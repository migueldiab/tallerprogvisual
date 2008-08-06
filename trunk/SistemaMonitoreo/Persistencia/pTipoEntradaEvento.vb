Public Class pTipoEntradaEvento : Inherits Persistente


    Public Overrides Function Borrar(ByVal objeto As Object) As Persistente.errorBD

    End Function

    Public Overloads Overrides Function buscar() As DataRowCollection
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal clave As Object) As Object
        Return Nothing
    End Function

    Public Overloads Overrides Function buscar(ByVal filtro As String) As DataRowCollection
        Return Nothing
    End Function

    Public Overrides Function Guardar(ByVal objeto As Object) As Persistente.errorBD

    End Function

    Public Overrides Function proximoId() As Integer

    End Function
End Class
