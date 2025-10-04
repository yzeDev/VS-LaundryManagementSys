Imports System.Data.OleDb
Imports System.Globalization

Public Class TransactionsControl

    Private dt As DataTable
    Private dv As DataView

    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()

        ' Add "View" button column if not already added
        If dgvTransactionsData.Columns("btnView") Is Nothing Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "btnView"
            btnCol.HeaderText = "Action"
            btnCol.Text = "View"
            btnCol.UseColumnTextForButtonValue = True
            dgvTransactionsData.Columns.Add(btnCol)
        End If
        dgvTransactionsData.ReadOnly = True
        dgvTransactionsData.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactionsData.DefaultCellStyle.SelectionBackColor = dgvTransactionsData.DefaultCellStyle.BackColor
        dgvTransactionsData.DefaultCellStyle.SelectionForeColor = dgvTransactionsData.DefaultCellStyle.ForeColor
        dgvTransactionsData.RowHeadersVisible = False

        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter.ValueChanged, AddressOf ApplyFilters
        AddHandler chkAllDates.CheckedChanged, AddressOf ApplyFilters


    End Sub

    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connStr)
            Try
                conn.Open()

                Dim sql As String = "SELECT TransactionID as [Transaction ID], CustomerName as [Customer Name], ServiceType as [Service Type], Status, MachineUsed as [Machine Used], TransactionDate as [Transaction Date], TotalPayment as [Total Payment] FROM Transactions"
                Dim adapter As New OleDbDataAdapter(sql, conn)

                ' Use class-level dt so ApplyFilters can use it
                dt = New DataTable()
                adapter.Fill(dt)

                ' Wrap in DataView and bind
                dv = New DataView(dt)
                dgvTransactionsData.DataSource = dv

                ' Formatting
                dgvTransactionsData.ReadOnly = True
                dgvTransactionsData.AllowUserToAddRows = False
                dgvTransactionsData.AllowUserToDeleteRows = False
                dgvTransactionsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Disable sorting
                For Each col As DataGridViewColumn In dgvTransactionsData.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                ' ---------------------
                ' Populate cmbStatus with distinct status values (and "All")
                ' ---------------------
                cmbStatus.Items.Clear()
                cmbStatus.Items.Add("All")
                Try
                    Dim distinctStatuses = dt.AsEnumerable() _
                    .Where(Function(r) Not IsDBNull(r("Status"))) _
                    .Select(Function(r) r.Field(Of String)("Status")) _
                    .Distinct().ToList()
                    For Each s In distinctStatuses
                        cmbStatus.Items.Add(s)
                    Next
                Catch
                    ' ignore if column missing or type mismatch
                End Try
                cmbStatus.SelectedIndex = 0
                ' Apply any filters that may already be set in UI
                ApplyFilters()
            Catch ex As Exception
                MessageBox.Show("Error loading transactions: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub dgvTransactionsData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsData.CellContentClick
        If e.ColumnIndex >= 0 AndAlso dgvTransactionsData.Columns(e.ColumnIndex).Name = "btnView" AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTransactionsData.Rows(e.RowIndex)

            Dim transactionId As Integer = Convert.ToInt32(row.Cells("Transaction ID").Value)
            Dim customerName As String = row.Cells("Customer Name").Value.ToString()
            Dim serviceType As String = row.Cells("Service Type").Value.ToString()
            Dim status As String = row.Cells("Status").Value.ToString()
            Dim machineUsed As String = row.Cells("Machine Used").Value.ToString()
            Dim transDate As Date = Convert.ToDateTime(row.Cells("Transaction Date").Value)
            Dim totalPayment As Decimal = Convert.ToDecimal(row.Cells("Total Payment").Value)

            Dim detailsForm As New TransactionDetailsForm(transactionId, customerName, serviceType, status, machineUsed, transDate, totalPayment)
            detailsForm.ShowDialog()
        End If
    End Sub

    Private Sub dgvTransactionsData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsData.CellClick
        If e.RowIndex >= 0 AndAlso dgvTransactionsData.Columns(e.ColumnIndex).Name <> "btnView" Then
            dgvTransactionsData.ClearSelection()
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub ApplyFilters()
        If dv Is Nothing OrElse dt Is Nothing Then Return

        Dim filterParts As New List(Of String)()

        ' --- 1) STATUS filter (exact match) ---
        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString().Trim() <> "" AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
            filterParts.Add("Status = '" & cmbStatus.SelectedItem.ToString().Replace("'", "''") & "'")
        End If


        ' --- 2) SEARCH (either specific column or all columns) ---
        Dim searchTextRaw As String = tbSearch.Text.Trim()
        If searchTextRaw <> "" Then
            Dim searchText As String = searchTextRaw.Replace("'", "''") ' escape single quotes

            ' No specific column selected -> search across all
            Dim searchParts As New List(Of String)
            For Each col As DataColumn In dt.Columns
                Dim colName As String = col.ColumnName
                Dim ct As Type = col.DataType

                If ct Is GetType(String) Then
                    searchParts.Add("[" & colName & "] LIKE '%" & searchText & "%'")
                ElseIf ct Is GetType(Integer) OrElse ct Is GetType(Long) _
               OrElse ct Is GetType(Decimal) OrElse ct Is GetType(Double) Then
                    If IsNumeric(searchText) Then
                        searchParts.Add("[" & colName & "] = " & searchText)
                    End If
                ElseIf ct Is GetType(DateTime) Then
                    Dim d As DateTime
                    If DateTime.TryParse(searchTextRaw, d) Then
                        Dim sD As Date = d.Date
                        Dim eD As Date = sD.AddDays(1)
                        searchParts.Add("([" & colName & "] >= #" & sD.ToString("MM/dd/yyyy") & "# AND [" & colName & "] < #" & eD.ToString("MM/dd/yyyy") & "#)")
                    End If
                End If
            Next

            If searchParts.Count > 0 Then
                filterParts.Add("(" & String.Join(" OR ", searchParts) & ")")
            End If
        End If


        ' --- 3) DATE filter using dtpDateFilter + chkAllDates ---
        If Not chkAllDates.Checked Then
            Dim selectedDate As Date = dtpDateFilter.Value.Date
            Dim nextDay As Date = selectedDate.AddDays(1)

            ' Transaction Date must be >= selectedDate and < nextDay
            filterParts.Add("[Transaction Date] >= #" & selectedDate.ToString("MM/dd/yyyy") & "# AND [Transaction Date] < #" & nextDay.ToString("MM/dd/yyyy") & "#")
        End If


        ' --- 4) Combine and apply ---
        Dim combinedFilter As String = If(filterParts.Count > 0, String.Join(" AND ", filterParts), String.Empty)
        Try
            dv.RowFilter = combinedFilter
        Catch ex As Exception
            ' Show the filter for debugging and fall back to no filter
            Debug.WriteLine("RowFilter failed: " & combinedFilter)
            MessageBox.Show("Filter error: " & ex.Message & vbCrLf & "Filter string: " & combinedFilter)
            dv.RowFilter = ""
        End Try

        ' Optional: sorting behavior (unchanged)
        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
            dv.Sort = "Status ASC"
        Else
            dv.Sort = ""
        End If

        ' Debug output
        Debug.WriteLine("Applied Filter: " & combinedFilter)
    End Sub

    Private Sub btnReloadData_Click(sender As Object, e As EventArgs) Handles btnReloadData.Click
        Try
            ' Reload from DB
            LoadTransactions()

            ' --- Reset filters ---
            cmbStatus.SelectedIndex = -1   ' Clear status filter
            tbSearch.Clear()               ' Clear search box
            dtpDateFilter.Value = Date.Today ' Reset date filter to today
            chkAllDates.Checked = True     ' Show all dates

            ' Clear DataView filter so all data shows
            If dv IsNot Nothing Then dv.RowFilter = ""

            MessageBox.Show("Data reloaded and filters reset.", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error while reloading data: " & ex.Message, "Reload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim popup As New TransactionOption()
        popup.ShowDialog() ' Shows it as a modal popup
    End Sub
End Class
