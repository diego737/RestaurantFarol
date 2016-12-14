Public Class frmesas
    Private accion_ As String
    Private mesas_ As New MesasClass
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set

    End Property
    Public Property mesas() As MesasClass
        Get
            Return mesas_
        End Get
        Set(ByVal value As MesasClass)
            mesas_ = value
        End Set
    End Property

    Private Sub frmesas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Mesa"
            txtdetalle.Text = ""
          
        Else
            Me.Text = "Modificar Cliente"
            txtid.Text = mesas.id
            txtdetalle.Text = mesas.Detalle
           
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        mesas.Detalle = txtdetalle.Text
    

        If accion_ = "Insertar" Then

            mesas.Insertar(mesas)
        Else
            mesas.id = txtid.Text
            mesas.Modificar(mesas)
        End If
        mesas.Consultartodos(MesasGrid.MesasGrid1)
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

   
    Private Sub txtdetalle_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdetalle.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class