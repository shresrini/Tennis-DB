<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuTournamentData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP250Series = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP250AddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP250View = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP500Series = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP500AddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP500View = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP1000Series = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP1000AddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemATP1000View = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemBWTFinals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemBWTAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemBWTView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDavisCup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDCAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemDCView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAWT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAWTAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAWTView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAWorldTourFinals = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAFAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWTAFView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFCup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFedAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFedView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemGrandSlam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemAO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemAOAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemAOView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFOAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemFOView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWimbledon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWimbledonAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemWibledonView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUSO = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUSAddEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItemUSView = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTournamentData})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuTournamentData
        '
        Me.mnuTournamentData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemATP, Me.mnuItemWTA, Me.mnuItemGrandSlam})
        Me.mnuTournamentData.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.mnuTournamentData.Name = "mnuTournamentData"
        Me.mnuTournamentData.Size = New System.Drawing.Size(112, 20)
        Me.mnuTournamentData.Text = "&Tournament Data"
        '
        'mnuItemATP
        '
        Me.mnuItemATP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemATP250Series, Me.mnuItemATP500Series, Me.mnuItemATP1000Series, Me.mnuItemBWTFinals, Me.mnuItemDavisCup})
        Me.mnuItemATP.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuItemATP.Name = "mnuItemATP"
        Me.mnuItemATP.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuItemATP.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemATP.Text = "&ATP"
        '
        'mnuItemATP250Series
        '
        Me.mnuItemATP250Series.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemATP250AddEdit, Me.mnuItemATP250View})
        Me.mnuItemATP250Series.Name = "mnuItemATP250Series"
        Me.mnuItemATP250Series.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemATP250Series.Text = "ATP 250 &Series"
        '
        'mnuItemATP250AddEdit
        '
        Me.mnuItemATP250AddEdit.Name = "mnuItemATP250AddEdit"
        Me.mnuItemATP250AddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemATP250AddEdit.Text = "Add/Edit"
        '
        'mnuItemATP250View
        '
        Me.mnuItemATP250View.Name = "mnuItemATP250View"
        Me.mnuItemATP250View.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemATP250View.Text = "View"
        '
        'mnuItemATP500Series
        '
        Me.mnuItemATP500Series.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemATP500AddEdit, Me.mnuItemATP500View})
        Me.mnuItemATP500Series.Name = "mnuItemATP500Series"
        Me.mnuItemATP500Series.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemATP500Series.Text = "ATP 500 S&eries"
        '
        'mnuItemATP500AddEdit
        '
        Me.mnuItemATP500AddEdit.Name = "mnuItemATP500AddEdit"
        Me.mnuItemATP500AddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemATP500AddEdit.Text = "Add/Edit"
        '
        'mnuItemATP500View
        '
        Me.mnuItemATP500View.Name = "mnuItemATP500View"
        Me.mnuItemATP500View.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemATP500View.Text = "View"
        '
        'mnuItemATP1000Series
        '
        Me.mnuItemATP1000Series.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemATP1000AddEdit, Me.mnuItemATP1000View})
        Me.mnuItemATP1000Series.Name = "mnuItemATP1000Series"
        Me.mnuItemATP1000Series.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemATP1000Series.Text = "ATP 1000 Se&ries"
        '
        'mnuItemATP1000AddEdit
        '
        Me.mnuItemATP1000AddEdit.Name = "mnuItemATP1000AddEdit"
        Me.mnuItemATP1000AddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemATP1000AddEdit.Text = "Add/Edit"
        '
        'mnuItemATP1000View
        '
        Me.mnuItemATP1000View.Name = "mnuItemATP1000View"
        Me.mnuItemATP1000View.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemATP1000View.Text = "View"
        '
        'mnuItemBWTFinals
        '
        Me.mnuItemBWTFinals.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemBWTAddEdit, Me.mnuItemBWTView})
        Me.mnuItemBWTFinals.Name = "mnuItemBWTFinals"
        Me.mnuItemBWTFinals.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemBWTFinals.Text = "Barclays World Tour Fina&ls"
        '
        'mnuItemBWTAddEdit
        '
        Me.mnuItemBWTAddEdit.Name = "mnuItemBWTAddEdit"
        Me.mnuItemBWTAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemBWTAddEdit.Text = "Add/Edit"
        '
        'mnuItemBWTView
        '
        Me.mnuItemBWTView.Name = "mnuItemBWTView"
        Me.mnuItemBWTView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemBWTView.Text = "View"
        '
        'mnuItemDavisCup
        '
        Me.mnuItemDavisCup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemDCAddEdit, Me.mnuItemDCView})
        Me.mnuItemDavisCup.Name = "mnuItemDavisCup"
        Me.mnuItemDavisCup.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemDavisCup.Text = "Davis Cu&p"
        '
        'mnuItemDCAddEdit
        '
        Me.mnuItemDCAddEdit.Name = "mnuItemDCAddEdit"
        Me.mnuItemDCAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemDCAddEdit.Text = "Add/Edit"
        '
        'mnuItemDCView
        '
        Me.mnuItemDCView.Name = "mnuItemDCView"
        Me.mnuItemDCView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemDCView.Text = "View"
        '
        'mnuItemWTA
        '
        Me.mnuItemWTA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemWTAWT, Me.mnuItemWTAWorldTourFinals, Me.mnuItemFCup})
        Me.mnuItemWTA.ImageTransparentColor = System.Drawing.Color.Black
        Me.mnuItemWTA.Name = "mnuItemWTA"
        Me.mnuItemWTA.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuItemWTA.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemWTA.Text = "&WTA"
        '
        'mnuItemWTAWT
        '
        Me.mnuItemWTAWT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemWTAWTAddEdit, Me.mnuItemWTAWTView})
        Me.mnuItemWTAWT.Name = "mnuItemWTAWT"
        Me.mnuItemWTAWT.Size = New System.Drawing.Size(196, 22)
        Me.mnuItemWTAWT.Text = "WTA World Tour"
        '
        'mnuItemWTAWTAddEdit
        '
        Me.mnuItemWTAWTAddEdit.Name = "mnuItemWTAWTAddEdit"
        Me.mnuItemWTAWTAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemWTAWTAddEdit.Text = "Add/Edit"
        '
        'mnuItemWTAWTView
        '
        Me.mnuItemWTAWTView.Name = "mnuItemWTAWTView"
        Me.mnuItemWTAWTView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemWTAWTView.Text = "View"
        '
        'mnuItemWTAWorldTourFinals
        '
        Me.mnuItemWTAWorldTourFinals.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemWTAFAddEdit, Me.mnuItemWTAFView})
        Me.mnuItemWTAWorldTourFinals.Name = "mnuItemWTAWorldTourFinals"
        Me.mnuItemWTAWorldTourFinals.Size = New System.Drawing.Size(196, 22)
        Me.mnuItemWTAWorldTourFinals.Text = "WTA World Tour Finals"
        '
        'mnuItemWTAFAddEdit
        '
        Me.mnuItemWTAFAddEdit.Name = "mnuItemWTAFAddEdit"
        Me.mnuItemWTAFAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemWTAFAddEdit.Text = "Add/Edit"
        '
        'mnuItemWTAFView
        '
        Me.mnuItemWTAFView.Name = "mnuItemWTAFView"
        Me.mnuItemWTAFView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemWTAFView.Text = "View"
        '
        'mnuItemFCup
        '
        Me.mnuItemFCup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemFedAddEdit, Me.mnuItemFedView})
        Me.mnuItemFCup.Name = "mnuItemFCup"
        Me.mnuItemFCup.Size = New System.Drawing.Size(196, 22)
        Me.mnuItemFCup.Text = "Federation Cup"
        '
        'mnuItemFedAddEdit
        '
        Me.mnuItemFedAddEdit.Name = "mnuItemFedAddEdit"
        Me.mnuItemFedAddEdit.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemFedAddEdit.Text = "Add/Edit"
        '
        'mnuItemFedView
        '
        Me.mnuItemFedView.Name = "mnuItemFedView"
        Me.mnuItemFedView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemFedView.Text = "View"
        '
        'mnuItemGrandSlam
        '
        Me.mnuItemGrandSlam.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemAO, Me.mnuItemFO, Me.mnuItemWimbledon, Me.mnuItemUSO})
        Me.mnuItemGrandSlam.Name = "mnuItemGrandSlam"
        Me.mnuItemGrandSlam.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemGrandSlam.Text = "&Grand Slam"
        '
        'mnuItemAO
        '
        Me.mnuItemAO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemAOAddEdit, Me.mnuItemAOView})
        Me.mnuItemAO.Name = "mnuItemAO"
        Me.mnuItemAO.Size = New System.Drawing.Size(159, 22)
        Me.mnuItemAO.Text = "Australian Open"
        '
        'mnuItemAOAddEdit
        '
        Me.mnuItemAOAddEdit.Name = "mnuItemAOAddEdit"
        Me.mnuItemAOAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemAOAddEdit.Text = "Add/Edit"
        '
        'mnuItemAOView
        '
        Me.mnuItemAOView.Name = "mnuItemAOView"
        Me.mnuItemAOView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemAOView.Text = "View"
        '
        'mnuItemFO
        '
        Me.mnuItemFO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemFOAddEdit, Me.mnuItemFOView})
        Me.mnuItemFO.Name = "mnuItemFO"
        Me.mnuItemFO.Size = New System.Drawing.Size(159, 22)
        Me.mnuItemFO.Text = "French Open"
        '
        'mnuItemFOAddEdit
        '
        Me.mnuItemFOAddEdit.Name = "mnuItemFOAddEdit"
        Me.mnuItemFOAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemFOAddEdit.Text = "Add/Edit"
        '
        'mnuItemFOView
        '
        Me.mnuItemFOView.Name = "mnuItemFOView"
        Me.mnuItemFOView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemFOView.Text = "View"
        '
        'mnuItemWimbledon
        '
        Me.mnuItemWimbledon.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemWimbledonAddEdit, Me.mnuItemWibledonView})
        Me.mnuItemWimbledon.Name = "mnuItemWimbledon"
        Me.mnuItemWimbledon.Size = New System.Drawing.Size(159, 22)
        Me.mnuItemWimbledon.Text = "Wimbledon"
        '
        'mnuItemWimbledonAddEdit
        '
        Me.mnuItemWimbledonAddEdit.Name = "mnuItemWimbledonAddEdit"
        Me.mnuItemWimbledonAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemWimbledonAddEdit.Text = "Add/Edit"
        '
        'mnuItemWibledonView
        '
        Me.mnuItemWibledonView.Name = "mnuItemWibledonView"
        Me.mnuItemWibledonView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemWibledonView.Text = "View"
        '
        'mnuItemUSO
        '
        Me.mnuItemUSO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemUSAddEdit, Me.mnuItemUSView})
        Me.mnuItemUSO.Name = "mnuItemUSO"
        Me.mnuItemUSO.Size = New System.Drawing.Size(159, 22)
        Me.mnuItemUSO.Text = "US Open"
        '
        'mnuItemUSAddEdit
        '
        Me.mnuItemUSAddEdit.Name = "mnuItemUSAddEdit"
        Me.mnuItemUSAddEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuItemUSAddEdit.Text = "Add/Edit"
        '
        'mnuItemUSView
        '
        Me.mnuItemUSView.Name = "mnuItemUSView"
        Me.mnuItemUSView.Size = New System.Drawing.Size(121, 22)
        Me.mnuItemUSView.Text = "View"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Tennis Database"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuItemGrandSlam As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTournamentData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuItemATP250Series As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP250AddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP250View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP500Series As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP500AddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP500View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP1000Series As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemBWTFinals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemDavisCup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAWT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAWTAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAWTView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAWorldTourFinals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAFAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWTAFView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFCup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFedAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFedView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemAO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemAOAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemAOView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFOAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemFOView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWimbledon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWimbledonAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemWibledonView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemUSO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemUSAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemUSView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP1000AddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemATP1000View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemBWTAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemBWTView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemDCAddEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemDCView As System.Windows.Forms.ToolStripMenuItem

End Class
