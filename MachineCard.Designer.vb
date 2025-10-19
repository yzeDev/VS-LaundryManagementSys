<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineCard
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblUnit = New Label()
        lblTransactionID = New Label()
        lblWeightText = New Label()
        lblWeightValue = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStatus = New Label()
        picMachine = New Guna.UI2.WinForms.Guna2PictureBox()
        btnProceedMachine = New Guna.UI2.WinForms.Guna2Button()
        btnViewDetails = New Guna.UI2.WinForms.Guna2Button()
        lblMachineIDText = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Controls.Add(lblStatus, 1, 0)
        TableLayoutPanel1.Controls.Add(picMachine, 0, 1)
        TableLayoutPanel1.Controls.Add(btnProceedMachine, 0, 2)
        TableLayoutPanel1.Controls.Add(btnViewDetails, 1, 2)
        TableLayoutPanel1.Controls.Add(lblMachineIDText, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 67F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 33F))
        TableLayoutPanel1.Size = New Size(571, 500)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblUnit, 0, 0)
        TableLayoutPanel2.Controls.Add(lblTransactionID, 0, 1)
        TableLayoutPanel2.Controls.Add(lblWeightText, 0, 2)
        TableLayoutPanel2.Controls.Add(lblWeightValue, 1, 2)
        TableLayoutPanel2.Controls.Add(Label1, 0, 3)
        TableLayoutPanel2.Controls.Add(Label2, 1, 3)
        TableLayoutPanel2.Controls.Add(Label3, 0, 4)
        TableLayoutPanel2.Controls.Add(Label4, 1, 4)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(289, 55)
        TableLayoutPanel2.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(278, 373)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' lblUnit
        ' 
        TableLayoutPanel2.SetColumnSpan(lblUnit, 2)
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUnit.Location = New Point(4, 0)
        lblUnit.Margin = New Padding(4, 0, 4, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(270, 62)
        lblUnit.TabIndex = 0
        lblUnit.Text = "Unit"
        lblUnit.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        TableLayoutPanel2.SetColumnSpan(lblTransactionID, 2)
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactionID.Location = New Point(4, 62)
        lblTransactionID.Margin = New Padding(4, 0, 4, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(270, 62)
        lblTransactionID.TabIndex = 8
        lblTransactionID.Text = "Transaction ID:"
        lblTransactionID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWeightText
        ' 
        lblWeightText.AutoSize = True
        lblWeightText.Dock = DockStyle.Fill
        lblWeightText.Font = New Font("Poppins", 9F)
        lblWeightText.Location = New Point(4, 124)
        lblWeightText.Margin = New Padding(4, 0, 4, 0)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(131, 62)
        lblWeightText.TabIndex = 2
        lblWeightText.Text = "Max Weight:"
        lblWeightText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWeightValue
        ' 
        lblWeightValue.AutoSize = True
        lblWeightValue.Dock = DockStyle.Fill
        lblWeightValue.Font = New Font("Poppins", 9F)
        lblWeightValue.Location = New Point(143, 124)
        lblWeightValue.Margin = New Padding(4, 0, 4, 0)
        lblWeightValue.Name = "lblWeightValue"
        lblWeightValue.Size = New Size(131, 62)
        lblWeightValue.TabIndex = 6
        lblWeightValue.Text = "Weight:"
        lblWeightValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 9F)
        Label1.Location = New Point(4, 186)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 62)
        Label1.TabIndex = 9
        Label1.Text = "Time Started:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 9F)
        Label2.Location = New Point(143, 186)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 62)
        Label2.TabIndex = 10
        Label2.Text = "00:00"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Poppins", 9F)
        Label3.Location = New Point(4, 248)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 62)
        Label3.TabIndex = 11
        Label3.Text = "Time Ends:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Poppins", 9F)
        Label4.Location = New Point(143, 248)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 62)
        Label4.TabIndex = 12
        Label4.Text = "00:00"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 12F)
        lblStatus.Location = New Point(289, 0)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(278, 50)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' picMachine
        ' 
        picMachine.CustomizableEdges = CustomizableEdges7
        picMachine.Dock = DockStyle.Fill
        picMachine.ImageRotate = 0F
        picMachine.Location = New Point(4, 55)
        picMachine.Margin = New Padding(4, 5, 4, 5)
        picMachine.Name = "picMachine"
        picMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        picMachine.Size = New Size(277, 373)
        picMachine.SizeMode = PictureBoxSizeMode.AutoSize
        picMachine.TabIndex = 13
        picMachine.TabStop = False
        picMachine.WaitOnLoad = True
        ' 
        ' btnProceedMachine
        ' 
        btnProceedMachine.Anchor = AnchorStyles.None
        btnProceedMachine.AutoRoundedCorners = True
        btnProceedMachine.CustomizableEdges = CustomizableEdges9
        btnProceedMachine.DisabledState.BorderColor = Color.DarkGray
        btnProceedMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnProceedMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnProceedMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnProceedMachine.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnProceedMachine.Font = New Font("Poppins", 8.25F)
        btnProceedMachine.ForeColor = Color.Black
        btnProceedMachine.Location = New Point(14, 438)
        btnProceedMachine.Margin = New Padding(4, 5, 4, 5)
        btnProceedMachine.Name = "btnProceedMachine"
        btnProceedMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnProceedMachine.Size = New Size(257, 57)
        btnProceedMachine.TabIndex = 14
        btnProceedMachine.Text = "Get Pending"
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.Anchor = AnchorStyles.None
        btnViewDetails.AutoRoundedCorners = True
        btnViewDetails.CustomizableEdges = CustomizableEdges11
        btnViewDetails.DisabledState.BorderColor = Color.DarkGray
        btnViewDetails.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewDetails.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewDetails.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewDetails.FillColor = Color.Gainsboro
        btnViewDetails.Font = New Font("Poppins", 8.25F)
        btnViewDetails.ForeColor = Color.Black
        btnViewDetails.Location = New Point(299, 438)
        btnViewDetails.Margin = New Padding(4, 5, 4, 5)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnViewDetails.Size = New Size(257, 57)
        btnViewDetails.TabIndex = 16
        btnViewDetails.Text = "View Details"
        ' 
        ' lblMachineIDText
        ' 
        lblMachineIDText.AutoSize = True
        lblMachineIDText.Dock = DockStyle.Bottom
        lblMachineIDText.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMachineIDText.Location = New Point(4, 10)
        lblMachineIDText.Margin = New Padding(4, 0, 4, 0)
        lblMachineIDText.Name = "lblMachineIDText"
        lblMachineIDText.Size = New Size(277, 40)
        lblMachineIDText.TabIndex = 5
        lblMachineIDText.Text = "Machine ID:"
        lblMachineIDText.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(0)
        Name = "MachineCard"
        Size = New Size(571, 500)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblWeightText As Label
    Friend WithEvents lblMachineIDText As Label
    Friend WithEvents lblWeightValue As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents picMachine As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnProceedMachine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewDetails As Guna.UI2.WinForms.Guna2Button

End Class
