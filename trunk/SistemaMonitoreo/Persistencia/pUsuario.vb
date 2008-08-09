Imports System.Data.OleDb
Imports DAC
Public Class pUsuario : Inherits Persistente


    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD
        Dim query As String
        Dim id As String = CType(objeto, String)
        Try
            query = "DELETE FROM usuarios " _
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
            ds = EjecutarSQL("select * from usuarios order by nombre")
            Return ds.Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal clave As Object) As Object
        'Dim lista As New ArrayList
        'Dim ds As DataSet

        'Dim unDsUsuario As dsUsuario
        'Dim unUsuario As dsUsuario.UsuariosRow
        'unDsUsuario = CType(clave, dsUsuario)
        'unUsuario = CType(unDsUsuario.Usuarios.Rows(0), dsUsuario.UsuariosRow)

        'Try
        '    ds = Me.EjecutarSQL("select * from usuarios where nombre = " & unUsuario.Nombre & ";")
        '    Return ds.Tables(0).Rows
        'Catch ex As Exception
        '    Debug.WriteLine(ex.Message)
        'End Try
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Dim query As String
        Try
            query = "SELECT * FROM usuarios " _
                    & " WHERE nombre = '" & filtro & "';"
            Debug.Print(query)
            Return EjecutarSQL(query).Tables(0).Rows
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unUsuario As dsUsuario.UsuariosRow
            Dim query As String
            Dim busqueda As DataRowCollection

            unUsuario = CType(objeto, dsUsuario.UsuariosRow)
            busqueda = Me.buscar(unUsuario.Nombre)
            If busqueda.Count = 0 Then
                query = "INSERT INTO Usuarios (nombre, contrasenia) VALUES (" _
                    & "'" & unUsuario.Nombre() & "'," _
                    & "'" & unUsuario.Contrasenia() & "')"
            ElseIf busqueda.Count = 1 Then
                query = "UPDATE Usuarios SET " _
                    & " contrasenia = '" & unUsuario.Contrasenia() & "'" _
                    & " WHERE nombre = '" & unUsuario.Nombre() & "';"
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
