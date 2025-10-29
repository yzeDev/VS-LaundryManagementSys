<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentDetails))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        cancelBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        confirmBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Panel1 = New Panel()
        Label1 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        amountPaidBox = New Guna.UI2.WinForms.Guna2TextBox()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 1)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 1.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 53.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 23.0F))
        TableLayoutPanel1.Size = New Size(400, 220)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Controls.Add(cancelBtn, 0, 0)
        TableLayoutPanel3.Controls.Add(confirmBtn, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(15, 168)
        TableLayoutPanel3.Margin = New Padding(15, 0, 15, 15)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(370, 37)
        TableLayoutPanel3.TabIndex = 10
        ' 
        ' cancelBtn
        ' 
        cancelBtn.BorderRadius = 5
        cancelBtn.CustomizableEdges = CustomizableEdges1
        cancelBtn.DisabledState.BorderColor = Color.DarkGray
        cancelBtn.DisabledState.CustomBorderColor = Color.DarkGray
        cancelBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancelBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cancelBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        cancelBtn.Dock = DockStyle.Left
        cancelBtn.FillColor = Color.DimGray
        cancelBtn.FillColor2 = Color.Gray
        cancelBtn.Font = New Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cancelBtn.ForeColor = Color.White
        cancelBtn.Image = CType(resources.GetObject("cancelBtn.Image"), Image)
        cancelBtn.ImageAlign = HorizontalAlignment.Left
        cancelBtn.ImageSize = New Size(15, 15)
        cancelBtn.Location = New Point(3, 3)
        cancelBtn.Margin = New Padding(3, 3, 7, 3)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cancelBtn.Size = New Size(153, 31)
        cancelBtn.TabIndex = 1
        cancelBtn.Text = "     Cancel"
        ' 
        ' confirmBtn
        ' 
        confirmBtn.BorderRadius = 5
        confirmBtn.CustomizableEdges = CustomizableEdges3
        confirmBtn.DisabledState.BorderColor = Color.DarkGray
        confirmBtn.DisabledState.CustomBorderColor = Color.DarkGray
        confirmBtn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        confirmBtn.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        confirmBtn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        confirmBtn.Dock = DockStyle.Right
        confirmBtn.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        confirmBtn.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        confirmBtn.Font = New Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        confirmBtn.ForeColor = Color.White
        confirmBtn.Image = CType(resources.GetObject("confirmBtn.Image"), Image)
        confirmBtn.ImageAlign = HorizontalAlignment.Left
        confirmBtn.ImageSize = New Size(14, 14)
        confirmBtn.Location = New Point(214, 3)
        confirmBtn.Margin = New Padding(7, 3, 3, 3)
        confirmBtn.Name = "confirmBtn"
        confirmBtn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        confirmBtn.Size = New Size(153, 31)
        confirmBtn.TabIndex = 0
        confirmBtn.Text = "     Confirm"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(15, 53)
        Panel1.Margin = New Padding(15, 3, 15, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(370, 1)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(15, 15)
        Label1.Margin = New Padding(15)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 20)
        Label1.TabIndex = 3
        Label1.Text = "Payment Details"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 57.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 43.0F))
        TableLayoutPanel2.Controls.Add(amountPaidBox, 1, 0)
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(15, 87)
        TableLayoutPanel2.Margin = New Padding(15, 35, 15, 35)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Size = New Size(370, 46)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' amountPaidBox
        ' 
        amountPaidBox.CustomizableEdges = CustomizableEdges5
        amountPaidBox.DefaultText = ""
        amountPaidBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        amountPaidBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        amountPaidBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        amountPaidBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        amountPaidBox.Dock = DockStyle.Fill
        amountPaidBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        amountPaidBox.Font = New Font("Poppins", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amountPaidBox.ForeColor = Color.Black
        amountPaidBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        amountPaidBox.Location = New Point(214, 5)
        amountPaidBox.Margin = New Padding(4, 5, 4, 5)
        amountPaidBox.Name = "amountPaidBox"
        amountPaidBox.PlaceholderText = ""
        amountPaidBox.SelectedText = ""
        amountPaidBox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        amountPaidBox.Size = New Size(152, 36)
        amountPaidBox.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 46)
        Label2.TabIndex = 4
        Label2.Text = "Amount To Pay:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PaymentDetails
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 220)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PaymentDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "transacCancelConfirm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents confirmBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents amountPaidBox As Guna.UI2.WinForms.Guna2TextBox
End Class
