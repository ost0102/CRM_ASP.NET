Imports System
Imports System.IO
Imports System.Reflection

Public Class RuntimeInfo
    Private Function GetConvertToDataSet(ByVal SearchType As String) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Select Case SearchType.ToString.ToUpper
                Case "ExecuteReconnect".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_EXECUTE", "SysRuntimeInfo@Search", True)
                    YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)

                    Dim dt As DataTable = ds.Tables("WG_DOMAIN").Copy
                    dt.TableName = "ConnectInfo"
                    YJSql.DataSet.Tables.Add(dt)

                Case "Execute".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_EXECUTE", "SysRuntimeInfo@Search", True)
                    YJSql.Params("SQLEXECUTE", S_EXECUTE.Text.ToString.Trim, False)
                Case "Domain".ToString.ToUpper
                    Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
                    YJSql.SqlBox("WG_DOMAIN", "SysRuntimeInfo@SearchDomain", True)
                    If Not String.IsNullOrEmpty(SavedSessionDomain) Then
                        Select Case SavedSessionDomain
                            Case "CRM.ELVIS.COM"
                                '전체검색
                            Case Else
                                YJSql.Params("DOMAIN", SavedSessionDomain.ToString.Trim, True)
                        End Select
                    End If
                Case Else
                    Throw New Exception("등록된 조회 조건이 없습니다. (GetConvertToDataSet)")
            End Select
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function

    Private Sub RuntimeInfo_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub RuntimeInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator({GV_HISTORY, GV_EXECUTE, GV_DOMAIN})

        Call showRuntimeInfo()

        Call SqlHistoryData()
        Call DomainData()
    End Sub

    Private Sub RuntimeInfo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub

    Private Sub showRuntimeInfo()
        '--------------Runtime--------------
        txtEnvPath.Text = System.Environment.CurrentDirectory & "\"
        txtAppPath.Text = Application.StartupPath & "\"
        txtReportPath.Text = Common.ReportPath
        txtWCFServer.Text = WCF.WCFBiz.Instance.ServerHomeUrl
        '--------------Live Updater--------------
        If Common.IsDeploymentMode Then
            'Read local manifest
            Dim sr As New StreamReader(txtAppPath.Text & "LocalManifest.inf")
            'First line is manifest url
            txtManifestUrl.Text = sr.ReadLine() & "Manifest.aspx"
        Else
            txtManifestUrl.Text = "N/A (Local Development Mode)"
        End If

        '--------------User session--------------
        txtUserID.Text = ClientSessionInfo.UserID
        txtDepartment.Text = ClientSessionInfo.OrganizationName
        txtOffice.Text = ClientSessionOfficeInfo.LocalName
        txtAuthLevel.Text = "" 'ClientSessionInfo.AuthorizationLevel


    End Sub

    Private Sub btnShowFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowFolder.Click
        Try
            Process.Start("explorer.exe", txtAppPath.Text)
        Catch ex As Exception
            MsgBox("Could not open this folder using Explorer!")
        End Try

    End Sub

    Private Sub btnEnvPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvPath.Click
        Try
            Process.Start("explorer.exe", txtEnvPath.Text)
        Catch ex As Exception
            MsgBox("Could not open this folder using Explorer!")
        End Try
    End Sub

    Private Sub btnLoadRecentSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRecentSql.Click
        txtRecentSql.Text = ""
        '--------------Sql log--------------
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Sys.RuntimeInfo", "GetRecentSqlLog", {}, AddressOf loadRecentSqlCompleted)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub loadRecentSqlCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        '//////Parsing WCF returned data///////
        Dim dsRet As DataSet = e.Result
        Dim drPairs As DataRow
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        txtRecentSql.Text = drPairs("RecentSqlLog")
    End Sub

    Private Sub btnLoadLoginList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadLoginList.Click
        txtRecentSql.Text = ""
        '--------------Sql log--------------
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Sys.RuntimeInfo", "GetLoginListLog", {}, AddressOf loadLoginListCompleted)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub loadLoginListCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        '//////Parsing WCF returned data///////
        Dim dsRet As DataSet = e.Result
        Dim drPairs As DataRow
        drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        txtRecentSql.Text = drPairs("LoginList")
    End Sub


    Private Sub btnRuntimeUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuntimeUpdate.Click
        txtRecentSql.Text = Common.RU_LogMessage.ToString
    End Sub

    Private Sub SqlHistory_Click(sender As System.Object, e As System.EventArgs) Handles btnSqlHistory.Click
        Call SqlHistoryData()
        'Private Sub btnLoadRecentSql_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRecentSql.Click
        '    txtRecentSql.Text = ""
        '    '--------------Sql log--------------
        '    Try
        '        YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Sys.RuntimeInfo", "GetRecentSqlLog", {}, AddressOf loadRecentSqlCompleted)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        Exit Sub
        '    End Try
        'End Sub

        'Private Sub loadRecentSqlCompleted(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        '    '//////Parsing WCF returned data///////
        '    Dim dsRet As DataSet = e.Result
        '    Dim drPairs As DataRow
        '    drPairs = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        '    txtRecentSql.Text = drPairs("RecentSqlLog")
        'End Sub
    End Sub


    Public Sub SqlHistoryData()
        Dim dsRet As DataSet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "GetRecentSqlLog", {})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Me.ClearView(UI.AppliedRangeTypes.All)

        Dim txtRecentSql As String = drPairs("RecentSqlLog")

        If Not String.IsNullOrEmpty(txtRecentSql) Then
            Dim dsSql As DataSet = New DataSet
            Dim dtSql As DataTable = New DataTable
            dtSql.TableName = "Data.WG_HISTORY"
            dtSql.Columns.Add("HISTORY_DATETIME", GetType(String))
            dtSql.Columns.Add("HISTORY_QUERY", GetType(String))
            Dim drSql As DataRow = Nothing

            dsSql.Tables.Add(dtSql)

            'Dim arrRecentSql() As string = mid(split(txtRecentSql,"#At:")(1),1,   instr(split(txtRecentSql,"#At:")(1),vbcrlf)  )
            Dim arrRecentSql() As String = Split(txtRecentSql, "#At:")
            For Each RecentSql As String In arrRecentSql
                If String.IsNullOrEmpty(RecentSql) Then Continue For
                drSql = dtSql.NewRow
                drSql("HISTORY_DATETIME") = Mid(RecentSql, 1, InStr(RecentSql, vbCrLf)).ToString.Trim
                drSql("HISTORY_QUERY") = Mid(RecentSql, InStr(RecentSql, vbCrLf) + 1).ToString.Trim.Replace(vbCr, "").Replace(vbLf, vbCrLf)
                dtSql.Rows.Add(drSql)
            Next

            Me.BindToDataset(dsSql, "Data")
        End If

        Me.DataState = UI.DataStates.None
    End Sub

    Private Sub GV_HISTORY_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_HISTORY.FocusedRowChanged
        If GV_HISTORY.RowCount = 0 Then Exit Sub
        If GV_HISTORY.FocusedRowHandle < 0 Then Exit Sub

        S_EXECUTE.Text = GV_HISTORY.GetFocusedRowCellValue("HISTORY_QUERY").ToString()
        GV_EXECUTE.Columns.Clear()
    End Sub

    Private Sub btnExecute_Click(sender As System.Object, e As System.EventArgs) Handles btnExecute.Click
        Call ExecuteData()
    End Sub
    Private Sub ExecuteData()
        If ExecuteValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet("Execute")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub


    Private Function ExecuteValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_EXECUTE.Text.ToString.Trim) Then
                If ErrControl Is Nothing Then ErrControl = S_EXECUTE
                ErrMsg &= "Please input the [Query]" & vbNewLine
            End If

            If S_EXECUTE.Text.ToString.StartsWith("-- " & Now.ToString("yyyyMMddHHmm") & " " & ClientSessionInfo.UserID) Then
                If MsgBoxLocalized("Oracle rollback is not possible. Do you want to execute?", vbYesNo, "Warning", MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                    ErrMsg &= "[Insert, Update, Delete, Create, Alter, Drop, Truncate, Grant, Revoke, Exec, Execuste, Merge] Character can not be used." & vbNewLine
                Else
                    If MsgBoxLocalized("Execute the query.", vbYesNo, "Warning", MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = MsgBoxResult.No Then
                        ErrMsg &= "[Insert, Update, Delete, Create, Alter, Drop, Truncate, Grant, Revoke, Exec, Execuste, Merge] Character can not be used." & vbNewLine
                    End If
                End If
            Else
                If S_EXECUTE.Text.ToString.ToUpper.Contains("INSERT") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("UPDATE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("DELETE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("CREATE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("ALTER") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("DROP") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("TRUNCATE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("GRANT") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("REVOKE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("EXEC") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("EXECUTE") _
                OrElse S_EXECUTE.Text.ToString.ToUpper.Contains("MERGE") Then
                    If ErrControl Is Nothing Then ErrControl = S_EXECUTE
                    ErrMsg &= "[Insert, Update, Delete, Create, Alter, Drop, Truncate, Grant, Revoke, Exec, Execuste, Merge] Character can not be used." & vbNewLine
                End If
            End If

            If Not String.IsNullOrEmpty(ErrMsg) Then
                If Not ErrControl Is Nothing Then ErrControl.Focus()
                Throw New Exception(ErrMsg)
            End If

            Return True
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Return False
        End Try
    End Function


    Private Sub GV_DOMAIN_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV_DOMAIN.FocusedRowChanged
        If GV_DOMAIN.RowCount = 0 Then Exit Sub
        If GV_DOMAIN.FocusedRowHandle < 0 Then Exit Sub

        S_DOMAIN.Text = GV_DOMAIN.GetFocusedRowCellValue("DOMAIN").ToString
    End Sub

    Private Sub btnDomain_Click(sender As System.Object, e As System.EventArgs) Handles btnDomain.Click
        Call DomainData()
    End Sub
    Private Sub DomainData()
        Dim dsRet As DataSet = GetConvertToDataSet("Domain")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DOMAIN})
                Me.BindToDataset(dsRet, "Data")
                'Case "N"
                '    Me.ClearView(UI.AppliedRangeTypes.Only, {WG_DOMAIN})
                '    MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                'MsgBoxLocalized(drPairs("TrxMsg"))
                S_DOMAIN.Visible = False
                btnExecuteReconnect.Visible = False
                SplitContainerControl3.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        End Select
    End Sub

    Private Sub GV_HISTORY_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GV_HISTORY.ShowingEditor
        '수정불가처리
        If GV_HISTORY.FocusedRowHandle >= 0 Then e.Cancel = True
    End Sub

    Private Sub GV_EXECUTE_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GV_EXECUTE.ShowingEditor
        '수정불가처리
        If GV_HISTORY.FocusedRowHandle >= 0 Then e.Cancel = True
    End Sub

    Private Sub GV_DOMAIN_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GV_DOMAIN.ShowingEditor
        '수정불가처리
        If GV_HISTORY.FocusedRowHandle >= 0 Then e.Cancel = True
    End Sub

    Private Sub GV_HISTORY_DoubleClick(sender As System.Object, e As System.EventArgs) Handles GV_HISTORY.DoubleClick
        Call ExecuteData()
    End Sub

    Private Sub btnExecuteReconnect_Click(sender As System.Object, e As System.EventArgs) Handles btnExecuteReconnect.Click

        If ExecuteValidate() = False Then Exit Sub

        For i As Integer = 0 To GV_DOMAIN.RowCount - 1
            GV_DOMAIN.GetDataRow(i).AcceptChanges()
            If GV_DOMAIN.GetDataRow(i)("DOMAIN").ToString = S_DOMAIN.Text.ToString Then
                GV_DOMAIN.GetDataRow(i).SetAdded()
            End If
        Next

        Dim dsRet As DataSet = GetConvertToDataSet("ExecuteReconnect")

        dsRet = MethodCallEx(Me, "YJIT.Sys.RuntimeInfo", "SearchReconnect", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                Me.BindToDataset(dsRet, "Data")
            Case "N"
                Me.ClearView(UI.AppliedRangeTypes.Only, {WG_EXECUTE})
                GV_EXECUTE.Columns.Clear()
                MsgBoxLocalized(drPairs("TrxMsg"))
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub

End Class