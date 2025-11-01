<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsControl
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogsControl))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        gtbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgvLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvLogs)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 70)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(855, 534)
        Panel2.TabIndex = 1
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.White
        Guna2Panel1.Controls.Add(TableLayoutPanel2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 20)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(855, 45)
        Guna2Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel2.Controls.Add(Panel3, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(855, 45)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(427, 45)
        Panel3.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(gtbSearch)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(427, 0)
        Panel4.Margin = New Padding(0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(428, 45)
        Panel4.TabIndex = 1
        ' 
        ' gtbSearch
        ' 
        gtbSearch.CustomizableEdges = CustomizableEdges1
        gtbSearch.DefaultText = ""
        gtbSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        gtbSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        gtbSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbSearch.Dock = DockStyle.Right
        gtbSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbSearch.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gtbSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbSearch.IconLeft = CType(resources.GetObject("gtbSearch.IconLeft"), Image)
        gtbSearch.IconLeftOffset = New Point(10, 0)
        gtbSearch.Location = New Point(149, 0)
        gtbSearch.Margin = New Padding(4, 6, 4, 6)
        gtbSearch.Name = "gtbSearch"
        gtbSearch.PlaceholderText = "Search"
        gtbSearch.SelectedText = ""
        gtbSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        gtbSearch.Size = New Size(279, 45)
        gtbSearch.TabIndex = 0
        ' 
        ' dgvLogs
        ' 
        dgvLogs.AllowUserToAddRows = False
        dgvLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLogs.DefaultCellStyle = DataGridViewCellStyle3
        dgvLogs.Dock = DockStyle.Fill
        dgvLogs.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLogs.Location = New Point(0, 0)
        dgvLogs.Name = "dgvLogs"
        dgvLogs.ReadOnly = True
        dgvLogs.RowHeadersVisible = False
        dgvLogs.Size = New Size(855, 534)
        dgvLogs.TabIndex = 0
        dgvLogs.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvLogs.ThemeStyle.BackColor = Color.White
        dgvLogs.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLogs.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvLogs.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvLogs.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvLogs.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLogs.ThemeStyle.HeaderStyle.Height = 4
        dgvLogs.ThemeStyle.ReadOnly = True
        dgvLogs.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvLogs.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLogs.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvLogs.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvLogs.ThemeStyle.RowsStyle.Height = 25
        dgvLogs.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvLogs.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' LogsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "LogsControl"
        Size = New Size(855, 604)
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents gtbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvLogs As Guna.UI2.WinForms.Guna2DataGridView

End Class
