Imports System.Data.OleDb
Imports DAC
Public Class pLog : Inherits Persistente

#Region "Metodos"
    Public Function Eliminar(ByVal objeto As DataSet) As Boolean
        Try
            Dim unDSLog As dsLog
            Dim unLog As dsLog.RegistroLogsRow
            unDSLog = CType(objeto, dsLog)
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            Persistente.EjecutarSQL("DELETE FROM RegistroLogs")
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Function

    Public Function Leer() As Boolean
        Try
            Dim unDSLog As New dsLog
            Dim unLog As dsLog.RegistroLogsRow
            Dim unDR As OleDb.OleDbDataReader
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            unDR = EjecutarReader("SELECT * FROM RegistroLogs")
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD

    End Function

    Public Overloads Overrides Function buscar() As DataRowCollection
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal clave As Object) As Object
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Return Nothing
    End Function

    Public Overloads Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unDSLog As dsLog
            Dim unLog As dsLog.RegistroLogsRow
            unDSLog = CType(objeto, dsLog)
            unLog = CType(unDSLog.RegistroLogs.Rows(0), dsLog.RegistroLogsRow)
            Persistente.EjecutarSQL("INSERT INTO RegistroLogs (IdTipoEntradaEvento,NombreMaquina,OrigenEvento,NombreUsuario,Category,HoraEscritura,HoraGenerado,Mensaje,EventoCapturado) VALUES (" _
            & unLog.IdTipoEntradaEvento() & ",'" _
            & unLog.NombreMaquina.ToString() & "','" _
            & unLog.OrigenEvento.ToString() & "','" _
            & unLog.NombreUsuario.ToString() & "','" _
            & unLog.Category.ToString() & "','" _
            & unLog.HoraEscritura.ToString() & "','" _
            & unLog.HoraGenerado.ToString() & "','" _
            & unLog.Mensaje.ToString() & "','" _
            & unLog.EventoCapturado.ToString() & "')")

            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try

    End Function

    Public Overrides Function proximoId() As Integer

    End Function

#End Region
End Class
