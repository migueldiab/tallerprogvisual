Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.OleDb
Public Class Persistente
    Private Shared mCadenaConexion As String
    Protected Shared Function leerConfig() As String
        Dim strConnect As String = ConfigurationManager.ConnectionStrings("connString").ConnectionString
        Return strConnect
    End Function
    Protected Shared ReadOnly Property CadenaConexion() As String
        Get
            Persistente.mCadenaConexion = Persistente.leerConfig
            Return Persistente.mCadenaConexion
        End Get
    End Property

    Protected Shared Function Conectar() As OleDbConnection
        Try
            Return New OleDbConnection(Persistente.CadenaConexion)
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
    Public Shared Function EjecutarSQL(ByVal cadenaSQL As String, ByVal unDataSet As DataSet, ByVal nombreTabla As String) As DataSet
        Dim unaC As OleDbConnection
        Dim unDA As OleDbDataAdapter
        Try
            unaC = Conectar()
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
    Public Shared Function EjecutarReader(ByVal cadenaSQL As String) As OleDbDataReader
        Dim unDR As OleDbDataReader
        Dim unaC As OleDbConnection
        Dim unCommand As New OleDbCommand(cadenaSQL)
        Try
            unaC = Conectar()
            unCommand.Connection = unaC
            unCommand.Connection.Open()
            unDR = unCommand.ExecuteReader
        Catch ex As OleDbException
            Throw New Exception("Error al acceder a la base de datos", ex)
        End Try
        Return unDR
    End Function


End Class
