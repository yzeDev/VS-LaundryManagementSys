<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionsControl
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
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnAddOrder = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        dgvTransactionsData = New DataGridView()
        lblOrderListText = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        cmbStatus = New ComboBox()
        cmbFilter = New ComboBox()
        tbSearch = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(dgvTransactionsData, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 23.36871F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.3156433F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.3156433F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvTransactionsData, 0, 1)
        TableLayoutPanel1.Controls.Add(lblOrderListText, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.9245586F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.Size = New Size(800, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Controls.Add(btnAddOrder, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(180, 113)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.Dock = DockStyle.Fill
        btnAddOrder.FlatStyle = FlatStyle.Flat
        btnAddOrder.ImageAlign = ContentAlignment.MiddleRight
        btnAddOrder.Location = New Point(3, 3)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New Size(174, 50)
        btnAddOrder.TabIndex = 0
        btnAddOrder.Text = "ADD ORDER"
        btnAddOrder.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(DateTimePicker1, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 59)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(174, 51)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 25)
        Label1.TabIndex = 0
        Label1.Text = "Date:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Dock = DockStyle.Fill
        DateTimePicker1.Location = New Point(3, 28)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(168, 23)
        DateTimePicker1.TabIndex = 1
        ' 
        ' dgvTransactionsData
        ' 
        dgvTransactionsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(dgvTransactionsData, 3)
        dgvTransactionsData.Dock = DockStyle.Fill
        dgvTransactionsData.Location = New Point(3, 122)
        dgvTransactionsData.Name = "dgvTransactionsData"
        TableLayoutPanel1.SetRowSpan(dgvTransactionsData, 2)
        dgvTransactionsData.Size = New Size(794, 375)
        dgvTransactionsData.TabIndex = 1
        ' 
        ' lblOrderListText
        ' 
        lblOrderListText.AutoSize = True
        lblOrderListText.Dock = DockStyle.Fill
        lblOrderListText.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderListText.Location = New Point(189, 0)
        lblOrderListText.Name = "lblOrderListText"
        lblOrderListText.Size = New Size(300, 119)
        lblOrderListText.TabIndex = 2
        lblOrderListText.Text = "ORDER LIST"
        lblOrderListText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel4.Controls.Add(Label2, 0, 0)
        TableLayoutPanel4.Controls.Add(Label3, 0, 1)
        TableLayoutPanel4.Controls.Add(Label4, 0, 2)
        TableLayoutPanel4.Controls.Add(cmbStatus, 1, 0)
        TableLayoutPanel4.Controls.Add(cmbFilter, 1, 2)
        TableLayoutPanel4.Controls.Add(tbSearch, 1, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(495, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 3
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel4.Size = New Size(302, 113)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 37)
        Label2.TabIndex = 0
        Label2.Text = "Status:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(3, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 37)
        Label3.TabIndex = 1
        Label3.Text = "Search:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.Location = New Point(3, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 39)
        Label4.TabIndex = 2
        Label4.Text = "Filter by:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Dock = DockStyle.Fill
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "In-Progress", "To be delivered", "Ready for Pickup", "Completed"})
        cmbStatus.Location = New Point(93, 3)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(206, 23)
        cmbStatus.TabIndex = 3
        ' 
        ' cmbFilter
        ' 
        cmbFilter.Dock = DockStyle.Fill
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {"Pending", "In-Progress", "To be delivered", "Ready for Pickup", "Completed"})
        cmbFilter.Location = New Point(93, 77)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(206, 23)
        cmbFilter.TabIndex = 4
        ' 
        ' tbSearch
        ' 
        tbSearch.Dock = DockStyle.Fill
        tbSearch.Location = New Point(93, 40)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(206, 23)
        tbSearch.TabIndex = 5
        ' 
        ' TransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "TransactionsControl"
        Size = New Size(800, 500)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(dgvTransactionsData, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgvTransactionsData As DataGridView
    Friend WithEvents lblOrderListText As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents tbSearch As TextBox

End Class
