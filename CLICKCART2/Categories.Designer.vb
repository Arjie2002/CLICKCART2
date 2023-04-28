<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Categories))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnRefresh = New Button()
        btnMenu = New Button()
        btnInsertCategory = New Button()
        btnUpdateCategory = New Button()
        btnDeleteCategory = New Button()
        DataGridView1 = New DataGridView()
        Categ_ID = New DataGridViewTextBoxColumn()
        Categ_Name = New DataGridViewTextBoxColumn()
        Categ_Description = New DataGridViewTextBoxColumn()
        txtCategoryID = New TextBox()
        txtCategoryName = New TextBox()
        txtCategoryDescription = New TextBox()
        btnExport = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1269, 619)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(499, 77)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(0, 0)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(664, 65)
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
        btnMenu.Location = New Point(995, 62)
        btnMenu.Name = "btnMenu"
        btnMenu.Size = New Size(212, 53)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Back to Menu"
        btnMenu.UseVisualStyleBackColor = False
        ' 
        ' btnInsertCategory
        ' 
        btnInsertCategory.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnInsertCategory.FlatAppearance.BorderSize = 0
        btnInsertCategory.FlatStyle = FlatStyle.Flat
        btnInsertCategory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnInsertCategory.Location = New Point(895, 406)
        btnInsertCategory.Name = "btnInsertCategory"
        btnInsertCategory.Size = New Size(312, 44)
        btnInsertCategory.TabIndex = 5
        btnInsertCategory.Text = "Insert Category"
        btnInsertCategory.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCategory
        ' 
        btnUpdateCategory.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnUpdateCategory.FlatAppearance.BorderSize = 0
        btnUpdateCategory.FlatStyle = FlatStyle.Flat
        btnUpdateCategory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdateCategory.Location = New Point(895, 460)
        btnUpdateCategory.Name = "btnUpdateCategory"
        btnUpdateCategory.Size = New Size(312, 44)
        btnUpdateCategory.TabIndex = 6
        btnUpdateCategory.Text = "Update Category"
        btnUpdateCategory.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteCategory
        ' 
        btnDeleteCategory.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnDeleteCategory.FlatAppearance.BorderSize = 0
        btnDeleteCategory.FlatStyle = FlatStyle.Flat
        btnDeleteCategory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteCategory.Location = New Point(895, 516)
        btnDeleteCategory.Name = "btnDeleteCategory"
        btnDeleteCategory.Size = New Size(312, 44)
        btnDeleteCategory.TabIndex = 7
        btnDeleteCategory.Text = "Delete Category"
        btnDeleteCategory.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Categ_ID, Categ_Name, Categ_Description})
        DataGridView1.Location = New Point(63, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(810, 415)
        DataGridView1.TabIndex = 9
        ' 
        ' Categ_ID
        ' 
        Categ_ID.HeaderText = "Category_ID"
        Categ_ID.MinimumWidth = 6
        Categ_ID.Name = "Categ_ID"
        Categ_ID.Width = 125
        ' 
        ' Categ_Name
        ' 
        Categ_Name.HeaderText = "Category_Name"
        Categ_Name.MinimumWidth = 6
        Categ_Name.Name = "Categ_Name"
        Categ_Name.Width = 250
        ' 
        ' Categ_Description
        ' 
        Categ_Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Categ_Description.HeaderText = "Description"
        Categ_Description.MinimumWidth = 6
        Categ_Description.Name = "Categ_Description"
        ' 
        ' txtCategoryID
        ' 
        txtCategoryID.Location = New Point(912, 174)
        txtCategoryID.Multiline = True
        txtCategoryID.Name = "txtCategoryID"
        txtCategoryID.Size = New Size(280, 30)
        txtCategoryID.TabIndex = 10
        ' 
        ' txtCategoryName
        ' 
        txtCategoryName.Location = New Point(912, 235)
        txtCategoryName.Multiline = True
        txtCategoryName.Name = "txtCategoryName"
        txtCategoryName.Size = New Size(280, 30)
        txtCategoryName.TabIndex = 11
        ' 
        ' txtCategoryDescription
        ' 
        txtCategoryDescription.Location = New Point(912, 294)
        txtCategoryDescription.Multiline = True
        txtCategoryDescription.Name = "txtCategoryDescription"
        txtCategoryDescription.Size = New Size(280, 81)
        txtCategoryDescription.TabIndex = 12
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnExport.Location = New Point(63, 566)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(114, 35)
        btnExport.TabIndex = 20
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 611)
        Controls.Add(btnExport)
        Controls.Add(txtCategoryDescription)
        Controls.Add(txtCategoryName)
        Controls.Add(txtCategoryID)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteCategory)
        Controls.Add(btnUpdateCategory)
        Controls.Add(btnInsertCategory)
        Controls.Add(btnMenu)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        Name = "Categories"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Categories"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnInsertCategory As Button
    Friend WithEvents btnUpdateCategory As Button
    Friend WithEvents btnDeleteCategory As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents txtCategoryDescription As TextBox
    Friend WithEvents Categ_ID As DataGridViewTextBoxColumn
    Friend WithEvents Categ_Name As DataGridViewTextBoxColumn
    Friend WithEvents Categ_Description As DataGridViewTextBoxColumn
    Friend WithEvents btnExport As Button
End Class
