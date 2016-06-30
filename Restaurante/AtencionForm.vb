Imports System.Data
Imports System.Data.SqlClient
Public Class AtencionForm

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub AtencionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mozo As New MozoClass
        mozo.CargarComboMozo(ComboMozo)

        Dim carta As New CartaClass
        carta.consultarCarta(DgvCarta1)

        Dim mesa As New MesasClass
        mesa.CargarComboMesa(ComboMesa)

        Dim tipofactura As New TipoFacturaClass
        tipofactura.CargarComboTipoFactura(ComboTipoFactura)
        LFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Dim clientes As New ClienteClass
        clientes.CargarComboClientes(ComboClientes)
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DgvCarta1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCarta1.CellDoubleClick
        Dim nombre, descripcion As String
        Dim Precio As Decimal

        nombre = DgvCarta1(2, DgvCarta1.CurrentRow.Index).Value
        descripcion = DgvCarta1(3, DgvCarta1.CurrentRow.Index).Value
        Precio = DgvCarta1(4, DgvCarta1.CurrentRow.Index).Value

        DgvDetalle.Rows.Add(nombre, descripcion, Precio)
    End Sub


    Private Sub DgvDetalle_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvDetalle.CellDoubleClick
        DgvDetalle.Rows.RemoveAt(DgvCarta1.CurrentRow.Index)
    End Sub
End Class