<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class W_ArithmeticOperationOf2
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
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ResultTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.Num2Txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Num1Txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductBtn = New System.Windows.Forms.Button()
        Me.FractionBtn = New System.Windows.Forms.Button()
        Me.DifferenceBtn = New System.Windows.Forms.Button()
        Me.SumBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OperatorTxt = New System.Windows.Forms.TextBox()
        Me.CloseTxt = New System.Windows.Forms.TextBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.Red
        Me.ClearBtn.FlatAppearance.BorderSize = 0
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(105, 552)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(115, 40)
        Me.ClearBtn.TabIndex = 17
        Me.ClearBtn.Text = "CLEAR"
        Me.ClearBtn.UseVisualStyleBackColor = False
        Me.ClearBtn.Visible = False
        '
        'ResultTxt
        '
        Me.ResultTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResultTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTxt.Location = New System.Drawing.Point(59, 499)
        Me.ResultTxt.Multiline = True
        Me.ResultTxt.Name = "ResultTxt"
        Me.ResultTxt.ReadOnly = True
        Me.ResultTxt.Size = New System.Drawing.Size(230, 30)
        Me.ResultTxt.TabIndex = 16
        Me.ResultTxt.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 474)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "RESULT"
        Me.Label4.Visible = False
        '
        'CalculateBtn
        '
        Me.CalculateBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CalculateBtn.Enabled = False
        Me.CalculateBtn.FlatAppearance.BorderSize = 0
        Me.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateBtn.ForeColor = System.Drawing.Color.White
        Me.CalculateBtn.Location = New System.Drawing.Point(59, 418)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(230, 40)
        Me.CalculateBtn.TabIndex = 14
        Me.CalculateBtn.Text = "CALCULATE"
        Me.CalculateBtn.UseVisualStyleBackColor = False
        '
        'Num2Txt
        '
        Me.Num2Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Num2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2Txt.Location = New System.Drawing.Point(62, 366)
        Me.Num2Txt.Multiline = True
        Me.Num2Txt.Name = "Num2Txt"
        Me.Num2Txt.ReadOnly = True
        Me.Num2Txt.Size = New System.Drawing.Size(230, 30)
        Me.Num2Txt.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ENTER SECOND NUMBER"
        '
        'Num1Txt
        '
        Me.Num1Txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Num1Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1Txt.Location = New System.Drawing.Point(59, 118)
        Me.Num1Txt.Multiline = True
        Me.Num1Txt.Name = "Num1Txt"
        Me.Num1Txt.Size = New System.Drawing.Size(230, 30)
        Me.Num1Txt.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ENTER FIRST NUMBER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SIMPLE CALCULATOR"
        '
        'ProductBtn
        '
        Me.ProductBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductBtn.Enabled = False
        Me.ProductBtn.FlatAppearance.BorderSize = 0
        Me.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductBtn.ForeColor = System.Drawing.Color.White
        Me.ProductBtn.Location = New System.Drawing.Point(221, 260)
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.Size = New System.Drawing.Size(53, 42)
        Me.ProductBtn.TabIndex = 25
        Me.ProductBtn.Text = "*"
        Me.ProductBtn.UseVisualStyleBackColor = False
        '
        'FractionBtn
        '
        Me.FractionBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FractionBtn.Enabled = False
        Me.FractionBtn.FlatAppearance.BorderSize = 0
        Me.FractionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FractionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FractionBtn.ForeColor = System.Drawing.Color.White
        Me.FractionBtn.Location = New System.Drawing.Point(64, 260)
        Me.FractionBtn.Name = "FractionBtn"
        Me.FractionBtn.Size = New System.Drawing.Size(53, 42)
        Me.FractionBtn.TabIndex = 24
        Me.FractionBtn.Text = "/"
        Me.FractionBtn.UseVisualStyleBackColor = False
        '
        'DifferenceBtn
        '
        Me.DifferenceBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.DifferenceBtn.Enabled = False
        Me.DifferenceBtn.FlatAppearance.BorderSize = 0
        Me.DifferenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DifferenceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifferenceBtn.ForeColor = System.Drawing.Color.White
        Me.DifferenceBtn.Location = New System.Drawing.Point(221, 203)
        Me.DifferenceBtn.Name = "DifferenceBtn"
        Me.DifferenceBtn.Size = New System.Drawing.Size(53, 42)
        Me.DifferenceBtn.TabIndex = 23
        Me.DifferenceBtn.Text = "-"
        Me.DifferenceBtn.UseVisualStyleBackColor = False
        '
        'SumBtn
        '
        Me.SumBtn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SumBtn.Enabled = False
        Me.SumBtn.FlatAppearance.BorderSize = 0
        Me.SumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SumBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SumBtn.ForeColor = System.Drawing.Color.White
        Me.SumBtn.Location = New System.Drawing.Point(64, 203)
        Me.SumBtn.Name = "SumBtn"
        Me.SumBtn.Size = New System.Drawing.Size(53, 42)
        Me.SumBtn.TabIndex = 22
        Me.SumBtn.Text = "+"
        Me.SumBtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "CHOOSE AN OPERATOR"
        '
        'OperatorTxt
        '
        Me.OperatorTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OperatorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OperatorTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperatorTxt.Location = New System.Drawing.Point(133, 238)
        Me.OperatorTxt.Multiline = True
        Me.OperatorTxt.Name = "OperatorTxt"
        Me.OperatorTxt.ReadOnly = True
        Me.OperatorTxt.Size = New System.Drawing.Size(73, 41)
        Me.OperatorTxt.TabIndex = 27
        Me.OperatorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OperatorTxt.Visible = False
        '
        'CloseTxt
        '
        Me.CloseTxt.BackColor = System.Drawing.SystemColors.Control
        Me.CloseTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CloseTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseTxt.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CloseTxt.Location = New System.Drawing.Point(59, 552)
        Me.CloseTxt.Multiline = True
        Me.CloseTxt.Name = "CloseTxt"
        Me.CloseTxt.ReadOnly = True
        Me.CloseTxt.Size = New System.Drawing.Size(230, 41)
        Me.CloseTxt.TabIndex = 29
        Me.CloseTxt.Text = "You can use                button " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to close the window."
        Me.CloseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.SystemColors.Control
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CloseBtn.Location = New System.Drawing.Point(166, 549)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(53, 22)
        Me.CloseBtn.TabIndex = 30
        Me.CloseBtn.Text = "ESC"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'W_ArithmeticOperationOf2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseBtn
        Me.ClientSize = New System.Drawing.Size(344, 611)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.CloseTxt)
        Me.Controls.Add(Me.OperatorTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProductBtn)
        Me.Controls.Add(Me.FractionBtn)
        Me.Controls.Add(Me.DifferenceBtn)
        Me.Controls.Add(Me.SumBtn)
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
        Me.Name = "W_ArithmeticOperationOf2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPLE CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents ResultTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CalculateBtn As System.Windows.Forms.Button
    Friend WithEvents Num2Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Num1Txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProductBtn As System.Windows.Forms.Button
    Friend WithEvents FractionBtn As System.Windows.Forms.Button
    Friend WithEvents DifferenceBtn As System.Windows.Forms.Button
    Friend WithEvents SumBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OperatorTxt As System.Windows.Forms.TextBox
    Friend WithEvents CloseTxt As System.Windows.Forms.TextBox
    Friend WithEvents CloseBtn As System.Windows.Forms.Button

End Class
