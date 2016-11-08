Imports CrystalDecisions.Shared
Public Class Impresiones
    Inherits Conexion
    Public Sub Configurar(ByVal objReporte As Object)
        Abrir()
        Dim usuario As String = ""
        Dim password As String = ""
        Dim intSec As Boolean = False
        If usuario = "" And password = "" Then
            intSec = True
        End If
        objReporte.DataSourceConnections.Item(0).SetConnection("DIEGO1-PC\SQLEXPRESS", "Restaurante", intSec)
        objReporte.setdatabaselogon("", "")
        Cerrar()

    End Sub
    Public Sub Factura(ByVal formulario As Form, ByVal objReporte As Object, ByVal idFactura As Integer)
        Configurar(objReporte)
        Dim Params As New ParameterValues
        Dim Par As New ParameterDiscreteValue

        Params.Clear()
        Par.Value = idFactura
        Params.Add(Par)
        objReporte.DataDefinition.ParameterFields("@idFactura").ApplyCurrentValues(Params)

        formulario.ShowDialog()
        formulario.Dispose()

    End Sub
End Class
