<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Minbtn = New System.Windows.Forms.Button()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Minbtn)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Location = New System.Drawing.Point(-8, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 26)
        Me.Panel1.TabIndex = 1
        '
        'Minbtn
        '
        Me.Minbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minbtn.BackColor = System.Drawing.Color.Transparent
        Me.Minbtn.FlatAppearance.BorderSize = 0
        Me.Minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minbtn.Font = New System.Drawing.Font("MS Outlook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minbtn.Location = New System.Drawing.Point(617, 1)
        Me.Minbtn.Name = "Minbtn"
        Me.Minbtn.Size = New System.Drawing.Size(42, 24)
        Me.Minbtn.TabIndex = 2
        Me.Minbtn.Text = "-"
        Me.Minbtn.UseVisualStyleBackColor = False
        '
        'Closebtn
        '
        Me.Closebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closebtn.BackColor = System.Drawing.Color.Transparent
        Me.Closebtn.FlatAppearance.BorderSize = 0
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Font = New System.Drawing.Font("MS Outlook", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closebtn.Location = New System.Drawing.Point(664, 1)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(42, 24)
        Me.Closebtn.TabIndex = 1
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(691, 403)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Minbtn As System.Windows.Forms.Button
    Friend WithEvents Closebtn As System.Windows.Forms.Button
End Class
