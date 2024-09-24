Imports System
Imports System.IO
Imports System.Data
Imports System.Data.OracleClient
Imports System.Collections.Generic
Imports YJIT.Data
Imports YJIT.Utils


Namespace YJIT.Sys

    Public Class SysHelpMgt

        '20240300 김정현 ELVIS21 버전 FAQ 추가 (SYS DB 사용 관련 코드 추가)
        Public Shared Function UpdateTitle(ByVal nodeId As String, ByVal title As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            ' ==============BEGIN UPDATE========================
            Try

                db.BeginTransaction()

                sql = New SqlBox("SysHelpMgt@UpdateTitle")
                sql.Params("NODE_ID") = nodeId
                sql.Params("TITLE") = title
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

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

            Return resultSet

        End Function

        Public Shared Function UpdateTitle_Sys(ByVal nodeId As String, ByVal title As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim sql As SqlBox
            Dim drHeader As DataRow = ds.Tables("Main").Rows(0)
            Dim ErrorOccur As Boolean = True
            'Dim dbCom As New YJIT.BIZ.dbCommon
            'dbCom.SetConnection(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            Try
                dbCom.BeginTransaction()
                sql = New SqlBox("SysHelpMgt@UpdateTitleSys")
                sql.Params("NODE_ID") = nodeId
                sql.Params("TITLE") = title
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                dbCom.SqlSet(sql.Text)

                dbCom.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                dbCom.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                dbCom.EndTransaction()
            End Try

            Return resultSet
        End Function
        Public Shared Function ChangeParentNode(ByVal NodeId As String, ByVal ChangeParentId As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True

            ' ==============BEGIN UPDATE========================
            Try

                db.BeginTransaction()

                sql = New SqlBox("SysHelpMgt@ChangeParentNode")
                sql.Params("NODE_ID") = NodeId
                sql.Params("PARENT_NODE_ID") = ChangeParentId
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

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

            Return resultSet

        End Function
        Public Shared Function ChangeParentNode_Sys(ByVal NodeId As String, ByVal ChangeParentId As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim ErrorOccur As Boolean = True
            'Dim dbCom As New YJIT.BIZ.dbCommon
            Dim drHeader As DataRow = ds.Tables("Main").Rows(0)

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            'dbCom.SetConnection(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)

            ' ==============BEGIN UPDATE========================
            Try

                dbCom.BeginTransaction()

                sql = New SqlBox("SysHelpMgt@ChangeParentNodeSys")
                sql.Params("NODE_ID") = NodeId
                sql.Params("PARENT_NODE_ID") = ChangeParentId
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                dbCom.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

                dbCom.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                dbCom.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                dbCom.EndTransaction()
            End Try
            Return resultSet
        End Function
        Public Shared Function DeleteNode(ByVal sNodeID As String, ByVal sNodeType As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim DirectoryName As String = ""

            ' ==============VALIDATION========================
            sql = New SqlBox("SysHelpMgt@CheckNodeForDelete")
            sql.Params("NODE_ID") = sNodeID
            dt = db.SqlGet(sql.Text, False)
            If dt.Rows.Count > 0 Then
                resultSet("TrxCode") = "FAILED"
                resultSet("TrxMsg") = "Could not delete group which contains sub group(s)! Process cancelled!"
                Return resultSet
            End If

            ' ==============BEGIN UPDATE========================
            Try
                db.BeginTransaction()

                'Image file delete
                sql = New SqlBox("SysHelpMgt@GetChildNodes")
                sql.Params("NODE_ID") = sNodeID
                dt = db.SqlGet(sql.Text, False)
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DirectoryName = HttpContext.Current.Server.MapPath("FAQ\Data\" & dt.Rows(i)("NODE_ID").ToString & "_files")
                        If System.IO.Directory.Exists(DirectoryName) Then
                            Dim picList As String() = System.IO.Directory.GetFiles(DirectoryName, "*.*")
                            For Each f As String In picList
                                System.IO.File.Delete(f)
                            Next
                            System.IO.Directory.Delete(DirectoryName)
                        End If
                    Next
                End If

                sql = New SqlBox("SysHelpMgt@DeleteNode")
                sql.Params("NODE_ID") = sNodeID
                db.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

                db.Commit()
            Catch ex As Exception
                db.Rollback()
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet
        End Function

        Public Shared Function DeleteNode_Sys(ByVal sNodeID As String, ByVal sNodeType As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim DirectoryName As String = ""

            Dim drHeader As DataRow = ds.Tables("Main").Rows(0)
            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            ' ==============VALIDATION========================
            sql = New SqlBox("SysHelpMgt@CheckNodeForDeleteSys")
            sql.Params("NODE_ID") = sNodeID
            dt = dbCom.SqlGet(sql.Text)
            If dt.Rows.Count > 0 Then
                resultSet("TrxCode") = "FAILED"
                resultSet("TrxMsg") = "Could not delete group which contains sub group(s)! Process cancelled!"
                Return resultSet
            End If

            ' ==============BEGIN UPDATE========================
            Try
                'Image file delete
                sql = New SqlBox("SysHelpMgt@GetChildNodesSys")
                sql.Params("NODE_ID") = sNodeID
                dt = dbCom.SqlGet(sql.Text)
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        DirectoryName = HttpContext.Current.Server.MapPath("FAQ21\Data\" & dt.Rows(i)("NODE_ID").ToString & "_files")
                        If System.IO.Directory.Exists(DirectoryName) Then
                            Dim picList As String() = System.IO.Directory.GetFiles(DirectoryName, "*.*")
                            For Each f As String In picList
                                System.IO.File.Delete(f)
                            Next
                            System.IO.Directory.Delete(DirectoryName)
                        End If
                    Next
                End If

                dbCom.BeginTransaction()
                sql = New SqlBox("SysHelpMgt@DeleteNodeSyS")
                sql.Params("NODE_ID") = sNodeID
                dbCom.SqlSet(sql.Text)
                dbCom.Commit()

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

            Catch ex As Exception
                dbCom.Rollback()
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                dbCom.EndTransaction()
            End Try

            Return resultSet
        End Function
        Public Shared Function UpdateContent(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim drHeader As DataRow
            Dim ErrorOccur As Boolean = True

            drHeader = ds.Tables("MAIN").Rows(0)
            ' ==============BEGIN UPDATE========================
            Try

                db.BeginTransaction()

                sql = New SqlBox("SysHelpMgt@UpdateContent")
                sql.Params("NODE_ID") = drHeader("NODE_ID").ToString
                sql.Params("NODE_TYPE") = drHeader("NODE_TYPE").ToString
                sql.Params("PARENT_NODE_ID") = drHeader("PARENT_NODE_ID").ToString
                sql.Params("TITLE") = drHeader("TITLE").ToString
                sql.Params("CONTENT") = drHeader("CONTENT").ToString
                sql.Params("LANG_CD") = drHeader("LANG_CD").ToString
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

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

            Return resultSet

        End Function

        Public Shared Function UpdateContent_Sys(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim dt As New DataTable
            Dim sql As SqlBox
            Dim drHeader As DataRow = ds.Tables("Main").Rows(0)
            Dim ErrorOccur As Boolean = True

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            ' ==============BEGIN UPDATE========================
            Try

                dbCom.BeginTransaction()

                sql = New SqlBox("SysHelpMgt@UpdateContentSys")
                sql.Params("NODE_ID") = drHeader("NODE_ID").ToString
                sql.Params("NODE_TYPE") = drHeader("NODE_TYPE").ToString
                sql.Params("PARENT_NODE_ID") = drHeader("PARENT_NODE_ID").ToString
                sql.Params("TITLE") = drHeader("TITLE").ToString
                sql.Params("CONTENT") = drHeader("CONTENT").ToString
                sql.Params("LANG_CD") = drHeader("LANG_CD").ToString
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                dbCom.SqlSet(sql.Text)

                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

                dbCom.Commit()

                resultSet("TrxCode") = "Y"
                resultSet("TrxMsg") = "Success"

            Catch ex As Exception
                dbCom.Rollback()
                If ErrorOccur Then resultSet("TrxCode") = "E" Else resultSet("TrxCode") = "N"
                resultSet("TrxMsg") = ex.Message
            Finally
                dbCom.EndTransaction()
            End Try
            Return resultSet
        End Function
        Public Shared Function GetNodeList(ByVal SearchKey As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysHelpMgt@GetNodeList")
                sql.Params("SEARCH_KEY") = SearchKey
                If SearchKey <> "" Then sql.Blocks("SEARCH_KEY") = True

                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "ViewTree"
                dsRet.Tables.Add(dt)
                resultSet("Data") = dsRet

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Help projects not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function GetNodeList_Sys(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim sql As SqlBox
            Dim dt As New DataTable
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            Try
                sql = New SqlBox("SysHelpMgt@GetNodeListSyS")
                sql.Params("SEARCH_KEY") = drHeader("SEARCH_KEY").ToString
                If Trim(drHeader("SEARCH_KEY").ToString) <> "" Then sql.Blocks("SEARCH_KEY") = True

                dt = dbCom.SqlGet(sql.Text)
                dt.TableName = "ViewTree"
                If dt.DataSet IsNot Nothing Then
                    dt.DataSet.Tables.Remove(dt)
                End If
                dsRet.Tables.Add(dt)
                resultSet("Data") = dsRet

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Help projects not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try
            Return resultSet
        End Function


        Public Shared Function GetNode_Sys(ByVal sNodeId As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim sql As SqlBox
            Dim dt As New DataTable
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            Try
                sql = New SqlBox("SysHelpMgt@GetNodeSys")
                sql.Params("NODE_ID") = sNodeId
                dt = dbCom.SqlGet(sql.Text)
                dt.TableName = "NodeData"
                If dt.DataSet IsNot Nothing Then
                    dt.DataSet.Tables.Remove(dt)
                End If
                dsRet.Tables.Add(dt)
                resultSet("Data") = dsRet

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Help node not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function GetNode(ByVal sNodeID As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try
                sql = New SqlBox("SysHelpMgt@GetNode")
                sql.Params("NODE_ID") = sNodeID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "NodeData"
                dsRet.Tables.Add(dt)
                resultSet("Data") = dsRet

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Help node not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Success"
                End If

            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function AddNewNode_Sys(ByVal sNodeType As String, ByVal sParentId As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim sql As SqlBox
            Dim dt As New DataTable
            Dim drHeader As DataRow = ds.Tables("MAIN").Rows(0)

            Dim strConn As String = YJIT.BIZ.Common.GetConnectionString(drHeader("S_IP").ToString, drHeader("S_PORT").ToString, drHeader("S_SID").ToString, drHeader("S_USER_ID").ToString, drHeader("S_PASSWORD").ToString)
            Dim dbCom As DBA = New DBA(strConn, "ORACLE")

            Try
                sql = New SqlBox("SysHelpMgt@GetNewNodeIDSys")
                sql.Params("NODE_TYPE") = sNodeType
                dt = dbCom.SqlGet(sql.Text)
                If dt.DataSet IsNot Nothing Then
                    dt.DataSet.Tables.Remove(dt)
                End If
                Dim sNewID As String = dt.Rows(0)("NEW_ID")

                dbCom.BeginTransaction()
                sql = New SqlBox("SysHelpMgt@InsertNodeSys")
                sql.Params("NODE_ID") = sNewID
                sql.Params("NODE_TYPE") = sNodeType
                sql.Params("PARENT_NODE_ID") = sParentId
                sql.Params("TITLE") = sNewID
                sql.Params("CONTENT") = ""
                sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                dbCom.SqlSet(sql.Text)
                dbCom.Commit()
                dbCom.EndTransaction()

                'Get inserted node info
                sql = New SqlBox("SysHelpMgt@GetNodeSys")
                sql.Params("NODE_ID") = sNewID
                dt = dbCom.SqlGet(sql.Text)
                dt.TableName = "NodeInfo"
                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "ERROR"
                    resultSet("TrxMsg") = "Failed to insert!"
                Else
                    If dt.DataSet IsNot Nothing Then
                        dt.DataSet.Tables.Remove(dt)
                    End If
                    dsRet.Tables.Add(dt)
                    resultSet("Data") = dsRet

                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Operation completed successfully!"
                End If
            Catch ex As Exception
                dbCom.Rollback()
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                dbCom.EndTransaction()
            End Try

            Return resultSet
        End Function

        Public Shared Function AddNewNode(ByVal sNodeType As String, ByVal sParentID As String, ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try
                sql = New SqlBox("SysHelpMgt@GetNewNodeID")
                sql.Params("NODE_TYPE") = sNodeType
                dt = db.SqlGet(sql.Text, False)
                Dim sNewID As String = dt.Rows(0)("NEW_ID")

                sql = New SqlBox("SysHelpMgt@InsertNode")

                sql.Params("NODE_ID") = sNewID
                sql.Params("NODE_TYPE") = sNodeType
                sql.Params("PARENT_NODE_ID") = sParentID
                sql.Params("TITLE") = sNewID
                sql.Params("CONTENT") = ""
                sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                'Get inserted node info
                sql = New SqlBox("SysHelpMgt@GetNode")
                sql.Params("NODE_ID") = sNewID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "NodeInfo"

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "ERROR"
                    resultSet("TrxMsg") = "Failed to insert!"
                Else
                    dsRet.Tables.Add(dt)
                    resultSet("Data") = dsRet

                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Operation completed successfully!"
                End If
            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function UpdateNodeTitle(ByVal sNodeID As String, ByVal sNodeTitle As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox
            ' ==============VALIDATION========================


            ' ==============BEGIN UPDATE========================
            Try
                db.BeginTransaction()
                sql = New SqlBox("SysHelpMgt@UpdateNodeTitle")
                sql.Params("TITLE") = sNodeTitle
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                sql.Params("NODE_ID") = sNodeID
                db.SqlSet(sql.Text)


                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"

                db.Commit()
            Catch ex As Exception
                db.Rollback()

                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            Finally
                db.EndTransaction()
            End Try

            Return resultSet
        End Function
    End Class

End Namespace
