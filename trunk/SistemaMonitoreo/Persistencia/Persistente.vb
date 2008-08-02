Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Data.OleDb
Public MustInherit Class Persistente
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
    Public Shared Function EjecutarSQLDataset(ByVal CadenaSQL As String) As DataSet
        Dim unaC As OleDbConnection
        Try
            unaC = Persistente.Conectar
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
    Public MustOverride Function Guardar(ByVal ObjetoPersistente As DataRow) As Boolean
    Public MustOverride Function Modificar(ByVal ObjetoPersistente As DataRow) As Boolean
    Public MustOverride Function Eliminar(ByVal ObjetoPersistente As DataRow) As Boolean
    Public MustOverride Function Leer(ByVal ObjetoPersistente As DataRow) As Boolean
End Class
