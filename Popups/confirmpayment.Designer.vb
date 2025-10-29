<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class confirmpayment
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel2 = New TableLayoutPanel()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        gtbAmountPaid = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        referencetb = New Guna.UI2.WinForms.Guna2TextBox()
        Panel1 = New Panel()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        btncancel = New Guna.UI2.WinForms.Guna2GradientButton()
        lblAmountToPay = New Label()
        TableLayoutPanel2.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Guna2GradientPanel1, 0, 0)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(560, 420)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BorderStyle = Drawing2D.DashStyle.Dash
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges1
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.Location = New Point(3, 2)
        Guna2GradientPanel1.Margin = New Padding(3, 2, 3, 2)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2GradientPanel1.Size = New Size(554, 56)
        Guna2GradientPanel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(554, 56)
        Label2.TabIndex = 5
        Label2.Text = "Proof of Payment"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(lblAmountToPay, 0, 1)
        TableLayoutPanel1.Controls.Add(gtbAmountPaid, 0, 5)
        TableLayoutPanel1.Controls.Add(Label1, 0, 4)
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(referencetb, 0, 3)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 6)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(3, 62)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 7
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40F))
        TableLayoutPanel1.Size = New Size(554, 356)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' gtbAmountPaid
        ' 
        gtbAmountPaid.BorderRadius = 5
        gtbAmountPaid.CustomizableEdges = CustomizableEdges3
        gtbAmountPaid.DefaultText = ""
        gtbAmountPaid.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        gtbAmountPaid.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        gtbAmountPaid.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbAmountPaid.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        gtbAmountPaid.Dock = DockStyle.Fill
        gtbAmountPaid.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbAmountPaid.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gtbAmountPaid.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        gtbAmountPaid.Location = New Point(0, 260)
        gtbAmountPaid.Margin = New Padding(0)
        gtbAmountPaid.Name = "gtbAmountPaid"
        gtbAmountPaid.PlaceholderText = "Amount Paid"
        gtbAmountPaid.SelectedText = ""
        gtbAmountPaid.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        gtbAmountPaid.Size = New Size(554, 50)
        gtbAmountPaid.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Poppins", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(548, 50)
        Label1.TabIndex = 12
        Label1.Text = "Amount Paid:"
        Label1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Poppins", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(548, 40)
        Label4.TabIndex = 2
        Label4.Text = "Reference Number: "
        Label4.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(535, 68)
        Label3.TabIndex = 9
        Label3.Text = "Enter the reference number provided by the customer to verify their GCash or PayMaya transaction."
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' referencetb
        ' 
        referencetb.BorderRadius = 5
        referencetb.CustomizableEdges = CustomizableEdges5
        referencetb.DefaultText = ""
        referencetb.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        referencetb.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        referencetb.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        referencetb.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        referencetb.Dock = DockStyle.Fill
        referencetb.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        referencetb.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        referencetb.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        referencetb.Location = New Point(0, 160)
        referencetb.Margin = New Padding(0)
        referencetb.Name = "referencetb"
        referencetb.PlaceholderText = "Reference Number"
        referencetb.SelectedText = ""
        referencetb.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        referencetb.Size = New Size(554, 50)
        referencetb.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 310)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(554, 46)
        Panel1.TabIndex = 11
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(btnSave, 1, 0)
        TableLayoutPanel3.Controls.Add(btncancel, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.Padding = New Padding(5)
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(554, 46)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.BorderRadius = 5
        btnSave.CustomizableEdges = CustomizableEdges7
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.Dock = DockStyle.Left
        btnSave.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnSave.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnSave.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(280, 7)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnSave.Size = New Size(115, 32)
        btnSave.TabIndex = 39
        btnSave.Text = "SAVE"
        ' 
        ' btncancel
        ' 
        btncancel.BorderRadius = 5
        btncancel.CustomizableEdges = CustomizableEdges9
        btncancel.DisabledState.BorderColor = Color.DarkGray
        btncancel.DisabledState.CustomBorderColor = Color.DarkGray
        btncancel.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btncancel.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btncancel.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btncancel.Dock = DockStyle.Right
        btncancel.FillColor = Color.White
        btncancel.FillColor2 = Color.White
        btncancel.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btncancel.ForeColor = Color.Black
        btncancel.Location = New Point(159, 7)
        btncancel.Margin = New Padding(3, 2, 3, 2)
        btncancel.Name = "btncancel"
        btncancel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btncancel.Size = New Size(115, 32)
        btncancel.TabIndex = 38
        btncancel.Text = "CANCEL"
        ' 
        ' lblAmountToPay
        ' 
        lblAmountToPay.AutoSize = True
        lblAmountToPay.Dock = DockStyle.Fill
        lblAmountToPay.Font = New Font("Poppins", 15.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAmountToPay.Location = New Point(3, 80)
        lblAmountToPay.Name = "lblAmountToPay"
        lblAmountToPay.Size = New Size(548, 40)
        lblAmountToPay.TabIndex = 14
        lblAmountToPay.Text = "Amount to Pay: "
        lblAmountToPay.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' confirmpayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 420)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "confirmpayment"
        StartPosition = FormStartPosition.CenterParent
        Text = "confirmpayment"
        TableLayoutPanel2.ResumeLayout(False)
        Guna2GradientPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Panel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents referencetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btncancel As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents gtbAmountPaid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAmountToPay As Label
End Class
