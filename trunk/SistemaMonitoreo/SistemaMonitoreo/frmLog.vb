Imports System.Diagnostics
Imports Dominio
Public Class frmLog


    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Dim unLog As New EventLog
        Dim i As Integer = 0
        unLog.Log = "System"
        unLog.MachineName = "."
        Dim unaEntry As EventLogEntry
        For Each unaEntry In unLog.Entries
            Dim NewLog As New Log
            NewLog.Category = unaEntry.Category
            NewLog.HoraEscritura = unaEntry.TimeWritten.ToString
            NewLog.HoraGenerado = unaEntry.TimeGenerated.ToString
            NewLog.IdTipoEntradaEvento = unaEntry.CategoryNumber
            NewLog.NombreMaquina = unaEntry.MachineName
            NewLog.Mensaje = unaEntry.Message
            NewLog.NombreUsuario = unaEntry.UserName
            NewLog.OrigenEvento = unaEntry.Source
            NewLog.Guardar()
        Next

        


    End Sub
End Class