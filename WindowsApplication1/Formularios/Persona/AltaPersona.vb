Public Class AltaPersona

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    Private Sub AltaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", " WHERE `Provincia` = 1 ORDER BY `Nombre` ASC ;")
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

            Dim calle As String = Funciones.QuitarEspacios(Me.txt_calle.Text)
            Dim numero As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_numero.Text))
            Dim localidad As Integer = Me.cmb_localidad.SelectedValue


            Dim idDomicilio As Integer = Conexion.CrearDomicilio(calle, numero, localidad)

            Dim nombre As String = Funciones.QuitarEspacios(Me.txt_nombre.Text)
            Dim apellido As String = Funciones.QuitarEspacios(Me.txt_apellido.Text)
            Dim documento As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text))
            Dim tipoDoc As Integer = cmb_tipoDocumento.SelectedValue
            Try
                Conexion.CrearPersona(idDomicilio, documento, tipoDoc, nombre, apellido)
                MsgBox("Persona creada correctamente")
            Catch exception As Exception
                MsgBox("Error en la Creacion de persona. " & exception.Message)
                'En caso de error en persona se deberia borrar el domicilio antes creado..
                Conexion.BorrarDomicilio(idDomicilio)
            End Try
        End If


    End Sub

    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"


        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)

    End Sub





    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Dispose()
    End Sub
End Class