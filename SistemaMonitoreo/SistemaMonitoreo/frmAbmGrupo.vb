Public Class frmAbmGrupo
    Public Sub New(ByVal ventanaPadre As Form)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MdiParent = ventanaPadre
    End Sub

    Private Sub frmAbmGrupo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarListaGrupos(Sistema.listaGrupos())
    End Sub

    Public Sub cargarListaGrupos(ByVal listaGrupos As ArrayList)
        lstGrupos.Items.Clear()
        Dim nuevoGrupo As New Grupo()
        nuevoGrupo.nombre = "--Nuevo empleado--"
        lstGrupos.Items.Add(nuevoGrupo)
        For Each unGrupo As Grupo In listaGrupos
            lstGrupos.Items.Add(unGrupo)
        Next
    End Sub
End Class