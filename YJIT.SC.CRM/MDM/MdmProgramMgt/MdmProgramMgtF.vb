Public Class MdmProgramMgtF
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class