Public Class frmcategorias
    Private accion_ As String
    Private categoria_ As New CategoriasClass

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property categoria() As CategoriasClass
        Get
            Return categoria_
        End Get
        Set(ByVal value As CategoriasClass)
            categoria_ = value
        End Set
    End Property

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        categoria.nombre = txtnombre.Text
        'categoria.imagen = imagencategorias.Image
        If accion_ = "Insertar" Then
            categoria.Insertar(categoria)
        Else
            categoria.id = txtid.Text
            categoria.modificar(categoria)
        End If
        categoria.consultarTodos(CategoriasGrid.CategoriasGrid1)
        Me.Close()
    End Sub

    Private Sub frmcategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Categoria"
            txtnombre.Text = ""
            'imagencategorias.Image = ""

        Else
            Me.Text = "Modificar Categoria"
            txtid.Text = categoria.id
            txtnombre.Text = categoria.nombre
            'imagencategorias.Image = categoria.imagen
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    
    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class