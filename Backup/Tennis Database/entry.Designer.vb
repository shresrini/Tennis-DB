<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entry
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
        Me.whichlbl = New System.Windows.Forms.Label
        Me.wch1 = New System.Windows.Forms.RadioButton
        Me.wch2 = New System.Windows.Forms.RadioButton
        Me.wch3 = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'whichlbl
        '
        Me.whichlbl.AutoSize = True
        Me.whichlbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whichlbl.Location = New System.Drawing.Point(99, 26)
        Me.whichlbl.Name = "whichlbl"
        Me.whichlbl.Size = New System.Drawing.Size(723, 25)
        Me.whichlbl.TabIndex = 0
        Me.whichlbl.Text = "Into which catagory of the tennis tournaments do you want enter the information ?" & _
            "?"
        '
        'wch1
        '
        Me.wch1.AutoSize = True
        Me.wch1.CausesValidation = False
        Me.wch1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wch1.ForeColor = System.Drawing.Color.DarkRed
        Me.wch1.Location = New System.Drawing.Point(104, 116)
        Me.wch1.Name = "wch1"
        Me.wch1.Size = New System.Drawing.Size(311, 22)
        Me.wch1.TabIndex = 1
        Me.wch1.Text = "Association of tennis professionals ( ATP ) "
        Me.wch1.UseVisualStyleBackColor = True
        '
        'wch2
        '
        Me.wch2.AutoSize = True
        Me.wch2.CausesValidation = False
        Me.wch2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wch2.ForeColor = System.Drawing.Color.DarkRed
        Me.wch2.Location = New System.Drawing.Point(104, 177)
        Me.wch2.Name = "wch2"
        Me.wch2.Size = New System.Drawing.Size(271, 22)
        Me.wch2.TabIndex = 2
        Me.wch2.Text = "Women's Tennis Association ( WTA )"
        Me.wch2.UseVisualStyleBackColor = True
        '
        'wch3
        '
        Me.wch3.AutoSize = True
        Me.wch3.CausesValidation = False
        Me.wch3.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wch3.ForeColor = System.Drawing.Color.DarkRed
        Me.wch3.Location = New System.Drawing.Point(104, 244)
        Me.wch3.Name = "wch3"
        Me.wch3.Size = New System.Drawing.Size(109, 22)
        Me.wch3.TabIndex = 3
        Me.wch3.Text = "Grand Slams"
        Me.wch3.UseVisualStyleBackColor = True
        '
        'entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 310)
        Me.Controls.Add(Me.wch3)
        Me.Controls.Add(Me.wch2)
        Me.Controls.Add(Me.wch1)
        Me.Controls.Add(Me.whichlbl)
        Me.Name = "entry"
        Me.Text = "entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents whichlbl As System.Windows.Forms.Label
    Friend WithEvents wch1 As System.Windows.Forms.RadioButton
    Friend WithEvents wch2 As System.Windows.Forms.RadioButton
    Friend WithEvents wch3 As System.Windows.Forms.RadioButton
End Class
