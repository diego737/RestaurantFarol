<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AtencionForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.Mozo = New System.Windows.Forms.GroupBox
        Me.ComboMozo = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboClientes = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtnumatencion = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboMesa = New System.Windows.Forms.ComboBox
        Me.DgvDetalle = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ComboTipoFactura = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LFecha = New System.Windows.Forms.TextBox
        Me.DgvCarta1 = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Aceptarbutton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.subtotaltxt = New System.Windows.Forms.TextBox
        Me.DgvDetalle2 = New System.Windows.Forms.DataGridView
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nuevo = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mozo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvCarta1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ATENCION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(811, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "CARTA"
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Mozo
        '
        Me.Mozo.BackColor = System.Drawing.Color.Transparent
        Me.Mozo.Controls.Add(Me.ComboMozo)
        Me.Mozo.Location = New System.Drawing.Point(10, 45)
        Me.Mozo.Name = "Mozo"
        Me.Mozo.Size = New System.Drawing.Size(193, 54)
        Me.Mozo.TabIndex = 14
        Me.Mozo.TabStop = False
        Me.Mozo.Text = "Mozo"
        '
        'ComboMozo
        '
        Me.ComboMozo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboMozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMozo.FormattingEnabled = True
        Me.ComboMozo.Location = New System.Drawing.Point(3, 19)
        Me.ComboMozo.Name = "ComboMozo"
        Me.ComboMozo.Size = New System.Drawing.Size(187, 21)
        Me.ComboMozo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ComboClientes)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 55)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'ComboClientes
        '
        Me.ComboClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboClientes.FormattingEnabled = True
        Me.ComboClientes.Location = New System.Drawing.Point(3, 20)
        Me.ComboClientes.Name = "ComboClientes"
        Me.ComboClientes.Size = New System.Drawing.Size(187, 21)
        Me.ComboClientes.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtnumatencion)
        Me.GroupBox2.Location = New System.Drawing.Point(405, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 56)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Atencion N°"
        '
        'txtnumatencion
        '
        Me.txtnumatencion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnumatencion.Enabled = False
        Me.txtnumatencion.Location = New System.Drawing.Point(6, 22)
        Me.txtnumatencion.Name = "txtnumatencion"
        Me.txtnumatencion.Size = New System.Drawing.Size(186, 20)
        Me.txtnumatencion.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ComboMesa)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 58)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mesa"
        '
        'ComboMesa
        '
        Me.ComboMesa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboMesa.FormattingEnabled = True
        Me.ComboMesa.Location = New System.Drawing.Point(3, 26)
        Me.ComboMesa.Name = "ComboMesa"
        Me.ComboMesa.Size = New System.Drawing.Size(187, 21)
        Me.ComboMesa.TabIndex = 6
        '
        'DgvDetalle
        '
        Me.DgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(7, 196)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.Size = New System.Drawing.Size(10, 342)
        Me.DgvDetalle.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ComboTipoFactura)
        Me.GroupBox4.Location = New System.Drawing.Point(206, 105)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 58)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo Factura"
        '
        'ComboTipoFactura
        '
        Me.ComboTipoFactura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTipoFactura.FormattingEnabled = True
        Me.ComboTipoFactura.Location = New System.Drawing.Point(3, 26)
        Me.ComboTipoFactura.Name = "ComboTipoFactura"
        Me.ComboTipoFactura.Size = New System.Drawing.Size(187, 21)
        Me.ComboTipoFactura.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.LFecha)
        Me.GroupBox6.Location = New System.Drawing.Point(405, 105)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(198, 58)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fecha"
        '
        'LFecha
        '
        Me.LFecha.Location = New System.Drawing.Point(62, 20)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(100, 20)
        Me.LFecha.TabIndex = 0
        '
        'DgvCarta1
        '
        Me.DgvCarta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCarta1.Location = New System.Drawing.Point(609, 43)
        Me.DgvCarta1.Name = "DgvCarta1"
        Me.DgvCarta1.Size = New System.Drawing.Size(449, 495)
        Me.DgvCarta1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "DETALLE"
        '
        'Aceptarbutton
        '
        Me.Aceptarbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptarbutton.Location = New System.Drawing.Point(792, 552)
        Me.Aceptarbutton.Name = "Aceptarbutton"
        Me.Aceptarbutton.Size = New System.Drawing.Size(136, 38)
        Me.Aceptarbutton.TabIndex = 22
        Me.Aceptarbutton.Text = "Aceptar"
        Me.Aceptarbutton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 558)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Subtotal"
        '
        'subtotaltxt
        '
        Me.subtotaltxt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotaltxt.Location = New System.Drawing.Point(422, 552)
        Me.subtotaltxt.Name = "subtotaltxt"
        Me.subtotaltxt.Size = New System.Drawing.Size(145, 30)
        Me.subtotaltxt.TabIndex = 24
        '
        'DgvDetalle2
        '
        Me.DgvDetalle2.AllowUserToAddRows = False
        Me.DgvDetalle2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Categoria, Me.nombre, Me.Precio, Me.IdAtencion, Me.nuevo})
        Me.DgvDetalle2.Location = New System.Drawing.Point(30, 196)
        Me.DgvDetalle2.Name = "DgvDetalle2"
        Me.DgvDetalle2.Size = New System.Drawing.Size(537, 342)
        Me.DgvDetalle2.TabIndex = 25
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'IdAtencion
        '
        Me.IdAtencion.HeaderText = "IdAtencion"
        Me.IdAtencion.Name = "IdAtencion"
        Me.IdAtencion.Visible = False
        '
        'nuevo
        '
        Me.nuevo.HeaderText = "nuevo"
        Me.nuevo.Name = "nuevo"
        '
        'AtencionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.Madera
        Me.ClientSize = New System.Drawing.Size(1070, 594)
        Me.Controls.Add(Me.DgvDetalle2)
        Me.Controls.Add(Me.subtotaltxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Aceptarbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgvCarta1)
        Me.Controls.Add(Me.Mozo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgvDetalle)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(1086, 588)
        Me.Name = "AtencionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AtencionForm"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mozo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DgvCarta1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Mozo As System.Windows.Forms.GroupBox
    Friend WithEvents ComboMozo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnumatencion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboMesa As System.Windows.Forms.ComboBox
    Friend WithEvents DgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboTipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DgvCarta1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents subtotaltxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Aceptarbutton As System.Windows.Forms.Button
    Friend WithEvents DgvDetalle2 As System.Windows.Forms.DataGridView
    Friend WithEvents LFecha As System.Windows.Forms.TextBox
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nuevo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
