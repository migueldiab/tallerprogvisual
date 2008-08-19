Imports Persistencia
Imports DAC

Public Class Grupo
#Region "Atributos"
    Private mId As String
    Private mNombre As String
    Private mUsuarios As String
    Private mEquipos As String
    Private mLogs As Integer

    Public Enum IdxCampos
        ID
        NOMBRE
        USUARIOS
        EQUIPOS
        LOGS
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
    Public Property usuarios() As String
        Get
            Return Me.mUsuarios
        End Get
        Set(ByVal value As String)
            Me.mUsuarios = value
        End Set
    End Property
    Public Property equipos() As String
        Get
            Return Me.mEquipos
        End Get
        Set(ByVal value As String)
            Me.mEquipos = value
        End Set
    End Property
    Public Property logs() As Integer
        Get
            Return Me.mLogs
        End Get
        Set(ByVal value As Integer)
            Me.mLogs = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
        Me.id = ""
        Me.nombre = ""
        Me.usuarios = ""
        Me.equipos = ""
        Me.logs = 0
    End Sub
    Public Sub New(ByVal id As String)
        If id <> "" Then
            Me.id = id
        End If
        Me.nombre = ""
        Me.usuarios = ""
        Me.equipos = ""
        Me.logs = 0
    End Sub
#End Region

#Region "Metodos"
    ' Función   : Sobreescribe la función toString para mostrar el nombre y el documento de un grupo
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Overrides Function ToString() As String
        Return Me.nombre.ToString() + " (" + Me.id.ToString + ")"
    End Function

    ' Función   : Guarda el grupo actual en la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function guardar() As Boolean

        Dim pGrupo As New pGrupo
        If (pGrupo.Guardar(Me.ToDataSet) = Persistente.errorBD.ok) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' Función   : Elimina un grupo de la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function borrar() As Boolean
        Dim pGrupo As New pGrupo
        Dim pPermisos As New pPertenenciaUsuario
        If pPermisos.buscarPorGrupo(Me.id) Is Nothing Then
            If pGrupo.Borrar(Me.id) = Persistente.errorBD.ok Then
                Return True
            Else
                Return False
            End If
        Else
            ' Permisos asociados al grupo
            Return False
        End If
    End Function

    Public Function ToDataSet() As dsGrupo.GruposRow
        Dim ds As New dsGrupo
        Dim unaFila As dsGrupo.GruposRow
        unaFila = ds.Grupos.NewGruposRow
        'unaFila.Id = Integer.Parse(Me.id())
        unaFila.Nombre = Me.nombre
        unaFila.PermisosSobreEquipos = Me.equipos
        unaFila.PermisosSobreUsuarios = Me.usuarios
        unaFila.PermisosSobreLogs = Me.logs().ToString
        Return unaFila
    End Function
    Public Function FromDataSet(ByVal fila As DataRow) As Grupo
        Try
            Dim uGrupo As New Grupo
            uGrupo.id = fila.Item(IdxCampos.ID).ToString
            uGrupo.nombre = fila.Item(IdxCampos.NOMBRE).ToString
            uGrupo.equipos = fila.Item(IdxCampos.EQUIPOS).ToString
            uGrupo.usuarios = fila.Item(IdxCampos.USUARIOS).ToString
            uGrupo.logs = Integer.Parse(fila.Item(IdxCampos.LOGS).ToString)
            Return uGrupo
        Catch ex As Exception
            Debug.Print("dsGrupo no se pudo convretir a Grupo : " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Try
            Dim unGrupo As Grupo
            unGrupo = CType(obj, Grupo)
            If unGrupo.nombre = Me.nombre Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

End Class
