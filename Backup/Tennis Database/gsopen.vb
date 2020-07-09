Public Class gsopen

    Private Sub Aus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aus.CheckedChanged
        aussie_entry.Show()

    End Sub

    Private Sub French_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles French.CheckedChanged
        french_entry.Show()

    End Sub

    Private Sub Wimbledon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wimbledon.CheckedChanged
        wimbl_entry.Show()

    End Sub

    Private Sub US_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles US.CheckedChanged
        us_entry.Show()

    End Sub
End Class