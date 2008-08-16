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


    Public Shared Function getLogs() As DataSet
        Dim allLogs As New DataSet()
        allLogs = Persistente.LeerLogs()
        Return allLogs

    End Function
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
#End Region

End Class
