<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class confirmpayment
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label4 = New Label()
        btnsave = New Guna.UI2.WinForms.Guna2GradientButton()
        referencetb = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Label2 = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Guna2GradientPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel1, 0, 1)
        TableLayoutPanel2.Controls.Add(Guna2GradientPanel1, 0, 0)
        TableLayoutPanel2.Location = New Point(2, -1)
        TableLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 12.02046F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 87.97954F))
        TableLayoutPanel2.Size = New Size(450, 276)
        TableLayoutPanel2.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Label4, 0, 2)
        TableLayoutPanel1.Controls.Add(btnsave, 0, 4)
        TableLayoutPanel1.Controls.Add(referencetb, 0, 3)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TableLayoutPanel1.Location = New Point(3, 35)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 83.67347F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.32653F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 31F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 95F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 43F))
        TableLayoutPanel1.Size = New Size(444, 230)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Poppins", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(3, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(438, 31)
        Label4.TabIndex = 2
        Label4.Text = "Reference Number: "
        Label4.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' btnsave
        ' 
        btnsave.Anchor = AnchorStyles.None
        btnsave.BorderRadius = 5
        btnsave.CustomizableEdges = CustomizableEdges1
        btnsave.DisabledState.BorderColor = Color.DarkGray
        btnsave.DisabledState.CustomBorderColor = Color.DarkGray
        btnsave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsave.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsave.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        btnsave.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        btnsave.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(169, 197)
        btnsave.Margin = New Padding(3, 2, 3, 2)
        btnsave.Name = "btnsave"
        btnsave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnsave.Size = New Size(105, 22)
        btnsave.TabIndex = 37
        btnsave.Text = "SAVE"
        ' 
        ' referencetb
        ' 
        referencetb.BorderRadius = 5
        referencetb.CustomizableEdges = CustomizableEdges3
        referencetb.DefaultText = ""
        referencetb.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        referencetb.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        referencetb.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        referencetb.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        referencetb.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        referencetb.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        referencetb.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        referencetb.Location = New Point(9, 95)
        referencetb.Margin = New Padding(9, 4, 9, 4)
        referencetb.Name = "referencetb"
        referencetb.PlaceholderText = ""
        referencetb.SelectedText = ""
        referencetb.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        referencetb.Size = New Size(423, 26)
        referencetb.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F)
        Label3.ForeColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(406, 44)
        Label3.TabIndex = 9
        Label3.Text = "Enter the reference number provided by the customer to verify their GCash or PayMaya transaction."
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Guna2GradientPanel1
        ' 
        Guna2GradientPanel1.BorderStyle = Drawing2D.DashStyle.Dash
        Guna2GradientPanel1.Controls.Add(Label2)
        Guna2GradientPanel1.CustomizableEdges = CustomizableEdges5
        Guna2GradientPanel1.Dock = DockStyle.Fill
        Guna2GradientPanel1.FillColor = Color.FromArgb(CByte(13), CByte(67), CByte(188))
        Guna2GradientPanel1.FillColor2 = Color.FromArgb(CByte(76), CByte(102), CByte(232))
        Guna2GradientPanel1.Location = New Point(3, 2)
        Guna2GradientPanel1.Margin = New Padding(3, 2, 3, 2)
        Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Guna2GradientPanel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientPanel1.Size = New Size(444, 29)
        Guna2GradientPanel1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(144, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 28)
        Label2.TabIndex = 5
        Label2.Text = "Proof of Payment"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' confirmpayment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(453, 273)
        Controls.Add(TableLayoutPanel2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "confirmpayment"
        StartPosition = FormStartPosition.CenterParent
        Text = "confirmpayment"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Guna2GradientPanel1.ResumeLayout(False)
        Guna2GradientPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents referencetb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnsave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
