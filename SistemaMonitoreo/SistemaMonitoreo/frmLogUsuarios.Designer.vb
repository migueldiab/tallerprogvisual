<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogUsuarios
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
        Me.btnAbrir = New System.Windows.Forms.Button
        Me.abrirArchivo = New System.Windows.Forms.OpenFileDialog
        Me.txtLogUsuarios = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(298, 13)
        Me.btnAbrir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(127, 32)
        Me.btnAbrir.TabIndex = 1
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'abrirArchivo
        '
        Me.abrirArchivo.FileName = "abrirArchivo"
        '
        'txtLogUsuarios
        '
        Me.txtLogUsuarios.Location = New System.Drawing.Point(12, 52)
        Me.txtLogUsuarios.Multiline = True
        Me.txtLogUsuarios.Name = "txtLogUsuarios"
        Me.txtLogUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLogUsuarios.Size = New System.Drawing.Size(413, 310)
        Me.txtLogUsuarios.TabIndex = 2
        '
        'frmLogUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 374)
        Me.Controls.Add(Me.txtLogUsuarios)
        Me.Controls.Add(Me.btnAbrir)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogUsuarios"
        Me.Text = "Log Importación de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbrir As System.Windows.Forms.Button
    Friend WithEvents abrirArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtLogUsuarios As System.Windows.Forms.TextBox
End Class
