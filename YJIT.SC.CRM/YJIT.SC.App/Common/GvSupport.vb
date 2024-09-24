Imports System.Data
Imports System.Reflection
Imports DevExpress.XtraReports.UI
Imports System.Collections.Specialized

Public Class GvSupport

    Private mGv As DevExpress.XtraGrid.Views.Grid.GridView
    Private mBGv As DevExpress.XtraGrid.Views.Grid.GridView
    Private mWebGrid() As YJIT.SC.UI.SCControls.WebGrid

    Dim ControlDown As Boolean = False
    Dim Drag As Boolean = False
    Dim MOuseLeftDown As Boolean = False
    Private CopyStr As String = ""


#Region "============ Data logic ============"
    Public Sub DeleteGridValue(sender As System.Object)
        Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = sender.GetSelectedCells()
        For Each column In columns
            sender.SetRowCellValue(column.RowHandle, column.Column.FieldName, "")
        Next
    End Sub

    Public Sub InitDrag(ByVal WebGrid() As YJIT.SC.UI.SCControls.WebGrid)
        mWebGrid = WebGrid
        For Each Wg As YJIT.SC.UI.SCControls.WebGrid In WebGrid
            Dim Control As Object = Wg.MainView
            Select Case Control.GetType.FullName
                Case "DevExpress.XtraGrid.Views.Grid.GridView"
                    mGv = Control
                    AddHandler mGv.MouseMove, AddressOf GV_MouseMove
                    AddHandler mGv.KeyDown, AddressOf Gv_KeyDown
                    AddHandler mGv.KeyUp, AddressOf Gv_KeyUp
                    AddHandler mGv.MouseUp, AddressOf Gv_MouseUp
                    AddHandler mGv.MouseDown, AddressOf Gv_MouseDown
                Case "DevExpress.XtraGrid.Views.BandedGrid.BandedGridView"
                    mBGv = Control
                    AddHandler mBGv.MouseMove, AddressOf GV_MouseMove
                    AddHandler mBGv.KeyDown, AddressOf Gv_KeyDown
                    AddHandler mBGv.KeyUp, AddressOf Gv_KeyUp
                    AddHandler mBGv.MouseUp, AddressOf Gv_MouseUp
                    AddHandler mBGv.MouseDown, AddressOf Gv_MouseDown
                Case Else
                    DevExpress.XtraEditors.XtraMessageBox.Show(" GridView and BandedGridView support Only.")
                    Continue For
            End Select
            Control.OptionsSelection.MultiSelect = True
            Control.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect

            AddHandler Wg.EditorKeyDown, AddressOf WG_EditorKeyDown
        Next

    End Sub

    Public Sub KeyPressControl(ByVal input As Boolean)
        ControlDown = input
    End Sub
     
    Public Sub New(ByVal WebGrid() As YJIT.SC.UI.SCControls.WebGrid)
        InitDrag(WebGrid)
    End Sub

    Private Sub SetCopyStr(sender As System.Object)
        Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = sender.GetSelectedCells()
        If CopyStr Is Nothing AndAlso columns.Count = 1 Then
            CopyStr = sender.GetRowCellValue(columns(0).RowHandle, columns(0).Column.FieldName).ToString
        End If
    End Sub

#End Region
#Region "============ Control Event  ============"
    Private Sub GV_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) 
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso MOuseLeftDown Then
            drag = True
            SetCopyStr(sender)
        Else
            drag = False
        End If
    End Sub

    Private Sub Gv_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        KeyPressControl(e.Control)
        If e.KeyCode = Keys.V AndAlso e.Control Then
            SetGridValue(sender, Clipboard.GetText)
            e.Handled = True
        End If
    End Sub

    Private Sub Gv_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        KeyPressControl(e.Control)
        If e.KeyCode = Keys.Delete Then
            DeleteGridValue(sender)
            e.Handled = True
        End If
    End Sub

    Private Sub Gv_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ControlDown AndAlso drag = True AndAlso Not CopyStr Is Nothing Then
            SetGridValue(sender, CopyStr)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MOuseLeftDown = False
            CopyStr = Nothing
        End If

    End Sub

    Private Sub Gv_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso ControlDown Then
            SetCopyStr(sender)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MOuseLeftDown = True
        End If
    End Sub

    Public Sub SetGridValue(sender As System.Object, ByVal paste As String)
        If Not paste Is Nothing Then
            Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = mGv.GetSelectedCells()
            For Each column As DevExpress.XtraGrid.Views.Base.GridCell In columns
                If column.Column.OptionsColumn.ReadOnly = False AndAlso column.Column.OptionsColumn.AllowEdit = True Then
                    mGv.SetRowCellValue(column.RowHandle, column.Column.FieldName, paste)
                End If

            Next
        End If
    End Sub

    Private Sub WG_EditorKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.V AndAlso e.Control Then
            'SetGridValue(sender.MainView, Clipboard.GetText)
            'e.Handled = True
        End If

    End Sub
#End Region


     

End Class
