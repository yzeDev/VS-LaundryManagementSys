Module Db
    Public ReadOnly Property ConnectionString As String
        Get
            ' Pick ONE path and stick to it.
            Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eisen\OneDrive\Documents\LaundryDatabase.accdb;"

        End Get
    End Property
End Module
