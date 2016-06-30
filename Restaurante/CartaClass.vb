Imports System.Data
Imports System.Data.SqlClient

Public Class CartaClass
    Inherits Conexion
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
End Class
