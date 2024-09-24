'****************************************************************************
' 작 성 자  : 박건태
' 작 성 일  : 2021-01-21
' 파일설명  : 안전운임제 CRM에서 관리
' 파 일 명  : TmsTrfMgt.vb
' 특이사항  : 

' 수 정 일 / 수정자 / 요청업체 / 수정내용 
'****************************************************************************

'****************************************************************************

Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Exception
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.BIZ.Common

Namespace YJIT.BIZ

    Public Class TmsTrfMgt

        Public Shared Function SearchWG1(ByVal TRF_TYPE As String, ByVal FR_PORT As String, ByVal ONEWAY_DEPOT As String,
                                         ByVal CITY As String, ByVal STREET As String, ByVal FR_DISTANCE As String, ByVal TO_DISTANCE As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ResultDs As DataSet = New DataSet
            'Dim drHeader As DataRow
            Dim db As DBA = New DBA()
            Dim ErrorOccur As Boolean = True

            'If Not ds.Tables.Contains("MAIN") Then ThrowMsg(ErrorOccur, "Data info missing.")
            'drHeader = ds.Tables("MAIN").Rows(0)

            Try
                Dim sql As New SqlBox("TmsTrfMgt@SearchWG1")

                With sql
                    .Params("LANG_CD") = SessionOfficeInfo.LanguageCode
                    .Params("TRF_TYPE") = TRF_TYPE
                    .Params("FR_PORT") = FR_PORT
                    .Params("ONEWAY_DEPOT") = ONEWAY_DEPOT
                    .Params("CITY") = CITY
                    .Params("STREET") = STREET
                    .Params("FR_DISTANCE") = FR_DISTANCE
                    .Params("TO_DISTANCE") = TO_DISTANCE

                    If Trim(TRF_TYPE) <> "" Then .Blocks("TRF_TYPE") = True
                    If Trim(FR_PORT) <> "" Then .Blocks("FR_PORT") = True
                    If Trim(ONEWAY_DEPOT) <> "" Then .Blocks("ONEWAY_DEPOT") = True
                    If Trim(CITY) <> "" Then .Blocks("CITY") = True
                    If Trim(STREET) <> "" Then .Blocks("STREET") = True
                    If CDec(FR_DISTANCE) > 0 Then .Blocks("FR_DISTANCE") = True
                    If CDec(TO_DISTANCE) > 0 Then .Blocks("TO_DISTANCE") = True
                End With

                Dim dt As DataTable = db.SqlGet(sql.Text, False)

                If dt.Rows.Count = 0 Then
                    ThrowMsg(ErrorOccur, "Data not found!")
                End If

                dt.TableName = "WG1"
                ResultDs.Tables.Add(dt)

                resultSet("Data") = ResultDs

                '성공 유무의 메세지는 생략.
                resultSet("TrxMsg") = "Success"
                resultSet("Data") = ResultDs
                resultSet("TrxCode") = "Y"

            Catch ex As Exception
                If ErrorOccur Then
                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            End Try

            Return resultSet
        End Function


        Public Shared Function SaveWG1(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim db As DBA = New DBA()
            'Dim drHeader As DataRow
            Dim dtDetail As DataTable
            Dim sql As SqlBox = Nothing
            Dim Session As HttpSessionState = HttpContext.Current.Session
            Dim resultSet As New Dictionary(Of String, Object)
            Dim ErrorOccur As Boolean = True


            db.BeginTransaction()
            Try
                '== WG1 그리드 저장
                dtDetail = ds.Tables("WG1")
                Dim rowCount As Integer = 0

                For Each drDetail As DataRow In dtDetail.Rows
                    Select Case drDetail("_INSFLAG")
                        Case "I"
                            sql = New SqlBox("TmsTrfMgt@InsertWG1")
                            sql.Params("INS_USRID") = YJIT.SessionInfo.UserID
                        Case "U"
                            sql = New SqlBox("TmsTrfMgt@UpdateWG1")
                            sql.Params("UPD_USRID") = YJIT.SessionInfo.UserID
                        Case "D"
                            sql = New SqlBox("TmsTrfMgt@DeleteWG1")
                            sql.Params("DEL_USRID") = YJIT.SessionInfo.UserID
                        Case Else
                            Continue For
                    End Select
                    sql.Params("TRF_TYPE") = drDetail("TRF_TYPE").ToString & ""
                    sql.Params("FR_PORT") = drDetail("FR_PORT").ToString & ""
                    sql.Params("ONEWAY_DEPOT") = drDetail("ONEWAY_DEPOT").ToString & ""
                    sql.Params("CITY") = drDetail("CITY").ToString & ""
                    sql.Params("STREET") = drDetail("STREET").ToString & ""
                    sql.Params("DISTANCE") = drDetail("DISTANCE").ToString & ""
                    sql.Params("AMT_40F") = drDetail("AMT_40F").ToString & ""
                    sql.Params("AMT_40F_CSM") = drDetail("AMT_40F_CSM").ToString & ""
                    sql.Params("AMT_20F") = drDetail("AMT_20F").ToString & ""
                    sql.Params("AMT_20F_CSM") = drDetail("AMT_20F_CSM").ToString & ""

                    '== 값이 없을 경우 IS NULL 문구 삽입을 위해 블럭 처리 (UPDATE, DELETE 문)
                    If Trim(drDetail("FR_PORT").ToString & "") <> "" Then
                        sql.Blocks("FR_PORT") = True
                    Else
                        sql.Blocks("FR_PORT_NULL") = True
                    End If
                    If Trim(drDetail("ONEWAY_DEPOT").ToString & "") <> "" Then
                        sql.Blocks("ONEWAY_DEPOT") = True
                    Else
                        sql.Blocks("ONEWAY_DEPOT_NULL") = True
                    End If
                    If Trim(drDetail("CITY").ToString & "") <> "" Then
                        sql.Blocks("CITY") = True
                    Else
                        sql.Blocks("CITY_NULL") = True
                    End If
                    If Trim(drDetail("STREET").ToString & "") <> "" Then
                        sql.Blocks("STREET") = True
                    Else
                        sql.Blocks("STREET_NULL") = True
                    End If

                    db.SqlSet(sql.Text)
                    rowCount += 1

                Next

                db.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                db.Rollback()
                If ErrorOccur Then

                    resultSet("TrxCode") = "E"
                Else
                    resultSet("TrxCode") = "N"
                End If
                resultSet("TrxMsg") = ex.Message
            Finally
                db.EndTransaction()
            End Try

            'ResultSet("Data") = Search(ds)("Data")
            Return resultSet
        End Function

    End Class
End Namespace
