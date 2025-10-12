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
        picMachine = New PictureBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblUnit = New Label()
        lblMachineIDText = New Label()
        lblTransactionID = New Label()
        lblWeightText = New Label()
        lblWeightValue = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStatus = New Label()
        Button1 = New Button()
        Button2 = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(picMachine, 0, 1)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 1)
        TableLayoutPanel1.Controls.Add(lblStatus, 1, 0)
        TableLayoutPanel1.Controls.Add(Button1, 0, 2)
        TableLayoutPanel1.Controls.Add(Button2, 1, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 83.40284F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.59716F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(400, 300)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' picMachine
        ' 
        picMachine.Dock = DockStyle.Fill
        picMachine.Location = New Point(3, 33)
        picMachine.Name = "picMachine"
        picMachine.Size = New Size(194, 219)
        picMachine.TabIndex = 4
        picMachine.TabStop = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(lblUnit, 0, 0)
        TableLayoutPanel2.Controls.Add(lblTransactionID, 0, 2)
        TableLayoutPanel2.Controls.Add(lblMachineIDText, 0, 1)
        TableLayoutPanel2.Controls.Add(lblWeightText, 0, 3)
        TableLayoutPanel2.Controls.Add(lblWeightValue, 1, 3)
        TableLayoutPanel2.Controls.Add(Label1, 0, 4)
        TableLayoutPanel2.Controls.Add(Label2, 1, 4)
        TableLayoutPanel2.Controls.Add(Label3, 0, 5)
        TableLayoutPanel2.Controls.Add(Label4, 1, 5)
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
        TableLayoutPanel2.Size = New Size(194, 219)
        TableLayoutPanel2.TabIndex = 10
        ' 
        ' lblUnit
        ' 
        TableLayoutPanel2.SetColumnSpan(lblUnit, 2)
        lblUnit.Dock = DockStyle.Fill
        lblUnit.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUnit.Location = New Point(3, 0)
        lblUnit.Name = "lblUnit"
        lblUnit.Size = New Size(188, 36)
        lblUnit.TabIndex = 0
        lblUnit.Text = "Unit"
        ' 
        ' lblMachineIDText
        ' 
        lblMachineIDText.AutoSize = True
        TableLayoutPanel2.SetColumnSpan(lblMachineIDText, 2)
        lblMachineIDText.Dock = DockStyle.Fill
        lblMachineIDText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMachineIDText.Location = New Point(3, 36)
        lblMachineIDText.Name = "lblMachineIDText"
        lblMachineIDText.Size = New Size(188, 36)
        lblMachineIDText.TabIndex = 5
        lblMachineIDText.Text = "Machine ID:"
        lblMachineIDText.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTransactionID
        ' 
        lblTransactionID.AutoSize = True
        TableLayoutPanel2.SetColumnSpan(lblTransactionID, 2)
        lblTransactionID.Dock = DockStyle.Fill
        lblTransactionID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTransactionID.Location = New Point(3, 72)
        lblTransactionID.Name = "lblTransactionID"
        lblTransactionID.Size = New Size(188, 36)
        lblTransactionID.TabIndex = 8
        lblTransactionID.Text = "Transaction ID:"
        lblTransactionID.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblWeightText
        ' 
        lblWeightText.AutoSize = True
        lblWeightText.Dock = DockStyle.Fill
        lblWeightText.Location = New Point(3, 108)
        lblWeightText.Name = "lblWeightText"
        lblWeightText.Size = New Size(91, 36)
        lblWeightText.TabIndex = 2
        lblWeightText.Text = "Max W. Capacity:"
        lblWeightText.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWeightValue
        ' 
        lblWeightValue.AutoSize = True
        lblWeightValue.Dock = DockStyle.Fill
        lblWeightValue.Location = New Point(100, 108)
        lblWeightValue.Name = "lblWeightValue"
        lblWeightValue.Size = New Size(91, 36)
        lblWeightValue.TabIndex = 6
        lblWeightValue.Text = "Weight:"
        lblWeightValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 9.75F)
        Label1.Location = New Point(3, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 36)
        Label1.TabIndex = 9
        Label1.Text = "Time Started:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(100, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 36)
        Label2.TabIndex = 10
        Label2.Text = "time"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(3, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 39)
        Label3.TabIndex = 11
        Label3.Text = "Est. Completion:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(100, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 39)
        Label4.TabIndex = 12
        Label4.Text = "time complete"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(203, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(194, 30)
        lblStatus.TabIndex = 9
        lblStatus.Text = "Status"
        lblStatus.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Location = New Point(3, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 39)
        Button1.TabIndex = 11
        Button1.Text = "Configure"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Fill
        Button2.Location = New Point(203, 258)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 39)
        Button2.TabIndex = 12
        Button2.Text = "View Details"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MachineCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(TableLayoutPanel1)
        Name = "MachineCard"
        Size = New Size(400, 300)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(picMachine, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblWeightText As Label
    Friend WithEvents picMachine As PictureBox
    Friend WithEvents lblMachineIDText As Label
    Friend WithEvents lblWeightValue As Label
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
