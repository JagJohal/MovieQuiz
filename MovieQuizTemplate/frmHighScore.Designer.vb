﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstHighScore = New System.Windows.Forms.ListBox()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
        '
        'lstHighScore
        '
        Me.lstHighScore.FormattingEnabled = True
        Me.lstHighScore.Location = New System.Drawing.Point(192, 96)
        Me.lstHighScore.Name = "lstHighScore"
        Me.lstHighScore.Size = New System.Drawing.Size(411, 186)
        Me.lstHighScore.TabIndex = 1
        '
        'btnAgain
        '
        Me.btnAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgain.Location = New System.Drawing.Point(518, 307)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(257, 64)
        Me.btnAgain.TabIndex = 2
        Me.btnAgain.Text = "AGAIN"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(518, 377)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(256, 61)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Location = New System.Drawing.Point(198, 309)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(0, 13)
        Me.lblmessage.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(212, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "lblmessage"
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.lstHighScore)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstHighScore As ListBox
    Friend WithEvents btnAgain As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblmessage As Label
    Friend WithEvents Label2 As Label
End Class
