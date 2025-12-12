<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Minbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContainerLogin = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Text_Email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContainerLogin.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Minbtn)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 42)
        Me.Panel1.TabIndex = 2
        '
        'Closebtn
        '
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.Transparent
        Me.Closebtn.FlatAppearance.BorderSize = 0
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.ForeColor = System.Drawing.Color.White
        Me.Closebtn.Location = New System.Drawing.Point(885, 1)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(57, 38)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'Minbtn
        '
        Me.Minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minbtn.BackColor = System.Drawing.Color.Transparent
        Me.Minbtn.FlatAppearance.BorderSize = 0
        Me.Minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minbtn.Font = New System.Drawing.Font("MS Outlook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minbtn.ForeColor = System.Drawing.Color.White
        Me.Minbtn.Location = New System.Drawing.Point(826, 1)
        Me.Minbtn.Name = "Minbtn"
        Me.Minbtn.Size = New System.Drawing.Size(57, 38)
        Me.Minbtn.TabIndex = 2
        Me.Minbtn.Text = "-"
        Me.Minbtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BackgroundImage = Global.NACOS_GPA_CALCULATOR.My.Resources.Resources.Nacos_wall1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.ContainerLogin)
        Me.Panel2.Location = New System.Drawing.Point(1, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(943, 673)
        Me.Panel2.TabIndex = 4
        '
        'ContainerLogin
        '
        Me.ContainerLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ContainerLogin.BackColor = System.Drawing.Color.White
        Me.ContainerLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ContainerLogin.Controls.Add(Me.Label1)
        Me.ContainerLogin.Controls.Add(Me.Button4)
        Me.ContainerLogin.Controls.Add(Me.Button1)
        Me.ContainerLogin.Controls.Add(Me.Button3)
        Me.ContainerLogin.Controls.Add(Me.CheckBox1)
        Me.ContainerLogin.Controls.Add(Me.TextBox1)
        Me.ContainerLogin.Controls.Add(Me.Text_Email)
        Me.ContainerLogin.Controls.Add(Me.Label6)
        Me.ContainerLogin.Controls.Add(Me.Label7)
        Me.ContainerLogin.Controls.Add(Me.Label9)
        Me.ContainerLogin.Controls.Add(Me.PictureBox3)
        Me.ContainerLogin.ForeColor = System.Drawing.Color.Black
        Me.ContainerLogin.Location = New System.Drawing.Point(277, 91)
        Me.ContainerLogin.Name = "ContainerLogin"
        Me.ContainerLogin.Padding = New System.Windows.Forms.Padding(20)
        Me.ContainerLogin.Size = New System.Drawing.Size(390, 454)
        Me.ContainerLogin.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Don't have an account?"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(183, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 32)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "create one now!"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(23, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 41)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Log in"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(202, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 29)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Forgot your password?"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(25, 293)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 20)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Remember Me"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(23, 232)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(340, 33)
        Me.TextBox1.TabIndex = 7
        '
        'Text_Email
        '
        Me.Text_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Text_Email.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Email.Location = New System.Drawing.Point(23, 150)
        Me.Text_Email.Multiline = True
        Me.Text_Email.Name = "Text_Email"
        Me.Text_Email.Size = New System.Drawing.Size(340, 33)
        Me.Text_Email.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Matric Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(268, 29)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Login to your account"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = Global.NACOS_GPA_CALCULATOR.My.Resources.Resources.NACOS1
        Me.PictureBox3.Location = New System.Drawing.Point(167, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.NACOS_GPA_CALCULATOR.My.Resources.Resources.NACOS
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(52, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 686)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ContainerLogin.ResumeLayout(False)
        Me.ContainerLogin.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Minbtn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Closebtn As System.Windows.Forms.Button
    Friend WithEvents ContainerLogin As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Text_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
