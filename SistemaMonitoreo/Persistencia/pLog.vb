Imports System.Data.OleDb
Imports DAC
Public Class pLog : Inherits Persistente
    Public Function Eliminar(ByVal objeto As DataSet) As Boolean
        Try
            Dim unDSLog As dsLog
            Dim unLog As dsLog.RegistroLogsRow
            unDSLog = CType(objeto, dsLog)
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            pLog.EjecutarSQL("DELETE FROM RegistroLogs")
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Function

    Public Function Guardar(ByVal objeto As DataSet) As Boolean
        Try
            Dim unDSLog As dsLog
            Dim unLog As dsLog.RegistroLogsRow
            unDSLog = CType(objeto, dsLog)
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            pLog.EjecutarSQL("INSERT INTO RegistroLogs (IdTipoEntradaEvento,NombreMaquina,OrigenEvento,NombreUsuario,Category,HoraEscritura,HoraGenerado,Mensaje) VALUES (" _
            & unLog.IdTipoEntradaEvento() & ",'" _
            & unLog.NombreMaquina.ToString() & "','" _
            & unLog.OrigenEvento.ToString() & "','" _
            & unLog.NombreUsuario.ToString() & "','" _
            & unLog.Category.ToString() & "','" _
            & unLog.HoraEscritura.ToString() & "','" _
            & unLog.HoraGenerado.ToString() & "','" _
            & unLog.Mensaje.ToString() & "')")
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Function Leer(ByVal objeto As DataSet) As DataSet
        Try
            Dim unDSLog As dsLog
            Dim unLog As dsLog.RegistroLogsRow
            Dim unDR As OleDb.OleDbDataReader
            unDSLog = CType(objeto, dsLog)
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            unDR = pLog.EjecutarReader("SELECT * FROM RegistroLogs")

            Return unDSLog
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
