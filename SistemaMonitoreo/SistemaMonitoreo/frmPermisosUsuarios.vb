Imports Dominio

Public Class frmPermisosUsuarios
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmPermisosUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListaUsuarios(Sistema.listaUsuarios())
        cargarListaGrupos(Sistema.listaGrupos())
    End Sub

    Public Sub cargarListaUsuarios(ByVal listaUsuarios As ArrayList)
        lstUsuarios.Items.Clear()
        For Each unUsuario As Usuario In listaUsuarios
            lstUsuarios.Items.Add(unUsuario)
        Next
    End Sub

    Public Sub cargarListaGrupos(ByVal listaGrupos As ArrayList)
        lstGrupos.Items.Clear()
        For Each unGrupo As Grupo In listaGrupos
            lstGrupos.Items.Add(unGrupo)
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
        txtID.Text = ""
        txtNombre.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If controlarDatos() Then
            Dim uUsuario As New Usuario(txtID.Text.ToString)
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
        'Try
        '    Convert.ToInt32(txtID.Text)
        '    Return True
        'Catch ex As Exception
        '    Return False
        'End Try
        Return True
    End Function

End Class