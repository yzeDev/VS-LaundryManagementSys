Imports System.Data.OleDb

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

    End Sub

    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        Using conn As New OleDbConnection(connStr)
            Try
                conn.Open()

                Dim sql As String = "SELECT TransactionID as [Transaction ID], CustomerName as [Customer Name], ServiceType as [Service Type], Status, MachineUsed as [Machine Used], TransactionDate as [Transaction Date], TotalPayment as [Total Payment] FROM Transactions"
                Dim adapter As New OleDbDataAdapter(sql, conn)

                ' ✅ Use the class-level dt, not a new local one
                dt = New DataTable()
                adapter.Fill(dt)

                ' ✅ Create DataView from dt
                dv = New DataView(dt)

                ' ✅ Bind DataGridView to dv (not dt)
                dgvTransactionsData.DataSource = dv

                ' ✅ Formatting
                dgvTransactionsData.ReadOnly = True
                dgvTransactionsData.AllowUserToAddRows = False
                dgvTransactionsData.AllowUserToDeleteRows = False
                dgvTransactionsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' ✅ Disable sorting
                For Each col As DataGridViewColumn In dgvTransactionsData.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading transactions: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub dgvTransactionsData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsData.CellContentClick
        ' Check if View button was clicked
        If e.ColumnIndex >= 0 AndAlso dgvTransactionsData.Columns(e.ColumnIndex).Name = "btnView" AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTransactionsData.Rows(e.RowIndex)

            ' Example: grab row data
            Dim transactionId As Integer = Convert.ToInt32(row.Cells("Transaction ID").Value)
            Dim customerName As String = row.Cells("Customer Name").Value.ToString()
            Dim serviceType As String = row.Cells("Service Type").Value.ToString()
            Dim status As String = row.Cells("Status").Value.ToString()
            Dim machineUsed As String = row.Cells("Machine Used").Value.ToString()
            Dim transDate As Date = Convert.ToDateTime(row.Cells("Transaction Date").Value)
            Dim totalPayment As Decimal = Convert.ToDecimal(row.Cells("Total Payment").Value)

            ' Open a pop-up form and pass details
            Dim detailsForm As New TransactionDetailsForm(transactionId, customerName, serviceType, status, machineUsed, transDate, totalPayment)
            detailsForm.ShowDialog()
        End If
    End Sub

    Private Sub dgvTransactionsData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsData.CellClick
        ' Allow only the "View" button to be clickable
        If e.RowIndex >= 0 AndAlso dgvTransactionsData.Columns(e.ColumnIndex).Name <> "btnView" Then
            dgvTransactionsData.ClearSelection()   ' remove highlight
        End If
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        ApplyFilters()
    End Sub
    Private Sub ApplyFilters()
        If dv Is Nothing Then Return

        Dim filterParts As New List(Of String)

        ' --- Filter by Status ---
        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
            filterParts.Add("Status = '" & cmbStatus.SelectedItem.ToString().Replace("'", "''") & "'")
        End If

        ' --- Filter by Search ---
        If tbSearch.Text.Trim() <> "" Then
            Dim searchText As String = tbSearch.Text.Replace("'", "''")  ' keep original case

            If cmbFilter.SelectedItem IsNot Nothing Then
                ' ✅ Search only in the selected column
                Dim colName As String = cmbFilter.SelectedItem.ToString()
                filterParts.Add("[" & colName & "] LIKE '%" & searchText & "%'")
            Else
                ' ✅ Search in ALL string columns instead
                Dim searchParts As New List(Of String)
                For Each col As DataColumn In dt.Columns
                    If col.DataType Is GetType(String) Then
                        searchParts.Add("[" & col.ColumnName & "] LIKE '%" & searchText & "%'")
                    End If
                Next
                If searchParts.Count > 0 Then
                    filterParts.Add("(" & String.Join(" OR ", searchParts) & ")")
                End If
            End If
        End If

        ' --- Apply combined filter ---
        dv.RowFilter = String.Join(" AND ", filterParts)

        ' --- Optional: Sort by Status ---
        If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
            dv.Sort = "Status ASC"
        Else
            dv.Sort = ""
        End If

        ' Debug
        Console.WriteLine("Applied Filter: " & dv.RowFilter)
    End Sub

End Class
