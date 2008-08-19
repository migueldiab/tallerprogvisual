Imports Dominio

Module SistemaMonitoreo
    Public Const LARGO_MIN_USUARIO As Integer = 4
    Public Const LARGO_MIN_PASSWORD As Integer = 4
    Public Const REGISTOS_IMPORTAR_CSV As Integer = 3
    Public Const ADMINISTRADOR As String = "Administradores"


    ' Función   : Punto de inicio del programa
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Sub main()
        Dim sistema As New Sistema()
        Dim login As New frmLogin()
        login.ShowDialog()
    End Sub
End Module
