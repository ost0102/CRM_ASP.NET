Imports YJIT.SC.UI
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraGrid.Views.Grid

Public Class EchUpload

#Region "=================Data logic actions==========="

    Public Sub exelUpLoad()

        Dim filePath As String = ""
        Dim ds As DataSet
        Dim Dialog As OpenFileDialog = New OpenFileDialog()
        Dialog.Title = "Excel Import"
        Dialog.InitialDirectory = "c:\"
        Dialog.FilterIndex = 2
        Dialog.RestoreDirectory = True
        Dialog.Multiselect = True
        Dialog.Filter = "Excel Spreadsheets (*.xls)|*.xls|Excel 2007 and later (*.xlsx)|*.xlsx"

        If Dialog.ShowDialog() = DialogResult.OK Then
            FILE_PATH.Text = Dialog.FileName
            Dim tempLeng As New Integer
            ds = ImportExcel(Dialog.FileName)

            Dim dt As DataTable = New DataTable

            dt = ds.Tables(0)

            For i = 0 To dt.Columns.Count - 2
                dt.Columns(i).ColumnName = GV1.Columns(i).FieldName
            Next
            dt.Rows.RemoveAt(0)
            WG1.DataSource = dt.Copy

            For i = 0 To GV1.RowCount - 1
                If GV1.GetDataRow(i).RowState = DataRowState.Unchanged Then
                    GV1.GetDataRow(i).SetAdded()
                End If
            Next
        End If

    End Sub

    Public Sub PopUpInit()

        Dim PopUp As New PopupBase
        PopUp = New PopupBase
        PopUp.ItemAdd(Action.DeleteRow, "EchUpload", "&Delete Row")
        PopUp.PopUpInit(Me, WG1)

    End Sub
    Public Sub SearchData()

        Dim dsRet As DataSet = Me.ConvertToDataset
        dsRet = MethodCallEx(Me, "YJIT.Biz.EchUpload", "Search", {dsRet})
        Dim drPairs As DataRow = dsRet.Tables("KEY_VALUE_PAIRS").Rows(0)
        Select Case drPairs("TrxCode")
            Case "Y"
                Me.BindToDataset(dsRet, "Data")
                Me.DataState = UI.DataStates.Retrieved
            Case "N"
                MsgBoxLocalized(drPairs("TrxMsg"))
                Call ClearView(AppliedRangeTypes.Only, {WG1})
                Me.DataState = UI.DataStates.Retrieved
            Case Else
                MsgBoxLocalized(drPairs("TrxMsg"))
        End Select

    End Sub
    Public Sub GridInit()
    End Sub

    'Grid View Sequence 표시 함수
    Private Sub SetGridViewSequence(ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Dim rowIndex As Integer = e.RowHandle

        e.Info.DisplayText = "No"

        If rowIndex >= 0 Then
            rowIndex += 1
            e.Info.DisplayText = rowIndex.ToString()
        End If

        e.Info.ImageIndex = -1
    End Sub

    Public Sub ClearData()
        Me.ClearView()
    End Sub

    Private Sub SaveData()
        Dim ds As DataSet = Nothing
        Dim dr As DataRow = Nothing

        Dim paramsDs As DataSet = Me.ConvertToDataset
        Try
            ds = YJIT.SC.WCF.WCFBiz.Instance.MethodCall("YJIT.Biz.EchUpload", "SaveData", {paramsDs})
        Catch ex As Exception
            MsgBoxLocalized(ex.Message)
            Exit Sub
        End Try
        dr = ds.Tables("KEY_VALUE_PAIRS").Rows(0)
        If dr("TrxCode") <> "Y" Then
            Select Case dr("TrxCode")
                Case "N"
                Case "E"
                    MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Error", MessageBoxIcon.Error)
                    Exit Sub
            End Select
        Else
            Me.BindToDataset(ds, "Data")
            Me.DataState = UI.DataStates.Retrieved
        End If
        MsgBoxLocalized(dr("TrxMsg"), MessageBoxButtons.OK, "Confirm", MessageBoxIcon.Information)
    End Sub

#End Region
#Region "=================Control Events==========="
    Private Sub EchUpload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Common.DrawRowIndicator(GV1)

    End Sub

    Private Sub EchUpload_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        PopUpInit()
    End Sub

    Private Sub GV1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        Call SetGridViewSequence(e)
    End Sub

    Private Sub btnFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFile.Click
        Call exelUpLoad()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveData()
    End Sub
#End Region



End Class