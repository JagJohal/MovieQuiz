Public Class frmQuestion1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        Me.Show()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

    End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class