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
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        dtpDateFilter = New DateTimePicker()
        chkAllDates = New CheckBox()
        btnReloadData = New Button()
        btnAdd = New Button()
        dgvTransactionsData = New DataGridView()
        lblOrderListText = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        cmbStatus = New ComboBox()
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
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.3828354F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(dgvTransactionsData, 0, 1)
        TableLayoutPanel1.Controls.Add(lblOrderListText, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.9245586F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.Size = New Size(1029, 667)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(btnReloadData, 1, 0)
        TableLayoutPanel2.Controls.Add(btnAdd, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 4)
        TableLayoutPanel2.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.Size = New Size(286, 151)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel2.SetColumnSpan(TableLayoutPanel3, 2)
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(dtpDateFilter, 0, 1)
        TableLayoutPanel3.Controls.Add(chkAllDates, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 64)
        TableLayoutPanel3.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(280, 83)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 41)
        Label1.TabIndex = 0
        Label1.Text = "Date:"
        ' 
        ' dtpDateFilter
        ' 
        TableLayoutPanel3.SetColumnSpan(dtpDateFilter, 2)
        dtpDateFilter.Dock = DockStyle.Fill
        dtpDateFilter.Location = New Point(3, 45)
        dtpDateFilter.Margin = New Padding(3, 4, 3, 4)
        dtpDateFilter.Name = "dtpDateFilter"
        dtpDateFilter.Size = New Size(274, 27)
        dtpDateFilter.TabIndex = 1
        ' 
        ' chkAllDates
        ' 
        chkAllDates.AutoSize = True
        chkAllDates.Checked = True
        chkAllDates.CheckState = CheckState.Checked
        chkAllDates.Dock = DockStyle.Fill
        chkAllDates.Location = New Point(143, 4)
        chkAllDates.Margin = New Padding(3, 4, 3, 4)
        chkAllDates.Name = "chkAllDates"
        chkAllDates.Size = New Size(134, 33)
        chkAllDates.TabIndex = 2
        chkAllDates.Text = "Show All Dates"
        chkAllDates.UseVisualStyleBackColor = True
        ' 
        ' btnReloadData
        ' 
        btnReloadData.BackgroundImage = My.Resources.Resources.refresh
        btnReloadData.BackgroundImageLayout = ImageLayout.Zoom
        btnReloadData.Dock = DockStyle.Fill
        btnReloadData.FlatAppearance.BorderSize = 0
        btnReloadData.FlatStyle = FlatStyle.Flat
        btnReloadData.Location = New Point(203, 4)
        btnReloadData.Margin = New Padding(3, 4, 3, 4)
        btnReloadData.Name = "btnReloadData"
        btnReloadData.Size = New Size(80, 52)
        btnReloadData.TabIndex = 2
        btnReloadData.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Dock = DockStyle.Fill
        btnAdd.Location = New Point(3, 4)
        btnAdd.Margin = New Padding(3, 4, 3, 4)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(194, 52)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Order"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' dgvTransactionsData
        ' 
        dgvTransactionsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(dgvTransactionsData, 3)
        dgvTransactionsData.Dock = DockStyle.Fill
        dgvTransactionsData.Location = New Point(3, 163)
        dgvTransactionsData.Margin = New Padding(3, 4, 3, 4)
        dgvTransactionsData.Name = "dgvTransactionsData"
        dgvTransactionsData.RowHeadersWidth = 51
        TableLayoutPanel1.SetRowSpan(dgvTransactionsData, 2)
        dgvTransactionsData.Size = New Size(1023, 500)
        dgvTransactionsData.TabIndex = 1
        ' 
        ' lblOrderListText
        ' 
        lblOrderListText.AutoSize = True
        lblOrderListText.Dock = DockStyle.Fill
        lblOrderListText.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderListText.Location = New Point(295, 0)
        lblOrderListText.Name = "lblOrderListText"
        lblOrderListText.Size = New Size(362, 159)
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
        TableLayoutPanel4.Controls.Add(cmbStatus, 1, 0)
        TableLayoutPanel4.Controls.Add(tbSearch, 1, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(663, 4)
        TableLayoutPanel4.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        TableLayoutPanel4.Size = New Size(363, 151)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 75)
        Label2.TabIndex = 0
        Label2.Text = "Status:"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(3, 75)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 76)
        Label3.TabIndex = 1
        Label3.Text = "Search:"
        Label3.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"", "Pending", "In-Progress", "To be delivered", "Ready for Pickup", "Completed"})
        cmbStatus.Location = New Point(111, 43)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(246, 28)
        cmbStatus.TabIndex = 3
        ' 
        ' tbSearch
        ' 
        tbSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        tbSearch.Location = New Point(111, 120)
        tbSearch.Margin = New Padding(3, 4, 3, 4)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(246, 27)
        tbSearch.TabIndex = 5
        ' 
        ' TransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "TransactionsControl"
        Size = New Size(1029, 667)
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
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateFilter As DateTimePicker
    Friend WithEvents dgvTransactionsData As DataGridView
    Friend WithEvents lblOrderListText As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents chkAllDates As CheckBox
    Friend WithEvents btnReloadData As Button
    Friend WithEvents btnAdd As Button

End Class
