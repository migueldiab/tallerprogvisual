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

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim i As Integer
        Dim myEnumval As [Enum]
        Dim unLog As New EventLog
        For i = 0 To 2
            myEnumval = CType(i, TipoLogs)
            unLog.Log = myEnumval.ToString
            unLog.MachineName = "."
            Dim unaEntry As EventLogEntry
            For Each unaEntry In unLog.Entries
                Dim NewLog As New Log
                NewLog.EventoCapturado = myEnumval.ToString
                NewLog.Category = unaEntry.Category
                NewLog.HoraEscritura = unaEntry.TimeWritten.Date.ToShortDateString
                NewLog.HoraGenerado = unaEntry.TimeGenerated.Date.ToShortDateString
                NewLog.IdTipoEntradaEvento = unaEntry.CategoryNumber
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




    End Sub
End Class
