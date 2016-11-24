<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartaGrid
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
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BtnBorrar = New System.Windows.Forms.Button
        Me.DgvCarta = New System.Windows.Forms.DataGridView
        CType(Me.DgvCarta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackgroundImage = Global.Restaurante.My.Resources.Resources.Madera1
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Sienna
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnAgregar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(12, 56)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(101, 43)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = Global.Restaurante.My.Resources.Resources.Madera
        Me.BtnModificar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.Location = New System.Drawing.Point(12, 117)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(101, 43)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackgroundImage = Global.Restaurante.My.Resources.Resources.Madera
        Me.BtnBorrar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.Color.White
        Me.BtnBorrar.Location = New System.Drawing.Point(12, 182)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(101, 43)
        Me.BtnBorrar.TabIndex = 2
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'DgvCarta
        '
        Me.DgvCarta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvCarta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarta.Location = New System.Drawing.Point(127, 49)
        Me.DgvCarta.Name = "DgvCarta"
        Me.DgvCarta.Size = New System.Drawing.Size(541, 471)
        Me.DgvCarta.TabIndex = 3
        '
        'CartaGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.textura_madera_7
        Me.ClientSize = New System.Drawing.Size(792, 532)
        Me.Controls.Add(Me.DgvCarta)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.MinimumSize = New System.Drawing.Size(808, 570)
        Me.Name = "CartaGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CartaGrid"
        CType(Me.DgvCarta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BtnBorrar As System.Windows.Forms.Button
    Friend WithEvents DgvCarta As System.Windows.Forms.DataGridView
End Class
