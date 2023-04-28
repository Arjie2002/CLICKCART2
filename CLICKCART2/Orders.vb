Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Orders
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
        command.CommandText = "SELECT * FROM shopping_db.orders"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim Order_ID = reader.GetString(0)
            Dim Order_Name = reader.GetString(1)
            Dim Order_Date = reader.GetString(2)
            Dim Total_Amount = reader.GetString(3)
            Dim Customer_ID = reader.GetString(4)
            DataGridView1.Rows.Add(Order_ID, Order_Name, Order_Date, Total_Amount, Customer_ID)

        End While

        Call Disconnect_to_Db()

    End Sub

    Private Sub btnInserOrder_Click(sender As Object, e As EventArgs) Handles btnInserOrder.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Insert into orders values('" & txtOrderID.Text & "', '" & txtOrderName.Text & "', '" & txtOrderDate.Text & "', '" & txtOrderAmount.Text & "', '" & txtOrderCustID.Text & "')", conn)

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

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("UPDATE orders SET Order_Name= '" & txtOrderName.Text & "', Order_Date= '" & txtOrderDate.Text & "', Total_Amount= '" & txtOrderAmount.Text & "', Customer_ID= '" & txtOrderCustID.Text & "' WHERE Order_ID = '" & txtOrderID.Text & "' ", conn)

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

    Private Sub btnDeleteOrder_Click(sender As Object, e As EventArgs) Handles btnDeleteOrder.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.No Then Return

        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Delete from orders where Order_ID = '" & txtOrderID.Text & "'", conn)

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
            .txtOrderID.Text = ""
            .txtOrderName.Text = ""
            .txtOrderDate.Text = ""
            .txtOrderAmount.Text = ""
            .txtOrderCustID.Text = ""
        End With
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        export_to_csv("orders")
    End Sub
End Class