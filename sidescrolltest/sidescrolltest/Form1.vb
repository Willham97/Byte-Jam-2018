Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Enabled = False
            Case Keys.Left
                tmrLeft.Enabled = False
        End Select
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Enabled = True
                tmrLeft.Enabled = False
            Case Keys.Left
                tmrRight.Enabled = False
                tmrLeft.Enabled = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim Objects() As PictureBox = {picOb2, picOb1}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= 3
        Next
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim Objects() As PictureBox = {picOb2, picOb1}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += 3
        Next
    End Sub
End Class
