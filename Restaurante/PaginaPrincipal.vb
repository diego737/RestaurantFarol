Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        MesasGrid.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        ClientesGrid.Show()
    End Sub
End Class
