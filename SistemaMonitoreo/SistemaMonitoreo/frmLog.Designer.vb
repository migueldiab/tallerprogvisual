<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.lblLog = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(281, 13)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(165, 28)
        Me.btnProcesar.TabIndex = 0
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actualizacion de Logs"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(38, 67)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(379, 23)
        Me.Progress.TabIndex = 3
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(35, 40)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(0, 18)
        Me.lblLog.TabIndex = 4
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 140)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLog"
        Me.Text = "Importar Logs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblLog As System.Windows.Forms.Label
End Class
