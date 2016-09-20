Public Class AltaOperacionInmobiliaria

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    Dim propiedad As DataTable

    Private Sub AltaOperacionInmobiliaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_tipoPropiedad, "Tipo_Propiedad")
        Conexion.cargarComboTipo(Me.cmb_estado, "Tipo_Propiedad")
    End Sub



    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim denominacion As String = Funciones.QuitarTodosLosEspacios(Me.MaskedTextBox1.Text)
        Dim datosInmueble As DataTable = Conexion.BusquedaExactaEnTabla("Inmueble", "Designacion_Catastral", denominacion)

        Dim datosDomicilio As DataTable = Conexion.Consulta("SELECT `Domicilio`.*, `Localidad`.`Nombre` AS `Localidadn`, `Provincia`.`Nombre` AS `Provincian` FROM `Domicilio` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia`=`Provincia`.`id` WHERE `Domicilio`.`id` = " & datosInmueble(0)("Domicilio"))


        Me.lbl_domicilio.Text = datosDomicilio(0)("Calle") & " " & datosDomicilio(0)("Numero") & ", " & datosDomicilio(0)("Localidadn") & ", " & datosDomicilio(0)("Provincian") & "."
        Me.lbl_tipoPropiedad.Text = Me.cmb_tipoPropiedad.SelectedText



        Conexion.cargarComboTipo(Me.cmb_tipoOperacion, "Tipo_Operacion")

    End Sub

End Class