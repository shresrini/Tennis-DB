<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlayers
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
        Me.components = New System.ComponentModel.Container()
        Me.Tbl_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_CountryTableAdapter = New Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_CountryTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdBtnFemale = New System.Windows.Forms.RadioButton()
        Me.rdoBtnMale = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Tbl_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbl_CountryTableAdapter
        '
        Me.Tbl_CountryTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player Name :"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(122, 32)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayerName.TabIndex = 1
        '
        'cmbCountry
        '
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Location = New System.Drawing.Point(122, 69)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(121, 21)
        Me.cmbCountry.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Country :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdBtnFemale)
        Me.GroupBox1.Controls.Add(Me.rdoBtnMale)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender :"
        '
        'rdBtnFemale
        '
        Me.rdBtnFemale.AutoSize = True
        Me.rdBtnFemale.Location = New System.Drawing.Point(71, 53)
        Me.rdBtnFemale.Name = "rdBtnFemale"
        Me.rdBtnFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdBtnFemale.TabIndex = 9
        Me.rdBtnFemale.TabStop = True
        Me.rdBtnFemale.Text = "Female"
        Me.rdBtnFemale.UseVisualStyleBackColor = True
        '
        'rdoBtnMale
        '
        Me.rdoBtnMale.AutoSize = True
        Me.rdoBtnMale.Location = New System.Drawing.Point(71, 30)
        Me.rdoBtnMale.Name = "rdoBtnMale"
        Me.rdoBtnMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoBtnMale.TabIndex = 8
        Me.rdoBtnMale.TabStop = True
        Me.rdoBtnMale.Text = "Male"
        Me.rdoBtnMale.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(125, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Save Player Record"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPlayers"
        Me.Text = "frmPlayers"
        CType(Me.Tbl_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tbl_CountryTableAdapter As Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_CountryTableAdapter
    Friend WithEvents Tbl_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents cmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdBtnFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBtnMale As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
