Public Class PaginaPrincipal

    Private Sub MesasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub PaginaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuStrip1.Enabled = True


    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub AtencionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtencionToolStripMenuItem.Click
      

    End Sub

    Private Sub CartaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub AtencionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtencionesToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        AtencionencursoForm.ShowDialog()
    End Sub

    Private Sub ConsultaAtencionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaAtencionesToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        FacturacionDiariaForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pregunta As DialogResult = MsgBox("¿Desea salir del Programa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If pregunta = DialogResult.Yes Then
            Me.Close()
            My.Forms.Inicio.Close()

        End If
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click
        MenuStrip1.Enabled = True
        ClientesGrid.ShowDialog()
    End Sub

    Private Sub CartaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartaToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        CartaGrid.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasToolStripMenuItem1.Click
        MenuStrip1.Enabled = True
        CategoriasGrid.ShowDialog()
    End Sub

    Private Sub MesasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesasToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        MesasGrid.ShowDialog()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        PersonalGrid.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        MenuStrip1.Enabled = True
        ProveedoresGrid.ShowDialog()
    End Sub
End Class
