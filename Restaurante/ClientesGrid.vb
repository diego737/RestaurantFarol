Public Class ClientesGrid
    Dim clientes As New ClienteClass
    Private Sub ClientesGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clientes.consultarTodos(ClientesGrid1)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmclientes.accion = "Insertar"
        frmclientes.ShowDialog()

    End Sub
    Public Sub modificar()
        clientes.id = ClientesGrid1.Item("id", ClientesGrid1.CurrentRow.Index).Value
        clientes.nomyape = ClientesGrid1.Item("nomyape", ClientesGrid1.CurrentRow.Index).Value
        clientes.dni = ClientesGrid1.Item("dni", ClientesGrid1.CurrentRow.Index).Value
        clientes.direccion = ClientesGrid1.Item("direccion", ClientesGrid1.CurrentRow.Index).Value
        clientes.telefono = ClientesGrid1.Item("telefono", ClientesGrid1.CurrentRow.Index).Value
        frmclientes.accion = "Modificar"
        frmclientes.cliente = clientes
        frmclientes.ShowDialog()


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        modificar()
    End Sub

    Private Sub ClientesGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesGrid1.CellContentClick

    End Sub

    Private Sub ClientesGrid1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesGrid1.CellContentDoubleClick
        modificar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar el Cliente?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            clientes.Borrar(ClientesGrid1.Item("id", ClientesGrid1.CurrentRow.Index).Value)
            clientes.consultarTodos(ClientesGrid1)
        End If
    End Sub
End Class