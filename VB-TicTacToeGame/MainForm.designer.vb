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
        Me.ticTacToeLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ticTacToeLabel.AutoSize = True
        Me.ticTacToeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ticTacToeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.ticTacToeLabel.Location = New System.Drawing.Point(365, 28)
        Me.ticTacToeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ticTacToeLabel.Name = "ticTacToeLabel"
        Me.ticTacToeLabel.Size = New System.Drawing.Size(271, 33)
        Me.ticTacToeLabel.TabIndex = 3
        Me.ticTacToeLabel.Text = "TIC TAC TOE GUI"
        Me.ticTacToeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'innerPanel1
        '
        Me.innerPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.innerPanel1.Location = New System.Drawing.Point(131, 49)
        Me.innerPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.innerPanel1.Name = "innerPanel1"
        Me.innerPanel1.Size = New System.Drawing.Size(731, 603)
        Me.innerPanel1.TabIndex = 0
        '
        'botRightBtn
        '
        Me.botRightBtn.Enabled = False
        Me.botRightBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botRightBtn.Location = New System.Drawing.Point(489, 404)
        Me.botRightBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botRightBtn.Name = "botRightBtn"
        Me.botRightBtn.Size = New System.Drawing.Size(232, 188)
        Me.botRightBtn.TabIndex = 8
        Me.botRightBtn.UseVisualStyleBackColor = True
        '
        'botMdlBtn
        '
        Me.botMdlBtn.Enabled = False
        Me.botMdlBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botMdlBtn.Location = New System.Drawing.Point(249, 404)
        Me.botMdlBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botMdlBtn.Name = "botMdlBtn"
        Me.botMdlBtn.Size = New System.Drawing.Size(232, 188)
        Me.botMdlBtn.TabIndex = 7
        Me.botMdlBtn.UseVisualStyleBackColor = True
        '
        'botLeftBtn
        '
        Me.botLeftBtn.Enabled = False
        Me.botLeftBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botLeftBtn.Location = New System.Drawing.Point(9, 404)
        Me.botLeftBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.botLeftBtn.Name = "botLeftBtn"
        Me.botLeftBtn.Size = New System.Drawing.Size(232, 188)
        Me.botLeftBtn.TabIndex = 6
        Me.botLeftBtn.UseVisualStyleBackColor = True
        '
        'mdlRightBtn
        '
        Me.mdlRightBtn.Enabled = False
        Me.mdlRightBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlRightBtn.Location = New System.Drawing.Point(489, 208)
        Me.mdlRightBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mdlRightBtn.Name = "mdlRightBtn"
        Me.mdlRightBtn.Size = New System.Drawing.Size(232, 188)
        Me.mdlRightBtn.TabIndex = 5
        Me.mdlRightBtn.UseVisualStyleBackColor = True
        '
        'mdlMdlBtn
        '
        Me.mdlMdlBtn.Enabled = False
        Me.mdlMdlBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlMdlBtn.Location = New System.Drawing.Point(249, 208)
        Me.mdlMdlBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mdlMdlBtn.Name = "mdlMdlBtn"
        Me.mdlMdlBtn.Size = New System.Drawing.Size(232, 188)
        Me.mdlMdlBtn.TabIndex = 4
        Me.mdlMdlBtn.UseVisualStyleBackColor = True
        '
        'mdlLeftBtn
        '
        Me.mdlLeftBtn.Enabled = False
        Me.mdlLeftBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdlLeftBtn.Location = New System.Drawing.Point(9, 208)
        Me.mdlLeftBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mdlLeftBtn.Name = "mdlLeftBtn"
        Me.mdlLeftBtn.Size = New System.Drawing.Size(232, 188)
        Me.mdlLeftBtn.TabIndex = 3
        Me.mdlLeftBtn.UseVisualStyleBackColor = True
        '
        'topRightBtn
        '
        Me.topRightBtn.Enabled = False
        Me.topRightBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topRightBtn.Location = New System.Drawing.Point(489, 12)
        Me.topRightBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.topRightBtn.Name = "topRightBtn"
        Me.topRightBtn.Size = New System.Drawing.Size(232, 188)
        Me.topRightBtn.TabIndex = 2
        Me.topRightBtn.UseVisualStyleBackColor = True
        '
        'topMdlBtn
        '
        Me.topMdlBtn.Enabled = False
        Me.topMdlBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topMdlBtn.Location = New System.Drawing.Point(249, 12)
        Me.topMdlBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.topMdlBtn.Name = "topMdlBtn"
        Me.topMdlBtn.Size = New System.Drawing.Size(232, 188)
        Me.topMdlBtn.TabIndex = 1
        Me.topMdlBtn.UseVisualStyleBackColor = True
        '
        'topLeftBtn
        '
        Me.topLeftBtn.Enabled = False
        Me.topLeftBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topLeftBtn.Location = New System.Drawing.Point(9, 12)
        Me.topLeftBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.topLeftBtn.Name = "topLeftBtn"
        Me.topLeftBtn.Size = New System.Drawing.Size(232, 188)
        Me.topLeftBtn.TabIndex = 0
        Me.topLeftBtn.UseVisualStyleBackColor = True
        '
        'innerPanel2
        '
        Me.innerPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innerPanel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.innerPanel2.Controls.Add(Me.settingsBtn)
        Me.innerPanel2.Controls.Add(Me.currentTurnLabel)
        Me.innerPanel2.Controls.Add(Me.startGameBtn)
        Me.innerPanel2.Location = New System.Drawing.Point(217, 711)
        Me.innerPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.innerPanel2.Name = "innerPanel2"
        Me.innerPanel2.Size = New System.Drawing.Size(560, 117)
        Me.innerPanel2.TabIndex = 4
        '
        'settingsBtn
        '
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.settingsBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.settingsBtn.Location = New System.Drawing.Point(64, 62)
        Me.settingsBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(183, 46)
        Me.settingsBtn.TabIndex = 2
        Me.settingsBtn.Text = "SETTINGS"
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'currentTurnLabel
        '
        Me.currentTurnLabel.AutoSize = True
        Me.currentTurnLabel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.currentTurnLabel.Location = New System.Drawing.Point(307, 32)
        Me.currentTurnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentTurnLabel.Name = "currentTurnLabel"
        Me.currentTurnLabel.Padding = New System.Windows.Forms.Padding(67, 18, 67, 18)
        Me.currentTurnLabel.Size = New System.Drawing.Size(185, 53)
        Me.currentTurnLabel.TabIndex = 1
        Me.currentTurnLabel.Text = "Z Turn"
        '
        'startGameBtn
        '
        Me.startGameBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.startGameBtn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.startGameBtn.Location = New System.Drawing.Point(64, 9)
        Me.startGameBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.startGameBtn.Name = "startGameBtn"
        Me.startGameBtn.Size = New System.Drawing.Size(183, 46)
        Me.startGameBtn.TabIndex = 0
        Me.startGameBtn.Text = "PLAY GAME"
        Me.startGameBtn.UseVisualStyleBackColor = True
        '
        'outerPanel1
        '
        Me.outerPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.outerPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.outerPanel1.Controls.Add(Me.scorePanel)
        Me.outerPanel1.Controls.Add(Me.innerPanel2)
        Me.outerPanel1.Controls.Add(Me.innerPanel1)
        Me.outerPanel1.Location = New System.Drawing.Point(17, 91)
        Me.outerPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.outerPanel1.Name = "outerPanel1"
        Me.outerPanel1.Size = New System.Drawing.Size(996, 894)
        Me.outerPanel1.TabIndex = 2
        '
        'scorePanel
        '
        Me.scorePanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.scorePanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.scorePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.scorePanel.Controls.Add(Me.oWinsCountLabel)
        Me.scorePanel.Controls.Add(Me.oWinsLabel)
        Me.scorePanel.Controls.Add(Me.xWinsCountLabel)
        Me.scorePanel.Controls.Add(Me.xWinsLabel)
        Me.scorePanel.Location = New System.Drawing.Point(888, 257)
        Me.scorePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scorePanel.Name = "scorePanel"
        Me.scorePanel.Size = New System.Drawing.Size(86, 188)
        Me.scorePanel.TabIndex = 5
        '
        'oWinsCountLabel
        '
        Me.oWinsCountLabel.AutoSize = True
        Me.oWinsCountLabel.Location = New System.Drawing.Point(35, 138)
        Me.oWinsCountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.oWinsCountLabel.Name = "oWinsCountLabel"
        Me.oWinsCountLabel.Size = New System.Drawing.Size(16, 17)
        Me.oWinsCountLabel.TabIndex = 3
        Me.oWinsCountLabel.Text = "0"
        '
        'oWinsLabel
        '
        Me.oWinsLabel.AutoSize = True
        Me.oWinsLabel.Location = New System.Drawing.Point(15, 122)
        Me.oWinsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.oWinsLabel.Name = "oWinsLabel"
        Me.oWinsLabel.Size = New System.Drawing.Size(54, 17)
        Me.oWinsLabel.TabIndex = 2
        Me.oWinsLabel.Text = "O Wins"
        '
        'xWinsCountLabel
        '
        Me.xWinsCountLabel.AutoSize = True
        Me.xWinsCountLabel.Location = New System.Drawing.Point(35, 30)
        Me.xWinsCountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.xWinsCountLabel.Name = "xWinsCountLabel"
        Me.xWinsCountLabel.Size = New System.Drawing.Size(16, 17)
        Me.xWinsCountLabel.TabIndex = 1
        Me.xWinsCountLabel.Text = "0"
        '
        'xWinsLabel
        '
        Me.xWinsLabel.AutoSize = True
        Me.xWinsLabel.Location = New System.Drawing.Point(15, 14)
        Me.xWinsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.xWinsLabel.Name = "xWinsLabel"
        Me.xWinsLabel.Size = New System.Drawing.Size(52, 17)
        Me.xWinsLabel.TabIndex = 0
        Me.xWinsLabel.Text = "X Wins"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1029, 999)
        Me.Controls.Add(Me.ticTacToeLabel)
        Me.Controls.Add(Me.outerPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
