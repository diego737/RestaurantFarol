<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptFactura))
        Me.cristalfactura = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Factura1 = New Restaurante.Factura
        Me.SuspendLayout()
        '
        'cristalfactura
        '
        Me.cristalfactura.ActiveViewIndex = 0
        Me.cristalfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cristalfactura.DisplayGroupTree = False
        Me.cristalfactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cristalfactura.Location = New System.Drawing.Point(0, 0)
        Me.cristalfactura.Name = "cristalfactura"
        Me.cristalfactura.ReportSource = Me.Factura1
        Me.cristalfactura.Size = New System.Drawing.Size(481, 428)
        Me.cristalfactura.TabIndex = 0
        '
        'rptFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 428)
        Me.Controls.Add(Me.cristalfactura)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptFactura"
        Me.Text = "Factura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cristalfactura As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Factura1 As Restaurante.Factura
End Class
