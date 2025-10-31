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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnArchive = New Guna.UI2.WinForms.Guna2Button()
        btnComplete = New Guna.UI2.WinForms.Guna2Button()
        btnNotify = New Guna.UI2.WinForms.Guna2Button()
        lblWaiting = New Label()
        lblStatus = New Label()
        lblServiceType = New Label()
        lblCustomer = New Label()
        rowNum = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.499999F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.499999F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Controls.Add(btnArchive, 7, 0)
        TableLayoutPanel1.Controls.Add(btnComplete, 6, 0)
        TableLayoutPanel1.Controls.Add(btnNotify, 5, 0)
        TableLayoutPanel1.Controls.Add(lblWaiting, 4, 0)
        TableLayoutPanel1.Controls.Add(lblStatus, 3, 0)
        TableLayoutPanel1.Controls.Add(lblServiceType, 2, 0)
        TableLayoutPanel1.Controls.Add(lblCustomer, 1, 0)
        TableLayoutPanel1.Controls.Add(rowNum, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1104, 45)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btnArchive
        ' 
        btnArchive.BorderRadius = 16
        btnArchive.CustomizableEdges = CustomizableEdges1
        btnArchive.DisabledState.BorderColor = Color.DarkGray
        btnArchive.DisabledState.CustomBorderColor = Color.DarkGray
        btnArchive.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnArchive.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnArchive.Dock = DockStyle.Fill
        btnArchive.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnArchive.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnArchive.ForeColor = Color.Black
        btnArchive.Location = New Point(974, 3)
        btnArchive.Margin = New Padding(10, 3, 3, 3)
        btnArchive.Name = "btnArchive"
        btnArchive.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnArchive.Size = New Size(127, 39)
        btnArchive.TabIndex = 13
        btnArchive.Text = "Archive"
        ' 
        ' btnComplete
        ' 
        btnComplete.BorderRadius = 16
        btnComplete.CustomizableEdges = CustomizableEdges3
        btnComplete.DisabledState.BorderColor = Color.DarkGray
        btnComplete.DisabledState.CustomBorderColor = Color.DarkGray
        btnComplete.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnComplete.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnComplete.Dock = DockStyle.Fill
        btnComplete.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnComplete.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnComplete.ForeColor = Color.Black
        btnComplete.Location = New Point(836, 3)
        btnComplete.Margin = New Padding(10, 3, 3, 3)
        btnComplete.Name = "btnComplete"
        btnComplete.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnComplete.Size = New Size(125, 39)
        btnComplete.TabIndex = 12
        btnComplete.Text = "Complete"
        ' 
        ' btnNotify
        ' 
        btnNotify.BorderRadius = 16
        btnNotify.CustomizableEdges = CustomizableEdges5
        btnNotify.DisabledState.BorderColor = Color.DarkGray
        btnNotify.DisabledState.CustomBorderColor = Color.DarkGray
        btnNotify.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnNotify.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnNotify.Dock = DockStyle.Fill
        btnNotify.FillColor = Color.FromArgb(CByte(187), CByte(246), CByte(162))
        btnNotify.Font = New Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNotify.ForeColor = Color.Black
        btnNotify.Location = New Point(699, 3)
        btnNotify.Margin = New Padding(10, 3, 3, 3)
        btnNotify.Name = "btnNotify"
        btnNotify.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnNotify.Size = New Size(124, 39)
        btnNotify.TabIndex = 11
        btnNotify.Text = "Notify"
        ' 
        ' lblWaiting
        ' 
        lblWaiting.Dock = DockStyle.Fill
        lblWaiting.Font = New Font("Poppins", 8.25F)
        lblWaiting.Location = New Point(553, 0)
        lblWaiting.Margin = New Padding(2, 0, 2, 0)
        lblWaiting.Name = "lblWaiting"
        lblWaiting.Size = New Size(134, 45)
        lblWaiting.TabIndex = 4
        lblWaiting.Text = "Waiting"
        lblWaiting.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 8.25F)
        lblStatus.Location = New Point(415, 0)
        lblStatus.Margin = New Padding(2, 0, 2, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(134, 45)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblServiceType
        ' 
        lblServiceType.Dock = DockStyle.Fill
        lblServiceType.Font = New Font("Poppins", 8.25F)
        lblServiceType.Location = New Point(277, 0)
        lblServiceType.Margin = New Padding(2, 0, 2, 0)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New Size(134, 45)
        lblServiceType.TabIndex = 2
        lblServiceType.Text = "Service"
        lblServiceType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCustomer
        ' 
        lblCustomer.Dock = DockStyle.Fill
        lblCustomer.Font = New Font("Poppins", 8.25F)
        lblCustomer.Location = New Point(139, 0)
        lblCustomer.Margin = New Padding(2, 0, 2, 0)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(134, 45)
        lblCustomer.TabIndex = 1
        lblCustomer.Text = "Name"
        lblCustomer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' rowNum
        ' 
        rowNum.Dock = DockStyle.Fill
        rowNum.Font = New Font("Poppins", 8.25F)
        rowNum.Location = New Point(2, 0)
        rowNum.Margin = New Padding(2, 0, 2, 0)
        rowNum.Name = "rowNum"
        rowNum.Size = New Size(133, 45)
        rowNum.TabIndex = 0
        rowNum.Text = "Num"
        rowNum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TransactionRow
        ' 
        AutoScaleDimensions = New SizeF(7F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(0)
        Name = "TransactionRow"
        Size = New Size(1104, 45)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents rowNum As Label
    Friend WithEvents lblWaiting As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblServiceType As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents btnArchive As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnComplete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNotify As Guna.UI2.WinForms.Guna2Button

End Class
