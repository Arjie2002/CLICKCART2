<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Details
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Order_Details))
        OrderDetails = New PictureBox()
        btnRefresh = New Button()
        btnMenu = New Button()
        btnEditOrderDetails = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Odetails_ID = New DataGridViewTextBoxColumn()
        Odetails_ProdID = New DataGridViewTextBoxColumn()
        Odetails_Price = New DataGridViewTextBoxColumn()
        Odetails_Quantity = New DataGridViewTextBoxColumn()
        txtOdetailsOrderID = New TextBox()
        txtOdetailsProductID = New TextBox()
        txtOdetailsPrice = New TextBox()
        txtOdetailsQuantity = New TextBox()
        CType(OrderDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OrderDetails
        ' 
        OrderDetails.Image = CType(resources.GetObject("OrderDetails.Image"), Image)
        OrderDetails.Location = New Point(-1, -4)
        OrderDetails.Name = "OrderDetails"
        OrderDetails.Size = New Size(1269, 619)
        OrderDetails.SizeMode = PictureBoxSizeMode.StretchImage
        OrderDetails.TabIndex = 0
        OrderDetails.TabStop = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(663, 60)
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
        btnMenu.Location = New Point(994, 58)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(212, 53)
        btnMenu.TabIndex = 5
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnEditOrderDetails
        ' 
        btnEditOrderDetails.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnEditOrderDetails.FlatAppearance.BorderSize = 0
        btnEditOrderDetails.FlatStyle = FlatStyle.Flat
        btnEditOrderDetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditOrderDetails.Location = New Point(894, 403)
        btnEditOrderDetails.Name = "btnEditOrderDetails"
        btnEditOrderDetails.Size = New Size(312, 44)
        btnEditOrderDetails.TabIndex = 6
        btnEditOrderDetails.Text = "Edit Order Details"
        btnEditOrderDetails.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(74), CByte(89), CByte(149))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(894, 453)
        Button1.Name = "Button1"
        Button1.Size = New Size(312, 102)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Odetails_ID, Odetails_ProdID, Odetails_Price, Odetails_Quantity})
        DataGridView1.Location = New Point(62, 140)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(810, 415)
        DataGridView1.TabIndex = 8
        ' 
        ' Odetails_ID
        ' 
        Odetails_ID.HeaderText = "OrderDetails_ID"
        Odetails_ID.MinimumWidth = 6
        Odetails_ID.Name = "Odetails_ID"
        Odetails_ID.Width = 175
        ' 
        ' Odetails_ProdID
        ' 
        Odetails_ProdID.HeaderText = "OrdDetails_ProdID"
        Odetails_ProdID.MinimumWidth = 6
        Odetails_ProdID.Name = "Odetails_ProdID"
        Odetails_ProdID.Width = 175
        ' 
        ' Odetails_Price
        ' 
        Odetails_Price.HeaderText = "Price"
        Odetails_Price.MinimumWidth = 6
        Odetails_Price.Name = "Odetails_Price"
        Odetails_Price.Width = 175
        ' 
        ' Odetails_Quantity
        ' 
        Odetails_Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Odetails_Quantity.HeaderText = "Quantity"
        Odetails_Quantity.MinimumWidth = 6
        Odetails_Quantity.Name = "Odetails_Quantity"
        ' 
        ' txtOdetailsOrderID
        ' 
        txtOdetailsOrderID.Location = New Point(911, 172)
        txtOdetailsOrderID.Multiline = True
        txtOdetailsOrderID.Name = "txtOdetailsOrderID"
        txtOdetailsOrderID.Size = New Size(280, 30)
        txtOdetailsOrderID.TabIndex = 9
        ' 
        ' txtOdetailsProductID
        ' 
        txtOdetailsProductID.Location = New Point(911, 230)
        txtOdetailsProductID.Multiline = True
        txtOdetailsProductID.Name = "txtOdetailsProductID"
        txtOdetailsProductID.Size = New Size(280, 30)
        txtOdetailsProductID.TabIndex = 10
        ' 
        ' txtOdetailsPrice
        ' 
        txtOdetailsPrice.Location = New Point(911, 290)
        txtOdetailsPrice.Multiline = True
        txtOdetailsPrice.Name = "txtOdetailsPrice"
        txtOdetailsPrice.Size = New Size(280, 30)
        txtOdetailsPrice.TabIndex = 11
        ' 
        ' txtOdetailsQuantity
        ' 
        txtOdetailsQuantity.Location = New Point(911, 349)
        txtOdetailsQuantity.Multiline = True
        txtOdetailsQuantity.Name = "txtOdetailsQuantity"
        txtOdetailsQuantity.Size = New Size(280, 30)
        txtOdetailsQuantity.TabIndex = 12
        ' 
        ' Order_Details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(txtOdetailsQuantity)
        Controls.Add(txtOdetailsPrice)
        Controls.Add(txtOdetailsProductID)
        Controls.Add(txtOdetailsOrderID)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(btnEditOrderDetails)
        Controls.Add(btnMenu)
        Controls.Add(btnRefresh)
        Controls.Add(OrderDetails)
        MaximizeBox = False
        Name = "Order_Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order_Details"
        CType(OrderDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OrderDetails As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnEditOrderDetails As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtOdetailsOrderID As TextBox
    Friend WithEvents txtOdetailsProductID As TextBox
    Friend WithEvents txtOdetailsPrice As TextBox
    Friend WithEvents txtOdetailsQuantity As TextBox
    Friend WithEvents Odetails_ID As DataGridViewTextBoxColumn
    Friend WithEvents Odetails_ProdID As DataGridViewTextBoxColumn
    Friend WithEvents Odetails_Price As DataGridViewTextBoxColumn
    Friend WithEvents Odetails_Quantity As DataGridViewTextBoxColumn
End Class
