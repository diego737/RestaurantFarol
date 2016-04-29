Public Class ProveedoresGrid
    Dim proveedores As New ProveedoresClass

    Private Sub ProveedoresGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        proveedores.consultarTodos(ProveedoresGrid1)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmproveedores.accion = "Insertar"
        frmproveedores.ShowDialog()
    End Sub
    Public Sub modificar()
        Try
            proveedores.id = ProveedoresGrid1.Item("id", ProveedoresGrid1.CurrentRow.Index).Value
            proveedores.nombre = ProveedoresGrid1.Item("nombre", ProveedoresGrid1.CurrentRow.Index).Value
            proveedores.cuit = ProveedoresGrid1.Item("cuit", ProveedoresGrid1.CurrentRow.Index).Value
            proveedores.detalle = ProveedoresGrid1.Item("detalle", ProveedoresGrid1.CurrentRow.Index).Value
            proveedores.direccion = ProveedoresGrid1.Item("direccion", ProveedoresGrid1.CurrentRow.Index).Value
            proveedores.telefono = ProveedoresGrid1.Item("telefono", ProveedoresGrid1.CurrentRow.Index).Value
            frmproveedores.accion = "Modificar"
            frmproveedores.proveedores = proveedores
            frmproveedores.ShowDialog()
        Catch ex As Exception
            MsgBox("No puede modificar una celda en blanco")

        Finally
        End Try
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificar()
    End Sub
    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar el Cliente?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            Try
                proveedores.Borrar(ProveedoresGrid1.Item("id", ProveedoresGrid1.CurrentRow.Index).Value)
                proveedores.consultarTodos(ProveedoresGrid1)
            Catch ex As Exception
                MsgBox("Debe seleccionar un proveedor")
            Finally
            End Try
        End If
    End Sub

    Private Sub ProveedoresGrid1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProveedoresGrid1.CellContentDoubleClick
        modificar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class