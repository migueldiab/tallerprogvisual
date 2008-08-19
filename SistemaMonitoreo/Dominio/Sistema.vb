Imports Persistencia

Public Class Sistema

#Region "Constantes"
    Private Shared Instancia As Sistema

    Public Const LECTURA As Char = "R"c
    Public Const ESCRITURA As Char = "W"c
    Public Enum LOGS
        NULL
        APLICACIONES
        APLICACIONES_SISTEMA
        ADMIN
    End Enum
    'Public Const LOGS_NULL As Integer = 0
    'Public Const LOGS_APLICACIONES As Integer = 1
    'Public Const LOGS_APLICACIONES_SISTEMA As Integer = 2
    'Public Const LOGS_ADMIN As Integer = 3

    Public Const ADMINISTRADOR As String = "Administradores"

    Public Const LARGO_MIN_USUARIO As Integer = 4
    Public Const LARGO_MIN_PASSWORD As Integer = 4
    Public Const REGISTOS_IMPORTAR_CSV As Integer = 3

    Public Enum acceso
        EQUIPOS_CONSULTA
        EQUIPOS_ALTA
        USUARIOS_CONSULTA
        USUARIOS_ALTA
        USUARIOS_IMPORTAR
        LOGS_APLICACIONES
        LOGS_APLICACIONES_SISTEMA
        LOGS_ADMIN
        LOGS_IMPORTAR
    End Enum
#End Region

#Region "Variables Globales"
    Public Shared usuarioLogueado As Usuario

#End Region

#Region "Metodos"
    'Singleton
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
            tempUsuario.id = unUsuario.Item(Usuario.IdxCampos.ID).ToString()
            tempUsuario.nombre = unUsuario.Item(Usuario.IdxCampos.NOMBRE).ToString()
            tempUsuario.contrasenia = unUsuario.Item(Usuario.IdxCampos.CONTRASENIA).ToString()
            tempUsuario.grupos = tempUsuario.obtenerGrupos(unUsuario.Item(Usuario.IdxCampos.ID).ToString())
            arrayUsuarios.Add(tempUsuario)
        Next
        Return arrayUsuarios
    End Function
    ' Función   : Devuelve todos los equipos
    ' Entrada   : 
    ' Salida    : Lista con todos los equipos ordenados alfabeticamente
    ' Notas     :
    Public Shared Function listaEquipos() As ArrayList
        Dim rawDataEquipos As DataRowCollection
        Dim arrayEquipos As New ArrayList
        Dim pEquipo As New pEquipo
        rawDataEquipos = pEquipo.buscar()
        If rawDataEquipos IsNot Nothing Then
            For Each unEquipo As DataRow In rawDataEquipos
                Dim tempEquipo As New Equipo
                tempEquipo.id = unEquipo.Item(Equipo.IdxCampos.ID).ToString()
                tempEquipo.nombre = unEquipo.Item(Equipo.IdxCampos.NOMBRE).ToString()
                tempEquipo.IP = unEquipo.Item(Equipo.IdxCampos.IP).ToString()
                tempEquipo.dominio = unEquipo.Item(Equipo.IdxCampos.DOMINIO).ToString()
                tempEquipo.destino = unEquipo.Item(Equipo.IdxCampos.DESTINO).ToString()
                arrayEquipos.Add(tempEquipo)
            Next
        End If
        Return arrayEquipos
    End Function

    ' Función   : Devuelve todos los Logs
    ' Entrada   : 
    ' Salida    : Lista con todos los Logs
    ' Notas     :
    Public Shared Function getLogs() As DataSet
        Dim allLogs As New DataSet()
        allLogs = Persistente.LeerLogs()
        Return allLogs

    End Function

    ' Función   : Devuelve todos los Tipos de Evento
    ' Entrada   : 
    ' Salida    : Lista con todos los Tipos de Evento
    ' Notas     :
    Public Shared Function getTipoEvento() As DataSet
        Dim allTipos As New DataSet
        allTipos = Persistente.LeerTipos
        Return allTipos
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
            tempGrupo.id = unGrupo.Item(Grupo.IdxCampos.ID).ToString()
            tempGrupo.nombre = unGrupo.Item(Grupo.IdxCampos.NOMBRE).ToString()
            tempGrupo.usuarios = unGrupo.Item(Grupo.IdxCampos.USUARIOS).ToString()
            tempGrupo.equipos = unGrupo.Item(Grupo.IdxCampos.EQUIPOS).ToString()
            tempGrupo.logs = Integer.Parse(unGrupo.Item(Grupo.IdxCampos.LOGS).ToString())
            arrayGrupos.Add(tempGrupo)
        Next
        Return arrayGrupos
    End Function

    Public Shared Function autentica(ByVal usuario As Usuario, ByVal acceso As Sistema.acceso) As Boolean
        For Each unGrupo As Grupo In usuario.grupos
            If unGrupo.nombre = Sistema.ADMINISTRADOR Then
                Return True
            End If
        Next

        Select Case acceso
            Case Sistema.acceso.EQUIPOS_CONSULTA
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.equipos.IndexOf(Sistema.LECTURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.EQUIPOS_ALTA
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.equipos.IndexOf(Sistema.ESCRITURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.USUARIOS_CONSULTA
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.usuarios.IndexOf(Sistema.LECTURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.USUARIOS_ALTA
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.usuarios.IndexOf(Sistema.ESCRITURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_ADMIN
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.logs = Sistema.LOGS.ADMIN Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_APLICACIONES
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.logs = Sistema.LOGS.APLICACIONES Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_APLICACIONES_SISTEMA
                For Each unGrupo As Grupo In usuario.grupos
                    If unGrupo.logs = Sistema.LOGS.APLICACIONES_SISTEMA Then
                        Return True
                    End If
                Next
            Case Else
                Return False
        End Select
        Return False

    End Function
#End Region

End Class
