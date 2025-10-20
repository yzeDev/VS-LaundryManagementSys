Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class newTransactionsControl
    Private transactionData As New DataTable()

    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataGridView()

        ' Setup filters
        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter.ValueChanged, AddressOf ApplyFilters
        AddHandler toggleDate.CheckedChanged, AddressOf ApplyFilters

        ' Load data
        LoadTransactions()
    End Sub

    Private Sub InitializeDataGridView()
        ' Configure Guna2DataGridView for modern look
        With dgvTransactions
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
            .ThemeStyle.AlternatingRowsStyle.Font = New Font("Poppins", 9)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(71, 69, 94)
            .ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(220, 235, 252)
            .ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94)

            ' Header Style — clean white minimal design
            .ThemeStyle.HeaderStyle.BackColor = Color.White
            .ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
            .ThemeStyle.HeaderStyle.Font = New Font("Poppins", 9, FontStyle.Regular)
            .ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(64, 64, 64)
            .ThemeStyle.HeaderStyle.Height = 40
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .EnableHeadersVisualStyles = False

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
            .ThemeStyle.RowsStyle.Font = New Font("Poppins", 9)
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
        End With

        ' Handle events
        AddHandler dgvTransactions.CellDoubleClick, AddressOf dgvTransactions_CellDoubleClick
        AddHandler dgvTransactions.CellContentClick, AddressOf dgvTransactions_CellContentClick
    End Sub

    Private Sub AddViewButtonColumn()
        ' Prevent duplicate button column
        If dgvTransactions.Columns.Contains("btnView") Then Return

        Dim btnColumn As New DataGridViewButtonColumn With {
            .Name = "btnView",
            .HeaderText = "ACTION",
            .Text = "View",
            .UseColumnTextForButtonValue = True,
            .Width = 80,
            .FillWeight = 15,
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        }
        dgvTransactions.Columns.Add(btnColumn)
    End Sub

    Private Sub LoadTransactions()
        ' Ensure the path is correct and accessible by your application
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Try
            'Debug.WriteLine("DEBUG >>> Starting LoadTransactions()")
            transactionData.Clear()
            dgvTransactions.SuspendLayout()

            Using conn As New OleDbConnection(connStr)
                'Debug.WriteLine("DEBUG >>> Opening connection to database...")
                conn.Open()
                'MessageBox.Show("Connected successfully to database!", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Verify that the table exists
                Dim schemaTable As DataTable = conn.GetSchema("Tables")
                Dim tableExists = schemaTable.AsEnumerable().Any(Function(r) r("TABLE_NAME").ToString().ToLower() = "transactions")
                If Not tableExists Then
                    MessageBox.Show("DEBUG >>> 'Transactions' table not found in the database!", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Test query
                Dim query As String = "SELECT [TransactionID], [CustomerName], [ServiceType], [Status], [MachineUsed], [TransactionDate], [TotalPayment] FROM Transactions ORDER BY TransactionDate DESC"
                'Debug.WriteLine("DEBUG >>> Query: " & query)

                Using cmd As New OleDbCommand(query, conn)
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(transactionData)
                    End Using
                End Using
            End Using

            ' Show how many rows were loaded
            'Debug.WriteLine("DEBUG >>> Rows loaded: " & transactionData.Rows.Count)
            'MessageBox.Show("DEBUG >>> Rows loaded: " & transactionData.Rows.Count, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' List column names found in DataTable
            Dim colList As String = String.Join(Environment.NewLine, transactionData.Columns.Cast(Of DataColumn).Select(Function(c) c.ColumnName))
            'MessageBox.Show("DEBUG >>> Columns found:" & Environment.NewLine & colList, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' If zero rows, stop here
            If transactionData.Rows.Count = 0 Then
                MessageBox.Show("No transactions found. The query returned 0 rows.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Bind data to grid
            dgvTransactions.DataSource = transactionData

            ' Disable sorting for all columns
            For Each col As DataGridViewColumn In dgvTransactions.Columns
                col.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            ' Debug: show bound row count after binding
            'MessageBox.Show("DEBUG >>> Rows shown in DataGridView: " & dgvTransactions.Rows.Count, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Add button AFTER binding
            AddViewButtonColumn()

            ' Safe column configuration
            If dgvTransactions.Columns.Contains("TransactionID") Then
                Debug.WriteLine("DEBUG >>> Columns exist, applying headers and styles...")
                With dgvTransactions
                    .Columns("TransactionID").HeaderText = "ORDER ID"
                    .Columns("TransactionID").FillWeight = 15
                    .Columns("TransactionID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("CustomerName").HeaderText = "CUSTOMER"
                    .Columns("CustomerName").FillWeight = 30

                    .Columns("ServiceType").HeaderText = "SERVICE"
                    .Columns("ServiceType").FillWeight = 20
                    .Columns("ServiceType").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("Status").HeaderText = "STATUS"
                    .Columns("Status").FillWeight = 15
                    .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("MachineUsed").HeaderText = "MACHINE"
                    .Columns("MachineUsed").FillWeight = 20
                    .Columns("MachineUsed").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("TransactionDate").HeaderText = "DATE"
                    .Columns("TransactionDate").FillWeight = 15
                    .Columns("TransactionDate").DefaultCellStyle.Format = "MM/dd/yyyy"
                    .Columns("TransactionDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns("TotalPayment").HeaderText = "TOTAL"
                    .Columns("TotalPayment").FillWeight = 15
                    .Columns("TotalPayment").DefaultCellStyle.Format = "₱#,##0.00"
                    .Columns("TotalPayment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
            Else
                MessageBox.Show("DEBUG >>> Column 'TransactionID' not found in result!", "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            ' Filters & finish
            PopulateStatusFilter()
            ApplyFilters()

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dgvTransactions.ResumeLayout()
            'Debug.WriteLine("DEBUG >>> Finished LoadTransactions()")
        End Try
    End Sub


    Private Sub PopulateStatusFilter()
        cmbStatus.BeginUpdate()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All")

        Dim statuses = transactionData.AsEnumerable() _
            .Select(Function(row) row.Field(Of String)("Status")) _
            .Where(Function(s) Not String.IsNullOrWhiteSpace(s)) _
            .Distinct() _
            .OrderBy(Function(s) s)

        For Each status In statuses
            cmbStatus.Items.Add(status)
        Next

        cmbStatus.SelectedIndex = 0
        cmbStatus.EndUpdate()
    End Sub

    Private Sub ApplyFilters()
        If transactionData Is Nothing OrElse transactionData.Rows.Count = 0 Then Return

        Dim searchTerm As String = tbSearch.Text.Trim().ToLower()
        Dim statusSelected As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "All")
        Dim dateFiltering As Boolean = Not toggleDate.Checked
        Dim selectedDate As Date = If(dateFiltering, dtpDateFilter.Value.Date, Date.MinValue)

        Dim filterParts As New List(Of String)

        If statusSelected <> "All" Then
            filterParts.Add($"Status = '{statusSelected.Replace("'", "''")}'")
        End If

        If Not String.IsNullOrEmpty(searchTerm) Then
            Dim searchFilter = $"(CustomerName LIKE '%{searchTerm.Replace("'", "''")}%' OR " &
                               $"ServiceType LIKE '%{searchTerm.Replace("'", "''")}%' OR " &
                               $"MachineUsed LIKE '%{searchTerm.Replace("'", "''")}%')"
            filterParts.Add(searchFilter)
        End If

        If dateFiltering Then
            filterParts.Add($"TransactionDate >= #{selectedDate:MM/dd/yyyy}# AND TransactionDate < #{selectedDate.AddDays(1):MM/dd/yyyy}#")
        End If

        Try
            transactionData.DefaultView.RowFilter = String.Join(" AND ", filterParts)
        Catch ex As Exception
            MessageBox.Show("Filter error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvTransactions_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTransactions.CellFormatting
        If dgvTransactions.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Select Case e.Value.ToString().ToLower()
                Case "pending" : e.CellStyle.ForeColor = Color.DarkGoldenrod
                Case "in-progress" : e.CellStyle.ForeColor = Color.DodgerBlue
                Case "for pickup" : e.CellStyle.ForeColor = Color.MediumSlateBlue
                Case "for delivery" : e.CellStyle.ForeColor = Color.DarkOrange
                Case "completed" : e.CellStyle.ForeColor = Color.ForestGreen
                Case "refunded" : e.CellStyle.ForeColor = Color.Crimson
            End Select
        End If
    End Sub


    Private Sub dgvTransactions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellDoubleClick
        If e.RowIndex >= 0 AndAlso dgvTransactions.Columns(e.ColumnIndex).Name <> "btnView" Then
            OpenTransactionView(e.RowIndex)
        End If
    End Sub

    Private Sub dgvTransactions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactions.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvTransactions.Columns(e.ColumnIndex).Name = "btnView" Then
            OpenTransactionView(e.RowIndex)
        End If
    End Sub

    Private Sub OpenTransactionView(rowIndex As Integer)
        Try
            Dim transactionId As Integer = CInt(dgvTransactions.Rows(rowIndex).Cells("TransactionID").Value)
            Dim viewForm As New TransactionForm With {
                .TransactionId = transactionId,
                .Mode = "View"
            }
            viewForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error opening transaction: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class