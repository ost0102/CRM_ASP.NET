Public Class CustomerMaster
    '20180720 물류회계
    Private loadParentCodeBoxText As String = String.Empty

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Me.txtKeyword.Text = ""
        MyBase.OnLoad(e)

        '20180720 물류회계
        loadParentCodeBoxText = Me.ParentCodeBox.Text

    End Sub

    Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
        MyBase.OnShown(e)

        '20180720 물류회계
        If String.IsNullOrEmpty(loadParentCodeBoxText) AndAlso Not String.IsNullOrEmpty(Me.ParentCodeBox.Text) _
                 OrElse loadParentCodeBoxText <> Me.ParentCodeBox.Text Then
            txtKeyword.Text = loadParentCodeBoxText
            _searchCode(1)
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        _searchCode(1)
    End Sub

    Private Sub GV1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV1.DoubleClick
        If GV1.GetSelectedRows().Count > 0 Then
            Dim nRow As Integer = GV1.GetSelectedRows()(0)
            Me.ReturnedCodeValue = CType(WG1.DataSource, DataTable).Rows(nRow)("CODE")      'Return only the code value
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Protected Overrides Sub ExecuteSearch(Optional ByVal nPage As Integer = 1)
        Me.SearchParamValues("SearchKey") = Me.txtKeyword.Text.Trim
        Me.SearchParamValues("SEARCH_TYPE") = Me.SEARCH_TYPE.SelectedValue
        Me.SearchParamValues("CUST_TYPE") = ""
        Me.EnablePaging = False
        MyBase.ExecuteSearch(nPage)
    End Sub

    Protected Overrides Sub OnCodeSearchReturned(ByVal sender As Object, ByVal e As WCF.SRBiz.MethodCallCompletedEventArgs)
        Dim dsResult As DataSet = e.Result
        If dsResult.Tables.Contains("Data.PAGE") Then
            WG1.DataSource = dsResult.Tables("Data.PAGE")
            If GV1.RowCount > 0 Then WG1.Focus() : GV1.FocusedRowHandle = 0 'Focus on first row
            'Extract paging info
            If dsResult.Tables.Contains("KEY_VALUE_PAIRS") Then
                Dim drPageInfo As DataRow = dsResult.Tables("KEY_VALUE_PAIRS").Rows(0)
                Dim ResultTotal As Integer = drPageInfo("PagingInfo.ResultTotal")
                Dim PageCount As Integer = drPageInfo("PagingInfo.PageCount")

                'Showing pages
                Dim startPage As Integer
                Dim endPage As Integer

                startPage = Me.CurrentPage - Me.PageSetSize / 2
                endPage = Me.CurrentPage + Me.PageSetSize / 2

                If startPage < 1 Then startPage = 1
                If endPage - startPage < Me.PageSetSize Then endPage = startPage + Me.PageSetSize
                If endPage > PageCount Then endPage = PageCount

                If endPage - startPage > PageSetSize Then endPage -= 1

                flpPageList.Controls.Clear()
                Dim ctrlPage As LinkLabel



                For i As Integer = startPage - 1 To endPage + 1
                    ctrlPage = New LinkLabel
                    ctrlPage.Width = 25
                    ctrlPage.Height = 20
                    ctrlPage.LinkColor = Color.DarkRed
                    ctrlPage.TextAlign = ContentAlignment.MiddleCenter
                    ctrlPage.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
                    ctrlPage.LinkBehavior = LinkBehavior.HoverUnderline
                    ctrlPage.AutoSize = True
                    If i = Me.CurrentPage Then
                        ctrlPage.BackColor = Color.LightGreen
                        ctrlPage.BorderStyle = BorderStyle.FixedSingle
                    End If

                    If i = startPage - 1 Then
                        ctrlPage.Text = "|<"
                        ctrlPage.AccessibleDescription = 1
                    ElseIf i = endPage + 1 Then
                        ctrlPage.Text = ">|"
                        ctrlPage.AccessibleDescription = PageCount
                    Else
                        ctrlPage.Text = i
                        ctrlPage.AccessibleDescription = i
                    End If

                    AddHandler ctrlPage.MouseClick, AddressOf LinkPage_MouseClick
                    AddHandler ctrlPage.MouseHover, AddressOf LinkPage_MouseHover
                    AddHandler ctrlPage.Enter, AddressOf LinkPage_MouseHover
                    AddHandler ctrlPage.MouseLeave, AddressOf LinkPage_MouseLeave
                    flpPageList.Controls.Add(ctrlPage)
                Next
            End If
        Else
            'CType(WG1.DataSource, DataTable).Rows.Clear()
            'flpPageList.Controls.Clear()
            If dsResult.Tables.Contains("Data.Table") Then
                WG1.DataSource = dsResult.Tables("Data.Table")
                WG1.Focus() : GV1.FocusedRowHandle = 0
            Else
                CType(WG1.DataSource, DataTable).Rows.Clear()
                flpPageList.Controls.Clear()
                txtKeyword.Focus()
            End If
        End If
        'txtKeyword.Focus()
    End Sub

    Private Sub _searchCode(ByVal nPage As Integer)
        Me.ExecuteSearch(nPage)
    End Sub

    Private Sub LinkPage_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim nPage As Integer = CType(sender, LinkLabel).AccessibleDescription
            _searchCode(nPage)
        End If
    End Sub
    Private Sub LinkPage_MouseHover(sender As System.Object, e As System.EventArgs)
        CType(sender, LinkLabel).BorderStyle = BorderStyle.FixedSingle
        CType(sender, LinkLabel).Cursor = Cursors.Hand
        CType(sender, LinkLabel).BackColor = Color.LightGoldenrodYellow
    End Sub
    Private Sub LinkPage_MouseLeave(sender As System.Object, e As System.EventArgs)
        CType(sender, LinkLabel).Cursor = Cursors.Default
        If CType(sender, LinkLabel).Text = Me.CurrentPage.ToString Then
            CType(sender, LinkLabel).BackColor = Color.LightGreen
            CType(sender, LinkLabel).BorderStyle = BorderStyle.FixedSingle
        Else
            CType(sender, LinkLabel).BackColor = Color.Transparent
            CType(sender, LinkLabel).BorderStyle = BorderStyle.None
        End If
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.ClearView()
    End Sub
    Private Sub txtKeyword_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtKeyword.PreviewKeyDown
        If e.KeyCode = Keys.Down AndAlso GV1.RowCount > 0 Then WG1.Focus() : GV1.FocusedRowHandle = 0 '
        If e.KeyCode = Keys.Enter Then
            _searchCode(1)
        End If
    End Sub
    Private Sub GV1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GV1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GV1_DoubleClick(WG1, Nothing)
        ElseIf (e.KeyCode = Keys.Up AndAlso GV1.FocusedRowHandle = 0) OrElse (e.KeyCode = Keys.Down AndAlso GV1.FocusedRowHandle = GV1.RowCount - 1) OrElse e.KeyCode = Keys.F2 Then
            txtKeyword.Focus()
            txtKeyword.SelectAll()
        End If
    End Sub

End Class