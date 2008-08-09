Imports System.Data.OleDb
Imports DAC

Public Class pEquipo : Inherits Persistente



    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD
        Dim query As String
        Dim id As String = CType(objeto, String)
        Try
            query = "DELETE FROM equipos " _
                    & " WHERE id = " & id & ";"
            Debug.Print(query)
            EjecutarSQL(query)
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
            ds = EjecutarSQL("select * from equipos order by nombreMaquina")
            Return ds.Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal clave As Object) As Object
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Dim query As String
        Try
            query = "SELECT * FROM equipos " _
                    & " WHERE nombreMaquina = '" & filtro & "';"
            Debug.Print(query)
            Return EjecutarSQL(query).Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unEquipo As dsEquipo.EquiposRow
            Dim query As String
            Dim busqueda As DataRowCollection

            unEquipo = CType(objeto, dsEquipo.EquiposRow)
            busqueda = Me.buscar(unEquipo.NombreMaquina)
            If busqueda.Count = 0 Then
                query = "INSERT INTO Equipos (nombreMaquina, IP, nombreDominio, destino) VALUES (" _
                    & "'" & unEquipo.NombreMaquina() & "'," _
                    & "'" & unEquipo.IP() & "'," _
                    & "'" & unEquipo.NombreDominio() & "'," _
                    & "'" & unEquipo.Destino() & "')"
            ElseIf busqueda.Count = 1 Then
                query = "UPDATE Equipos SET " _
                    & " IP             = '" & unEquipo.IP() & "'," _
                    & " nombreDominio  = '" & unEquipo.NombreDominio() & "'," _
                    & " destino        = '" & unEquipo.Destino() & "'" _
                    & " WHERE nombreMaquina = '" & unEquipo.NombreMaquina() & "';"
            Else
                Return errorBD.errorGeneral
            End If
            Debug.Print(query)
            EjecutarSQL(query)

            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function

    Public Overrides Function proximoId() As Integer

    End Function
End Class
