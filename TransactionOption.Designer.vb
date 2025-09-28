<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionOption
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
        lblLaundryText = New Label()
        lblTransactionFormText = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnCancelOrder = New Button()
        btnDryCleaning = New Button()
        btnFullSelfServiceText = New Button()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblLaundryText
        ' 
        lblLaundryText.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        lblLaundryText.Dock = DockStyle.Top
        lblLaundryText.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLaundryText.ForeColor = Color.White
        lblLaundryText.Location = New Point(0, 0)
        lblLaundryText.Name = "lblLaundryText"
        lblLaundryText.Size = New Size(372, 37)
        lblLaundryText.TabIndex = 1
        lblLaundryText.Text = "Laundry Management System"
        lblLaundryText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionFormText
        ' 
        lblTransactionFormText.Dock = DockStyle.Top
        lblTransactionFormText.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactionFormText.Location = New Point(0, 37)
        lblTransactionFormText.Name = "lblTransactionFormText"
        lblTransactionFormText.Size = New Size(372, 89)
        lblTransactionFormText.TabIndex = 2
        lblTransactionFormText.Text = "Transaction Form"
        lblTransactionFormText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnCancelOrder, 0, 2)
        TableLayoutPanel1.Controls.Add(btnDryCleaning, 0, 1)
        TableLayoutPanel1.Controls.Add(btnFullSelfServiceText, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 126)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 67F))
        TableLayoutPanel1.Size = New Size(372, 395)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' btnCancelOrder
        ' 
        btnCancelOrder.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancelOrder.BackColor = Color.FromArgb(CByte(255), CByte(87), CByte(87))
        btnCancelOrder.FlatStyle = FlatStyle.Flat
        btnCancelOrder.ForeColor = Color.White
        btnCancelOrder.Location = New Point(3, 349)
        btnCancelOrder.Name = "btnCancelOrder"
        btnCancelOrder.Size = New Size(114, 43)
        btnCancelOrder.TabIndex = 13
        btnCancelOrder.Text = "Cancel Order"
        btnCancelOrder.UseVisualStyleBackColor = False
        ' 
        ' btnDryCleaning
        ' 
        btnDryCleaning.Anchor = AnchorStyles.None
        btnDryCleaning.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        btnDryCleaning.FlatStyle = FlatStyle.Flat
        btnDryCleaning.Font = New Font("Microsoft Sans Serif", 15.75F)
        btnDryCleaning.ForeColor = Color.White
        btnDryCleaning.Location = New Point(56, 206)
        btnDryCleaning.Name = "btnDryCleaning"
        btnDryCleaning.Size = New Size(259, 79)
        btnDryCleaning.TabIndex = 12
        btnDryCleaning.Text = "Dry Cleaning"
        btnDryCleaning.UseVisualStyleBackColor = False
        ' 
        ' btnFullSelfServiceText
        ' 
        btnFullSelfServiceText.Anchor = AnchorStyles.None
        btnFullSelfServiceText.BackColor = Color.FromArgb(CByte(57), CByte(88), CByte(134))
        btnFullSelfServiceText.FlatStyle = FlatStyle.Flat
        btnFullSelfServiceText.Font = New Font("Microsoft Sans Serif", 15.75F)
        btnFullSelfServiceText.ForeColor = Color.White
        btnFullSelfServiceText.Location = New Point(56, 42)
        btnFullSelfServiceText.Name = "btnFullSelfServiceText"
        btnFullSelfServiceText.Size = New Size(259, 79)
        btnFullSelfServiceText.TabIndex = 11
        btnFullSelfServiceText.Text = "Full-Service/Self-Service"
        btnFullSelfServiceText.UseVisualStyleBackColor = False
        ' 
        ' TransactionOption
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(372, 521)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(lblTransactionFormText)
        Controls.Add(lblLaundryText)
        Name = "TransactionOption"
        Text = "TransactionOption"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblLaundryText As Label
    Friend WithEvents lblTransactionFormText As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnDryCleaning As Button
    Friend WithEvents btnFullSelfServiceText As Button
    Friend WithEvents btnCancelOrder As Button
End Class
