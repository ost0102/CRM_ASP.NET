Imports System
Imports System.Data
Imports System.Collections.Generic
Imports YJIT.Data

Namespace YJIT.WCF

    ''' <summary>
    ''' Provide system methods for smart client connection
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ClientService


        Public Shared Function SynchronizeUserSessionInfo(ByVal sUserID As String, ByVal ReqSvc As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim resDs As New DataSet
            Dim db As New DBA()
            Dim sql As SqlBox
            Dim dt As DataTable

            '1.First, authorize user
            resDs = SessionInfo.AuthorizeUser(sUserID)

            sql = New SqlBox("Login@SearchUserPgmAuth")
            sql.Params("UserID") = sUserID
            If ReqSvc = "ALL" Then
                sql.Blocks("DEFAULT_AUTH") = True
            Else
                Dim GRP_ID As String = ReqSvc
                sql.Params("GRP_ID") = GRP_ID
                sql.Blocks("SERVIECE_AUTH") = True
            End If
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "UserPgmAuthInfo"
            resDs.Tables.Add(dt)

            sql = New SqlBox("Login@SearchUserFuncAuth")
            sql.Params("UserID") = sUserID
            dt = db.SqlGet(sql.Text, False)
            dt.TableName = "UserFuncAuthInfo"
            resDs.Tables.Add(dt)

            '3.Call preload code list
            Call preloadCodeList(resDs)



            'Finally, return sync data to WCF client
            resultSet("TrxCode") = "SUCCESS"
            resultSet("TrxMsg") = "SUCCESS"
            resultSet("Data") = resDs
            Return resultSet
        End Function

        Private Shared Function SetCodeListName(ByVal CodeService As String, ByVal Dataparam As String) As String
            Dim NewName As String = "CodeList." & CodeService
            If Dataparam <> "" Then
                NewName &= "@" & Dataparam
            End If
            Return NewName
        End Function
        Private Shared Function GetCodeData(ByVal cs As YJIT.CodeService.CommonCode, ByVal CodeService As String, ByVal Dataparam As String) As DataTable
            Dim dt As DataTable = Nothing
            Dim dataParams As New Dictionary(Of String, Object)
            Dim dictTmp0 As New Dictionary(Of String, Object)


 
            'ex) Params = GroupCode:'A15',NameType:'A'
            Dim DataSplit() As String = Split(Dataparam, ",")
            For i = 0 To DataSplit.Length - 1
                If DataSplit(i).ToString <> "" Then
                    Dim Values() As String = Split(DataSplit(i), ":")
                    Try
                        dataParams.Add(Values(0), Values(1).Replace("'", ""))
                    Catch ex As Exception

                    End Try
                End If
            Next
            Try
                dt = cs.List(dictTmp0, dataParams, False)("Data")
                dt.TableName = SetCodeListName(CodeService, Dataparam)    '"CodeList.CommonCode@GroupCode:'A05,NameType:'B'"

            Catch ex As Exception
                'Currently not handle this
            End Try
            Return dt
        End Function
        Private Shared Sub preloadCodeList(ByVal cs As YJIT.Web.UI.WebControls.CodeBox.CodeService, ByVal dsRet As DataSet, ByVal CodeList As ArrayList)

            Dim CodeService As String = cs.ToString.Remove(0, cs.ToString.LastIndexOf(".") + 1)
            For index = 0 To CodeList.Count - 1

                Dim DataParam As String = CodeList(index)
                Dim dt As DataTable
                dt = GetCodeData(cs, CodeService, DataParam)
                If Not dt Is Nothing Then
                    If Not dsRet.Tables.Contains(dt.TableName) Then
                        dsRet.Tables.Add(dt)
                    End If

                End If

            Next
        End Sub

        Private Shared Sub preloadCodeList(ByVal dsRet As DataSet)

            Dim db As New DBA()
            Dim sql As SqlBox

            Dim CodeList As New ArrayList
            Dim cs As YJIT.Web.UI.WebControls.CodeBox.CodeService

            cs = New YJIT.CodeService.CommonCode


            ''=================================================
            ''Air
            ''==================================================
            ''Shipment
            'CodeList.Add("GroupCode:'A15',NameType:'A'")
            ''Co-Load Type
            'CodeList.Add("GroupCode:'M37',NameType:'A'")
            ''B/L Type
            'CodeList.Add("GroupCode:'A06',NameType:'A'")

            'preloadCodeList(cs, dsRet, CodeList)


            Dim dt As DataTable
            Dim dictTmp As New Dictionary(Of String, Object)

            Try
                '## Common Code
                Sql = New SqlBox("MdmCommonMgt@SearchPreloadCommonCode")
                dt = db.SqlGet(Sql.Text, False)
                If Not dt Is Nothing Then
                    dt.TableName = "TableList.MDM_COM_CODE"
                    dsRet.Tables.Add(dt)
                End If
            Catch ex As Exception
                '오류없이 넘기도록 처리
            End Try

            Try
                sql = New SqlBox("MdmUserMgt@Search")
                sql.Params("OFFICE_CD") = SessionInfo.OfficeCode
                sql.Params("LANG_CD") = SessionOfficeInfo.LanguageCode
                sql.Params("USE_YN") = "Y"
                sql.Blocks("USE_YN") = True
                dt = db.SqlGet(sql.Text, False)
                If Not dt Is Nothing Then
                    dt.TableName = "TableList.CRM_USR_MST"
                    dsRet.Tables.Add(dt)
                End If
            Catch ex As Exception
                '오류없이 넘기도록 처리
            End Try

            Try
                sql = New SqlBox("MdmMappingMgt@Search")
                dt = db.SqlGet(sql.Text, False)
                If Not dt Is Nothing Then
                    dt.TableName = "TableList.MDM_MAPPING_MST"
                    dsRet.Tables.Add(dt)
                End If
            Catch ex As Exception
                '오류없이 넘기도록 처리
            End Try

            Try
                sql = New SqlBox("MdmUserMgt@Search")
                dt = db.SqlGet(sql.Text, False)
                If Not dt Is Nothing Then
                    dt.TableName = "TableList.CRM_USR_MST"
                    dsRet.Tables.Add(dt)
                End If
            Catch ex As Exception
                '오류없이 넘기도록 처리
            End Try

        End Sub

        Shared Function WCF_UPLOAD_DIR() As String
            Throw New NotImplementedException
        End Function

    End Class

End Namespace
