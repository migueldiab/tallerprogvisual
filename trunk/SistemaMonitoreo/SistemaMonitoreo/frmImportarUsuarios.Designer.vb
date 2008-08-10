<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarUsuarios
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
        Me.txtRepetir = New System.Windows.Forms.TextBox
        Me.txtContrasenia = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtFiltroUsuarios = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblContrasenia = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnImportar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
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
        'txtRepetir
        '
        Me.txtRepetir.Enabled = False
        Me.txtRepetir.Location = New System.Drawing.Point(356, 106)
        Me.txtRepetir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepetir.Size = New System.Drawing.Size(204, 26)
        Me.txtRepetir.TabIndex = 23
        '
        'txtContrasenia
        '
        Me.txtContrasenia.Enabled = False
        Me.txtContrasenia.Location = New System.Drawing.Point(356, 72)
        Me.txtContrasenia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasenia.Size = New System.Drawing.Size(204, 26)
        Me.txtContrasenia.TabIndex = 22
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Repetir"
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
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Location = New System.Drawing.Point(239, 75)
        Me.lblContrasenia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(94, 18)
        Me.lblContrasenia.TabIndex = 30
        Me.lblContrasenia.Text = "Contraseña"
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
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(258, 283)
        Me.btnImportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(232, 32)
        Me.btnImportar.TabIndex = 24
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
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
        'frmImportarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 324)
        Me.Controls.Add(Me.lstUsuarios)
        Me.Controls.Add(Me.txtRepetir)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtFiltroUsuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmImportarUsuarios"
        Me.Text = "Importar Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstUsuarios As System.Windows.Forms.ListBox
    Friend WithEvents txtRepetir As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
