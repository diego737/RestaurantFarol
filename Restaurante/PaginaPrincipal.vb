Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        'Dim frmesas As New MesasGrid
        'frmesas.MdiParent = Me
        MesasGrid.ShowDialog()

        'Dim frmesas As New MesasGrid
        'frmesas.MdiParent = Me
      

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        ClientesGrid.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        PersonalGrid.ShowDialog()

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
        MenuStrip1.Enabled = False
        ConsultasGrid.ShowDialog()
    End Sub

    Private Sub PaginaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
