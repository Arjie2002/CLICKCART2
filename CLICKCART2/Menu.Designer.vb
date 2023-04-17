<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Menu))
        PictureBox1 = New PictureBox()
        btnCustomers = New Button()
        btnOrders = New Button()
        btnOrderDetails = New Button()
        btnCategories = New Button()
        btnProducts = New Button()
        btnBackUp = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1271, 614)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnCustomers.Location = New Point(110, 234)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(205, 64)
        btnCustomers.TabIndex = 2
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnOrders
        ' 
        btnOrders.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnOrders.Location = New Point(347, 234)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(205, 64)
        btnOrders.TabIndex = 3
        btnOrders.Text = "Orders"
        btnOrders.UseVisualStyleBackColor = True
        ' 
        ' btnOrderDetails
        ' 
        btnOrderDetails.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnOrderDetails.Location = New Point(228, 324)
        btnOrderDetails.Name = "btnOrderDetails"
        btnOrderDetails.Size = New Size(205, 64)
        btnOrderDetails.TabIndex = 4
        btnOrderDetails.Text = "Order Details"
        btnOrderDetails.UseVisualStyleBackColor = True
        ' 
        ' btnCategories
        ' 
        btnCategories.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnCategories.Location = New Point(347, 415)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(205, 64)
        btnCategories.TabIndex = 5
        btnCategories.Text = "Categories"
        btnCategories.UseVisualStyleBackColor = True
        ' 
        ' btnProducts
        ' 
        btnProducts.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnProducts.Location = New Point(110, 415)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(205, 64)
        btnProducts.TabIndex = 6
        btnProducts.Text = "Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnBackUp
        ' 
        btnBackUp.BackColor = SystemColors.ActiveCaption
        btnBackUp.FlatAppearance.BorderSize = 0
        btnBackUp.FlatStyle = FlatStyle.Flat
        btnBackUp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBackUp.Location = New Point(974, 476)
        btnBackUp.Name = "btnBackUp"
        btnBackUp.Size = New Size(205, 64)
        btnBackUp.TabIndex = 7
        btnBackUp.Text = "Backup Database"
        btnBackUp.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(btnBackUp)
        Controls.Add(btnProducts)
        Controls.Add(btnCategories)
        Controls.Add(btnOrderDetails)
        Controls.Add(btnOrders)
        Controls.Add(btnCustomers)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnOrderDetails As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnBackUp As Button
End Class
