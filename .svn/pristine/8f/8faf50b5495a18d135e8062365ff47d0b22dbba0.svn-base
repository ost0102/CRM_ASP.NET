

Public Class CrmAsPayment
    Public SaveYN As String = "N"

#Region "=================Data logic actions==========="
    Private Sub SaveData()
        Try
            If MandatoryGridValue("GV_PAY") Then Exit Sub
            '20200708 김성은 금액이 있는 경우 무조건 적용
            'If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.OKCancel) = MsgBoxResult.Cancel Then Exit Sub

            'Dim ds As DataSet = Me.ConvertToDataset
            'If ds.Tables("WG_PAY").Rows.Count = 0 Then
            '    MsgBoxLocalized("Data is empty!")
            '    Exit Sub
            'End If
            SaveYN = "Y"
            Me.Close()
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Function MandatoryGridValue(ByVal gridView As String) As Boolean
        Dim Param As New Dictionary(Of String, Object)
        Dim checkNull() As String = Nothing
        Select Case gridView
            Case "GV_PAY"
                checkNull = {"FARE_LOC_AMT"}
                Param("FARE_LOC_AMT") = GV_PAY_FARE_LOC_AMT.Caption()
                Return ValidateGridValue(GV_PAY, Param, checkNull)
        End Select
        Return False
    End Function

#End Region

#Region "=================Control Events==========="
    Private Sub CrmAsPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call GridInit()
    End Sub
    Private Sub CrmAsPayment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call PopupInit()
        Call AddGridRow(WG_PAY)

        '커서 위치 정의
        GV_PAY.FocusedColumn = GV_PAY.Columns("CARD_ACCT_CD")
        GV_PAY.ShowEditor()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnAddWg_Click(sender As System.Object, e As System.EventArgs) Handles btnAddWg.Click
        Call AddGridRow(WG_PAY)
    End Sub
    Private Sub btnDelWg_Click(sender As System.Object, e As System.EventArgs) Handles btnDelWg.Click
        Call DelGridRow(WG_PAY)
    End Sub
    Private Sub btnExpWg_Click(sender As System.Object, e As System.EventArgs) Handles btnExpWg.Click
        Common.ExportToExcel(WG_PAY)
    End Sub
    Private Sub GV_PAY_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_PAY.CellValueChanged
        Select Case e.Column.FieldName
            Case "CARD_TYPE"
                Dim row As DataRow = GV_PAY.GetFocusedDataRow
                Dim ctrl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(GV_PAY.Columns("CARD_TYPE").ColumnEdit, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
                Dim drList() As DataRow = CType(ctrl.DataSource, DataTable).Select("CODE = '" & e.Value & "'")
                For Each dr As DataRow In drList
                    row("CARD_CD") = dr("ITEM").ToString
                    row("CARD_NM") = dr("ITEM2").ToString
                Next
            Case "CARD_ACCT_CD"
                Dim row As DataRow = GV_PAY.GetFocusedDataRow
                Dim ctrl As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(GV_PAY.Columns("CARD_ACCT_CD").ColumnEdit, DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit)
                Dim drList() As DataRow = CType(ctrl.DataSource, DataTable).Select("CODE = '" & e.Value & "'")
                For Each dr As DataRow In drList
                    row("CARD_ACCT_NM") = dr("NAME").ToString
                Next
        End Select
    End Sub
#End Region

#Region "=================Client Function==========="
    Private Sub PopupInit()
        Dim PopUp As New PopupBase
        PopUp.ItemAdd(Action.Addrow, "WG1_AddRow", "행추가")
        PopUp.ItemAdd(Action.DeleteRow, "WG1_DelRow", "행삭제")
        PopUp.ItemAdd(Action.Excel, "WG1_ExcelExport", "엑셀다운로드", True)
        PopUp.PopUpInit(Me, WG_PAY, btnQuickFwg, "CARD_ACCT_CD", "RMK")
    End Sub
    Private Sub GridInit()
        Dim editorCombo As New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Dim searchParams As Dictionary(Of String, Object)
        Dim dataParams As Dictionary(Of String, Object)

        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T18")
        dataParams.Add("NameType", "")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        GV_PAY.Columns("CARD_ACCT_CD").ColumnEdit = editorCombo

        '법인/개인카드 종류
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo.ValueMember = "CODE"
        editorCombo.DisplayMember = "NAME"
        editorCombo.NullText = ""
        searchParams = New Dictionary(Of String, Object)
        dataParams = New Dictionary(Of String, Object)
        dataParams.Add("GroupCode", "T19")
        dataParams.Add("NameType", "")
        dataParams.Add("Item", "Y")
        dataParams.Add("Item2", "Y")
        editorCombo.DataSource = Common.CodeServiceAPI.GetCodeList("CommonCode", searchParams, dataParams)
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False 'Show/Hide one column  (by default, all columns in datasource is visible)
        editorCombo.Columns("ITEM").Visible = False
        editorCombo.Columns("ITEM2").Visible = False
        GV_PAY.Columns("CARD_TYPE").ColumnEdit = editorCombo
    End Sub
    Public Sub PopUpOnAfterClick(ByVal Dr As DataRow)
        Dim Key As String = Dr("Key")
        Dim Sender As String = ""
        If Not Dr("Sender") Is System.DBNull.Value Then Sender = Dr("Sender")

        'Dim Id As String = ""
        'If Key = "Enter" Then Id = Dr("ID")

        Select Case Dr("Action")
            Case Action.Addrow, Action.EventKey
                Select Case Sender
                    Case "WG_PAY"
                        If GV_PAY.FocusedRowHandle = 0 Then
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_ACCT_CD", "41641")
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_TYPE", "P")
                        Else
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_ACCT_CD", GV_PAY.GetRowCellValue(GV_PAY.FocusedRowHandle - 1, "CARD_ACCT_CD").ToString)
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_CD", GV_PAY.GetRowCellValue(GV_PAY.FocusedRowHandle - 1, "CARD_CD").ToString)
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_NM", GV_PAY.GetRowCellValue(GV_PAY.FocusedRowHandle - 1, "CARD_NM").ToString)
                            GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "CARD_TYPE", GV_PAY.GetRowCellValue(GV_PAY.FocusedRowHandle - 1, "CARD_TYPE").ToString)
                        End If
                        GV_PAY.SetRowCellValue(GV_PAY.FocusedRowHandle, "FARE_LOC_AMT", 0)
                End Select
            Case Action.Excel
                'If Key = "WG1_ExportExcel" Then
                '    GV1.OptionsView.ShowViewCaption = True
                'End If
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
#End Region

End Class