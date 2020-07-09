Imports System.Windows.Forms

Public Class frmMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles mnuItemATP.Click
       
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles mnuItemWTA.Click
        
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuItemGrandSlam.Click
        
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub mnuItemATP250AddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemATP250AddEdit.Click
        _250entry.MdiParent = Me
        _250entry.Show()
    End Sub

    Private Sub mnuItemATP500AddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemATP500AddEdit.Click
        _500entry.MdiParent() = Me
        _500entry.Show()
    End Sub

    Private Sub mnuItemATP1000AddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemATP1000AddEdit.Click
        _1000entry.MdiParent() = Me
        _1000entry.Show()
    End Sub

    Private Sub mnuItemBWTAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemBWTAddEdit.Click
        finalsentry.MdiParent() = Me
        finalsentry.Show()
    End Sub

    Private Sub mnuItemDCAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemDCAddEdit.Click
        davisentry.MdiParent() = Me
        davisentry.Show()
    End Sub

    Private Sub mnuItemWTAWTAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemWTAWTAddEdit.Click
        'wtatourentry.MdiParent() = Me
        'wtatourentry.Show()
        DisplayChild(wtatourentry)
    End Sub

    Private Sub mnuItemWTAFAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemWTAFAddEdit.Click
        'wtafinalsentry.MdiParent() = Me
        'wtafinalsentry.Show()
        DisplayChild(wtafinalsentry)
    End Sub

    Private Sub mnuItemAOAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemAOAddEdit.Click
        aussie_entry.MdiParent() = Me
        aussie_entry.Show()
    End Sub

    Private Sub mnuItemFOAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemFOAddEdit.Click
        french_entry.MdiParent() = Me
        french_entry.Show()
    End Sub

    Private Sub mnuItemWimbledonAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemWimbledonAddEdit.Click
        wimbl_entry.MdiParent() = Me
        wimbl_entry.Show()
    End Sub

    Private Sub mnuItemUSAddEdit_Click(sender As Object, e As EventArgs) Handles mnuItemUSAddEdit.Click
        us_entry.MdiParent() = Me
        us_entry.Show()
    End Sub
    Public Sub DisplayChild(child As Form)
        Dim max As Boolean = False
        If Me.ActiveMdiChild IsNot Nothing AndAlso Me.ActiveMdiChild.WindowState = FormWindowState.Maximized Then
            Me.ActiveMdiChild.WindowState = FormWindowState.Normal
            max = True
        End If
        child.MdiParent = Me
        child.Show()
        If max Then
            child.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class