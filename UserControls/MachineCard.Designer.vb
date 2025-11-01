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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblCycles = New Label()
        Label2 = New Label()
        lblClothesWeight = New Label()
        ClothesKGTitle = New Label()
        lblUnit = New Label()
        lblTransactionID = New Label()
        lblWeightText = New Label()
        lblWeightValue = New Label()
        Label1 = New Label()
        lblServiceTime = New Label()
        lblStatus = New Label()
        picMachine = New Guna.UI2.WinForms.Guna2PictureBox()
        btnViewDetails = New Guna.UI2.WinForms.Guna2Button()
        lblMachineIDText = New Label()
        btnProceedMachine = New Guna.UI2.WinForms.Guna2Button()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Controls.Add(lblStatus, 1, 0)
        TableLayoutPanel1.Controls.Add(picMachine, 0, 1)
        TableLayoutPanel1.Controls.Add(btnViewDetails, 1, 2)
        TableLayoutPanel1.Controls.Add(lblMachineIDText, 0, 0)
        TableLayoutPanel1.Controls.Add(btnProceedMachine, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.Padding = New Padding(5)
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(500, 300)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblCycles, 1, 5)
        TableLayoutPanel2.Controls.Add(Label2, 0, 5)
        TableLayoutPanel2.Controls.Add(lblClothesWeight, 1, 4)
        TableLayoutPanel2.Controls.Add(ClothesKGTitle, 0, 4)
        TableLayoutPanel2.Controls.Add(lblUnit, 0, 0)
        TableLayoutPanel2.Controls.Add(lblTransactionID, 0, 1)
        TableLayoutPanel2.Controls.Add(lblWeightText, 0, 2)
        TableLayoutPanel2.Controls.Add(lblWeightValue, 1, 2)
        TableLayoutPanel2.Controls.Add(Label1, 0, 3)
        TableLayoutPanel2.Controls.Add(lblServiceTime, 1, 3)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(253, 38)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(239, 214)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' lblCycles
        ' 
        lblCycles.AutoSize = True
        lblCycles.Dock = DockStyle.Fill
        lblCycles.Font = New Font("Poppins", 12F)
        lblCycles.Location = New Point(122, 175)
        lblCycles.Name = "lblCycles"
        lblCycles.Size = New Size(114, 39)
        lblCycles.TabIndex = 14
        lblCycles.Text = "0"
        lblCycles.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 12F)
        Label2.Location = New Point(3, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 39)
        Label2.TabIndex = 13
        Label2.Text = "# of Cycles:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblClothesWeight
        ' 
        lblClothesWeight.AutoSize = True
        lblClothesWeight.Dock = DockStyle.Fill
        lblClothesWeight.Font = New Font("Poppins", 12F)
        lblClothesWeight.Location = New Point(122, 140)
        lblClothesWeight.Name = "lblClothesWeight"
        lblClothesWeight.Size = New Size(114, 35)
        lblClothesWeight.TabIndex = 12
        lblClothesWeight.Text = "kg"
        lblClothesWeight.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ClothesKGTitle
        ' 
        ClothesKGTitle.AutoSize = True
        ClothesKGTitle.Dock = DockStyle.Fill
        ClothesKGTitle.Font = New Font("Poppins", 12F)
        ClothesKGTitle.Location = New Point(3, 140)
        ClothesKGTitle.Name = "ClothesKGTitle"
        ClothesKGTitle.Size = New Size(113, 35)
        ClothesKGTitle.TabIndex = 11
        ClothesKGTitle.Text = "Clothes (kg):"
        ClothesKGTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUnit
        ' 
        TableLayoutPanel2.SetColumnSpan(lblUnit, 2)
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Font = New Font("Poppins SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUnit.Location = New Point(3, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(233, 35)
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
        lblTransactionID.Location = New Point(3, 35)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(233, 35)
        lblTransactionID.TabIndex = 8
        lblTransactionID.Text = "Transaction ID:"
        lblTransactionID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWeightText
        ' 
        lblWeightText.AutoSize = True
        lblWeightText.Dock = DockStyle.Fill
        lblWeightText.Font = New Font("Poppins", 12F)
        lblWeightText.Location = New Point(3, 70)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(113, 35)
        lblWeightText.TabIndex = 2
        lblWeightText.Text = "Max Weight:"
        lblWeightText.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWeightValue
        ' 
        lblWeightValue.AutoSize = True
        lblWeightValue.Dock = DockStyle.Fill
        lblWeightValue.Font = New Font("Poppins", 11.25F)
        lblWeightValue.Location = New Point(122, 70)
        lblWeightValue.Name = "lblWeightValue"
        lblWeightValue.Size = New Size(114, 35)
        lblWeightValue.TabIndex = 6
        lblWeightValue.Text = "Weight:"
        lblWeightValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 12F)
        Label1.Location = New Point(3, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 35)
        Label1.TabIndex = 9
        Label1.Text = "Finishes in:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblServiceTime
        ' 
        lblServiceTime.AutoSize = True
        lblServiceTime.Dock = DockStyle.Fill
        lblServiceTime.Font = New Font("Poppins", 11.25F)
        lblServiceTime.Location = New Point(122, 105)
        lblServiceTime.Name = "lblServiceTime"
        lblServiceTime.Size = New Size(114, 35)
        lblServiceTime.TabIndex = 10
        lblServiceTime.Text = "00:00"
        lblServiceTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 12F)
        lblStatus.Location = New Point(253, 5)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(239, 30)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' picMachine
        ' 
        picMachine.CustomizableEdges = CustomizableEdges1
        picMachine.Dock = DockStyle.Fill
        picMachine.ImageRotate = 0F
        picMachine.Location = New Point(8, 38)
        picMachine.Name = "picMachine"
        picMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        picMachine.Size = New Size(239, 214)
        picMachine.SizeMode = PictureBoxSizeMode.Zoom
        picMachine.TabIndex = 13
        picMachine.TabStop = False
        picMachine.WaitOnLoad = True
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.Transparent
        btnViewDetails.BorderRadius = 10
        btnViewDetails.CustomizableEdges = CustomizableEdges3
        btnViewDetails.DisabledState.BorderColor = Color.DarkGray
        btnViewDetails.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewDetails.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewDetails.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewDetails.Dock = DockStyle.Left
        btnViewDetails.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnViewDetails.ForeColor = Color.Black
        btnViewDetails.Location = New Point(255, 258)
        btnViewDetails.Margin = New Padding(5, 3, 5, 3)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnViewDetails.Size = New Size(169, 34)
        btnViewDetails.TabIndex = 16
        btnViewDetails.Text = "View Details"
        ' 
        ' lblMachineIDText
        ' 
        lblMachineIDText.AutoSize = True
        lblMachineIDText.Dock = DockStyle.Bottom
        lblMachineIDText.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMachineIDText.Location = New Point(8, 9)
        lblMachineIDText.Name = "lblMachineIDText"
        lblMachineIDText.Size = New Size(239, 26)
        lblMachineIDText.TabIndex = 5
        lblMachineIDText.Text = "Machine ID:"
        lblMachineIDText.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnProceedMachine
        ' 
        btnProceedMachine.BackColor = Color.Transparent
        btnProceedMachine.BorderRadius = 10
        btnProceedMachine.CustomizableEdges = CustomizableEdges5
        btnProceedMachine.DisabledState.BorderColor = Color.DarkGray
        btnProceedMachine.DisabledState.CustomBorderColor = Color.DarkGray
        btnProceedMachine.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnProceedMachine.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnProceedMachine.Dock = DockStyle.Right
        btnProceedMachine.FillColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnProceedMachine.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnProceedMachine.ForeColor = Color.Black
        btnProceedMachine.Location = New Point(76, 258)
        btnProceedMachine.Margin = New Padding(5, 3, 5, 3)
        btnProceedMachine.Name = "btnProceedMachine"
        btnProceedMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnProceedMachine.Size = New Size(169, 34)
        btnProceedMachine.TabIndex = 14
        btnProceedMachine.Text = "In-Use"
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 18
        Guna2Elipse1.TargetControl = Me
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(5)
        Name = "MachineCard"
        Size = New Size(500, 300)
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
    Friend WithEvents lblServiceTime As Label
    Friend WithEvents picMachine As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnProceedMachine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewDetails As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblClothesWeight As Label
    Friend WithEvents ClothesKGTitle As Label
    Friend WithEvents lblCycles As Label
    Friend WithEvents Label2 As Label

End Class
