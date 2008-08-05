<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbmUsuario
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
        Me.lstEmpleados = New System.Windows.Forms.ListBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtFiltroEmpleados = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtEliminar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstEmpleados
        '
        Me.lstEmpleados.FormattingEnabled = True
        Me.lstEmpleados.ItemHeight = 18
        Me.lstEmpleados.Location = New System.Drawing.Point(12, 45)
        Me.lstEmpleados.Name = "lstEmpleados"
        Me.lstEmpleados.Size = New System.Drawing.Size(205, 274)
        Me.lstEmpleados.TabIndex = 20
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(356, 76)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(204, 26)
        Me.txtTelefono.TabIndex = 24
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(356, 42)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(204, 26)
        Me.txtNombre.TabIndex = 22
        '
        'txtFiltroEmpleados
        '
        Me.txtFiltroEmpleados.Location = New System.Drawing.Point(66, 10)
        Me.txtFiltroEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFiltroEmpleados.Name = "txtFiltroEmpleados"
        Me.txtFiltroEmpleados.Size = New System.Drawing.Size(150, 26)
        Me.txtFiltroEmpleados.TabIndex = 14
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(356, 8)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(103, 26)
        Me.txtID.TabIndex = 21
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(239, 79)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(94, 18)
        Me.lblTelefono.TabIndex = 17
        Me.lblTelefono.Text = "Contraseña"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(498, 287)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(112, 32)
        Me.btnCerrar.TabIndex = 31
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'txtEliminar
        '
        Me.txtEliminar.Location = New System.Drawing.Point(378, 287)
        Me.txtEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEliminar.Name = "txtEliminar"
        Me.txtEliminar.Size = New System.Drawing.Size(112, 32)
        Me.txtEliminar.TabIndex = 30
        Me.txtEliminar.Text = "Eliminar"
        Me.txtEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(258, 287)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 32)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(239, 45)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 18)
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Filtro"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(239, 11)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(24, 18)
        Me.lblID.TabIndex = 16
        Me.lblID.Text = "ID"
        '
        'frmAbmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 333)
        Me.Controls.Add(Me.lstEmpleados)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtFiltroEmpleados)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAbmUsuario"
        Me.Text = "frmAbmUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstEmpleados As System.Windows.Forms.ListBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroEmpleados As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class
