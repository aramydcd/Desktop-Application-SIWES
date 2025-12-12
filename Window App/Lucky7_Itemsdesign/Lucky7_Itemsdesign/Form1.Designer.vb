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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelClone = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelClone.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(17, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 35)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "Skip"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Navy
        Me.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStart.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ButtonStart.Location = New System.Drawing.Point(17, 15)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(108, 49)
        Me.ButtonStart.TabIndex = 124
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = False
        Me.ButtonStart.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(351, 78)
        Me.Label14.TabIndex = 123
        Me.Label14.Text = "Lucky 7 is a popular dice game that involves rolling three dice to score points."
        Me.Label14.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'PanelClone
        '
        Me.PanelClone.AutoScroll = True
        Me.PanelClone.BackColor = System.Drawing.Color.Navy
        Me.PanelClone.Controls.Add(Me.Label3)
        Me.PanelClone.Controls.Add(Me.Label1)
        Me.PanelClone.ForeColor = System.Drawing.Color.White
        Me.PanelClone.Location = New System.Drawing.Point(359, 27)
        Me.PanelClone.Name = "PanelClone"
        Me.PanelClone.Size = New System.Drawing.Size(427, 349)
        Me.PanelClone.TabIndex = 126
        Me.PanelClone.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 81)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How To Play"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(46, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 54)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 448)
        Me.Controls.Add(Me.PanelClone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelClone.ResumeLayout(False)
        Me.PanelClone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelClone As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
