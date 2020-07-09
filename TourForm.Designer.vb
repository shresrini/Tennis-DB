<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TourForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TourForm))
        Dim Tour_NameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tennis_DatabaseDataSet = New Tennis_Database.Tennis_DatabaseDataSet()
        Me.Tbl_TourBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_TourTableAdapter = New Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_TourTableAdapter()
        Me.TableAdapterManager = New Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_TourBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_TourBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tour_NameTextBox = New System.Windows.Forms.TextBox()
        Tour_NameLabel = New System.Windows.Forms.Label()
        CType(Me.Tennis_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_TourBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_TourBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_TourBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tour Name :"
        '
        'Tennis_DatabaseDataSet
        '
        Me.Tennis_DatabaseDataSet.DataSetName = "Tennis_DatabaseDataSet"
        Me.Tennis_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_TourBindingSource
        '
        Me.Tbl_TourBindingSource.DataMember = "Tbl_Tour"
        Me.Tbl_TourBindingSource.DataSource = Me.Tennis_DatabaseDataSet
        '
        'Tbl_TourTableAdapter
        '
        Me.Tbl_TourTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tbl_TourTableAdapter = Me.Tbl_TourTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_TourBindingNavigator
        '
        Me.Tbl_TourBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_TourBindingNavigator.BindingSource = Me.Tbl_TourBindingSource
        Me.Tbl_TourBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_TourBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_TourBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_TourBindingNavigatorSaveItem})
        Me.Tbl_TourBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_TourBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_TourBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_TourBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_TourBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_TourBindingNavigator.Name = "Tbl_TourBindingNavigator"
        Me.Tbl_TourBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_TourBindingNavigator.Size = New System.Drawing.Size(303, 25)
        Me.Tbl_TourBindingNavigator.TabIndex = 3
        Me.Tbl_TourBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_TourBindingNavigatorSaveItem
        '
        Me.Tbl_TourBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_TourBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_TourBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_TourBindingNavigatorSaveItem.Name = "Tbl_TourBindingNavigatorSaveItem"
        Me.Tbl_TourBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Tbl_TourBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tour_NameLabel
        '
        Tour_NameLabel.AutoSize = True
        Tour_NameLabel.Location = New System.Drawing.Point(11, 45)
        Tour_NameLabel.Name = "Tour_NameLabel"
        Tour_NameLabel.Size = New System.Drawing.Size(63, 13)
        Tour_NameLabel.TabIndex = 3
        Tour_NameLabel.Text = "Tour Name:"
        '
        'Tour_NameTextBox
        '
        Me.Tour_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_TourBindingSource, "Tour_Name", True))
        Me.Tour_NameTextBox.Location = New System.Drawing.Point(80, 42)
        Me.Tour_NameTextBox.Name = "Tour_NameTextBox"
        Me.Tour_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tour_NameTextBox.TabIndex = 4
        '
        'TourForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 155)
        Me.Controls.Add(Tour_NameLabel)
        Me.Controls.Add(Me.Tour_NameTextBox)
        Me.Controls.Add(Me.Tbl_TourBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TourForm"
        Me.Text = "Tour Entry Form"
        CType(Me.Tennis_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_TourBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_TourBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_TourBindingNavigator.ResumeLayout(False)
        Me.Tbl_TourBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tennis_DatabaseDataSet As Tennis_Database.Tennis_DatabaseDataSet
    Friend WithEvents Tbl_TourBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_TourTableAdapter As Tennis_Database.Tennis_DatabaseDataSetTableAdapters.Tbl_TourTableAdapter
    Friend WithEvents TableAdapterManager As Tennis_Database.Tennis_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_TourBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_TourBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tour_NameTextBox As System.Windows.Forms.TextBox
End Class
