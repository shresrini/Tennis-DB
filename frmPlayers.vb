Imports System.Data.SqlClient

Public Class frmPlayers

    Private Sub Tbl_PlayerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmPlayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String = "select ID,Country_name from tbl_country"

        Using connection As New SqlConnection("Data Source=SHREYAS\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;Initial Catalog=Tennis_Database")
            Dim daPlayers As New SqlDataAdapter(sql, connection)
            Dim dsPls As New DataTable
            daPlayers.Fill(dsPls)
            With cmbCountry
                .DataSource = dsPls
                .DisplayMember = "Country_Name"
                .ValueMember = "ID"
                .SelectedIndex = 0
            End With
        End Using

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strName As String
        Dim Country_ID As Integer
        Dim isFemale As String = "0"

        If txtPlayerName.Text.Length = 0 Then
            Return
        End If

        strName = txtPlayerName.Text
        Country_ID = Convert.ToInt32(cmbCountry.SelectedValue)

        If rdBtnFemale.Checked Then
            isFemale = "1"
        ElseIf rdoBtnMale.Checked Then
            isFemale = "0"
        End If

        Dim sql As String = "insert into tbl_player (Player_Name, Country_ID,isFemale) VALUES ('" & strName & "', " & Country_ID & ", " & isFemale & ")"

        Using connection As New SqlConnection("Data Source=SHREYAS\SQLEXPRESS;Initial Catalog=Tennis_Database;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False")
            Dim command As New SqlCommand(sql, connection)
            command.Connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub
End Class