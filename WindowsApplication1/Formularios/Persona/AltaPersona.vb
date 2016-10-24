Public Class AltaPersona

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim modificar As Boolean = False
    Dim idPersona As Integer
    Dim idDomicilioEditar As Integer

    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida


    Public Sub New(ByVal edicion As Boolean, ByVal idAEditar As Integer)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.modificar = edicion
        Me.idPersona = idAEditar

    End Sub


    Private Sub AltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Carga.setTotalDeEventos(3)

        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")

        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
        Me.Carga.actualizarLoading("Combo Provincia.")

        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", " WHERE `Provincia` = 1 ORDER BY `Nombre` ASC ;")
        Me.Carga.actualizarLoading("Combo Localidad.")

        If modificar Then
            Me.Text = "Edicion de Persona"
            Me.btn_aceptar.Text = "Modificar"
            Dim persona As DataTable = Conexion.Consulta("SELECT `Persona`.*, `Domicilio`.`Calle`, `Domicilio`.`Numero`, `Domicilio`.`Localidad` AS `Localidad`, `Provincia`.`id` AS `Provincia` FROM `Persona` JOIN `Domicilio` ON `Persona`.`Domicilio` = `Domicilio`.`id` JOIN `Localidad` ON `Domicilio`.`Localidad` = `Localidad`.`id` JOIN `Provincia` ON `Localidad`.`Provincia` = `Provincia`.`id` WHERE `Persona`.`id` = " & idPersona & ";")

            idDomicilioEditar = persona(0)("Domicilio")

            Me.txt_nombre.Text = persona(0)("Nombre")
            Me.txt_apellido.Text = persona(0)("Apellido")
            Me.txt_calle.Text = persona(0)("Calle")
            Me.txt_documento.Text = persona(0)("Documento")
            Me.txt_numero.Text = persona(0)("Numero")

            ' Combos

            Me.cmb_localidad.SelectedIndex = persona(0)("Localidad")
            Me.cmb_provincia.SelectedIndex = persona(0)("Provincia")
            Me.cmb_tipoDocumento.SelectedIndex = persona(0)("Tipo_Documento")



        End If

    End Sub




    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim guardar As Boolean = True
        If Funciones.ValidarTextBox(Me.txt_nombre) = False Then
            guardar = False
            MsgBox("Revise el campo Nombre")
        End If

        If Funciones.ValidarTextBox(Me.txt_apellido) = False Then
            guardar = False
            MsgBox("Revise el campo Apellido")
        End If

        If Funciones.ValidarTextBox(Me.txt_documento) = False Then
            guardar = False
            MsgBox("Revise el campo Documento")
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
            'Datos Limpios
            Dim calle As String = Funciones.QuitarEspacios(Me.txt_calle.Text)
            Dim numero As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_numero.Text))
            Dim localidad As Integer = Me.cmb_localidad.SelectedValue

            Dim nombre As String = Funciones.QuitarEspacios(Me.txt_nombre.Text)
            Dim apellido As String = Funciones.QuitarEspacios(Me.txt_apellido.Text)
            Dim documento As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text))
            Dim tipoDoc As Integer = cmb_tipoDocumento.SelectedValue

            If modificar = True Then

                Try
                    Conexion.ActualizarDomicilio(idDomicilioEditar, calle, numero, localidad)
                    Conexion.ActualizarPersona(idPersona, idDomicilioEditar, documento, tipoDoc, nombre, apellido)
                    MsgBox("Persona editada correctamente")

                    Me.Dispose()

                Catch ex As Exception
                    MsgBox("Error en la Edicion de persona. " & ex.Message)
                End Try

            Else

                Dim idDomicilio As Integer = Conexion.CrearDomicilio(calle, numero, localidad)

                Try
                    Conexion.CrearPersona(idDomicilio, documento, tipoDoc, nombre, apellido)
                    MsgBox("Persona creada correctamente")
                Catch exception As Exception
                    MsgBox("Error en la Creacion de persona. " & exception.Message)
                    'En caso de error en persona se deberia borrar el domicilio antes creado..
                    Conexion.BorrarDomicilio(idDomicilio)
                End Try
            End If

        End If
    End Sub

    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"
        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub


    Private Sub txt_nombre_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_nombre.MaskInputRejected

    End Sub
End Class