Public Class Listado_Proveedores

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim idProvincia As Integer = 0

    Public Sub New(ByVal id As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        idProvincia = id


    End Sub




    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub impresion()
        Dim tabla As New DataTable
        ' Dim sqlConsulta As String = "SELECT * FROM  `Proveedor`"
        Dim sql As String = "SELECT `Proveedor`.`id`,`Proveedor`.`Nombre`,CONCAT(  `Domicilio`.`Calle` ,  ' ', `Domicilio`.`Numero`, ', ', `Localidad`.`Nombre`, ', ', `Provincia`.`Nombre`) AS  `Domicilio` FROM `Proveedor` JOIN `Domicilio` ON `Proveedor`.`Domicilio` = `Domicilio`.`id`  JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE `Provincia`.`id` = " & Me.idProvincia & ";"
        tabla = Conexion.Consulta(sql)
        Me.ProveedorBindingSource.DataSource = tabla
    End Sub

    Private Sub Listado_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class