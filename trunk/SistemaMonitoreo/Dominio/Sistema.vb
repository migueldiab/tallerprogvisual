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
        rawDataUsuarios = pUsuario.buscar()
        For Each unUsuario As DataRow In rawDataUsuarios
            Dim tempUsuario As New Usuario
            tempUsuario.id = unUsuario.Item(0).ToString()
            tempUsuario.nombre = unUsuario.Item(1).ToString()
            tempUsuario.contrasenia = unUsuario.Item(2).ToString()
            arrayUsuarios.Add(tempUsuario)
        Next
        Return arrayUsuarios
    End Function

    ' Función   : Devuelve todos los Grupos
    ' Entrada   : 
    ' Salida    : Lista con todos los Grupos ordenados alfabeticamente
    ' Notas     :
    Public Shared Function listaGrupos() As ArrayList
        Dim rawDataGrupos As DataRowCollection
        Dim arrayGrupos As New ArrayList
        Dim pGrupo As New pGrupo
        rawDataGrupos = pGrupo.buscar()
        For Each unGrupo As DataRow In rawDataGrupos
            Dim tempGrupo As New Grupo
            tempGrupo.id = unGrupo.Item(0).ToString()
            tempGrupo.nombre = unGrupo.Item(1).ToString()
            tempGrupo.contrasenia = unGrupo.Item(2).ToString()
            arrayGrupos.Add(tempGrupo)
        Next
        Return arrayGrupos
    End Function
#End Region

End Class
