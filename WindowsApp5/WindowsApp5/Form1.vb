Public Class Form1


    Private Sub form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.D Then
            picAsh.Left += 10
        ElseIf e.KeyCode = Keys.A Then
            picAsh.Left -= 10
        ElseIf e.KeyCode = Keys.W Then
            picAsh.Top -= 10
        ElseIf e.KeyCode = Keys.S Then
            picAsh.Top += 10
        End If


        If picAsh.Bounds.IntersectsWith(picPhoenix.Bounds) Then
            picPhoenix.Visible = False
        End If
    End Sub
End Class
