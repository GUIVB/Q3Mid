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
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LoadRa = New System.Windows.Forms.RadioButton()
        Me.BlueRa = New System.Windows.Forms.RadioButton()
        Me.GreenRa = New System.Windows.Forms.RadioButton()
        Me.RedRa = New System.Windows.Forms.RadioButton()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBox
        '
        Me.PBox.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBox.Location = New System.Drawing.Point(152, 21)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(355, 325)
        Me.PBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBox.TabIndex = 0
        Me.PBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoadRa)
        Me.GroupBox1.Controls.Add(Me.BlueRa)
        Me.GroupBox1.Controls.Add(Me.GreenRa)
        Me.GroupBox1.Controls.Add(Me.RedRa)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'LoadRa
        '
        Me.LoadRa.AutoSize = True
        Me.LoadRa.Location = New System.Drawing.Point(12, 112)
        Me.LoadRa.Name = "LoadRa"
        Me.LoadRa.Size = New System.Drawing.Size(66, 17)
        Me.LoadRa.TabIndex = 3
        Me.LoadRa.Text = "LoadImg"
        Me.LoadRa.UseVisualStyleBackColor = True
        '
        'BlueRa
        '
        Me.BlueRa.AutoSize = True
        Me.BlueRa.Location = New System.Drawing.Point(12, 89)
        Me.BlueRa.Name = "BlueRa"
        Me.BlueRa.Size = New System.Drawing.Size(45, 17)
        Me.BlueRa.TabIndex = 2
        Me.BlueRa.Text = "Blue"
        Me.BlueRa.UseVisualStyleBackColor = True
        '
        'GreenRa
        '
        Me.GreenRa.AutoSize = True
        Me.GreenRa.Location = New System.Drawing.Point(12, 66)
        Me.GreenRa.Name = "GreenRa"
        Me.GreenRa.Size = New System.Drawing.Size(54, 17)
        Me.GreenRa.TabIndex = 1
        Me.GreenRa.Text = "Green"
        Me.GreenRa.UseVisualStyleBackColor = True
        '
        'RedRa
        '
        Me.RedRa.AutoSize = True
        Me.RedRa.Checked = True
        Me.RedRa.Location = New System.Drawing.Point(12, 43)
        Me.RedRa.Name = "RedRa"
        Me.RedRa.Size = New System.Drawing.Size(44, 17)
        Me.RedRa.TabIndex = 0
        Me.RedRa.TabStop = True
        Me.RedRa.Text = "Red"
        Me.RedRa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LoadRa As RadioButton
    Friend WithEvents BlueRa As RadioButton
    Friend WithEvents GreenRa As RadioButton
    Friend WithEvents RedRa As RadioButton
End Class
