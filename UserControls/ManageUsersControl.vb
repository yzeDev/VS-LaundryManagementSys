Imports System.Data.OleDb

Public Class ManageUsersControl

    Private dt As DataTable

    Private Sub ManageUsersControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataGridView()
        LoadEmployees()
        AddHandler gtbSearch.TextChanged, AddressOf gtbSearch_TextChanged
    End Sub

    Private Sub InitializeDataGridView()
        ' Configure Guna2DataGridView for modern look
        With dgdvUsers
            ' Disable visual row selection highlight
            .ClearSelection()
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.SelectionBackColor = Color.White
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(71, 69, 94)

            ' Prevent the column header from highlighting when clicked
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64)
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default
            .ThemeStyle.BackColor = Color.White
            ' Theme & Colors
            '.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(250, 252, 253)
            .ThemeStyle.AlternatingRowsStyle.Font = New Font("Poppins", 12)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(71, 69, 94)
            .ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(220, 235, 252)
            .ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94)

            ' Header Style — clean white minimal design
            .ThemeStyle.HeaderStyle.BackColor = Color.White
            .ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
            .ThemeStyle.HeaderStyle.Font = New Font("Poppins", 12, FontStyle.Regular)
            .ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64)
            .ThemeStyle.HeaderStyle.Height = 40
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False

            With dgdvUsers
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            End With


            ' Remove all dividers except bottom line
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
            .AdvancedColumnHeadersBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single

            ' Make bottom divider soft gray
            .GridColor = Color.FromArgb(230, 230, 230)
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .BackgroundColor = Color.White


            ' Row Style
            .ThemeStyle.RowsStyle.BackColor = Color.White
            .ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .ThemeStyle.RowsStyle.Font = New Font("Poppins", 12)
            .ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94)
            .ThemeStyle.RowsStyle.Height = 45
            .ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(220, 235, 252)
            .ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94)

            ' Grid Behavior
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(231, 229, 255)
            .BackgroundColor = Color.White
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Performance
            '.DoubleBuffered = True
            .VirtualMode = False ' Set to True for 1000+ rows with custom data management

            AddHandler .ColumnAdded, Sub(s, e)
                                         e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
                                     End Sub
        End With

    End Sub

    Private Sub LoadEmployees()
        Try
            Using conn As New OleDbConnection(Db.ConnectionString)
                conn.Open()

                Dim query As String = "SELECT EmployeeID, EmployeeName, UserRole FROM Employees"
                Dim adapter As New OleDbDataAdapter(query, conn)
                dt = New DataTable()
                adapter.Fill(dt)

                ' === ASSIGN TO DATAGRIDVIEW ===
                dgdvUsers.DataSource = dt

                ' === CUSTOM HEADER TEXTS ===
                If dgdvUsers.Columns.Contains("EmployeeID") Then
                    dgdvUsers.Columns("EmployeeID").HeaderText = "Employee ID"
                End If
                If dgdvUsers.Columns.Contains("EmployeeName") Then
                    dgdvUsers.Columns("EmployeeName").HeaderText = "Full Name"
                End If
                If dgdvUsers.Columns.Contains("UserRole") Then
                    dgdvUsers.Columns("UserRole").HeaderText = "User Role"
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    Private Sub gtbSearch_TextChanged(sender As Object, e As EventArgs)
        Try
            If dt Is Nothing Then Exit Sub

            Dim dv As DataView = dt.DefaultView
            Dim filterText As String = gtbSearch.Text.Trim().Replace("'", "''")

            If filterText = "" Then
                dv.RowFilter = ""
            Else
                ' Match EmployeeName or UserRole columns
                dv.RowFilter = $"EmployeeName LIKE '%{filterText}%' OR UserRole LIKE '%{filterText}%'"
            End If

            dgdvUsers.DataSource = dv

        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message)
        End Try
    End Sub

End Class
