<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ticTacToeLabel = New System.Windows.Forms.Label()
        Me.innerPanel1 = New System.Windows.Forms.Panel()
        Me.botRightBtn = New System.Windows.Forms.Button()
        Me.botMdlBtn = New System.Windows.Forms.Button()
        Me.botLeftBtn = New System.Windows.Forms.Button()
        Me.mdlRightBtn = New System.Windows.Forms.Button()
        Me.mdlMdlBtn = New System.Windows.Forms.Button()
        Me.mdlLeftBtn = New System.Windows.Forms.Button()
        Me.topRightBtn = New System.Windows.Forms.Button()
        Me.topMdlBtn = New System.Windows.Forms.Button()
        Me.topLeftBtn = New System.Windows.Forms.Button()
        Me.innerPanel2 = New System.Windows.Forms.Panel()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.currentTurnLabel = New System.Windows.Forms.Label()
        Me.startGameBtn = New System.Windows.Forms.Button()
        Me.outerPanel1 = New System.Windows.Forms.Panel()
        Me.scorePanel = New System.Windows.Forms.Panel()
        Me.oWinsCountLabel = New System.Windows.Forms.Label()
        Me.oWinsLabel = New System.Windows.Forms.Label()
        Me.xWinsCountLabel = New System.Windows.Forms.Label()
        Me.xWinsLabel = New System.Windows.Forms.Label()
        Me.innerPanel1.SuspendLayout()
        Me.innerPanel2.SuspendLayout()
        Me.outerPanel1.SuspendLayout()
        Me.scorePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ticTacToeLabel
        '
        Me.ticTacToeLabel.AutoSize = True
        Me.ticTacToeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ticTacToeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ticTacToeLabel.Location = New System.Drawing.Point(274, 23)
        Me.ticTacToeLabel.Name = "ticTacToeLabel"
        Me.ticTacToeLabel.Size = New System.Drawing.Size(225, 29)
        Me.ticTacToeLabel.TabIndex = 3
        Me.ticTacToeLabel.Text = "TIC TAC TOE GUI"
        Me.ticTacToeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'innerPanel1
        '
        Me.innerPanel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.innerPanel1.Controls.Add(Me.botRightBtn)
        Me.innerPanel1.Controls.Add(Me.botMdlBtn)
        Me.innerPanel1.Controls.Add(Me.botLeftBtn)
        Me.innerPanel1.Controls.Add(Me.mdlRightBtn)
        Me.innerPanel1.Controls.Add(Me.mdlMdlBtn)
        Me.innerPanel1.Controls.Add(Me.mdlLeftBtn)
        Me.innerPanel1.Controls.Add(Me.topRightBtn)
        Me.innerPanel1.Controls.Add(Me.topMdlBtn)
        Me.innerPanel1.Controls.Add(Me.topLeftBtn)
        Me.innerPanel1.Location = New System.Drawing.Point(98, 40)
        Me.innerPanel1.Name = "innerPanel1"
        Me.innerPanel1.Size = New System.Drawing.Size(548, 490)
        Me.innerPanel1.TabIndex = 0
        '
        'botRightBtn
        '
        Me.botRightBtn.Enabled = False
        Me.botRightBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRightBtn.Location = New System.Drawing.Point(367, 328)
        Me.botRightBtn.Name = "botRightBtn"
        Me.botRightBtn.Size = New System.Drawing.Size(174, 153)
        Me.botRightBtn.TabIndex = 8
        Me.botRightBtn.UseVisualStyleBackColor = True
        '
        'botMdlBtn
        '
        Me.botMdlBtn.Enabled = False
        Me.botMdlBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botMdlBtn.Location = New System.Drawing.Point(187, 328)
        Me.botMdlBtn.Name = "botMdlBtn"
        Me.botMdlBtn.Size = New System.Drawing.Size(174, 153)
        Me.botMdlBtn.TabIndex = 7
        Me.botMdlBtn.UseVisualStyleBackColor = True
        '
        'botLeftBtn
        '
        Me.botLeftBtn.Enabled = False
        Me.botLeftBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLeftBtn.Location = New System.Drawing.Point(7, 328)
        Me.botLeftBtn.Name = "botLeftBtn"
        Me.botLeftBtn.Size = New System.Drawing.Size(174, 153)
        Me.botLeftBtn.TabIndex = 6
        Me.botLeftBtn.UseVisualStyleBackColor = True
        '
        'mdlRightBtn
        '
        Me.mdlRightBtn.Enabled = False
        Me.mdlRightBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlRightBtn.Location = New System.Drawing.Point(367, 169)
        Me.mdlRightBtn.Name = "mdlRightBtn"
        Me.mdlRightBtn.Size = New System.Drawing.Size(174, 153)
        Me.mdlRightBtn.TabIndex = 5
        Me.mdlRightBtn.UseVisualStyleBackColor = True
        '
        'mdlMdlBtn
        '
        Me.mdlMdlBtn.Enabled = False
        Me.mdlMdlBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlMdlBtn.Location = New System.Drawing.Point(187, 169)
        Me.mdlMdlBtn.Name = "mdlMdlBtn"
        Me.mdlMdlBtn.Size = New System.Drawing.Size(174, 153)
        Me.mdlMdlBtn.TabIndex = 4
        Me.mdlMdlBtn.UseVisualStyleBackColor = True
        '
        'mdlLeftBtn
        '
        Me.mdlLeftBtn.Enabled = False
        Me.mdlLeftBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlLeftBtn.Location = New System.Drawing.Point(7, 169)
        Me.mdlLeftBtn.Name = "mdlLeftBtn"
        Me.mdlLeftBtn.Size = New System.Drawing.Size(174, 153)
        Me.mdlLeftBtn.TabIndex = 3
        Me.mdlLeftBtn.UseVisualStyleBackColor = True
        '
        'topRightBtn
        '
        Me.topRightBtn.Enabled = False
        Me.topRightBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topRightBtn.Location = New System.Drawing.Point(367, 10)
        Me.topRightBtn.Name = "topRightBtn"
        Me.topRightBtn.Size = New System.Drawing.Size(174, 153)
        Me.topRightBtn.TabIndex = 2
        Me.topRightBtn.UseVisualStyleBackColor = True
        '
        'topMdlBtn
        '
        Me.topMdlBtn.Enabled = False
        Me.topMdlBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topMdlBtn.Location = New System.Drawing.Point(187, 10)
        Me.topMdlBtn.Name = "topMdlBtn"
        Me.topMdlBtn.Size = New System.Drawing.Size(174, 153)
        Me.topMdlBtn.TabIndex = 1
        Me.topMdlBtn.UseVisualStyleBackColor = True
        '
        'topLeftBtn
        '
        Me.topLeftBtn.Enabled = False
        Me.topLeftBtn.Font = New System.Drawing.Font("Ink Free", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLeftBtn.Location = New System.Drawing.Point(7, 10)
        Me.topLeftBtn.Name = "topLeftBtn"
        Me.topLeftBtn.Size = New System.Drawing.Size(174, 153)
        Me.topLeftBtn.TabIndex = 0
        Me.topLeftBtn.UseVisualStyleBackColor = True
        '
        'innerPanel2
        '
        Me.innerPanel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.innerPanel2.Controls.Add(Me.settingsBtn)
        Me.innerPanel2.Controls.Add(Me.currentTurnLabel)
        Me.innerPanel2.Controls.Add(Me.startGameBtn)
        Me.innerPanel2.Location = New System.Drawing.Point(163, 578)
        Me.innerPanel2.Name = "innerPanel2"
        Me.innerPanel2.Size = New System.Drawing.Size(420, 95)
        Me.innerPanel2.TabIndex = 4
        '
        'settingsBtn
        '
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.settingsBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.settingsBtn.Location = New System.Drawing.Point(48, 50)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(137, 37)
        Me.settingsBtn.TabIndex = 2
        Me.settingsBtn.Text = "SETTINGS"
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'currentTurnLabel
        '
        Me.currentTurnLabel.AutoSize = True
        Me.currentTurnLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.currentTurnLabel.Location = New System.Drawing.Point(230, 26)
        Me.currentTurnLabel.Name = "currentTurnLabel"
        Me.currentTurnLabel.Padding = New System.Windows.Forms.Padding(50, 15, 50, 15)
        Me.currentTurnLabel.Size = New System.Drawing.Size(139, 43)
        Me.currentTurnLabel.TabIndex = 1
        Me.currentTurnLabel.Text = "Z Turn"
        '
        'startGameBtn
        '
        Me.startGameBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.startGameBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.startGameBtn.Location = New System.Drawing.Point(48, 7)
        Me.startGameBtn.Name = "startGameBtn"
        Me.startGameBtn.Size = New System.Drawing.Size(137, 37)
        Me.startGameBtn.TabIndex = 0
        Me.startGameBtn.Text = "PLAY GAME"
        Me.startGameBtn.UseVisualStyleBackColor = True
        '
        'outerPanel1
        '
        Me.outerPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.outerPanel1.Controls.Add(Me.scorePanel)
        Me.outerPanel1.Controls.Add(Me.innerPanel2)
        Me.outerPanel1.Controls.Add(Me.innerPanel1)
        Me.outerPanel1.Location = New System.Drawing.Point(13, 74)
        Me.outerPanel1.Name = "outerPanel1"
        Me.outerPanel1.Size = New System.Drawing.Size(747, 726)
        Me.outerPanel1.TabIndex = 2
        '
        'scorePanel
        '
        Me.scorePanel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.scorePanel.Controls.Add(Me.oWinsCountLabel)
        Me.scorePanel.Controls.Add(Me.oWinsLabel)
        Me.scorePanel.Controls.Add(Me.xWinsCountLabel)
        Me.scorePanel.Controls.Add(Me.xWinsLabel)
        Me.scorePanel.Location = New System.Drawing.Point(666, 209)
        Me.scorePanel.Name = "scorePanel"
        Me.scorePanel.Size = New System.Drawing.Size(65, 153)
        Me.scorePanel.TabIndex = 5
        '
        'oWinsCountLabel
        '
        Me.oWinsCountLabel.AutoSize = True
        Me.oWinsCountLabel.Location = New System.Drawing.Point(26, 112)
        Me.oWinsCountLabel.Name = "oWinsCountLabel"
        Me.oWinsCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.oWinsCountLabel.TabIndex = 3
        Me.oWinsCountLabel.Text = "0"
        '
        'oWinsLabel
        '
        Me.oWinsLabel.AutoSize = True
        Me.oWinsLabel.Location = New System.Drawing.Point(11, 99)
        Me.oWinsLabel.Name = "oWinsLabel"
        Me.oWinsLabel.Size = New System.Drawing.Size(42, 13)
        Me.oWinsLabel.TabIndex = 2
        Me.oWinsLabel.Text = "O Wins"
        '
        'xWinsCountLabel
        '
        Me.xWinsCountLabel.AutoSize = True
        Me.xWinsCountLabel.Location = New System.Drawing.Point(26, 24)
        Me.xWinsCountLabel.Name = "xWinsCountLabel"
        Me.xWinsCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.xWinsCountLabel.TabIndex = 1
        Me.xWinsCountLabel.Text = "0"
        '
        'xWinsLabel
        '
        Me.xWinsLabel.AutoSize = True
        Me.xWinsLabel.Location = New System.Drawing.Point(11, 11)
        Me.xWinsLabel.Name = "xWinsLabel"
        Me.xWinsLabel.Size = New System.Drawing.Size(41, 13)
        Me.xWinsLabel.TabIndex = 0
        Me.xWinsLabel.Text = "X Wins"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(772, 812)
        Me.Controls.Add(Me.ticTacToeLabel)
        Me.Controls.Add(Me.outerPanel1)
        Me.Name = "TicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.innerPanel1.ResumeLayout(False)
        Me.innerPanel2.ResumeLayout(False)
        Me.innerPanel2.PerformLayout()
        Me.outerPanel1.ResumeLayout(False)
        Me.scorePanel.ResumeLayout(False)
        Me.scorePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ticTacToeLabel As Label
    Friend WithEvents innerPanel1 As Panel
    Friend WithEvents botRightBtn As Button
    Friend WithEvents botMdlBtn As Button
    Friend WithEvents botLeftBtn As Button
    Friend WithEvents mdlRightBtn As Button
    Friend WithEvents mdlMdlBtn As Button
    Friend WithEvents mdlLeftBtn As Button
    Friend WithEvents topRightBtn As Button
    Friend WithEvents topMdlBtn As Button
    Friend WithEvents topLeftBtn As Button
    Friend WithEvents innerPanel2 As Panel
    Friend WithEvents currentTurnLabel As Label
    Friend WithEvents startGameBtn As Button
    Friend WithEvents outerPanel1 As Panel
    Friend WithEvents scorePanel As Panel
    Friend WithEvents oWinsCountLabel As Label
    Friend WithEvents oWinsLabel As Label
    Friend WithEvents xWinsCountLabel As Label
    Friend WithEvents xWinsLabel As Label
    Friend WithEvents settingsBtn As Button
End Class
