Imports System.IO
Public Class utilsArchivos

    Public Shared Function escribirArchivo(ByVal texto As String, ByVal archivo As String, Optional ByVal mensajeError As String = "") As Boolean
        Dim bAns As Boolean = False
        Dim contenido As String
        Dim objArchivo As StreamWriter
        Try
            contenido = leerArchivo(archivo)
            objArchivo = New StreamWriter(archivo)
            objArchivo.Write(contenido)
            objArchivo.Write(texto)
            objArchivo.Close()
            bAns = True
        Catch Ex As Exception
            mensajeError = Ex.Message
        End Try
        Return bAns
    End Function

    Public Shared Function borrarArchivo(ByVal archivo As String, Optional ByVal mensajeError As String = "") As Boolean
        Dim bAns As Boolean = False
        Dim objArchivo As StreamWriter
        Try
            objArchivo = New StreamWriter(archivo)
            objArchivo.Write("")
            objArchivo.Close()
            bAns = True
        Catch Ex As Exception
            mensajeError = Ex.Message
        End Try
        Return bAns
    End Function
    Public Shared Function leerArchivo(ByVal archivo As String, Optional ByRef mensajeError As String = "") As String
        Dim contenido As String
        Dim objArchivo As StreamReader
        Try
            objArchivo = New StreamReader(archivo)
            contenido = objArchivo.ReadToEnd()
            objArchivo.Close()
            Return contenido
        Catch Ex As Exception
            mensajeError = Ex.Message
            Return Nothing
        End Try
    End Function

End Class
