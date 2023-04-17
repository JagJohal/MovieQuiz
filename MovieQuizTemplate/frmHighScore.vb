Public Class frmHighScore
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class