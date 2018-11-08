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

                'experimental movement (can't go through objects, can go over, buggy)
                Dim Objects() As PictureBox = {picOb1, picOb2}
                For x = 0 To Objects.Length - 1
                    If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) Then
                        tmrRight.Enabled = False
                    End If
                Next

            Case Keys.Left
                tmrRight.Enabled = False
                tmrLeft.Enabled = True

                'experimental movement (can't go through objects, can go over, buggy)
                Dim Objects() As PictureBox = {picOb1, picOb2}
                For x = 0 To Objects.Length - 1
                    If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) Then
                        tmrLeft.Enabled = False
                    End If
                Next

            Case Keys.Up
                If blnJump = True Then
                    tmrUp.Enabled = True
                    blnJump = False
                End If
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim Objects() As PictureBox = {picOb1, picOb2, picGround}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= 5
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
        Dim Objects() As PictureBox = {picOb1, picOb2, picGround}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += 5
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
        If x < 30 Then
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

        'Array for objects that let's players jump on top of them - AD
        Dim Objects() As PictureBox = {picOb1, picOb2}
        For x = 0 To Objects.Length - 1
            If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And tmrUp.Enabled = False Then
                tmrDown.Enabled = False
                blnJump = True
            End If

            'experimental movement (can't go through objects, can go over, buggy)
            If picPlayer.Bounds.IntersectsWith(Objects(x).Bounds) And Not (picPlayer.Top + picPlayer.Height) < (Objects(x).Top + 20) Then
                tmrLeft.Enabled = False
                tmrRight.Enabled = False
            End If

        Next

    End Sub
End Class
