Public Class frmHighScore
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Public Sub doscore()
        If (playerScore < 1) Then
            lblmessage.text = "sorry Your Score Was Not Good Enough"
        Else
            lblmessage.text = "Congratulations Your Score Will Be Added To The Hall of Fame "
            lstHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)
        End If
    End Sub

    Private Sub frmHighScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class