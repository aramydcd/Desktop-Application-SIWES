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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CU6 = New System.Windows.Forms.Button()
        Me.CU5 = New System.Windows.Forms.Button()
        Me.CU4 = New System.Windows.Forms.Button()
        Me.CU3 = New System.Windows.Forms.Button()
        Me.CU2 = New System.Windows.Forms.Button()
        Me.CU1 = New System.Windows.Forms.Button()
        Me.CC6 = New System.Windows.Forms.Button()
        Me.CC5 = New System.Windows.Forms.Button()
        Me.CC4 = New System.Windows.Forms.Button()
        Me.CC3 = New System.Windows.Forms.Button()
        Me.CC2 = New System.Windows.Forms.Button()
        Me.CC1 = New System.Windows.Forms.Button()
        Me.T6 = New System.Windows.Forms.TextBox()
        Me.T5 = New System.Windows.Forms.TextBox()
        Me.T4 = New System.Windows.Forms.TextBox()
        Me.L6 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.L5 = New System.Windows.Forms.Label()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SumExamScoreTxt = New System.Windows.Forms.TextBox()
        Me.SumCUTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GPAText = New System.Windows.Forms.Label()
        Me.GPATxt = New System.Windows.Forms.TextBox()
        Me.TGPTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Table1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MainPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(705, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "4REAL GLOBAL GRADE POINT (GP) CALCULATOR"
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.BackColor = System.Drawing.SystemColors.Control
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.Button1)
        Me.MainPanel.Controls.Add(Me.ButtonSubmit)
        Me.MainPanel.Controls.Add(Me.Label5)
        Me.MainPanel.Controls.Add(Me.GroupBox1)
        Me.MainPanel.Controls.Add(Me.T6)
        Me.MainPanel.Controls.Add(Me.T5)
        Me.MainPanel.Controls.Add(Me.T4)
        Me.MainPanel.Controls.Add(Me.L6)
        Me.MainPanel.Controls.Add(Me.L4)
        Me.MainPanel.Controls.Add(Me.L5)
        Me.MainPanel.Controls.Add(Me.T3)
        Me.MainPanel.Controls.Add(Me.T2)
        Me.MainPanel.Controls.Add(Me.T1)
        Me.MainPanel.Controls.Add(Me.L3)
        Me.MainPanel.Controls.Add(Me.L1)
        Me.MainPanel.Controls.Add(Me.L2)
        Me.MainPanel.Controls.Add(Me.ShapeContainer1)
        Me.MainPanel.Location = New System.Drawing.Point(12, 79)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1273, 465)
        Me.MainPanel.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(727, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 43)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.AutoSize = True
        Me.ButtonSubmit.BackColor = System.Drawing.SystemColors.GrayText
        Me.ButtonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ButtonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.Location = New System.Drawing.Point(388, 408)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(139, 43)
        Me.ButtonSubmit.TabIndex = 23
        Me.ButtonSubmit.Text = "CALCULATE"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
        Me.ButtonSubmit.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(504, 25)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "PROVIDE THE SCORE FOR THE FOLLOWING:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.CU6)
        Me.GroupBox1.Controls.Add(Me.CU5)
        Me.GroupBox1.Controls.Add(Me.CU4)
        Me.GroupBox1.Controls.Add(Me.CU3)
        Me.GroupBox1.Controls.Add(Me.CU2)
        Me.GroupBox1.Controls.Add(Me.CU1)
        Me.GroupBox1.Controls.Add(Me.CC6)
        Me.GroupBox1.Controls.Add(Me.CC5)
        Me.GroupBox1.Controls.Add(Me.CC4)
        Me.GroupBox1.Controls.Add(Me.CC3)
        Me.GroupBox1.Controls.Add(Me.CC2)
        Me.GroupBox1.Controls.Add(Me.CC1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(626, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 362)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COURSE UNIT"
        '
        'CU6
        '
        Me.CU6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU6.Enabled = False
        Me.CU6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU6.Location = New System.Drawing.Point(115, 312)
        Me.CU6.Name = "CU6"
        Me.CU6.Size = New System.Drawing.Size(51, 36)
        Me.CU6.TabIndex = 28
        Me.CU6.Text = "0"
        Me.CU6.UseVisualStyleBackColor = False
        '
        'CU5
        '
        Me.CU5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU5.Enabled = False
        Me.CU5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU5.Location = New System.Drawing.Point(115, 260)
        Me.CU5.Name = "CU5"
        Me.CU5.Size = New System.Drawing.Size(51, 36)
        Me.CU5.TabIndex = 27
        Me.CU5.Text = "0"
        Me.CU5.UseVisualStyleBackColor = False
        '
        'CU4
        '
        Me.CU4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU4.Enabled = False
        Me.CU4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU4.Location = New System.Drawing.Point(115, 197)
        Me.CU4.Name = "CU4"
        Me.CU4.Size = New System.Drawing.Size(51, 36)
        Me.CU4.TabIndex = 26
        Me.CU4.Text = "0"
        Me.CU4.UseVisualStyleBackColor = False
        '
        'CU3
        '
        Me.CU3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU3.Enabled = False
        Me.CU3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU3.Location = New System.Drawing.Point(115, 143)
        Me.CU3.Name = "CU3"
        Me.CU3.Size = New System.Drawing.Size(51, 36)
        Me.CU3.TabIndex = 25
        Me.CU3.Text = "0"
        Me.CU3.UseVisualStyleBackColor = False
        '
        'CU2
        '
        Me.CU2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU2.Enabled = False
        Me.CU2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU2.Location = New System.Drawing.Point(115, 90)
        Me.CU2.Name = "CU2"
        Me.CU2.Size = New System.Drawing.Size(51, 36)
        Me.CU2.TabIndex = 24
        Me.CU2.Text = "0"
        Me.CU2.UseVisualStyleBackColor = False
        '
        'CU1
        '
        Me.CU1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CU1.Enabled = False
        Me.CU1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CU1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CU1.Location = New System.Drawing.Point(115, 37)
        Me.CU1.Name = "CU1"
        Me.CU1.Size = New System.Drawing.Size(51, 36)
        Me.CU1.TabIndex = 23
        Me.CU1.Text = "0"
        Me.CU1.UseVisualStyleBackColor = False
        '
        'CC6
        '
        Me.CC6.AutoSize = True
        Me.CC6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC6.FlatAppearance.BorderSize = 0
        Me.CC6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC6.Location = New System.Drawing.Point(15, 312)
        Me.CC6.Name = "CC6"
        Me.CC6.Size = New System.Drawing.Size(66, 36)
        Me.CC6.TabIndex = 5
        Me.CC6.Text = "CC000"
        Me.CC6.UseVisualStyleBackColor = False
        '
        'CC5
        '
        Me.CC5.AutoSize = True
        Me.CC5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC5.FlatAppearance.BorderSize = 0
        Me.CC5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC5.Location = New System.Drawing.Point(15, 257)
        Me.CC5.Name = "CC5"
        Me.CC5.Size = New System.Drawing.Size(66, 36)
        Me.CC5.TabIndex = 4
        Me.CC5.Text = "CC000"
        Me.CC5.UseVisualStyleBackColor = False
        '
        'CC4
        '
        Me.CC4.AutoSize = True
        Me.CC4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC4.FlatAppearance.BorderSize = 0
        Me.CC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC4.Location = New System.Drawing.Point(15, 198)
        Me.CC4.Name = "CC4"
        Me.CC4.Size = New System.Drawing.Size(66, 36)
        Me.CC4.TabIndex = 3
        Me.CC4.Text = "CC000"
        Me.CC4.UseVisualStyleBackColor = False
        '
        'CC3
        '
        Me.CC3.AutoSize = True
        Me.CC3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC3.FlatAppearance.BorderSize = 0
        Me.CC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC3.Location = New System.Drawing.Point(15, 143)
        Me.CC3.Name = "CC3"
        Me.CC3.Size = New System.Drawing.Size(66, 36)
        Me.CC3.TabIndex = 2
        Me.CC3.Text = "CC000"
        Me.CC3.UseVisualStyleBackColor = False
        '
        'CC2
        '
        Me.CC2.AutoSize = True
        Me.CC2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC2.FlatAppearance.BorderSize = 0
        Me.CC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC2.Location = New System.Drawing.Point(15, 90)
        Me.CC2.Name = "CC2"
        Me.CC2.Size = New System.Drawing.Size(66, 36)
        Me.CC2.TabIndex = 1
        Me.CC2.Text = "CC000"
        Me.CC2.UseVisualStyleBackColor = False
        '
        'CC1
        '
        Me.CC1.AutoSize = True
        Me.CC1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CC1.FlatAppearance.BorderSize = 0
        Me.CC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CC1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CC1.Location = New System.Drawing.Point(15, 37)
        Me.CC1.Name = "CC1"
        Me.CC1.Size = New System.Drawing.Size(66, 36)
        Me.CC1.TabIndex = 0
        Me.CC1.Text = "CC000"
        Me.CC1.UseVisualStyleBackColor = False
        '
        'T6
        '
        Me.T6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T6.Location = New System.Drawing.Point(363, 348)
        Me.T6.Multiline = True
        Me.T6.Name = "T6"
        Me.T6.Size = New System.Drawing.Size(187, 33)
        Me.T6.TabIndex = 13
        '
        'T5
        '
        Me.T5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T5.Location = New System.Drawing.Point(363, 296)
        Me.T5.Multiline = True
        Me.T5.Name = "T5"
        Me.T5.Size = New System.Drawing.Size(187, 33)
        Me.T5.TabIndex = 13
        '
        'T4
        '
        Me.T4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T4.Location = New System.Drawing.Point(363, 237)
        Me.T4.Multiline = True
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(187, 33)
        Me.T4.TabIndex = 13
        '
        'L6
        '
        Me.L6.AutoSize = True
        Me.L6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L6.Location = New System.Drawing.Point(10, 353)
        Me.L6.Name = "L6"
        Me.L6.Size = New System.Drawing.Size(149, 20)
        Me.L6.TabIndex = 17
        Me.L6.Text = "COURSES TITLE"
        '
        'L4
        '
        Me.L4.AutoSize = True
        Me.L4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L4.Location = New System.Drawing.Point(10, 239)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(149, 20)
        Me.L4.TabIndex = 16
        Me.L4.Text = "COURSES TITLE"
        '
        'L5
        '
        Me.L5.AutoSize = True
        Me.L5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L5.Location = New System.Drawing.Point(10, 298)
        Me.L5.Name = "L5"
        Me.L5.Size = New System.Drawing.Size(149, 20)
        Me.L5.TabIndex = 15
        Me.L5.Text = "COURSES TITLE"
        '
        'T3
        '
        Me.T3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T3.Location = New System.Drawing.Point(363, 182)
        Me.T3.Multiline = True
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(187, 33)
        Me.T3.TabIndex = 13
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.Location = New System.Drawing.Point(363, 129)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(187, 33)
        Me.T2.TabIndex = 13
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.Location = New System.Drawing.Point(363, 76)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(187, 33)
        Me.T1.TabIndex = 13
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L3.Location = New System.Drawing.Point(10, 184)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(149, 20)
        Me.L3.TabIndex = 4
        Me.L3.Text = "COURSES TITLE"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(10, 78)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(149, 20)
        Me.L1.TabIndex = 3
        Me.L1.Text = "COURSES TITLE"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(10, 131)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(149, 20)
        Me.L2.TabIndex = 2
        Me.L2.Text = "COURSES TITLE"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1271, 463)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Black
        Me.LineShape1.Visible = False
        Me.LineShape1.X1 = 838
        Me.LineShape1.X2 = 834
        Me.LineShape1.Y1 = -3
        Me.LineShape1.Y2 = 461
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "TOTAL EXAM SCORE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "TOTAL COURSE UNIT"
        '
        'SumExamScoreTxt
        '
        Me.SumExamScoreTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumExamScoreTxt.Location = New System.Drawing.Point(256, 46)
        Me.SumExamScoreTxt.Multiline = True
        Me.SumExamScoreTxt.Name = "SumExamScoreTxt"
        Me.SumExamScoreTxt.ReadOnly = True
        Me.SumExamScoreTxt.Size = New System.Drawing.Size(113, 33)
        Me.SumExamScoreTxt.TabIndex = 24
        Me.SumExamScoreTxt.Text = "0"
        '
        'SumCUTxt
        '
        Me.SumCUTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumCUTxt.Location = New System.Drawing.Point(256, 103)
        Me.SumCUTxt.Multiline = True
        Me.SumCUTxt.Name = "SumCUTxt"
        Me.SumCUTxt.ReadOnly = True
        Me.SumCUTxt.Size = New System.Drawing.Size(113, 33)
        Me.SumCUTxt.TabIndex = 26
        Me.SumCUTxt.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.GPAText)
        Me.GroupBox2.Controls.Add(Me.GPATxt)
        Me.GroupBox2.Controls.Add(Me.TGPTxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Table1)
        Me.GroupBox2.Controls.Add(Me.SumCUTxt)
        Me.GroupBox2.Controls.Add(Me.SumExamScoreTxt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(860, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 454)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULT PROCCESING..."
        '
        'GPAText
        '
        Me.GPAText.AutoSize = True
        Me.GPAText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPAText.ForeColor = System.Drawing.Color.Navy
        Me.GPAText.Location = New System.Drawing.Point(253, 423)
        Me.GPAText.Name = "GPAText"
        Me.GPAText.Size = New System.Drawing.Size(144, 20)
        Me.GPAText.TabIndex = 32
        Me.GPAText.Text = "Advice to withdraw!"
        Me.GPAText.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GPATxt
        '
        Me.GPATxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPATxt.Location = New System.Drawing.Point(256, 379)
        Me.GPATxt.Multiline = True
        Me.GPATxt.Name = "GPATxt"
        Me.GPATxt.ReadOnly = True
        Me.GPATxt.Size = New System.Drawing.Size(113, 33)
        Me.GPATxt.TabIndex = 31
        Me.GPATxt.Text = "0"
        '
        'TGPTxt
        '
        Me.TGPTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TGPTxt.Location = New System.Drawing.Point(256, 322)
        Me.TGPTxt.Multiline = True
        Me.TGPTxt.Name = "TGPTxt"
        Me.TGPTxt.ReadOnly = True
        Me.TGPTxt.Size = New System.Drawing.Size(113, 33)
        Me.TGPTxt.TabIndex = 29
        Me.TGPTxt.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "GRADE POINT AVERAGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 329)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TOTAL GRADE POINT"
        '
        'Table1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Table1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Table1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Table1.Location = New System.Drawing.Point(11, 151)
        Me.Table1.MultiSelect = False
        Me.Table1.Name = "Table1"
        Me.Table1.ReadOnly = True
        Me.Table1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.Table1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Table1.ShowCellErrors = False
        Me.Table1.ShowCellToolTips = False
        Me.Table1.ShowEditingIcon = False
        Me.Table1.ShowRowErrors = False
        Me.Table1.Size = New System.Drawing.Size(391, 157)
        Me.Table1.TabIndex = 27
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Score"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Unit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "GP"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "RMK"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1297, 568)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4REAL GLOBAL GRADE POINT (GP) CALCULATOR"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T6 As System.Windows.Forms.TextBox
    Friend WithEvents T5 As System.Windows.Forms.TextBox
    Friend WithEvents T4 As System.Windows.Forms.TextBox
    Friend WithEvents L6 As System.Windows.Forms.Label
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents L5 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CU6 As System.Windows.Forms.Button
    Friend WithEvents CU5 As System.Windows.Forms.Button
    Friend WithEvents CU4 As System.Windows.Forms.Button
    Friend WithEvents CU3 As System.Windows.Forms.Button
    Friend WithEvents CU2 As System.Windows.Forms.Button
    Friend WithEvents CU1 As System.Windows.Forms.Button
    Friend WithEvents CC6 As System.Windows.Forms.Button
    Friend WithEvents CC5 As System.Windows.Forms.Button
    Friend WithEvents CC4 As System.Windows.Forms.Button
    Friend WithEvents CC3 As System.Windows.Forms.Button
    Friend WithEvents CC2 As System.Windows.Forms.Button
    Friend WithEvents CC1 As System.Windows.Forms.Button
    Friend WithEvents ButtonSubmit As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SumExamScoreTxt As System.Windows.Forms.TextBox
    Friend WithEvents SumCUTxt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Table1 As System.Windows.Forms.DataGridView
    Friend WithEvents GPATxt As System.Windows.Forms.TextBox
    Friend WithEvents TGPTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GPAText As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
