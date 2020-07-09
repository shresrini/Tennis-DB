Public Class TourForm

    Private Sub TourForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tennis_DatabaseDataSet.Tbl_Tour' table. You can move, or remove it, as needed.
        Me.Tbl_TourTableAdapter.Fill(Me.Tennis_DatabaseDataSet.Tbl_Tour)

    End Sub

    Private Sub Tbl_TourBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_TourBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_TourBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tennis_DatabaseDataSet)

    End Sub
End Class