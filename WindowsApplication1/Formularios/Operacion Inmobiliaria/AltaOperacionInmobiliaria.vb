Public Class AltaOperacionInmobiliaria

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim propiedad As DataTable
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida


    Private Sub AltaOperacionInmobiliaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Carga.setTotalDeEventos(4)

        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoPropiedad, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")

        Conexion.cargarComboTipo(Me.cmb_estado, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Estado Propiedad.")

        Me.cargarComboEscribanos(Me.cmb_escribano)
        Me.Carga.actualizarLoading("Combo Escribanos.")

        Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")
        Me.Carga.actualizarLoading("Combo Tipo Operacion.")

        Me.Funciones.AddButtonColumn(Me.grid_Busqueda, "Seleccionar", "Accion", 4)

    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Me.grid_Busqueda.Rows.Clear()
        '    Me.btn_buscar.Enabled = False


        Dim denominacion As String = Funciones.QuitarTodosLosEspacios(Me.txt_designacion.Text)

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

            btn_buscar.Enabled = False
            Me.cmb_tipoPropiedad.Enabled = False
            Me.txt_designacion.Enabled = False

            Me.lbl_domicilio.Text = Me.grid_Busqueda.Rows(e.RowIndex).Cells(2).Value
            Me.lbl_tipo_propiedad.Text = Me.cmb_tipoPropiedad.SelectedValue

            Me.lbl_superficie.Text = "54.654 Km2"

        End If
    End Sub




    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Me.grid_Busqueda.Rows.Clear()

        Me.btn_aceptar.Enabled = True
        Me.cmb_escribano.Enabled = True
        Me.cmb_estado.Enabled = True
        Me.cmb_tipoOperacion.Enabled = True


        Me.RemoveControl()
        Me.txt_factura.Enabled = True
        Me.txt_fechaFin.Enabled = True
        Me.txt_fechaOperacion.Enabled = True
        Me.txt_venta.Enabled = True
        Me.txt_MontoMensual.Enabled = True
        Me.btn_confirmar.Enabled = False


    End Sub


    Private Sub cargarComboEscribanos(ByRef ComboBox As ComboBox)
        Dim sql As String = "SELECT `Escribanos`.`id` AS `ID`, CONCAT(`Persona`.`Apellido`, ', ', `Persona`.`Nombre`, '(', `Escribanos`.`Matricula` ,')' ) AS `Nombre` FROM `Escribanos` JOIN `Persona` ON `Persona`.`id` = `Escribanos`.`Persona` ;"

        Dim Tabla As DataTable = Me.Conexion.Consulta(sql)

        ComboBox.DataSource = Tabla
        ComboBox.DisplayMember = "Nombre"
        ComboBox.ValueMember = "ID"

    End Sub



    Public Sub RemoveControl()
        ' NOTE: The code below uses the instance of 
        ' the button (NewPanelButton) from the previous example.
        If Me.Controls.Contains(grid_Busqueda) Then
            RemoveHandler grid_Busqueda.CellClick, AddressOf _
            EventoSeleccionarPropiedad
            Me.Controls.Remove(grid_Busqueda)
            grid_Busqueda.Dispose()
        End If
    End Sub

    Public Sub RemoveControl2()
        ' NOTE: The code below uses the instance of 
        ' the button (NewPanelButton) from the previous example.
        If Me.Controls.Contains(Me.GroupBox1) Then
            RemoveHandler grid_Busqueda.CellClick, AddressOf _
            EventoSeleccionarPropiedad
            Me.Controls.Remove(grid_Busqueda)
            grid_Busqueda.Dispose()
        End If
    End Sub




    Private Sub btn_NuevaBusqueda_Click(sender As Object, e As EventArgs) Handles btn_NuevaBusqueda.Click
        MsgBox("Sin Implementar..")
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click


        Conexion._nombre_tabla = "t_pedidos"
        Conexion.conexion_con_transaccion()


        Dim sqlFActura As String = "INSERT INTO `Factura`(`Persona`, `Monto`, `Moneda`, `Concepto`) VALUES ([value-1],[value-2],'','') ;"





        Dim sqlinsert As String = ""

      
        Conexion.insertar(sqlinsert)




        '''''''''' comit

        Conexion.cerrar_con_transaccion()
    End Sub
End Class