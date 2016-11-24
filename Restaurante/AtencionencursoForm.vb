Public Class AtencionencursoForm
    Dim atencion As New AtencionClass

    Private Sub NuevaAtencionbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaAtencionbutton.Click

        AtencionForm.accion = "Insertar"
        AtencionForm.ShowDialog()


    End Sub

    Private Sub AtencionencursoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        atencion.consultarAtenciones(AtencionesDgv)
    End Sub
    Public Sub modificar()
        Try
            atencion.id = AtencionesDgv.Item("id", AtencionesDgv.CurrentRow.Index).Value
            atencion.mozo = AtencionesDgv.Item("idMozo", AtencionesDgv.CurrentRow.Index).Value
            atencion.mesa = AtencionesDgv.Item("idMesa", AtencionesDgv.CurrentRow.Index).Value
            atencion.cliente = AtencionesDgv.Item("Cliente", AtencionesDgv.CurrentRow.Index).Value
            atencion.tipofactura = AtencionesDgv.Item("TipoFactura", AtencionesDgv.CurrentRow.Index).Value
            atencion.fecha = AtencionesDgv.Item("Fecha", AtencionesDgv.CurrentRow.Index).Value
            AtencionForm.accion = "Modificar"
            AtencionForm.atencion = atencion
            AtencionForm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub ModicarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModicarButton.Click
        modificar()
    End Sub

    Private Sub AtencionesDgv_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AtencionesDgv.CellDoubleClick
        modificar()
    End Sub

    Private Sub borrarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borrarButton.Click
        Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar esta Atencion?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            Try
                atencion.BorrarAtencion(AtencionesDgv.Item("id", AtencionesDgv.CurrentRow.Index).Value)
                atencion.consultarAtenciones(AtencionesDgv)
            Catch ex As Exception
                MsgBox("Debe seleccionar una Atencion")
            Finally
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim miimpresion As New Impresiones
        atencion.id = AtencionesDgv.Item("id", AtencionesDgv.CurrentRow.Index).Value
        miimpresion.Factura(rptFactura, rptFactura.Factura1, atencion.id)
        miimpresion.ActualizarImpresa(atencion.id)
        atencion.consultarAtenciones(AtencionesDgv)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        atencion.consultarAtencionesFacturadas(AtencionesDgv)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        atencion.consultarAtenciones(AtencionesDgv)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        atencion.consultarAtencionesaFacturar(AtencionesDgv)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        atencion.consultarAtencionesdeHoy(AtencionesDgv)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        atencion.consultarAtencionesFacturadasHoy(AtencionesDgv)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        atencion.consultarAtencionesaFacturarHoy(AtencionesDgv)
    End Sub
End Class