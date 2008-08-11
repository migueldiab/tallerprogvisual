Imports System.Diagnostics
Imports Dominio

Public Class frmLog
    Enum TipoLogs
        System = 0
        Security = 1
        Application = 2
    End Enum

    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'get a reference to the backgroundworker
        Dim BGW As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        'Some time consuming process
        Dim i As Integer
        Dim percent As Integer = 0
        Dim p As Integer = 0
        Dim myEnumval As [Enum]
        Dim unLog As New EventLog
        Dim total As Integer
        Try
            For i = 0 To 2
                p = 0
                percent = 0
                myEnumval = CType(i, TipoLogs)
                unLog.Log = myEnumval.ToString
                unLog.MachineName = "."
                Dim unaEntry As EventLogEntry
                total = unLog.Entries.Count
                For Each unaEntry In unLog.Entries
                    p += 1
                    Percent = CInt(p / total * 100)
                    If percent > 100 Then
                        percent = 100
                    End If
                    BackgroundWorker1.ReportProgress(percent)
                    Dim NewLog As New Log
                    NewLog.EventoCapturado = myEnumval.ToString
                    NewLog.Category = unaEntry.Category
                    NewLog.HoraEscritura = unaEntry.TimeWritten.Date.ToShortDateString
                    NewLog.HoraGenerado = unaEntry.TimeGenerated.Date.ToShortDateString
                    NewLog.IdTipoEntradaEvento = unaEntry.EntryType
                    NewLog.NombreMaquina = unaEntry.MachineName
                    NewLog.Mensaje = unaEntry.Message
                    If unaEntry.UserName IsNot Nothing Then
                        NewLog.NombreUsuario = unaEntry.UserName
                    Else
                        NewLog.NombreUsuario = "N/A"
                    End If
                    NewLog.OrigenEvento = unaEntry.Source
                    NewLog.Guardar()
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
      

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Here's where you update the progressbar
        Try
            Progress.Value = e.ProgressPercentage
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        'Notify user the process is finished

        Me.lblLog.Text = "Completado"

    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        BackgroundWorker1.RunWorkerAsync()
        Me.lblLog.Text = "Procesando, espere "
    End Sub

    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
    End Sub
End Class
