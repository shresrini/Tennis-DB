Public Class atpentry

    Private Sub Radio250_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio250.CheckedChanged
        _250entry.Show()

    End Sub

    Private Sub Radio500_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio500.CheckedChanged
        _500entry.Show()


    End Sub

    Private Sub Radio1000_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio1000.CheckedChanged
        _1000entry.Show()

    End Sub

    Private Sub Radiotour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiotour.CheckedChanged
        finalsentry.Show()

    End Sub

    Private Sub Radiodavid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radiodavid.CheckedChanged
        davisentry.Show()

    End Sub
End Class