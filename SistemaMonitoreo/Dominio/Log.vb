Imports Persistencia
Imports DAC


Public Class Log
#Region "Atributos"
    Private mIdTipoEntradaEvento As Integer
    Private mNombreMaquina As String
    Private mOrigenEvento As String
    Private mNombreUsuario As String
    Private mCategory As String
    Private mHoraEscritura As String
    Private mHoraGenerado As String
    Private mMensaje As String
    Private mEventoCapturado As String
    Private mTipoEvento As String
#End Region

#Region "Properties"
    Public Property IdTipoEntradaEvento() As Integer
        Get
            Return Me.mIdTipoEntradaEvento
        End Get
        Set(ByVal value As Integer)
            Me.mIdTipoEntradaEvento = value
        End Set
    End Property
    Public Property NombreMaquina() As String
        Get
            Return Me.mNombreMaquina
        End Get
        Set(ByVal value As String)
            Me.mNombreMaquina = value
        End Set
    End Property
    Public Property OrigenEvento() As String
        Get
            Return Me.mOrigenEvento
        End Get
        Set(ByVal value As String)
            Me.mOrigenEvento = value
        End Set
    End Property
    Public Property NombreUsuario() As String
        Get
            Return Me.mNombreUsuario
        End Get
        Set(ByVal value As String)
            Me.mNombreUsuario = value
        End Set
    End Property
    Public Property Category() As String
        Get
            Return Me.mCategory
        End Get
        Set(ByVal value As String)
            Me.mCategory = value
        End Set
    End Property
    Public Property HoraEscritura() As String
        Get
            Return Me.mHoraEscritura
        End Get
        Set(ByVal value As String)
            Me.mHoraEscritura = value
        End Set
    End Property
    Public Property HoraGenerado() As String
        Get
            Return Me.mHoraGenerado
        End Get
        Set(ByVal value As String)
            Me.mHoraGenerado = value
        End Set
    End Property
    Public Property Mensaje() As String
        Get
            Return Me.mMensaje
        End Get
        Set(ByVal value As String)
            Me.mMensaje = value
        End Set
    End Property
    Public Property EventoCapturado() As String
        Get
            Return mEventoCapturado
        End Get
        Set(ByVal value As String)
            mEventoCapturado = value
        End Set
    End Property
  
#End Region

    Public Sub New()

    End Sub
    Public Shared Function DataViewLogs() As DataView
        Dim dvLog As DataView
        dvLog = Persistencia.pLog.LeerLogs.Tables(0).DefaultView
        Return dvLog
    End Function



#Region "Metodos Persistencia"
    Public Function Guardar() As Boolean
        Dim unPLog As New pLog
        If (unPLog.Guardar(Me.ToDataSet) = Persistente.errorBD.ok) Then
            Return True
        Else
            Return False
        End If
    End Function
 
    Public Function Eliminar() As Boolean
        Try
            Dim unPLog As New pLog
            Return unPLog.Eliminar(Me.ToDataSet)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "From/To DataSet"
    Sub FromDataSet(ByVal objeto As DataSet)
        Dim unDSLog As dsLog
        Dim unaFila As dsLog.RegistroLogsRow = Nothing
        unDSLog = CType(objeto, dsLog)
        Try
            If Not unaFila Is Nothing Then
                Me.Mensaje = unaFila.Mensaje
                Me.NombreMaquina = unaFila.NombreMaquina
                Me.NombreUsuario = unaFila.NombreUsuario
                Me.HoraEscritura = unaFila.HoraEscritura
                Me.HoraGenerado = unaFila.HoraGenerado
                Me.IdTipoEntradaEvento = unaFila.IdTipoEntradaEvento
                Me.Category = unaFila.Category
                Me.OrigenEvento = unaFila.OrigenEvento
                Me.EventoCapturado = unaFila.EventoCapturado

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ToDataSet() As DataSet
        Dim ds As New dsLog
        Dim unaFila As dsLog.RegistroLogsRow
        unaFila = ds.RegistroLogs.NewRegistroLogsRow
        Me.Mensaje = Me.Mensaje.Replace("'", "''")
        unaFila.Mensaje = Left(Me.Mensaje, 255)
        unaFila.NombreMaquina = Me.NombreMaquina
        unaFila.NombreUsuario = Me.NombreUsuario
        unaFila.HoraEscritura = Me.HoraEscritura
        unaFila.HoraGenerado = Me.HoraGenerado
        unaFila.IdTipoEntradaEvento = Me.IdTipoEntradaEvento
        unaFila.Category = Me.Category
        unaFila.OrigenEvento = Me.OrigenEvento
        unaFila.EventoCapturado = Me.EventoCapturado
        ds.RegistroLogs.Rows.Add(unaFila)
        Return ds
    End Function
#End Region


End Class
