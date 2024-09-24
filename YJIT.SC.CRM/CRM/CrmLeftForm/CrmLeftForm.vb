Imports System
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class CrmLeftForm
    'Public mainForm As Object = Nothing
    Dim second As Integer = 0
    Dim MaxInterval As Integer = 0
    Dim REQ_SVC2_dt As DataTable
    Dim ShownFlag As Boolean = True
    Dim BindFlag As Boolean = False


#Region "=================GetConvertToDataSet Function==========="
    Private Function GetConvertToDataSet(ByVal SearchType As String, Optional ByVal rowHandle As Integer = 0) As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)
            Select Case SearchType.ToUpper
                Case "REQ_SVC2"
                    YJSql.SqlBox("REQ_SVC2", "Common@GetReqSvc2List", True)
                Case Else
                    YJSql.SqlBox("WG1", "CrmLeftForm@Search", True, True)
                    YJSql.Blocks("ONLINE_Y", True)
                    YJSql.Params("REQ_SVC", S_REQ_SVC_LIST.EditValue.ToString.Replace(" ", "").Replace(";", "','"))

                    YJSql.SqlBox("WG2", "CrmLeftForm@Search", True, True)
                    YJSql.Params("WORK_DEPT_CD", ClientSessionInfo.OrganizationCode)
                    YJSql.Blocks("ONLINE_SHARE_Y", True)
            End Select

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
#End Region


#Region "=================Data logic actions==========="
    Public Sub SearchData(ByVal eventName As String)
        If eventName = "Timer2_Tick" Then
            If Now.Hour >= 0 AndAlso Now.Hour <= 7 Then Exit Sub
            If Now.Hour >= 20 AndAlso Now.Hour <= 23 Then Exit Sub
        End If

        Dim dsRet As DataSet = GetConvertToDataSet("Search")
        dsRet = MethodCallEx(Me, "YJIT.Biz.CrmLeftForm", "Search", dsRet)
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        If drPairs("TrxCode").ToString <> "Y" Then
            MsgBoxLocalized(drPairs("TrxMsg"))
            Me.DataState = UI.DataStates.Retrieved
            Exit Sub
        End If
        BindFlag = True
        Me.BindToDataset(dsRet, "Data")
        BindFlag = False

        xtpNonAssign.Text = String.Format("{0}({1})", Mid(xtpNonAssign.Text, 1, xtpNonAssign.Text.IndexOf("(")), GV1.RowCount)
        xtpSubShare.Text = String.Format("{0}({1})", Mid(xtpSubShare.Text, 1, xtpSubShare.Text.IndexOf("(")), GV2.RowCount)

        Me.DataState = UI.DataStates.Retrieved
    End Sub
#End Region


#Region "============Client Function & Procedure============"
    Public Sub InitGrid()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T02")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        GV1.Columns("REQ_SVC").ColumnEdit = editorCombo
        GV2.Columns("REQ_SVC").ColumnEdit = editorCombo

    End Sub

    Private Sub AddNewRow(ByVal dt As DataTable, ByVal Code As String, ByVal Name As String)
        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1)("CODE") = Code
        dt.Rows(dt.Rows.Count - 1)("NAME") = Name
    End Sub

    Private Sub InitData()
        Try
            Dim ds As DataSet = GetConvertToDataSet("REQ_SVC2")
            ds = MethodCallEx(Me, "YJIT.Biz.CrmLeftForm", "Search", ds)
            ds = AdaptDataSourceForReport(ds)
            If ds.Tables.Contains("REQ_SVC2") Then
                REQ_SVC2_dt = ds.Tables("REQ_SVC2")
            End If
        Catch ex As Exception

        End Try

        Try
            Dim searchParams As Dictionary(Of String, Object)
            Dim dataParams As Dictionary(Of String, Object)
            searchParams = New Dictionary(Of String, Object)
            dataParams = New Dictionary(Of String, Object)
            dataParams.Add("GroupCode", "T02")
            dataParams.Add("NameType", "")
            Dim dt As DataTable = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)


            Dim bindingSourceProduct As BindingSource
            bindingSourceProduct = New BindingSource()
            bindingSourceProduct.DataSource = dt
            S_REQ_SVC_LIST.Properties.DataSource = bindingSourceProduct.DataSource
            S_REQ_SVC_LIST.Properties.ValueMember = "CODE"
            S_REQ_SVC_LIST.Properties.DisplayMember = "NAME"
            S_REQ_SVC_LIST.Properties.NullText = String.Empty
            S_REQ_SVC_LIST.DataBindings.Clear()
            S_REQ_SVC_LIST.DataBindings.Add("EditValue", dt, "NAME")
            'S_REQ_SVC_LIST.DataBindings.Add("EditValue", bindingSourceProduct, "NAME", True, DataSourceUpdateMode.OnPropertyChanged)
            S_REQ_SVC_LIST.Properties.SeparatorChar = ";"
            S_REQ_SVC_LIST.Properties.PopupFormMinSize = New Size(80, dt.Rows.Count * 22)
            'S_REQ_SVC_LIST.EditValue = ""

        Catch ex As Exception

        End Try

    End Sub
