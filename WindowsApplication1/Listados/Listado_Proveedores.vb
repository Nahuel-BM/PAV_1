Public Class Listado_Proveedores
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub impresion()
        Dim tabla As New DataTable
        ' Dim sqlConsulta As String = "SELECT * FROM  `Proveedor`"
        Dim sql As String = "SELECT `Proveedor`.`id`,`Proveedor`.`Nombre`,CONCAT(  `Domicilio`.`Calle` ,  ' ', `Domicilio`.`Numero`, ', ', `Localidad`.`Nombre`, ', ', `Provincia`.`Nombre`) AS  `Domicilio` FROM `Proveedor` LEFT JOIN `Domicilio` ON `Proveedor`.`Domicilio` = `Domicilio`.`id`  LEFT JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` LEFT JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.ProveedorBindingSource.DataSource = tabla





    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class