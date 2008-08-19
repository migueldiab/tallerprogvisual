Imports Dominio

Public Class frmAbmEquipo
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmAbmEquipo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Grupos' table. You can move, or remove it, as needed.
        Me.GruposTableAdapter.Fill(Me.DBDataSet.Grupos)
        cargarListaEquipos(Sistema.listaEquipos())
    End Sub

    Public Sub cargarListaEquipos(ByVal listaEquipos As ArrayList)
        lstEquipos.Items.Clear()
        Dim nuevoEquipo As New Equipo()
        nuevoEquipo.nombre = "--Nuevo equipo--"
        lstEquipos.Items.Add(nuevoEquipo)
        For Each unEquipo As Equipo In listaEquipos
            lstEquipos.Items.Add(unEquipo)
        Next
    End Sub

    Private Sub lstEquipos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEquipos.SelectedIndexChanged
        If (lstEquipos.SelectedItems.Count <> 0) Then
            mostrarDatos(CType(lstEquipos.SelectedItems.Item(0), Equipo))
        Else
            limpiarDatos()
        End If
    End Sub


    Private Sub mostrarDatos(ByVal equipo As Equipo)
        txtNombre.Text = equipo.nombre.ToString
        txtID.Text = equipo.id.ToString
        txtDestino.Text = equipo.destino.ToString
        txtDominio.Text = equipo.dominio.ToString
        txtIP.Text = equipo.IP.ToString
        If equipo.id <> "" Then
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
        txtDestino.Text = ""
        txtDominio.Text = ""
        txtIP.Text = ""
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.EQUIPOS_ALTA) Then
            If controlarDatos() Then
                Dim uEquipo As New Equipo(txtID.Text.ToString)
                uEquipo.nombre = txtNombre.Text
                uEquipo.destino = txtDestino.Text
                uEquipo.dominio = txtDominio.Text
                uEquipo.IP = txtIP.Text
                uEquipo.guardar()
                txtFiltroEquipos.Text = ""
                limpiarDatos()
                cargarListaEquipos(Sistema.listaEquipos())
            Else
                MsgBox("Datos incorrectos, imposible guardar equipo", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
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
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.EQUIPOS_ALTA) Then
            If MsgBox("Seguro que desea eliminar el equipo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Borrar Equipo") = MsgBoxResult.Yes Then
                Dim uEquipo As New Equipo(txtID.Text.ToString)
                uEquipo.borrar()
                Me.cargarListaEquipos(Sistema.listaEquipos())
                Me.limpiarDatos()
                'MsgBox("No existe el Equipo", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                'MsgBox("No se puede borrar el registro", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
            End If
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
        End If

    End Sub

    Private Sub txtDestino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDestino.TextChanged

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class