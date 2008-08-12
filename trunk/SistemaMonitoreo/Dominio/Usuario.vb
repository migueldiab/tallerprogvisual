Imports Persistencia
Imports DAC

Public Class Usuario
#Region "Atributos"
    Private mId As String
    Private mNombre As String
    Private mContrasenia As String
    Private mGrupos As ArrayList
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
#End Region

#Region "Constructores"
    Public Sub New()
        Me.id = ""
        Me.nombre = ""
        Me.contrasenia = ""
    End Sub
    Public Sub New(ByVal id As String)
        If id <> "" Then
            Me.id = id
        End If
        Me.nombre = ""

        Me.contrasenia = ""
    End Sub
#End Region

#Region "Metodos"
    ' Funci�n   : Sobreescribe la funci�n toString para mostrar el nombre y el documento de un usuario
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Overrides Function ToString() As String
        Return Me.nombre.ToString() + " (" + Me.id.ToString + ")"
    End Function
    ' Funci�n   : Busca un usuario �nico en base a una ID. Al ser clave primaria retorna una �nica coincidencia
    ' Entrada   : ID de Usuario
    ' Salida    : objeto Usuario
    ' Notas     :
    Public Shared Function buscarUsuario(ByVal id As String) As Usuario
        Dim pUsuario As New pUsuario
        Dim uUsuario As New Usuario
        uUsuario = CType(pUsuario.buscar(CType(id, Object)), Usuario)

        Return uUsuario
    End Function
    ' Funci�n   : Devuelve los usuarios cuyo nombre coincida con un filtro parcial
    ' Entrada   : filter : nombre de usuario a buscar
    ' Salida    : Lita con todos los usuarios que coincidan con el filtro
    ' Notas     :
    Public Shared Function listaUsuarios(ByVal filter As String) As DataRowCollection
        Dim lista As DataRowCollection
        Dim pUsuario As New pUsuario
        If filter <> "" Then
            lista = pUsuario.buscar(filter)
        Else
            lista = pUsuario.buscar()
        End If
        Return lista
    End Function
    ' Funci�n   : Guarda el usuario actual en la BD
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
    ' Funci�n   : Elimina un usuario de la BD
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
    Public Function ToPertenenciaGrupoDataSet() As dsUsuario.UsuariosRow
        Dim ds As New dsUsuario
        Dim unaFila As dsUsuario.UsuariosRow
        unaFila = ds.Usuarios.NewUsuariosRow
        'unaFila.Id = Integer.Parse(Me.id())
        unaFila.Nombre = Me.nombre
        unaFila.Contrasenia = Me.contrasenia
        Return unaFila

    End Function
#End Region

End Class
