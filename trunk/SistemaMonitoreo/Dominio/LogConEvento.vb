Imports Persistencia
Imports DAC
Public Class LogConEvento

    'Traigo Logs y Tipos de Evento, y creo un Dataset Tipado 
    'con Logs y columna de Tipo Evento
    Public Shared Function AllLogsconEvento() As dsLogConEvento
        Try
            Dim i, j As Integer
            i = 0
            j = 0
            Dim LogsconEvento As New dsLogConEvento
            Dim Logs As DataView
            Dim Eventos As DataView
            Eventos = TipoEvento.DataViewTipos 'tabla2 sorted by IdEvento
            Logs = Log.DataViewLogs
            Logs.Sort = "IdTipoEntradaEvento" 'tabla 1 Sorted by IdEvento
            Dim unlog As DataRow
            Dim Idrelacion As Integer
            Dim tipos As DataRow
            tipos = Eventos.Item(0).Row
            Idrelacion = 1
            Dim unlogId As Integer = 1
            While i < Logs.Count And j <= 4
                tipos = Eventos.Item(j).Row
                tipos = CType(Eventos.Item(j).Row, dsTipoEntradaEvento.TipoEntradaEventoRow)
                While unlogId = Idrelacion And i < Logs.Count
                    unlog = Logs.Item(i).Row
                    unlog = CType(Logs.Item(i).Row, dsLog.RegistroLogsRow)
                    LogsconEvento.RegistroLogs.AddRegistroLogsRow(CInt(unlog.Item("IdTipoEntradaEvento").ToString) _
                , unlog.Item("NombreMaquina").ToString, unlog.Item("OrigenEvento").ToString _
                , unlog.Item("NombreUsuario").ToString, unlog.Item("Category").ToString _
                , unlog.Item("HoraEscritura").ToString, unlog.Item("HoraGenerado").ToString _
                , unlog.Item("Mensaje").ToString, unlog.Item("EventoCapturado").ToString, tipos.Item("NombreEspaniol").ToString)
                    unlogId = CInt(unlog.Item("IdTipoEntradaEvento").ToString)
                    i += 1
                End While
                Idrelacion = CInt(2 ^ (CInt(tipos.Item("Id").ToString) - 1))
                j += 1
            End While

            Return LogsconEvento
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
