<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gsopen
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
        Me.US = New System.Windows.Forms.RadioButton
        Me.Wimbledon = New System.Windows.Forms.RadioButton
        Me.French = New System.Windows.Forms.RadioButton
        Me.Aus = New System.Windows.Forms.RadioButton
        Me.GSlbl = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'US
        '
        Me.US.AutoSize = True
        Me.US.CausesValidation = False
        Me.US.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.US.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.US.Location = New System.Drawing.Point(200, 197)
        Me.US.Name = "US"
        Me.US.Size = New System.Drawing.Size(86, 22)
        Me.US.TabIndex = 7
        Me.US.TabStop = True
        Me.US.Text = "US Open"
        Me.US.UseVisualStyleBackColor = True
        '
        'Wimbledon
        '
        Me.Wimbledon.AutoSize = True
        Me.Wimbledon.CausesValidation = False
        Me.Wimbledon.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wimbledon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Wimbledon.Location = New System.Drawing.Point(200, 160)
        Me.Wimbledon.Name = "Wimbledon"
        Me.Wimbledon.Size = New System.Drawing.Size(101, 22)
        Me.Wimbledon.TabIndex = 6
        Me.Wimbledon.TabStop = True
        Me.Wimbledon.Text = "Wimbledon"
        Me.Wimbledon.UseVisualStyleBackColor = True
        '
        'French
        '
        Me.French.AutoSize = True
        Me.French.CausesValidation = False
        Me.French.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.French.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.French.Location = New System.Drawing.Point(201, 119)
        Me.French.Name = "French"
        Me.French.Size = New System.Drawing.Size(121, 22)
        Me.French.TabIndex = 5
        Me.French.TabStop = True
        Me.French.Text = "Roland Garros"
        Me.French.UseVisualStyleBackColor = True
        '
        'Aus
        '
        Me.Aus.AutoSize = True
        Me.Aus.CausesValidation = False
        Me.Aus.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Aus.Location = New System.Drawing.Point(201, 81)
        Me.Aus.Name = "Aus"
        Me.Aus.Size = New System.Drawing.Size(135, 22)
        Me.Aus.TabIndex = 4
        Me.Aus.TabStop = True
        Me.Aus.Text = "Australian Open"
        Me.Aus.UseVisualStyleBackColor = True
        '
        'GSlbl
        '
        Me.GSlbl.AutoSize = True
        Me.GSlbl.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GSlbl.Location = New System.Drawing.Point(196, 29)
        Me.GSlbl.Name = "GSlbl"
        Me.GSlbl.Size = New System.Drawing.Size(400, 25)
        Me.GSlbl.TabIndex = 8
        Me.GSlbl.Text = "Into which grandslam do you want to enter ??"
        '
        'gsopen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 262)
        Me.Controls.Add(Me.GSlbl)
        Me.Controls.Add(Me.US)
        Me.Controls.Add(Me.Wimbledon)
        Me.Controls.Add(Me.French)
        Me.Controls.Add(Me.Aus)
        Me.Name = "gsopen"
        Me.Text = "gsopen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents US As System.Windows.Forms.RadioButton
    Friend WithEvents Wimbledon As System.Windows.Forms.RadioButton
    Friend WithEvents French As System.Windows.Forms.RadioButton
    Friend WithEvents Aus As System.Windows.Forms.RadioButton
    Friend WithEvents GSlbl As System.Windows.Forms.Label
End Class
