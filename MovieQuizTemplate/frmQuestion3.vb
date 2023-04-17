Public Class frmQuestion3
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If

        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub btnAnswer3_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub
End Class