Public Class frmQuestion1
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAnswer1_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer1.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (btnAnswer3.Checked) Then
            playerScore = playerScore + 1
        End If

        frmQuestion2.Show()

        Me.Hide()
    End Sub

    Private Sub btnAnswer1_CheckedChanged_1(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub
End Class