Imports System
Imports System.Data.SqlClient

Public Class MozoClass
    Inherits Conexion
    Private id_ As Integer
    Private nombre_ As String


    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property nombre() As Integer
        Get
            Return nombre_
        End Get
        Set(ByVal value As Integer)
            nombre_ = value
        End Set
    End Property

    Public Sub CargarComboMozo(ByVal comboactual As ComboBox)
        Try
            Abrir()
            Dim objComando As New SqlCommand("MozoCargarCombo", Me.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "nomyape"
                .ValueMember = "id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try
    End Sub

End Class
