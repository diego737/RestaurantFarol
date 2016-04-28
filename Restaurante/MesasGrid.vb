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
        Try
            mesas.id = MesasGrid1.Item("id", MesasGrid1.CurrentRow.Index).Value
            mesas.Detalle = MesasGrid1.Item("detalle", MesasGrid1.CurrentRow.Index).Value
            frmesas.accion = "Modificar"
            frmesas.mesas = mesas
            frmesas.ShowDialog()
        Catch ex As Exception
            MsgBox("No se puede modificar un personal en blanco")
        Finally
        End Try
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Modificar()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show(" Está seguro de borrar la Mesa?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            Try
                mesas.Borrar(MesasGrid1.Item("id", MesasGrid1.CurrentRow.Index).Value)
                mesas.Consultartodos(MesasGrid1)
            Catch ex As Exception
                MsgBox("No se puede eliminar un campo en blanco")
            Finally
            End Try
End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub MesasGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MesasGrid1.CellContentClick

    End Sub

    Private Sub MesasGrid1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MesasGrid1.CellContentDoubleClick
        Modificar()
    End Sub
End Class