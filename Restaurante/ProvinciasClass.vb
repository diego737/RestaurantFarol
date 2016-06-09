Imports System
Imports System.Data.SqlClient

Public Class ProvinciasClass
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



    'Public Sub CargarComboProvincias(ByVal comboactual As ComboBox)
    '    Try
    '        Abrir()

    '        Dim objComando As New SqlCommand("ProvinciasCargarCombo", objConexion)
    '        objComando.CommandType = CommandType.StoredProcedure
    '        Dim objDataSet As New Data.DataSet
    '        Dim objDataAdapter As New SqlDataAdapter(objComando)

    '        objDataAdapter.Fill(objDataSet, "Provincias")
    '        Dim objDataTable As New Data.DataTable
    '        objDataTable.Columns.Add("id", GetType(Integer))
    '        objDataTable.Columns.Add("nombre", GetType(String))
    '        Dim drDsRow As DataRow
    '        Dim drNewRow As DataRow
    '        Dim indice As Integer = 0

    '        For Each drDsRow In objDataSet.Tables("Provincias").Rows
    '            drNewRow = objDataTable.NewRow
    '            drNewRow("id") = drDsRow("id")
    '            drNewRow("nombre") = drDsRow("nombre")
    '            objDataTable.Rows.Add(drNewRow)
    '            indice += 1
    '        Next
    '        With comboactual
    '            .DataSource = objDataTable
    '            .DisplayMember = "nombre"
    '            .ValueMember = "id"
    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        Cerrar()
    '    End Try
    'End Sub

    Public Sub CargarComboProvincias(ByVal comboactual As ComboBox)
        Try
            Abrir()
            Dim objComando As New SqlCommand("ProvinciasCargarCombo", Me.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "nombre"
                .ValueMember = "id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try
    End Sub



End Class
