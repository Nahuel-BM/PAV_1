'Importo libreria de Hilos..
Imports System.Threading

Public Class AltaPropiedad

    Dim idTipoPropiedad As Integer = 0
    Dim encontrado As Boolean = False
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    'Parametros de carga,identifican que es una edicion..
    Dim Id_Domicilio_parametro As Integer = 0
    Dim Id_Inmueble_parametro As Integer = 0
    Dim Id_Propiedad_parametro As Integer = 0
    Dim Edicion As Boolean = False
    Dim tablaDatos As DataTable
    'Fin parametros de carga.

    'Variables de pantalla de carga
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida


    Enum monedas
        peso
        dolar
        euro
    End Enum





    Sub New(ByVal id_domicilio As Integer, ByVal id_inmueble As Integer, ByVal id_propiedad As Integer)

        InitializeComponent() 'es necesario que lleve esta linea

        Me.Id_Domicilio_parametro = id_domicilio
        Me.Id_Inmueble_parametro = id_inmueble
        Me.Id_Propiedad_parametro = id_propiedad

        Edicion = True

        Me.btn_crearPropiedad.Text = "Editar Propiedad"
        Me.Text = "Edicion de Propiedad"

    End Sub

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByVal datos As DataTable)
        InitializeComponent()
        Me.tablaDatos = datos
        Me.Edicion = True
    End Sub


    Private Sub AltaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CargarDatosDeCombos()

    End Sub

    Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_propietarios.CellClick
        ' elimino la fila
        If e.ColumnIndex = 4 Then
            Dim result As Integer = MessageBox.Show("¿Realmente desea quitar al Propietario?", "Alerta", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.grid_propietarios.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub GuardarEnBaseDeDatos()
        Try
            If Me.validar() = True Then

                Me.idTipoPropiedad = Me.cmb_tipo_propiedad.SelectedValue()

                Dim alturaCalle As Integer = Integer.Parse(Funciones.QuitarEspacios(Me.txt_numeroCalle.Text))
                Dim sqlDomicilio As String = "INSERT INTO `Domicilio`(`Calle`, `Numero`, `Localidad`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_calle.Text) & "', " & alturaCalle & "," & Me.cmb_localidad.SelectedValue & ");"

                'Ejecutar consulta "sqlDomicilio"

                Conexion.ejecutarInsert(sqlDomicilio)

                Dim idDomicilio As Integer = Conexion.ultimoIdInsertado()
                Dim sqlInmueble As String

                If Me.idTipoPropiedad = 1 Then
                    'Si es un edificio..
                    sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`, `Encargado`, `Cantidad_Departamentos`, `Superficie`, `Ascensor`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & "," & cmb_encargado.SelectedValue & "," & Integer.Parse(Funciones.QuitarEspacios(Me.txt_total_departamento.Text)) & "," & Double.Parse(Funciones.QuitarEspacios(Me.txt_superficie.Text)) & "," & chk_ascensor.CheckState & ")"
                Else
                    sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & ");"
                End If

                'Ejecutar consulta "sqlInmueble"

                Conexion.ejecutarInsert(sqlInmueble)

                Dim idInmueble As Integer = Conexion.ultimoIdInsertado()
                Dim moneda As String = ""

                If Me.cmb_moneda.SelectedValue = 0 Then
                    moneda = "Peso"
                End If
                If Me.cmb_moneda.SelectedValue = 1 Then
                    moneda = "Dolar"
                End If
                If Me.cmb_moneda.SelectedValue = 2 Then
                    moneda = "Euro"
                End If



                Dim sqlPropiedad As String = ""


                'Si es departameto
                If idTipoPropiedad = 1 Then
                    sqlPropiedad = "INSERT INTO `Propiedad`(`Id_Inmueble`, `Piso`, `Denominacion`, `Tipo_Propiedad`, `Superficie`, `Monto`, `Moneda`) VALUES (" _
                                            & idInmueble & ", " & Funciones.QuitarTodosLosEspacios(Me.txt_piso.Text) & ", '" & Funciones.QuitarTodosLosEspacios(Me.txt_denominacion_departamento.Text) & "', " & Me.cmb_tipo_propiedad.SelectedValue & ", " _
                                            & Funciones.QuitarTodosLosEspacios(Me.txt_superficie.Text.Replace(",", ".")) & ", " _
                                            & Funciones.QuitarTodosLosEspacios(Me.txt_monto.Text.Replace(",", ".")) & ", '" _
                                            & moneda & "');"

                Else
                    sqlPropiedad = "INSERT INTO `Propiedad`(`Id_Inmueble`, `Tipo_Propiedad`, `Superficie`, `Monto`, `Moneda`) VALUES (" _
                                            & idInmueble & ", " & Me.cmb_tipo_propiedad.SelectedValue & ", " _
                                            & Funciones.QuitarTodosLosEspacios(Me.txt_superficie.Text.Replace(",", ".")) & ", " _
                                            & Funciones.QuitarTodosLosEspacios(Me.txt_monto.Text.Replace(",", ".")) & ", '" _
                                            & moneda & "');"

                End If

                Conexion.ejecutarInsert(sqlPropiedad)

                Dim idPropiedad As Integer = Conexion.ultimoIdInsertado()

                'por cada dueño una consulta..

                Dim Codigo As String
                For Each row As DataGridViewRow In Me.grid_propietarios.Rows
                    'obtenemos el valor de la columna en la variable declarada
                    Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer

                    Dim sqlDuenio As String = "INSERT INTO `Duenios`(`Propiedad`, `Duenio`) VALUES (" & idPropiedad & ", " & Codigo & ");"
                    Conexion.ejecutarInsert(sqlDuenio)
                Next

                MsgBox("¡Propiedad creada con exito!")




            End If

        Catch e As Exception
            MsgBox("Error al Guardar Datos")

        End Try

    End Sub


    Private Sub AgregarEnListaDePropietarios(ByVal sender As System.Object, e As EventArgs) Handles btn_add.Click

        If Me.encontrado Then

            Dim fila As DataGridViewRow = Me.grid_Busqueda.CurrentRow
            Me.grid_Busqueda.Rows.Clear()
            Me.txt_numeroBusquedaDocumento.Text = ""
            Me.btn_add.Enabled = False

            If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
                Me.grid_propietarios.Rows.Add(fila)
            Else

                For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows
                    If Not dgitem.Cells(0).Value.Equals(fila.Cells(0).Value) Then
                        Me.grid_propietarios.Rows.Add(fila)
                    Else
                        'MsgBox("La Persona ya es Propietaria del inmueble.")
                    End If
                Next

            End If

        End If

    End Sub

    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"


        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)

    End Sub

    Private Sub cambiarTipoInmuebleSeleccionado(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_tipo_propiedad.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)

        idTipoPropiedad = senderComboBox.SelectedValue

        If idTipoPropiedad = 1 Then
            Me.cmb_encargado.Enabled = True
            Me.txt_denominacion_departamento.Enabled = True
            Me.txt_piso.Enabled = True
            Me.txt_total_departamento.Enabled = True
            Me.chk_ascensor.Enabled = True
        Else
            Me.cmb_encargado.Enabled = False
            Me.txt_denominacion_departamento.Enabled = False
            Me.txt_piso.Enabled = False
            Me.txt_total_departamento.Enabled = False
            Me.chk_ascensor.Enabled = False

        End If


    End Sub






    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim idTipoDoc As Integer = Me.cmb_tipoDocumento.SelectedValue

            Dim Sql As String = " SELECT `Tipo_Documento`.`Nombre` AS `Tipo_Documento`, `Persona`.`Nombre`, `Persona`.`Apellido`, `Persona`.`id`, `Persona`.`Documento` FROM Persona LEFT JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE Documento LIKE '%" & Me.txt_numeroBusquedaDocumento.Text & "%' AND Tipo_Documento = " & idTipoDoc & ";"
            Dim tabla As New Data.DataTable

            tabla = Conexion.Consulta(Sql)

            Me.grid_Busqueda.Rows.Clear()


            Dim recorrido As Integer = 0
            For recorrido = 0 To tabla.Rows.Count() - 1
                Me.grid_Busqueda.Rows.Add()
                Me.grid_Busqueda.Rows(recorrido).Cells("id_Buscados").Value = tabla.Rows(recorrido)("id")
                Me.grid_Busqueda.Rows(recorrido).Cells("nombre_encontrados").Value = tabla.Rows(recorrido)("Nombre") & ", " & tabla.Rows(recorrido)("Apellido")
                Me.grid_Busqueda.Rows(recorrido).Cells("num_documento").Value = tabla.Rows(recorrido)("Documento")
                Me.grid_Busqueda.Rows(recorrido).Cells("tipo_documento").Value = tabla.Rows(recorrido)("Tipo_Documento")
            Next


            If tabla.Rows.Count() >= 1 Then
                Me.encontrado = True
            Else
                Me.encontrado = False
            End If


            Me.btn_add.Enabled = Me.encontrado



        Catch ex As Exception
            MsgBox("Error " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub




    Private Function validar() As Boolean
        If Me.txt_calle.Text = "" Then
            MessageBox.Show("La calle esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_calle.Focus()
            Return False
        End If

        If Me.txt_numeroCalle.Text = "" Then
            MessageBox.Show("El número de calle esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_numeroCalle.Focus()
            Return False
        End If

        If Me.txt_superficie.Text = "" Then
            MessageBox.Show("La superficie esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_superficie.Focus()
            Return False
        End If

        If Me.txt_monto.Text = "" Then
            MessageBox.Show("El monto de venta esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_monto.Focus()
            Return False
        End If

        If Me.txt_denominacion_catastral.Text = "" Then
            MessageBox.Show("La denominacion catastral esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_denominacion_catastral.Focus()
            Return False
        End If


        If Me.idTipoPropiedad = 1 Then

            If Me.txt_piso.Text = "" Then
                MessageBox.Show("El piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_piso.Focus()
                Return False
            End If

            If Me.txt_denominacion_departamento.Text = "" Then
                MessageBox.Show("La denominacion del piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_denominacion_catastral.Focus()
                Return False
            End If

            If Me.txt_total_departamento.Text = "" Then
                MessageBox.Show("El total de los departamentos esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_denominacion_catastral.Focus()
                Return False
            End If

        End If

        'Separador de ratón..

        If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
            MessageBox.Show("La propiedad debe tener al menos un propietario. Busque uno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_numeroBusquedaDocumento.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub btn_crearPropiedad_Click(sender As Object, e As EventArgs) Handles btn_crearPropiedad.Click
        If Edicion Then
            'Actualizar campos
            Me.ActualizarDatos()
        Else
            Me.GuardarEnBaseDeDatos()
        End If

    End Sub

    Private Sub cargarMonedas(ByRef cmbmoneda)
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("id")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("id") = "0"
        dr("Descripcion") = "Peso"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("Descripcion") = "Dolar"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "2"
        dr("Descripcion") = "Euro"
        dt.Rows.Add(dr)

        cmbmoneda.DataSource = dt
        cmbmoneda.ValueMember = "id"
        cmbmoneda.DisplayMember = "Descripcion"

    End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub CargarDatosDeEdicion()
        'Datos Domicilio
        Dim datosDomicilio As DataTable = Conexion.Consulta("SELECT `Domicilio`.* , `Localidad`.`Nombre` AS `LocalidadN`, `Provincia`.`Nombre` AS `ProvinciaN` FROM `Domicilio` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE `Domicilio`.`id` = " & Me.Id_Domicilio_parametro & ";")
        Me.cmb_provincia.SelectedIndex = Me.cmb_provincia.FindStringExact(datosDomicilio(0)("LocalidadN"))
        Me.cmb_provincia.SelectedIndex = Me.cmb_provincia.FindStringExact(datosDomicilio(0)("ProvinciaN"))


        Me.txt_calle.Text = datosDomicilio(0)("Calle")



        Me.txt_numeroCalle.Text = datosDomicilio(0)("Numero")
        'Datos Propiedad

        Dim datosPropiedad As DataTable = Conexion.Consulta("SELECT `Propiedad`.`Piso`, `Propiedad`.`Moneda`, `Propiedad`.`Denominacion`,`Propiedad`.`Superficie`, `Propiedad`.`Monto`, `Tipo_Propiedad`.`Nombre` FROM `Propiedad` JOIN `Tipo_Propiedad` ON `Propiedad`.`Tipo_Propiedad` = `Tipo_Propiedad`.`id` WHERE `Propiedad`.`id`= " & Me.Id_Propiedad_parametro)

        Me.txt_piso.Text = "" & datosPropiedad(0)("Piso")
        Me.txt_denominacion_departamento.Text = Convert.ToString(datosPropiedad(0)("Denominacion"))

        ' Me.txt_superficie.RightToLeft = Windows.Forms.RightToLeft.Yes
        Me.txt_superficie.Text = Funciones.RellenarConEspacios(datosPropiedad(0)("Superficie"))

        Me.txt_monto.Text = Funciones.RellenarConEspacios(datosPropiedad(0)("Monto"))

        Me.cmb_tipo_propiedad.SelectedIndex = Me.cmb_tipo_propiedad.FindStringExact(datosPropiedad(0)("Nombre"))

        Me.cmb_moneda.SelectedIndex = Me.cmb_moneda.FindStringExact(datosPropiedad(0)("Moneda"))
        'Datos Inmueble

        Dim datosInmueble As DataTable
        If datosPropiedad(0)("Nombre") = "DEPARTAMENTO" Then
            datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor`, `Persona`.`Nombre` AS `Encargado`, `Persona`.`Apellido` AS `Encargado_Apellido` FROM `Inmueble` JOIN `Persona` ON `Inmueble`.`Encargado` = `Persona`.`id` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)

            Me.txt_total_departamento.Text = datosInmueble(0)("Cantidad_Departamentos")
            'encargado

            Me.cmb_encargado.SelectedIndex = Me.cmb_moneda.FindStringExact(datosInmueble(0)("Encargado"))

            'ascensor
            If datosInmueble(0)("Ascensor") = 1 Then
                Me.chk_ascensor.CheckState = CheckState.Checked
            End If



            Me.cmb_encargado.Enabled = True
            Me.txt_denominacion_departamento.Enabled = True
            Me.txt_piso.Enabled = True
            Me.txt_total_departamento.Enabled = True
            Me.chk_ascensor.Enabled = True

        Else

            Me.cmb_encargado.Enabled = False
            Me.txt_denominacion_departamento.Enabled = False
            Me.txt_piso.Enabled = False
            Me.txt_total_departamento.Enabled = False
            Me.chk_ascensor.Enabled = False


            datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor` FROM `Inmueble` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)
        End If
        'datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor`, `Persona`.`Nombre` AS `Encargado`, `Persona`.`Apellido` AS `Encargado_Apellido` FROM `Inmueble` JOIN `Persona` ON `Inmueble`.`Encargado` = `Persona`.`id` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)

        Me.txt_denominacion_catastral.Text = datosInmueble(0)("Designacion_Catastral")

        Dim duenios As DataTable = Conexion.Consulta("SELECT `Persona`.`id`, `Persona`.`Nombre`, `Persona`.`Apellido`, `Persona`.`Documento`, `Tipo_Documento`.`Nombre` AS `Tipo_Documento` FROM `Duenios` JOIN `Persona` ON `Duenios`.`Duenio`=`Persona`.`id` JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE `Duenios`.`Propiedad` = " & Id_Propiedad_parametro & " AND `Duenios`.`borrado` = 0;")


        Me.grid_propietarios.Rows.Clear()

        Dim recorrido As Integer = 0
        For recorrido = 0 To duenios.Rows.Count() - 1
            Me.grid_propietarios.Rows.Add()
            Me.grid_propietarios.Rows(recorrido).Cells("id").Value = duenios.Rows(recorrido)("id")
            Me.grid_propietarios.Rows(recorrido).Cells("nombre").Value = duenios.Rows(recorrido)("Nombre") & ", " & duenios.Rows(recorrido)("Apellido")
            Me.grid_propietarios.Rows(recorrido).Cells("numeroDocumento").Value = duenios.Rows(recorrido)("Documento")
            Me.grid_propietarios.Rows(recorrido).Cells("tipoDocumento").Value = duenios.Rows(recorrido)("Tipo_Documento")
        Next


    End Sub


    Private Sub ActualizarDatos()

        If Me.validar() = True Then




            Dim alturaCalle As Integer = Integer.Parse(Funciones.QuitarEspacios(Me.txt_numeroCalle.Text))
            Dim calle As String = Funciones.QuitarEspacios(Me.txt_calle.Text)
            Dim localidad As Integer = Me.cmb_localidad.SelectedValue

            Conexion.ActualizarDomicilio(Id_Domicilio_parametro, calle, alturaCalle, localidad)

            Dim denominacionCatastral As String = Funciones.QuitarEspacios(Me.txt_denominacion_catastral.Text)



            ' If Me.idTipoPropiedad = 1 Then
            'Si es un edificio..

            Dim encargado As Integer = cmb_encargado.SelectedValue
            Dim totaldepto As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios("0" & Me.txt_total_departamento.Text))
            Dim Superficie As Double = Double.Parse(Funciones.QuitarEspacios(Me.txt_superficie.Text))
            Dim Ascensor As Boolean = chk_ascensor.CheckState

            Conexion.ActualizarInmueble(Id_Inmueble_parametro, denominacionCatastral, Id_Domicilio_parametro, encargado, totaldepto, Ascensor)

            Dim moneda As String = ""

            If Me.cmb_moneda.SelectedValue = 0 Then
                moneda = "Peso"
            End If
            If Me.cmb_moneda.SelectedValue = 1 Then
                moneda = "Dolar"
            End If
            If Me.cmb_moneda.SelectedValue = 2 Then
                moneda = "Euro"
            End If

            Dim piso As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios("0" & Me.txt_piso.Text))
            Dim denominacion As String = Funciones.QuitarTodosLosEspacios(Me.txt_denominacion_departamento.Text)
            Dim tipoPropiedad As Integer = Me.cmb_tipo_propiedad.SelectedValue
            Dim sup As Double = Double.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_superficie.Text.Replace(",", ".")))
            Dim monto As Double = Double.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_monto.Text.Replace(",", ".")))

            Conexion.ActualizarPropiedad(Id_Propiedad_parametro, Id_Inmueble_parametro, piso, denominacion, tipoPropiedad, sup, monto, moneda)

            Conexion.BorrarDuenioFisicoPorPropiedad(Id_Propiedad_parametro)


            Dim Codigo As Integer
            For Each row As DataGridViewRow In Me.grid_propietarios.Rows
                'obtenemos el valor de la columna en la variable declarada
                Codigo = Integer.Parse(row.Cells(0).Value) 'donde (0) es la columna a recorrer
                Conexion.CrearDuenio(Id_Propiedad_parametro, Codigo)
            Next

            MsgBox("Edicion Correcta.")
            Me.Dispose()
        End If
    End Sub

    Private Sub CargarDatosDeCombos()

        If Edicion Then
            'Seteo el total de Elementos a cargar
            Me.Carga.setTotalDeEventos(6)
        Else
            'Seteo el total de Elementos a cargar
            Me.Carga.setTotalDeEventos(5)
        End If

        'Muestro el formulario
        Me.Carga.Run()

        'Sigo con logica.
        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
        Me.Carga.actualizarLoading("Combo Provincia.")


        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", "WHERE Provincia = 1 ORDER BY Nombre ASC;")
        'Cargo las localidades de Buenos aires (Provincia = 1) ya que es el que primero se selecciona..
        Me.Carga.actualizarLoading("Combo Localidad.")


        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento..")


        Conexion.cargarComboTipo(Me.cmb_tipo_propiedad, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Tipo Propiedad..")


        Conexion.cargarComboTipo(Me.cmb_encargado, "Persona")
        Me.Carga.actualizarLoading("Combo Encargados..")

        Me.cargarMonedas(Me.cmb_moneda)
        Funciones.AddButtonColumn(Me.grid_propietarios, "Eliminar", "Accion", 4)

        If Edicion Then
            Me.CargarDatosDeEdicion()
            Me.Carga.actualizarLoading("Datos de edicion.")
        End If



        '      Me.terminarLoading()

    End Sub




    Private Sub txt_piso_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_piso.MaskInputRejected

    End Sub
End Class