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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        dtpDateFilter1 = New DateTimePicker()
        chkAllDates = New CheckBox()
        btnAdd = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        cmbStatus = New ComboBox()
        tbSearch = New TextBox()
        flpTransactions = New FlowLayoutPanel()
        dtpDateFilter = New Guna.UI2.WinForms.Guna2DateTimePicker()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 28.38284F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.8085823F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 0)
        TableLayoutPanel1.Controls.Add(btnAdd, 0, 2)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel4, 2, 0)
        TableLayoutPanel1.Controls.Add(flpTransactions, 0, 1)
        TableLayoutPanel1.Controls.Add(dtpDateFilter, 2, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 100F))
        TableLayoutPanel1.Size = New Size(855, 604)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel2.Size = New Size(236, 94)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel2.SetColumnSpan(TableLayoutPanel3, 2)
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(dtpDateFilter1, 0, 1)
        TableLayoutPanel3.Controls.Add(chkAllDates, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 40)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(230, 51)
        TableLayoutPanel3.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Bottom
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 0
        Label1.Text = "Date:"
        ' 
        ' dtpDateFilter1
        ' 
        TableLayoutPanel3.SetColumnSpan(dtpDateFilter1, 2)
        dtpDateFilter1.Dock = DockStyle.Fill
        dtpDateFilter1.Location = New Point(3, 28)
        dtpDateFilter1.Name = "dtpDateFilter1"
        dtpDateFilter1.Size = New Size(224, 23)
        dtpDateFilter1.TabIndex = 1
        ' 
        ' chkAllDates
        ' 
        chkAllDates.AutoSize = True
        chkAllDates.Checked = True
        chkAllDates.CheckState = CheckState.Checked
        chkAllDates.Dock = DockStyle.Bottom
        chkAllDates.Location = New Point(118, 3)
        chkAllDates.Name = "chkAllDates"
        chkAllDates.Size = New Size(109, 19)
        chkAllDates.TabIndex = 2
        chkAllDates.Text = "Show All Dates"
        chkAllDates.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(3, 506)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(230, 39)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Order"
        btnAdd.UseVisualStyleBackColor = True
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
        TableLayoutPanel4.Location = New Point(551, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(301, 94)
        TableLayoutPanel4.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel4.SetColumnSpan(Panel1, 2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(2, 2)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(297, 43)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(2, 49)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(86, 43)
        Panel2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Bottom
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(0, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 17)
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
        Label2.Size = New Size(86, 17)
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
        Panel3.Location = New Point(92, 49)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 43)
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
        cmbStatus.Size = New Size(207, 23)
        cmbStatus.TabIndex = 3
        ' 
        ' tbSearch
        ' 
        tbSearch.Dock = DockStyle.Bottom
        tbSearch.Location = New Point(0, 20)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(207, 23)
        tbSearch.TabIndex = 5
        ' 
        ' flpTransactions
        ' 
        flpTransactions.AutoScroll = True
        TableLayoutPanel1.SetColumnSpan(flpTransactions, 3)
        flpTransactions.Dock = DockStyle.Fill
        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.Location = New Point(2, 102)
        flpTransactions.Margin = New Padding(2)
        flpTransactions.Name = "flpTransactions"
        flpTransactions.Size = New Size(851, 399)
        flpTransactions.TabIndex = 4
        flpTransactions.WrapContents = False
        ' 
        ' dtpDateFilter
        ' 
        dtpDateFilter.Checked = True
        dtpDateFilter.CustomizableEdges = CustomizableEdges1
        dtpDateFilter.Font = New Font("Segoe UI", 9F)
        dtpDateFilter.Format = DateTimePickerFormat.Long
        dtpDateFilter.Location = New Point(551, 506)
        dtpDateFilter.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpDateFilter.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpDateFilter.Name = "dtpDateFilter"
        dtpDateFilter.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        dtpDateFilter.Size = New Size(200, 36)
        dtpDateFilter.TabIndex = 5
        dtpDateFilter.Value = New Date(2025, 10, 14, 2, 48, 47, 303)
        ' 
        ' TransactionsControl
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(10)
        Name = "TransactionsControl"
        Size = New Size(855, 604)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateFilter1 As DateTimePicker
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents chkAllDates As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents flpTransactions As FlowLayoutPanel
    Friend WithEvents dtpDateFilter As Guna.UI2.WinForms.Guna2DateTimePicker

End Class
