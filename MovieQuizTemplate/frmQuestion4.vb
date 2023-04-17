Public Class frmQuestion4
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion4.Enabled = False

        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion5.Show()
        frmQuestion5.init()
        Me.Hide()
    End Sub




    Public Sub init()
        progressCount = 0
        tmrQuestion4.Enabled = True
        ProgressBarQ4.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub



    Private Sub tmrQuestion1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion4.Tick
        progressCount = progressCount + 1
        ProgressBarQ4.PerformStep()
        If (progressCount = 10) Then
            tmrQuestion4.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion5.Show()
            frmQuestion5.init()
            Me.Hide()
        End If
    End Sub
End Class