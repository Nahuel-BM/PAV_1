Public Class Listado_OperacionesInmobiliarias
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Listado_OperacionesInmobiliarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresion()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Operacion_Inmobiliaria`.`id`,CONCAT( `Tipo_Propiedad`.`Nombre`) AS `Propiedad`,CONCAT(`Tipo_Operacion`.`Nombre`) AS `Tipo_Operacion` , CONCAT(  `Persona`.`Nombre` ,',', `Persona`.`Apellido`) AS `Persona_Interviniente`, `Operacion_Inmobiliaria`.`Fecha_Operacion`, `Operacion_Inmobiliaria`.`Duracion`, `Operacion_Inmobiliaria`.`Monto_Mensual`, `Operacion_Inmobiliaria`.`Factura`, `Operacion_Inmobiliaria`.`Comision_Venta`,CONCAT(`Escribanos`.`Persona`) AS `Escribano` FROM `Operacion_Inmobiliaria` INNER JOIN `Propiedad` ON `Operacion_Inmobiliaria`.`Propiedad` = `Propiedad`.`id`  INNER JOIN `Tipo_Propiedad` ON `Tipo_Propiedad`.`id` = `Propiedad`.`Tipo_Propiedad` INNER JOIN `Escribanos` ON `Operacion_Inmobiliaria`.`Escribano` = `Escribanos`.`id` INNER JOIN `Persona` ON `Operacion_Inmobiliaria`.`Persona_Interviniente` = `Persona`.`id`  INNER JOIN `Tipo_Operacion` ON `Operacion_Inmobiliaria`.`Tipo_Operacion` = `Tipo_Operacion`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.OperacionInmobiliariaBindingSource.DataSource = tabla
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class