<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsControl
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        TableLayoutPanel1 = New TableLayoutPanel()
        guna2BtnPriceSettings = New Guna.UI2.WinForms.Guna2Button()
        guna2BtnPassword = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        panelDisplay = New Guna.UI2.WinForms.Guna2ContainerControl()
        TableLayoutPanel1.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(guna2BtnPriceSettings, 0, 1)
        TableLayoutPanel1.Controls.Add(guna2BtnPassword, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(193, 124)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' guna2BtnPriceSettings
        ' 
        guna2BtnPriceSettings.Anchor = AnchorStyles.Top
        guna2BtnPriceSettings.BorderRadius = 8
        guna2BtnPriceSettings.CustomizableEdges = CustomizableEdges1
        guna2BtnPriceSettings.DisabledState.BorderColor = Color.DarkGray
        guna2BtnPriceSettings.DisabledState.CustomBorderColor = Color.DarkGray
        guna2BtnPriceSettings.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        guna2BtnPriceSettings.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        guna2BtnPriceSettings.FillColor = Color.White
        guna2BtnPriceSettings.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guna2BtnPriceSettings.ForeColor = Color.DimGray
        guna2BtnPriceSettings.Location = New Point(17, 64)
        guna2BtnPriceSettings.Margin = New Padding(3, 2, 3, 2)
        guna2BtnPriceSettings.Name = "guna2BtnPriceSettings"
        guna2BtnPriceSettings.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        guna2BtnPriceSettings.Size = New Size(158, 36)
        guna2BtnPriceSettings.TabIndex = 9
        guna2BtnPriceSettings.Text = "Price Settings"
        ' 
        ' guna2BtnPassword
        ' 
        guna2BtnPassword.Anchor = AnchorStyles.Bottom
        guna2BtnPassword.BorderRadius = 8
        guna2BtnPassword.CustomizableEdges = CustomizableEdges3
        guna2BtnPassword.DisabledState.BorderColor = Color.DarkGray
        guna2BtnPassword.DisabledState.CustomBorderColor = Color.DarkGray
        guna2BtnPassword.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        guna2BtnPassword.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        guna2BtnPassword.FillColor = Color.DimGray
        guna2BtnPassword.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        guna2BtnPassword.ForeColor = Color.White
        guna2BtnPassword.Location = New Point(17, 24)
        guna2BtnPassword.Margin = New Padding(3, 2, 3, 2)
        guna2BtnPassword.Name = "guna2BtnPassword"
        guna2BtnPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        guna2BtnPassword.Size = New Size(158, 36)
        guna2BtnPassword.TabIndex = 8
        guna2BtnPassword.Text = "Password"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.Controls.Add(TableLayoutPanel1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges5
        Guna2Panel1.FillColor = Color.Transparent
        Guna2Panel1.ForeColor = Color.Transparent
        Guna2Panel1.Location = New Point(22, 19)
        Guna2Panel1.Margin = New Padding(3, 2, 3, 2)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel1.Size = New Size(193, 124)
        Guna2Panel1.TabIndex = 6
        ' 
        ' panelDisplay
        ' 
        panelDisplay.BorderRadius = 20
        panelDisplay.CustomizableEdges = CustomizableEdges7
        panelDisplay.Location = New Point(233, 43)
        panelDisplay.Margin = New Padding(0)
        panelDisplay.Name = "panelDisplay"
        panelDisplay.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        panelDisplay.Size = New Size(681, 507)
        panelDisplay.TabIndex = 7
        panelDisplay.Text = "Guna2ContainerControl1"
        ' 
        ' OptionsControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(241), CByte(241))
        Controls.Add(panelDisplay)
        Controls.Add(Guna2Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "OptionsControl"
        Size = New Size(935, 566)
        TableLayoutPanel1.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents guna2BtnPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents guna2BtnPriceSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelDisplay As Guna.UI2.WinForms.Guna2ContainerControl

End Class
