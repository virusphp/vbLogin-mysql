Public Class FormMenuUtama

    Sub Terkunci()
        btnLogin.Enabled = True
        MenuPesanan.Enabled = False
        btnLogout.Enabled = False
        btnExit.Enabled = True
    End Sub

    Sub Terbuka()
        btnLogin.Enabled = False
        MenuPesanan.Enabled = True
        btnLogout.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Call Terkunci()
    End Sub
End Class
