Imports Dominio


Module SistemaMonitoreo
    ' Función   : Punto de inicio del programa
    ' Entrada   : 
    ' Salida    : 
    ' Notas     :
    Sub main()
        Dim sistema As New Sistema()
        Dim ventanaPrincipal As New frmSistema()
        ' Llamada a Ventana Principal
        ventanaPrincipal.ShowDialog()


    End Sub
End Module
