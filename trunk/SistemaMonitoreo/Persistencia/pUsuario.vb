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
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD
        Try
            Dim unDsUsuario As dsUsuario
            Dim unUsuario As dsUsuario.UsuariosRow
            unDsUsuario = CType(objeto, dsUsuario)
            unUsuario = CType(unDsUsuario.Usuarios.Rows(0), dsUsuario.UsuariosRow)
            Dim ds As DataSet = Me.EjecutarSQL("select * from usuarios where id = '" & unUsuario.Id.ToString & "'")
            If ds.Tables("Tabla").Rows.Count = 1 Then
                Dim fila As DataRow = ds.Tables("tabla").Rows(0)
                fila.BeginEdit()
                fila("id") = unUsuario.Id.ToString
                fila("nombre") = unUsuario.Nombre.ToString
                fila("contrasenia") = unUsuario.Contrasenia.ToString
                fila.EndEdit()
                Return Me.actualizar("Select * from personal", ds)
            ElseIf ds.Tables("Tabla").Rows.Count = 0 Then
                Dim fila As DataRow = ds.Tables("tabla").NewRow
                fila("id") = unUsuario.Id.ToString
                fila("nombre") = unUsuario.Nombre.ToString
                fila("contrasenia") = unUsuario.Contrasenia.ToString
                ds.Tables("tabla").Rows.Add(fila)
                Return Me.actualizar("Select * from personal", ds)
            Else
                Return errorBD.sinRegistro
            End If
            Return errorBD.ok
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return errorBD.errorGeneral
        End Try
    End Function

    Public Overrides Function proximoId() As Integer

    End Function
End Class
