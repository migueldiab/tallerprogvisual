Imports Dominio

Public Class frmImportarUsuarios
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmImportarUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListaUsuarios(Sistema.listaUsuarios())
    End Sub

    Public Sub cargarListaUsuarios(ByVal listaUsuarios As ArrayList)
        lstUsuarios.Items.Clear()
        Dim nuevoUsuario As New Usuario()
        nuevoUsuario.nombre = "--Nuevo usuario--"
        lstUsuarios.Items.Add(nuevoUsuario)
        For Each unUsuario As Usuario In listaUsuarios
            lstUsuarios.Items.Add(unUsuario)
        Next
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsuarios.SelectedIndexChanged
        If (lstUsuarios.SelectedItems.Count <> 0) Then
            mostrarDatos(CType(lstUsuarios.SelectedItems.Item(0), Usuario))
        Else
            limpiarDatos()
        End If
    End Sub

    Private Sub mostrarDatos(ByVal usuario As Usuario)
        txtNombre.Text = usuario.nombre.ToString
        txtContrasenia.Text = usuario.contrasenia.ToString
        txtRepetir.Text = usuario.contrasenia.ToString
        txtID.Text = usuario.id.ToString
        If usuario.id <> "" Then
            txtNombre.Enabled = False
        Else
            txtNombre.Enabled = True
        End If
        txtNombre.Focus()
    End Sub
    Public Sub limpiarDatos()
        txtNombre.Text = ""
        txtContrasenia.Text = ""
        txtRepetir.Text = ""
        txtID.Text = ""
        txtNombre.Enabled = True
    End Sub



    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Comma Separated Values (*.csv)|*.csv|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Using archivoImportar As New Microsoft.VisualBasic.FileIO.TextFieldParser(openFileDialog1.OpenFile())
                archivoImportar.TextFieldType = FileIO.FieldType.Delimited
                archivoImportar.SetDelimiters(",")
                Dim fila As String()
                While Not archivoImportar.EndOfData
                    Try
                        fila = archivoImportar.ReadFields()
                        If (fila.Length = Sistema.REGISTOS_IMPORTAR_CSV) Then
                            Dim uUsuario As New Usuario(txtID.Text.ToString)
                            If fila.GetValue(0).ToString.Length >= Sistema.LARGO_MIN_USUARIO And fila.GetValue(1).ToString.Length > 4 And fila.GetValue(2).ToString.Length > Sistema.LARGO_MIN_PASSWORD Then
                                txtNombre.Text = fila.GetValue(0).ToString
                                txtContrasenia.Text = fila.GetValue(1).ToString
                                txtRepetir.Text = fila.GetValue(1).ToString
                                uUsuario.contrasenia = txtContrasenia.Text
                                uUsuario.nombre = txtNombre.Text
                                uUsuario.guardar()

                            Else
                                'Nombres cortos
                            End If
                        Else
                            'no hay 3 campos
                        End If
                    Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                        Debug.Write("Linea " & ex.Message & " no es válida.")
                    End Try
                End While
                cargarListaUsuarios(Sistema.listaUsuarios())
            End Using

        End If


    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class