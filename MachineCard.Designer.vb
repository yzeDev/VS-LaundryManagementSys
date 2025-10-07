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
        TableLayoutPanel1 = New TableLayoutPanel()
        lblWeightValue = New Label()
        lblWeightText = New Label()
        lblUnit = New Label()
        picMachine = New PictureBox()
        lblMachineIDText = New Label()
        Label1 = New Label()
        lblTransactionID = New Label()
        lblStatus = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(lblWeightValue, 1, 3)
        TableLayoutPanel1.Controls.Add(lblWeightText, 0, 3)
        TableLayoutPanel1.Controls.Add(lblUnit, 0, 0)
        TableLayoutPanel1.Controls.Add(picMachine, 0, 1)
        TableLayoutPanel1.Controls.Add(lblMachineIDText, 0, 2)
        TableLayoutPanel1.Controls.Add(Label1, 0, 4)
        TableLayoutPanel1.Controls.Add(lblTransactionID, 0, 5)
        TableLayoutPanel1.Controls.Add(lblStatus, 1, 4)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(4, 5, 4, 5)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.264462F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 51.7499161F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.2982359F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.2982359F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.2982349F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090908F))
        TableLayoutPanel1.Size = New Size(357, 533)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lblWeightValue
        ' 
        lblWeightValue.AutoSize = True
        lblWeightValue.Dock = DockStyle.Fill
        lblWeightValue.Location = New Point(182, 373)
        lblWeightValue.Margin = New Padding(4, 0, 4, 0)
        lblWeightValue.Name = "lblWeightValue"
        lblWeightValue.Size = New Size(171, 54)
        lblWeightValue.TabIndex = 6
        lblWeightValue.Text = "Weight:"
        lblWeightValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWeightText
        ' 
        lblWeightText.AutoSize = True
        lblWeightText.Dock = DockStyle.Fill
        lblWeightText.Location = New Point(4, 373)
        lblWeightText.Margin = New Padding(4, 0, 4, 0)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(170, 54)
        lblWeightText.TabIndex = 2
        lblWeightText.Text = "Max Weight Capacity:"
        lblWeightText.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblUnit
        ' 
        lblUnit.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblUnit, 2)
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUnit.Location = New Point(4, 0)
        lblUnit.Margin = New Padding(4, 0, 4, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(349, 44)
        lblUnit.TabIndex = 0
        lblUnit.Text = "Unit"
        lblUnit.TextAlign = ContentAlignment.TopCenter
        ' 
        ' picMachine
        ' 
        TableLayoutPanel1.SetColumnSpan(picMachine, 2)
        picMachine.Dock = DockStyle.Fill
        picMachine.Location = New Point(4, 49)
        picMachine.Margin = New Padding(4, 5, 4, 5)
        picMachine.Name = "picMachine"
        picMachine.Size = New Size(349, 265)
        picMachine.TabIndex = 4
        picMachine.TabStop = False
        ' 
        ' lblMachineIDText
        ' 
        lblMachineIDText.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblMachineIDText, 2)
        lblMachineIDText.Dock = DockStyle.Fill
        lblMachineIDText.Location = New Point(4, 319)
        lblMachineIDText.Margin = New Padding(4, 0, 4, 0)
        lblMachineIDText.Name = "lblMachineIDText"
        lblMachineIDText.Size = New Size(349, 54)
        lblMachineIDText.TabIndex = 5
        lblMachineIDText.Text = "Machine ID:"
        lblMachineIDText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(4, 427)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 54)
        Label1.TabIndex = 7
        Label1.Text = "Machine Status:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        TableLayoutPanel1.SetColumnSpan(lblTransactionID, 2)
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Location = New Point(4, 481)
        lblTransactionID.Margin = New Padding(4, 0, 4, 0)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(349, 52)
        lblTransactionID.TabIndex = 8
        lblTransactionID.Text = "Transaction ID:"
        lblTransactionID.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Location = New Point(182, 427)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(171, 54)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "MachineCard"
        Size = New Size(357, 533)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblWeightText As Label
    Friend WithEvents picMachine As PictureBox
    Friend WithEvents lblMachineIDText As Label
    Friend WithEvents lblWeightValue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblStatus As Label

End Class
