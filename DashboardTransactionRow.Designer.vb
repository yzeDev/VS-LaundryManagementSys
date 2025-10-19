<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardTransactionRow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardTransactionRow))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblOrderID = New Label()
        lblCustomerName = New Label()
        lblContactNo = New Label()
        lblStatus = New Label()
        btnNotify = New Guna.UI2.WinForms.Guna2Button()
        btnCheck = New Guna.UI2.WinForms.Guna2ImageButton()
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
        TableLayoutPanel1.Controls.Add(btnNotify, 4, 0)
        TableLayoutPanel1.Controls.Add(btnCheck, 5, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(657, 45)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblOrderID
        ' 
        lblOrderID.AutoSize = True
        lblOrderID.BackColor = Color.Transparent
        lblOrderID.Dock = DockStyle.Fill
        lblOrderID.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOrderID.Location = New Point(3, 0)
        lblOrderID.Name = "lblOrderID"
        lblOrderID.Size = New Size(115, 45)
        lblOrderID.TabIndex = 0
        lblOrderID.Text = "Transac ID"
        lblOrderID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.BackColor = Color.Transparent
        lblCustomerName.Dock = DockStyle.Fill
        lblCustomerName.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCustomerName.Location = New Point(124, 0)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(115, 45)
        lblCustomerName.TabIndex = 1
        lblCustomerName.Text = "CustomerName"
        lblCustomerName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.BackColor = Color.Transparent
        lblContactNo.Dock = DockStyle.Fill
        lblContactNo.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContactNo.Location = New Point(245, 0)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(115, 45)
        lblContactNo.TabIndex = 2
        lblContactNo.Text = "ContactNo"
        lblContactNo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(366, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(115, 45)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNotify
        ' 
        btnNotify.BackColor = Color.White
        btnNotify.CustomizableEdges = CustomizableEdges1
        btnNotify.DisabledState.BorderColor = Color.DarkGray
        btnNotify.DisabledState.CustomBorderColor = Color.DarkGray
        btnNotify.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNotify.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNotify.FillColor = Color.White
        btnNotify.Font = New Font("Segoe UI", 9F)
        btnNotify.ForeColor = Color.Black
        btnNotify.Location = New Point(487, 3)
        btnNotify.Name = "btnNotify"
        btnNotify.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnNotify.Size = New Size(115, 39)
        btnNotify.TabIndex = 4
        btnNotify.Text = "Notify"
        ' 
        ' btnCheck
        ' 
        btnCheck.CheckedState.ImageSize = New Size(64, 64)
        btnCheck.HoverState.ImageSize = New Size(64, 64)
        btnCheck.Image = CType(resources.GetObject("btnCheck.Image"), Image)
        btnCheck.ImageOffset = New Point(0, 0)
        btnCheck.ImageRotate = 0F
        btnCheck.Location = New Point(608, 3)
        btnCheck.Name = "btnCheck"
        btnCheck.PressedState.ImageSize = New Size(64, 64)
        btnCheck.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btnCheck.Size = New Size(46, 39)
        btnCheck.TabIndex = 5
        ' 
        ' DashboardTransactionRow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "DashboardTransactionRow"
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
    Friend WithEvents btnNotify As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCheck As Guna.UI2.WinForms.Guna2ImageButton

End Class
