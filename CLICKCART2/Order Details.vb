Imports MySql.Data.MySqlClient

Public Class Order_Details
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()

        Dim table As New DataTable()
        Dim command As New MySqlCommand
        Dim dt As New DataTable()

        command.Connection = conn
        command.CommandText = "SELECT * FROM shopping_db.odetails"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim Ord_ID = reader.GetString(0)
            Dim Prod_ID = reader.GetString(1)
            Dim Price = reader.GetString(2)
            Dim Quantity = reader.GetString(3)
            DataGridView1.Rows.Add(Ord_ID, Prod_ID, Price, Quantity)

        End While

        Call Disconnect_to_Db()

    End Sub

    Private Sub btnEditOrderDetails_Click(sender As Object, e As EventArgs) Handles btnEditOrderDetails.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("UPDATE odetails SET Prod_ID= '" & txtOdetailsProductID.Text & "', Price= '" & txtOdetailsPrice.Text & "', Quantity= '" & txtOdetailsQuantity.Text & "' WHERE Ord_ID = '" & txtOdetailsOrderID.Text & "' ", conn)

        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Record Successfully Updated")
            Call Clear()
        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_Db()
        End Try
    End Sub

    Private Sub Clear()
        With Me
            .txtOdetailsOrderID.Text = ""
            .txtOdetailsProductID.Text = ""
            .txtOdetailsPrice.Text = ""
            .txtOdetailsQuantity.Text = ""
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        export_to_csv("odetails")
    End Sub
End Class