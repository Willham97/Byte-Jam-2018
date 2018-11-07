Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayLoopingBackgroundSound()


        lblTitle.Location = New Point(pnlTitle.ClientSize.Width, pnlTitle.ClientSize.Height / 2 - (lblTitle.Height / 2))
        tmrTitleAnimate.Start()




    End Sub

    Sub PlayLoopingBackgroundSound()
        My.Computer.Audio.Play(My.Resources.KeyboardCat,
              AudioPlayMode.BackgroundLoop)


    End Sub
    Private Sub tmrTitleAnimate_Tick(sender As Object, e As EventArgs) Handles tmrTitleAnimate.Tick
        If lblTitle.Right < 0 Then
            lblTitle.Left = pnlTitle.ClientSize.Width
        Else
            lblTitle.Left -= 10
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
