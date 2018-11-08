<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredits
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
        Me.tmrCreditsScroll = New System.Windows.Forms.Timer(Me.components)
        Me.lblDesigners = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.lblGraphics = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pnlScroll = New System.Windows.Forms.Panel()
        Me.pnlScroll.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrCreditsScroll
        '
        Me.tmrCreditsScroll.Interval = 50
        '
        'lblDesigners
        '
        Me.lblDesigners.AutoSize = True
        Me.lblDesigners.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesigners.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblDesigners.Location = New System.Drawing.Point(175, 35)
        Me.lblDesigners.Name = "lblDesigners"
        Me.lblDesigners.Size = New System.Drawing.Size(169, 37)
        Me.lblDesigners.TabIndex = 0
        Me.lblDesigners.Text = "Designers"
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblNames.Location = New System.Drawing.Point(177, 91)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(93, 275)
        Me.lblNames.TabIndex = 1
        Me.lblNames.Text = "Jessica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Brandon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "William" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Heather" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kelsey" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elvis"
        '
        'lblGraphics
        '
        Me.lblGraphics.AutoSize = True
        Me.lblGraphics.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.lblGraphics.Location = New System.Drawing.Point(492, 35)
        Me.lblGraphics.Name = "lblGraphics"
        Me.lblGraphics.Size = New System.Drawing.Size(269, 37)
        Me.lblGraphics.TabIndex = 2
        Me.lblGraphics.Text = "Graphics Design"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(494, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 75)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jessica" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Heather" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(398, 447)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(184, 81)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'pnlScroll
        '
        Me.pnlScroll.BackColor = System.Drawing.Color.Transparent
        Me.pnlScroll.Controls.Add(Me.btnBack)
        Me.pnlScroll.Controls.Add(Me.Label1)
        Me.pnlScroll.Controls.Add(Me.lblGraphics)
        Me.pnlScroll.Controls.Add(Me.lblNames)
        Me.pnlScroll.Controls.Add(Me.lblDesigners)
        Me.pnlScroll.Location = New System.Drawing.Point(203, 132)
        Me.pnlScroll.Name = "pnlScroll"
        Me.pnlScroll.Size = New System.Drawing.Size(967, 557)
        Me.pnlScroll.TabIndex = 0
        '
        'frmCredits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ByteJame2018.My.Resources.Resources.BG
        Me.ClientSize = New System.Drawing.Size(1344, 742)
        Me.Controls.Add(Me.pnlScroll)
        Me.Name = "frmCredits"
        Me.Text = "Credits"
        Me.pnlScroll.ResumeLayout(False)
        Me.pnlScroll.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrCreditsScroll As Timer
    Friend WithEvents lblDesigners As Label
    Friend WithEvents lblNames As Label
    Friend WithEvents lblGraphics As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents pnlScroll As Panel
End Class
