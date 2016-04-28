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
        categoria.descripcion = txtdescripcion.Text
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
            txtdescripcion.Text = ""
            'imagencategorias.Image = ""
        
        Else
            Me.Text = "Modificar Categoria"
            txtid.Text = categoria.id
            txtdescripcion.Text = categoria.descripcion
            'imagencategorias.Image = categoria.imagen
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class