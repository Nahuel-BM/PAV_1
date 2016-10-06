Public Class AltaOperacionInmobiliaria

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim propiedad As DataTable
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida


    Private Sub AltaOperacionInmobiliaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Carga.setTotalDeEventos(2)

        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoPropiedad, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")

        Conexion.cargarComboTipo(Me.cmb_estado, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Estado Propiedad.")

        Me.Funciones.AddButtonColumn(Me.grid_Busqueda, "Seleccionar", "Accion", 4)

    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Me.grid_Busqueda.Rows.Clear()
        Me.btn_buscar.Enabled = False


        Dim denominacion As String = Funciones.QuitarTodosLosEspacios(Me.MaskedTextBox1.Text)

        Dim sqlModificada As String = "SELECT  `Inmueble`.`id` AS `idInmueble`, `Propiedad`.`id` AS `idPropiedad`, CONCAT(  `Domicilio`.`Calle` ,  ' ', `Domicilio`.`Numero`, ', ', `Localidad`.`Nombre`, ', ', `Provincia`.`Nombre`) AS  `Domicilio` FROM  `Inmueble` JOIN  `Propiedad` ON  `Propiedad`.`Id_Inmueble` =  `Inmueble`.`id` JOIN  `Domicilio` ON  `Domicilio`.`id` =  `Inmueble`.`Domicilio` JOIN  `Localidad` ON  `Localidad`.`id` = `Domicilio`.`Localidad` JOIN  `Provincia` ON  `Provincia`.`id` = `Localidad`.`Provincia` WHERE  `Inmueble`.`Designacion_Catastral` LIKE  '%" & denominacion & "%' AND  `Propiedad`.`Tipo_Propiedad` = 1 "
        Dim datos As DataTable = Conexion.Consulta(sqlModificada)



        ' MsgBox("Encontrados: " & datos.Rows.Count)


        Try

            Dim recorrido As Integer = 0
            For Each row As DataRow In datos.Rows

                Dim Domicilio As String = row("Domicilio")

                Me.grid_Busqueda.Rows.Add()

                Me.grid_Busqueda.Rows(recorrido).Cells("idPropiedad").Value = row("idPropiedad")
                Me.grid_Busqueda.Rows(recorrido).Cells("idInmueble").Value = row("idInmueble")
                Me.grid_Busqueda.Rows(recorrido).Cells("textDomicilio").Value = Domicilio

                recorrido += 1
            Next










            Try
                '  Dim datosDomicilio As DataTable = Conexion.Consulta("SELECT `Domicilio`.*, `Localidad`.`Nombre` AS `Localidadn`, `Provincia`.`Nombre` AS `Provincian` FROM `Domicilio` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia`=`Provincia`.`id` WHERE `Domicilio`.`id` = " & datosInmueble(0)("Domicilio"))

                '   Me.lbl_domicilio.Text = datosDomicilio(0)("Calle") & " " & datosDomicilio(0)("Numero") & ", " & datosDomicilio(0)("Localidadn") & ", " & datosDomicilio(0)("Provincian") & "."
                '   Me.lbl_tipo_propiedad.Text = Me.cmb_tipoPropiedad.SelectedText



                Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")

                Me.btn_aceptar.Enabled = True

            Catch ex As Exception
                MsgBox("Inmueble no encontrado.")
            End Try





        Catch ex As Exception

        End Try





    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub




    Private Sub EventoSeleccionarPropiedad(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_Busqueda.CellClick

        If e.ColumnIndex = 3 Then
            '   Dim result As Integer = MessageBox.Show("¿Realmente desea quitar al Propietario?", "Alerta", MessageBoxButtons.OKCancel)
            '    If result = DialogResult.OK Then
            'Me.grid_propietarios.Rows.RemoveAt(e.RowIndex)
            'MsgBox("Seleccionada!!")
            Me.lbl_domicilio.Text = Me.grid_Busqueda.Rows(e.RowIndex).Cells(2).Value

            ' MsgBox(Me.grid_Busqueda.Rows(e.RowIndex).Cells(3).Size)

            'End If
        End If
    End Sub



End Class