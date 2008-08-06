Imports Dominio
Public Class frmAbmUsuario
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub


    Private Sub frmAbmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarListaUsuarios(Sistema.listaUsuarios())

    End Sub

    Public Sub cargarListaUsuarios(ByVal listaUsuarios As ArrayList)
        lstUsuarios.Items.Clear()
        Dim nuevoUsuario As New Usuario()
        nuevoUsuario.nombre = "--Nuevo empleado--"
        lstUsuarios.Items.Add(nuevoUsuario)
        For Each unUsuario As Usuario In listaUsuarios
            lstUsuarios.Items.Add(unUsuario)
        Next
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If (Me.lstUsuarios.SelectedItems.Count <> 0) Then
            Me.mostrarDatos(CType(Me.lstUsuarios.SelectedItems.Item(0), Usuario))
        Else
            Me.limpiarDatos()
        End If
    End Sub

    Private Sub mostrarDatos(ByVal usuario As Usuario)
        txtNombre.Text = usuario.nombre.ToString
        txtContrasenia.Text = usuario.contrasenia.ToString
        txtID.Text = usuario.id.ToString
    End Sub
    Public Sub limpiarDatos()
        Me.txtNombre.Text = ""
        Me.txtContrasenia.Text = ""
        Me.txtID.Text = ""
        Me.txtID.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.controlarDatos() Then
            Dim uUsuario As New Usuario(txtID.Text.ToString)
            uUsuario.contrasenia = txtContrasenia.Text
            uUsuario.nombre = txtNombre.Text
            uUsuario.guardar()
            txtFiltroUsuarios.Text = ""
            Me.limpiarDatos()
            Me.cargarListaUsuarios(Sistema.listaUsuarios())

        Else
            MsgBox("Datos incorrectos, imposible guardar usuario", MsgBoxStyle.Critical, "Error")
        End If


    End Sub

    Private Function controlarDatos() As Boolean
        If Me.txtNombre.Text.Length < 4 Then
            Return False
        End If
        Try
            Convert.ToInt32(Me.txtID.Text)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class