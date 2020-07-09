Public Class frmCountry

    Private Sub Tbl_CountryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_CountryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_CountryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tennis_DatabaseDataSet)

    End Sub

    Private Sub frmCountry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tennis_DatabaseDataSet.Tbl_Country' table. You can move, or remove it, as needed.
        Me.Tbl_CountryTableAdapter.Fill(Me.Tennis_DatabaseDataSet.Tbl_Country)

    End Sub
End Class