Public Class Datos_Transaccion_AltaOperacion
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim propiedad As DataTable
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Enum monedas
        peso
        dolar
        euro
    End Enum

    Private Sub Datos_Transaccion_AltaOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_moneda, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Estado Propiedad.")

        Me.cargarComboEscribanos(Me.cmb_escribano)
        Me.Carga.actualizarLoading("Combo Escribanos.")

        Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")
        Me.Carga.actualizarLoading("Combo Tipo Operacion.")

        Me.cargarMonedas(Me.cmb_moneda)

        'Me.txt_factura.Enabled = False
        'Me.txt_fechaFin.Enabled = False
        Me.txt_fechaOperacion.Enabled = False
        Me.txt_venta.Enabled = False
        Me.txt_MontoMensual.Enabled = False
        Me.txt_duracion.Enabled = False
        Me.cmb_escribano.Enabled = False
        Me.cmb_moneda.Enabled = False
        Me.cmb_tipoOperacion.Enabled = False
        Me.btn_aceptar.Enabled = False
        'Falta Comision y Duracion
    End Sub

    Private Sub cargarComboEscribanos(ByRef ComboBox As ComboBox)
        Dim sql As String = "SELECT `Escribanos`.`id` AS `ID`, CONCAT(`Persona`.`Apellido`, ', ', `Persona`.`Nombre`, '(', `Escribanos`.`Matricula` ,')' ) AS `Nombre` FROM `Escribanos` JOIN `Persona` ON `Persona`.`id` = `Escribanos`.`Persona` ;"

        Dim Tabla As DataTable = Me.Conexion.Consulta(sql)

        ComboBox.DataSource = Tabla
        ComboBox.DisplayMember = "Nombre"
        ComboBox.ValueMember = "ID"

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim guardar As Boolean = True
       
        If Funciones.ValidarTextBox(Me.txt_fechaOperacion) = False Then
            guardar = False
            MsgBox("Revise el campo Fecha Operacion")
        End If

        If Funciones.ValidarTextBox(Me.txt_duracion) = False Then
            guardar = False
            MsgBox("Revise el campo Duracion")
        End If

        If Funciones.ValidarTextBox(Me.txt_venta) = False Then
            guardar = False
            MsgBox("Revise el campo Venta")
        End If

        If Funciones.ValidarTextBox(Me.txt_MontoMensual) = False Then
            guardar = False
            MsgBox("Revise el campo Monto Mensual")
        End If

        If guardar = True Then
            'Datos Limpios
            'Dim factura As String = Funciones.QuitarEspacios(Me.txt_factura.Text)
            ' Dim fechafin As String = Funciones.QuitarEspacios(Me.txt_fechaFin.Text)
            Dim fechaop As String = Me.txt_fechaOperacion.Text 'Funciones.QuitarEspacios(Me.txt_fechaOperacion.Text)
            Dim venta As String = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_venta.Text))
            Dim monto As Double = Double.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_MontoMensual.Text))
            Dim escribano As Integer = Me.cmb_escribano.SelectedValue
            'Dim estado As Integer = Me.cmb_estado.SelectedValue
            Dim tipoop As Integer = Me.cmb_tipoOperacion.SelectedValue
            Dim duracion As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_duracion.Text))


            Try

                'crear factura.

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

                ' Conexion.conexion_con_transaccion()

                Dim factura As Integer = Conexion.CrearFactura(Me.lbl_idpersona.Text, monto, moneda, Me.cmb_tipoOperacion.Text & " " & Me.lbl_tipo_propiedad.Text)

                Conexion.CrearOperacionInmobiliaria(Me.lbl_idprop.Text, tipoop, Me.lbl_idpersona.Text, fechaop, duracion, monto, factura, venta, escribano)

                Conexion.cerrar_con_transaccion()
                MsgBox("Operacion Inmobiliaria creada correctamente")

            Catch exception As Exception
                MsgBox("Error en la Creacion de la operacion. " & exception.Message)
            End Try
            Me.Close()

        End If


    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        ' Me.txt_factura.Enabled = True
        'Me.txt_fechaFin.Enabled = True
        Me.txt_fechaOperacion.Enabled = True
        Me.txt_venta.Enabled = True
        Me.txt_MontoMensual.Enabled = True
        Me.txt_duracion.Enabled = True
        Me.cmb_escribano.Enabled = True
        Me.cmb_moneda.Enabled = True
        Me.cmb_tipoOperacion.Enabled = True
        Me.btn_aceptar.Enabled = True
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


End Class