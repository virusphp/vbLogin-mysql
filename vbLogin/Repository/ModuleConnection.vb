Imports System.Data.Odbc
Imports System.Data.SqlClient

Module ModuleConnection
    'CONFIG CONNECTION WITH MYSQL SERVER
    Public ConnectMYSQL As OdbcConnection
    Public DAMYSQL As OdbcDataAdapter
    Public RDMYSQL As OdbcDataReader
    Public CMDMYSQL As OdbcCommand
    Public MYDBMYSQL As String
    Public DSMYSQL As DataSet

    'CONNECTION WITH SQL SERVER
    Public ConnectSQL As SqlConnection
    Public DASQL As SqlDataAdapter
    Public RDSQL As SqlDataReader
    Public CMDSQL As SqlCommand
    Public MYDBSQL As String
    Public DSYSQL As DataSet

    Public Sub koneksiMysql()
        MYDBMYSQL = "Driver={Mysql 8.0.33 driver};database=db_aplikasi;server=localhost;uid=megono;password=password123$$"

        ConnectMYSQL = New OdbcConnection(MYDBMYSQL)
        If ConnectMYSQL.State = ConnectionState.Closed Then ConnectMYSQL.Open()
    End Sub

    Public Sub koneksiSQL()
        MYDBSQL = "Data Source=192.168.0.205\SQL2008;initial catalog=DBSIMRS;integreted security=true"
        ConnectSQL = New SqlConnection(MYDBSQL)
        If ConnectSQL.State = ConnectionState.Closed Then ConnectSQL.Open()
    End Sub


End Module
