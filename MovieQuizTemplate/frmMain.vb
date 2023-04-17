Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        If (txtName.Text = "") Then
            MsgBox("Please Enter Your name")
        Else
            'save the player name to the global variable
            playerName = txtName.Text
            'show the first question form
            frmQuestion1.Show()
            'use the local sub procedure to intialise the form
            frmQuestion1.init()
            'set the player name to Blank for game restart
            txtName.Text = ""
            'hide this ofrm
            Me.Hide()

        End If
        playerName = txtName.Text
        frmQuestion1.Show()
        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class