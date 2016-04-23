Imports System.Data
Imports System.Data.SqlClient

Public Class ClienteClass

    Inherits conexion
    Private id_ As Integer
    Private nomyape_ As String
    Private dni_ As String
    Private direccion_ As String
    Private telefono_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property nomyape() As String
        Get
            Return nomyape_
        End Get
        Set(ByVal value As String)
            nomyape_ = value
        End Set
    End Property
    Public Property dni() As String
        Get
            Return dni_
        End Get
        Set(ByVal value As String)
            dni_ = value
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
    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value
        End Set
    End Property

    Public Sub consultarTodos(ByVal tabla As DataGridView)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultarClientes", objConexion)
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

    Public Sub Insertar(ByVal cliente As ClienteClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pInsertarClientes", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("nomyape", cliente.nomyape)
            objComando.Parameters.AddWithValue("dni", cliente.dni)
            objComando.Parameters.AddWithValue("direccion", cliente.direccion)
            objComando.Parameters.AddWithValue("telefono", cliente.telefono)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Modificar(ByVal cliente As ClienteClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pModificarClientes", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", cliente.id)
            objComando.Parameters.AddWithValue("nomyape", cliente.nomyape)
            objComando.Parameters.AddWithValue("dni", cliente.dni)
            objComando.Parameters.AddWithValue("direccion", cliente.direccion)
            objComando.Parameters.AddWithValue("telefono", cliente.telefono)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Borrar(ByVal idCliente As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarClientes", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idCliente

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

End Class
