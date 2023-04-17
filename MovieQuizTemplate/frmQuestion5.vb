Public Class frmQuestion5
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        tmrQuestion5.Enabled = False

        If (btnAnswer3.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion6.Show()
        frmQuestion6.init()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion5.Tick
        progressCount = progressCount + 1
        If (progressCount = 10) Then
            tmrQuestion5.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion6.Show()
            frmQuestion6.init()
            Me.Hide()
        End If
    End Sub
    Public Sub init()
        progressCount = 0
        tmrQuestion5.Enabled = True
        ProgressBarQ5.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
End Class