<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmGrupo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstGrupos = New System.Windows.Forms.ListBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtFiltroGrupos = New System.Windows.Forms.TextBox
        Me.lblEquipos = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblUsuarios = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtEliminar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lblLogs = New System.Windows.Forms.Label
        Me.chkUsuariosRead = New System.Windows.Forms.CheckBox
        Me.chkUsuariosWrite = New System.Windows.Forms.CheckBox
        Me.chkEquiposRead = New System.Windows.Forms.CheckBox
        Me.chkEquiposWrite = New System.Windows.Forms.CheckBox
        Me.selLogs = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'lstGrupos
        '
        Me.lstGrupos.FormattingEnabled = True
        Me.lstGrupos.ItemHeight = 18
        Me.lstGrupos.Location = New System.Drawing.Point(12, 48)
        Me.lstGrupos.Name = "lstGrupos"
        Me.lstGrupos.Size = New System.Drawing.Size(205, 274)
        Me.lstGrupos.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(356, 45)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 21
        '
        'txtFiltroGrupos
        '
        Me.txtFiltroGrupos.Location = New System.Drawing.Point(66, 13)
        Me.txtFiltroGrupos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroGrupos.Name = "txtFiltroGrupos"
        Me.txtFiltroGrupos.Size = New System.Drawing.Size(150, 26)
        Me.txtFiltroGrupos.TabIndex = 19
        '
        'lblEquipos
        '
        Me.lblEquipos.AutoSize = True
        Me.lblEquipos.Location = New System.Drawing.Point(239, 116)
        Me.lblEquipos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquipos.Name = "lblEquipos"
        Me.lblEquipos.Size = New System.Drawing.Size(65, 18)
        Me.lblEquipos.TabIndex = 31
        Me.lblEquipos.Text = "Equipos"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(356, 11)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(103, 26)
        Me.txtID.TabIndex = 20
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Location = New System.Drawing.Point(239, 82)
        Me.lblUsuarios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(72, 18)
        Me.lblUsuarios.TabIndex = 30
        Me.lblUsuarios.Text = "Usuarios"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(498, 290)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 32)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(378, 290)
        Me.txtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(112, 32)
        Me.txtEliminar.TabIndex = 25
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(258, 290)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(239, 48)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 18)
        Me.lblNombre.TabIndex = 32
        Me.lblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Filtro"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(239, 14)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 18)
        Me.lblID.TabIndex = 29
        Me.lblID.Text = "ID"
        '
        'lblLogs
        '
        Me.lblLogs.AutoSize = True
        Me.lblLogs.Location = New System.Drawing.Point(239, 150)
        Me.lblLogs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogs.Name = "lblLogs"
        Me.lblLogs.Size = New System.Drawing.Size(43, 18)
        Me.lblLogs.TabIndex = 31
        Me.lblLogs.Text = "Logs"
        '
        'chkUsuariosRead
        '
        Me.chkUsuariosRead.AutoSize = True
        Me.chkUsuariosRead.Location = New System.Drawing.Point(356, 82)
        Me.chkUsuariosRead.Name = "chkUsuariosRead"
        Me.chkUsuariosRead.Size = New System.Drawing.Size(64, 22)
        Me.chkUsuariosRead.TabIndex = 33
        Me.chkUsuariosRead.Text = "Read"
        Me.chkUsuariosRead.UseVisualStyleBackColor = True
        '
        'chkUsuariosWrite
        '
        Me.chkUsuariosWrite.AutoSize = True
        Me.chkUsuariosWrite.Location = New System.Drawing.Point(426, 82)
        Me.chkUsuariosWrite.Name = "chkUsuariosWrite"
        Me.chkUsuariosWrite.Size = New System.Drawing.Size(66, 22)
        Me.chkUsuariosWrite.TabIndex = 33
        Me.chkUsuariosWrite.Text = "Write"
        Me.chkUsuariosWrite.UseVisualStyleBackColor = True
        '
        'chkEquiposRead
        '
        Me.chkEquiposRead.AutoSize = True
        Me.chkEquiposRead.Location = New System.Drawing.Point(356, 116)
        Me.chkEquiposRead.Name = "chkEquiposRead"
        Me.chkEquiposRead.Size = New System.Drawing.Size(64, 22)
        Me.chkEquiposRead.TabIndex = 33
        Me.chkEquiposRead.Text = "Read"
        Me.chkEquiposRead.UseVisualStyleBackColor = True
        '
        'chkEquiposWrite
        '
        Me.chkEquiposWrite.AutoSize = True
        Me.chkEquiposWrite.Location = New System.Drawing.Point(426, 116)
        Me.chkEquiposWrite.Name = "chkEquiposWrite"
        Me.chkEquiposWrite.Size = New System.Drawing.Size(66, 22)
        Me.chkEquiposWrite.TabIndex = 33
        Me.chkEquiposWrite.Text = "Write"
        Me.chkEquiposWrite.UseVisualStyleBackColor = True
        '
        'selLogs
        '
        Me.selLogs.FormattingEnabled = True
        Me.selLogs.Location = New System.Drawing.Point(356, 150)
        Me.selLogs.Name = "selLogs"
        Me.selLogs.Size = New System.Drawing.Size(204, 26)
        Me.selLogs.TabIndex = 34
        '
        'frmAbmGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 332)
        Me.Controls.Add(Me.selLogs)
        Me.Controls.Add(Me.chkEquiposWrite)
        Me.Controls.Add(Me.chkEquiposRead)
        Me.Controls.Add(Me.chkUsuariosWrite)
        Me.Controls.Add(Me.chkUsuariosRead)
        Me.Controls.Add(Me.lstGrupos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblLogs)
        Me.Controls.Add(Me.txtFiltroGrupos)
        Me.Controls.Add(Me.lblEquipos)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAbmGrupo"
        Me.Text = "Administración de Grupos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstGrupos As System.Windows.Forms.ListBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroGrupos As System.Windows.Forms.TextBox
    Friend WithEvents lblEquipos As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblLogs As System.Windows.Forms.Label
    Friend WithEvents chkUsuariosRead As System.Windows.Forms.CheckBox
    Friend WithEvents chkUsuariosWrite As System.Windows.Forms.CheckBox
    Friend WithEvents chkEquiposRead As System.Windows.Forms.CheckBox
    Friend WithEvents chkEquiposWrite As System.Windows.Forms.CheckBox
    Friend WithEvents selLogs As System.Windows.Forms.ComboBox
End Class
