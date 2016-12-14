Public Class CartaGrid
    Dim carta As New CartaClass
    Private Sub CartaGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        carta.consultarCarta(DgvCarta)
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        frmcarta.accion = "Insertar"
        frmcarta.ShowDialog()
    End Sub

    Public Sub modificar()
        Try
            carta.id = DgvCarta.Item("id", DgvCarta.CurrentRow.Index).Value
            carta.IdCategoria = DgvCarta.Item("IdCategoria", DgvCarta.CurrentRow.Index).Value
            carta.descripcion = DgvCarta.Item("descripcion", DgvCarta.CurrentRow.Index).Value
            carta.precio = DgvCarta.Item("precio", DgvCarta.CurrentRow.Index).Value
         
            frmcarta.accion = "Modificar"
            frmcarta.carta = carta
            frmcarta.ShowDialog()
        Catch ex As Exception
            MsgBox("No puede modificar un cliente en blanco")

        Finally
        End Try
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        modificar()
    End Sub

   

    Private Sub DgvCarta_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCarta.CellDoubleClick
        modificar()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar el item seleccionado?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            Try
                carta.Borrar(DgvCarta.Item("id", DgvCarta.CurrentRow.Index).Value)
                carta.consultarCarta(DgvCarta)
            Catch ex As Exception
                MsgBox("Debe seleccionar un cliente")
            Finally
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class