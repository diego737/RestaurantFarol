Imports System.Data
Imports System.Data.SqlClient
Public Class conexion
    Private strConexion_ As String
    Private objConexion_ As SqlConnection
    Public Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property
    Public Property objConexion() As SqlConnection
        Get
            Return objConexion_
        End Get
        Set(ByVal value As SqlConnection)
            objConexion_ = value

        End Set
    End Property
    Public Sub Abrir()
        Try
            strConexion_ = "Data Source= DIEGO-PC\SQLEXPRESS;Database= Restaurante; Integrated Security=sspi"
            objConexion_ = New SqlConnection(strConexion_)
            objConexion_.Open()
        Catch ex As SqlException
            MsgBox("Es incorrecta la Cadena de Conexion")

        End Try
    End Sub
    Public Sub Cerrar()
        objConexion_.Close()

    End Sub
End Class

