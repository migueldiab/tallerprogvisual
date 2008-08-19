Imports Dominio
Public Class frmLogUsuarios
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub


    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Dim abrirArchivo As New OpenFileDialog()

        abrirArchivo.InitialDirectory = "c:\"
        abrirArchivo.Filter = "Archivo de Log (*.log)|*.log|All files (*.*)|*.*"
        abrirArchivo.FilterIndex = 1
        abrirArchivo.RestoreDirectory = False

        If abrirArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtLogUsuarios.Text = utilsArchivos.leerArchivo(abrirArchivo.FileName)

        End If

    End Sub

End Class