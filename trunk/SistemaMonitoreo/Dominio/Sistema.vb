Imports Persistencia
Public Class Sistema

#Region "Metodos"
    ' Función   : Devuelve todos los usuarios
    ' Entrada   : 
    ' Salida    : Lista con todos los usuarios ordenados alfabeticamente
    ' Notas     :
    Public Shared Function listaUsuarios() As ArrayList
        Dim rawDataUsuarios As DataRowCollection
        Dim arrayUsuarios As New ArrayList
        Dim pUsuario As New pUsuario
        Dim tempUsuario As New Usuario
        rawDataUsuarios = pUsuario.buscar()
        For Each unUsuario As DataRow In rawDataUsuarios
            tempUsuario.id = unUsuario.Item(0).ToString()
            tempUsuario.nombre = unUsuario.Item(1).ToString()
            tempUsuario.contrasenia = unUsuario.Item(2).ToString()
            arrayUsuarios.Add(tempUsuario)
        Next
        Return arrayUsuarios
    End Function
#End Region

End Class
