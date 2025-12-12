<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sum2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Num1Txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Num2Txt = New System.Windows.Forms.TextBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ResultTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUM OF TWO NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENTER FIRST NUMBER"
        '
        'Num1Txt
        '
        Me.Num1Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Num1Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1Txt.Location = New System.Drawing.Point(65, 119)
        Me.Num1Txt.Multiline = True
        Me.Num1Txt.Name = "Num1Txt"
        Me.Num1Txt.Size = New System.Drawing.Size(230, 30)
        Me.Num1Txt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ENTER SECOND NUMBER"
        '
        'Num2Txt
        '
        Me.Num2Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Num2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2Txt.Location = New System.Drawing.Point(65, 198)
        Me.Num2Txt.Multiline = True
        Me.Num2Txt.Name = "Num2Txt"
        Me.Num2Txt.Size = New System.Drawing.Size(230, 30)
        Me.Num2Txt.TabIndex = 4
        '
        'CalculateBtn
        '
        Me.CalculateBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CalculateBtn.FlatAppearance.BorderSize = 0
        Me.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateBtn.ForeColor = System.Drawing.Color.White
        Me.CalculateBtn.Location = New System.Drawing.Point(65, 254)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(230, 40)
        Me.CalculateBtn.TabIndex = 5
        Me.CalculateBtn.Text = "CALCULATE"
        Me.CalculateBtn.UseVisualStyleBackColor = False
        '
        'ResultTxt
        '
        Me.ResultTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTxt.Location = New System.Drawing.Point(65, 335)
        Me.ResultTxt.Multiline = True
        Me.ResultTxt.Name = "ResultTxt"
        Me.ResultTxt.ReadOnly = True
        Me.ResultTxt.Size = New System.Drawing.Size(230, 30)
        Me.ResultTxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RESULT"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClearBtn.FlatAppearance.BorderSize = 0
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(111, 388)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(115, 40)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "CLEAR"
        Me.ClearBtn.UseVisualStyleBackColor = False
        Me.ClearBtn.Visible = False
        '
        'Sum2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(344, 441)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ResultTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.Num2Txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Num1Txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Sum2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUM2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Num1Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Num2Txt As System.Windows.Forms.TextBox
    Friend WithEvents CalculateBtn As System.Windows.Forms.Button
    Friend WithEvents ResultTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClearBtn As System.Windows.Forms.Button

End Class
