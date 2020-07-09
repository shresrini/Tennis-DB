<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class question
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
        Me.ques1 = New System.Windows.Forms.Button
        Me.orlbl = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ques1
        '
        Me.ques1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ques1.Location = New System.Drawing.Point(224, 37)
        Me.ques1.Name = "ques1"
        Me.ques1.Size = New System.Drawing.Size(488, 71)
        Me.ques1.TabIndex = 0
        Me.ques1.Text = "Do you want to enter into the database ?? "
        Me.ques1.UseVisualStyleBackColor = True
        '
        'orlbl
        '
        Me.orlbl.AutoSize = True
        Me.orlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orlbl.Location = New System.Drawing.Point(430, 160)
        Me.orlbl.Name = "orlbl"
        Me.orlbl.Size = New System.Drawing.Size(35, 25)
        Me.orlbl.TabIndex = 1
        Me.orlbl.Text = "Or"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(224, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(481, 69)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Do you want to see the list of champions of different tournaments??"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 333)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.orlbl)
        Me.Controls.Add(Me.ques1)
        Me.Name = "question"
        Me.Text = "question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ques1 As System.Windows.Forms.Button
    Friend WithEvents orlbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
