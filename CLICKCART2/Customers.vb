Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Customers
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnInserCustomer_Click(sender As Object, e As EventArgs) Handles btnInserCustomer.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Insert into customer values('" & txtCustomerID.Text & "', '" & txtCustomerFName.Text & "', '" & txtCustomerLName.Text & "', '" & txtCustomerPhoneNumber.Text & "')", conn)

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

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("UPDATE customer SET Cust_FirstName= '" & txtCustomerFName.Text & "', Cust_LastName= '" & txtCustomerLName.Text & "', Phone_Number= '" & txtCustomerPhoneNumber.Text & "' WHERE Cust_ID = '" & txtCustomerID.Text & "' ", conn)

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


    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.No Then Return

        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Delete from customer WHERE Cust_ID = '" & txtCustomerID.Text & "'", conn)

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
            .txtCustomerID.Text = ""
            .txtCustomerFName.Text = ""
            .txtCustomerLName.Text = ""
            .txtCustomerPhoneNumber.Text = ""
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Transactions
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.transactions", conn)
        Dim command As New MySqlCommand
        Dim dt As New DataTable()

        command.Connection = conn
        command.CommandText = "SELECT * FROM shopping_db.customer"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim Cust_ID = reader.GetString(0)
            Dim Cust_FirstName = reader.GetString(1)
            Dim Cust_LastName = reader.GetString(2)
            Dim Phone_Number = reader.GetString(3)
            DataGridView1.Rows.Add(Cust_ID, Cust_FirstName, Cust_LastName, Phone_Number)

        End While

        Call Disconnect_to_Db()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog1 As New OpenFileDialog With {
        .Filter = "Text Files (*.csv)|*.csv|All Files (*.*)|*.*",
        .FilterIndex = 1,
        .RestoreDirectory = True
    }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim path As String = filePath.Replace("\", "/")

            Connect_to_Db()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Load DATA INFILE '" & path & "' INTO TABLE customer " &
                     "FIELDS TERMINATED BY ',' " &
                     "LINES TERMINATED BY '\r\n' " &
                     "IGNORE 1 LINES"

                mycmd.CommandText = strSQL
                mycmd.Connection = conn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Data uploaded successfully")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Disconnect_to_Db()
            End Try
        End If
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        export_to_csv("customer")
    End Sub
End Class