Public Class frmproveedores

    Private accion_ As String
    Private proveedores_ As New ProveedoresClass

    Public Property proveedores() As ProveedoresClass
        Get
            Return proveedores_
        End Get
        Set(ByVal value As ProveedoresClass)
            proveedores_ = value
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
        proveedores.nombre = txtNombre.Text
        proveedores.cuit = txtCuit.Text
        proveedores.detalle = txtDetalle.Text
        proveedores.direccion = txtDireccion.Text
        proveedores.telefono = txtTelefono.Text

        If accion_ = "Insertar" Then
            proveedores.Insertar(proveedores)
        Else
            proveedores.id = txtId.Text
            proveedores.Modificar(proveedores)
        End If
        proveedores.consultarTodos(ProveedoresGrid.ProveedoresGrid1)
        Me.Close()
    End Sub

    Private Sub frmclientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Proveedor"
            txtNombre.Text = ""
            txtCuit.Text = ""
            txtDetalle.Text = ""
            txtDireccion.Text = ""
            txtTelefono.Text = ""
        Else
            Me.Text = "Modificar Proveedor"
            txtId.Text = proveedores.id
            txtNombre.Text = proveedores.nombre
            txtCuit.Text = proveedores.cuit
            txtDetalle.Text = proveedores.detalle
            txtDireccion.Text = proveedores.direccion
            txtTelefono.Text = proveedores.telefono
        End If
    End Sub
End Class