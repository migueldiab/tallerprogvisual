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
        lstAsignados.Items.Clear()
        cargarListaGrupos(Sistema.listaGrupos())
        If Not usuario.grupos Is Nothing Then
            For Each unGrupo As Grupo In usuario.grupos
                If lstGrupos.Items.IndexOf(unGrupo) <> -1 Then
                    lstGrupos.Items.Remove(unGrupo)
                    lstAsignados.Items.Add(unGrupo)
                Else
                    MsgBox("This user belongs to a group that no longer exists. Group removed", MsgBoxStyle.Exclamation, "Error")
                    'Esto no debería de suceder nunca en realidad....
                End If

            Next

        End If
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
            Dim Permisos As New ArrayList
            uUsuario.id = txtID.Text
            uUsuario.nombre = txtNombre.Text
            For Each unGrupo As Grupo In lstAsignados.Items
                If unGrupo.nombre = SistemaMonitoreo.ADMINISTRADOR And lstAsignados.Items.Count > 1 Then
                    MsgBox("El usuario posee permisos de " & SistemaMonitoreo.ADMINISTRADOR & " entre otros, solo el administrador será guardado", MsgBoxStyle.Exclamation, "Error")
                    Permisos.Clear()
                    Permisos.Add(unGrupo)
                    Exit For
                End If
                Permisos.Add(unGrupo)
            Next
            uUsuario.grupos = Permisos
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

    Private Sub btnAgregarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarGrupo.Click
        If lstGrupos.SelectedItems.Count <> 1 Then
            MsgBox("Seleccione un grupo para ser asignado")
        Else
            Dim unGrupo As Grupo = CType(lstGrupos.SelectedItem, Grupo)
            If unGrupo.nombre = SistemaMonitoreo.ADMINISTRADOR Then
                If MsgBox("Al agregar el grupo " & SistemaMonitoreo.ADMINISTRADOR & ", todos los demás serán eliminados, continuar?" _
                    , MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    lstAsignados.Items.Clear()
                    lstAsignados.Items.Add(lstGrupos.SelectedItem)
                    cargarListaGrupos(Sistema.listaGrupos())
                    lstGrupos.Items.Remove(lstAsignados.Items.Item(0))
                End If
            Else
                lstAsignados.Items.Add(lstGrupos.SelectedItem)
                lstGrupos.Items.Remove(lstGrupos.SelectedItem)
            End If

        End If
    End Sub

    Private Sub btnQuitarGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarGrupo.Click
        If lstAsignados.SelectedItems.Count <> 1 Then
            MsgBox("Seleccione un grupo para ser asignado")
        Else
            lstGrupos.Items.Add(lstAsignados.SelectedItem)
            lstAsignados.Items.Remove(lstAsignados.SelectedItem)
        End If

    End Sub
End Class