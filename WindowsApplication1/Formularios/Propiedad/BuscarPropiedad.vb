Public Class BuscarPropiedad

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    Dim Edicion As Boolean = False



    Sub New(ByVal edicion As Boolean)
        InitializeComponent() 'es necesario que lleve esta linea
        Me.Edicion = edicion
    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub BuscarPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_tipoPropiedad, "Tipo_Propiedad")
        If Edicion Then
            Funciones.AddButtonColumn(Me.grid_resultadosBusqueda, "Editar", "Accion", 5)
        Else
            Funciones.AddButtonColumn(Me.grid_resultadosBusqueda, "Borrar", "Accion", 5)
        End If

    End Sub


    Private Sub Buscar_Inmueble_Por_Designacion_Catastral(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Dim DenominacionCatastral As String = Funciones.QuitarEspacios(Me.txt_denominacionCatastral.Text)

        Dim sqlConsulta As String = "SELECT  `Domicilio`.`id` AS `ID_DOMICILIO`, `Inmueble`.`id` AS `ID_INMUEBLE` , `Propiedad`.`id` AS `ID_PROPIEDAD`, `Domicilio`.`Calle`, `Domicilio`.`Numero` , `Localidad`.`Nombre` AS `Localidad` , `Provincia`.`Nombre` AS `Provincia`, `Inmueble`.`Designacion_Catastral` FROM  `Propiedad` LEFT JOIN  `Inmueble` ON  `Propiedad`.`Id_Inmueble` =  `Inmueble`.`id` LEFT JOIN `Domicilio` ON `Inmueble`.`Domicilio` = `Domicilio`.`id`  LEFT JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` LEFT JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE  `Inmueble`.`Designacion_Catastral` LIKE  '%" & DenominacionCatastral & "%' AND `Propiedad`.`borrado`= 0 AND `Propiedad`.`Tipo_Propiedad` = " & Me.cmb_tipoPropiedad.SelectedValue & ";"


        Dim tabla As New Data.DataTable
        tabla = Conexion.Consulta(sqlConsulta)

        Me.grid_resultadosBusqueda.Rows.Clear()


        Dim recorrido As Integer = 0
        For recorrido = 0 To tabla.Rows.Count() - 1
            Me.grid_resultadosBusqueda.Rows.Add()
            Me.grid_resultadosBusqueda.Rows(recorrido).Cells("ID_DOMICILIO").Value = tabla.Rows(recorrido)("ID_DOMICILIO")
            Me.grid_resultadosBusqueda.Rows(recorrido).Cells("ID_INMUEBLE").Value = tabla.Rows(recorrido)("ID_INMUEBLE")
            Me.grid_resultadosBusqueda.Rows(recorrido).Cells("ID_PROPIEDAD").Value = tabla.Rows(recorrido)("ID_PROPIEDAD")
            Me.grid_resultadosBusqueda.Rows(recorrido).Cells("Domicilio").Value = tabla.Rows(recorrido)("Calle") & " " & tabla.Rows(recorrido)("Numero") & ", " & tabla.Rows(recorrido)("Localidad") & ", " & tabla.Rows(recorrido)("Provincia") & "."

            Me.grid_resultadosBusqueda.Rows(recorrido).Cells("designacion").Value = tabla.Rows(recorrido)("Designacion_Catastral")
            'designacion

        Next
    End Sub


    Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_resultadosBusqueda.CellClick
        ' elimino la fila
        If e.ColumnIndex = 5 Then
            Dim result As Integer = 0
            If Edicion Then
                result = MessageBox.Show("¿Realmente desea Editar la Propiedad?", "Alerta", MessageBoxButtons.OKCancel)
            Else
                result = MessageBox.Show("¿Realmente desea Eliminar la Propiedad?", "Alerta", MessageBoxButtons.OKCancel)
            End If

            If result = DialogResult.OK Then

                'Elimiar Propiedad, Eliminar Referencia en dueños, 
                'Comprobar si es departamento si es depto fijarse si hay otro 
                'que apunte a inmueble.
                '
                Dim Id_Domicilio As Integer = Integer.Parse(Me.grid_resultadosBusqueda.Rows(e.RowIndex).Cells(0).Value.ToString)
                Dim Id_Inmueble As Integer = Integer.Parse(Me.grid_resultadosBusqueda.Rows(e.RowIndex).Cells(1).Value.ToString)
                Dim Id_Propiedad As Integer = Integer.Parse(Me.grid_resultadosBusqueda.Rows(e.RowIndex).Cells(2).Value.ToString)

                If Edicion Then
                    Dim frm As New AltaPropiedad(Id_Domicilio, Id_Inmueble, Id_Propiedad)
                    'Dim frm As New AltaPropiedad()
                    frm.Show()
                    Me.Close()
                Else
                    Me.BorrarPropiedad(Id_Domicilio, Id_Inmueble, Id_Propiedad)
                    Me.grid_resultadosBusqueda.Rows.RemoveAt(e.RowIndex)
                End If


            End If
        End If
    End Sub

    Private Sub BorrarPropiedad(ByVal ID_DOMICILIO As Integer, ByVal ID_INMUEBLE As Integer, ByVal ID_PROPIEDAD As Integer)

        Dim sqlTotalDeptos As String = "SELECT COUNT(*) AS `TOTAL` FROM `Propiedad` WHERE `Id_Inmueble`= " & ID_INMUEBLE & ";"

        Dim sqlBorrarDuenio As String = "UPDATE `Duenios` SET `borrado` = 1 WHERE `Propiedad` = " & ID_PROPIEDAD & " AND `borrado`= 0;"
        Dim sqlBorrarPropiedad As String = "UPDATE `Propiedad` SET `borrado` = 1 WHERE `id` = " & ID_PROPIEDAD & " AND `borrado`= 0 LIMIT 1;"
        Dim sqlBorrarInmueble As String = "UPDATE `Inmueble` SET `borrado` = 1 WHERE `id` = " & ID_INMUEBLE & " AND `borrado`= 0 LIMIT 1;"


        Dim totalDeptos As Integer = Integer.Parse((Conexion.Consulta(sqlTotalDeptos))(0)("TOTAL"))


        Conexion.Consulta(sqlBorrarDuenio)
        Conexion.Consulta(sqlBorrarPropiedad)

        If totalDeptos = 1 Then
            Conexion.Consulta(sqlBorrarInmueble)
        End If



    End Sub

End Class