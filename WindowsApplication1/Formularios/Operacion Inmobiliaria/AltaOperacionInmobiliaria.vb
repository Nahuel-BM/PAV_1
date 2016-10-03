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

    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim denominacion As String = Funciones.QuitarTodosLosEspacios(Me.MaskedTextBox1.Text)
        Dim datosInmueble As DataTable = Conexion.BusquedaExactaEnTabla("Inmueble", "Designacion_Catastral", denominacion)

        Try
            Dim datosDomicilio As DataTable = Conexion.Consulta("SELECT `Domicilio`.*, `Localidad`.`Nombre` AS `Localidadn`, `Provincia`.`Nombre` AS `Provincian` FROM `Domicilio` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia`=`Provincia`.`id` WHERE `Domicilio`.`id` = " & datosInmueble(0)("Domicilio"))

            Me.lbl_domicilio.Text = datosDomicilio(0)("Calle") & " " & datosDomicilio(0)("Numero") & ", " & datosDomicilio(0)("Localidadn") & ", " & datosDomicilio(0)("Provincian") & "."
            Me.lbl_Dom.Text = Me.cmb_tipoPropiedad.SelectedText

            Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")

            Me.btn_aceptar.Enabled = True

        Catch ex As Exception
            MsgBox("Inmueble no encontrado.")
        End Try

    

    End Sub

    Private Sub lbl_superficie_Click(sender As Object, e As EventArgs) Handles lbl_tipo_propiedad.Click

    End Sub
End Class