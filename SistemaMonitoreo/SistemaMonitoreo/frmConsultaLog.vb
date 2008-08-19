Imports Dominio
Imports DAC.LogReport
Public Class frmConsultaLog
    Private DSLogsconEvento As DataSet


    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub btnVerReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerReporte.Click
        Try
            Dim Filtro As String = Nothing
            Dim TipoLog As String = Nothing
            'Traigo Dataset de Logs con los Eventos
            Dim getlogs As DataSet = DSLogsconEvento
            If Me.rdbSeguridad.Checked = True Then
                TipoLog = "EventoCapturado = 'Security'"
            ElseIf Me.rdbSistema.Checked = True Then
                TipoLog = "EventoCapturado = 'System'"
            ElseIf Me.rdbAplicacion.Checked = True Then
                TipoLog = "EventoCapturado = 'Application'"
            Else
                MessageBox.Show("Debe Seleccionar un tipo de Log")
            End If
            'Reporte por Tipo de Evento
            If Me.chkTipo.Checked = True And TipoLog IsNot Nothing Then
                Dim unDV As New DataView(getlogs.Tables("RegistroLogs"), TipoLog, "HoraEscritura", DataViewRowState.CurrentRows)
                Dim reporte As New DAC.LogReport
                reporte.SetDataSource(unDV)
                Me.CrystalReportViewer.ReportSource = reporte
                'Reporte por Fecha
            ElseIf Me.chkFecha.Checked = True And TipoLog IsNot Nothing Then
                Dim unDV As New DataView(getlogs.Tables("RegistroLogs"), TipoLog, "HoraEscritura", DataViewRowState.CurrentRows)
                Dim reporte As New DAC.LogReportFecha
                reporte.SetDataSource(unDV)
                Me.CrystalReportViewer.ReportSource = reporte
            ElseIf TipoLog Is Nothing Then
                MessageBox.Show("Debe Seleccionar un tipo de Log")
            Else
                MessageBox.Show("Debe Seleccionar un tipo de Filtro")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    Private Sub chkTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTipo.CheckedChanged
        If Me.chkTipo.Checked = True Then
            Me.chkFecha.Checked = False
        End If
    End Sub
    Private Sub chkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFecha.CheckedChanged
        If Me.chkFecha.Checked = True Then
            Me.chkTipo.Checked = False
        End If
    End Sub

    Private Sub frmConsultaLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DSLogsconEvento = LogConEvento.AllLogsconEvento
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_ADMIN) Then
            rdbAplicacion.Visible = True
            rdbSistema.Visible = True
            rdbSeguridad.Visible = True
        ElseIf Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_APLICACIONES) Then
            rdbAplicacion.Visible = True
        ElseIf Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_APLICACIONES_SISTEMA) Then
            rdbAplicacion.Visible = True
            rdbSeguridad.Visible = True
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class