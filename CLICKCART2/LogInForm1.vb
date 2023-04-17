Imports MySql.Data.MySqlClient
Public Class LogInForm1
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from accounts where username = '" _
                & .txtUsername.Text & "' and password = md5('" _
                & .txtPassword.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = conn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                Menu.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_Db()
        End With

    End Sub

End Class
