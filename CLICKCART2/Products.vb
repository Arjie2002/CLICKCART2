Imports MySql.Data.MySqlClient

Public Class Products
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
        command.CommandText = "SELECT * FROM shopping_db.product"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim Product_ID = reader.GetString(0)
            Dim Product_Name = reader.GetString(1)
            Dim Price = reader.GetString(2)
            Dim Quantity = reader.GetString(3)
            Dim Categ_ID = reader.GetString(4)
            DataGridView1.Rows.Add(Product_ID, Product_Name, Price, Quantity, Categ_ID)

        End While

        Call Disconnect_to_Db()
    End Sub

    Private Sub btnInserProduct_Click(sender As Object, e As EventArgs) Handles btnInserProduct.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Insert into product values('" & txtProductID.Text & "', '" & txtProductName.Text & "', '" & txtProductPrice.Text & "', '" & txtProductQuantity.Text & "', '" & txtProductCategoryID.Text & "')", conn)

        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Record Successfully Added")
            Call Clear()
        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_Db()
        End Try
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("UPDATE product SET Product_Name= '" & txtProductName.Text & "', Price= '" & txtProductPrice.Text & "', Quantity= '" & txtProductQuantity.Text & "', Categ_ID= '" & txtProductCategoryID.Text & "' WHERE Product_ID = '" & txtProductID.Text & "' ", conn)

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

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.No Then Return

        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Delete from product where Product_ID = '" & txtProductID.Text & "'", conn)

        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Record Successfully Deleted")
            Call Clear()
        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Disconnect_to_Db()
        End Try
    End Sub
    Private Sub Clear()
        With Me
            .txtProductID.Text = ""
            .txtProductName.Text = ""
            .txtProductPrice.Text = ""
            .txtProductQuantity.Text = ""
            .txtProductCategoryID.Text = ""
        End With
    End Sub


End Class