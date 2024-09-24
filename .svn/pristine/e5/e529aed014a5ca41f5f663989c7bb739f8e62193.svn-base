Imports Microsoft.VisualBasic
Imports System
Imports YJIT.SC.UI
Imports DevExpress.XtraGrid.Views.Grid
Imports YJIT.SC.UI.SCControls
Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class CrmHolidayMgt
    Dim bShowDateBoxEdit As Boolean = True
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Dim dtREQ_SVC2 As DataTable = Nothing
#Region "=================Data logic actions==========="
    Public Sub NewData()
        Me.ClearView(UI.AppliedRangeTypes.All)
        Call SetDefault()
        Call AddGridRow(WG1)
        GV1.FocusedColumn = GV1.Columns("HD_YMD")
        GV1.ShowEditor()
    End Sub
    Private Function GetConvertToDataSet() As DataSet
        Dim YJSql As New YJQuery
        Dim ds As DataSet = Me.ConvertToDataset
        Dim IsSingleSearch As Boolean = False

        Try
            Dim drMAIN As DataRow = ds.Tables("MAIN").Rows(0)

            YJSql.SqlBox("WG1", "CrmHolidayMgt@Search", , False)
            YJSql.Params("HD_FM_YMD", drMAIN("S_HD_FM_YMD").ToString.Trim)
            YJSql.Params("HD_TO_YMD", drMAIN("S_HD_TO_YMD").ToString.Trim)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return YJSql.DataSet
    End Function
    Public Sub SearchData()
        If SearchValidate() = False Then Exit Sub

        Dim dsRet As DataSet = GetConvertToDataSet()

        Using dlg As DevExpress.Utils.WaitDialogForm = New DevExpress.Utils.WaitDialogForm("", "잠시만 기다려주세요. 자료검색중입니다.")
            dsRet = MethodCallEx(Me, "YJIT.Biz.CrmHolidayMgt", "Search", {dsRet})
        End Using
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)

        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                YJIT.SC.UI.SCView.MsgBoxTimeout = 1
                YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords = drPairs("TrxMsg")
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select
    End Sub
    Private Function SearchValidate() As Boolean
        Dim ErrMsg As String = String.Empty
        Dim ErrControl As Control = Nothing

        Try
            If String.IsNullOrEmpty(S_HD_FM_YMD.Text.ToString) OrElse String.IsNullOrEmpty(S_HD_TO_YMD.Text.ToString) Then
                If ErrControl Is Nothing Then
                    If String.IsNullOrEmpty(S_HD_TO_YMD.Text) Then
                        ErrControl = S_HD_TO_YMD
                    Else
                        ErrControl = S_HD_FM_YMD
                    End If
                End If
                ErrMsg &= "휴일 일자를 입력해주세요!" & vbNewLine
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
    Public Sub SaveData()

        If MandatoryGridValue("GV1") Then Exit Sub
        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

        Dim ds As DataSet = Me.ConvertToDataset
        If ds.Tables("WG1").Rows.Count = 0 Then
            MsgBoxLocalized("Data is empty!")
            Exit Sub
        End If

        'Save Data
        Dim dr As DataRow
        For Each dt As DataTable In GetConvertToDataSet.Tables
            ds.Tables.Add(dt.Copy)
        Next

        Try
            'ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.CrmWBSMgt", "Save", ds)
            ds = MethodCallEx(Me, "YJIT.Biz.CrmHolidayMgt", "Save", ds)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try

        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

        If dr("TrxCode") = "Y" Then
            Call ClearView(AppliedRangeTypes.Only, {WG1})
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
            YJIT.SC.UI.SCView.MsgBoxTimeout = 1
            YJIT.SC.UI.SCView.MsgBoxTimeoutKeyWords = "저장되었습니다."
            MsgBoxLocalized("저장되었습니다.")
        Else
            MsgBoxLocalized(dr("TrxMsg"))
        End If



    End Sub
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV1"
                checkNull = {"HD_YMD"}
                Param("HD_YMD") = GV1_HD_YMD.Caption()
                Return ValidateGridValue(GV1, Param, checkNull)
        End Select
        Return False
    End Function
    Private Sub initGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = GridFunc.GetRepositoryItemLookUpEdit({"Y:Y", "N:N"})
        GV1.Columns("CHANGE_YN").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)

    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub ComDelLogMgt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YJIT.SC.UI.SCView.AppAutoSuggestion = False
        Call initGrid()
        Call SetDefault()
    End Sub
    Private Sub ComDelLogMgt_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Call PopupInit()
        Call AddGridRow(WG1)
        GV1.FocusedColumn = GV1.Columns("HD_YMD")
        GV1.ShowEditor()
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub

    Private Sub GV1_ShownEditor(sender As System.Object, e As System.EventArgs) Handles GV1.ShownEditor
        Dim view As GridView = TryCast(sender, GridView)


        Select Case view.FocusedColumn.FieldName
            Case "HD_YMD"
                Dim te As TextEdit = CType(view.ActiveEditor, TextEdit)
                If Not String.IsNullOrEmpty(te.EditValue) Then
                    te.SelectionStart = te.Text.Length
                    te.SelectionLength = 0
                End If
        End Select

        Select Case view.ActiveEditor.EditorTypeName
            '20200810 김성은 불편해서 제거
            'Case "DateBoxEdit"
            '    If bShowDateBoxEdit = False Then Exit Sub
            '    Dim edit As DateBoxEdit = CType(view.ActiveEditor, DateBoxEdit)
            '    edit.ShowDatePicker()
            '    bShowDateBoxEdit = False
            Case Else
                view.GridControl.BeginInvoke(New MethodInvoker(Sub()
                                                                   Dim edit As PopupBaseEdit = TryCast(view.ActiveEditor, PopupBaseEdit)
                                                                   If edit Is Nothing Then
                                                                       Return
                                                                   End If
                                                                   edit.ShowPopup()
                                                                   edit.SelectionStart = edit.Text.Length
                                                                   edit.SelectionLength = 0
                                                               End Sub))
        End Select

    End Sub
    Private Sub btnDelWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnDelWg2.Click
        Call DelGridRow(WG1)
    End Sub
    Private Sub btnAddWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWg2.Click
        Call AddGridRow(WG1)
    End Sub
    Private Sub GV1_FocusedColumnChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GV1.FocusedColumnChanged
        bShowDateBoxEdit = True
    End Sub
    Private Sub btnExpWg2_Click(sender As System.Object, e As System.EventArgs) Handles btnExpWg2.Click
        Common.ExportToExcel(WG1)
    End Sub
    Private Sub S_REQ_FM_YMD_Leave(sender As System.Object, e As System.EventArgs) Handles S_HD_FM_YMD.Leave
        If S_HD_FM_YMD.Text > S_HD_TO_YMD.Text Then
            S_HD_TO_YMD.Text = S_HD_FM_YMD.Text
        End If
    End Sub
