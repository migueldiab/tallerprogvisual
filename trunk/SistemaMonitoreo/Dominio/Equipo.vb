Imports Persistencia
Imports DAC

Public Class Equipo
#Region "Atributos"
    Private mId As String
    Private mNombre As String
    Private mIP As String
    Private mDominio As String
    Private mDestino As String

    Public Enum IdxCampos
        ID
        NOMBRE
        IP
        DOMINIO
        DESTINO
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
    Public Property IP() As String
        Get
            Return Me.mIP
        End Get
        Set(ByVal value As String)
            Me.mIP = value
        End Set
    End Property
    Public Property dominio() As String
        Get
            Return Me.mDominio
        End Get
        Set(ByVal value As String)
            Me.mDominio = value
        End Set
    End Property
    Public Property destino() As String
        Get
            Return Me.mDestino
        End Get
        Set(ByVal value As String)
            Me.mDestino = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()
        Me.id = ""
        Me.nombre = ""
        Me.IP = ""
        Me.dominio = ""
        Me.destino = ""
    End Sub
    Public Sub New(ByVal id As String)
        If id <> "" Then
            Me.id = id
        End If
        Me.nombre = ""
        Me.IP = ""
        Me.dominio = ""
        Me.destino = ""
    End Sub
#End Region

#Region "Metodos"
    ' Función   : Sobreescribe la función toString para mostrar el nombre y el documento de un equipo
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Overrides Function ToString() As String
        Return Me.nombre.ToString() + " (" + Me.id.ToString + ")"
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
    Public Shared Function listaEquipos(ByVal filter As String) As DataRowCollection
        Dim lista As DataRowCollection
        Dim pEquipo As New pEquipo
        If filter <> "" Then
            lista = pEquipo.buscarPorNombre(filter)
        Else
            lista = pEquipo.buscar()
        End If
        Return lista
    End Function
    ' Función   : Guarda el equipo actual en la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function guardar() As Boolean

        Dim pEquipo As New pEquipo
        If (pEquipo.Guardar(Me.ToDataSet) = Persistente.errorBD.ok) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' Función   : Elimina un equipo de la BD
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Public Function borrar() As Boolean
        Dim pEquipo As New pEquipo
        If pEquipo.Borrar(Me.id) = Persistente.errorBD.ok Then
            Return True
        Else
            Return False
        End If
    End Function

    'Public Function ToDataSet() As DataSet
    '    Dim ds As New dsEquipo
    '    Dim unaFila As dsEquipo.EquiposRow
    '    unaFila = ds.Equipos.NewEquiposRow
    '    unaFila.Id = Integer.Parse(Me.id)
    '    unaFila.Nombre = Me.nombre
    '    unaFila.Contrasenia = Me.contrasenia
    '    ds.Equipos.Rows.Add(unaFila)
    '    Return ds
    'End Function

    Public Function ToDataSet() As dsEquipo.EquiposRow
        Dim ds As New dsEquipo
        Dim unaFila As dsEquipo.EquiposRow
        unaFila = ds.Equipos.NewEquiposRow
        'unaFila.Id = Integer.Parse(Me.id())
        unaFila.NombreMaquina = Me.nombre
        unaFila.IP = Me.IP
        unaFila.NombreDominio = Me.dominio
        unaFila.Destino = Me.destino
        Return unaFila
    End Function
#End Region

End Class
