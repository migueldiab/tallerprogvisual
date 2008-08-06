Imports Persistencia

Public Class Usuario
#Region "Atributos"
    Private mId As String
    Private mNombre As String
    Private mContrasenia As String
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
    ' Función   : Sobreescribe la función toString para mostrar el nombre y el documento de un usuario
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Overrides Function ToString() As String
        Return Me.nombre.ToString() + " (" + Me.id.ToString + ")"
    End Function
    ' Función   : Busca un usuario único en base a una ID. Al ser clave primaria retorna una única coincidencia
    ' Entrada   : ID de Usuario
    ' Salida    : objeto Usuario
    ' Notas     :
    Public Shared Function buscarUsuario(ByVal id As String) As Usuario
        Dim pUsuario As New pUsuario
        Dim uUsuario As New Usuario
        uUsuario = CType(pUsuario.buscar(CType(id, Object)), Usuario)

        Return uUsuario
    End Function
    ' Función   : Devuelve los usuarios cuyo nombre coincida con un filtro parcial
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
    ' Función   : Guarda el usuario actual en la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Sub guardar()
        Dim pUsuario As New pUsuario
        pUsuario.Guardar(CType(Me, Usuario))
    End Sub
    ' Función   : Elimina un usuario de la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function borrar() As Persistente.errorBD
        Dim pUsuario As New pUsuario
        Return pUsuario.Borrar(CType(Me, Usuario))
    End Function

#End Region

End Class
