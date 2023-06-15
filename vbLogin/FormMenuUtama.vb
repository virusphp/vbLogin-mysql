Public Class FormMenuUtama

    Sub Terkunci()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
