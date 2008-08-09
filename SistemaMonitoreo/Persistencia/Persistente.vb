Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.OleDb
Public MustInherit Class Persistente

    Public Enum errorBD
        ok              '=0
        claveDuplicada  '=1
        sinRegistro     'etc.
        DatosAsociadosEnOtraTabla
        errorGeneral
    End Enum

#Region "Atributos"
    Private Shared mCadenaConexion As String

#End Region
#Region "Propiedades"
    Protected Shared ReadOnly Property CadenaConexion() As String
        Get
            Persistente.mCadenaConexion = Persistente.leerConfig
            Return Persistente.mCadenaConexion
        End Get
    End Property

#End Region
#Region "Constructores"

#End Region
#Region "Metodos"
    Protected Shared Function leerConfig() As String
        Dim strConnect As String = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString
        Return strConnect
    End Function

    Protected Shared Function Conectar() As OleDbConnection
        Try
            Dim unaC As OleDbConnection
            unaC = New OleDbConnection(CadenaConexion)

            Return unaC
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Shared Function EjecutarSQL(ByVal CadenaSQL As String) As DataSet
        Dim unaC As OleDbConnection
        Try
            unaC = Conectar()
            If unaC IsNot Nothing Then
                Dim unDs As New DataSet
                Dim unDA As OleDbDataAdapter
                unDA = New OleDbDataAdapter(CadenaSQL, unaC)
                unDA.Fill(unDs)
                unDA.Dispose()
                unaC.Close()
                unaC.Dispose()
                Return unDs
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>Ejecuta una sentencia SQL (consulta) y carga en resultado en el dataset que recibe,
    ''' especificamente en la tabla que se indica
    '''</summary>
    Protected Function EjecutarSQL(ByVal cadenaSQL As String, ByVal unDataSet As DataSet, ByVal nombreTabla As String) As DataSet
        Dim unaC As OleDbConnection
        Dim unDA As OleDbDataAdapter
        Try
            unaC = Persistente.Conectar()
            unDA = New OleDbDataAdapter(cadenaSQL, unaC)
            unDA.Fill(unDataSet, nombreTabla)
        Catch ex As OleDbException
            Throw New Exception("Error al acceder a la base de datos", ex)
        Finally
            If unaC IsNot Nothing Then
                If unaC.State <> ConnectionState.Closed Then
                    unaC.Close()
                End If
                unDA.Dispose()
                unaC.Dispose()
            End If
        End Try
        Return unDataSet
    End Function
    ''' <summary>Ejecuta una sentencia SQL (consulta) y retorna un OleDbDataReader</summary>
    ''' <returns>Retorna un DataSet con el resultado de la consulta</returns>
    Protected Function EjecutarReader(ByVal cadenaSQL As String) As OleDbDataReader
        Dim unDR As OleDbDataReader
        Dim unaC As OleDbConnection
        Dim unCommand As New OleDbCommand(cadenaSQL)
        Try
            unaC = Persistente.Conectar()
            unCommand.Connection = unaC
            unCommand.Connection.Open()
            unDR = unCommand.ExecuteReader
        Catch ex As OleDbException
            Throw New Exception("Error al acceder a la base de datos", ex)
        End Try
        Return unDR
    End Function

    Protected Function actualizar(ByVal operacion As String, ByVal ds As DataSet) As errorBD
        Dim conexion As OleDbConnection = Persistente.Conectar()
        Try
            Dim da As New OleDbDataAdapter(operacion, conexion)
            Dim cb As New OleDbCommandBuilder(da)
            da.UpdateCommand = cb.GetUpdateCommand
            da.DeleteCommand = cb.GetDeleteCommand
            da.InsertCommand = cb.GetInsertCommand
            da.Update(ds, "tabla")
            Return errorBD.ok
        Catch ex As Exception
            Return errorBD.errorGeneral
        End Try
    End Function

    Public MustOverride Function buscar(ByVal filtro As String) As Data.DataRowCollection
    Public MustOverride Function buscar(ByVal clave As Object) As Object
    Public MustOverride Function buscar() As Data.DataRowCollection

    Public MustOverride Function Guardar(ByVal objeto As Object) As errorBD
    Public MustOverride Function Borrar(ByVal objeto As Object) As errorBD
    Public MustOverride Function proximoId() As Integer
#End Region

End Class
