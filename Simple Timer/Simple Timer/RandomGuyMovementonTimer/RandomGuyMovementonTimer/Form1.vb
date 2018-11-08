Public Class Form1


    Private Sub form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Timer1.Start()
        Timer2.Start()

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
            picAsh.Location = New Point(x:=-2, y:=0)
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblTimer1.Text < 50 Then
            lblTimer1.Text = lblTimer1.Text + 0.1

        ElseIf lblTimer1.Text > 50 Then
            Timer1.Stop()
        End If

        Dim iSec = lblTimer1.Text

        If lblTimer1.Text = 10 Then
            Dim cMove As New Random()
            Dim cMove2 As Integer = 0
            cMove2 = cMove.Next(1, 3)
            If cMove2 = 1 Then
                Timer2.Enabled = True
            End If
            If cMove2 = 2 Then
                picBlue.Left += 10
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picBlue.Left -= 5
        If lblTimer1.Text = 10 Then
            Timer2.Enabled = False

        End If
    End Sub
End Class
