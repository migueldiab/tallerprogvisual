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
        Me.chkAplicaciones = New System.Windows.Forms.CheckBox
        Me.chkSeguridad = New System.Windows.Forms.CheckBox
        Me.chkSistema = New System.Windows.Forms.CheckBox
        Me.chkFecha = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.clbTipoLog = New System.Windows.Forms.CheckedListBox
        Me.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnVerReporte
        '
        Me.btnVerReporte.Location = New System.Drawing.Point(336, 59)
        Me.btnVerReporte.Name = "btnVerReporte"
        Me.btnVerReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnVerReporte.TabIndex = 0
        Me.btnVerReporte.Text = "Ver reporte"
        Me.btnVerReporte.UseVisualStyleBackColor = True
        '
        'chkAplicaciones
        '
        Me.chkAplicaciones.AutoSize = True
        Me.chkAplicaciones.Location = New System.Drawing.Point(37, 65)
        Me.chkAplicaciones.Name = "chkAplicaciones"
        Me.chkAplicaciones.Size = New System.Drawing.Size(86, 17)
        Me.chkAplicaciones.TabIndex = 1
        Me.chkAplicaciones.Text = "Aplicaciones"
        Me.chkAplicaciones.UseVisualStyleBackColor = True
        '
        'chkSeguridad
        '
        Me.chkSeguridad.AutoSize = True
        Me.chkSeguridad.Location = New System.Drawing.Point(37, 88)
        Me.chkSeguridad.Name = "chkSeguridad"
        Me.chkSeguridad.Size = New System.Drawing.Size(74, 17)
        Me.chkSeguridad.TabIndex = 2
        Me.chkSeguridad.Text = "Seguridad"
        Me.chkSeguridad.UseVisualStyleBackColor = True
        '
        'chkSistema
        '
        Me.chkSistema.AutoSize = True
        Me.chkSistema.Location = New System.Drawing.Point(37, 111)
        Me.chkSistema.Name = "chkSistema"
        Me.chkSistema.Size = New System.Drawing.Size(63, 17)
        Me.chkSistema.TabIndex = 3
        Me.chkSistema.Text = "Sistema"
        Me.chkSistema.UseVisualStyleBackColor = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(244, 111)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(72, 17)
        Me.chkFecha.TabIndex = 5
        Me.chkFecha.Text = "Por fecha"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Seleccione Tipo de Log a mostrar"
        '
        'clbTipoLog
        '
        Me.clbTipoLog.FormattingEnabled = True
        Me.clbTipoLog.Location = New System.Drawing.Point(354, 111)
        Me.clbTipoLog.Name = "clbTipoLog"
        Me.clbTipoLog.Size = New System.Drawing.Size(120, 94)
        Me.clbTipoLog.TabIndex = 7
        '
        'CrystalReportViewer
        '
        Me.CrystalReportViewer.ActiveViewIndex = -1
        Me.CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer.Location = New System.Drawing.Point(12, 249)
        Me.CrystalReportViewer.Name = "CrystalReportViewer"
        Me.CrystalReportViewer.SelectionFormula = ""
        Me.CrystalReportViewer.Size = New System.Drawing.Size(538, 230)
        Me.CrystalReportViewer.TabIndex = 8
        Me.CrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'frmConsultaLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 491)
        Me.Controls.Add(Me.CrystalReportViewer)
        Me.Controls.Add(Me.clbTipoLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkFecha)
        Me.Controls.Add(Me.chkSistema)
        Me.Controls.Add(Me.chkSeguridad)
        Me.Controls.Add(Me.chkAplicaciones)
        Me.Controls.Add(Me.btnVerReporte)
        Me.Name = "frmConsultaLog"
        Me.Text = "Consulta de Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerReporte As System.Windows.Forms.Button
    Friend WithEvents chkAplicaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguridad As System.Windows.Forms.CheckBox
    Friend WithEvents chkSistema As System.Windows.Forms.CheckBox
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clbTipoLog As System.Windows.Forms.CheckedListBox
    Friend WithEvents CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
