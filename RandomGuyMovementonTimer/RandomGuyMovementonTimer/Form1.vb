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
            picAsh.Location = New Point(x:=-2, y:=0)
        End If
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblTimer1.Text < 50 Then
            lblTimer1.Text = lblTimer1.Text + 0.1

        ElseIf lblTimer1.Text > 50 Then
            Timer1.Stop()
        End If



        If lblTimer1.text = 5 Or lblTimer1.Text = 10 Or lblTimer1.Text = 15 Or lblTimer1.Text = 20 Then
            Dim cMove As New Random()
            Dim cMove2 As Integer = 0
            cMove2 = cMove.Next(1, 5)
            If cMove2 = 1 Then
                Timer2.Enabled = True
            End If
            If cMove2 = 2 Then
                Timer3.Enabled = True
            End If
            If cMove2 = 3 Then
                Timer4.Enabled = True
            End If
            If cMove2 = 4 Then
                Timer5.Enabled = True
            End If

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        picBlue.Left -= 5
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer2.Enabled = False

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        picBlue.Left += 5
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        picBlue.Left += 10
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        picBlue.Left -= 10
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer5.Enabled = False
        End If
    End Sub
End Class
