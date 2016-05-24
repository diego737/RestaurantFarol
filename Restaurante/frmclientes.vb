Public Class frmclientes

    Private accion_ As String
    Private cliente_ As New ClienteClass

    Public Property cliente() As ClienteClass
        Get
            Return cliente_
        End Get
        Set(ByVal value As ClienteClass)
            cliente_ = value
        End Set
    End Property

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        cliente.nomyape = txtNomyape.Text
        cliente.dni = txtDni.Text
        cliente.direccion = txtDireccion.Text
        cliente.telefono = txtTelefono.Text
        cliente.IdProvincia = ComboBoxProvincias.SelectedIndex

        If accion_ = "Insertar" Then
            cliente.Insertar(cliente)
        Else
            cliente.id = txtId.Text
            cliente.Modificar(cliente)
        End If
        cliente.consultarTodos(ClientesGrid.ClientesGrid1)
        Me.Close()
    End Sub

    Private Sub frmclientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim provincias As New ProvinciasClass
        provincias.CargarComboProvincias(ComboBoxProvincias)
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Cliente"
            txtNomyape.Text = ""
            txtDni.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
            ComboBoxProvincias.SelectedItem = ""

        Else
            Me.Text = "Modificar Cliente"
            txtId.Text = cliente.id
            txtNomyape.Text = cliente.nomyape
            txtDni.Text = cliente.dni
            txtDireccion.Text = cliente.direccion
            txtTelefono.Text = cliente.telefono
            ComboBoxProvincias.SelectedItem = cliente.IdProvincia
        End If
    End Sub
End Class