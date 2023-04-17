Public Class frmQuestion1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        tmrQuestion1.Enabled = False

        If (btnAnswer2.Checked) Then
            playerScore = playerScore + 1
        End If
        frmQuestion2.Show()
        frmQuestion2.InitializeLifetimeService()
        Me.Hide()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmQuestion1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrQuestion1.Tick
        progressCount = progressCount + 1
        If (progressCount = 10) Then
            tmrQuestion1.Enabled = False
            MsgBox("Too Slow Try Again")
            frmQuestion2.Show()
            frmQuestion2.InitializeLifetimeService()
            Me.Hide()
        End If
    End Sub
    Public Sub init()
        progressCount = 0
        tmrQuestion1.Enabled = True
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub
End Class