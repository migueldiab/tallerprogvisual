<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVerReporte = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rdbAplicacion = New System.Windows.Forms.RadioButton
        Me.rdbSeguridad = New System.Windows.Forms.RadioButton
        Me.rdbSistema = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkTipo = New System.Windows.Forms.CheckBox
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(692, 9)
        Me.btnVerReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(127, 32)
        Me.btnVerReporte.TabIndex = 0
        Me.btnVerReporte.Text = "Ver reporte"
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione Tipo de Log a mostrar"
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Location = New System.Drawing.Point(6, 109)
        Me.CrystalReportViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(824, 363)
        Me.CrystalReportViewer.TabIndex = 8
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'rdbAplicacion
        '
        Me.rdbAplicacion.AutoSize = True
        Me.rdbAplicacion.Location = New System.Drawing.Point(277, 13)
        Me.rdbAplicacion.Name = "rdbAplicacion"
        Me.rdbAplicacion.Size = New System.Drawing.Size(98, 22)
        Me.rdbAplicacion.TabIndex = 9
        Me.rdbAplicacion.TabStop = True
        Me.rdbAplicacion.Text = "Aplicacion"
        Me.rdbAplicacion.UseVisualStyleBackColor = True
        Me.rdbAplicacion.Visible = False
        '
        'rdbSeguridad
        '
        Me.rdbSeguridad.AutoSize = True
        Me.rdbSeguridad.Location = New System.Drawing.Point(277, 42)
        Me.rdbSeguridad.Name = "rdbSeguridad"
        Me.rdbSeguridad.Size = New System.Drawing.Size(99, 22)
        Me.rdbSeguridad.TabIndex = 10
        Me.rdbSeguridad.TabStop = True
        Me.rdbSeguridad.Text = "Seguridad"
        Me.rdbSeguridad.UseVisualStyleBackColor = True
        Me.rdbSeguridad.Visible = False
        '
        'rdbSistema
        '
        Me.rdbSistema.AutoSize = True
        Me.rdbSistema.Location = New System.Drawing.Point(277, 70)
        Me.rdbSistema.Name = "rdbSistema"
        Me.rdbSistema.Size = New System.Drawing.Size(86, 22)
        Me.rdbSistema.TabIndex = 11
        Me.rdbSistema.TabStop = True
        Me.rdbSistema.Text = "Sistema"
        Me.rdbSistema.UseVisualStyleBackColor = True
        Me.rdbSistema.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Seleccione filtro"
        '
        'chkTipo
        '
        Me.chkTipo.AutoSize = True
        Me.chkTipo.Location = New System.Drawing.Point(449, 37)
        Me.chkTipo.Name = "chkTipo"
        Me.chkTipo.Size = New System.Drawing.Size(58, 22)
        Me.chkTipo.TabIndex = 15
        Me.chkTipo.Text = "Tipo"
        Me.chkTipo.UseVisualStyleBackColor = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(449, 71)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(71, 22)
        Me.chkFecha.TabIndex = 16
        Me.chkFecha.Text = "Fecha"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(692, 49)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(127, 32)
        Me.btnCerrar.TabIndex = 17
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmConsultaLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 474)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.chkTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbSistema)
        Me.Controls.Add(Me.rdbSeguridad)
        Me.Controls.Add(Me.rdbAplicacion)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVerReporte)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmConsultaLog"
        Me.Text = "Consulta de Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rdbAplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSeguridad As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSistema As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
