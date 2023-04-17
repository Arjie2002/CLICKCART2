<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Orders))
        PictureBox1 = New PictureBox()
        btnRefresh = New Button()
        btnMenu = New Button()
        btnInserOrder = New Button()
        btnUpdateOrder = New Button()
        btnDeleteOrder = New Button()
        DataGridView1 = New DataGridView()
        Ord_ID = New DataGridViewTextBoxColumn()
        Ord_Name = New DataGridViewTextBoxColumn()
        Ord_Date = New DataGridViewTextBoxColumn()
        Ord_TotalAmount = New DataGridViewTextBoxColumn()
        Cust_ID = New DataGridViewTextBoxColumn()
        txtOrderID = New TextBox()
        txtOrderName = New TextBox()
        txtOrderDate = New TextBox()
        txtOrderAmount = New TextBox()
        txtOrderCustID = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, -4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1268, 619)
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
        btnRefresh.Location = New Point(661, 60)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(209, 53)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "🔄️Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnMenu
        ' 
        btnMenu.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnMenu.Location = New Point(992, 59)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(212, 53)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnInserOrder
        ' 
        btnInserOrder.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnInserOrder.FlatAppearance.BorderSize = 0
        btnInserOrder.FlatStyle = FlatStyle.Flat
        btnInserOrder.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInserOrder.Location = New Point(892, 444)
        btnInserOrder.Name = "btnInserOrder"
        btnInserOrder.Size = New Size(312, 44)
        btnInserOrder.TabIndex = 5
        btnInserOrder.Text = "Insert Order"
        btnInserOrder.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateOrder
        ' 
        btnUpdateOrder.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnUpdateOrder.FlatAppearance.BorderSize = 0
        btnUpdateOrder.FlatStyle = FlatStyle.Flat
        btnUpdateOrder.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateOrder.Location = New Point(892, 500)
        btnUpdateOrder.Name = "btnUpdateOrder"
        btnUpdateOrder.Size = New Size(312, 44)
        btnUpdateOrder.TabIndex = 6
        btnUpdateOrder.Text = "Update Order"
        btnUpdateOrder.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteOrder
        ' 
        btnDeleteOrder.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDeleteOrder.FlatAppearance.BorderSize = 0
        btnDeleteOrder.FlatStyle = FlatStyle.Flat
        btnDeleteOrder.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteOrder.Location = New Point(892, 553)
        btnDeleteOrder.Name = "btnDeleteOrder"
        btnDeleteOrder.Size = New Size(312, 44)
        btnDeleteOrder.TabIndex = 7
        btnDeleteOrder.Text = "Delete Order"
        btnDeleteOrder.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Ord_ID, Ord_Name, Ord_Date, Ord_TotalAmount, Cust_ID})
        DataGridView1.Location = New Point(61, 139)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(810, 415)
        DataGridView1.TabIndex = 9
        ' 
        ' Ord_ID
        ' 
        Ord_ID.HeaderText = "Order_ID"
        Ord_ID.MinimumWidth = 6
        Ord_ID.Name = "Ord_ID"
        Ord_ID.Width = 125
        ' 
        ' Ord_Name
        ' 
        Ord_Name.HeaderText = "Order Name"
        Ord_Name.MinimumWidth = 6
        Ord_Name.Name = "Ord_Name"
        Ord_Name.Width = 250
        ' 
        ' Ord_Date
        ' 
        Ord_Date.HeaderText = "Order_Date"
        Ord_Date.MinimumWidth = 6
        Ord_Date.Name = "Ord_Date"
        Ord_Date.Width = 150
        ' 
        ' Ord_TotalAmount
        ' 
        Ord_TotalAmount.HeaderText = "Total_Amount"
        Ord_TotalAmount.MinimumWidth = 6
        Ord_TotalAmount.Name = "Ord_TotalAmount"
        Ord_TotalAmount.Width = 125
        ' 
        ' Cust_ID
        ' 
        Cust_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Cust_ID.HeaderText = "Customer_ID"
        Cust_ID.MinimumWidth = 6
        Cust_ID.Name = "Cust_ID"
        ' 
        ' txtOrderID
        ' 
        txtOrderID.Location = New Point(908, 165)
        txtOrderID.Multiline = True
        txtOrderID.Name = "txtOrderID"
        txtOrderID.Size = New Size(280, 30)
        txtOrderID.TabIndex = 12
        ' 
        ' txtOrderName
        ' 
        txtOrderName.Location = New Point(908, 225)
        txtOrderName.Multiline = True
        txtOrderName.Name = "txtOrderName"
        txtOrderName.Size = New Size(280, 30)
        txtOrderName.TabIndex = 13
        ' 
        ' txtOrderDate
        ' 
        txtOrderDate.Location = New Point(908, 285)
        txtOrderDate.Multiline = True
        txtOrderDate.Name = "txtOrderDate"
        txtOrderDate.Size = New Size(280, 30)
        txtOrderDate.TabIndex = 14
        ' 
        ' txtOrderAmount
        ' 
        txtOrderAmount.Location = New Point(908, 342)
        txtOrderAmount.Multiline = True
        txtOrderAmount.Name = "txtOrderAmount"
        txtOrderAmount.Size = New Size(280, 30)
        txtOrderAmount.TabIndex = 15
        ' 
        ' txtOrderCustID
        ' 
        txtOrderCustID.Location = New Point(908, 398)
        txtOrderCustID.Multiline = True
        txtOrderCustID.Name = "txtOrderCustID"
        txtOrderCustID.Size = New Size(280, 30)
        txtOrderCustID.TabIndex = 16
        ' 
        ' Orders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(txtOrderCustID)
        Controls.Add(txtOrderAmount)
        Controls.Add(txtOrderDate)
        Controls.Add(txtOrderName)
        Controls.Add(txtOrderID)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteOrder)
        Controls.Add(btnUpdateOrder)
        Controls.Add(btnInserOrder)
        Controls.Add(btnMenu)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        MinimizeBox = False
        Name = "Orders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Orders"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnInserOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents btnDeleteOrder As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtOrderName As TextBox
    Friend WithEvents txtOrderDate As TextBox
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents Ord_ID As DataGridViewTextBoxColumn
    Friend WithEvents Ord_Name As DataGridViewTextBoxColumn
    Friend WithEvents Ord_Date As DataGridViewTextBoxColumn
    Friend WithEvents Ord_TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents Cust_ID As DataGridViewTextBoxColumn
    Friend WithEvents txtOrderCustID As TextBox
End Class
