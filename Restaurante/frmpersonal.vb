Public Class frmpersonal
    Private accion_ As String
    Private personal_ As New PersonalClass
    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property personal() As PersonalClass
        Get
            Return personal_
        End Get
        Set(ByVal value As PersonalClass)
            personal_ = value

        End Set
    End Property

    Private Sub frmpersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion_ = "Insertar" Then
            Me.Text = "Agregar Personal"
            txtnomyape.Text = ""
            txttarea.Text = ""
        Else
            Me.Text = "Modificar Personal"
            txtid.Text = personal.id
            txtnomyape.Text = personal.nomyape
            txttarea.Text = personal.tarea
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        personal.nomyape = txtnomyape.Text
        personal.tarea = txttarea.Text

        If accion_ = "Insertar" Then
            personal.Insertar(personal)
        Else
            personal.id = txtid.Text
            personal.Modificar(personal)


        End If
        personal.ConsultarPersonal(PersonalGrid.Personalgrid1)
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtnomyape_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnomyape.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttarea.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class