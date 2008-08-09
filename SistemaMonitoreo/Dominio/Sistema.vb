Imports Persistencia
Public Class Sistema
    Private Shared Instancia As Sistema
#Region "Metodos"
    Public Shared Function getInstancia() As Sistema
        If Instancia Is Nothing Then
            Instancia = New Sistema
        End If
        Return Instancia
    End Function

    ' Función   : Devuelve todos los usuarios
    ' Entrada   : 
    ' Salida    : Lista con todos los usuarios ordenados alfabeticamente
    ' Notas     :
    Public Shared Function listaUsuarios() As ArrayList
        Dim rawDataUsuarios As DataRowCollection
        Dim arrayUsuarios As New ArrayList
        Dim pUsuario As New pUsuario
        rawDataUsuarios = pUsuario.buscar()
        For Each unUsuario As DataRow In rawDataUsuarios
            Dim tempUsuario As New Usuario
            tempUsuario.id = unUsuario.Item(0).ToString()
            tempUsuario.nombre = unUsuario.Item(1).ToString()
            tempUsuario.contrasenia = unUsuario.Item(2).ToString()
            arrayUsuarios.Add(tempUsuario)
        Next
        Return arrayUsuarios
    End Function

    Public Shared Function getLogs() As ArrayList
        Dim colLogs As ArrayList
        Try
            Dim unDs As DataSet
            Dim cadena As String
            cadena = "SELECT cedula FROM Docentes"
            unDs = Persistente.EjecutarSQL(cadena)
            If Not unDs Is Nothing AndAlso _
                            unDs.Tables.Count > 0 Then
                colLogs = New ArrayList
                For Each fila As DataRow In _
                                                unDs.Tables(0).Rows
                    Dim nuevoLog As New Log
                    '       If nuevoLog.Leer() Then
                    colLogs.Add(nuevoLog)
                    '        End If
                    nuevoLog = Nothing
                Next
                Return colLogs
            End If
            Return Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    ' Función   : Devuelve todos los Grupos
    ' Entrada   : 
    ' Salida    : Lista con todos los Grupos ordenados alfabeticamente
    ' Notas     :
    Public Shared Function listaGrupos() As ArrayList
        Dim rawDataGrupos As DataRowCollection
        Dim arrayGrupos As New ArrayList
        Dim pGrupo As New pGrupo
        rawDataGrupos = pGrupo.buscar()
        For Each unGrupo As DataRow In rawDataGrupos
            Dim tempGrupo As New Grupo
            tempGrupo.id = unGrupo.Item(0).ToString()
            tempGrupo.nombre = unGrupo.Item(1).ToString()
            tempGrupo.usuarios = unGrupo.Item(2).ToString()
            tempGrupo.equipos = unGrupo.Item(3).ToString()
            tempGrupo.logs = Integer.Parse(unGrupo.Item(4).ToString())
            arrayGrupos.Add(tempGrupo)
        Next
        Return arrayGrupos
    End Function
#End Region

End Class
