<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccountForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Minbtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelCreateAcc = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelCreateAcc.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 42)
        Me.Panel1.TabIndex = 3
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
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BackgroundImage = Global.NACOS_GPA_CALCULATOR.My.Resources.Resources.Nacos_wall1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.PanelCreateAcc)
        Me.Panel2.Location = New System.Drawing.Point(1, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 666)
        Me.Panel2.TabIndex = 7
        '
        'PanelCreateAcc
        '
        Me.PanelCreateAcc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelCreateAcc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelCreateAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCreateAcc.Controls.Add(Me.Button5)
        Me.PanelCreateAcc.Controls.Add(Me.Button1)
        Me.PanelCreateAcc.Controls.Add(Me.TextBox2)
        Me.PanelCreateAcc.Controls.Add(Me.Label15)
        Me.PanelCreateAcc.Controls.Add(Me.TextBox3)
        Me.PanelCreateAcc.Controls.Add(Me.TextBox4)
        Me.PanelCreateAcc.Controls.Add(Me.Label11)
        Me.PanelCreateAcc.Controls.Add(Me.TextBox5)
        Me.PanelCreateAcc.Controls.Add(Me.Label12)
        Me.PanelCreateAcc.Controls.Add(Me.Label13)
        Me.PanelCreateAcc.Controls.Add(Me.Label14)
        Me.PanelCreateAcc.Controls.Add(Me.Label16)
        Me.PanelCreateAcc.Controls.Add(Me.PictureBox4)
        Me.PanelCreateAcc.Location = New System.Drawing.Point(265, 17)
        Me.PanelCreateAcc.Name = "PanelCreateAcc"
        Me.PanelCreateAcc.Padding = New System.Windows.Forms.Padding(20)
        Me.PanelCreateAcc.Size = New System.Drawing.Size(432, 577)
        Me.PanelCreateAcc.TabIndex = 14
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(201, 513)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 32)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Log in"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(41, 390)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 38)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(41, 305)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(344, 38)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(41, 224)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(344, 38)
        Me.TextBox4.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Confirm Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Matric Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(43, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 517)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Already have an account?"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(57, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(296, 34)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Create your account"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = Global.NACOS_GPA_CALCULATOR.My.Resources.Resources.NACOS
        Me.PictureBox4.Location = New System.Drawing.Point(169, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(57, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(41, 144)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(344, 38)
        Me.TextBox5.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(43, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Email address"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(41, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Sign up"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 673)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelCreateAcc.ResumeLayout(False)
        Me.PanelCreateAcc.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Closebtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Minbtn As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PanelCreateAcc As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
