
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text

Module export_module
    Sub export_to_csv(tableName As String)
        Dim connectionString As String = "Server=localhost;
        Database=shopping_db;
        Uid=root;
        Pwd=arjie;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM " + tableName
                Dim command As New MySqlCommand(query, connection)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
                saveFileDialog.Title = "Export table as CSV"
                saveFileDialog.ShowDialog()

                If saveFileDialog.FileName <> "" Then
                    Dim csvContent As New StringBuilder()
                    For i As Integer = 0 To reader.FieldCount - 1
                        csvContent.Append(reader.GetName(i))
                        If i < reader.FieldCount - 1 Then
                            csvContent.Append(",")
                        End If
                    Next
                    csvContent.AppendLine()

                    While reader.Read()
                        For i As Integer = 0 To reader.FieldCount - 1
                            If Not reader.IsDBNull(i) Then
                                csvContent.Append(reader(i).ToString())
                            End If
                            If i < reader.FieldCount - 1 Then
                                csvContent.Append(",")
                            End If
                        Next
                        csvContent.AppendLine()
                    End While

                    Using writer As New StreamWriter(saveFileDialog.FileName)
                        writer.Write(csvContent.ToString())
                    End Using

                    MessageBox.Show("Export Succesful!")
                End If

                reader.Close()
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error Exporting Data: " + ex.Message)
        End Try
    End Sub

End Module