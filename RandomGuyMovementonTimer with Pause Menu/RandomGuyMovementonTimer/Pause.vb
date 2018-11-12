Public Class Pause
    Private Sub Pause_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "P" Or e.KeyChar = "p" Then
            Close()

        End If
    End Sub

End Class