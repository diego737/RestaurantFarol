Imports System.Data
Imports System.Data.SqlClient

Public Class DetalleClass

    Inherits Conexion
    Dim id_ As Integer
    Dim categoria_ As String
    Dim nombre_ As String
    Dim precio_ As Decimal
    Dim idAtencion_ As Integer
    Dim nuevo_ As Integer


    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property categoria() As String
        Get
            Return categoria_
        End Get
        Set(ByVal value As String)
            categoria_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property

    Public Property precio() As Decimal
        Get
            Return precio_
        End Get
        Set(ByVal value As Decimal)
            precio_ = value
        End Set
    End Property
    Public Property idAtencion() As Integer
        Get
            Return idAtencion_
        End Get
        Set(ByVal value As Integer)
            idAtencion_ = value
        End Set
    End Property
    Public Property nuevo() As Integer
        Get
            Return nuevo_
        End Get
        Set(ByVal value As Integer)
            nuevo_ = value
        End Set
    End Property

    Public Sub consultarDetalle(ByVal tabla As DataGridView)
        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultarDetalles", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
            tabla.Columns("id").Visible = False
            tabla.Columns("idAtencion").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub consultarDetalleActual(ByVal tabla As DataGridView, ByVal idAtencion As Integer)
        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultarAtencionActual", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idAtencion", idAtencion)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.Rows.Clear()
            Dim fila As Integer = 0
            For Each row As DataRow In objDataTable.Rows
                tabla.Rows.Add()
                tabla.Rows(fila).Cells("categoria").Value = row.Item("categoria")
                tabla.Rows(fila).Cells("nombre").Value = row.Item("nombre")
                tabla.Rows(fila).Cells("precio").Value = row.Item("precio")
                tabla.Rows(fila).Cells("nuevo").Value = row.Item("nuevo")
                fila += 1
            Next
            'tabla.DataSource = objDataTable
            'tabla.Columns("id").Visible = False
            'tabla.Columns("idAtencion").Visible = False


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Insertar3(ByVal detalle As DataGridView, ByVal ultimaAtencion As Integer)
        Dim cartagrid As New AtencionForm
        Try
            Abrir()
            Dim sql As String = "INSERT INTO Detalle (categoria,nombre,precio,idAtencion) VALUES (@categoria,@nombre,@precio,@idAtencion)"
            For Each fila As DataGridViewRow In detalle.Rows
                Using Command As New SqlCommand(sql, objConexion)
                    If fila.Cells("nuevo").Value = 1 Then
                        Command.Parameters.AddWithValue("@categoria", fila.Cells(0).Value)
                        Command.Parameters.AddWithValue("@nombre", fila.Cells(1).Value)
                        Command.Parameters.AddWithValue("@precio", fila.Cells(2).Value)
                        Command.Parameters.AddWithValue("@idAtencion", ultimaAtencion)
                        Command.ExecuteNonQuery()
                    End If
                End Using
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()


        End Try
    End Sub

    Public Sub Insertar(ByVal detalle As DetalleClass)
        Dim cartagrid As New AtencionForm
        Try
            Abrir()
            Dim objComando As New SqlCommand("pInsertarDetalle", objConexion)
            For Each fila As DataGridViewRow In cartagrid.DgvCarta1.Rows

                'objComando.Parameters.AddWithValue("@id", fila.Cells(0).Value)
                objComando.Parameters.AddWithValue("@categoria", fila.Cells(1).Value)
                objComando.Parameters.AddWithValue("@nombre", fila.Cells(2).Value)
                objComando.Parameters.AddWithValue("@precio", fila.Cells(3).Value)
                'objComando.Parameters.AddWithValue("@idAtencion", detalle.idAtencion)
                objComando.ExecuteNonQuery()

            Next



        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()


        End Try
    End Sub
    Public Sub Insertar2(ByVal detalle As DetalleClass)
        Dim cartagrid As New AtencionForm
        Try
            Abrir()
            Dim objComando As New SqlCommand("pInsertarDetalle", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            'objComando.Parameters.AddWithValue("@id", fila.Cells(0).Value)
            objComando.Parameters.AddWithValue("@categoria", detalle.categoria)
            objComando.Parameters.AddWithValue("@nombre", detalle.nombre)
            objComando.Parameters.AddWithValue("@precio", detalle.precio)
            objComando.Parameters.AddWithValue("@idAtencion", detalle.idAtencion)


            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cerrar()


        End Try
    End Sub
    Public Sub BorrarDetalle(ByVal idDetalle As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarDetalle", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idDetalle

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub


End Class



