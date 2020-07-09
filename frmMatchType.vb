Public Class frmMatchType

    Private Sub Tbl_Match_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Match_TypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_Match_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Tennis_DatabaseDataSet)

    End Sub

    Private Sub frmMatchType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Tennis_DatabaseDataSet.Tbl_Match_Type' table. You can move, or remove it, as needed.
        Me.Tbl_Match_TypeTableAdapter.Fill(Me.Tennis_DatabaseDataSet.Tbl_Match_Type)

    End Sub
End Class