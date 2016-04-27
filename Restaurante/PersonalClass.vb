Imports System.Data
Imports System.Data.SqlClient

Public Class PersonalClass
    Inherits conexion
    Private id_ As Integer
    Private nomyape_ As String
    Private tarea_ As String
    Public Property id() As String
        Get
            Return id_


        End Get
        Set(ByVal value As String)
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
    Public Property tarea() As String
        Get
            Return tarea_
        End Get
        Set(ByVal value As String)
            tarea_ = value
        End Set
    End Property
    Public Sub ConsultarPersonal(ByVal tabla As DataGridView)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pConsultarPersonal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objdataAdapter As New SqlDataAdapter(objComando)

            objdataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable

        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()
        End Try
    End Sub

    Public Sub Insertar(ByVal personal As PersonalClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pInsertarPersonal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@nomyape", SqlDbType.VarChar)
            objComando.Parameters("@nomyape").Value = personal.nomyape
            objComando.Parameters.Add("@tarea", SqlDbType.VarChar)
            objComando.Parameters("@tarea").Value = personal.tarea

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()


        End Try
    End Sub
    Public Sub Modificar(ByVal personal As PersonalClass)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pModificarPersonal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", personal.id)
            objComando.Parameters.AddWithValue("nomyape", personal.nomyape)
            objComando.Parameters.AddWithValue("tarea", personal.tarea)

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Borrar(ByVal idpersonal As Integer)
        Try
            Abrir()
            Dim objComando As New SqlCommand("pBorrarPersonal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idpersonal

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

End Class
