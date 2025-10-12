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
        btnAdd = New Button()
        lblOrderListText = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel5 = New TableLayoutPanel()
        btnRemove = New Button()
        btnEdit = New Button()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        cmbStatus = New ComboBox()
        tbSearch = New TextBox()
        flpTransactions = New FlowLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.3828354F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(lblOrderListText, 1, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 2, 0)
        TableLayoutPanel1.Controls.Add(flpTransactions, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.9245586F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 38.03772F))
        TableLayoutPanel1.Size = New Size(900, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(btnAdd, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.Size = New Size(249, 113)
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
        TableLayoutPanel3.Location = New Point(3, 48)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(243, 62)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 0
        Label1.Text = "Date:"
        ' 
        ' dtpDateFilter
        ' 
        TableLayoutPanel3.SetColumnSpan(dtpDateFilter, 2)
        dtpDateFilter.Dock = DockStyle.Fill
        dtpDateFilter.Location = New Point(3, 34)
        dtpDateFilter.Name = "dtpDateFilter"
        dtpDateFilter.Size = New Size(237, 23)
        dtpDateFilter.TabIndex = 1
        ' 
        ' chkAllDates
        ' 
        chkAllDates.AutoSize = True
        chkAllDates.Checked = True
        chkAllDates.CheckState = CheckState.Checked
        chkAllDates.Dock = DockStyle.Bottom
        chkAllDates.Location = New Point(124, 9)
        chkAllDates.Name = "chkAllDates"
        chkAllDates.Size = New Size(116, 19)
        chkAllDates.TabIndex = 2
        chkAllDates.Text = "Show All Dates"
        chkAllDates.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        TableLayoutPanel2.SetColumnSpan(btnAdd, 2)
        btnAdd.Dock = DockStyle.Fill
        btnAdd.Location = New Point(3, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(243, 39)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Order"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lblOrderListText
        ' 
        lblOrderListText.AutoSize = True
        lblOrderListText.Dock = DockStyle.Fill
        lblOrderListText.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrderListText.Location = New Point(258, 0)
        lblOrderListText.Name = "lblOrderListText"
        lblOrderListText.Size = New Size(316, 119)
        lblOrderListText.TabIndex = 2
        lblOrderListText.Text = "TRANSACTION LIST"
        lblOrderListText.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel4.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel4.Controls.Add(Panel2, 0, 1)
        TableLayoutPanel4.Controls.Add(Panel3, 1, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(580, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(317, 113)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel4.SetColumnSpan(Panel1, 2)
        Panel1.Controls.Add(TableLayoutPanel5)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(2, 2)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(313, 52)
        Panel1.TabIndex = 6
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(btnRemove, 1, 0)
        TableLayoutPanel5.Controls.Add(btnEdit, 1, 1)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(313, 52)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' btnRemove
        ' 
        btnRemove.Dock = DockStyle.Right
        btnRemove.Enabled = False
        btnRemove.Location = New Point(235, 3)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(75, 20)
        btnRemove.TabIndex = 0
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Dock = DockStyle.Right
        btnEdit.Enabled = False
        btnEdit.Location = New Point(235, 29)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 20)
        btnEdit.TabIndex = 1
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(2, 58)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(91, 53)
        Panel2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(0, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 17)
        Label3.TabIndex = 1
        Label3.Text = "Search:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 17)
        Label2.TabIndex = 0
        Label2.Text = "Status:"
        Label2.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Panel3
        ' 
        Panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel3.Controls.Add(cmbStatus)
        Panel3.Controls.Add(tbSearch)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(97, 58)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(218, 53)
        Panel3.TabIndex = 8
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Dock = DockStyle.Top
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"", "Pending", "In-Progress", "To be delivered", "Ready for Pickup", "Completed"})
        cmbStatus.Location = New Point(0, 0)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(218, 23)
        cmbStatus.TabIndex = 3
        ' 
        ' tbSearch
        ' 
        tbSearch.Dock = DockStyle.Bottom
        tbSearch.Location = New Point(0, 30)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(218, 23)
        tbSearch.TabIndex = 5
        ' 
        ' flpTransactions
        ' 
        flpTransactions.AutoScroll = True
        TableLayoutPanel1.SetColumnSpan(flpTransactions, 3)
        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.Location = New Point(2, 121)
        flpTransactions.Margin = New Padding(2)
        flpTransactions.Name = "flpTransactions"
        TableLayoutPanel1.SetRowSpan(flpTransactions, 2)
        flpTransactions.Size = New Size(896, 377)
        flpTransactions.TabIndex = 4
        flpTransactions.WrapContents = False
        ' 
        ' TransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "TransactionsControl"
        Size = New Size(900, 500)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateFilter As DateTimePicker
    Friend WithEvents lblOrderListText As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents chkAllDates As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents flpTransactions As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnEdit As Button

End Class
