Public Class Listado_Dueños
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Listado_Dueños_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        Dim tabla As New DataTable
        ' Dim sqlConsulta As String = "SELECT * FROM  `Proveedor`"
        Dim sql As String = "SELECT `Duenios`.`id`,CONCAT( `Tipo_Propiedad`.`Nombre`) AS  `Propiedad`, CONCAT(  `Persona`.`Nombre` ,',', `Persona`.`Apellido`) AS `Duenio`  FROM `Duenios` LEFT JOIN `Propiedad` ON `Duenios`.`Propiedad` = `Propiedad`.`id`  LEFT JOIN `Tipo_Propiedad` ON `Tipo_Propiedad`.`id` = `Propiedad`.`Tipo_Propiedad` LEFT JOIN `Persona` ON `Duenios`.`Duenio` = `Persona`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.DueniosDataTableBindingSource.DataSource = tabla
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class