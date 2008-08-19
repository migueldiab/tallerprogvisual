Imports System.Windows.Forms
Imports Dominio

Public Class frmSistema
    Public importarLogs As System.Windows.Forms.Form
    Public abmEquipos As System.Windows.Forms.Form
    Public listadoEquipos As System.Windows.Forms.Form
    Public abmGrupos As System.Windows.Forms.Form
    Public abmUsuarios As System.Windows.Forms.Form
    Public importarUsuarios As System.Windows.Forms.Form
    Public permisosUsuario As System.Windows.Forms.Form
    Public logUsuarios As System.Windows.Forms.Form
    Public consultaLogs As System.Windows.Forms.Form


    Public Sub New(ByVal Usuario As Usuario)
        ' Llamada necesaria para el Diseñador de Windows Forms.

        InitializeComponent()
        Sistema.usuarioLogueado = Usuario
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripButton.Click
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        Me.Text = My.Computer.Clipboard.GetText().ToString()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub importarLogsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mImportarLogs.Click
        If importarLogs Is Nothing Then
            importarLogs = New frmLog(Me)
        ElseIf importarLogs.IsDisposed Then
            importarLogs = New frmLog(Me)
        End If
        importarLogs.Show()
        importarLogs.BringToFront()
        importarLogs.Left = 0
        importarLogs.Top = 0
    End Sub

    Private Sub abmUsuariosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAbmUsuarios.Click
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.USUARIOS_CONSULTA) Then
            If abmUsuarios Is Nothing Then
                abmUsuarios = New frmAbmUsuario(Me)
            ElseIf abmUsuarios.IsDisposed Then
                abmUsuarios = New frmAbmUsuario(Me)
            End If
            abmUsuarios.Show()
            abmUsuarios.BringToFront()
            abmUsuarios.Left = 0
            abmUsuarios.Top = 0
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    Private Sub importarUsuariosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mImportarUsuarios.Click
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.USUARIOS_IMPORTAR) Then
            If importarUsuarios Is Nothing Then
                importarUsuarios = New frmImportarUsuarios(Me)
            ElseIf importarUsuarios.IsDisposed Then
                importarUsuarios = New frmImportarUsuarios(Me)
            End If
            importarUsuarios.Show()
            importarUsuarios.BringToFront()
            importarUsuarios.Left = 0
            importarUsuarios.Top = 0
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    Private Sub logUsuariosMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mLogsUsuarios.Click
        If logUsuarios Is Nothing Then
            logUsuarios = New frmLogUsuarios(Me)
        ElseIf logUsuarios.IsDisposed Then
            logUsuarios = New frmLogUsuarios(Me)
        End If
        logUsuarios.Show()
        logUsuarios.BringToFront()
        logUsuarios.Left = 0
        logUsuarios.Top = 0
    End Sub

    Private Sub permisosUsuarioMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mPermisosUsuarios.Click
        If permisosUsuario Is Nothing Then
            permisosUsuario = New frmPermisosUsuarios(Me)
        ElseIf permisosUsuario.IsDisposed Then
            permisosUsuario = New frmPermisosUsuarios(Me)
        End If
        permisosUsuario.Show()
        permisosUsuario.BringToFront()
        permisosUsuario.Left = 0
        permisosUsuario.Top = 0
    End Sub

    Private Sub abmEquiposMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAbmEquipos.Click
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.EQUIPOS_CONSULTA) Then
            If abmEquipos Is Nothing Then
                abmEquipos = New frmAbmEquipo(Me)
            ElseIf abmEquipos.IsDisposed Then
                abmEquipos = New frmAbmEquipo(Me)
            End If
            abmEquipos.Show()
            abmEquipos.BringToFront()
            abmEquipos.Left = 0
            abmEquipos.Top = 0
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    Private Sub listadoEquiposMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mListadoEquipos.Click
        If listadoEquipos Is Nothing Then
            listadoEquipos = New frmListadoEquipos(Me)
        ElseIf listadoEquipos.IsDisposed Then
            listadoEquipos = New frmListadoEquipos(Me)
        End If
        listadoEquipos.Show()
        listadoEquipos.BringToFront()
        listadoEquipos.Left = 0
        listadoEquipos.Top = 0
    End Sub

    Private Sub abmGruposMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAbmGrupos.Click
        If abmGrupos Is Nothing Then
            abmGrupos = New frmAbmGrupo(Me)
        ElseIf abmGrupos.IsDisposed Then
            abmGrupos = New frmAbmGrupo(Me)
        End If
        abmGrupos.Show()
        abmGrupos.BringToFront()
        abmGrupos.Left = 0
        abmGrupos.Top = 0
    End Sub


    Private Sub mConsultaLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mConsultaLogs.Click
        If Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_ADMIN) Or _
        Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_APLICACIONES) Or _
        Sistema.autentica(Sistema.usuarioLogueado, Sistema.acceso.LOGS_APLICACIONES_SISTEMA) Then
            If consultaLogs Is Nothing Then
                consultaLogs = New frmConsultaLog(Me)
            ElseIf consultaLogs.IsDisposed Then
                consultaLogs = New frmConsultaLog(Me)
            End If
            consultaLogs.Show()
            consultaLogs.BringToFront()
            consultaLogs.Left = 0
            consultaLogs.Top = 0
        Else
            MsgBox("Permisos insuficientes para realizar operación", MsgBoxStyle.Information, "Atención")
        End If
    End Sub

    Private Sub frmSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsMenu.Click

    End Sub

    Private Sub BloquearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BloquearToolStripMenuItem.Click
        Me.Dispose()
        Me.Close()
        Dim login As New frmLogin()
        login.ShowDialog()

    End Sub
End Class