#End Region
#Region "=================Client Function==========="
    Private Sub SetDefault()
        S_HD_FM_YMD.Text = Now.ToString("yyyy") & "0101"
        S_HD_TO_YMD.Text = Now.ToString("yyyy") & "1231"
    End Sub
    Private Sub PopupInit()

        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "행추가")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DelRow", "행삭제")
        PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "엑셀다운로드", True)
        PopUp.PopUpInit(Me, WG1, btnQuickFwg2, "HD_YMD", "CHANGE_YN")

    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        Dim Id As String = ""
        If Key = "Enter" Then Id = Dr("ID")

        Dim rowIndex As Integer = 0

        Select Case Dr("Action")
            Case Action.Excel
                If Key = "WG1_ExportExcel" Then
                    GV1.OptionsView.ShowViewCaption = True
                End If
        End Select

    End Sub
    Private Sub AddGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvAddRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvAddRow.Columns.Add("Key")
        GvAddRow.Columns.Add("Sender")
        GvAddRow.Columns.Add("Action", GetType(Action))
        GvAddRow.Rows.Add()
        dr = GvAddRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_AddRow"
        dr("Action") = Action.Addrow
        obj.AddRow()

        PopUpOnAfterClick(GvAddRow.Rows(0))

    End Sub
    Private Sub DelGridRow(ByVal obj As YJIT.SC.UI.SCControls.WebGrid)
        Dim GvDelRow As New DataTable
        Dim dr As DataRow

        If obj.Visible = False And obj.Enabled = False Then Exit Sub
        GvDelRow.Columns.Add("Key")
        GvDelRow.Columns.Add("Sender")
        GvDelRow.Columns.Add("Action", GetType(Action))
        GvDelRow.Rows.Add()
        dr = GvDelRow.Rows(0)
        dr("Sender") = obj.Name
        dr("Key") = obj.Name + "_DeleteRow"
        dr("Action") = Action.DeleteRow
        obj.DeleteRow()

        PopUpOnAfterClick(GvDelRow.Rows(0))

    End Sub

    Private Sub GV1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV1.FocusedRowChanged
        Call GridFunc.SetGridKeyProtectEx(sender, e, "HD_YMD")
    End Sub
#End Region
End Class