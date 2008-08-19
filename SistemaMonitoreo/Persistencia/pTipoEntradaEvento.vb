Public Class pTipoEntradaEvento : Inherits Persistente


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

    End Function

    Public Overrides Function proximoId() As Integer

    End Function
End Class
