Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        MesasGrid.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        ClientesGrid.ShowDialog()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        PersonalGrid.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        CategoriasGrid.ShowDialog()
    End Sub

    Private Sub PaginaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = True
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        ProveedoresGrid.ShowDialog()
    End Sub

    Private Sub AtencionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtencionToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        AtencionForm.ShowDialog()
    End Sub
End Class
