<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturacionDiariaForm
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
        Me.cmbmozo = New System.Windows.Forms.ComboBox
        Me.cmbmesa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DgvFacturacionDiaria = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.TextBox
        CType(Me.DgvFacturacionDiaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbmozo
        '
        Me.cmbmozo.FormattingEnabled = True
        Me.cmbmozo.Location = New System.Drawing.Point(28, 102)
        Me.cmbmozo.Name = "cmbmozo"
        Me.cmbmozo.Size = New System.Drawing.Size(121, 21)
        Me.cmbmozo.TabIndex = 0
        '
        'cmbmesa
        '
        Me.cmbmesa.FormattingEnabled = True
        Me.cmbmesa.Location = New System.Drawing.Point(28, 168)
        Me.cmbmesa.Name = "cmbmesa"
        Me.cmbmesa.Size = New System.Drawing.Size(121, 21)
        Me.cmbmesa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(279, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Facturacion del Dia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(49, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Por Mozo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(49, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Por Mesa"
        '
        'DgvFacturacionDiaria
        '
        Me.DgvFacturacionDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturacionDiaria.Location = New System.Drawing.Point(164, 64)
        Me.DgvFacturacionDiaria.Name = "DgvFacturacionDiaria"
        Me.DgvFacturacionDiaria.Size = New System.Drawing.Size(445, 392)
        Me.DgvFacturacionDiaria.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(360, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Dia"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(473, 475)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(136, 34)
        Me.txttotal.TabIndex = 7
        '
        'FacturacionDiariaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurante.My.Resources.Resources.Madera
        Me.ClientSize = New System.Drawing.Size(744, 517)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvFacturacionDiaria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmesa)
        Me.Controls.Add(Me.cmbmozo)
        Me.Name = "FacturacionDiariaForm"
        Me.Text = "FacturacionDiariaForm"
        CType(Me.DgvFacturacionDiaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbmozo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmesa As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DgvFacturacionDiaria As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
End Class
