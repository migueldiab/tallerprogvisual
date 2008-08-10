<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmEquipo
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
        Me.lstEquipos = New System.Windows.Forms.ListBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.lblDestino = New System.Windows.Forms.Label
        Me.txtFiltroEquipos = New System.Windows.Forms.TextBox
        Me.lblDominio = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblIP = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtEliminar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txtDominio = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lstEquipos
        '
        Me.lstEquipos.FormattingEnabled = True
        Me.lstEquipos.ItemHeight = 18
        Me.lstEquipos.Location = New System.Drawing.Point(12, 41)
        Me.lstEquipos.Name = "lstEquipos"
        Me.lstEquipos.Size = New System.Drawing.Size(205, 274)
        Me.lstEquipos.TabIndex = 41
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(356, 38)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 37
        '
        'lblDestino
        '
        Me.lblDestino.AutoSize = True
        Me.lblDestino.Location = New System.Drawing.Point(239, 143)
        Me.lblDestino.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDestino.Name = "lblDestino"
        Me.lblDestino.Size = New System.Drawing.Size(64, 18)
        Me.lblDestino.TabIndex = 45
        Me.lblDestino.Text = "Destino"
        '
        'txtFiltroEquipos
        '
        Me.txtFiltroEquipos.Location = New System.Drawing.Point(66, 6)
        Me.txtFiltroEquipos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroEquipos.Name = "txtFiltroEquipos"
        Me.txtFiltroEquipos.Size = New System.Drawing.Size(150, 26)
        Me.txtFiltroEquipos.TabIndex = 35
        '
        'lblDominio
        '
        Me.lblDominio.AutoSize = True
        Me.lblDominio.Location = New System.Drawing.Point(239, 109)
        Me.lblDominio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDominio.Name = "lblDominio"
        Me.lblDominio.Size = New System.Drawing.Size(69, 18)
        Me.lblDominio.TabIndex = 46
        Me.lblDominio.Text = "Dominio"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(356, 4)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(103, 26)
        Me.txtID.TabIndex = 36
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(239, 75)
        Me.lblIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(22, 18)
        Me.lblIP.TabIndex = 44
        Me.lblIP.Text = "IP"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(498, 283)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 32)
        Me.btnCerrar.TabIndex = 40
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(378, 283)
        Me.txtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(112, 32)
        Me.txtEliminar.TabIndex = 39
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(258, 283)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.btnGuardar.TabIndex = 38
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(239, 41)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 18)
        Me.lblNombre.TabIndex = 47
        Me.lblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Filtro"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(239, 7)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 18)
        Me.lblID.TabIndex = 43
        Me.lblID.Text = "ID"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(356, 72)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(204, 26)
        Me.txtIP.TabIndex = 37
        '
        'txtDominio
        '
        Me.txtDominio.Location = New System.Drawing.Point(356, 106)
        Me.txtDominio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDominio.Name = "txtDominio"
        Me.txtDominio.Size = New System.Drawing.Size(204, 26)
        Me.txtDominio.TabIndex = 37
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(356, 140)
        Me.txtDestino.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(204, 26)
        Me.txtDestino.TabIndex = 37
        '
        'frmAbmEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 328)
        Me.Controls.Add(Me.lstEquipos)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtDominio)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDestino)
        Me.Controls.Add(Me.txtFiltroEquipos)
        Me.Controls.Add(Me.lblDominio)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAbmEquipo"
        Me.Text = "Administración de Equipos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEquipos As System.Windows.Forms.ListBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDestino As System.Windows.Forms.Label
    Friend WithEvents txtFiltroEquipos As System.Windows.Forms.TextBox
    Friend WithEvents lblDominio As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtDominio As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
End Class
