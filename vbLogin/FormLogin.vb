Imports System.Data.SqlClient
Imports Syncfusion.Windows.Forms

Public Class FormLogin
    Inherits Office2010Form

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Sub ClearFormLogin()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Sub LoginMYSQLCrypt(ByVal username As String, ByVal password As String)
        Dim passBcrypt As New Chilkat.Crypt2
        Dim passed As Boolean = False
        Dim passHashed As String
        Dim passReplace As String

        If username = "" Or password = "" Then
            MsgBox("Username atau Password tidak boleh kosong")
        Else
            Call koneksiMysql()
            CMDMYSQL = New Odbc.OdbcCommand("select * from users where username='" & username & "'", ConnectMYSQL)
            RDMYSQL = CMDMYSQL.ExecuteReader
            RDMYSQL.Read()

            passHashed = RDMYSQL.Item("password").ToString
            passReplace = passHashed.Replace("$2y", "$2a")
            If RDMYSQL.HasRows And username = RDMYSQL.Item("username").ToString Then
                passed = passBcrypt.BCryptVerify(password, passReplace)
                If passed = True Then
                    Me.Close()
                    Call FormMenuUtama.Terbuka()
                Else
                    MsgBox("Password tidak sesuai atau tidak sama!")
                End If

            Else
                MsgBox("Username ditemukan atau tidak terdaftar!")
            End If
            RDMYSQL.Close()
        End If
    End Sub

    Sub LoginSQLCrypt(ByVal username As String, ByVal password As String)
        Dim passBcrypt As New Chilkat.Crypt2
        Dim passed As Boolean = False
        Dim passHashed As String
        Dim passReplace As String

        If username = "" Or password = "" Then
            MsgBox("Username atau Password tidak boleh kosong")
        Else
            Call koneksiSQL()
            CMDSQL = New SqlCommand("select * from users where username='" & username & "'", ConnectSQL)
            RDSQL = CMDSQL.ExecuteReader
            RDSQL.Read()

            passHashed = RDSQL.Item("password").ToString
            passReplace = passHashed.Replace("$2y", "$2a")
            If RDSQL.HasRows And username = RDSQL.Item("username").ToString Then
                passed = passBcrypt.BCryptVerify(password, passReplace)
                If passed = True Then
                    Me.Close()
                    Call FormMenuUtama.Terbuka()
                Else
                    MsgBox("Password tidak sesuai atau tidak sama!")
                End If

            Else
                MsgBox("Username ditemukan atau tidak terdaftar!")
            End If
            RDSQL.Close()
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoginSQLCrypt(txtUsername.Text, txtPassword.Text)
    End Sub

    Private Sub cbShoPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbShoPassword.CheckedChanged
        If cbShoPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub FormLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ClearFormLogin()
    End Sub
End Class