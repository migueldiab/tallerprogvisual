Imports System.Data.OleDb
Imports DAC
Public Class pUsuario : Inherits Persistente


    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD

    End Function

    Public Overloads Overrides Function buscar() As DataRowCollection
        Dim lista As New ArrayList
        Dim ds As DataSet
        Try
            ds = Me.EjecutarSQL("select * from usuarios order by nombre")
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
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unUsuario As dsUsuario.UsuariosRow
            unUsuario = CType(objeto, dsUsuario.UsuariosRow)
            Dim query As String

            me.buscar(

            query = "INSERT INTO Usuarios VALUES (" _
                & unUsuario.Id() & ",'" _
                & unUsuario.Nombre() & "','" _
                & unUsuario.Contrasenia() _
                & "')"

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
