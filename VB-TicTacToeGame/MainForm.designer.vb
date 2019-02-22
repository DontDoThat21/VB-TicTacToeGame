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
        Me.tttoeLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.botRightBtn = New System.Windows.Forms.Button()
        Me.botMdlBtn = New System.Windows.Forms.Button()
        Me.botLeftBtn = New System.Windows.Forms.Button()
        Me.mdlRightBtn = New System.Windows.Forms.Button()
        Me.mdlMdlBtn = New System.Windows.Forms.Button()
        Me.mdlLeftBtn = New System.Windows.Forms.Button()
        Me.topRightBtn = New System.Windows.Forms.Button()
        Me.topMdlBtn = New System.Windows.Forms.Button()
        Me.topLeftBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.currentTurnLabel = New System.Windows.Forms.Label()
        Me.startGameBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tttoeLabel
        '
        Me.tttoeLabel.AutoSize = True
        Me.tttoeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tttoeLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.tttoeLabel.Location = New System.Drawing.Point(274, 23)
        Me.tttoeLabel.Name = "tttoeLabel"
        Me.tttoeLabel.Size = New System.Drawing.Size(225, 29)
        Me.tttoeLabel.TabIndex = 3
        Me.tttoeLabel.Text = "TIC TAC TOE GUI"
        Me.tttoeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.botRightBtn)
        Me.Panel2.Controls.Add(Me.botMdlBtn)
        Me.Panel2.Controls.Add(Me.botLeftBtn)
        Me.Panel2.Controls.Add(Me.mdlRightBtn)
        Me.Panel2.Controls.Add(Me.mdlMdlBtn)
        Me.Panel2.Controls.Add(Me.mdlLeftBtn)
        Me.Panel2.Controls.Add(Me.topRightBtn)
        Me.Panel2.Controls.Add(Me.topMdlBtn)
        Me.Panel2.Controls.Add(Me.topLeftBtn)
        Me.Panel2.Location = New System.Drawing.Point(98, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 490)
        Me.Panel2.TabIndex = 0
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel3.Controls.Add(Me.currentTurnLabel)
        Me.Panel3.Controls.Add(Me.startGameBtn)
        Me.Panel3.Location = New System.Drawing.Point(163, 578)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 95)
        Me.Panel3.TabIndex = 4
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
        Me.startGameBtn.Location = New System.Drawing.Point(52, 32)
        Me.startGameBtn.Name = "startGameBtn"
        Me.startGameBtn.Size = New System.Drawing.Size(137, 37)
        Me.startGameBtn.TabIndex = 0
        Me.startGameBtn.Text = "PLAY GAME"
        Me.startGameBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(13, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 726)
        Me.Panel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(666, 209)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(65, 153)
        Me.Panel4.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "O Wins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X Wins"
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(772, 812)
        Me.Controls.Add(Me.tttoeLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tttoeLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents botRightBtn As Button
    Friend WithEvents botMdlBtn As Button
    Friend WithEvents botLeftBtn As Button
    Friend WithEvents mdlRightBtn As Button
    Friend WithEvents mdlMdlBtn As Button
    Friend WithEvents mdlLeftBtn As Button
    Friend WithEvents topRightBtn As Button
    Friend WithEvents topMdlBtn As Button
    Friend WithEvents topLeftBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents currentTurnLabel As Label
    Friend WithEvents startGameBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
