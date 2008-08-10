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
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.clbTipoLog = New System.Windows.Forms.CheckedListBox
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rdbAplicacion = New System.Windows.Forms.RadioButton
        Me.rdbSeguridad = New System.Windows.Forms.RadioButton
        Me.rdbSistema = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(401, 13)
        Me.btnVerReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(181, 32)
        Me.btnVerReporte.TabIndex = 0
        Me.btnVerReporte.Text = "Ver reporte"
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(401, 73)
        Me.chkFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(97, 22)
        Me.chkFecha.TabIndex = 5
        Me.chkFecha.Text = "Por fecha"
        Me.chkFecha.UseVisualStyleBackColor = True
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
        'clbTipoLog
        '
        Me.clbTipoLog.FormattingEnabled = True
        Me.clbTipoLog.Location = New System.Drawing.Point(590, 13)
        Me.clbTipoLog.Margin = New System.Windows.Forms.Padding(4)
        Me.clbTipoLog.Name = "clbTipoLog"
        Me.clbTipoLog.Size = New System.Drawing.Size(172, 88)
        Me.clbTipoLog.TabIndex = 7
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Location = New System.Drawing.Point(16, 109)
        Me.CrystalReportViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(806, 352)
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
        '
        'rdbSistema
        '
        Me.rdbSistema.AutoSize = True
        Me.rdbSistema.Location = New System.Drawing.Point(277, 77)
        Me.rdbSistema.Name = "rdbSistema"
        Me.rdbSistema.Size = New System.Drawing.Size(127, 22)
        Me.rdbSistema.TabIndex = 11
        Me.rdbSistema.TabStop = True
        Me.rdbSistema.Text = "RadioButton3"
        Me.rdbSistema.UseVisualStyleBackColor = True
        '
        'frmConsultaLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 474)
        Me.Controls.Add(Me.rdbSistema)
        Me.Controls.Add(Me.rdbSeguridad)
        Me.Controls.Add(Me.rdbAplicacion)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Controls.Add(Me.clbTipoLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFecha)
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
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clbTipoLog As System.Windows.Forms.CheckedListBox
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rdbAplicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSeguridad As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSistema As System.Windows.Forms.RadioButton
End Class
