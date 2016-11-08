Public Class Form_propiedades_por_dueño

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim idPersonaLocal As Integer

    Public Sub New(ByVal idPersona As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        idPersonaLocal = idPersona


    End Sub


    Private Sub Form_propiedades_por_dueño_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String = "SELECT * FROM `Propiedad` JOIN `Duenios` ON `Propiedad`.`id` = `Duenios`.`Duenio` WHERE `Duenios`.`Duenio` = " & idPersonaLocal & " AND `Propiedad`.`borrado` = 0 AND `Duenios`.`borrado` = 0;"

        Dim tabla As New DataTable
        tabla = Me.Conexion.Consulta(sql)

        PropiedadBindingSource.DataSource = tabla

        Me.ReportViewer1.RefreshReport()
    End Sub





End Class