Imports Dominio

Module SistemaMonitoreo

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
