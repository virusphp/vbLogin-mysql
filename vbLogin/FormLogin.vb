Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.MasterToolStripMenuItem.Visible = True
    End Sub

End Class