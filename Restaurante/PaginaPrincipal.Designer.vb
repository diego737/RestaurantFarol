<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AtencionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AtencionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaAtencionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CartaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.Restaurante.My.Resources.Resources.textura_madera_roja
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtencionToolStripMenuItem, Me.ClientesToolStripMenuItem1, Me.CartaToolStripMenuItem, Me.CategoriasToolStripMenuItem1, Me.MesasToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.ProveedoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1285, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AtencionToolStripMenuItem
        '
        Me.AtencionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AtencionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtencionesToolStripMenuItem, Me.ConsultaAtencionesToolStripMenuItem})
        Me.AtencionToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AtencionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AtencionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AtencionToolStripMenuItem.Name = "AtencionToolStripMenuItem"
        Me.AtencionToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.AtencionToolStripMenuItem.Text = "Atencion"
        '
        'AtencionesToolStripMenuItem
        '
        Me.AtencionesToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.textura_madera_roja
        Me.AtencionesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AtencionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AtencionesToolStripMenuItem.Name = "AtencionesToolStripMenuItem"
        Me.AtencionesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AtencionesToolStripMenuItem.Text = "Atenciones"
        '
        'ConsultaAtencionesToolStripMenuItem
        '
        Me.ConsultaAtencionesToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.textura_madera_roja
        Me.ConsultaAtencionesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConsultaAtencionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ConsultaAtencionesToolStripMenuItem.Name = "ConsultaAtencionesToolStripMenuItem"
        Me.ConsultaAtencionesToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ConsultaAtencionesToolStripMenuItem.Text = "Consulta Atenciones"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(84, 36)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'CartaToolStripMenuItem
        '
        Me.CartaToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CartaToolStripMenuItem.Name = "CartaToolStripMenuItem"
        Me.CartaToolStripMenuItem.Size = New System.Drawing.Size(63, 36)
        Me.CartaToolStripMenuItem.Text = "Carta"
        '
        'CategoriasToolStripMenuItem1
        '
        Me.CategoriasToolStripMenuItem1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriasToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        Me.CategoriasToolStripMenuItem1.Size = New System.Drawing.Size(107, 36)
        Me.CategoriasToolStripMenuItem1.Text = "Categorias"
        '
        'MesasToolStripMenuItem
        '
        Me.MesasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem"
        Me.MesasToolStripMenuItem.Size = New System.Drawing.Size(71, 36)
        Me.MesasToolStripMenuItem.Text = "Mesas"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(92, 36)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(123, 36)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Restaurante.My.Resources.Resources.textura02
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1199, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.pagprincipal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1285, 581)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PaginaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurante Nuevo Farol"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AtencionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtencionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaAtencionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CartaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
