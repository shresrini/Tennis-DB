<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class atpentry
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
        Me.Radio250 = New System.Windows.Forms.RadioButton
        Me.wch1lbl = New System.Windows.Forms.Label
        Me.Radio500 = New System.Windows.Forms.RadioButton
        Me.Radio1000 = New System.Windows.Forms.RadioButton
        Me.Radiotour = New System.Windows.Forms.RadioButton
        Me.Radiodavid = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Radio250
        '
        Me.Radio250.AutoSize = True
        Me.Radio250.CausesValidation = False
        Me.Radio250.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio250.Location = New System.Drawing.Point(205, 77)
        Me.Radio250.Name = "Radio250"
        Me.Radio250.Size = New System.Drawing.Size(133, 22)
        Me.Radio250.TabIndex = 0
        Me.Radio250.TabStop = True
        Me.Radio250.Text = "ATP 250 Series "
        Me.Radio250.UseVisualStyleBackColor = True
        '
        'wch1lbl
        '
        Me.wch1lbl.AutoSize = True
        Me.wch1lbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wch1lbl.Location = New System.Drawing.Point(200, 19)
        Me.wch1lbl.Name = "wch1lbl"
        Me.wch1lbl.Size = New System.Drawing.Size(426, 25)
        Me.wch1lbl.TabIndex = 1
        Me.wch1lbl.Text = "Which series of ATP do you want to enter into ? "
        '
        'Radio500
        '
        Me.Radio500.AutoSize = True
        Me.Radio500.CausesValidation = False
        Me.Radio500.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio500.Location = New System.Drawing.Point(205, 123)
        Me.Radio500.Name = "Radio500"
        Me.Radio500.Size = New System.Drawing.Size(128, 22)
        Me.Radio500.TabIndex = 2
        Me.Radio500.TabStop = True
        Me.Radio500.Text = "ATP 500 Series"
        Me.Radio500.UseVisualStyleBackColor = True
        '
        'Radio1000
        '
        Me.Radio1000.AutoSize = True
        Me.Radio1000.CausesValidation = False
        Me.Radio1000.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio1000.Location = New System.Drawing.Point(205, 169)
        Me.Radio1000.Name = "Radio1000"
        Me.Radio1000.Size = New System.Drawing.Size(136, 22)
        Me.Radio1000.TabIndex = 3
        Me.Radio1000.TabStop = True
        Me.Radio1000.Text = "ATP 1000 Series"
        Me.Radio1000.UseVisualStyleBackColor = True
        '
        'Radiotour
        '
        Me.Radiotour.AutoSize = True
        Me.Radiotour.CausesValidation = False
        Me.Radiotour.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiotour.Location = New System.Drawing.Point(205, 216)
        Me.Radiotour.Name = "Radiotour"
        Me.Radiotour.Size = New System.Drawing.Size(184, 22)
        Me.Radiotour.TabIndex = 4
        Me.Radiotour.TabStop = True
        Me.Radiotour.Text = "ATP World Tour Finals"
        Me.Radiotour.UseVisualStyleBackColor = True
        '
        'Radiodavid
        '
        Me.Radiodavid.AutoSize = True
        Me.Radiodavid.CausesValidation = False
        Me.Radiodavid.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiodavid.Location = New System.Drawing.Point(205, 260)
        Me.Radiodavid.Name = "Radiodavid"
        Me.Radiodavid.Size = New System.Drawing.Size(96, 22)
        Me.Radiodavid.TabIndex = 5
        Me.Radiodavid.TabStop = True
        Me.Radiodavid.Text = "Davis Cup"
        Me.Radiodavid.UseVisualStyleBackColor = True
        '
        'atpentry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 298)
        Me.Controls.Add(Me.Radiodavid)
        Me.Controls.Add(Me.Radiotour)
        Me.Controls.Add(Me.Radio1000)
        Me.Controls.Add(Me.Radio500)
        Me.Controls.Add(Me.wch1lbl)
        Me.Controls.Add(Me.Radio250)
        Me.Name = "atpentry"
        Me.Text = "atpentry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Radio250 As System.Windows.Forms.RadioButton
    Friend WithEvents wch1lbl As System.Windows.Forms.Label
    Friend WithEvents Radio500 As System.Windows.Forms.RadioButton
    Friend WithEvents Radio1000 As System.Windows.Forms.RadioButton
    Friend WithEvents Radiotour As System.Windows.Forms.RadioButton
    Friend WithEvents Radiodavid As System.Windows.Forms.RadioButton
End Class
