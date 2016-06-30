Public Class CategoriasGrid
    Dim categorias As New CategoriasClass
    
   
    Private Sub CategoriasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        categorias.consultarTodos(CategoriasGrid1)

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        frmcategorias.accion = "Insertar"
        frmcategorias.ShowDialog()

    End Sub

    Public Sub Modificar()
        Try
            categorias.id = CategoriasGrid1.Item("id", CategoriasGrid1.CurrentRow.Index).Value
            categorias.descripcion = CategoriasGrid1.Item("descripcion", CategoriasGrid1.CurrentRow.Index).Value

            frmcategorias.accion = "Modificar"
            frmcategorias.categoria = categorias
            frmcategorias.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Modificar()
    End Sub


    Private Sub CategoriasGrid1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CategoriasGrid1.CellDoubleClick
        Modificar()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Try
            Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar la Categoria?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If mensaje = Windows.Forms.DialogResult.OK Then
                categorias.Borrar(CategoriasGrid1.Item("id", CategoriasGrid1.CurrentRow.Index).Value)
                categorias.consultarTodos(CategoriasGrid1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

   
End Class