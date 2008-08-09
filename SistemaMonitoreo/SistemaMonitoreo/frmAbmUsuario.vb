Imports Dominio

Public Class frmAbmUsuario
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MdiParent = ventanaPadre
    End Sub

    Private Sub frmAbmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If controlarDatos() Then
            Dim uUsuario As New Usuario(txtID.Text.ToString)
            uUsuario.contrasenia = txtContrasenia.Text
            uUsuario.nombre = txtNombre.Text
            uUsuario.guardar()
            txtFiltroUsuarios.Text = ""
            limpiarDatos()
            cargarListaUsuarios(Sistema.listaUsuarios())
        Else
            MsgBox("Datos incorrectos, imposible guardar usuario", MsgBoxStyle.Critical, "Error")
        End If


    End Sub

    Private Function controlarDatos() As Boolean
        If txtNombre.Text.Length < 4 Then
            Return False
        End If
        If txtContrasenia.Text.Length < 4 Then
            Return False
        End If
        If txtContrasenia.Text <> txtRepetir.Text Then
            Return False
        End If
        'Try
        '    Convert.ToInt32(txtID.Text)
        '    Return True
        'Catch ex As Exception
        '    Return False
        'End Try
        Return True
    End Function

    Private Sub txtEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEliminar.Click
        If MsgBox("Seguro que desea eliminar el usuario?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Borrar Usuario") = MsgBoxResult.Yes Then
            Dim uUsuario As New Usuario(txtID.Text.ToString)
            uUsuario.borrar()
            Me.cargarListaUsuarios(Sistema.listaUsuarios())
            Me.limpiarDatos()
            'MsgBox("No existe el Usuario", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            'MsgBox("No se puede borrar el registro", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub
End Class