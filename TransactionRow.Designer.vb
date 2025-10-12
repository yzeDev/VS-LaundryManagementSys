<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionRow
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
        lblTotal = New Label()
        lblDate = New Label()
        lblMachine = New Label()
        lblStatus = New Label()
        lblServiceType = New Label()
        lblCustomer = New Label()
        lblTransactionID = New Label()
        btnView = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Controls.Add(lblTotal, 6, 0)
        TableLayoutPanel1.Controls.Add(lblDate, 5, 0)
        TableLayoutPanel1.Controls.Add(lblMachine, 4, 0)
        TableLayoutPanel1.Controls.Add(lblStatus, 3, 0)
        TableLayoutPanel1.Controls.Add(lblServiceType, 2, 0)
        TableLayoutPanel1.Controls.Add(lblCustomer, 1, 0)
        TableLayoutPanel1.Controls.Add(lblTransactionID, 0, 0)
        TableLayoutPanel1.Controls.Add(btnView, 7, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(602, 43)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblTotal
        ' 
        lblTotal.Dock = DockStyle.Fill
        lblTotal.Location = New Point(452, 0)
        lblTotal.Margin = New Padding(2, 0, 2, 0)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(71, 43)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Total"
        lblTotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblDate
        ' 
        lblDate.Dock = DockStyle.Fill
        lblDate.Location = New Point(377, 0)
        lblDate.Margin = New Padding(2, 0, 2, 0)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(71, 43)
        lblDate.TabIndex = 5
        lblDate.Text = "Date"
        lblDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblMachine
        ' 
        lblMachine.Dock = DockStyle.Fill
        lblMachine.Location = New Point(302, 0)
        lblMachine.Margin = New Padding(2, 0, 2, 0)
        lblMachine.Name = "lblMachine"
        lblMachine.Size = New Size(71, 43)
        lblMachine.TabIndex = 4
        lblMachine.Text = "Machine"
        lblMachine.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStatus
        ' 
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Location = New Point(227, 0)
        lblStatus.Margin = New Padding(2, 0, 2, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(71, 43)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblServiceType
        ' 
        lblServiceType.Dock = DockStyle.Fill
        lblServiceType.Location = New Point(152, 0)
        lblServiceType.Margin = New Padding(2, 0, 2, 0)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(71, 43)
        lblServiceType.TabIndex = 2
        lblServiceType.Text = "Service"
        lblServiceType.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCustomer
        ' 
        lblCustomer.Dock = DockStyle.Fill
        lblCustomer.Location = New Point(77, 0)
        lblCustomer.Margin = New Padding(2, 0, 2, 0)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(71, 43)
        lblCustomer.TabIndex = 1
        lblCustomer.Text = "Name"
        lblCustomer.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Location = New Point(2, 0)
        lblTransactionID.Margin = New Padding(2, 0, 2, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(71, 43)
        lblTransactionID.TabIndex = 0
        lblTransactionID.Text = "Transac"
        lblTransactionID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnView
        ' 
        btnView.Dock = DockStyle.Fill
        btnView.Location = New Point(527, 2)
        btnView.Margin = New Padding(2)
        btnView.Name = "btnView"
        btnView.Size = New Size(73, 39)
        btnView.TabIndex = 7
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' TransactionRow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(2)
        Name = "TransactionRow"
        Size = New Size(602, 43)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblMachine As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents btnView As Button

End Class
