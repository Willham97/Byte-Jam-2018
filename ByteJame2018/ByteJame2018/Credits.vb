Public Class frmCredits

    Private Sub frmCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.MiiChannelMusic,
              AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim menu = New frmMain()
        menu.Show()
        Me.Hide()
    End Sub
End Class