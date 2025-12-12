<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.btnPeriod = New System.Windows.Forms.Button()
        Me.btnzero = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnRaise2Pow = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.ClearMemory = New System.Windows.Forms.Button()
        Me.MemoryRecall = New System.Windows.Forms.Button()
        Me.MemorySubtract = New System.Windows.Forms.Button()
        Me.MemoryAdd = New System.Windows.Forms.Button()
        Me.Memory = New System.Windows.Forms.Button()
        Me.MemoryStore = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.Standard = New System.Windows.Forms.Label()
        Me.ResultInterface = New System.Windows.Forms.Label()
        Me.UserInterfaceFeedback = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPeriod
        '
        Me.btnPeriod.BackColor = System.Drawing.Color.LightGray
        Me.btnPeriod.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPeriod.Location = New System.Drawing.Point(0, 436)
        Me.btnPeriod.Name = "btnPeriod"
        Me.btnPeriod.Size = New System.Drawing.Size(75, 52)
        Me.btnPeriod.TabIndex = 0
        Me.btnPeriod.Text = "."
        Me.btnPeriod.UseVisualStyleBackColor = False
        '
        'btnzero
        '
        Me.btnzero.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnzero.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnzero.Location = New System.Drawing.Point(74, 436)
        Me.btnzero.Name = "btnzero"
        Me.btnzero.Size = New System.Drawing.Size(75, 52)
        Me.btnzero.TabIndex = 1
        Me.btnzero.Text = "0"
        Me.btnzero.UseVisualStyleBackColor = False
        '
        'btnplus
        '
        Me.btnplus.BackColor = System.Drawing.Color.LightGray
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnplus.Location = New System.Drawing.Point(222, 385)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(73, 52)
        Me.btnplus.TabIndex = 2
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.Color.LightGray
        Me.btnEqual.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEqual.Location = New System.Drawing.Point(148, 436)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(147, 52)
        Me.btnEqual.TabIndex = 3
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnThree.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(148, 385)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(75, 52)
        Me.btnThree.TabIndex = 6
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTwo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(74, 385)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(75, 52)
        Me.btnTwo.TabIndex = 5
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOne.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(0, 385)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(75, 52)
        Me.btnOne.TabIndex = 4
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnFactorial
        '
        Me.btnFactorial.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnFactorial.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactorial.Location = New System.Drawing.Point(222, 179)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(73, 52)
        Me.btnFactorial.TabIndex = 23
        Me.btnFactorial.Text = "!"
        Me.btnFactorial.UseVisualStyleBackColor = False
        '
        'btnRaise2Pow
        '
        Me.btnRaise2Pow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRaise2Pow.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaise2Pow.Location = New System.Drawing.Point(148, 179)
        Me.btnRaise2Pow.Name = "btnRaise2Pow"
        Me.btnRaise2Pow.Size = New System.Drawing.Size(75, 52)
        Me.btnRaise2Pow.TabIndex = 22
        Me.btnRaise2Pow.Text = "^"
        Me.btnRaise2Pow.UseVisualStyleBackColor = False
        '
        'btnSquare
        '
        Me.btnSquare.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSquare.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.Location = New System.Drawing.Point(74, 179)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(75, 52)
        Me.btnSquare.TabIndex = 21
        Me.btnSquare.Text = "x^2"
        Me.btnSquare.UseVisualStyleBackColor = False
        '
        'btnPercentage
        '
        Me.btnPercentage.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPercentage.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercentage.Location = New System.Drawing.Point(0, 179)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(75, 52)
        Me.btnPercentage.TabIndex = 20
        Me.btnPercentage.Text = "%"
        Me.btnPercentage.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.Color.LightGray
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDivide.Location = New System.Drawing.Point(222, 231)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(73, 52)
        Me.btnDivide.TabIndex = 19
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.LightGray
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(148, 231)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 52)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "Del"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(74, 231)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 52)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.LightGray
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(0, 231)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(75, 52)
        Me.btnClearAll.TabIndex = 15
        Me.btnClearAll.Text = "CE"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'ClearMemory
        '
        Me.ClearMemory.BackColor = System.Drawing.Color.Transparent
        Me.ClearMemory.FlatAppearance.BorderSize = 0
        Me.ClearMemory.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearMemory.ForeColor = System.Drawing.Color.Black
        Me.ClearMemory.Location = New System.Drawing.Point(0, 137)
        Me.ClearMemory.Name = "ClearMemory"
        Me.ClearMemory.Size = New System.Drawing.Size(46, 41)
        Me.ClearMemory.TabIndex = 24
        Me.ClearMemory.Text = "MC"
        Me.ClearMemory.UseVisualStyleBackColor = False
        '
        'MemoryRecall
        '
        Me.MemoryRecall.BackColor = System.Drawing.Color.Transparent
        Me.MemoryRecall.FlatAppearance.BorderSize = 0
        Me.MemoryRecall.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryRecall.ForeColor = System.Drawing.Color.Black
        Me.MemoryRecall.Location = New System.Drawing.Point(46, 137)
        Me.MemoryRecall.Name = "MemoryRecall"
        Me.MemoryRecall.Size = New System.Drawing.Size(52, 41)
        Me.MemoryRecall.TabIndex = 25
        Me.MemoryRecall.Text = "MR"
        Me.MemoryRecall.UseVisualStyleBackColor = False
        '
        'MemorySubtract
        '
        Me.MemorySubtract.BackColor = System.Drawing.Color.Transparent
        Me.MemorySubtract.FlatAppearance.BorderSize = 0
        Me.MemorySubtract.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemorySubtract.ForeColor = System.Drawing.Color.Black
        Me.MemorySubtract.Location = New System.Drawing.Point(147, 137)
        Me.MemorySubtract.Name = "MemorySubtract"
        Me.MemorySubtract.Size = New System.Drawing.Size(47, 41)
        Me.MemorySubtract.TabIndex = 27
        Me.MemorySubtract.Text = "M-"
        Me.MemorySubtract.UseVisualStyleBackColor = False
        '
        'MemoryAdd
        '
        Me.MemoryAdd.BackColor = System.Drawing.Color.Transparent
        Me.MemoryAdd.FlatAppearance.BorderSize = 0
        Me.MemoryAdd.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryAdd.ForeColor = System.Drawing.Color.Black
        Me.MemoryAdd.Location = New System.Drawing.Point(99, 137)
        Me.MemoryAdd.Name = "MemoryAdd"
        Me.MemoryAdd.Size = New System.Drawing.Size(46, 41)
        Me.MemoryAdd.TabIndex = 26
        Me.MemoryAdd.Text = "M+"
        Me.MemoryAdd.UseVisualStyleBackColor = False
        '
        'Memory
        '
        Me.Memory.BackColor = System.Drawing.Color.Transparent
        Me.Memory.FlatAppearance.BorderSize = 0
        Me.Memory.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Memory.ForeColor = System.Drawing.Color.Black
        Me.Memory.Location = New System.Drawing.Point(245, 137)
        Me.Memory.Name = "Memory"
        Me.Memory.Size = New System.Drawing.Size(50, 41)
        Me.Memory.TabIndex = 29
        Me.Memory.Text = "M*"
        Me.Memory.UseVisualStyleBackColor = False
        '
        'MemoryStore
        '
        Me.MemoryStore.BackColor = System.Drawing.Color.Transparent
        Me.MemoryStore.FlatAppearance.BorderSize = 0
        Me.MemoryStore.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoryStore.ForeColor = System.Drawing.Color.Black
        Me.MemoryStore.Location = New System.Drawing.Point(197, 137)
        Me.MemoryStore.Name = "MemoryStore"
        Me.MemoryStore.Size = New System.Drawing.Size(46, 41)
        Me.MemoryStore.TabIndex = 28
        Me.MemoryStore.Text = "MS"
        Me.MemoryStore.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSix.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(148, 334)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(75, 52)
        Me.btnSix.TabIndex = 33
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFive.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(74, 334)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(75, 52)
        Me.btnFive.TabIndex = 32
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFour.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(0, 334)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(75, 52)
        Me.btnFour.TabIndex = 31
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.LightGray
        Me.btnMinus.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMinus.Location = New System.Drawing.Point(222, 334)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(73, 52)
        Me.btnMinus.TabIndex = 30
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNine.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(148, 283)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(75, 52)
        Me.btnNine.TabIndex = 37
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEight.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(74, 283)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(75, 52)
        Me.btnEight.TabIndex = 36
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSeven.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(0, 283)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(75, 52)
        Me.btnSeven.TabIndex = 35
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.LightGray
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProduct.Location = New System.Drawing.Point(222, 283)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(73, 52)
        Me.btnProduct.TabIndex = 34
        Me.btnProduct.Text = "*"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'Standard
        '
        Me.Standard.AutoSize = True
        Me.Standard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Standard.Location = New System.Drawing.Point(12, 9)
        Me.Standard.Name = "Standard"
        Me.Standard.Size = New System.Drawing.Size(99, 25)
        Me.Standard.TabIndex = 39
        Me.Standard.Text = "Standard"
        '
        'ResultInterface
        '
        Me.ResultInterface.Font = New System.Drawing.Font("Arial", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultInterface.Location = New System.Drawing.Point(4, 84)
        Me.ResultInterface.MaximumSize = New System.Drawing.Size(291, 50)
        Me.ResultInterface.MinimumSize = New System.Drawing.Size(51, 50)
        Me.ResultInterface.Name = "ResultInterface"
        Me.ResultInterface.Size = New System.Drawing.Size(291, 50)
        Me.ResultInterface.TabIndex = 40
        Me.ResultInterface.Text = "0"
        Me.ResultInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserInterfaceFeedback
        '
        Me.UserInterfaceFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInterfaceFeedback.Location = New System.Drawing.Point(11, 49)
        Me.UserInterfaceFeedback.Name = "UserInterfaceFeedback"
        Me.UserInterfaceFeedback.Size = New System.Drawing.Size(273, 35)
        Me.UserInterfaceFeedback.TabIndex = 41
        Me.UserInterfaceFeedback.Text = "0"
        Me.UserInterfaceFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UserInterfaceFeedback.Visible = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 488)
        Me.Controls.Add(Me.UserInterfaceFeedback)
        Me.Controls.Add(Me.ResultInterface)
        Me.Controls.Add(Me.Standard)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.Memory)
        Me.Controls.Add(Me.MemoryStore)
        Me.Controls.Add(Me.MemorySubtract)
        Me.Controls.Add(Me.MemoryAdd)
        Me.Controls.Add(Me.MemoryRecall)
        Me.Controls.Add(Me.ClearMemory)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnRaise2Pow)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.btnPercentage)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnzero)
        Me.Controls.Add(Me.btnPeriod)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPeriod As System.Windows.Forms.Button
    Friend WithEvents btnzero As System.Windows.Forms.Button
    Friend WithEvents btnplus As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnFactorial As System.Windows.Forms.Button
    Friend WithEvents btnRaise2Pow As System.Windows.Forms.Button
    Friend WithEvents btnSquare As System.Windows.Forms.Button
    Friend WithEvents btnPercentage As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents ClearMemory As System.Windows.Forms.Button
    Friend WithEvents MemoryRecall As System.Windows.Forms.Button
    Friend WithEvents MemorySubtract As System.Windows.Forms.Button
    Friend WithEvents MemoryAdd As System.Windows.Forms.Button
    Friend WithEvents Memory As System.Windows.Forms.Button
    Friend WithEvents MemoryStore As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents Standard As System.Windows.Forms.Label
    Friend WithEvents ResultInterface As System.Windows.Forms.Label
    Friend WithEvents UserInterfaceFeedback As System.Windows.Forms.Label

End Class
