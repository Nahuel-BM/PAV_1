﻿Public Class AltaGastos

    'Dim idTipoPropiedad As Integer = 0
    'Dim encontrado As Boolean = False
    'Dim Conexion As Conexion = Constantes.accesoMySQL
    'Dim Funciones As New FuncionesUtiles


    ''Parametros de carga,identifican que es una edicion..
    'Dim Id_Domicilio_parametro As Integer = 0
    'Dim Id_Inmueble_parametro As Integer = 0
    'Dim Id_Propiedad_parametro As Integer = 0
    'Dim Edicion As Boolean = False
    'Dim tablaDatos As DataTable
    ''Fin parametros de carga.


    'Sub New(ByVal id_domicilio As Integer, ByVal id_inmueble As Integer, ByVal id_propiedad As Integer)

    '    InitializeComponent() 'es necesario que lleve esta linea

    '    'Me.Id_Domicilio_parametro = id_domicilio
    '    'Me.Id_Inmueble_parametro = id_inmueble
    '    'Me.Id_Propiedad_parametro = id_propiedad

    '    Edicion = True

    '    Me.btn_altaGasto.Text = "Crear Gasto"
    '    Me.Text = "Creacion de Gasto"

    'End Sub



    'Sub New()
    '    InitializeComponent()
    'End Sub

    'Sub New(ByVal datos As DataTable)
    '    InitializeComponent()
    '    Me.tablaDatos = datos
    '    Me.Edicion = True
    'End Sub

    'Private Sub AltaGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Conexion.cargarComboTipo(Me.cmb_Edificio, "Inmueble")
    '    Conexion.cargarComboTipo(Me.cmb_proveedor, "Proveedor")

    '    If Edicion Then
    '        Me.CargarDatosDeEdicion()
    '    End If



    'End Sub

    ''Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_propietarios.CellClick
    ''    ' elimino la fila
    ''    If e.ColumnIndex = 4 Then
    ''        Dim result As Integer = MessageBox.Show("¿Realmente desea quitar al Propietario?", "Alerta", MessageBoxButtons.OKCancel)
    ''        If result = DialogResult.OK Then
    ''            Me.grid_propietarios.Rows.RemoveAt(e.RowIndex)
    ''        End If
    ''    End If
    ''End Sub

    'Private Sub GuardarEnBaseDeDatos()
    '    Try
    '        If Me.validar = True Then

    '            Dim Fecha As Date = Me.txt_Fecha.Text
    '            Dim NumeroComprobante As Integer = Me.txt_NumeroComprobante.Text
    '            Dim Concepto As String = Me.txt_NumeroComprobante.Text
    '            Dim Importe As Integer = Me.txt_Importe.Text

    '            Dim sqlGastos As String = "INSERT INTO `Gastos`(`Edificio`, `Fecha`, `Concepto`, `Proveedor`, `Numero_Comprobante`, `Importe`) VALUES ('" & Me.cmb_Edificio.SelectedValue & "', " & Fecha & "," & Me.txt_Concepto.Text & "', " & Me.cmb_proveedor.SelectedValue & "," & Me.txt_NumeroComprobante.Text & "," & Me.txt_Importe & ");"



    '            Conexion.ejecutarInsert(sqlGastos)

    '            Dim idGasto As Integer = Conexion.ultimoIdInsertado()

    '            'por cada dueño una consulta..

    '            Dim Codigo As String
    '            For Each row As DataGridViewRow In Me.grid_Concepto.Rows
    '                'obtenemos el valor de la columna en la variable declarada
    '                Codigo = row.Cells(0).Value 'donde (0) es la columna a recorrer

    '                Dim sqlGasto As String = "INSERT INTO `Gastos`(`Propiedad`, `Duenio`) VALUES (" & idPropiedad & ", " & Codigo & ");"
    '                Conexion.ejecutarInsert(sqlDuenio)
    '            Next

    '            MsgBox("¡Gasto creado con exito!")




    '        End If

    '    Catch e As Exception
    '        MsgBox("Error al Guardar Datos")

    '    End Try

    'End Sub


    ''Private Sub AgregarEnListaDePropietarios(ByVal sender As System.Object, e As EventArgs) Handles btn_add.Click

    ''    If Me.encontrado Then

    ''        Dim fila As DataGridViewRow = Me.grid_Busqueda.CurrentRow
    ''        Me.grid_Busqueda.Rows.Clear()
    ''        Me.txt_numeroBusquedaDocumento.Text = ""
    ''        Me.btn_add.Enabled = False

    ''        If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
    ''            Me.grid_propietarios.Rows.Add(fila)
    ''        Else

    ''            For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows
    ''                If Not dgitem.Cells(0).Value.Equals(fila.Cells(0).Value) Then
    ''                    Me.grid_propietarios.Rows.Add(fila)
    ''                Else
    ''                    'MsgBox("La Persona ya es Propietaria del inmueble.")
    ''                End If
    ''            Next

    ''        End If

    ''    End If

    ''End Sub

    ''Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

    ''    Dim senderComboBox As ComboBox = CType(sender, ComboBox)
    ''    Dim idProvincia As Integer = senderComboBox.SelectedValue
    ''    Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"


    ''    Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)

    ''End Sub

    ''Private Sub cambiarTipoInmuebleSeleccionado(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_tipo_propiedad.SelectionChangeCommitted

    ''    Dim senderComboBox As ComboBox = CType(sender, ComboBox)

    ''    idTipoPropiedad = senderComboBox.SelectedValue

    ''    If idTipoPropiedad = 1 Then
    ''        Me.cmb_encargado.Enabled = True
    ''        Me.txt_denominacion_departamento.Enabled = True
    ''        Me.txt_piso.Enabled = True
    ''        Me.txt_total_departamento.Enabled = True
    ''        Me.chk_ascensor.Enabled = True
    ''    Else
    ''        Me.cmb_encargado.Enabled = False
    ''        Me.txt_denominacion_departamento.Enabled = False
    ''        Me.txt_piso.Enabled = False
    ''        Me.txt_total_departamento.Enabled = False
    ''        Me.chk_ascensor.Enabled = False

    ''    End If


    ''End Sub






    'Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
    '    Try
    '        Dim idTipoDoc As Integer = Me.cmb_tipoDocumento.SelectedValue

    '        Dim Sql As String = " SELECT `Tipo_Documento`.`Nombre` AS `Tipo_Documento`, `Persona`.`Nombre`, `Persona`.`Apellido`, `Persona`.`id`, `Persona`.`Documento` FROM Persona LEFT JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE Documento LIKE '%" & Me.txt_numeroBusquedaDocumento.Text & "%' AND Tipo_Documento = " & idTipoDoc & ";"
    '        Dim tabla As New Data.DataTable

    '        tabla = Conexion.Consulta(Sql)

    '        Me.grid_Busqueda.Rows.Clear()


    '        Dim recorrido As Integer = 0
    '        For recorrido = 0 To tabla.Rows.Count() - 1
    '            Me.grid_Busqueda.Rows.Add()
    '            Me.grid_Busqueda.Rows(recorrido).Cells("id_Buscados").Value = tabla.Rows(recorrido)("id")
    '            Me.grid_Busqueda.Rows(recorrido).Cells("nombre_encontrados").Value = tabla.Rows(recorrido)("Nombre") & ", " & tabla.Rows(recorrido)("Apellido")
    '            Me.grid_Busqueda.Rows(recorrido).Cells("num_documento").Value = tabla.Rows(recorrido)("Documento")
    '            Me.grid_Busqueda.Rows(recorrido).Cells("tipo_documento").Value = tabla.Rows(recorrido)("Tipo_Documento")
    '        Next


    '        If tabla.Rows.Count() >= 1 Then
    '            Me.encontrado = True
    '        Else
    '            Me.encontrado = False
    '        End If


    '        Me.btn_add.Enabled = Me.encontrado



    '    Catch ex As Exception
    '        MsgBox("Error " &
    '               vbCrLf & vbCrLf & ex.Message,
    '               MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
    '    End Try
    'End Sub




    'Private Function validar() As Boolean
    '    If Me.txt_calle.Text = "" Then
    '        MessageBox.Show("La calle esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_calle.Focus()
    '        Return False
    '    End If

    '    If Me.txt_numeroCalle.Text = "" Then
    '        MessageBox.Show("El número de calle esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_numeroCalle.Focus()
    '        Return False
    '    End If

    '    If Me.txt_superficie.Text = "" Then
    '        MessageBox.Show("La superficie esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_superficie.Focus()
    '        Return False
    '    End If

    '    If Me.txt_monto.Text = "" Then
    '        MessageBox.Show("El monto de venta esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_monto.Focus()
    '        Return False
    '    End If

    '    If Me.txt_denominacion_catastral.Text = "" Then
    '        MessageBox.Show("La denominacion catastral esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_denominacion_catastral.Focus()
    '        Return False
    '    End If


    '    If Me.idTipoPropiedad = 1 Then

    '        If Me.txt_piso.Text = "" Then
    '            MessageBox.Show("El piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Me.txt_piso.Focus()
    '            Return False
    '        End If

    '        If Me.txt_denominacion_departamento.Text = "" Then
    '            MessageBox.Show("La denominacion del piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Me.txt_denominacion_catastral.Focus()
    '            Return False
    '        End If

    '        If Me.txt_total_departamento.Text = "" Then
    '            MessageBox.Show("El total de los departamentos esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Me.txt_denominacion_catastral.Focus()
    '            Return False
    '        End If

    '    End If

    '    'Separador de ratón..

    '    If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
    '        MessageBox.Show("La propiedad debe tener al menos un propietario. Busque uno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '        Me.txt_numeroBusquedaDocumento.Focus()
    '        Return False
    '    End If

    '    Return True
    'End Function


    'Private Sub btn_crearPropiedad_Click(sender As Object, e As EventArgs) Handles btn_crearPropiedad.Click
    '    If Edicion Then
    '        'Actualizar campos
    '    Else
    '        Me.GuardarEnBaseDeDatos()
    '    End If

    'End Sub

    'Private Sub cargarMonedas(ByRef cmbmoneda)
    '    Dim dt As DataTable = New DataTable("Tabla")

    '    dt.Columns.Add("id")
    '    dt.Columns.Add("Descripcion")

    '    Dim dr As DataRow

    '    dr = dt.NewRow()
    '    dr("id") = "0"
    '    dr("Descripcion") = "Peso"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow()
    '    dr("id") = "1"
    '    dr("Descripcion") = "Dolar"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow()
    '    dr("id") = "2"
    '    dr("Descripcion") = "Euro"
    '    dt.Rows.Add(dr)

    '    cmbmoneda.DataSource = dt
    '    cmbmoneda.ValueMember = "id"
    '    cmbmoneda.DisplayMember = "Descripcion"

    'End Sub


    'Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
    '    Me.Close()
    'End Sub


    'Private Sub CargarDatosDeEdicion()
    '    'Datos Domicilio
    '    Dim datosDomicilio As DataTable = Conexion.Consulta("SELECT `Domicilio`.* , `Localidad`.`Nombre` AS `LocalidadN`, `Provincia`.`Nombre` AS `ProvinciaN` FROM `Domicilio` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE `Domicilio`.`id` = " & Me.Id_Domicilio_parametro & ";")
    '    Me.cmb_provincia.SelectedIndex = Me.cmb_provincia.FindStringExact(datosDomicilio(0)("LocalidadN"))
    '    Me.cmb_provincia.SelectedIndex = Me.cmb_provincia.FindStringExact(datosDomicilio(0)("ProvinciaN"))


    '    Me.txt_calle.Text = datosDomicilio(0)("Calle")



    '    Me.txt_numeroCalle.Text = datosDomicilio(0)("Numero")
    '    'Datos Propiedad

    '    Dim datosPropiedad As DataTable = Conexion.Consulta("SELECT `Propiedad`.`Piso`, `Propiedad`.`Moneda`, `Propiedad`.`Denominacion`,`Propiedad`.`Superficie`, `Propiedad`.`Monto`, `Tipo_Propiedad`.`Nombre` FROM `Propiedad` JOIN `Tipo_Propiedad` ON `Propiedad`.`Tipo_Propiedad` = `Tipo_Propiedad`.`id` WHERE `Propiedad`.`id`= " & Me.Id_Propiedad_parametro)

    '    Me.txt_piso.Text = "" & datosPropiedad(0)("Piso")
    '    Me.txt_denominacion_departamento.Text = datosPropiedad(0)("Denominacion")

    '    ' Me.txt_superficie.RightToLeft = Windows.Forms.RightToLeft.Yes
    '    Me.txt_superficie.Text = Funciones.RellenarConEspacios(datosPropiedad(0)("Superficie"))

    '    Me.txt_monto.Text = Funciones.RellenarConEspacios(datosPropiedad(0)("Monto"))

    '    Me.cmb_tipo_propiedad.SelectedIndex = Me.cmb_tipo_propiedad.FindStringExact(datosPropiedad(0)("Nombre"))

    '    Me.cmb_moneda.SelectedIndex = Me.cmb_moneda.FindStringExact(datosPropiedad(0)("Moneda"))
    '    'Datos Inmueble

    '    Dim datosInmueble As DataTable
    '    If datosPropiedad(0)("Nombre") = "DEPARTAMENTO" Then
    '        datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor`, `Persona`.`Nombre` AS `Encargado`, `Persona`.`Apellido` AS `Encargado_Apellido` FROM `Inmueble` JOIN `Persona` ON `Inmueble`.`Encargado` = `Persona`.`id` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)

    '        Me.txt_total_departamento.Text = datosInmueble(0)("Cantidad_Departamentos")
    '        'encargado

    '        Me.cmb_encargado.SelectedIndex = Me.cmb_moneda.FindStringExact(datosInmueble(0)("Encargado"))

    '        'ascensor
    '        If datosInmueble(0)("Designacion_Catastral") = 1 Then
    '            Me.chk_ascensor.CheckState = CheckState.Checked
    '        End If



    '        Me.cmb_encargado.Enabled = True
    '        Me.txt_denominacion_departamento.Enabled = True
    '        Me.txt_piso.Enabled = True
    '        Me.txt_total_departamento.Enabled = True
    '        Me.chk_ascensor.Enabled = True

    '    Else

    '        Me.cmb_encargado.Enabled = False
    '        Me.txt_denominacion_departamento.Enabled = False
    '        Me.txt_piso.Enabled = False
    '        Me.txt_total_departamento.Enabled = False
    '        Me.chk_ascensor.Enabled = False


    '        datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor` FROM `Inmueble` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)
    '    End If
    '    'datosInmueble = Conexion.Consulta("SELECT `Inmueble`.`Designacion_Catastral`, `Inmueble`.`Cantidad_Departamentos`, `Inmueble`.`Ascensor`, `Persona`.`Nombre` AS `Encargado`, `Persona`.`Apellido` AS `Encargado_Apellido` FROM `Inmueble` JOIN `Persona` ON `Inmueble`.`Encargado` = `Persona`.`id` WHERE `Inmueble`.`id` = " & Me.Id_Inmueble_parametro)

    '    Me.txt_denominacion_catastral.Text = datosInmueble(0)("Designacion_Catastral")

    'End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub AltaGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class