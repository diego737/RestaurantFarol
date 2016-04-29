﻿Imports System.Data
Imports System.Data.SqlClient
Public Class CategoriasClass
    Inherits Conexion

    Private id_ As Integer
    Private descripcion_ As String
    Private imagen_ As PictureBox

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property
    Public Property imagen() As PictureBox
        Get
            Return imagen_
        End Get
        Set(ByVal value As PictureBox)
            imagen_ = value
        End Set
    End Property
    Public Sub consultarTodos(ByVal tabla As DataGridView)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pConsultarCategorias", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)

            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub

    Public Sub Insertar(ByVal categoria As CategoriasClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pInsertarCategorias", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("descripcion", categoria.descripcion)
            'objComando.Parameters.AddWithValue("imagen", categoria.imagen)
           

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Modificar(ByVal categoria As CategoriasClass)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pModificarCategorias", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("id", categoria.id)
            objComando.Parameters.AddWithValue("descripcion", categoria.descripcion)
            'objComando.Parameters.AddWithValue("imagen", categoria.imagen)
           

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
    Public Sub Borrar(ByVal idCategoria As Integer)

        Try
            Abrir()

            Dim objComando As New SqlCommand("pBorrarCategorias", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters("@id").Value = idCategoria

            objComando.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cerrar()
        End Try
    End Sub
End Class