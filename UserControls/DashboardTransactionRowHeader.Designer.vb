<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardTransactionRowHeader
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblStatus = New Label()
        lblContactNo = New Label()
        lblCustomerName = New Label()
        lblOrderID = New Label()
        lblAction = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0000057F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.Controls.Add(lblStatus, 3, 0)
        TableLayoutPanel1.Controls.Add(lblContactNo, 2, 0)
        TableLayoutPanel1.Controls.Add(lblCustomerName, 1, 0)
        TableLayoutPanel1.Controls.Add(lblOrderID, 0, 0)
        TableLayoutPanel1.Controls.Add(lblAction, 4, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(657, 45)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 9.75F)
        lblStatus.Location = New Point(366, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(115, 45)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.BackColor = Color.Transparent
        lblContactNo.Dock = DockStyle.Fill
        lblContactNo.Font = New Font("Poppins", 9.75F)
        lblContactNo.Location = New Point(245, 0)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(115, 45)
        lblContactNo.TabIndex = 2
        lblContactNo.Text = "Contact No."
        lblContactNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.BackColor = Color.Transparent
        lblCustomerName.Dock = DockStyle.Fill
        lblCustomerName.Font = New Font("Poppins", 9.75F)
        lblCustomerName.Location = New Point(124, 0)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(115, 45)
        lblCustomerName.TabIndex = 1
        lblCustomerName.Text = "Name"
        lblCustomerName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOrderID
        ' 
        lblOrderID.AutoSize = True
        lblOrderID.BackColor = Color.Transparent
        lblOrderID.Dock = DockStyle.Fill
        lblOrderID.Font = New Font("Poppins", 9.75F)
        lblOrderID.Location = New Point(3, 0)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(115, 45)
        lblOrderID.TabIndex = 0
        lblOrderID.Text = "Transaction ID"
        lblOrderID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAction
        ' 
        lblAction.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblAction, 2)
        lblAction.Dock = DockStyle.Fill
        lblAction.Font = New Font("Poppins", 9.75F)
        lblAction.Location = New Point(487, 0)
        lblAction.Name = "lblAction"
        lblAction.Size = New Size(167, 45)
        lblAction.TabIndex = 4
        lblAction.Text = "Actions"
        lblAction.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DashboardTransactionRowHeader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        ForeColor = Color.Black
        Name = "DashboardTransactionRowHeader"
        Size = New Size(657, 45)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblAction As Label

End Class
