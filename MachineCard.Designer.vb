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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
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
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
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
        TableLayoutPanel1.Controls.Add(Guna2Button1, 0, 2)
        TableLayoutPanel1.Controls.Add(Guna2Button2, 1, 2)
        TableLayoutPanel1.Controls.Add(lblMachineIDText, 0, 0)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(400, 300)
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
        TableLayoutPanel2.Location = New Point(203, 33)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(194, 224)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' lblUnit
        ' 
        TableLayoutPanel2.SetColumnSpan(lblUnit, 2)
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Font = New Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUnit.Location = New Point(3, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(188, 37)
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
        lblTransactionID.Location = New Point(3, 37)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(188, 37)
        lblTransactionID.TabIndex = 8
        lblTransactionID.Text = "Transaction ID:"
        lblTransactionID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWeightText
        ' 
        lblWeightText.AutoSize = True
        lblWeightText.Dock = DockStyle.Fill
        lblWeightText.Font = New Font("Poppins", 9F)
        lblWeightText.Location = New Point(3, 74)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(91, 37)
        lblWeightText.TabIndex = 2
        lblWeightText.Text = "Max Weight:"
        lblWeightText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWeightValue
        ' 
        lblWeightValue.AutoSize = True
        lblWeightValue.Dock = DockStyle.Fill
        lblWeightValue.Font = New Font("Poppins", 9F)
        lblWeightValue.Location = New Point(100, 74)
        lblWeightValue.Name = "lblWeightValue"
        lblWeightValue.Size = New Size(91, 37)
        lblWeightValue.TabIndex = 6
        lblWeightValue.Text = "Weight:"
        lblWeightValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 9F)
        Label1.Location = New Point(3, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 37)
        Label1.TabIndex = 9
        Label1.Text = "Time Started:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 9F)
        Label2.Location = New Point(100, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 37)
        Label2.TabIndex = 10
        Label2.Text = "00:00"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Poppins", 9F)
        Label3.Location = New Point(3, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 37)
        Label3.TabIndex = 11
        Label3.Text = "Time Ends:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Poppins", 9F)
        Label4.Location = New Point(100, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 37)
        Label4.TabIndex = 12
        Label4.Text = "00:00"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Poppins", 12F)
        lblStatus.Location = New Point(203, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(194, 30)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' picMachine
        ' 
        picMachine.CustomizableEdges = CustomizableEdges1
        picMachine.Dock = DockStyle.Fill
        picMachine.ImageRotate = 0F
        picMachine.Location = New Point(3, 33)
        picMachine.Name = "picMachine"
        picMachine.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        picMachine.Size = New Size(194, 224)
        picMachine.SizeMode = PictureBoxSizeMode.AutoSize
        picMachine.TabIndex = 13
        picMachine.TabStop = False
        picMachine.WaitOnLoad = True
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.Anchor = AnchorStyles.None
        Guna2Button1.AutoRoundedCorners = True
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        Guna2Button1.Font = New Font("Poppins", 8.25F)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(10, 263)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(180, 34)
        Guna2Button1.TabIndex = 14
        Guna2Button1.Text = "Complete"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Anchor = AnchorStyles.None
        Guna2Button2.AutoRoundedCorners = True
        Guna2Button2.CustomizableEdges = CustomizableEdges5
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Gainsboro
        Guna2Button2.Font = New Font("Poppins", 8.25F)
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Location = New Point(210, 263)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button2.Size = New Size(180, 34)
        Guna2Button2.TabIndex = 16
        Guna2Button2.Text = "View Details"
        ' 
        ' lblMachineIDText
        ' 
        lblMachineIDText.AutoSize = True
        lblMachineIDText.Dock = DockStyle.Bottom
        lblMachineIDText.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMachineIDText.Location = New Point(3, 4)
        lblMachineIDText.Name = "lblMachineIDText"
        lblMachineIDText.Size = New Size(194, 26)
        lblMachineIDText.TabIndex = 5
        lblMachineIDText.Text = "Machine ID:"
        lblMachineIDText.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(0)
        Name = "MachineCard"
        Size = New Size(400, 300)
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
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button

End Class
