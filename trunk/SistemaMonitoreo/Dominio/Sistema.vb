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
    Public Enum IMPORTAR_USUARIOS
        GRUPO_INEXISTENTE
        GRUPO_DUPLICADO
        CANTIDAD_REGISTOS_INCORRECTO
        FORMATO_INCORRECTO
        USUARIO_INVALIDO
        PASSWORD_INVALIDO
        GRUPO_INVALIDO
        USUARIO_ADMINISTRADOR
    End Enum
    'Public Const LOGS_NULL As Integer = 0
    'Public Const LOGS_APLICACIONES As Integer = 1
    'Public Const LOGS_APLICACIONES_SISTEMA As Integer = 2
    'Public Const LOGS_ADMIN As Integer = 3

    Public Const ADMINISTRADOR As String = "Administradores"

    Public Const LARGO_MIN_USUARIO As Integer = 4
    Public Const LARGO_MIN_PASSWORD As Integer = 4
    Public Const LARGO_MIN_GRUPO As Integer = 4
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

    'Singleton
    Public Shared Function getInstancia() As Sistema
        If Instancia Is Nothing Then
            Instancia = New Sistema
        End If
        Return Instancia
    End Function

#Region "Logs"
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

#End Region

#Region "Usuarios"
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
    Public Shared Function importarUsuarios(ByVal archivo As System.IO.Stream, ByVal log As String) As Boolean
        Using archivoImportar As New Microsoft.VisualBasic.FileIO.TextFieldParser(archivo)
            archivoImportar.TextFieldType = FileIO.FieldType.Delimited
            archivoImportar.SetDelimiters(",")
            Dim fila As String()
            Dim linea As Long
            Dim mensaje As String
            utilsArchivos.borrarArchivo(log)
            While Not archivoImportar.EndOfData
                Try
                    linea = archivoImportar.LineNumber()
                    fila = archivoImportar.ReadFields()
                    If (fila.Length <> Sistema.REGISTOS_IMPORTAR_CSV) Then
                        'no hay 3 campos
                        mensaje = logMensajeError(IMPORTAR_USUARIOS.CANTIDAD_REGISTOS_INCORRECTO, linea, fila)
                        utilsArchivos.escribirArchivo(mensaje, log)
                    ElseIf Not fila.GetValue(2).ToString.EndsWith(";") Then
                        'Mal formato, no termina con ;
                        mensaje = logMensajeError(IMPORTAR_USUARIOS.FORMATO_INCORRECTO, linea, fila)
                        utilsArchivos.escribirArchivo(mensaje, log)
                    ElseIf fila.GetValue(0).ToString.Length < Sistema.LARGO_MIN_USUARIO Then
                        ' Usuario corto
                        mensaje = logMensajeError(IMPORTAR_USUARIOS.USUARIO_INVALIDO, linea, fila)
                        utilsArchivos.escribirArchivo(mensaje, log)
                    ElseIf fila.GetValue(1).ToString.Length < Sistema.LARGO_MIN_PASSWORD Then
                        ' password corto
                        mensaje = logMensajeError(IMPORTAR_USUARIOS.PASSWORD_INVALIDO, linea, fila)
                        utilsArchivos.escribirArchivo(mensaje, log)
                    ElseIf fila.GetValue(2).ToString.Length < Sistema.LARGO_MIN_GRUPO Then
                        ' grupo corto
                        mensaje = logMensajeError(IMPORTAR_USUARIOS.GRUPO_INVALIDO, linea, fila)
                        utilsArchivos.escribirArchivo(mensaje, log)
                    Else
                        Dim uUsuario As New Usuario
                        Dim uGrupo As New Grupo
                        Dim nombreGrupo As String

                        uUsuario.contrasenia = fila.GetValue(1).ToString
                        uUsuario.nombre = fila.GetValue(0).ToString
                        uUsuario.grupos = Nothing
                        uUsuario.guardar()

                        nombreGrupo = fila.GetValue(2).ToString()
                        nombreGrupo = nombreGrupo.Substring(0, nombreGrupo.IndexOf(";"))
                        uGrupo = buscarGrupo(nombreGrupo)
                        If uGrupo.nombre = Sistema.ADMINISTRADOR Then
                            uUsuario.borrarPermisos()
                            mensaje = logMensajeError(IMPORTAR_USUARIOS.USUARIO_ADMINISTRADOR, linea, fila)
                            utilsArchivos.escribirArchivo(mensaje, log)
                        End If
                        If Not uGrupo Is Nothing Then
                            uUsuario.agregarPermiso(uGrupo.id)
                        Else
                            'Grupo no existe
                            mensaje = logMensajeError(IMPORTAR_USUARIOS.GRUPO_INEXISTENTE, linea, fila)
                            utilsArchivos.escribirArchivo(mensaje, log)
                        End If
                    End If
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    Debug.Write("Linea no válida : " & ex.Message)
                    mensaje = logMensajeError(IMPORTAR_USUARIOS.FORMATO_INCORRECTO, linea, Nothing)
                    utilsArchivos.escribirArchivo(mensaje, log)
                End Try
            End While
        End Using

    End Function
    Public Shared Function logMensajeError(ByVal enumError As IMPORTAR_USUARIOS, ByVal linea As Long, ByVal fila As String()) As String
        Return "Error " & enumError & " : " & _
               enumError.ToString() & vbCrLf & _
               " Linea # : " & linea.ToString & vbCrLf & _
               " Valor : " & String.Join(",", fila) & vbCrLf
    End Function



    ' Función   : Busca un usuario único en base a una ID. Al ser clave primaria retorna una única coincidencia
    ' Entrada   : ID de Usuario
    ' Salida    : objeto Usuario
    ' Notas     :
    Public Shared Function buscarUsuario(ByVal id As String) As Usuario

        Dim pUsuario As New pUsuario
        Dim uUsuario As New Usuario
        Dim drc As DataRowCollection
        drc = pUsuario.buscarPorNombre(id)
        If drc.Count = 1 Then
            Return uUsuario.FromDataSet(drc.Item(0))
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function autentica(ByVal usuario As Usuario, ByVal acceso As Sistema.acceso) As Boolean
        For Each unGrupo As Grupo In Usuario.grupos
            If unGrupo.nombre = Sistema.ADMINISTRADOR Then
                Return True
            End If
        Next

        Select Case acceso
            Case Sistema.acceso.EQUIPOS_CONSULTA
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.equipos.IndexOf(Sistema.LECTURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.EQUIPOS_ALTA
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.equipos.IndexOf(Sistema.ESCRITURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.USUARIOS_CONSULTA
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.usuarios.IndexOf(Sistema.LECTURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.USUARIOS_ALTA
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.usuarios.IndexOf(Sistema.ESCRITURA) <> -1 Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_ADMIN
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.logs = Sistema.LOGS.ADMIN Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_APLICACIONES
                For Each unGrupo As Grupo In Usuario.grupos
                    If unGrupo.logs = Sistema.LOGS.APLICACIONES Then
                        Return True
                    End If
                Next
            Case Sistema.acceso.LOGS_APLICACIONES_SISTEMA
                For Each unGrupo As Grupo In Usuario.grupos
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

#Region "Equipos"

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

    ' Función   : Busca un equipo único en base a una ID. Al ser clave primaria retorna una única coincidencia
    ' Entrada   : ID de Equipo
    ' Salida    : objeto Equipo
    ' Notas     :
    Public Shared Function buscarEquipo(ByVal id As String) As Equipo
        Dim pEquipo As New pEquipo
        Dim uEquipo As New Equipo
        uEquipo = CType(pEquipo.buscarPorId(id), Equipo)
        Return uEquipo
    End Function

    ' Función   : Devuelve los equipos cuyo nombre coincida con un filtro parcial
    ' Entrada   : filter : nombre de equipo a buscar
    ' Salida    : Lita con todos los equipos que coincidan con el filtro
    ' Notas     :
    Public Shared Function listaEquipos(ByVal filter As String) As ArrayList
        'Dim rawDataEquipos As DataRowCollection
        'Dim arrayEquipos As New ArrayList
        'Dim pEquipo As New pEquipo
        'rawDataEquipos = Sistema.buscarEquipos(filter)
        'If rawDataEquipos IsNot Nothing Then
        '    For Each unEquipo As DataRow In rawDataEquipos
        '        Dim tempEquipo As New Equipo
        '        tempEquipo.id = unEquipo.Item(Equipo.IdxCampos.ID).ToString()
        '        tempEquipo.nombre = unEquipo.Item(Equipo.IdxCampos.NOMBRE).ToString()
        '        tempEquipo.IP = unEquipo.Item(Equipo.IdxCampos.IP).ToString()
        '        tempEquipo.dominio = unEquipo.Item(Equipo.IdxCampos.DOMINIO).ToString()
        '        tempEquipo.destino = unEquipo.Item(Equipo.IdxCampos.DESTINO).ToString()
        '        arrayEquipos.Add(tempEquipo)
        '    Next
        'End If
        'Return arrayEquipos
        Return Nothing
    End Function

#End Region

#Region "Grupos"

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
    ' Función   : Busca un grupo único en base a una ID. Al ser clave primaria retorna una única coincidencia
    ' Entrada   : ID de Grupo
    ' Salida    : objeto Grupo
    ' Notas     :
    Public Shared Function buscarGrupo(ByVal id As String) As Grupo
        Dim pGrupo As New pGrupo
        Dim uGrupo As New Grupo
        Dim drc As DataRowCollection
        drc = pGrupo.buscarPorNombre(id)
        If drc.Count = 1 Then
            Return uGrupo.FromDataSet(drc.Item(0))
        Else
            Return Nothing
        End If
    End Function
#End Region

End Class
