Imports System.Data
Imports System.Data.SqlClient

Public Class ProveedoresClass

    Inherits conexion
    Private id_ As Integer
    Private nombre_ As String
    Private cuit_ As String
    Private detalle_ As String
    Private telefono_ As String
    Private direccion_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property cuit() As String
        Get
            Return cuit_
        End Get
        Set(ByVal value As String)
            cuit_ = value
        End Set
    End Property

    Public Property detalle() As String
        Get
            Return detalle_
        End Get
        Set(ByVal value As String)
            detalle_ = value
        End Set
    End Property

    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value
        End Set
    End Property

    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Public Sub consultarTodos(ByVal tabla As DataGridView)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultarProveedores", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub


    Public Sub Insertar(ByVal proveedores As ProveedoresClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pInsertarProveedores", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("nombre", proveedores.nombre)
            objComando.Parameters.AddWithValue("cuit", proveedores.cuit)
            objComando.Parameters.AddWithValue("detalle", proveedores.detalle)
            objComando.Parameters.AddWithValue("direccion", proveedores.direccion)
            objComando.Parameters.AddWithValue("telefono", proveedores.telefono)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Modificar(ByVal proveedores As ProveedoresClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pModificarProveedores", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", proveedores.id)
            objComando.Parameters.AddWithValue("nombre", proveedores.nombre)
            objComando.Parameters.AddWithValue("cuit", proveedores.cuit)
            objComando.Parameters.AddWithValue("detalle", proveedores.detalle)
            objComando.Parameters.AddWithValue("direccion", proveedores.direccion)
            objComando.Parameters.AddWithValue("telefono", proveedores.telefono)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Borrar(ByVal idProveedor As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarProveedores", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idProveedor

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub



End Class
