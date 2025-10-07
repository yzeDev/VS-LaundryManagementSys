Imports System.Data.OleDb
Imports System.Globalization

Public Class TransactionsControl

    Private Sub flpTransactions_SizeChanged(sender As Object, e As EventArgs)
        For Each ctrl As Control In flpTransactions.Controls
            ctrl.Width = flpTransactions.ClientSize.Width - flpTransactions.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth
        Next
    End Sub


    ' No longer using DataGridView or DataView
    Private Sub TransactionsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactions()

        ' Hook up filter handlers
        AddHandler cmbStatus.SelectedIndexChanged, AddressOf ApplyFilters
        AddHandler tbSearch.TextChanged, AddressOf ApplyFilters
        AddHandler dtpDateFilter.ValueChanged, AddressOf ApplyFilters
        AddHandler chkAllDates.CheckedChanged, AddressOf ApplyFilters
        ' FlowLayoutPanel visual tweaks
        flpTransactions.FlowDirection = FlowDirection.TopDown
        flpTransactions.WrapContents = False
        flpTransactions.AutoScroll = True
        flpTransactions.Dock = DockStyle.Fill

        AddHandler flpTransactions.SizeChanged, AddressOf flpTransactions_SizeChanged
    End Sub

    ' -------------------------
    ' LOAD TRANSACTIONS
    ' -------------------------
    Private Sub LoadTransactions()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        flpTransactions.Controls.Clear()
        AddHeaderRow() ' Add header before rows

        Using conn As New OleDbConnection(connStr)
            conn.Open()
            Dim sql As String = "SELECT TransactionID, CustomerName, ServiceType, Status, MachineUsed, TransactionDate, TotalPayment FROM Transactions"
            Using cmd As New OleDbCommand(sql, conn)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim row As New TransactionRow()
                        row.SetData(
                            reader("TransactionID"),
                            reader("CustomerName").ToString(),
                            reader("ServiceType").ToString(),
                            reader("Status").ToString(),
                            reader("MachineUsed").ToString(),
                            Convert.ToDateTime(reader("TransactionDate")),
                            Convert.ToDecimal(reader("TotalPayment"))
                        )
                        flpTransactions.Controls.Add(row)
                    End While
                End Using
            End Using
        End Using

        ' Populate cmbStatus with distinct values + "All"
        PopulateStatusFilter()
    End Sub

    ' -------------------------
    ' FILTERS
    ' -------------------------
    Private Sub PopulateStatusFilter()
        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("All")

        Dim statuses As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                Dim row As TransactionRow = DirectCast(ctrl, TransactionRow)
                statuses.Add(row.lblStatus.Text)
            End If
        Next

        For Each s In statuses
            cmbStatus.Items.Add(s)
        Next

        cmbStatus.SelectedIndex = 0
    End Sub

    Private Sub ApplyFilters()
        For Each ctrl As Control In flpTransactions.Controls
            If TypeOf ctrl Is TransactionRow Then
                Dim row As TransactionRow = DirectCast(ctrl, TransactionRow)
                Dim visible As Boolean = True

                ' 1. Status Filter
                If cmbStatus.SelectedItem IsNot Nothing AndAlso cmbStatus.SelectedItem.ToString() <> "All" Then
                    If Not row.lblStatus.Text.Equals(cmbStatus.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase) Then
                        visible = False
                    End If
                End If

                ' 2. Search Filter
                Dim searchTerm As String = tbSearch.Text.Trim().ToLower()
                If visible AndAlso searchTerm <> "" Then
                    Dim match As Boolean =
                        row.lblCustomer.Text.ToLower().Contains(searchTerm) _
                        OrElse row.lblServiceType.Text.ToLower().Contains(searchTerm) _
                        OrElse row.lblMachine.Text.ToLower().Contains(searchTerm)
                    visible = match
                End If

                ' 3. Date Filter
                If visible AndAlso Not chkAllDates.Checked Then
                    Dim selectedDate As Date = dtpDateFilter.Value.Date
                    Dim rowDate As Date = Date.Parse(row.lblDate.Text).Date
                    visible = (rowDate = selectedDate)
                End If

                row.Visible = visible
            End If
        Next
    End Sub

    ' -------------------------
    ' BUTTONS
    ' -------------------------
    Private Sub btnReloadData_Click(sender As Object, e As EventArgs)
        Try
            LoadTransactions()
            cmbStatus.SelectedIndex = 0
            tbSearch.Clear()
            dtpDateFilter.Value = Date.Today
            chkAllDates.Checked = True
            MessageBox.Show("Data reloaded and filters reset.", "Reload", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while reloading data: " & ex.Message, "Reload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim popup As New TransactionOption()
        popup.ShowDialog()
    End Sub

    ' -------------------------
    ' HEADER ROW
    ' -------------------------
    Private Sub AddHeaderRow()
        Dim header As New Panel With {
            .Height = 35,
            .Dock = DockStyle.Top,
            .BackColor = Color.LightGray
        }

        Dim labels = {"ID", "Customer", "Service", "Status", "Machine", "Date", "Total", "Action"}
        Dim widths = {60, 150, 120, 100, 120, 120, 100, 80}
        Dim x As Integer = 10

        For i As Integer = 0 To labels.Length - 1
            Dim lbl As New Label With {
                .Text = labels(i),
                .Font = New Font("Segoe UI", 9, FontStyle.Bold),
                .AutoSize = False,
                .Width = widths(i),
                .Left = x,
                .Top = 8,
                .TextAlign = ContentAlignment.MiddleLeft
            }
            header.Controls.Add(lbl)
            x += widths(i)
        Next

        flpTransactions.Controls.Add(header)
    End Sub

End Class
