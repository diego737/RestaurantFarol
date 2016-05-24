<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesasGrid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesasGrid))
        Me.MesasGrid1 = New System.Windows.Forms.DataGridView
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        CType(Me.MesasGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MesasGrid1
        '
        Me.MesasGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MesasGrid1.Location = New System.Drawing.Point(119, 12)
        Me.MesasGrid1.Name = "MesasGrid1"
        Me.MesasGrid1.Size = New System.Drawing.Size(281, 505)
        Me.MesasGrid1.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImage = CType(resources.GetObject("BtnAgregar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAgregar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 37)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(101, 43)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(12, 105)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(101, 43)
        Me.BtnModificar.TabIndex = 2
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnBorrar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Location = New System.Drawing.Point(12, 176)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(101, 43)
        Me.BtnBorrar.TabIndex = 3
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSalir.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(12, 474)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(101, 43)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'MesasGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(439, 529)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.MesasGrid1)
        Me.Name = "MesasGrid"
        Me.Text = "MesasGrid"
        CType(Me.MesasGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MesasGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class
