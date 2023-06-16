Public Class FormMenuUtama

    Sub Terkunci()
        btnLogin.Enabled = True
        MenuPesanan.Enabled = False
        btnLogout.Enabled = False
        btnExit.Enabled = False
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


End Class
