Public Class DashboardControl
﻿Imports System.Data.OleDb
Imports System.Transactions
Public Class DashboardControl
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderCounts()
        LoadMachineCounts()
    End Sub
    Private Sub LoadOrderCounts()
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\source\repos\LaundryManagementSys\LaundryDatabase.accdb;"

End Class