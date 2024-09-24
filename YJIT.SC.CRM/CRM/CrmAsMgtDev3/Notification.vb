Imports System.Drawing

Public Class Notification
    Dim i As Integer

    Private Sub Notification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - 200, Screen.PrimaryScreen.Bounds.Height - 100)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Me.Opacity = 0 Then Me.Close()

        If i = 30 Then
            Me.Opacity -= 0.02
        End If

        If Not Me.Location.Y = Screen.PrimaryScreen.WorkingArea.Height - 100 Then
            Me.Location = New Point(Me.Location.X, Me.Location.Y - 2)
        End If
        If Not i = 30 Then i += 1


    End Sub
End Class