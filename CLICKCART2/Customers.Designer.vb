<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Customers))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Customer_ID = New DataGridViewTextBoxColumn()
        Customer_FirstName = New DataGridViewTextBoxColumn()
        Customer_LastName = New DataGridViewTextBoxColumn()
        Customer_PhoneNumber = New DataGridViewTextBoxColumn()
        btnRefresh = New Button()
        btnMenu = New Button()
        btnInserCustomer = New Button()
        btnUpdateCustomer = New Button()
        btnDeleteCustomer = New Button()
        txtCustomerID = New TextBox()
        txtCustomerFName = New TextBox()
        txtCustomerLName = New TextBox()
        txtCustomerPhoneNumber = New TextBox()
        btnBrowse = New Button()
        Label1 = New Label()
        btnExport = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1269, 619)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Customer_ID, Customer_FirstName, Customer_LastName, Customer_PhoneNumber})
        DataGridView1.Location = New Point(60, 146)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(811, 412)
        DataGridView1.TabIndex = 1
        ' 
        ' Customer_ID
        ' 
        Customer_ID.HeaderText = "Cust_ID"
        Customer_ID.MinimumWidth = 6
        Customer_ID.Name = "Customer_ID"
        Customer_ID.Width = 125
        ' 
        ' Customer_FirstName
        ' 
        Customer_FirstName.HeaderText = "Cust_FirstName"
        Customer_FirstName.MinimumWidth = 6
        Customer_FirstName.Name = "Customer_FirstName"
        Customer_FirstName.Width = 225
        ' 
        ' Customer_LastName
        ' 
        Customer_LastName.HeaderText = "Cust_LastName"
        Customer_LastName.MinimumWidth = 6
        Customer_LastName.Name = "Customer_LastName"
        Customer_LastName.Width = 225
        ' 
        ' Customer_PhoneNumber
        ' 
        Customer_PhoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Customer_PhoneNumber.HeaderText = "Phone_Number"
        Customer_PhoneNumber.MinimumWidth = 6
        Customer_PhoneNumber.Name = "Customer_PhoneNumber"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(662, 62)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(209, 53)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "🔄️Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMenu.Location = New Point(993, 62)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(212, 53)
        btnMenu.TabIndex = 3
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnInserCustomer
        ' 
        btnInserCustomer.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnInserCustomer.FlatAppearance.BorderSize = 0
        btnInserCustomer.FlatStyle = FlatStyle.Flat
        btnInserCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInserCustomer.Location = New Point(893, 406)
        btnInserCustomer.Name = "btnInserCustomer"
        btnInserCustomer.Size = New Size(312, 44)
        btnInserCustomer.TabIndex = 4
        btnInserCustomer.Text = "Insert Customer"
        btnInserCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCustomer
        ' 
        btnUpdateCustomer.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnUpdateCustomer.FlatAppearance.BorderSize = 0
        btnUpdateCustomer.FlatStyle = FlatStyle.Flat
        btnUpdateCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateCustomer.Location = New Point(893, 459)
        btnUpdateCustomer.Name = "btnUpdateCustomer"
        btnUpdateCustomer.Size = New Size(312, 44)
        btnUpdateCustomer.TabIndex = 5
        btnUpdateCustomer.Text = "Update Customer"
        btnUpdateCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCustomer
        ' 
        btnDeleteCustomer.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDeleteCustomer.FlatAppearance.BorderSize = 0
        btnDeleteCustomer.FlatStyle = FlatStyle.Flat
        btnDeleteCustomer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteCustomer.Location = New Point(893, 514)
        btnDeleteCustomer.Name = "btnDeleteCustomer"
        btnDeleteCustomer.Size = New Size(312, 44)
        btnDeleteCustomer.TabIndex = 6
        btnDeleteCustomer.Text = "Delete Customer"
        btnDeleteCustomer.UseVisualStyleBackColor = False
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(908, 172)
        txtCustomerID.Multiline = True
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(280, 30)
        txtCustomerID.TabIndex = 11
        ' 
        ' txtCustomerFName
        ' 
        txtCustomerFName.Location = New Point(908, 231)
        txtCustomerFName.Multiline = True
        txtCustomerFName.Name = "txtCustomerFName"
        txtCustomerFName.Size = New Size(280, 30)
        txtCustomerFName.TabIndex = 12
        ' 
        ' txtCustomerLName
        ' 
        txtCustomerLName.Location = New Point(908, 290)
        txtCustomerLName.Multiline = True
        txtCustomerLName.Name = "txtCustomerLName"
        txtCustomerLName.Size = New Size(280, 30)
        txtCustomerLName.TabIndex = 13
        ' 
        ' txtCustomerPhoneNumber
        ' 
        txtCustomerPhoneNumber.Location = New Point(908, 350)
        txtCustomerPhoneNumber.Multiline = True
        txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber"
        txtCustomerPhoneNumber.Size = New Size(280, 30)
        txtCustomerPhoneNumber.TabIndex = 14
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBrowse.Location = New Point(434, 62)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(209, 53)
        btnBrowse.TabIndex = 15
        btnBrowse.Text = "Browse .csv"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(287, 564)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 17
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(60, 561)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(114, 35)
        btnExport.TabIndex = 19
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' Customers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(btnExport)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(txtCustomerPhoneNumber)
        Controls.Add(txtCustomerLName)
        Controls.Add(txtCustomerFName)
        Controls.Add(txtCustomerID)
        Controls.Add(btnDeleteCustomer)
        Controls.Add(btnUpdateCustomer)
        Controls.Add(btnInserCustomer)
        Controls.Add(btnMenu)
        Controls.Add(btnRefresh)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        MinimizeBox = False
        Name = "Customers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customers"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnInserCustomer As Button
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtCustomerFName As TextBox
    Friend WithEvents txtCustomerLName As TextBox
    Friend WithEvents txtCustomerPhoneNumber As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents Customer_FirstName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_LastName As DataGridViewTextBoxColumn
    Friend WithEvents Customer_PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExport As Button
End Class
