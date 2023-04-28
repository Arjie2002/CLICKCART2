<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Products))
        PictureBox1 = New PictureBox()
        btnRefresh = New Button()
        btnMenu = New Button()
        btnInserProduct = New Button()
        btnUpdateProduct = New Button()
        btnDeleteProduct = New Button()
        DataGridView1 = New DataGridView()
        Prod_ID = New DataGridViewTextBoxColumn()
        Prod_Name = New DataGridViewTextBoxColumn()
        Prod_Price = New DataGridViewTextBoxColumn()
        Prod_Quantity = New DataGridViewTextBoxColumn()
        Prod_CategID = New DataGridViewTextBoxColumn()
        txtProductID = New TextBox()
        txtProductName = New TextBox()
        txtProductPrice = New TextBox()
        txtProductCategoryID = New TextBox()
        txtProductQuantity = New TextBox()
        btnExport = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1270, 614)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(665, 60)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(209, 53)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "🔄️Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMenu.Location = New Point(996, 57)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(212, 53)
        btnMenu.TabIndex = 5
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnInserProduct
        ' 
        btnInserProduct.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnInserProduct.FlatAppearance.BorderSize = 0
        btnInserProduct.FlatStyle = FlatStyle.Flat
        btnInserProduct.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInserProduct.Location = New Point(895, 443)
        btnInserProduct.Name = "btnInserProduct"
        btnInserProduct.Size = New Size(312, 44)
        btnInserProduct.TabIndex = 6
        btnInserProduct.Text = "Insert Product"
        btnInserProduct.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateProduct
        ' 
        btnUpdateProduct.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnUpdateProduct.FlatAppearance.BorderSize = 0
        btnUpdateProduct.FlatStyle = FlatStyle.Flat
        btnUpdateProduct.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateProduct.Location = New Point(895, 497)
        btnUpdateProduct.Name = "btnUpdateProduct"
        btnUpdateProduct.Size = New Size(312, 44)
        btnUpdateProduct.TabIndex = 7
        btnUpdateProduct.Text = "Update Product"
        btnUpdateProduct.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteProduct
        ' 
        btnDeleteProduct.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDeleteProduct.FlatAppearance.BorderSize = 0
        btnDeleteProduct.FlatStyle = FlatStyle.Flat
        btnDeleteProduct.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteProduct.Location = New Point(895, 550)
        btnDeleteProduct.Name = "btnDeleteProduct"
        btnDeleteProduct.Size = New Size(312, 44)
        btnDeleteProduct.TabIndex = 8
        btnDeleteProduct.Text = "Delete Product"
        btnDeleteProduct.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Prod_ID, Prod_Name, Prod_Price, Prod_Quantity, Prod_CategID})
        DataGridView1.Location = New Point(61, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(813, 410)
        DataGridView1.TabIndex = 9
        ' 
        ' Prod_ID
        ' 
        Prod_ID.HeaderText = "Product_ID"
        Prod_ID.MinimumWidth = 6
        Prod_ID.Name = "Prod_ID"
        Prod_ID.Width = 125
        ' 
        ' Prod_Name
        ' 
        Prod_Name.HeaderText = "Product_Name"
        Prod_Name.MinimumWidth = 6
        Prod_Name.Name = "Prod_Name"
        Prod_Name.Width = 250
        ' 
        ' Prod_Price
        ' 
        Prod_Price.HeaderText = "Price"
        Prod_Price.MinimumWidth = 6
        Prod_Price.Name = "Prod_Price"
        Prod_Price.Width = 125
        ' 
        ' Prod_Quantity
        ' 
        Prod_Quantity.HeaderText = "Quantity"
        Prod_Quantity.MinimumWidth = 6
        Prod_Quantity.Name = "Prod_Quantity"
        Prod_Quantity.Width = 125
        ' 
        ' Prod_CategID
        ' 
        Prod_CategID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Prod_CategID.HeaderText = "Categ_ID"
        Prod_CategID.MinimumWidth = 6
        Prod_CategID.Name = "Prod_CategID"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(910, 166)
        txtProductID.Multiline = True
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(280, 30)
        txtProductID.TabIndex = 12
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(910, 224)
        txtProductName.Multiline = True
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(280, 30)
        txtProductName.TabIndex = 13
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.Location = New Point(910, 283)
        txtProductPrice.Multiline = True
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(280, 30)
        txtProductPrice.TabIndex = 14
        ' 
        ' txtProductCategoryID
        ' 
        txtProductCategoryID.Location = New Point(910, 394)
        txtProductCategoryID.Multiline = True
        txtProductCategoryID.Name = "txtProductCategoryID"
        txtProductCategoryID.Size = New Size(280, 30)
        txtProductCategoryID.TabIndex = 15
        ' 
        ' txtProductQuantity
        ' 
        txtProductQuantity.Location = New Point(910, 342)
        txtProductQuantity.Multiline = True
        txtProductQuantity.Name = "txtProductQuantity"
        txtProductQuantity.Size = New Size(280, 30)
        txtProductQuantity.TabIndex = 16
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(61, 559)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(114, 35)
        btnExport.TabIndex = 20
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' Products
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(btnExport)
        Controls.Add(txtProductQuantity)
        Controls.Add(txtProductCategoryID)
        Controls.Add(txtProductPrice)
        Controls.Add(txtProductName)
        Controls.Add(txtProductID)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteProduct)
        Controls.Add(btnUpdateProduct)
        Controls.Add(btnInserProduct)
        Controls.Add(btnMenu)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "Products"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Products"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnInserProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents txtProductCategoryID As TextBox
    Friend WithEvents Prod_ID As DataGridViewTextBoxColumn
    Friend WithEvents Prod_Name As DataGridViewTextBoxColumn
    Friend WithEvents Prod_Price As DataGridViewTextBoxColumn
    Friend WithEvents Prod_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Prod_CategID As DataGridViewTextBoxColumn
    Friend WithEvents txtProductQuantity As TextBox
    Friend WithEvents btnExport As Button
End Class
