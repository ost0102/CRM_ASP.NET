Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.Utils

Public Class SysBoardList
    Private HotTrackRowValue As Integer = DevExpress.XtraGrid.GridControl.InvalidRowHandle
    Private Sub PopupInit()
        'Pending List
        Dim PopUp = New PopupBase
        PopUp.ItemAdd(Action.Other, "WG2CHKALL", "Select All")
        PopUp.ItemAdd(Action.Other, "WG2CHKALLCOLDATA", "Select All(동일자료)")
        PopUp.ItemAdd(Action.Other, "WG2CHKALLBILL", "Select All(ELVIS-BILL)")
        PopUp.PopUpInit(Me, WG2)
    End Sub

    Private Sub SaveData()

        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        If MsgBoxLocalized("Do you want to save?", MessageBoxButtons.YesNo, "Confirm", MessageBoxIcon.Question) = MsgBoxResult.No Then Exit Sub

        For i As Integer = 0 To GV1.RowCount - 1
            If GV2.GetDataRow(i).RowState = DataRowState.Unchanged Then
                GV2.GetDataRow(i).SetModified()
            End If
        Next

        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.SysBoardList", "Save", Me.ConvertToDataset)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
        Else
            MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
        End If


    End Sub

    Public Sub SearchCustList()
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysBoardList", "SearchCustList", Me.ConvertToDataset, AddressOf searchCust_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub searchCust_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If

            Me.BindToDataset(ds, "Data")
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub


    Private Property HotTrackRow() As Integer
        Get
            Return HotTrackRowValue
        End Get

        Set(ByVal Value As Integer)
            If HotTrackRowValue <> Value Then
                Dim PrevHotTrackRow As Integer
                PrevHotTrackRow = HotTrackRowValue
                HotTrackRowValue = Value
                GV1.RefreshRow(PrevHotTrackRow)
                GV1.RefreshRow(HotTrackRowValue)
            End If
        End Set

    End Property

