Imports System.Data.OleDb
Imports DAC

Public Class pGrupo : Inherits Persistente



    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD
        Dim query As String
        Dim id As String = CType(objeto, String)
        Try
            query = "DELETE FROM grupos " _
                    & " WHERE id = " & id & ";"
            Debug.Print(query)
            Me.EjecutarSQL(query)
            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar() As DataRowCollection
        Dim lista As New ArrayList
        Dim ds As DataSet
        Try
            ds = Me.EjecutarSQL("select * from grupos order by nombre")
            Return ds.Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal clave As Object) As Object

    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Dim query As String
        Try
            query = "SELECT * FROM grupos " _
                    & " WHERE nombre = '" & filtro & "';"
            Debug.Print(query)
            Return Me.EjecutarSQL(query).Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unGrupo As dsGrupo.GruposRow
            Dim query As String
            Dim busqueda As DataRowCollection

            unGrupo = CType(objeto, dsGrupo.GruposRow)
            busqueda = Me.buscar(unGrupo.Nombre)
            If busqueda.Count = 0 Then
                query = "INSERT INTO Grupos (nombre, permisosSobreUsuarios, permisosSobreEquipos, permisosSobreLogs) VALUES (" _
                    & "'" & unGrupo.Nombre() & "'," _
                    & "'" & unGrupo.PermisosSobreUsuarios() & "'," _
                    & "'" & unGrupo.PermisosSobreEquipos() & "'," _
                    & "'" & unGrupo.PermisosSobreLogs() & "')"
            ElseIf busqueda.Count = 1 Then
                query = "UPDATE Grupos SET (" _
                    & " permisosSobreUsuarios = '" & unGrupo.PermisosSobreUsuarios() & "'," _
                    & " permisosSobreEquipos  = '" & unGrupo.PermisosSobreEquipos() & "'," _
                    & " permisosSobreLogs     = '" & unGrupo.PermisosSobreLogs() & "')" _
                    & " WHERE nombre = '" & unGrupo.Nombre() & "';"
            Else
                Return errorBD.errorGeneral
            End If
            Debug.Print(query)
            Me.EjecutarSQL(query)

            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function

    Public Overrides Function proximoId() As Integer

    End Function
End Class
