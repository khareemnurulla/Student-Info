﻿Module Module1
    Public con As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public Sub Connect()
        Dim path As String = Application.StartupPath & "\dbTutorial.mdb"
        con.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & path)
    End Sub
End Module
