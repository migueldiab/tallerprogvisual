Imports Dominio

Public Class frmImportarUsuarios
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmImportarUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListaUsuarios(Sistema.listaUsuarios())
    End Sub

    Public Sub cargarListaUsuarios(ByVal listaUsuarios As ArrayList)
        lstUsuarios.Items.Clear()
        Dim nuevoUsuario As New Usuario()
        nuevoUsuario.nombre = "--Nuevo usuario--"
        lstUsuarios.Items.Add(nuevoUsuario)
        For Each unUsuario As Usuario In listaUsuarios
            lstUsuarios.Items.Add(unUsuario)
        Next
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If (lstUsuarios.SelectedItems.Count <> 0) Then
            mostrarDatos(CType(lstUsuarios.SelectedItems.Item(0), Usuario))
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub mostrarDatos(ByVal usuario As Usuario)
        txtNombre.Text = usuario.nombre.ToString
        txtContrasenia.Text = usuario.contrasenia.ToString
        txtRepetir.Text = usuario.contrasenia.ToString
        txtID.Text = usuario.id.ToString
        If usuario.id <> "" Then
            txtNombre.Enabled = False
        Else
            txtNombre.Enabled = True
        End If
        txtNombre.Focus()
    End Sub
    Public Sub limpiarDatos()
        txtNombre.Text = ""
        txtContrasenia.Text = ""
        txtRepetir.Text = ""
        txtID.Text = ""
        txtNombre.Enabled = True
    End Sub



    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim abrirArchivo As New OpenFileDialog()

        abrirArchivo.InitialDirectory = "c:\"
        abrirArchivo.Filter = "Comma Separated Values (*.csv)|*.csv|All files (*.*)|*.*"
        abrirArchivo.FilterIndex = 1
        abrirArchivo.RestoreDirectory = False

        If abrirArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Sistema.importarUsuarios(abrirArchivo.OpenFile(), abrirArchivo.FileName & ".log")
            cargarListaUsuarios(Sistema.listaUsuarios())
        End If



    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles abrirArchivo.FileOk

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class