#End Region

#Region "============Control events============"

    Private Sub CrmLeftForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub CrmLeftForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Call InitData()
            Call InitGrid()

            'Common.DrawRowIndicator({GV1})

            GV1.OptionsView.ColumnAutoWidth = True

            Call SaveControlValues(Me, {REF_TIME, S_REQ_SVC_LIST})

            TimerLeftForm.Interval = 1000
            TimerLeftForm.Start()
            If REF_TIME.SelectedValue = 0 Then
                TimerLeftForm.Stop()
            Else
                MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
            End If

            Call SearchData("CrmLeftForm_Shown")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            ShownFlag = False
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call SearchData("btnRefresh_Click")
    End Sub

    Private Sub REF_TIME_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REF_TIME.SelectedValueChanged
        If ShownFlag Then Exit Sub

        If REF_TIME.SelectedValue = 0 Then
            TimerLeftForm.Stop()
        Else
            TimerLeftForm.Start()
            MaxInterval = 60 * CDbl(REF_TIME.SelectedValue)
        End If

        Call Common.Form_Closing(Me, Nothing)
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLeftForm.Tick
        Try

            If CDbl(REF_TIME.SelectedValue) <> 0 Then
                lblTime.Text = "Refresh : " & second & " 초"
            Else
                lblTime.Text = ""
            End If

            second = second + 1
            If second >= MaxInterval Then
                second = 0
                SearchData("Timer2_Tick")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolTipController1_GetActiveObjectInfo(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs) Handles ToolTipController1.GetActiveObjectInfo
        If Not e.SelectedControl Is WG1 AndAlso Not e.SelectedControl Is WG2 Then Return

        Dim info As ToolTipControlInfo = Nothing
        'Get the view at the current mouse position
        Dim WG As YJIT.SC.UI.SCControls.WebGrid = CType(e.SelectedControl, YJIT.SC.UI.SCControls.WebGrid)
        Dim view As GridView = WG.GetViewAt(e.ControlMousePosition)
        If view Is Nothing Then Return
        'Get the view's element information that resides at the current position
        Dim hi As GridHitInfo = view.CalcHitInfo(e.ControlMousePosition)

        'Display a hint for row indicator cells
        If hi.InRowCell Then
            If hi.Column.FieldName = "CUST_NM" OrElse hi.Column.FieldName = "REQ_SVC" Then
                'An object that uniquely identifies a row indicator cell
                Dim text As String = String.Empty
                Try
                    If view.RowCount = 0 Then Exit Try
                    text = view.GetFocusedDataRow("TOOLTIP").ToString
                Catch ex As Exception
                    MsgBoxLocalized(ex.Message)
                End Try

                Dim o As Object = hi.HitTest.ToString() + hi.RowHandle.ToString()
                info = New ToolTipControlInfo(o, text)
            End If
        End If
        'Supply tooltip information if applicable, otherwise preserve default tooltip (if any)
        If Not info Is Nothing Then e.Info = info

    End Sub

    Private Sub GV1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV1.Click
        Call SearchDetail(sender)
    End Sub
    Private Sub GV2_Click(sender As Object, e As MouseEventArgs) Handles GV2.Click
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = GV2.CalcHitInfo(e.Location)
        If (hitInfo.InRowCell) Then
            Call SearchDetail(sender)
        Else
            'HEADER 클릭시 자료조회 로직 제외
        End If
    End Sub

    Private Sub GV1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV1.KeyDown, GV2.KeyDown
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down
                Call SearchDetail(sender)
        End Select
    End Sub


    Private Sub GV1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            If e.RowHandle < 0 Then Exit Sub

            Select Case e.Column.FieldName
                Case "REQ_SVC"
                    Dim reqDate As String = view.GetRowCellValue(e.RowHandle, "REQ_DATE").ToString
                    If Not IsDate(reqDate) Then
                        reqDate = CDate(Now.ToString("yyyy-") & view.GetRowCellValue(e.RowHandle, "REQ_DATE").ToString)
                    End If
                    If Not IsDate(reqDate) Then Exit Sub
                    If Now.ToString("yyyy-MM-dd") <> CDate(reqDate).ToString("yyyy-MM-dd") Then Exit Sub

                    Dim minutesDiff = DateDiff(DateInterval.Minute, CDate(Now.ToString("yyyy-MM-dd HH:mm")), CDate(reqDate))

                    If (Math.Abs(minutesDiff) / 60) <= 0.2 AndAlso view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightSalmon
                    ElseIf (Math.Abs(minutesDiff) / 60) > 0.2 AndAlso view.GetRowCellValue(e.RowHandle, "PROC_TYPE").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.Red
                    Else
                        e.Appearance.BackColor = Nothing
                    End If
                Case "CUST_NM"
                    Select Case view.GetRowCellValue(e.RowHandle, "SYS_ID").ToString
                        Case "CRM", "MAIL"
                            '기본값
                        Case Else '"ELVIS", "HELP"
                            e.Appearance.BackColor = System.Drawing.Color.LightPink
                    End Select
                Case "REQ_DATE"
                    'If view.GetRowCellValue(e.RowHandle, "SHARE_DEPT").ToString.Contains(ClientSessionInfo.OrganizationCode) Then
                    If view.GetRowCellValue(e.RowHandle, "DEV_CMPT_YN").ToString = "Y" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightBlue
                    Else
                        e.Appearance.BackColor = Nothing
                    End If
                Case "CONTENT"
                    If view.GetRowCellValue(e.RowHandle, "PRIORITY").ToString = "0" Then
                        e.Appearance.BackColor = System.Drawing.Color.LightPink
                    Else
                        e.Appearance.BackColor = Nothing
                    End If
            End Select
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub SearchDetail(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
        If BindFlag = True Then Exit Sub
        If view.RowCount = 0 Then Exit Sub

        If view.GetFocusedRowCellValue("MNGT_NO").ToString = "" Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmMain As YJIT.SC.UI.IMainForm = Common.IMainForm
            Dim fTarget As Object = Nothing

            fTarget = frmMain.NavigateTo("CrmAsMgt_v4")
            If Not IsNothing(fTarget) Then
                'frm.NewData() 사용하면 안됨
                fTarget.MNGT_NO.text = view.GetFocusedRowCellValue("MNGT_NO").ToString
                'If view.Name = "GV2" Then
                '    fTarget.LEFTFORM_TAB.text = xtcTeam.SelectedTabPage.Name
                '    fTarget.SearchData()
                'Else
                fTarget.LEFTFORM_TAB.text = tabMain.SelectedTabPage.Name
                If view.GetFocusedRowCellValue("DEV_CMPT_YN").ToString = "Y" Then
                    fTarget.SearchNewData()
                Else
                    fTarget.SearchData()
                End If
                'End If
            End If
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub S_REQ_SVC_LIST_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles S_REQ_SVC_LIST.EditValueChanged
        If ShownFlag Then Exit Sub

        Call Common.Form_Closing(Me, Nothing)
    End Sub

#End Region


End Class