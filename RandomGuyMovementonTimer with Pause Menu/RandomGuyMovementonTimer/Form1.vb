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

    Friend Shared Function pausescreen() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblTimer1.Text < 50 Then
            lblTimer1.Text = lblTimer1.Text + 0.1

        ElseIf lblTimer1.Text > 50 Then
            Timer1.Stop()
        End If



        If lblTimer1.text = 5 Or lblTimer1.Text = 10 Or lblTimer1.Text = 15 Or lblTimer1.Text = 20 Then
            Dim cMove As New Random()
            Dim cMove2 As Integer = 0
            cMove2 = cMove.Next(1, 9)
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
            If cMove2 = 5 Then
                Timer6.Enabled = True
            End If
            If cMove2 = 6 Then
                Timer7.Enabled = True
            End If
            If cMove2 = 7 Then
                Timer8.Enabled = True
            End If
            If cMove2 = 8 Then
                Timer9.Enabled = True
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

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        picBlue.Left += 100
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer6.Enabled = False
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        picBlue.Left -= 100
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer7.Enabled = False
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        picBlue.Left += 50
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer8.Enabled = False
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        picBlue.Left -= 50
        If lblTimer1.Text = 8 Or lblTimer1.Text = 13 Or lblTimer1.Text = 18 Or lblTimer1.Text = 23 Then
            Timer9.Enabled = False
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        Static Paused As Boolean = False

        Static Unpause As Boolean = True



        If e.KeyChar = "P" Or e.KeyChar = "p" And Paused = False Then
                Timer1.Stop()
                Paused = True
                Unpause = False
                Dim pausescreen As New Pause()
                pausescreen.Show()
            ElseIf e.KeyChar = "P" Or e.KeyChar = "p" And Unpause = False Then
            Unpause = True
            Paused = False
            Timer1.Enabled = True

        End If



        '    If e.KeyChar = "P" Or e.KeyChar = "p" Then
        '        If Paused = True Then
        '            Timer1.Enabled = True
        '            Paused = False
        '        Else
        '            Enabled = False
        '            Paused = True
        '        End If
        '    End If
    End Sub

End Class
