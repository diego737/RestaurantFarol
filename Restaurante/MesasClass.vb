Imports System.Data
Imports System.Data.SqlClient

Public Class MesasClass
    Inherits conexion
    Private Id_ As Integer
    Private Detalle_ As String

    Public Property id() As Integer
        Get
            Return Id_

        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Detalle() As String
        Get
            Return Detalle_

        End Get
        Set(ByVal value As String)
            Detalle_ = value
        End Set
    End Property
    Public Sub Consultartodos(ByVal tabla As DataGridView)
        'Dim strconexion As String = "Data Source= DIEGO-PC\SQLEXPRESS;Database= Restaurant; Integrated Security=sspi"
        ' Dim objconexion As New SqlConnection(strconexion)
        Try


            Abrir()
            'Dim strComando As String = "Select * from Clientes"
            Dim objComando As New SqlCommand("pConsultaMesas", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim ojbDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            'objconexion.Open()
            objDataAdapter.Fill(ojbDataTable)
            tabla.DataSource = ojbDataTable
            'objconexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()
        End Try
    End Sub
    Public Sub Insertar(ByVal mesa As MesasClass)
        'Dim strConexion As String = "Data Source= DIEGO-PC\SQLEXPRESS;Database= Restaurant; Integrated Security=sspi"
        'Dim objConexion As New SqlConnection(strConexion)
        Try
            Abrir()
            ' Dim strComando As String = "INSERT INTO Clientes (nombre,direccion,fechanac,deuda) VALUES (@nombre,@direccion,@fechanac,@deuda)"
            Dim objComando As New SqlCommand("pInsertarMesas", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@detalle", SqlDbType.VarChar)
            objComando.Parameters("@detalle").Value = mesa.Detalle

            'objComando.Parameters.AddWithValue("id", mesa.id)
            'objComando.Parameters.AddWithValue("detalle", mesa.Detalle)
            'objConexion.Open()
            objComando.ExecuteNonQuery()
            'objConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Borrar(ByVal idmesa As Integer)
        'Dim strConexion As String = "Data Source= DIEGO-PC\SQLEXPRESS;Database= Restaurant; Integrated Security=sspi"
        ' Dim objConexion As New SqlConnection(strConexion)
        Try
            Abrir()
            ' Dim strComando As String = "DELETE Clientes WHERE id=@id"
            Dim objComando As New SqlCommand("pBorrarMesas", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idmesa

            'objConexion.Open()
            objComando.ExecuteNonQuery()
            'objConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Modificar(ByVal mesa As MesasClass)
        'Dim strConexion As String = "Data Source= DIEGO-PC\SQLEXPRESS;Database= Restaurant; Integrated Security=sspi"
        'Dim objConexion As New SqlConnection(strConexion)
        Try
            Abrir()
            'Dim strComando As String = "UPDATE Clientes SET nombre=@nombre,direccion=@direccion,fechanac=@fechaNac,deuda=@deuda WHERE id=@id"
            Dim objComando As New SqlCommand("pModificarMesas", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            'objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters.AddWithValue("id", mesa.id) 'este es con procedimiento almacenado
            'objComando.Parameters.Add("@detalle", SqlDbType.VarChar)
            objComando.Parameters.AddWithValue("detalle", mesa.Detalle)
            'objComando.Parameters("@id").Value = mesa.id
            'objComando.Parameters("@detalle").Value = mesa.Detalle
            

            'objConexion.Open()
            objComando.ExecuteNonQuery()
            'objConexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try

    End Sub
    Public Sub CargarComboMesa(ByVal comboactual As ComboBox)
        Try
            Abrir()
            Dim objComando As New SqlCommand("MesasCargarCombo", Me.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            With comboactual
                .DataSource = objDataTable
                .DisplayMember = "detalle"
                .ValueMember = "id"

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()

        End Try
    End Sub
End Class
