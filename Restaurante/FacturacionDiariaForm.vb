Imports System.Data
Imports System.Data.SqlClient
Public Class FacturacionDiariaForm

    Private Sub FacturacionDiariaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mozo As New MozoClass
        mozo.CargarComboMozo(cmbmozo)

        Dim mesa As New MesasClass
        mesa.CargarComboMesa(cmbmesa)
        Dim atencion As New AtencionClass
        atencion.consultarAtenciones(DgvFacturacionDiaria)
    End Sub

    Private Sub cmbmozo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmozo.SelectedIndexChanged
        Dim Conexion As String = "Data Source= DIEGO1-PC\SQLEXPRESS;Database= Restaurante; Integrated Security=sspi"
        Dim objconexion As New SqlConnection(Conexion)
        Dim buscar As New SqlDataAdapter("select mozo,mesa,fecha from Atencion where Mozo  like '%" + cmbmozo.SelectedValue.ToString + "%' and Fecha=convert(varchar(10),getdate(),103)", objconexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "Atencion")
        DgvFacturacionDiaria.DataSource = ds.Tables(0)
    End Sub
End Class