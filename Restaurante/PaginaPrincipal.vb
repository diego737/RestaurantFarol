﻿Public Class PaginaPrincipal

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
      

    End Sub

    Private Sub CartaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARTAToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        CartaGrid.ShowDialog()
    End Sub

    Private Sub AtencionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtencionesToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        AtencionencursoForm.ShowDialog()
    End Sub

    Private Sub ConsultaAtencionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaAtencionesToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        FacturacionDiariaForm.ShowDialog()
    End Sub
End Class
