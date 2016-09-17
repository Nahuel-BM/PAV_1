Imports MySql.Data.MySqlClient

Public Class BajaPropiedad

    Dim Coneccion As New Coneccion
    Dim Funciones As New FuncionesUtiles

    Private Sub BajaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Funciones.AddButtonColumn(Me.grid_grilla, "Eliminar", "Acción", 5)
    End Sub




    Private Sub Buscar_Inmueble_Por_Designacion_Catastral(sender As Object, e As EventArgs) Handles Button1.Click

        Dim TrimString As String = Funciones.QuitarEspacios(Me.MaskedTextBox1.Text)

        Dim sqlConsulta As String = "SELECT  `Domicilio`.`id` AS `ID_DOMICILIO`, `Inmueble`.`id` AS `ID_INMUEBLE` , `Propiedad`.`id` AS `ID_PROPIEDAD`, `Domicilio`.`Calle`, `Domicilio`.`Numero` , `Localidad`.`Nombre` AS `Localidad` , `Provincia`.`Nombre` AS `Provincia`, `Inmueble`.`Designacion_Catastral` FROM  `Propiedad` LEFT JOIN  `Inmueble` ON  `Propiedad`.`Id_Inmueble` =  `Inmueble`.`id` LEFT JOIN `Domicilio` ON `Inmueble`.`Domicilio` = `Domicilio`.`id`  LEFT JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` LEFT JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE  `Inmueble`.`Designacion_Catastral` LIKE  '%" & TrimString & "%' AND `Propiedad`.`borrado`= 0;"


        Dim tabla As New Data.DataTable
        tabla = Coneccion.Consulta(sqlConsulta)

        Me.grid_grilla.Rows.Clear()


        Dim recorrido As Integer = 0
        For recorrido = 0 To tabla.Rows.Count() - 1
            Me.grid_grilla.Rows.Add()
            Me.grid_grilla.Rows(recorrido).Cells("ID_DOMICILIO").Value = tabla.Rows(recorrido)("ID_DOMICILIO")
            Me.grid_grilla.Rows(recorrido).Cells("ID_INMUEBLE").Value = tabla.Rows(recorrido)("ID_INMUEBLE")
            Me.grid_grilla.Rows(recorrido).Cells("ID_PROPIEDAD").Value = tabla.Rows(recorrido)("ID_PROPIEDAD")
            Me.grid_grilla.Rows(recorrido).Cells("Domicilio").Value = tabla.Rows(recorrido)("Calle") & " " & tabla.Rows(recorrido)("Numero") & ", " & tabla.Rows(recorrido)("Localidad") & ", " & tabla.Rows(recorrido)("Provincia") & "."

            Me.grid_grilla.Rows(recorrido).Cells("designacion").Value = tabla.Rows(recorrido)("Designacion_Catastral")
            'designacion

        Next




    End Sub

    Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_grilla.CellClick
        ' elimino la fila
        If e.ColumnIndex = 5 Then
            Dim result As Integer = MessageBox.Show("¿Realmente desea Eliminar la Propiedad?", "Alerta", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then

                'Elimiar Propiedad, Eliminar Referencia en dueños, 
                'Comprobar si es departamento si es depto fijarse si hay otro 
                'que apunte a inmueble.
                '
                Dim Id_Domicilio As Integer = Integer.Parse(Me.grid_grilla.Rows(e.RowIndex).Cells(0).Value.ToString)
                Dim Id_Inmueble As Integer = Integer.Parse(Me.grid_grilla.Rows(e.RowIndex).Cells(1).Value.ToString)
                Dim Id_Propiedad As Integer = Integer.Parse(Me.grid_grilla.Rows(e.RowIndex).Cells(2).Value.ToString)


                Me.BorrarPropiedad(Id_Domicilio, Id_Inmueble, Id_Propiedad)

                Me.grid_grilla.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub


    Private Sub BorrarPropiedad(ByVal ID_DOMICILIO As Integer, ByVal ID_INMUEBLE As Integer, ByVal ID_PROPIEDAD As Integer)

        Dim sqlTotalDeptos As String = "SELECT COUNT(*) AS `TOTAL` FROM `Propiedad` WHERE `Id_Inmueble`= " & ID_INMUEBLE & ";"

        Dim sqlBorrarDuenio As String = "UPDATE `Duenios` SET `borrado` = 1 WHERE `Propiedad` = " & ID_PROPIEDAD & " AND `borrado`= 0 LIMIT 1;"
        Dim sqlBorrarPropiedad As String = "UPDATE `Propiedad` SET `borrado` = 1 WHERE `id` = " & ID_PROPIEDAD & " AND `borrado`= 0 LIMIT 1;"
        Dim sqlBorrarInmueble As String = "UPDATE `Inmueble` SET `borrado` = 1 WHERE `id` = " & ID_INMUEBLE & " AND `borrado`= 0 LIMIT 1;"




    End Sub


End Class