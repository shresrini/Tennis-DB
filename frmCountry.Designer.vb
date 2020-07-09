<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCountry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCountry))
        Dim Country_NameLabel As System.Windows.Forms.Label
        Me.Tennis_DatabaseDataSet = New Tennis_Database.Tennis_DatabaseDataSet()
        Me.Tbl_CountryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_CountryTableAdapter = New Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_CountryTableAdapter()
        Me.TableAdapterManager = New Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_CountryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_CountryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Country_NameTextBox = New System.Windows.Forms.TextBox()
        Country_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Tennis_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_CountryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_CountryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_CountryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tennis_DatabaseDataSet
        '
        Me.Tennis_DatabaseDataSet.DataSetName = "Tennis_DatabaseDataSet"
        Me.Tennis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_CountryBindingSource
        '
        Me.Tbl_CountryBindingSource.DataMember = "Tbl_Country"
        Me.Tbl_CountryBindingSource.DataSource = Me.Tennis_DatabaseDataSet
        '
        'Tbl_CountryTableAdapter
        '
        Me.Tbl_CountryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tbl_CountryTableAdapter = Me.Tbl_CountryTableAdapter
        Me.TableAdapterManager.Tbl_TourTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_CountryBindingNavigator
        '
        Me.Tbl_CountryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_CountryBindingNavigator.BindingSource = Me.Tbl_CountryBindingSource
        Me.Tbl_CountryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_CountryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_CountryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_CountryBindingNavigatorSaveItem})
        Me.Tbl_CountryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_CountryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_CountryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_CountryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_CountryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_CountryBindingNavigator.Name = "Tbl_CountryBindingNavigator"
        Me.Tbl_CountryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_CountryBindingNavigator.Size = New System.Drawing.Size(309, 25)
        Me.Tbl_CountryBindingNavigator.TabIndex = 0
        Me.Tbl_CountryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Tbl_CountryBindingNavigatorSaveItem
        '
        Me.Tbl_CountryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_CountryBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_CountryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_CountryBindingNavigatorSaveItem.Name = "Tbl_CountryBindingNavigatorSaveItem"
        Me.Tbl_CountryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_CountryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Country_NameLabel
        '
        Country_NameLabel.AutoSize = True
        Country_NameLabel.Location = New System.Drawing.Point(35, 61)
        Country_NameLabel.Name = "Country_NameLabel"
        Country_NameLabel.Size = New System.Drawing.Size(77, 13)
        Country_NameLabel.TabIndex = 1
        Country_NameLabel.Text = "Country Name:"
        '
        'Country_NameTextBox
        '
        Me.Country_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_CountryBindingSource, "Country_Name", True))
        Me.Country_NameTextBox.Location = New System.Drawing.Point(118, 58)
        Me.Country_NameTextBox.Name = "Country_NameTextBox"
        Me.Country_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Country_NameTextBox.TabIndex = 2
        '
        'frmCountry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 261)
        Me.Controls.Add(Country_NameLabel)
        Me.Controls.Add(Me.Country_NameTextBox)
        Me.Controls.Add(Me.Tbl_CountryBindingNavigator)
        Me.Name = "frmCountry"
        Me.Text = "frmCountry"
        CType(Me.Tennis_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_CountryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_CountryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_CountryBindingNavigator.ResumeLayout(False)
        Me.Tbl_CountryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tennis_DatabaseDataSet As Tennis_Database.Tennis_DatabaseDataSet
    Friend WithEvents Tbl_CountryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_CountryTableAdapter As Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_CountryTableAdapter
    Friend WithEvents TableAdapterManager As Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_CountryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_CountryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Country_NameTextBox As System.Windows.Forms.TextBox
End Class