#Region "=================Data logic actions==========="
    Public Sub NewData()
        Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
        Dim fTarget As Object = frmMain.NavigateTo("SysBoardMgt", NavigatedWindowModes.Popup, False)
        If fTarget IsNot Nothing Then
            fTarget.NewData()
            fTarget.ShowDialog()
        End If
    End Sub
    Public Sub SearchData()
        Try
            YJIT.SC.WCF.WCFBiz.Instance.MethodCallAsync("YJIT.Biz.SysBoardList", "Search", Me.ConvertToDataset, AddressOf search_OnComplete)
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Private Sub search_OnComplete(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Try
            Dim ds As DataSet = e.Result
            Dim dr As DataRow = ds.Tables("KEY_VALUE_PAIRS").Rows(0)

            If dr("TrxCode") <> "Y" Then
                Me.ClearView(AppliedRangeTypes.Only, {WG1})
                MsgBoxLocalized(dr("TrxMsg"))
                Exit Sub
            End If
            Me.BindToDataset(ds, "Data")

            GV2.BestFitColumns()

        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
        End Try
    End Sub
    Public Sub PopUpOnAfterClick(ByVal dr As DataRow)
        Dim key As String = dr("Key").ToString
        Dim checkAll As Boolean = False

        Select Case dr("Action")
            Case Action.Other
                Select Case key
                    Case "WG2CHKALLCOLDATA"
                        For i As Integer = 0 To GV2.RowCount - 1
                            If GV2.GetRowCellValue(i, "CHK").ToString = "N" AndAlso GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
                                checkAll = True
                                Exit For
                            End If
                        Next
                        If checkAll = True Then
                            For i As Integer = 0 To GV2.RowCount - 1
                                If GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
                                    GV2.SetRowCellValue(i, "CHK", "Y")
                                End If
                            Next
                        Else
                            For i As Integer = 0 To GV2.RowCount - 1
                                If GV2.GetRowCellValue(i, GV2.FocusedColumn).ToString = GV2.GetRowCellValue(GV2.FocusedRowHandle, GV2.FocusedColumn).ToString Then
                                    GV2.SetRowCellValue(i, "CHK", "N")
                                End If
                            Next
                        End If
                    Case "WG2CHKALL"
                        For i As Integer = 0 To GV2.RowCount - 1
                            If GV2.GetRowCellValue(i, "CHK").ToString = "N" Then
                                checkAll = True
                                Exit For
                            End If
                        Next
                        If checkAll = True Then
                            For i As Integer = 0 To GV2.RowCount - 1
                                GV2.SetRowCellValue(i, "CHK", "Y")
                            Next
                        Else
                            For i As Integer = 0 To GV2.RowCount - 1
                                GV2.SetRowCellValue(i, "CHK", "N")
                            Next
                        End If
                    Case "WG2CHKALLBILL"
                        For i As Integer = 0 To GV2.RowCount - 1
                            If GV2.GetRowCellValue(i, "CHK").ToString = "N" AndAlso GV2.GetRowCellValue(i, "ELVIS_BILL_YN").ToString = "Y" Then
                                checkAll = True
                                Exit For
                            End If
                        Next
                        If checkAll = True Then
                            For i As Integer = 0 To GV2.RowCount - 1
                                If GV2.GetRowCellValue(i, "ELVIS_BILL_YN").ToString = "Y" Then
                                    GV2.SetRowCellValue(i, "CHK", "Y")
                                End If
                            Next
                        Else
                            For i As Integer = 0 To GV2.RowCount - 1
                                If GV2.GetRowCellValue(i, "ELVIS_BILL_YN").ToString = "Y" Then
                                    GV2.SetRowCellValue(i, "CHK", "N")
                                End If
                            Next
                        End If
                End Select
        End Select
    End Sub
    Private Sub InitGrid()
        Dim editorCombo As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        editorCombo = GridFunc.GetRepositoryItemLookUpEdit({"Y:Yes", "N:No"})
        GV2.Columns("ELVIS_BILL_YN").ColumnEdit = editorCombo
        editorCombo.ForceInitialize() : editorCombo.PopulateColumns()
        editorCombo.Columns("CODE").Visible = False
    End Sub
#End Region
#Region "=================Control Events==========="
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call SearchData()
    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call NewData()
    End Sub
    Private Sub SysBoardList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call DrawRowIndicator({GV2})
        Dim ms As New MenuStrip()
        ms.Visible = False
        Me.MainMenuStrip = ms

        Call PopupInit()

    End Sub
    Private Sub SysBoardList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Call InitGrid()
    End Sub
    Private Sub GV1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GV1.RowCellStyle
        If e.RowHandle = HotTrackRow Then
            e.Appearance.BackColor = Color.PaleGoldenrod
        End If
    End Sub
    Private Sub GV1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GV1.RowStyle
        With GV1
            If .RowCount >= 0 AndAlso e.RowHandle > -1 Then
                Dim col As System.Drawing.Color = Nothing

                If .GetRowCellValue(e.RowHandle, "NOTICE_YN").ToString = "Y" Then
                    col = System.Drawing.Color.Blue
                End If

                If col <> Nothing Then
                    e.Appearance.ForeColor = col
                End If
            End If

        End With
    End Sub
    Private Sub WG1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles WG1.MouseMove

        With GV1.CalcHitInfo(New Point(e.X, e.Y))

            If .InRowCell Then
                HotTrackRow = .RowHandle
                If .Column.FieldName = "TITLE" Then
                    WG1.Cursor = Cursors.Hand
                ElseIf .Column.FieldName = "EDIT" AndAlso GV1.GetRowCellValue(.RowHandle, .Column).ToString = "Edit" Then
                    WG1.Cursor = Cursors.Hand
                Else
                    WG1.Cursor = Cursors.Arrow
                End If
            Else
                HotTrackRow = DevExpress.XtraGrid.GridControl.InvalidRowHandle
                WG1.Cursor = Cursors.Arrow
            End If

        End With
    End Sub
    Private Sub GV1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles GV1.MouseDown

        Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = GV1.CalcHitInfo(e.Location)
        If (hitInfo.InRowCell) Then
            Dim rowHandle As Integer = hitInfo.RowHandle
            Dim col As DevExpress.XtraGrid.Columns.GridColumn = hitInfo.Column

            If col.FieldName = "TITLE" Then
                BOARD_ID.Text = GV1.GetRowCellValue(rowHandle, "BOARD_ID").ToString
                TITLE.Text = GV1.GetRowCellValue(rowHandle, "TITLE").ToString
                Call SearchCustList()
            ElseIf col.FieldName = "EDIT" Then
                WG1.Cursor = Cursors.AppStarting
                Dim frmMain As YJIT.SC.UI.IMainForm = Me.MdiParent
                Dim fTarget As Object = frmMain.NavigateTo("SysBoardMgt", NavigatedWindowModes.Popup, False)
                If fTarget IsNot Nothing Then
                    fTarget.BOARD_ID.Text = GV1.GetRowCellValue(rowHandle, "BOARD_ID").ToString
                    fTarget.SearchData()
                    fTarget.Show()
                End If
            End If
            WG1.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        If BOARD_ID.Text = "" Then Exit Sub

        Call SaveData()

    End Sub

    Private Sub RepositoryItemCheckEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        GV2.FocusedColumn = GV2.Columns("DOMAIN")
        GV2.FocusedColumn = GV2.Columns("CHK")
    End Sub
#End Region
End Class
