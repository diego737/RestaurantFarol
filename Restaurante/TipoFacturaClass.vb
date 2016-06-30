Imports System
Imports System.Data.SqlClient

Public Class TipoFacturaClass
    Inherits Conexion

    Public Sub CargarComboTipoFactura(ByVal comboactual As ComboBox)
        Try
            Abrir()
            Dim objComando As New SqlCommand("TipoFacturaCargarCombo", Me.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "tipo"
                .ValueMember = "id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try
    End Sub
End Class
