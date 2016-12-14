Public Class frmcarta
    Private accion_ As String
    Private carta_ As New CartaClass
    Public Property carta() As CartaClass
        Get
            Return carta_
        End Get
        Set(ByVal value As CartaClass)
            carta_ = value
        End Set
    End Property

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        carta.IdCategoria = ComboCategoria.SelectedValue
        carta.descripcion = txtdescripcion.Text
        carta.precio = txtprecio.Text
        If accion_ = "Insertar" Then
            carta.Insertar(carta)
        Else
            carta.Modificar(carta)
        End If
        carta.consultarCarta(CartaGrid.DgvCarta)
        Me.Close()
    End Sub

    Private Sub frmcarta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim categoria As New CategoriasClass
        categoria.CargarComboCategorias(ComboCategoria)
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Carta"
            ComboCategoria.SelectedItem = ""
            txtdescripcion.Text = ""
            txtprecio.Text = ""


        Else
            Me.Text = "Modificar Carta"
            ComboCategoria.SelectedValue = carta.IdCategoria
            txtdescripcion.Text = carta.descripcion
            txtprecio.Text = carta.precio

        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

   
    Private Sub txtdescripcion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdescripcion.LostFocus


    End Sub

   
    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "$" Or e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class