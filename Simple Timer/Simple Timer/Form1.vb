Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        'stops timer stops at 10 seconds'
        If timerLabel.Text < 10 Then
            timerLabel.Text = timerLabel.Text + 0.01
        ElseIf timerLabel.Text > 10 Then
            Timer.Stop()
        End If


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Starts timer when player moves'
        Timer.Start()

        'Movement Keys'
        If e.KeyCode = Keys.W Then
            player.Top = player.Top - 5
        End If

        If e.KeyCode = Keys.A Then
            player.Left = player.Left - 5
        End If

        If e.KeyCode = Keys.S Then
            player.Top = player.Top + 5
        End If

        If e.KeyCode = Keys.D Then
            player.Left = player.Left + 5
        End If

    End Sub
End Class
