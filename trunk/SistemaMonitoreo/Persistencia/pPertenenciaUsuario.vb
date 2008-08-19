Imports System.Data.OleDb
Imports DAC

Public Class pPertenenciaUsuario : Inherits Persistente


    Public Function buscarPorUsuario(ByVal idUsuario As String) As DataRowCollection
        Dim query As String
        Dim drc As DataRowCollection
        Try
            query = "SELECT * FROM grupos " _
                    & " WHERE id = (SELECT idGrupo from PertenenciaGrupos where idUsuario = " & idUsuario & ");"
            Debug.Print(query)

            drc = EjecutarSQL(query).Tables(0).Rows
            Return drc

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD

    End Function

    Public Overloads Overrides Function buscar() As DataRowCollection
        Return Nothing
    End Function

    Public Overloads Overrides Function buscarPorId(ByVal id As String) As Object
        Return Nothing
    End Function

    Public Overloads Overrides Function buscarPorNombre(ByVal nombre As String) As DataRowCollection
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim losPermisos As dsPertenenciaGrupo
            Dim tempGrupo As dsPertenenciaGrupo.PertenenciaGruposRow
            Dim query As String
            losPermisos = CType(objeto, dsPertenenciaGrupo)
            tempGrupo = CType(losPermisos.Tables(0).Rows(0), dsPertenenciaGrupo.PertenenciaGruposRow)
            query = "DELETE FROM PertenenciaGrupos WHERE idUsuario = " & tempGrupo.idUsuario
            Debug.Print(query)
            EjecutarSQL(query)

            For Each unGrupo As dsPertenenciaGrupo.PertenenciaGruposRow In losPermisos.Tables(0).Rows
                query = "INSERT INTO PertenenciaGrupos (idUsuario, idGrupo) VALUES (" _
                        & unGrupo.idUsuario() & "," _
                        & unGrupo.idGrupo() & ")"
                Debug.Print(query)
                EjecutarSQL(query)
            Next

            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function

    Public Overrides Function proximoId() As Integer

    End Function


End Class
