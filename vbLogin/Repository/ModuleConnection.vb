Imports System.Data.Odbc

Module ModuleConnection
    Public Connect As OdbcConnection
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public RD As OdbcDataReader

    Public MYDB As String

    Public Sub koneksi()
        MYDB = "Driver={Mysql 8.0.33 driver};database=db_aplikasi;server=localhost;uid=megono;password=password123$$"
        Connect = New OdbcConnection(MYDB)
        If Connect.State = ConnectionState.Closed Then Connect.Open()
    End Sub
End Module
