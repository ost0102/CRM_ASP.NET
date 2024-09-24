Public Class GridDrag

    'Private mGv As DevExpress.XtraGrid.Views.Grid.GridView
    'Private mWg As YJIT.SC.UI.SCControls.WebGrid
    'Dim seq As Integer = 1
    'Dim cntr As Boolean = False
    'Dim drag As Boolean = False
    'Private CopyStr As String = ""
    'Property GridView As DevExpress.XtraGrid.Views.Grid.GridView
    '    Set(value As DevExpress.XtraGrid.Views.Grid.GridView)

    '    End Set
    '    Get
    '        Return mGv
    '    End Get
    'End Property

    'Public Sub InitDrag(ByVal Wg As YJIT.SC.UI.SCControls.WebGrid)
    '    mGv = Wg.MainView
    '    mWg = Wg
    '    mGv.OptionsSelection.MultiSelect = True
    '    mGv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
    '    AddHandler mGv.MouseMove, AddressOf GV_MouseMove
    '    AddHandler mGv.KeyDown, AddressOf Gv_KeyDown
    '    AddHandler mGv.KeyUp, AddressOf Gv_KeyUp
    '    AddHandler mGv.MouseUp, AddressOf Gv_MouseUp
    '    AddHandler mWg.EditorKeyDown, AddressOf WG_EditorKeyDown
    'End Sub

    'Private Sub GV_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
    '    seq += 1
    '    If e.Button = Windows.Forms.MouseButtons.Left AndAlso cntr Then
    '        drag = True
    '        If CopyStr Is Nothing Then
    '            Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = mGv.GetSelectedCells()
    '            CopyStr = mGv.GetFocusedRowCellValue(mGv.FocusedColumn).ToString
    '        End If
    '    Else
    '        drag = False
    '    End If
    'End Sub

    'Public Sub KeyPressControl(ByVal input As Boolean)
    '    cntr = input
    'End Sub
    'Private Sub Gv_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
    '    KeyPressControl(e.Control)
    '    If e.KeyCode = Keys.V AndAlso e.Control Then
    '        SetGridValue(Clipboard.GetText)
    '    End If
    'End Sub

    'Private Sub Gv_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
    '    KeyPressControl(e.Control)

    'End Sub

    'Private Sub Gv_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Left AndAlso cntr AndAlso drag = True Then
    '        SetGridValue(CopyStr)
    '        CopyStr = Nothing 
    '        Exit Sub
    '    End If 
    'End Sub

    'Public Sub SetGridValue(ByVal paste As String)
    '    If Not CopyStr Is Nothing Then
    '        Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = mGv.GetSelectedCells()
    '        For Each column In columns
    '            mGv.SetRowCellValue(column.RowHandle, column.Column.FieldName, paste)
    '        Next
    '    End If
    'End Sub
    'Public Sub DeleteGridValue()
    '    If Not CopyStr Is Nothing Then
    '        Dim columns() As DevExpress.XtraGrid.Views.Base.GridCell = mGv.GetSelectedCells()
    '        For Each column In columns
    '            mGv.SetRowCellValue(column.RowHandle, column.Column.FieldName, "")
    '        Next
    '    End If
    'End Sub
    'Private Sub WG_EditorKeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.V AndAlso e.Control Then
    '        SetGridValue(Clipboard.GetText)
    '    End If
    '    If e.KeyCode = Keys.Delete Then
    '        DeleteGridValue()
    '    End If
    'End Sub
End Class
