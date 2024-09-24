Imports System
Imports System.IO
Imports System.Data
Imports System.Collections.Generic

Imports YJIT.Data
Imports YJIT.Utils


Namespace YJIT.Sys

    Public Class SysSmartHelp

        Public Shared Function GetHelpRoots() As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysSmartHelp@GetRoots")
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "HelpRoots"
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

        Public Shared Function GetChildNodes(ByVal sNodeID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysSmartHelp@GetChildNodes")
                sql.Params("PARENT_NODE_ID") = sNodeID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "ChildNodes"
                dsRet.Tables.Add(dt)


                resultSet("Data") = dsRet
                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Operation completed successful!"
            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function AddNewNode(ByVal sNodeType As String, ByVal sParentID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysSmartHelp@GetNewNodeID")
                sql.Params("NODE_TYPE") = sNodeType
                dt = db.SqlGet(sql.Text, False)
                Dim sNewID As String = dt.Rows(0)("NEW_ID")

                sql = New SqlBox("SysSmartHelp@InsertNode")

                sql.Params("NODE_ID") = sNewID
                sql.Params("NODE_TYPE") = sNodeType
                sql.Params("PARENT_NODE_ID") = sParentID
                sql.Params("TITLE") = sNewID
                sql.Params("CONTENT") = ""
                sql.Params("INS_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                'Get inserted node info
                sql = New SqlBox("SysSmartHelp@GetNode")
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
                sql = New SqlBox("SysSmartHelp@UpdateNodeTitle")
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

        Public Shared Function GetNode(ByVal sNodeID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysSmartHelp@GetNode")
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
                    resultSet("TrxMsg") = "Operation completed successful!"
                End If

            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function GetNodeProperties(ByVal sNodeID As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            Try

                sql = New SqlBox("SysSmartHelp@GetNodeProperties")
                sql.Params("NODE_ID") = sNodeID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "NodeData"
                dsRet.Tables.Add(dt)

                If dt.Rows.Count = 0 Then
                    resultSet("TrxCode") = "NODATA"
                    resultSet("TrxMsg") = "Help node not found!"
                Else
                    resultSet("TrxCode") = "SUCCESS"
                    resultSet("TrxMsg") = "Operation completed successful!"
                End If

                'Get Display Seq in parent
                sql = New SqlBox("SysSmartHelp@GetNodeOrderInParent")
                sql.Params("NODE_ID") = sNodeID
                dt = db.SqlGet(sql.Text, False)
                dt.TableName = "WG1"
                dsRet.Tables.Add(dt)

                resultSet("Data") = dsRet
            Catch ex As Exception
                resultSet("TrxCode") = "ERROR"
                resultSet("TrxMsg") = "Error occured! " & ex.Message
            End Try

            Return resultSet
        End Function

        Public Shared Function UpdateNodeContent(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox


            Dim drNode As DataRow
            drNode = ds.Tables("NodeInfo").Rows(0)
            ' ==============VALIDATION========================


            ' ==============BEGIN UPDATE========================
            Try
                db.BeginTransaction()

                sql = New SqlBox("SysSmartHelp@UpdateNodeContent")
                sql.Params("NODE_ID") = drNode("NODE_ID")
                sql.Params("MSG_CONTENT") = Mid(drNode("CONTENT"), 1, 30000)
                sql.Params("MSG_CONTENT2") = Mid(drNode("CONTENT"), 30001, 60000)
                sql.Params("MSG_CONTENT3") = Mid(drNode("CONTENT"), 60001)

                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
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

        Public Shared Function DeleteNode(ByVal sNodeID As String, ByVal sNodeType As String) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox

            ' ==============VALIDATION========================
            'We dont support deleting group node with sub group/folder insdie
            'We support deleting group node with sub node/files only
            'If sNodeType = "G" OrElse sNodeType = "R" Then
            sql = New SqlBox("SysSmartHelp@CheckNodeForDelete")
            sql.Params("NODE_ID") = sNodeID
            dt = db.SqlGet(sql.Text, False)

            If dt.Rows.Count > 0 Then
                'This group node contains sub group node(s) => Failed
                resultSet("TrxCode") = "FAILED"
                resultSet("TrxMsg") = "Could not delete group which contains sub group(s)! Process cancelled!"
                Return resultSet
            End If
            'End If

            ' ==============BEGIN UPDATE========================
            Try
                db.BeginTransaction()
                sql = New SqlBox("SysSmartHelp@DeleteNode")
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

        Public Shared Function UpdateNodeProperties(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Dim resultSet As New Dictionary(Of String, Object)
            Dim dsRet As New DataSet
            Dim db As DBA = New DBA()
            Dim dt As New DataTable
            Dim sql As SqlBox


            Dim drNode As DataRow
            drNode = ds.Tables("MAIN").Rows(0)

            dt = ds.Tables("WG1")
            ' ==============VALIDATION========================


            ' ==============BEGIN UPDATE========================
            Try
                db.BeginTransaction()

                'Update node title
                sql = New SqlBox("SysSmartHelp@UpdateNodeTitle")
                sql.Params("NODE_ID") = drNode("NODE_ID")
                sql.Params("TITLE") = drNode("TITLE")
                sql.Params("UPD_USR") = YJIT.SessionInfo.UserID
                db.SqlSet(sql.Text)


                'Update Displaying Seq
                For Each dr As DataRow In dt.Rows
                    sql = New SqlBox("SysSmartHelp@UpdateNodeDisplaySeq")
                    sql.Params("DISPLAY_SEQ") = dr("DISPLAY_SEQ")
                    sql.Params("NODE_ID") = dr("NODE_ID")
                    db.SqlSet(sql.Text)
                Next


                resultSet("TrxCode") = "SUCCESS"
                resultSet("TrxMsg") = "Update successful!"

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
