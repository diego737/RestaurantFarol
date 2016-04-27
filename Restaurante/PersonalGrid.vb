Public Class PersonalGrid
    Dim personal As New PersonalClass

    

   
    Private Sub PersonalGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        personal.ConsultarPersonal(Personalgrid1)

    End Sub

    Private Sub BtnAgragar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgragar.Click
        frmpersonal.accion = "Insertar"
        frmpersonal.ShowDialog()
    End Sub
    Public Sub modificar()
        personal.id = Personalgrid1.Item("id", Personalgrid1.CurrentRow.Index).Value
        personal.nomyape = Personalgrid1.Item("nomyape", Personalgrid1.CurrentRow.Index).Value
        personal.tarea = Personalgrid1.Item("tarea", Personalgrid1.CurrentRow.Index).Value
        frmpersonal.accion = "Modificar"
        frmpersonal.personal = personal
        frmpersonal.ShowDialog()
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        modificar()
    End Sub
   
    
    Private Sub Personalgrid1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Personalgrid1.CellContentDoubleClick
        modificar()
    End Sub

    Private Sub BtnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorrar.Click
        Dim mensaje As DialogResult = MessageBox.Show(" Está seguro de borrar a la Persona?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If mensaje = Windows.Forms.DialogResult.OK Then
            personal.Borrar(Personalgrid1.Item("id", Personalgrid1.CurrentRow.Index).Value)
            personal.ConsultarPersonal(Personalgrid1)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class