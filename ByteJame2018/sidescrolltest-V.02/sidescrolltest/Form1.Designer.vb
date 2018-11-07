<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picOb1 = New System.Windows.Forms.PictureBox()
        Me.picOb2 = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(216, 123)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(177, 231)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3000, 105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'picOb1
        '
        Me.picOb1.Image = CType(resources.GetObject("picOb1.Image"), System.Drawing.Image)
        Me.picOb1.Location = New System.Drawing.Point(1096, 207)
        Me.picOb1.Name = "picOb1"
        Me.picOb1.Size = New System.Drawing.Size(177, 231)
        Me.picOb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picOb1.TabIndex = 2
        Me.picOb1.TabStop = False
        '
        'picOb2
        '
        Me.picOb2.Image = CType(resources.GetObject("picOb2.Image"), System.Drawing.Image)
        Me.picOb2.Location = New System.Drawing.Point(1692, 207)
        Me.picOb2.Name = "picOb2"
        Me.picOb2.Size = New System.Drawing.Size(177, 231)
        Me.picOb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picOb2)
        Me.Controls.Add(Me.picOb1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOb2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picOb1 As PictureBox
    Friend WithEvents picOb2 As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
End Class
