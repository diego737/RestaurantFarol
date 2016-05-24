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
        Me.RestauranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestauranteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 44)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RestauranteToolStripMenuItem
        '
        Me.RestauranteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.RestauranteToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.RestauranteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.MesasToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.RestauranteToolStripMenuItem.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestauranteToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestauranteToolStripMenuItem.Name = "RestauranteToolStripMenuItem"
        Me.RestauranteToolStripMenuItem.Size = New System.Drawing.Size(137, 40)
        Me.RestauranteToolStripMenuItem.Text = "Restaurante"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.PersonalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'MesasToolStripMenuItem
        '
        Me.MesasToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.MesasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem"
        Me.MesasToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.MesasToolStripMenuItem.Text = "Mesas"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.CategoriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackgroundImage = Global.Restaurante.My.Resources.Resources.barrarestaurante
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.Bienvenida
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 410)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PaginaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurante Nuevo Farol"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RestauranteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
