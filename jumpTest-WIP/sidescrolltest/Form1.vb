Public Class Form1
    Private faceLeft = False
    Private faceRight = True
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
        Static btnRight As Boolean = False
        Static btnLeft As Boolean = False

        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Enabled = True
                tmrLeft.Enabled = False
                btnRight = True
                btnLeft = False
            Case Keys.Left
                tmrRight.Enabled = False
                tmrLeft.Enabled = True
                btnLeft = True
                btnRight = False

                'Up arrow allows player to jump. moveRight and moveLeft subs allow for diagonal movement - AD
            Case Keys.Up

                For jumpUp As Integer = 0 To 30 Step 1
                    If btnRight = True Then
                        moveRight()
                    ElseIf btnLeft = True Then
                        moveLeft()
                    End If
                    picPlayer.Top -= 3
                        System.Threading.Thread.Sleep(10)
                        Refresh()
                    Next jumpUp
                For jumpDown As Integer = 0 To 30 Step 1
                    If btnRight = True Then
                        moveRight()
                    ElseIf btnLeft = True Then
                        moveLeft()
                    End If
                    picPlayer.Top += 3
                    System.Threading.Thread.Sleep(10)
                    Refresh()
                Next jumpDown

        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Dim Objects() As PictureBox = {picOb2, picOb1}
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
        Dim Objects() As PictureBox = {picOb2, picOb1}
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
    Sub moveRight()
        Dim Objects() As PictureBox = {picOb2, picOb1}
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

    Sub moveLeft()
        Dim Objects() As PictureBox = {picOb2, picOb1}
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
End Class
