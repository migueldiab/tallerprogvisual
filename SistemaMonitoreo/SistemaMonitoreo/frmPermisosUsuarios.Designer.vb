<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermisosUsuarios
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
        Me.lstUsuarios = New System.Windows.Forms.ListBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtFiltroUsuarios = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lstGrupos = New System.Windows.Forms.ListBox
        Me.lstAsignados = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstUsuarios
        '
        Me.lstUsuarios.FormattingEnabled = True
        Me.lstUsuarios.ItemHeight = 18
        Me.lstUsuarios.Location = New System.Drawing.Point(12, 41)
        Me.lstUsuarios.Name = "lstUsuarios"
        Me.lstUsuarios.Size = New System.Drawing.Size(205, 274)
        Me.lstUsuarios.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(356, 38)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 21
        '
        'txtFiltroUsuarios
        '
        Me.txtFiltroUsuarios.Location = New System.Drawing.Point(66, 6)
        Me.txtFiltroUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroUsuarios.Name = "txtFiltroUsuarios"
        Me.txtFiltroUsuarios.Size = New System.Drawing.Size(150, 26)
        Me.txtFiltroUsuarios.TabIndex = 19
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(356, 4)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(103, 26)
        Me.txtID.TabIndex = 20
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(498, 283)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 32)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(242, 283)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(248, 32)
        Me.btnGuardar.TabIndex = 24
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
        Me.lblNombre.TabIndex = 32
        Me.lblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Filtro"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(239, 7)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 18)
        Me.lblID.TabIndex = 29
        Me.lblID.Text = "ID"
        '
        'lstGrupos
        '
        Me.lstGrupos.FormattingEnabled = True
        Me.lstGrupos.ItemHeight = 18
        Me.lstGrupos.Location = New System.Drawing.Point(242, 107)
        Me.lstGrupos.Name = "lstGrupos"
        Me.lstGrupos.Size = New System.Drawing.Size(145, 166)
        Me.lstGrupos.TabIndex = 33
        '
        'lstAsignados
        '
        Me.lstAsignados.FormattingEnabled = True
        Me.lstAsignados.ItemHeight = 18
        Me.lstAsignados.Location = New System.Drawing.Point(465, 107)
        Me.lstAsignados.Name = "lstAsignados"
        Me.lstAsignados.Size = New System.Drawing.Size(145, 166)
        Me.lstAsignados.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(462, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Asignados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Disponibles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(394, 191)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 27)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(394, 156)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 27)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPermisosUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 328)
        Me.Controls.Add(Me.lstAsignados)
        Me.Controls.Add(Me.lstGrupos)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtFiltroUsuarios)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPermisosUsuarios"
        Me.Text = "Permisos de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lstGrupos As System.Windows.Forms.ListBox
    Friend WithEvents lstAsignados As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
