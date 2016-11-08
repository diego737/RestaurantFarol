<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtencionencursoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NuevaAtencionbutton = New System.Windows.Forms.Button
        Me.AtencionesEnCurso = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Atenciones = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.AtencionesDgv = New System.Windows.Forms.DataGridView
        Me.ModicarButton = New System.Windows.Forms.Button
        Me.borrarButton = New System.Windows.Forms.Button
        Me.AtencionesEnCurso.SuspendLayout()
        Me.Atenciones.SuspendLayout()
        CType(Me.AtencionesDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuevaAtencionbutton
        '
        Me.NuevaAtencionbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaAtencionbutton.Location = New System.Drawing.Point(225, 12)
        Me.NuevaAtencionbutton.Name = "NuevaAtencionbutton"
        Me.NuevaAtencionbutton.Size = New System.Drawing.Size(183, 37)
        Me.NuevaAtencionbutton.TabIndex = 0
        Me.NuevaAtencionbutton.Text = "Nueva Atencion"
        Me.NuevaAtencionbutton.UseVisualStyleBackColor = True
        '
        'AtencionesEnCurso
        '
        Me.AtencionesEnCurso.Controls.Add(Me.Label4)
        Me.AtencionesEnCurso.Controls.Add(Me.Label3)
        Me.AtencionesEnCurso.Controls.Add(Me.Label2)
        Me.AtencionesEnCurso.Controls.Add(Me.Button3)
        Me.AtencionesEnCurso.Controls.Add(Me.Label1)
        Me.AtencionesEnCurso.Controls.Add(Me.Atenciones)
        Me.AtencionesEnCurso.Controls.Add(Me.AtencionesDgv)
        Me.AtencionesEnCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtencionesEnCurso.Location = New System.Drawing.Point(89, 71)
        Me.AtencionesEnCurso.Name = "AtencionesEnCurso"
        Me.AtencionesEnCurso.Size = New System.Drawing.Size(575, 450)
        Me.AtencionesEnCurso.TabIndex = 2
        Me.AtencionesEnCurso.TabStop = False
        Me.AtencionesEnCurso.Text = "Atenciones en Curso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Facturadas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(466, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "La"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sin Facturar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 404)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Facturar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(466, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "La"
        '
        'Atenciones
        '
        Me.Atenciones.Controls.Add(Me.Button5)
        Me.Atenciones.Controls.Add(Me.Button4)
        Me.Atenciones.Controls.Add(Me.Button2)
        Me.Atenciones.Controls.Add(Me.Button1)
        Me.Atenciones.Location = New System.Drawing.Point(469, 34)
        Me.Atenciones.Name = "Atenciones"
        Me.Atenciones.Size = New System.Drawing.Size(100, 258)
        Me.Atenciones.TabIndex = 5
        Me.Atenciones.TabStop = False
        Me.Atenciones.Text = "Buscar"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(10, 206)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 35)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "A Facturar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 35)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Facturadas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Actuales"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Todas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AtencionesDgv
        '
        Me.AtencionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtencionesDgv.Location = New System.Drawing.Point(3, 34)
        Me.AtencionesDgv.Name = "AtencionesDgv"
        Me.AtencionesDgv.Size = New System.Drawing.Size(457, 364)
        Me.AtencionesDgv.TabIndex = 0
        '
        'ModicarButton
        '
        Me.ModicarButton.Location = New System.Drawing.Point(2, 115)
        Me.ModicarButton.Name = "ModicarButton"
        Me.ModicarButton.Size = New System.Drawing.Size(84, 34)
        Me.ModicarButton.TabIndex = 1
        Me.ModicarButton.Text = "Modificar"
        Me.ModicarButton.UseVisualStyleBackColor = True
        '
        'borrarButton
        '
        Me.borrarButton.Location = New System.Drawing.Point(2, 155)
        Me.borrarButton.Name = "borrarButton"
        Me.borrarButton.Size = New System.Drawing.Size(84, 34)
        Me.borrarButton.TabIndex = 3
        Me.borrarButton.Text = "Borrar"
        Me.borrarButton.UseVisualStyleBackColor = True
        '
        'AtencionencursoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 533)
        Me.Controls.Add(Me.AtencionesEnCurso)
        Me.Controls.Add(Me.NuevaAtencionbutton)
        Me.Controls.Add(Me.borrarButton)
        Me.Controls.Add(Me.ModicarButton)
        Me.Name = "AtencionencursoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.AtencionesEnCurso.ResumeLayout(False)
        Me.AtencionesEnCurso.PerformLayout()
        Me.Atenciones.ResumeLayout(False)
        CType(Me.AtencionesDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NuevaAtencionbutton As System.Windows.Forms.Button
    Friend WithEvents AtencionesEnCurso As System.Windows.Forms.GroupBox
    Friend WithEvents AtencionesDgv As System.Windows.Forms.DataGridView
    Friend WithEvents ModicarButton As System.Windows.Forms.Button
    Friend WithEvents borrarButton As System.Windows.Forms.Button
    Friend WithEvents Atenciones As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
