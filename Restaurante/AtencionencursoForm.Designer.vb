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
        Me.AtencionesDgv = New System.Windows.Forms.DataGridView
        Me.ModicarButton = New System.Windows.Forms.Button
        Me.borrarButton = New System.Windows.Forms.Button
        Me.AtencionesEnCurso.SuspendLayout()
        CType(Me.AtencionesDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuevaAtencionbutton
        '
        Me.NuevaAtencionbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevaAtencionbutton.Location = New System.Drawing.Point(126, 12)
        Me.NuevaAtencionbutton.Name = "NuevaAtencionbutton"
        Me.NuevaAtencionbutton.Size = New System.Drawing.Size(183, 37)
        Me.NuevaAtencionbutton.TabIndex = 0
        Me.NuevaAtencionbutton.Text = "Nueva Atencion"
        Me.NuevaAtencionbutton.UseVisualStyleBackColor = True
        '
        'AtencionesEnCurso
        '
        Me.AtencionesEnCurso.Controls.Add(Me.AtencionesDgv)
        Me.AtencionesEnCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtencionesEnCurso.Location = New System.Drawing.Point(40, 71)
        Me.AtencionesEnCurso.Name = "AtencionesEnCurso"
        Me.AtencionesEnCurso.Size = New System.Drawing.Size(366, 404)
        Me.AtencionesEnCurso.TabIndex = 2
        Me.AtencionesEnCurso.TabStop = False
        Me.AtencionesEnCurso.Text = "Atenciones en Curso"
        '
        'AtencionesDgv
        '
        Me.AtencionesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AtencionesDgv.Location = New System.Drawing.Point(3, 34)
        Me.AtencionesDgv.Name = "AtencionesDgv"
        Me.AtencionesDgv.Size = New System.Drawing.Size(357, 364)
        Me.AtencionesDgv.TabIndex = 0
        '
        'ModicarButton
        '
        Me.ModicarButton.Location = New System.Drawing.Point(412, 120)
        Me.ModicarButton.Name = "ModicarButton"
        Me.ModicarButton.Size = New System.Drawing.Size(75, 23)
        Me.ModicarButton.TabIndex = 1
        Me.ModicarButton.Text = "Modificar"
        Me.ModicarButton.UseVisualStyleBackColor = True
        '
        'borrarButton
        '
        Me.borrarButton.Location = New System.Drawing.Point(412, 149)
        Me.borrarButton.Name = "borrarButton"
        Me.borrarButton.Size = New System.Drawing.Size(75, 23)
        Me.borrarButton.TabIndex = 3
        Me.borrarButton.Text = "Borrar"
        Me.borrarButton.UseVisualStyleBackColor = True
        '
        'AtencionencursoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 487)
        Me.Controls.Add(Me.borrarButton)
        Me.Controls.Add(Me.ModicarButton)
        Me.Controls.Add(Me.AtencionesEnCurso)
        Me.Controls.Add(Me.NuevaAtencionbutton)
        Me.Name = "AtencionencursoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atencionencurso"
        Me.AtencionesEnCurso.ResumeLayout(False)
        CType(Me.AtencionesDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NuevaAtencionbutton As System.Windows.Forms.Button
    Friend WithEvents AtencionesEnCurso As System.Windows.Forms.GroupBox
    Friend WithEvents AtencionesDgv As System.Windows.Forms.DataGridView
    Friend WithEvents ModicarButton As System.Windows.Forms.Button
    Friend WithEvents borrarButton As System.Windows.Forms.Button
End Class
