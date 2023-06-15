Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong")
        Else
            Call koneksiMysql()
            CMDMYSQL = New Odbc.OdbcCommand("select * from user where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", ConnectMYSQL)
            RDMYSQL = CMDMYSQL.ExecuteReader
            RDMYSQL.Read()

            If RDMYSQL.HasRows Then
                Me.Close()
                Call Terbuka()
            Else
                MsgBox("Username dan password tidak sesuai / Salah!")
            End If
        End If
        'If txtUsername.Text = "AA" And txtPassword.Text = "BB" Then

        'End If
    End Sub
End Class