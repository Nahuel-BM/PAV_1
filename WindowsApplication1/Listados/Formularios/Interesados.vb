﻿Public Class Interesados
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Private Sub Interesados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub impresion()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT CONCAT(  `Persona`.`Apellido` ,  ', ',  `Persona`.`Nombre` ) AS  `interesados` , CONCAT(  `Propiedad`.`Monto` ,  ' ', `Propiedad`.`Moneda` ) AS  `propiedad` ,  `p`.`id` FROM  `Interesados` AS  `p` INNER JOIN  `Persona` ON  `Persona`.`id` =  `p`.`Interesado`  INNER JOIN  `Propiedad` ON  `Propiedad`.`id` =  `p`.`Propiedad` JOIN  `Inmueble` ON  `Propiedad`.`id_Inmueble` =  `Inmueble`.`id` WHERE  `Inmueble`.`Designacion_Catastral` =  '" & MaskedTextBox1.Text & "'; "

        ' MsgBox(sql)

        tabla = Conexion.Consulta(sql)
        InteresadosBindingSource.DataSource = tabla
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MaskedTextBox1.Text = "" Then
            Me.ReportViewer1.RefreshReport()
        Else
            impresion()
        End If
    End Sub
End Class