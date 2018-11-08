Public Class frmMain
    Private faceLeft = False
    Private faceRight = True
    Private blnJump As Boolean = True
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
            Case Keys.Up
                If blnJump = True Then
                    tmrUp.Enabled = True
                    blnJump = False
                End If
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim Objects() As PictureBox = {picOb2, picOb1, picGround}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= 3
        Next
        'Faces the player right when moving right -AD
        If faceRight = False Then
            picPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            faceRight = True
            faceLeft = False
            picPlayer.Refresh()
        End If
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        Dim Objects() As PictureBox = {picOb2, picOb1, picGround}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += 3
        Next
        'Faces the player left when moving left -AD
        If faceLeft = False Then
            picPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
            faceLeft = True
            faceRight = False
            picPlayer.Refresh()
        End If
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        Static x As Integer = 0
        If x < 20 Then
            picPlayer.Top -= 6
        Else
            tmrUp.Enabled = False
            tmrDown.Enabled = True
            x = 0
        End If
        x += 1
    End Sub

    Private Sub tmrDown_Tick(sender As Object, e As EventArgs) Handles tmrDown.Tick
        picPlayer.Top += 6
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) AndAlso (picPlayer.Top + picPlayer.Height) < (picGround.Top + 10) Then
            tmrDown.Enabled = False
            blnJump = True
        End If
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        If Not picPlayer.Bounds.IntersectsWith(picGround.Bounds) And tmrUp.Enabled = False Then
            tmrDown.Enabled = True
        End If
    End Sub
End Class
