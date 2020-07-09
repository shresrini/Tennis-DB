<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wtaentry
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
        Me.wtalbl = New System.Windows.Forms.Label
        Me.Fed = New System.Windows.Forms.RadioButton
        Me.WTAFinals = New System.Windows.Forms.RadioButton
        Me.WTATour = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'wtalbl
        '
        Me.wtalbl.AutoSize = True
        Me.wtalbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtalbl.Location = New System.Drawing.Point(179, 9)
        Me.wtalbl.Name = "wtalbl"
        Me.wtalbl.Size = New System.Drawing.Size(463, 25)
        Me.wtalbl.TabIndex = 0
        Me.wtalbl.Text = "Into which WTA tournament do you want to enter ??"
        '
        'Fed
        '
        Me.Fed.AutoSize = True
        Me.Fed.CausesValidation = False
        Me.Fed.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fed.ForeColor = System.Drawing.Color.Sienna
        Me.Fed.Location = New System.Drawing.Point(184, 176)
        Me.Fed.Name = "Fed"
        Me.Fed.Size = New System.Drawing.Size(83, 22)
        Me.Fed.TabIndex = 5
        Me.Fed.Text = "Fed Cup"
        Me.Fed.UseVisualStyleBackColor = True
        '
        'WTAFinals
        '
        Me.WTAFinals.AutoSize = True
        Me.WTAFinals.CausesValidation = False
        Me.WTAFinals.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTAFinals.ForeColor = System.Drawing.Color.Sienna
        Me.WTAFinals.Location = New System.Drawing.Point(184, 129)
        Me.WTAFinals.Name = "WTAFinals"
        Me.WTAFinals.Size = New System.Drawing.Size(143, 22)
        Me.WTAFinals.TabIndex = 4
        Me.WTAFinals.Text = "WTA Tour Finals"
        Me.WTAFinals.UseVisualStyleBackColor = True
        '
        'WTATour
        '
        Me.WTATour.AutoSize = True
        Me.WTATour.CausesValidation = False
        Me.WTATour.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTATour.ForeColor = System.Drawing.Color.Sienna
        Me.WTATour.Location = New System.Drawing.Point(184, 72)
        Me.WTATour.Name = "WTATour"
        Me.WTATour.Size = New System.Drawing.Size(149, 22)
        Me.WTATour.TabIndex = 3
        Me.WTATour.Text = "WTA World Tour "
        Me.WTATour.UseVisualStyleBackColor = True
        '
        'wtaentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(884, 262)
        Me.Controls.Add(Me.Fed)
        Me.Controls.Add(Me.WTAFinals)
        Me.Controls.Add(Me.WTATour)
        Me.Controls.Add(Me.wtalbl)
        Me.Name = "wtaentry"
        Me.Text = "wtaentry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wtalbl As System.Windows.Forms.Label
    Friend WithEvents Fed As System.Windows.Forms.RadioButton
    Friend WithEvents WTAFinals As System.Windows.Forms.RadioButton
    Friend WithEvents WTATour As System.Windows.Forms.RadioButton
End Class
