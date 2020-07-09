Public Class wtaentry

    Private Sub WTATour_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WTATour.CheckedChanged
        wtatourentry.Show()

    End Sub

    Private Sub WTAFinals_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WTAFinals.CheckedChanged
        wtafinalsentry.Show()

    End Sub

    Private Sub Fed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fed.CheckedChanged
        fedentry.Show()

    End Sub
End Class