Public Class FormMenuUtama

    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub
End Class
