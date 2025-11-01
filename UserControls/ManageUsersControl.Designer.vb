<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsersControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageUsersControl))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        dgdvUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        Panel1 = New Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        gbCreate = New Guna.UI2.WinForms.Guna2Button()
        gbEdit = New Guna.UI2.WinForms.Guna2Button()
        gbRemove = New Guna.UI2.WinForms.Guna2Button()
        Panel3 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        gtbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgdvUsers, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 70F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(855, 604)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgdvUsers)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 70)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(855, 534)
        Panel2.TabIndex = 1
        ' 
        ' dgdvUsers
        ' 
        dgdvUsers.AllowUserToAddRows = False
        dgdvUsers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgdvUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgdvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgdvUsers.ColumnHeadersHeight = 4
        dgdvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgdvUsers.DefaultCellStyle = DataGridViewCellStyle3
        dgdvUsers.Dock = DockStyle.Fill
        dgdvUsers.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgdvUsers.Location = New Point(0, 0)
        dgdvUsers.Margin = New Padding(0)
        dgdvUsers.Name = "dgdvUsers"
        dgdvUsers.ReadOnly = True
        dgdvUsers.RowHeadersVisible = False
        dgdvUsers.Size = New Size(855, 534)
        dgdvUsers.TabIndex = 0
        dgdvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgdvUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgdvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgdvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgdvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgdvUsers.ThemeStyle.BackColor = Color.White
        dgdvUsers.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgdvUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgdvUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgdvUsers.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgdvUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgdvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgdvUsers.ThemeStyle.HeaderStyle.Height = 4
        dgdvUsers.ThemeStyle.ReadOnly = True
        dgdvUsers.ThemeStyle.RowsStyle.BackColor = Color.White
        dgdvUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgdvUsers.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgdvUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgdvUsers.ThemeStyle.RowsStyle.Height = 25
        dgdvUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgdvUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Guna2Panel1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 20, 0, 5)
        Panel1.Size = New Size(855, 70)
        Panel1.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(TableLayoutPanel2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 20)
        Guna2Panel1.Margin = New Padding(0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 0
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.ShadowDecoration.Enabled = True
        Guna2Panel1.ShadowDecoration.Shadow = New Padding(2)
        Guna2Panel1.Size = New Size(855, 45)
        Guna2Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(Panel3, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(855, 45)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(gbCreate)
        FlowLayoutPanel1.Controls.Add(gbEdit)
        FlowLayoutPanel1.Controls.Add(gbRemove)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Margin = New Padding(0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(0, 0, 0, 10)
        FlowLayoutPanel1.Size = New Size(427, 45)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' gbCreate
        ' 
        gbCreate.BorderRadius = 16
        gbCreate.CustomizableEdges = CustomizableEdges1
        gbCreate.DisabledState.BorderColor = Color.DarkGray
        gbCreate.DisabledState.CustomBorderColor = Color.DarkGray
        gbCreate.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        gbCreate.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        gbCreate.FillColor = Color.MediumSeaGreen
        gbCreate.Font = New Font("Poppins", 11.25F)
        gbCreate.ForeColor = Color.White
        gbCreate.Image = CType(resources.GetObject("gbCreate.Image"), Image)
        gbCreate.Location = New Point(3, 3)
        gbCreate.Name = "gbCreate"
        gbCreate.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        gbCreate.Size = New Size(135, 39)
        gbCreate.TabIndex = 0
        gbCreate.Text = "Create"
        gbCreate.TextOffset = New Point(0, 2)
        ' 
        ' gbEdit
        ' 
        gbEdit.BorderRadius = 16
        gbEdit.CustomizableEdges = CustomizableEdges3
        gbEdit.DisabledState.BorderColor = Color.DarkGray
        gbEdit.DisabledState.CustomBorderColor = Color.DarkGray
        gbEdit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        gbEdit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        gbEdit.FillColor = Color.DodgerBlue
        gbEdit.Font = New Font("Poppins", 11.25F)
        gbEdit.ForeColor = Color.White
        gbEdit.Image = CType(resources.GetObject("gbEdit.Image"), Image)
        gbEdit.Location = New Point(144, 3)
        gbEdit.Name = "gbEdit"
        gbEdit.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        gbEdit.Size = New Size(135, 39)
        gbEdit.TabIndex = 1
        gbEdit.Text = "Edit"
        gbEdit.TextOffset = New Point(0, 2)
        ' 
        ' gbRemove
        ' 
        gbRemove.BorderRadius = 16
        gbRemove.CustomizableEdges = CustomizableEdges5
        gbRemove.DisabledState.BorderColor = Color.DarkGray
        gbRemove.DisabledState.CustomBorderColor = Color.DarkGray
        gbRemove.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        gbRemove.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        gbRemove.FillColor = Color.IndianRed
        gbRemove.Font = New Font("Poppins", 11.25F)
        gbRemove.ForeColor = Color.White
        gbRemove.Image = CType(resources.GetObject("gbRemove.Image"), Image)
        gbRemove.Location = New Point(285, 3)
        gbRemove.Name = "gbRemove"
        gbRemove.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        gbRemove.Size = New Size(135, 39)
        gbRemove.TabIndex = 2
        gbRemove.Text = "Remove"
        gbRemove.TextOffset = New Point(0, 2)
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TableLayoutPanel3)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(427, 0)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(428, 45)
        Panel3.TabIndex = 1
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 250F))
        TableLayoutPanel3.Controls.Add(gtbSearch, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Size = New Size(428, 45)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' gtbSearch
        ' 
        gtbSearch.CustomizableEdges = CustomizableEdges7
        gtbSearch.DefaultText = ""
        gtbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        gtbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        gtbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbSearch.Dock = DockStyle.Fill
        gtbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbSearch.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gtbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbSearch.IconLeft = CType(resources.GetObject("gtbSearch.IconLeft"), Image)
        gtbSearch.Location = New Point(182, 6)
        gtbSearch.Margin = New Padding(4, 6, 4, 6)
        gtbSearch.Name = "gtbSearch"
        gtbSearch.PlaceholderText = "Search"
        gtbSearch.SelectedText = ""
        gtbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        gtbSearch.Size = New Size(242, 33)
        gtbSearch.TabIndex = 0
        ' 
        ' ManageUsersControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "ManageUsersControl"
        Size = New Size(855, 604)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(dgdvUsers, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents gbCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents gtbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgdvUsers As Guna.UI2.WinForms.Guna2DataGridView

End Class
