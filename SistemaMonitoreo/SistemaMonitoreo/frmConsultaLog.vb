Imports Dominio
Imports DAC.LogReport
Public Class frmConsultaLog

    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub
    Private Sub frmConsultaLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clbTipoLog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbTipoLog.SelectedIndexChanged

    End Sub


    Private Sub btnVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerReporte.Click
        Dim getlogs As DataSet = LogConEvento.AllLogsconEvento


        If Me.rdbSeguridad.Checked = True Then
            Dim unDV As New DataView(getlogs.Tables("RegistroLogs"), "EventoCapturado = 'Security'", "HoraEscritura", DataViewRowState.CurrentRows)
            Dim reporte As New DAC.LogReport
            reporte.SetDataSource(unDV)
            Me.CrystalReportViewer.ReportSource = reporte
        ElseIf Me.rdbSistema.Checked = True Then
            Dim unDV As New DataView(getlogs.Tables("RegistroLogs"), "EventoCapturado = 'System'", "HoraEscritura", DataViewRowState.CurrentRows)
            Dim reporte As New DAC.LogReport
            reporte.SetDataSource(unDV)
            Me.CrystalReportViewer.ReportSource = reporte
        ElseIf Me.rdbAplicacion.Checked = True Then
            Dim unDV As New DataView(getlogs.Tables("RegistroLogs"), "EventoCapturado = 'Application'", "HoraEscritura", DataViewRowState.CurrentRows)
            Dim reporte As New DAC.LogReport
            reporte.SetDataSource(unDV)

            Me.CrystalReportViewer.ReportSource = reporte

        End If

       
    End Sub

    Private Sub CrystalReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer.Load

    End Sub
    Private Sub rdbSeguridad_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSeguridad.CheckedChanged
        If Me.rdbSeguridad.Checked = True Then
            Me.rdbAplicacion.Checked = False
            Me.rdbSistema.Checked = False
        End If
    End Sub
    Private Sub rdbAplicacion_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbAplicacion.CheckedChanged
        If Me.rdbAplicacion.Checked = True Then
            Me.rdbSeguridad.Checked = False
            Me.rdbSistema.Checked = False
        End If
    End Sub
    Private Sub rdbSistema_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbSistema.CheckedChanged
        If Me.rdbSistema.Checked = True Then
            Me.rdbAplicacion.Checked = False
            Me.rdbSeguridad.Checked = False
        End If
    End Sub
End Class