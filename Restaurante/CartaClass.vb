Imports System.Data
Imports System.Data.SqlClient

Public Class CartaClass
    Inherits Conexion

    Private id_ As Integer
    Private IdCategoria_ As Integer
    Private descripcion_ As String
    Private precio_ As Decimal


    Public Property id() As Integer
        Get
            Return id_

        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property IdCategoria() As Integer
        Get
            Return IdCategoria_

        End Get
        Set(ByVal value As Integer)
            IdCategoria_ = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return descripcion_


        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property
    Public Property precio() As Decimal
        Get
            Return precio_

        End Get
        Set(ByVal value As Decimal)
            precio_ = value
        End Set
    End Property
    Public Sub consultarCarta(ByVal tabla As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultaCarta", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
            tabla.Columns("IdCategoria").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Insertar(ByVal carta As CartaClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pInsertarCarta", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("IdCategoria", carta.IdCategoria)
            objComando.Parameters.AddWithValue("descripcion", carta.descripcion)
            objComando.Parameters.AddWithValue("precio", carta.precio)
          
            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Modificar(ByVal carta As CartaClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pModificarCarta", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", carta.id)
            objComando.Parameters.AddWithValue("IdCategoria", carta.IdCategoria)
            objComando.Parameters.AddWithValue("descripcion", carta.descripcion)
            objComando.Parameters.AddWithValue("precio", carta.precio)

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Borrar(ByVal idCarta As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarCarta", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idCarta

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
End Class
