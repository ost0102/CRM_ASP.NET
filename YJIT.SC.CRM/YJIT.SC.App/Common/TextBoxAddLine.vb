Public Class TextBoxAddLine
    Dim mRichTextBox As System.Windows.Forms.RichTextBox = Nothing
    Dim mTextBox As YJIT.SC.UI.SCControls.TextBox = Nothing
    Dim mPictureBox As System.Windows.Forms.PictureBox = Nothing
    Dim font_height As Single

#Region "=================Data logic actions==========="
    Public Sub New(ByRef TextBox As Object, ByRef Picture As System.Windows.Forms.PictureBox)


        Select Case TextBox.GetType.FullName
            Case "System.Windows.Forms.RichTextBox"
                mRichTextBox = CType(TextBox, System.Windows.Forms.RichTextBox)
                mRichTextBox.ScrollBars = RichTextBoxScrollBars.Both
                AddHandler mRichTextBox.Resize, AddressOf RichTextBox_Resize
                AddHandler mRichTextBox.VScroll, AddressOf RichTextBox_VScroll
                mRichTextBox.Text = "A" & vbCrLf & "A" & vbCrLf
            Case "YJIT.SC.UI.SCControls.TextBox"
                mTextBox = CType(TextBox, YJIT.SC.UI.SCControls.TextBox)
                mTextBox.ScrollBars = ScrollBars.Both
                AddHandler mTextBox.Resize, AddressOf RichTextBox_Resize
                AddHandler mTextBox.KeyDown, AddressOf TextBox_KeyDown
                AddHandler mTextBox.MouseClick, AddressOf TextBox_KeyDown

            Case Else
                Exit Sub
        End Select

        mPictureBox = Picture
        '폰트와 폰트사이의 간격을 알아내기 위한 공식
        TextBox.text = "a" & vbCrLf & "a" & vbCrLf
        font_height = TextBox.GetPositionFromCharIndex(TextBox.GetFirstCharIndexFromLine(1)).Y - TextBox.GetPositionFromCharIndex(TextBox.GetFirstCharIndexFromLine(0)).Y
        TextBox.text = ""
        AddHandler mPictureBox.Paint, AddressOf PictureBox_Paint
    End Sub

    Public Sub PictuerBoxInvalidate()
        If mPictureBox Is Nothing Then Exit Sub
        mPictureBox.Invalidate()
    End Sub


#End Region
#Region "=================Control Events==========="
    Public Sub DrawRichTextBoxLineNumbers(ByRef g As Graphics)

        If font_height = 0 Then Exit Sub

        Dim obj As Object = Nothing

        If Not mRichTextBox Is Nothing Then
            obj = mRichTextBox

        ElseIf Not mTextBox Is Nothing Then
            obj = mTextBox
        Else
            Exit Sub
        End If

        Dim firstIndex As Integer = obj.GetCharIndexFromPosition(New Point(0, g.VisibleClipBounds.Y + font_height / 3))
        Dim firstLine As Integer = obj.GetLineFromCharIndex(firstIndex)
        Dim firstLineY As Integer = obj.GetPositionFromCharIndex(firstIndex).Y

        'Print on the PictureBox the visible line numbers of the RichTextBox
        '   g.Clear(Control.DefaultBackColor)
        Dim i As Integer = firstLine + 1
        Dim y As Single
        Dim Base As Single = g.VisibleClipBounds.Y + g.VisibleClipBounds.Height
        Do While y < Base
            y = 3 + font_height * (i - firstLine - 1) ' firstLineY +
            g.DrawString((i).ToString, obj.Font, Brushes.LightSkyBlue, mPictureBox.Width - g.MeasureString((i).ToString, obj.Font).Width, y)
            i += 1
        Loop
        'Debug.WriteLine("Finished: " & firstLine + 1 & " " & i - 1)
    End Sub

    Public Sub RichTextBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        PictuerBoxInvalidate()
    End Sub

    Public Sub RichTextBox_VScroll(ByVal sender As Object, ByVal e As System.EventArgs)
        PictuerBoxInvalidate()
    End Sub

    Public Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        DrawRichTextBoxLineNumbers(e.Graphics)
    End Sub

    Public Sub TextBox_KeyDown(sender As System.Object, e As System.EventArgs)
        PictuerBoxInvalidate()
    End Sub
#End Region



End Class
