Imports System.Data.Odbc
Module Module1
    Public CONN As OdbcConnection
    Public CMD As OdbcCommand
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public QUERY As String
    Public DS As DataSet
    Public DT As DataTable
    Public str As String
    Public strCari As String
    Public CodeCari As Boolean
    Public strMenuAkses As String
    Public strUser As String

    Sub KONEKSI()
        Dim str As String = "Dsn=SI_Penjualan"
        CONN = New OdbcConnection(str)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        Else
            MsgBox("Koneksi gagal, mohon periksa kembali.")
        End If

    End Sub

End Module
