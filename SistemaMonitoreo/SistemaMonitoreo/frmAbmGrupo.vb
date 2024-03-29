Imports Dominio

Public Class frmAbmGrupo
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmAbmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListaGrupos(Sistema.listaGrupos())
        cargarListaLogs()
    End Sub

    Public Sub cargarListaGrupos(ByVal listaGrupos As ArrayList)
        lstGrupos.Items.Clear()
        Dim nuevoGrupo As New Grupo()
        nuevoGrupo.nombre = "--Nuevo grupo--"
        lstGrupos.Items.Add(nuevoGrupo)
        For Each unGrupo As Grupo In listaGrupos
            lstGrupos.Items.Add(unGrupo)
        Next
    End Sub
    Public Sub cargarListaLogs()
        
        For Each tipoLog As Sistema.LOGS In [Enum].GetValues(GetType(Sistema.LOGS))
            Dim strMsgType As String = tipoLog.ToString()
            selLogs.Items.Add(strMsgType)
        Next

    End Sub
    Private Sub lstGrupos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGrupos.SelectedIndexChanged
        If (lstGrupos.SelectedItems.Count <> 0) Then
            mostrarDatos(CType(lstGrupos.SelectedItems.Item(0), Grupo))
        Else
            limpiarDatos()
        End If
    End Sub


    Private Sub mostrarDatos(ByVal grupo As Grupo)
        txtNombre.Text = grupo.nombre.ToString
        txtID.Text = grupo.id.ToString
        chkUsuariosRead.Checked = (grupo.usuarios.IndexOf(sistema.LECTURA) <> -1)
        chkUsuariosWrite.Checked = (grupo.usuarios.IndexOf(Sistema.ESCRITURA) <> -1)
        chkEquiposRead.Checked = (grupo.equipos.IndexOf(Sistema.LECTURA) <> -1)
        chkEquiposWrite.Checked = (grupo.equipos.IndexOf(Sistema.ESCRITURA) <> -1)
        selLogs.SelectedIndex = grupo.logs
        If grupo.id <> "" Then
            txtNombre.Enabled = False
        Else
            txtNombre.Enabled = True
        End If
        txtNombre.Focus()
    End Sub
    Public Sub limpiarDatos()
        txtNombre.Text = ""
        txtID.Text = ""
        chkUsuariosRead.Checked = False
        chkUsuariosWrite.Checked = False
        chkEquiposRead.Checked = False
        chkEquiposWrite.Checked = False
        selLogs.SelectedIndex = -1
        txtNombre.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If controlarDatos() Then
            Dim uGrupo As New Grupo(txtID.Text.ToString)
            Dim permisos As String
            uGrupo.nombre = txtNombre.Text
            permisos = ""
            If chkUsuariosRead.Checked Then
                permisos = permisos & Sistema.LECTURA
            End If
            If chkUsuariosWrite.Checked Then
                permisos = permisos & Sistema.ESCRITURA
            End If
            uGrupo.usuarios = permisos
            permisos = ""
            If chkEquiposRead.Checked Then
                permisos = permisos & Sistema.LECTURA
            End If
            If chkEquiposWrite.Checked Then
                permisos = permisos & Sistema.ESCRITURA
            End If
            uGrupo.equipos = permisos
            uGrupo.logs = selLogs.SelectedIndex
            uGrupo.guardar()
            txtFiltroGrupos.Text = ""
            limpiarDatos()
            cargarListaGrupos(Sistema.listaGrupos())
        Else
            MsgBox("Datos incorrectos, imposible guardar grupo", MsgBoxStyle.Critical, "Error")
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

    Private Sub txtEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEliminar.Click
        If MsgBox("Seguro que desea eliminar el grupo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Borrar Grupo") = MsgBoxResult.Yes Then
            Dim uGrupo As New Grupo(txtID.Text.ToString)
            If (uGrupo.borrar()) Then
                Me.cargarListaGrupos(Sistema.listaGrupos())
                Me.limpiarDatos()
            Else
                MsgBox("No se puede borrar el registro, permisos asociados", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End If
            'MsgBox("No existe el Grupo", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")

        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class