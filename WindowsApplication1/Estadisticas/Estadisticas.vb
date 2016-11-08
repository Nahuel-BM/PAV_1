Public Class Estadisticas
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.impresionPropiedadxSuperficie()
        Me.impresionPropiedadxMonto()
        Me.impresionOpInmobiliariaxMontoMensual()
        Me.impresionOpInmobiliariaxComision()
        Me.impresionOpInmobiliariaxduracion()
        Me.impresionGastosxImporte()
        Me.impresionFacturaxMonto()

    End Sub
    Private Sub impresionPropiedadxSuperficie()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Propiedad`.`id` AS ID ,SUM(`Superficie`) AS TOTAL FROM `Propiedad` GROUP BY `Propiedad`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresionPropiedadxMonto()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Propiedad`.`id` AS ID ,SUM(`Monto`) AS TOTAL FROM `Propiedad` GROUP BY `Propiedad`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub impresionOpInmobiliariaxMontoMensual()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Operacion_Inmobiliaria`.`id` AS ID ,SUM(`Monto_Mensual`) AS TOTAL FROM `Operacion_Inmobiliaria` GROUP BY `Operacion_Inmobiliaria`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer3.RefreshReport()
    End Sub

    Private Sub impresionOpInmobiliariaxComision()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Operacion_Inmobiliaria`.`id` AS ID ,SUM(`Comision_Venta`) AS TOTAL FROM `Operacion_Inmobiliaria` GROUP BY `Operacion_Inmobiliaria`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer4.RefreshReport()
    End Sub

    Private Sub impresionOpInmobiliariaxduracion()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Operacion_Inmobiliaria`.`id` AS ID ,SUM(`Duracion`) AS TOTAL FROM `Operacion_Inmobiliaria` GROUP BY `Operacion_Inmobiliaria`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer5.RefreshReport()
    End Sub
  
    Private Sub impresionGastosxImporte()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Gastos`.`id` AS ID ,SUM(`Importe`) AS TOTAL FROM `Gastos` GROUP BY `Gastos`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer6.RefreshReport()
    End Sub
    
    Private Sub impresionFacturaxMonto()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT `Factura`.`id` AS ID ,SUM(`Monto`) AS TOTAL FROM `Factura` GROUP BY `Factura`.`id`"
        tabla = Conexion.Consulta(sql)
        Me.EstadisticasBindingSource.DataSource = tabla
        Me.ReportViewer7.RefreshReport()
    End Sub
   
    
End Class