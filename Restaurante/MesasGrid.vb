Public Class MesasGrid
    Dim mesas As New MesasClass
    Private Sub MesasGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mesas.Consultartodos(MesasGrid1)
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        frmesas.accion = "Insertar"
        frmesas.ShowDialog()
    End Sub
    Public Sub Modificar()

        mesas.id = MesasGrid1.Item("id", MesasGrid1.CurrentRow.Index).Value
        mesas.Detalle = MesasGrid1.Item("nombre", MesasGrid1.CurrentRow.Index).Value
        frmesas.accion = "Modificar"
        frmesas.mesas = mesas
        frmesas.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Modificar()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show(" Está seguro de borrar la Mesa?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            mesas.Borrar(MesasGrid1.Item("id", MesasGrid1.CurrentRow.Index).Value)
            mesas.Consultartodos(MesasGrid1)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class