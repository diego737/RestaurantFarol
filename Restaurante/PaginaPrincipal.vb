Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        'Dim frmesas As New MesasGrid
        'frmesas.MdiParent = Me
        frmesas.Show()
    End Sub
End Class
