Public Class Listado_Dueños
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Listado_Dueños_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Duenios`.`id`, `Tipo_Propiedad`.`Nombre` AS  `Propiedad`, CONCAT(  `Persona`.`Nombre` ,',', `Persona`.`Apellido`) AS `Duenio`  FROM `Duenios` JOIN `Propiedad` ON `Duenios`.`Propiedad` = `Propiedad`.`id` JOIN `Tipo_Propiedad` ON `Tipo_Propiedad`.`id` = `Propiedad`.`Tipo_Propiedad` JOIN `Persona` ON `Duenios`.`Duenio` = `Persona`.`id` WHERE `Duenios`.`borrado` = 0 AND `Propiedad`.`borrado` = 0;"
        tabla = Conexion.Consulta(sql)
        Me.DueniosDataTableBindingSource.DataSource = tabla
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class