<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.tmrTitleAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Xirod", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(121, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(637, 78)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "I Can Haz Cheezburger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Game"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnPlay.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPlay.Location = New System.Drawing.Point(562, 240)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(184, 81)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnHelp.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnHelp.Location = New System.Drawing.Point(562, 412)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(184, 81)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCredits.Location = New System.Drawing.Point(562, 498)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(184, 81)
        Me.btnCredits.TabIndex = 3
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnScores
        '
        Me.btnScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnScores.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnScores.Location = New System.Drawing.Point(562, 326)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(184, 81)
        Me.btnScores.TabIndex = 4
        Me.btnScores.Text = "High Scores"
        Me.btnScores.UseVisualStyleBackColor = False
        '
        'tmrTitleAnimate
        '
        Me.tmrTitleAnimate.Interval = 50
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(240, 76)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(839, 158)
        Me.pnlTitle.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(562, 584)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(184, 81)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1344, 742)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "frmMain"
        Me.Text = "Can Haz Cheezburger"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents tmrTitleAnimate As Timer
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents btnExit As Button
End Class
