<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonalGrid))
        Me.BtnAgragar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Personalgrid1 = New System.Windows.Forms.DataGridView
        CType(Me.Personalgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgragar
        '
        Me.BtnAgragar.BackgroundImage = CType(resources.GetObject("BtnAgragar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgragar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAgragar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgragar.ForeColor = System.Drawing.Color.White
        Me.BtnAgragar.Location = New System.Drawing.Point(12, 36)
        Me.BtnAgragar.Name = "BtnAgragar"
        Me.BtnAgragar.Size = New System.Drawing.Size(100, 43)
        Me.BtnAgragar.TabIndex = 0
        Me.BtnAgragar.Text = "Agregar"
        Me.BtnAgragar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = CType(resources.GetObject("BtnModificar.BackgroundImage"), System.Drawing.Image)
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(12, 95)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(100, 43)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = CType(resources.GetObject("BtnBorrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnBorrar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Location = New System.Drawing.Point(12, 156)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(100, 43)
        Me.BtnBorrar.TabIndex = 2
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSalir.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(12, 477)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 43)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Personalgrid1
        '
        Me.Personalgrid1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Personalgrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Personalgrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.Personalgrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.Personalgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Personalgrid1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Personalgrid1.Location = New System.Drawing.Point(119, 12)
        Me.Personalgrid1.Name = "Personalgrid1"
        Me.Personalgrid1.Size = New System.Drawing.Size(407, 508)
        Me.Personalgrid1.TabIndex = 4
        '
        'PersonalGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 532)
        Me.Controls.Add(Me.Personalgrid1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgragar)
        Me.MaximumSize = New System.Drawing.Size(795, 570)
        Me.Name = "PersonalGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonalGrid"
        CType(Me.Personalgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAgragar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Personalgrid1 As System.Windows.Forms.DataGridView
End Class
