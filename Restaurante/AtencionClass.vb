Imports System.Data
Imports System.Data.SqlClient
Public Class AtencionClass
    Inherits Conexion
    Dim id_ As Integer
    Dim numero_ As Integer
    Dim mozo_ As String
    Dim mesa_ As String
    Dim cliente_ As String
    Dim tipoFactura_ As String
    Dim fecha_ As Date

  
    Public Property id() As Integer
        Get
            Return id_

        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property numero() As Integer
        Get
            Return numero_

        End Get
        Set(ByVal value As Integer)
            numero_ = value
        End Set
    End Property
    Public Property mozo() As String
        Get
            Return mozo_

        End Get
        Set(ByVal value As String)
            mozo_ = value
        End Set
    End Property
    Public Property mesa() As String
        Get
            Return mesa_

        End Get
        Set(ByVal value As String)
            mesa_ = value
        End Set
    End Property
   
    Public Property cliente() As String
        Get
            Return cliente_

        End Get
        Set(ByVal value As String)
            cliente_ = value
        End Set
    End Property
    Public Property tipofactura() As String
        Get
            Return tipoFactura_

        End Get
        Set(ByVal value As String)
            tipoFactura_ = value
        End Set
    End Property
    Public Property fecha() As DateTime
        Get
            Return fecha_

        End Get
        Set(ByVal value As DateTime)
            fecha_ = value
        End Set
    End Property
 

    Public Sub consultarAtenciones(ByVal tabla As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultaAtenciones", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
            'tabla.Columns("id").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Insertar(ByVal atencion As AtencionClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pInsertarAtenciones", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@Mozo", SqlDbType.VarChar)
            objComando.Parameters("@Mozo").Value = atencion.mozo
            objComando.Parameters.Add("@Mesa", SqlDbType.VarChar)
            objComando.Parameters("@Mesa").Value = atencion.mesa
            objComando.Parameters.Add("@Cliente", SqlDbType.VarChar)
            objComando.Parameters("@Cliente").Value = atencion.cliente
            objComando.Parameters.Add("@TipoFactura", SqlDbType.VarChar)
            objComando.Parameters("@TipoFactura").Value = atencion.tipofactura
            objComando.Parameters.Add("@Fecha", SqlDbType.DateTime)
            objComando.Parameters("@Fecha").Value = atencion.fecha
            

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()


        End Try
    End Sub
    Public Sub Modificar(ByVal atencion As AtencionClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pModificarAtenciones", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", atencion.id)
            objComando.Parameters.AddWithValue("Mozo", atencion.mozo)
            objComando.Parameters.AddWithValue("Mesa", atencion.mesa)
            objComando.Parameters.AddWithValue("Cliente", atencion.cliente)
            objComando.Parameters.AddWithValue("TipoFactura", atencion.tipofactura)
            objComando.Parameters.AddWithValue("Fecha", atencion.fecha)
           

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub BorrarAtencion(ByVal idAtencion As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarAtenciones", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idAtencion

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Function UltimaAtencion()
        Abrir()
        Try

            Dim objComando As New SqlCommand("pUltimaAtencion", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Return objComando.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()
            Return False
        End Try
    End Function
End Class
