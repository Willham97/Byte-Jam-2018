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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picOb1 = New System.Windows.Forms.PictureBox()
        Me.picOb2 = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(324, 142)
        Me.picPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(236, 284)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4000, 129)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(92, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'picOb1
        '
        Me.picOb1.BackColor = System.Drawing.Color.Red
        Me.picOb1.Location = New System.Drawing.Point(662, 48)
        Me.picOb1.Margin = New System.Windows.Forms.Padding(4)
        Me.picOb1.Name = "picOb1"
        Me.picOb1.Size = New System.Drawing.Size(368, 378)
        Me.picOb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb1.TabIndex = 2
        Me.picOb1.TabStop = False
        '
        'picOb2
        '
        Me.picOb2.BackColor = System.Drawing.Color.Red
        Me.picOb2.Image = CType(resources.GetObject("picOb2.Image"), System.Drawing.Image)
        Me.picOb2.Location = New System.Drawing.Point(1132, 251)
        Me.picOb2.Margin = New System.Windows.Forms.Padding(4)
        Me.picOb2.Name = "picOb2"
        Me.picOb2.Size = New System.Drawing.Size(376, 175)
        Me.picOb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOb2.TabIndex = 3
        Me.picOb2.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 10
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 10
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picGround.Location = New System.Drawing.Point(172, 409)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(1347, 50)
        Me.picGround.TabIndex = 4
        Me.picGround.TabStop = False
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.picOb2)
        Me.Controls.Add(Me.picOb1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picOb1 As PictureBox
    Friend WithEvents picOb2 As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrDown As Timer
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrCheck As Timer
End Class
