Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
<<<<<<< .mine
        MenuStrip1.Enabled = True
        'Dim frmesas As New MesasGrid
        'frmesas.MdiParent = Me
||||||| .r16
        MenuStrip1.Enabled = False
        'Dim frmesas As New MesasGrid
        'frmesas.MdiParent = Me
=======

        MenuStrip1.Enabled = True
>>>>>>> .r17
        MesasGrid.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
<<<<<<< .mine
        MenuStrip1.Enabled = True
        ClientesGrid.Show()
||||||| .r16
        MenuStrip1.Enabled = False
        ClientesGrid.ShowDialog()
=======
        MenuStrip1.Enabled = True
        ClientesGrid.ShowDialog()
>>>>>>> .r17
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
<<<<<<< .mine
        MenuStrip1.Enabled = True
        PersonalGrid.Show()
||||||| .r16
        MenuStrip1.Enabled = False
        PersonalGrid.ShowDialog()
=======
        MenuStrip1.Enabled = True
        PersonalGrid.ShowDialog()
>>>>>>> .r17

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem.Click
<<<<<<< .mine
        MenuStrip1.Enabled = True
        ConsultasGrid.Show()
||||||| .r16
        MenuStrip1.Enabled = False
        ConsultasGrid.ShowDialog()
=======
        MenuStrip1.Enabled = True
        ConsultasGrid.ShowDialog()
>>>>>>> .r17
    End Sub

    Private Sub PaginaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = True

    End Sub
End Class
