Imports Dominio
Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim Usuario As New Usuario(txtUsuario.Text.ToString)
        If Usuario Is Nothing Then
            lblError.Text = "El Usuario no existe"
            lblError.Visible = True
        Else
            If Usuario.login(txtContrasenia.Text) Then
                Dim ventanaPrincipal As New frmSistema()
                ' Llamada a Ventana Principal
                ventanaPrincipal.ShowDialog()
                Me.Close()
            Else
                lblError.Text = "La contraseña no es válida"
                lblError.Visible = True
            End If

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
