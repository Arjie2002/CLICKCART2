Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Menu
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Customers.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrderDetails_Click(sender As Object, e As EventArgs) Handles btnOrderDetails.Click
        Order_Details.Show()
        Me.Hide()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Products.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        Categories.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog() = DialogResult.OK Then
            Dim cmd = $"mysqldump -h localhost -u root -parjie shopping_db > ""{backup.FileName}"""
            Dim batchFilePath As String = "C:\Users\acer\Desktop\EDP\backupfunction.bat"

            Using writer As New StreamWriter(batchFilePath)
                writer.WriteLine(cmd)
            End Using

            Dim backupDatabase = Shell(batchFilePath)

            MessageBox.Show(If(backupDatabase, "Your database is successfully backup!", "Your database is not successfully backup!"))
        End If

    End Sub
End Class