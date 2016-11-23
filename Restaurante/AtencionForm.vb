Imports System.Data
Imports System.Data.SqlClient

Public Class AtencionForm
    'Dim suma As Integer
    Dim subtotal As Decimal = 0
    Private accion_ As String
    Private atencion_ As New AtencionClass
    Private detalle_ As New DetalleClass
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property atencion() As AtencionClass
        Get
            Return atencion_
        End Get
        Set(ByVal value As AtencionClass)
            atencion_ = value

        End Set
    End Property
    Public Property detalle() As DetalleClass
        Get
            Return detalle_
        End Get
        Set(ByVal value As DetalleClass)
            detalle_ = value

        End Set
    End Property

    Private Sub AtencionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mozo As New MozoClass

        mozo.CargarComboMozo(ComboMozo)

        Dim carta As New CartaClass
        carta.consultarCarta(DgvCarta1)
        Dim detalle As New DetalleClass
        detalle.consultarDetalle(DgvDetalle)

        Dim mesa As New MesasClass
        mesa.CargarComboMesa(ComboMesa)

        Dim tiposfactura As New TipoFacturaClass
        tiposfactura.CargarComboTipoFactura(ComboTipoFactura)
        'DateTime.Now.ToString("dd/MM/yyyy")
        Dim clientes As New ClienteClass
        clientes.CargarComboClientes(ComboClientes)
        If accion_ = "Insertar" Then

            Me.Text = "Agregar Atencion"
            ComboMozo.SelectedItem = ""
            ComboMesa.SelectedItem = ""
            ComboClientes.SelectedItem = ""
            ComboTipoFactura.SelectedItem = ""
            txtnumatencion.Text = ""
            LFecha.Text = Today
            DgvDetalle2.Rows.Clear()



        Else
            Me.Text = "Modificar Atencion"
            ComboMozo.SelectedValue = atencion.mozo
            ComboMesa.SelectedValue = atencion.mesa
            ComboClientes.SelectedValue = atencion.cliente
            ComboTipoFactura.SelectedValue = atencion.tipofactura
            txtnumatencion.Text = atencion.id
            LFecha.Text = atencion.fecha
            detalle.consultarDetalleActual(DgvDetalle2, atencion.id)
            detalle.ActualizarDetalleActual(DgvDetalle2, subtotal, subtotaltxt)
            subtotaltxt.Text = subtotal

        End If



    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DgvCarta1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCarta1.CellDoubleClick
        Dim nombre, descripcion As String
        Dim Precio As Decimal
        Dim idAtencion As String
        Dim nuevo As Integer

        nombre = DgvCarta1(2, DgvCarta1.CurrentRow.Index).Value
        descripcion = DgvCarta1(3, DgvCarta1.CurrentRow.Index).Value
        Precio = DgvCarta1(4, DgvCarta1.CurrentRow.Index).Value
        'idAtencion = atencion.UltimaAtencion
        idAtencion = 1
        nuevo = 1
        DgvDetalle2.Rows.Add(nombre, descripcion, Precio, idAtencion, nuevo)
        DgvDetalle2.Columns("idAtencion").Visible = False
        DgvDetalle2.Columns("nuevo").Visible = False
        detalle.ActualizarDetalleActual(DgvDetalle2, subtotal, subtotaltxt)
        'detalle.categoria = DgvCarta1.CurrentRow.Cells(2).Value()
        'detalle.nombre = DgvCarta1.CurrentRow.Cells(3).Value
        'detalle.precio = DgvCarta1.CurrentRow.Cells(4).Value
        'detalle.idAtencion = txtnumatencion.Text
        'detalle.Insertar2(detalle)
        'detalle.consultarDetalle(DgvDetalle)
       
        'For Each fila As DataGridViewRow In DgvDetalle.Rows

        '    suma += CInt(fila.Cells(3).Value)


        'Next
        'subtotaltxt.Text = suma.ToString

    End Sub


    'Private Sub DgvDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalle.CellDoubleClick
    '    'Dim mensaje As DialogResult = MessageBox.Show("Esta seguro de borrar este detalle?", "Adveretencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '    'If mensaje = Windows.Forms.DialogResult.OK Then
    '    '    Try
    '    '        detalle.BorrarDetalle(DgvDetalle.Item("id", DgvDetalle.CurrentRow.Index).Value)
    '    '        detalle.consultarDetalle(DgvDetalle)
    '    '    Catch ex As Exception
    '    '        MsgBox("Debe seleccionar una Atencion")
    '    '    Finally
    '    '    End Try
    '    'End If
    '    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)

    'End Sub


    Private Sub Aceptarbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptarbutton.Click
        atencion.mozo = ComboMozo.SelectedValue
        atencion.mesa = ComboMesa.SelectedValue
        atencion.cliente = ComboClientes.SelectedValue
        'atencion.id = txtnumatencion.Text
        atencion.tipofactura = ComboTipoFactura.SelectedValue
        atencion.fecha = LFecha.Text


        If accion_ = "Insertar" Then
            atencion.Insertar(atencion)
            detalle.Insertar3(DgvDetalle2, atencion.UltimaAtencion)
        Else
            atencion.id = txtnumatencion.Text
            atencion.Modificar(atencion)
            detalle.Insertar3(DgvDetalle2, atencion.id)

        End If
        atencion.consultarAtenciones(AtencionencursoForm.AtencionesDgv)
        Me.Close()


    End Sub

    

    Private Sub DgvDetalle2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalle2.CellDoubleClick
        DgvDetalle2.Rows.Remove(DgvDetalle2.CurrentRow)
    End Sub

End Class