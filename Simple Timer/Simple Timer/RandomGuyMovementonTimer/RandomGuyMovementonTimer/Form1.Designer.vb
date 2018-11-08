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
        Me.picAsh = New System.Windows.Forms.PictureBox()
        Me.picPhoenix = New System.Windows.Forms.PictureBox()
        Me.picBlue = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer1 = New System.Windows.Forms.Label()
        CType(Me.picAsh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoenix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAsh
        '
        Me.picAsh.Image = CType(resources.GetObject("picAsh.Image"), System.Drawing.Image)
        Me.picAsh.InitialImage = CType(resources.GetObject("picAsh.InitialImage"), System.Drawing.Image)
        Me.picAsh.Location = New System.Drawing.Point(3, -2)
        Me.picAsh.Name = "picAsh"
        Me.picAsh.Size = New System.Drawing.Size(331, 426)
        Me.picAsh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsh.TabIndex = 3
        Me.picAsh.TabStop = False
        '
        'picPhoenix
        '
        Me.picPhoenix.Image = CType(resources.GetObject("picPhoenix.Image"), System.Drawing.Image)
        Me.picPhoenix.Location = New System.Drawing.Point(378, 68)
        Me.picPhoenix.Name = "picPhoenix"
        Me.picPhoenix.Size = New System.Drawing.Size(285, 298)
        Me.picPhoenix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoenix.TabIndex = 4
        Me.picPhoenix.TabStop = False
        '
        'picBlue
        '
        Me.picBlue.BackColor = System.Drawing.SystemColors.Highlight
        Me.picBlue.Location = New System.Drawing.Point(801, 144)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(210, 157)
        Me.picBlue.TabIndex = 5
        Me.picBlue.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'lblTimer1
        '
        Me.lblTimer1.AutoSize = True
        Me.lblTimer1.Location = New System.Drawing.Point(481, 24)
        Me.lblTimer1.Name = "lblTimer1"
        Me.lblTimer1.Size = New System.Drawing.Size(16, 17)
        Me.lblTimer1.TabIndex = 6
        Me.lblTimer1.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 450)
        Me.Controls.Add(Me.lblTimer1)
        Me.Controls.Add(Me.picBlue)
        Me.Controls.Add(Me.picPhoenix)
        Me.Controls.Add(Me.picAsh)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picAsh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoenix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAsh As PictureBox
    Friend WithEvents picPhoenix As PictureBox
    Friend WithEvents picBlue As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTimer1 As Label
End Class
