Public Class frmQuestion6
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        tmrQuestion6.Enabled = False

        If (btnAnswer4.Checked) Then
            playerScore = playerScore + 1
        End If
        frmHighScore.Show()
        frmHighScore.doscore()
        Me.Hide()

    End Sub
    Public Sub init()
        progressCount = 0
        tmrQuestion6.Enabled = True
        ProgressBarQ6.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAmswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub

    Private Sub tmrQuestion3_Tick(sender As Object, e As EventArgs) Handles tmrQuestion6.Tick
        progressCount += 1
        ProgressBarQ6.PerformStep()

        If (progressCount = 10) Then
            tmrQuestion6.Enabled = False
            MsgBox("Too Slow Try Again")
            frmHighScore.Show()
            frmHighScore.doscore()
            Me.Hide()
        End If
    End Sub

    Private Sub ProgressBarQ6_Click(sender As Object, e As EventArgs) Handles ProgressBarQ6.Click

    End Sub
End Class