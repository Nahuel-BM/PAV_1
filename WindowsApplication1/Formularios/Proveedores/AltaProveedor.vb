Public Class AltaProveedor

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Private Sub AltaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Carga.setTotalDeEventos(2)

        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
        Me.Carga.actualizarLoading("Combo Provincia.")

        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", " WHERE `Provincia` = 1 ORDER BY `Nombre` ASC ;")
        Me.Carga.actualizarLoading("Combo Localidad.")

    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim guardar As Boolean = True
        If Funciones.ValidarTextBox(Me.txt_nombre) = False Then
            guardar = False
            MsgBox("Revise el campo Nombre")
        End If


        If Funciones.ValidarTextBox(Me.txt_calle) = False Then
            guardar = False
            MsgBox("Revise el campo Calle")
        End If

        If Funciones.ValidarTextBox(Me.txt_numero) = False Then
            guardar = False
            MsgBox("Revise el campo Número de calle")
        End If

        If guardar = True Then

            Dim calle As String = Funciones.QuitarEspacios(Me.txt_calle.Text)
            Dim numero As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_numero.Text))
            Dim localidad As Integer = Me.cmb_localidad.SelectedValue


            Dim idDomicilio As Integer = Conexion.CrearDomicilio(calle, numero, localidad)

            Dim nombre As String = Funciones.QuitarEspacios(Me.txt_nombre.Text)
            Try
                Conexion.CrearProveedor(idDomicilio, nombre)
                MsgBox("Proveedor creado correctamente")
            Catch exception As Exception
                MsgBox("Error en la Creacion del proveedor. " & exception.Message)
                Conexion.BorrarDomicilio(idDomicilio)
            End Try
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cmb_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedIndexChanged

    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub



    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE `Provincia` = " + idProvincia.ToString + " ORDER BY `Nombre` ASC;"

        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)



    End Sub



End Class