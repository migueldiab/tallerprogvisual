Imports System.Data.OleDb
Imports DAC

Public Class pPertenenciaUsuario : Inherits Persistente

    Public Function borrarPermisos(ByVal idUsuario As String) As Persistente.errorBD
        Try
            Dim query As String
            query = "DELETE FROM PertenenciaGrupos WHERE idUsuario = " & idUsuario
            Debug.Print(query)
            EjecutarSQL(query)
            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function
    Public Function buscarPorUsuario(ByVal idUsuario As String) As DataRowCollection
        Dim query As String
        Dim drc As DataRowCollection
        Try
            query = "SELECT * FROM grupos " _
                    & " WHERE id IN (SELECT idGrupo from PertenenciaGrupos where idUsuario = " & idUsuario & ");"
            Debug.Print(query)

            drc = EjecutarSQL(query).Tables(0).Rows
            Return drc

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function
    Public Function buscarPorGrupo(ByVal idGrupo As String) As DataRowCollection
        Dim query As String
        Dim drc As DataRowCollection
        Try
            query = "SELECT * FROM PertenenciaGrupos WHERE idGrupo = " & idGrupo
            Debug.Print(query)
            drc = EjecutarSQL(query).Tables(0).Rows
            If drc.Count > 0 Then
                Return drc
            Else
                Return Nothing
            End If
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
    Public Function Agregar(ByVal uPermiso As dsPertenenciaGrupo.PertenenciaGruposRow) As Persistente.errorBD
        Try
            Dim ds As DataSet
            Dim query As String
            query = "SELECT COUNT(*) FROM PertenenciaGrupos WHERE " & _
                        " idUsuario = " & uPermiso.idUsuario & " AND " & _
                        " idGrupo = " & uPermiso.idGrupo
            Debug.Print(query)
            ds = EjecutarSQL(query)
            If ds.Tables(0).Rows(0).Item(0).ToString = "0" Then
                query = "INSERT INTO PertenenciaGrupos (idUsuario, idGrupo) VALUES (" _
                            & uPermiso.idUsuario() & "," _
                            & uPermiso.idGrupo() & ")"
                Debug.Print(query)
                EjecutarSQL(query)
                Return errorBD.ok
            Else
                Return errorBD.claveDuplicada
            End If

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function

    Public Overrides Function proximoId() As Integer

    End Function


End Class
