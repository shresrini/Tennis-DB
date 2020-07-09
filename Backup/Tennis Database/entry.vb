Public Class entry

    Private Sub wch1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wch1.CheckedChanged
        atpentry.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wch2.CheckedChanged
        wtaentry.Show()

    End Sub

    Private Sub wch3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wch3.CheckedChanged
        gsopen.Show()

    End Sub

    Private Sub entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'wch1.Enabled = False
        'wch2.Enabled = False
        'wch3.Enabled = False
    End Sub
End Class
