Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Imports System.Data
Imports YJIT.Biz.Common
Imports System.Collections.Generic
Imports YJIT.Data

Imports My
Imports System.IO
Imports System.Diagnostics

Namespace YJIT.Biz
    Public Class SysMenuMgt
        Public Shared Function Search(ByVal sys_id As String, ByVal Pgm_Grp As String, ByVal Pgm_id As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As DataSet = New DataSet
            Dim db As DBA = New DBA()

            Try
                'Program Management에서 사용하는 쿼리를 같이 사용함
                Dim sql As SqlBox
                sql = New SqlBox("SysMenuMgt@Search")
                sql.Params("SYS_ID") = sys_id.Trim
                sql.Params("PGM_GRP") = Pgm_Grp.Trim
                sql.Params("PGM_ID") = Pgm_id.Trim

                If Pgm_Grp.Trim <> "" Then
                    sql.Blocks("PGM_GRP") = True
                End If

                If Pgm_id.Trim <> "" Then
                    sql.Blocks("PGM_ID") = True
                End If

                Dim dt As DataTable
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                resDs.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Data not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                Throw ex
            End Try

            resultSet("Data") = resDs

            Return resultSet
        End Function

        Public Shared Function SearchMenuTree(ByVal OfficeCode As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDs As DataSet = New DataSet
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            Try
                Dim sql As New SqlBox("SysMenuMgt@SearchMenuTree")
                sql.Params("OFFICE_CD") = OfficeCode
                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                dt.TableName = "MenuTree"
                resultDs.Tables.Add(dt)
                resultSet("Data") = resultDs

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "Data not found!"
                Else
                    resultSet("TrxCode") = "Y"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function

        'Save Data
        Public Shared Function Save(ByVal OfficeCode As String, ByVal ds As DataSet, ByVal localPath As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resultDS As DataSet = New DataSet
            Dim db As DBA = New DBA()

            Dim sql As SqlBox = Nothing
            Dim dtMenu As DataTable = ds.Tables("MenuTree")
            Dim ErrorOccur As Boolean = True

            Try
                db.BeginTransaction()

                If dtMenu Is Nothing Then
                    ThrowMsg(ErrorOccur, "Data info missing.")
                End If

                'Delete & Insert
                sql = New SqlBox("SysMenuMgt@Delete")
                sql.Params("OFFICE_CD") = OfficeCode
                db.SqlSet(sql.Text)

                'Insert
                For Each dr As DataRow In dtMenu.Rows
                    If dr.RowState = DataRowState.Deleted Then Continue For '삭제된 row는 처리하지 않음

                    sql = New SqlBox("SysMenuMgt@Insert")

                    sql.Params("OFFICE_CD") = OfficeCode
                    sql.Params("MENU_CD") = dr("NEW_MENU")
                    sql.Params("UPPER_MENU_CD") = dr("NEW_UPPER")
                    sql.Params("FORM_ID") = dr("FORM_ID")
                    sql.Params("FORM_NM") = dr("FORM_NM")
                    sql.Params("FORM_TAG") = dr("FORM_TAG")
                    sql.Params("GRP_TAG") = dr("GRP_TAG")
                    sql.Params("CONVERT_ID") = dr("CONVERT_ID")

                    sql.Params("RMK") = dr("RMK")
                    sql.Params("USE_YN") = "Y"
                    sql.Params("USR_ID") = YJIT.SessionInfo.UserID

                    db.SqlSet(sql.Text)
                Next

                ' Hjkim : 2017-08-25 : HqOffice 정보 화면에 있는 정보 이용
                '=================================================
                FormFileCreate(db, localPath, OfficeCode)
                ' ================================================

                db.Commit()
                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"
            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            resultSet("Data") = SearchMenuTree(OfficeCode)("Data")
            Return resultSet

        End Function

        ' File Create
        Public Shared Function FormFileCreate(ByVal db As DBA, ByVal localPath As String, ByVal hqOffice As String) As String

            Dim ErrorOccur As Boolean = True

            Dim dt As DataTable
            Dim sql As SqlBox = Nothing
            Dim proParams As New Dictionary(Of String, Object)

            Dim insFlag As String = Nothing
            Dim officeCd As String = Nothing
            Dim returnMsg As String = "Y"

            Try

                ' Convert List
                sql = New SqlBox("SysMenuMgt@SearchConvertList")

                'sql.Params("HQ_OFFICE_CD") = YJIT.SessionOfficeInfo.HqOfficeCode
                sql.Params("HQ_OFFICE_CD") = hqOffice

                dt = db.SqlGet(sql.Text, False)

                ' ==================================================================
                Dim formList As New StringBuilder

                formList.AppendLine("[" & hqOffice & "]")
                For Each dr As DataRow In dt.Rows
                    formList.AppendLine(dr("FORM_ID").ToString)
                Next

                '===============================파일작성========================================
                '파일 생성 변수 선언
                Dim fileName As String = ""
                Dim filePath As String = ""
                Dim sTxtByte As Byte()
                'Dim hqOffice As String = YJIT.SessionOfficeInfo.HqOfficeCode
                Dim domainName As String = YJIT.SessionOfficeInfo.Domain

                Try

                    If localPath = "Server" Then
                        filePath = System.AppDomain.CurrentDomain.BaseDirectory & "WCF\Client\Bin\OfficeConfig\" & domainName
                    Else
                        filePath = localPath & "\OfficeConfig\" & domainName
                    End If

                    Computer.FileSystem.CreateDirectory(filePath)
                    fileName = filePath & "\" & hqOffice & ".dat"

                    Dim fs As New FileStream(fileName, FileMode.Create, FileAccess.Write)

                    'ANSI로 인코딩한 후에 저장
                    sTxtByte = Encoding.Default.GetBytes(formList.ToString)
                    fs.Write(sTxtByte, 0, sTxtByte.Length)
                    fs.Close()

                Catch ex As Exception
                    ThrowMsg(ErrorOccur, "EDI 파일작성 중 오류가 발생하였습니다. 파일명 (" & fileName & ")")
                End Try
                '================================================================================

            Catch ex As Exception
                returnMsg = ex.Message
            End Try

            Return returnMsg

        End Function



    End Class
End Namespace
