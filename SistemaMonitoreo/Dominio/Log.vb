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
#End Region

    Public Sub New()

    End Sub
#Region "Metodos Persistencia"

    Public Function Guardar() As Boolean
        Dim unPLog As New pLog
        Return unPLog.Guardar(Me.ToDataSet)
    End Function
    Public Function Leer() As Boolean
        Try
            Dim unPLog As New pLog
            Dim filaLeida As dsLog.RegistroLogsRow = Me.ToDataSet
            If unPLog.Leer(filaLeida) Then
                Me.FromDataSet(filaLeida)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
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

#Region "from y to datarow"
    Sub FromDataSet(ByVal objeto As DataSet)
        Dim unDSLog As dsLog
        Dim unaFila As dsLog.RegistroLogsRow
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
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ToDataSet() As DataSet
        Dim ds As New dsLog
        Dim unaFila As dsLog.RegistroLogsRow
        unafila = ds.RegistroLogs.NewRegistroLogsRow
        unafila.Mensaje = Me.Mensaje
        unaFila.NombreMaquina = Me.NombreMaquina
        unaFila.NombreUsuario = Me.NombreUsuario
        unaFila.HoraEscritura = Me.HoraEscritura
        unaFila.HoraGenerado = Me.HoraGenerado
        unaFila.IdTipoEntradaEvento = Me.IdTipoEntradaEvento
        unaFila.Category = Me.Category
        unafila.OrigenEvento = Me.OrigenEvento
        ds.RegistroLogs.Rows.Add(unafila)
        Return ds
    End Function
#End Region

End Class
