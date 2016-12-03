Public Class Inicio
    Dim contador As Byte = 4
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            PaginaPrincipal.Show()
            ProgressBar1.Hide()
            Me.Hide()

        Else
            ProgressBar1.Value += 2
            If ProgressBar1.Value = contador Then
                Label3.Text = "INICIANDO..."
            Else
                If ProgressBar1.Value = contador + 15 Then
                    Label3.Text = ""
                    contador += 20
                End If
            End If
        End If



    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class