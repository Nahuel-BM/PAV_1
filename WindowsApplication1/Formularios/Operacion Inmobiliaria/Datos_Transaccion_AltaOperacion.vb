Public Class Datos_Transaccion_AltaOperacion
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim propiedad As DataTable
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida


    Private Sub Datos_Transaccion_AltaOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_estado, "Tipo_Propiedad")
        Me.Carga.actualizarLoading("Combo Estado Propiedad.")

        Me.cargarComboEscribanos(Me.cmb_escribano)
        Me.Carga.actualizarLoading("Combo Escribanos.")

        Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")
        Me.Carga.actualizarLoading("Combo Tipo Operacion.")

        Me.txt_factura.Enabled = False
        Me.txt_fechaFin.Enabled = False
        Me.txt_fechaOperacion.Enabled = False
        Me.txt_venta.Enabled = False
        Me.txt_MontoMensual.Enabled = False
        Me.txt_duracion.Enabled = False
        Me.cmb_escribano.Enabled = False
        Me.cmb_estado.Enabled = False
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
        If Funciones.ValidarTextBox(Me.txt_factura) = False Then
            guardar = False
            MsgBox("Revise el campo Factura")
        End If

        If Funciones.ValidarTextBox(Me.txt_fechaFin) = False Then
            guardar = False
            MsgBox("Revise el campo Fecha Fin")
        End If

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
            Dim factura As String = Funciones.QuitarEspacios(Me.txt_factura.Text)
            Dim fechafin As String = Funciones.QuitarEspacios(Me.txt_fechaFin.Text)
            Dim fechaop As String = Funciones.QuitarEspacios(Me.txt_fechaOperacion.Text)
            Dim venta As String = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_venta.Text))
            Dim monto As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_MontoMensual.Text))
            Dim escribano As Integer = Me.cmb_escribano.SelectedValue
            Dim estado As Integer = Me.cmb_estado.SelectedValue
            Dim tipoop As Integer = Me.cmb_tipoOperacion.SelectedValue
            Dim duracion As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_duracion.Text))


            Try
                Conexion.CrearOperacionInmobiliaria(Me.lbl_idprop.Text, tipoop, Me.lbl_idpersona.Text, fechaop, duracion, monto, factura, venta, escribano)
                MsgBox("Operacion Inmobiliaria creada correctamente")
            Catch exception As Exception
                MsgBox("Error en la Creacion de la operacion. " & exception.Message)
            End Try
        End If


    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Me.txt_factura.Enabled = True
        Me.txt_fechaFin.Enabled = True
        Me.txt_fechaOperacion.Enabled = True
        Me.txt_venta.Enabled = True
        Me.txt_MontoMensual.Enabled = True
        Me.txt_duracion.Enabled = True
        Me.cmb_escribano.Enabled = True
        Me.cmb_estado.Enabled = True
        Me.cmb_tipoOperacion.Enabled = True
        Me.btn_aceptar.Enabled = True
    End Sub


End Class