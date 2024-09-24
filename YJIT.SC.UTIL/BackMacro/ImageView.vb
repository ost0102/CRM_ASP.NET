Public Class ImageView

    Public Sub SetImage(ByVal ii As Object)
        PictureBox1.ImageLocation = Nothing
        PictureBox1.ImageLocation = ii
    End Sub

    Private Sub ImageView_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Common.MainForm.ImageView = Nothing
    End Sub
End Class