Imports MySql.Data.MySqlClient

Public Class Categories
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsertCategory_Click(sender As Object, e As EventArgs) Handles btnInsertCategory.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Insert into category values('" & txtCategoryID.Text & "', '" & txtCategoryName.Text & "', '" & txtCategoryDescription.Text & "')", conn)

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

    Private Sub btnUpdateCategory_Click(sender As Object, e As EventArgs) Handles btnUpdateCategory.Click
        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("UPDATE category SET Category_Name = '" & txtCategoryName.Text & "', Description= '" & txtCategoryDescription.Text & "' WHERE Category_ID = '" & txtCategoryID.Text & "' ", conn)

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


    Private Sub btnDeleteCategory_Click(sender As Object, e As EventArgs) Handles btnDeleteCategory.Click
        Dim answer As MsgBoxResult = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.No Then Return

        Call Connect_to_Db()
        Dim mycmd As New MySqlCommand("Delete from category where Category_ID = '" & txtCategoryID.Text & "'", conn)

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
            .txtCategoryID.Text = ""
            .txtCategoryName.Text = ""
            .txtCategoryDescription.Text = ""
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()

        Dim table As New DataTable()
        Dim command As New MySqlCommand
        Dim dt As New DataTable()

        command.Connection = conn
        command.CommandText = "SELECT * FROM shopping_db.category"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim Category_ID = reader.GetString(0)
            Dim Category_Name = reader.GetString(1)
            Dim Description = reader.GetString(2)
            DataGridView1.Rows.Add(Category_ID, Category_Name, Description)

        End While

        Call Disconnect_to_Db()
    End Sub
End Class