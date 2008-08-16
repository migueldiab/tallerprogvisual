Imports Persistencia
Imports DAC

Public Class TipoEvento

#Region "Atributos"
    Private mId As Integer
    Private mNombre As String
    Private mNombreEspaniol As String
    Private TodosTipos As DataView
#End Region

#Region "Properties"
    Public ReadOnly Property Id() As Integer
        Get
            Return Me.mId
        End Get
    End Property
    Public Property Nombre() As String
        Get
            Return Me.mNombre
        End Get
        Set(ByVal value As String)
            Me.mNombre = value
        End Set
    End Property
    Public Property NombreEspaniol() As String
        Get
            Return Me.mNombreEspaniol
        End Get
        Set(ByVal value As String)
            Me.mNombreEspaniol = value
        End Set
    End Property
   
#End Region

    Public Sub New()

    End Sub

    Public Shared Function DataViewTipos() As DataView
        Dim dvTipo As DataView
        dvTipo = Persistencia.pTipoEntradaEvento.LeerTipos.Tables(0).DefaultView
        Return dvTipo
    End Function


End Class
