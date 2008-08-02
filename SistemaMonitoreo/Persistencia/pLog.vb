Imports System.Data.OleDb
Public Class pLog : Inherits Persistente
    Public Overrides Function Eliminar(ByVal filaparametro As ) As Boolean
        Try
            Dim UnaConexion As OleDbConnection = pLog.Conectar
            Dim unDS As New DataSet
            Dim unDA As OleDbDataAdapter = New OleDbDataAdapter("Select * from Socios where Id =" & CInt(filaparametro.Item("Id").ToString) & "", UnaConexion)
            Dim unComando As OleDbCommandBuilder = New OleDbCommandBuilder(unDA)
            unDA.Fill(unDS, "Socios")
            unDS.Tables(0).Rows(0).Delete()
            unDA.Update(unDS, "Socios")
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Function

    Public Overrides Function Guardar(ByVal filaparametro As System.Data.DataRow) As Boolean
        Try
            Dim unaConexion As OleDbConnection
            unaConexion = New OleDbConnection(pLog.CadenaConexion)
            Dim unDA As OleDbDataAdapter
            unDA = New OleDbDataAdapter("Select * from Socios", unaConexion)
            Dim unComando As OleDbCommandBuilder
            unComando = New OleDbCommandBuilder(unDA)
            Dim unDS As New DataSet
            unDA.Fill(unDS, "Socios")
            Dim unaTabla As DataTable = unDS.Tables(0)
            Dim nuevaFila As DataRow = unaTabla.NewRow
            nuevaFila.Item("Id") = filaparametro.Item("Id")
            nuevaFila.Item("Cedula") = filaparametro.Item("Cedula")
            nuevaFila.Item("Nombre") = filaparametro.Item("Nombre")
            nuevaFila.Item("Apellido") = filaparametro.Item("Apellido")
            nuevaFila.Item("FechaNacimiento") = filaparametro.Item("FechaNacimiento")
            nuevaFila.Item("FechaIngreso") = filaparametro.Item("FechaIngreso")
            unaTabla.Rows.Add(nuevaFila)
            unDA.Update(unDS, "Socios")
            unDA.Dispose()
            unaConexion.Close()
            unaConexion.Dispose()
            Dim pId As Integer = CInt(filaparametro.Item("Id").ToString)
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    Public Overrides Function Leer(ByVal filaparametro As System.Data.DataRow) As Boolean
        Try
            If Not filaparametro Is Nothing Then
                Dim unDS As DataSet
                Dim cadSQL As String
                cadSQL = "Select * from Socios WHERE Id=" & CInt(filaparametro.Item("Id").ToString) & ""
                unDS = pLog.EjecutarSQLDataset(cadSQL)
                If Not unDS Is Nothing AndAlso unDS.Tables.Count = 1 Then
                    Dim unafila As DataRow
                    unafila = unDS.Tables(0).Rows(0)
                    filaparametro.Item("Cedula") = unafila.Item("Cedula").ToString
                    filaparametro.Item("Nombre") = unafila.Item("Nombre").ToString
                    filaparametro.Item("Apellido") = unafila.Item("Apellido").ToString
                    'ver si anda bien esto de convertir a fecha
                    filaparametro.Item("FechaNacimiento") = CDate(unafila.Item("FechaNacimiento"))
                    filaparametro.Item("FechaIngreso") = CDate(unafila.Item("FechaIngreso"))
                    Return True
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
    End Function

    Public Overrides Function Modificar(ByVal filaparametro As System.Data.DataRow) As Boolean
        Try
            Dim unaConexion As OleDbConnection
            unaConexion = New OleDbConnection(pLog.CadenaConexion)
            Dim unDA As OleDbDataAdapter
            Dim cadSQL As String
            cadSQL = "Select * from Socios WHERE Id=" & CInt(filaparametro.Item("Id").ToString) & ""
            unDA = New OleDbDataAdapter(cadSQL, unaConexion)
            Dim unComando As OleDbCommandBuilder
            unComando = New OleDbCommandBuilder(unDA)
            Dim unDS As New DataSet
            unDA.Fill(unDS, "Socios")
            Dim unaTabla As DataTable = unDS.Tables("Socios")
            Dim unafila As DataRow = unaTabla.Rows(0)
            unafila.Item("Cedula") = filaparametro.Item("cedula")
            unafila.Item("Nombre") = filaparametro.Item("Nombre")
            unafila.Item("Apellido") = filaparametro.Item("Apellido")
            unafila.Item("FechaNacimiento") = filaparametro.Item("FechaNacimiento")
            unafila.Item("FechaIngreso") = filaparametro.Item("FechaIngreso")
            unDA.Update(unDS, "Socios")
            unDA.Dispose()
            unaConexion.Close()
            unaConexion.Dispose()
            Return True
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return False
        End Try
    End Function



End Class
