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
        Dim unDS As DataSet
        unDS = Sistema.getLogs
        Dim unDV As DataView
        If Me.chkSeguridad.Checked = True Then

        End If


        unDV = unDS.Tables("RegistroLogs").DefaultView
        Dim reporte As New DAC.LogReport
        reporte.SetDataSource(unDV)
        Me.CrystalReportViewer.ReportSource = reporte
    End Sub

    Private Sub CrystalReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer.Load

    End Sub
End Class