<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclientes))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtNomyape = New System.Windows.Forms.TextBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.ComboBoxProvincias = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(230, 344)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 43)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAceptar.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(108, 344)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(101, 43)
        Me.btnAceptar.TabIndex = 18
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Dni:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id.:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(117, 226)
        Me.txtTelefono.Multiline = True
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(267, 30)
        Me.txtTelefono.TabIndex = 17
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(117, 172)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(267, 30)
        Me.txtDireccion.TabIndex = 16
        '
        'txtNomyape
        '
        Me.txtNomyape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomyape.Location = New System.Drawing.Point(117, 64)
        Me.txtNomyape.Multiline = True
        Me.txtNomyape.Name = "txtNomyape"
        Me.txtNomyape.Size = New System.Drawing.Size(267, 30)
        Me.txtNomyape.TabIndex = 14
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(51, 9)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(40, 32)
        Me.txtId.TabIndex = 13
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(117, 121)
        Me.txtDni.Multiline = True
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(267, 30)
        Me.txtDni.TabIndex = 15
        '
        'ComboBoxProvincias
        '
        Me.ComboBoxProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProvincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxProvincias.FormattingEnabled = True
        Me.ComboBoxProvincias.Location = New System.Drawing.Point(117, 289)
        Me.ComboBoxProvincias.Name = "ComboBoxProvincias"
        Me.ComboBoxProvincias.Size = New System.Drawing.Size(267, 28)
        Me.ComboBoxProvincias.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Localidad:"
        '
        'frmclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.background_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(432, 409)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxProvincias)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNomyape)
        Me.Controls.Add(Me.txtId)
        Me.Name = "frmclientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmclientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNomyape As System.Windows.Forms.TextBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProvincias As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
