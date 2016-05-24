<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmesas))
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Id = New System.Windows.Forms.Label
        Me.Detalle = New System.Windows.Forms.Label
        Me.txtid = New System.Windows.Forms.TextBox
        Me.txtdetalle = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackgroundImage = CType(resources.GetObject("BtnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.BtnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(61, 129)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(101, 43)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCancelar.ForeColor = System.Drawing.Color.White
        Me.BtnCancelar.Location = New System.Drawing.Point(192, 129)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(101, 43)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.BackColor = System.Drawing.Color.Transparent
        Me.Id.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.ForeColor = System.Drawing.Color.White
        Me.Id.Location = New System.Drawing.Point(12, 13)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(25, 20)
        Me.Id.TabIndex = 2
        Me.Id.Text = "Id"
        '
        'Detalle
        '
        Me.Detalle.AutoSize = True
        Me.Detalle.BackColor = System.Drawing.Color.Transparent
        Me.Detalle.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detalle.ForeColor = System.Drawing.Color.White
        Me.Detalle.Location = New System.Drawing.Point(12, 73)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(65, 20)
        Me.Detalle.TabIndex = 3
        Me.Detalle.Text = "Detalle"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(61, 4)
        Me.txtid.Multiline = True
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(34, 28)
        Me.txtid.TabIndex = 4
        '
        'txtdetalle
        '
        Me.txtdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalle.Location = New System.Drawing.Point(98, 62)
        Me.txtdetalle.Multiline = True
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(216, 31)
        Me.txtdetalle.TabIndex = 5
        '
        'frmesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.background_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(360, 192)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Detalle)
        Me.Controls.Add(Me.Id)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.MinimumSize = New System.Drawing.Size(376, 230)
        Me.Name = "frmesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmesas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents Detalle As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtdetalle As System.Windows.Forms.TextBox
End Class
