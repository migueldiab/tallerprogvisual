Imports Persistencia
Imports DAC

Public Class Usuario
#Region "Atributos"
    Private mId As String
    Private mNombre As String
    Private mContrasenia As String
    Private mGrupos As ArrayList

    Public Enum IdxCampos
        ID
        NOMBRE
        CONTRASENIA
    End Enum
#End Region

#Region "Propiedades"
    Public Property id() As String
        Get
            Return Me.mId
        End Get
        Set(ByVal value As String)
            Me.mId = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return Me.mNombre
        End Get
        Set(ByVal value As String)
            Me.mNombre = value
        End Set
    End Property
    Public Property contrasenia() As String
        Get
            Return Me.mContrasenia
        End Get
        Set(ByVal value As String)
            Me.mContrasenia = value
        End Set
    End Property
    Public Property grupos() As ArrayList
        Get
            Return Me.mGrupos
        End Get
        Set(ByVal value As ArrayList)
            Me.mGrupos = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
        Me.id = ""
        Me.nombre = ""
        Me.contrasenia = ""
    End Sub
    Public Sub New(ByVal id As String)
        If id <> "" Then
            Dim pUsuario As New pUsuario
            Dim Usuarios As DataRowCollection
            Usuarios = pUsuario.buscar(id)
            If Usuarios Is Nothing Then
                Me.nombre = ""
                Me.contrasenia = ""
                Me.grupos = Nothing
            ElseIf Usuarios.Count > 1 Then
                Me.nombre = ""
                Me.contrasenia = ""
                Me.grupos = Nothing
            ElseIf Usuarios.Count = 1 Then
                Dim usuario As DataRow = Usuarios.Item(IdxCampos.ID)
                Me.id = usuario.Item(IdxCampos.ID).ToString
                Me.nombre = usuario.Item(IdxCampos.NOMBRE).ToString
                Me.contrasenia = usuario.Item(IdxCampos.CONTRASENIA).ToString
                Me.grupos = Nothing
            End If
        End If
    End Sub
#End Region

#Region "Metodos"
    ' Función   : Sobreescribe la función toString para mostrar el nombre y el documento de un usuario
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Overrides Function ToString() As String
        Return Me.nombre.ToString() + " (" + Me.id.ToString + ")"
    End Function
    Public Function login(ByVal contrasenia As String) As Boolean
        If Me.contrasenia = contrasenia Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function obtenerGrupos(ByVal id As String) As ArrayList
        Dim arrayGrupos As New ArrayList
        Dim rawDataPermisos As DataRowCollection
        Dim pPermisos As New pPertenenciaUsuario
        rawDataPermisos = pPermisos.buscar(id)
        If rawDataPermisos Is Nothing Then
            Return Nothing
        Else
            For Each unGrupo As DataRow In rawDataPermisos
                Dim tempGrupo As New Grupo
                tempGrupo.id = unGrupo.Item(Grupo.IdxCampos.ID).ToString()
                tempGrupo.nombre = unGrupo.Item(Grupo.IdxCampos.NOMBRE).ToString()
                tempGrupo.usuarios = unGrupo.Item(Grupo.IdxCampos.USUARIOS).ToString()
                tempGrupo.equipos = unGrupo.Item(Grupo.IdxCampos.EQUIPOS).ToString()
                tempGrupo.logs = Integer.Parse(unGrupo.Item(Grupo.IdxCampos.LOGS).ToString)
                arrayGrupos.Add(tempGrupo)
            Next
            Return arrayGrupos
        End If
    End Function



    ' Función   : Busca un usuario único en base a una ID. Al ser clave primaria retorna una única coincidencia
    ' Entrada   : ID de Usuario
    ' Salida    : objeto Usuario
    ' Notas     :
    'Public Shared Function buscarUsuario(ByVal id As String) As Usuario
    '    Dim pUsuario As New pUsuario
    '    Dim uUsuario As New Usuario
    '    uUsuario = CType(pUsuario.buscar(CType(id, Object)), Usuario)

    '    Return uUsuario
    'End Function
    ' Función   : Devuelve los usuarios cuyo nombre coincida con un filtro parcial
    ' Entrada   : filter : nombre de usuario a buscar
    ' Salida    : Lita con todos los usuarios que coincidan con el filtro
    ' Notas     :
    'Public Shared Function listaUsuarios(ByVal filter As String) As DataRowCollection
    '    Dim lista As DataRowCollection
    '    Dim pUsuario As New pUsuario
    '    If filter <> "" Then
    '        lista = pUsuario.buscar(filter)
    '    Else
    '        lista = pUsuario.buscar()
    '    End If
    '    Return lista
    'End Function
    ' Función   : Guarda el usuario actual en la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function guardar() As Boolean

        Dim pUsuario As New pUsuario
        If (pUsuario.Guardar(Me.ToUsuarioDataSet) = Persistente.errorBD.ok) Then
            'And (pPertenenciaUsuario.Guardar(Me.ToPertenenciaGrupoDataSet) = Persistente.errorBD.ok) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' Función   : Elimina un usuario de la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function borrar() As Boolean
        Dim pUsuario As New pUsuario
        If pUsuario.Borrar(Me.id) = Persistente.errorBD.ok Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public Function ToDataSet() As DataSet
    '    Dim ds As New dsUsuario
    '    Dim unaFila As dsUsuario.UsuariosRow
    '    unaFila = ds.Usuarios.NewUsuariosRow
    '    unaFila.Id = Integer.Parse(Me.id)
    '    unaFila.Nombre = Me.nombre
    '    unaFila.Contrasenia = Me.contrasenia
    '    ds.Usuarios.Rows.Add(unaFila)
    '    Return ds
    'End Function

    Public Function ToUsuarioDataSet() As dsUsuario.UsuariosRow
        Dim ds As New dsUsuario
        Dim unaFila As dsUsuario.UsuariosRow
        unaFila = ds.Usuarios.NewUsuariosRow
        'unaFila.Id = Integer.Parse(Me.id())
        unaFila.Nombre = Me.nombre
        unaFila.Contrasenia = Me.contrasenia
        Return unaFila

    End Function
    Public Function ToPertenenciaGrupoDataSet() As dsPertenenciaGrupo
        Dim ds As New dsPertenenciaGrupo
        For Each grupo As Grupo In mGrupos
            Dim unaFila As dsPertenenciaGrupo.PertenenciaGruposRow
            unaFila = ds.PertenenciaGrupos.NewPertenenciaGruposRow
            unaFila.idGrupo = Integer.Parse(grupo.id())
            unaFila.idUsuario = Integer.Parse(Me.id)
            ds.PertenenciaGrupos.Rows.Add(unaFila)
        Next
        Return ds
    End Function
#End Region

End Class
