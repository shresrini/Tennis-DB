﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wimbl_entry
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Exitbtn = New System.Windows.Forms.Button
        Me.Yeartext = New System.Windows.Forms.TextBox
        Me.Year = New System.Windows.Forms.Label
        Me.Tourneytext = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Typetext = New System.Windows.Forms.TextBox
        Me.Type = New System.Windows.Forms.Label
        Me.Settext = New System.Windows.Forms.TextBox
        Me.Runnat = New System.Windows.Forms.TextBox
        Me.Winnat = New System.Windows.Forms.TextBox
        Me.Runtext = New System.Windows.Forms.TextBox
        Me.Wintext = New System.Windows.Forms.TextBox
        Me.Sets = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Wincon = New System.Windows.Forms.Label
        Me.Runner = New System.Windows.Forms.Label
        Me.Winner = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 52)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Exitbtn
        '
        Me.Exitbtn.Location = New System.Drawing.Point(142, 206)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(79, 52)
        Me.Exitbtn.TabIndex = 56
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = True
        '
        'Yeartext
        '
        Me.Yeartext.Location = New System.Drawing.Point(588, 51)
        Me.Yeartext.Name = "Yeartext"
        Me.Yeartext.Size = New System.Drawing.Size(172, 20)
        Me.Yeartext.TabIndex = 55
        '
        'Year
        '
        Me.Year.AutoSize = True
        Me.Year.Location = New System.Drawing.Point(527, 58)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(29, 13)
        Me.Year.TabIndex = 54
        Me.Year.Text = "Year"
        '
        'Tourneytext
        '
        Me.Tourneytext.Location = New System.Drawing.Point(588, 5)
        Me.Tourneytext.Name = "Tourneytext"
        Me.Tourneytext.Size = New System.Drawing.Size(178, 20)
        Me.Tourneytext.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Tournament Name"
        '
        'Typetext
        '
        Me.Typetext.Location = New System.Drawing.Point(257, 58)
        Me.Typetext.Name = "Typetext"
        Me.Typetext.Size = New System.Drawing.Size(173, 20)
        Me.Typetext.TabIndex = 51
        '
        'Type
        '
        Me.Type.AutoSize = True
        Me.Type.Location = New System.Drawing.Point(139, 58)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(85, 13)
        Me.Type.TabIndex = 50
        Me.Type.Text = "Singles/Doubles"
        '
        'Settext
        '
        Me.Settext.Location = New System.Drawing.Point(582, 206)
        Me.Settext.Name = "Settext"
        Me.Settext.Size = New System.Drawing.Size(186, 20)
        Me.Settext.TabIndex = 49
        '
        'Runnat
        '
        Me.Runnat.Location = New System.Drawing.Point(588, 135)
        Me.Runnat.Name = "Runnat"
        Me.Runnat.Size = New System.Drawing.Size(180, 20)
        Me.Runnat.TabIndex = 48
        '
        'Winnat
        '
        Me.Winnat.Location = New System.Drawing.Point(588, 91)
        Me.Winnat.Name = "Winnat"
        Me.Winnat.Size = New System.Drawing.Size(180, 20)
        Me.Winnat.TabIndex = 47
        '
        'Runtext
        '
        Me.Runtext.Location = New System.Drawing.Point(257, 146)
        Me.Runtext.Name = "Runtext"
        Me.Runtext.Size = New System.Drawing.Size(173, 20)
        Me.Runtext.TabIndex = 46
        '
        'Wintext
        '
        Me.Wintext.Location = New System.Drawing.Point(257, 100)
        Me.Wintext.Name = "Wintext"
        Me.Wintext.Size = New System.Drawing.Size(173, 20)
        Me.Wintext.TabIndex = 45
        '
        'Sets
        '
        Me.Sets.AutoSize = True
        Me.Sets.Location = New System.Drawing.Point(419, 213)
        Me.Sets.Name = "Sets"
        Me.Sets.Size = New System.Drawing.Size(154, 13)
        Me.Sets.TabIndex = 44
        Me.Sets.Text = "Number Of Sets Taken To Win"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Runner Up's Nationality"
        '
        'Wincon
        '
        Me.Wincon.AutoSize = True
        Me.Wincon.Location = New System.Drawing.Point(473, 100)
        Me.Wincon.Name = "Wincon"
        Me.Wincon.Size = New System.Drawing.Size(100, 13)
        Me.Wincon.TabIndex = 42
        Me.Wincon.Text = "Winner's Nationality"
        '
        'Runner
        '
        Me.Runner.AutoSize = True
        Me.Runner.Location = New System.Drawing.Point(139, 153)
        Me.Runner.Name = "Runner"
        Me.Runner.Size = New System.Drawing.Size(59, 13)
        Me.Runner.TabIndex = 41
        Me.Runner.Text = "Runner Up"
        '
        'Winner
        '
        Me.Winner.AutoSize = True
        Me.Winner.Location = New System.Drawing.Point(139, 107)
        Me.Winner.Name = "Winner"
        Me.Winner.Size = New System.Drawing.Size(41, 13)
        Me.Winner.TabIndex = 40
        Me.Winner.Text = "Winner"
        '
        'wimbl_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Yeartext)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Tourneytext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Typetext)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Settext)
        Me.Controls.Add(Me.Runnat)
        Me.Controls.Add(Me.Winnat)
        Me.Controls.Add(Me.Runtext)
        Me.Controls.Add(Me.Wintext)
        Me.Controls.Add(Me.Sets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Wincon)
        Me.Controls.Add(Me.Runner)
        Me.Controls.Add(Me.Winner)
        Me.Name = "wimbl_entry"
        Me.Text = "wimbl_entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Exitbtn As System.Windows.Forms.Button
    Friend WithEvents Yeartext As System.Windows.Forms.TextBox
    Friend WithEvents Year As System.Windows.Forms.Label
    Friend WithEvents Tourneytext As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Typetext As System.Windows.Forms.TextBox
    Friend WithEvents Type As System.Windows.Forms.Label
    Friend WithEvents Settext As System.Windows.Forms.TextBox
    Friend WithEvents Runnat As System.Windows.Forms.TextBox
    Friend WithEvents Winnat As System.Windows.Forms.TextBox
    Friend WithEvents Runtext As System.Windows.Forms.TextBox
    Friend WithEvents Wintext As System.Windows.Forms.TextBox
    Friend WithEvents Sets As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Wincon As System.Windows.Forms.Label
    Friend WithEvents Runner As System.Windows.Forms.Label
    Friend WithEvents Winner As System.Windows.Forms.Label
End Class
