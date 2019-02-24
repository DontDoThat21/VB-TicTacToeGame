<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Me.mainGroupBox = New System.Windows.Forms.GroupBox()
        Me.playerCountLabel = New System.Windows.Forms.Label()
        Me.twoPlayerButton = New System.Windows.Forms.RadioButton()
        Me.onePlayerButton = New System.Windows.Forms.RadioButton()
        Me.difficultySettingLabel = New System.Windows.Forms.Label()
        Me.difficultyTrackBar = New System.Windows.Forms.TrackBar()
        Me.mainGroupBox.SuspendLayout()
        CType(Me.difficultyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainGroupBox
        '
        Me.mainGroupBox.Controls.Add(Me.playerCountLabel)
        Me.mainGroupBox.Controls.Add(Me.twoPlayerButton)
        Me.mainGroupBox.Controls.Add(Me.onePlayerButton)
        Me.mainGroupBox.Controls.Add(Me.difficultySettingLabel)
        Me.mainGroupBox.Controls.Add(Me.difficultyTrackBar)
        Me.mainGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.mainGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.mainGroupBox.Name = "mainGroupBox"
        Me.mainGroupBox.Size = New System.Drawing.Size(234, 219)
        Me.mainGroupBox.TabIndex = 0
        Me.mainGroupBox.TabStop = False
        Me.mainGroupBox.Text = "Settings"
        '
        'playerCountLabel
        '
        Me.playerCountLabel.AutoSize = True
        Me.playerCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.playerCountLabel.Location = New System.Drawing.Point(53, 49)
        Me.playerCountLabel.Name = "playerCountLabel"
        Me.playerCountLabel.Size = New System.Drawing.Size(70, 20)
        Me.playerCountLabel.TabIndex = 6
        Me.playerCountLabel.Text = "Players:"
        '
        'twoPlayerButton
        '
        Me.twoPlayerButton.AutoSize = True
        Me.twoPlayerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.twoPlayerButton.Location = New System.Drawing.Point(129, 61)
        Me.twoPlayerButton.Name = "twoPlayerButton"
        Me.twoPlayerButton.Size = New System.Drawing.Size(52, 21)
        Me.twoPlayerButton.TabIndex = 5
        Me.twoPlayerButton.TabStop = True
        Me.twoPlayerButton.Text = "Two"
        Me.twoPlayerButton.UseVisualStyleBackColor = True
        '
        'onePlayerButton
        '
        Me.onePlayerButton.AutoSize = True
        Me.onePlayerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.onePlayerButton.Location = New System.Drawing.Point(129, 38)
        Me.onePlayerButton.Name = "onePlayerButton"
        Me.onePlayerButton.Size = New System.Drawing.Size(53, 21)
        Me.onePlayerButton.TabIndex = 4
        Me.onePlayerButton.TabStop = True
        Me.onePlayerButton.Text = "One"
        Me.onePlayerButton.UseVisualStyleBackColor = True
        '
        'difficultySettingLabel
        '
        Me.difficultySettingLabel.AutoSize = True
        Me.difficultySettingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.difficultySettingLabel.Location = New System.Drawing.Point(42, 114)
        Me.difficultySettingLabel.MinimumSize = New System.Drawing.Size(150, 0)
        Me.difficultySettingLabel.Name = "difficultySettingLabel"
        Me.difficultySettingLabel.Size = New System.Drawing.Size(150, 20)
        Me.difficultySettingLabel.TabIndex = 3
        Me.difficultySettingLabel.Text = "Medium"
        Me.difficultySettingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'difficultyTrackBar
        '
        Me.difficultyTrackBar.LargeChange = 0
        Me.difficultyTrackBar.Location = New System.Drawing.Point(17, 137)
        Me.difficultyTrackBar.Name = "difficultyTrackBar"
        Me.difficultyTrackBar.Size = New System.Drawing.Size(201, 45)
        Me.difficultyTrackBar.SmallChange = 5
        Me.difficultyTrackBar.TabIndex = 2
        Me.difficultyTrackBar.TickFrequency = 5
        Me.difficultyTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.difficultyTrackBar.Value = 5
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 238)
        Me.Controls.Add(Me.mainGroupBox)
        Me.Name = "SettingsForm"
        Me.mainGroupBox.ResumeLayout(False)
        Me.mainGroupBox.PerformLayout()
        CType(Me.difficultyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainGroupBox As GroupBox
    Friend WithEvents difficultySettingLabel As Label
    Friend WithEvents difficultyTrackBar As TrackBar
    Friend WithEvents playerCountLabel As Label
    Friend WithEvents twoPlayerButton As RadioButton
    Friend WithEvents onePlayerButton As RadioButton
End Class
