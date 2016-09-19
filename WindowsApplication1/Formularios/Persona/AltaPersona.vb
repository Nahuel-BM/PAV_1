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
            MsgBox("Revise el campo Nombre")
        End If

        If Funciones.ValidarTextBox(Me.txt_documento) = False Then
            guardar = False
            MsgBox("Revise el campo Nombre")
        End If

        If Funciones.ValidarTextBox(Me.txt_calle) = False Then
            guardar = False
            MsgBox("Revise el campo Nombre")
        End If

        If Funciones.ValidarTextBox(Me.txt_numero) = False Then
            guardar = False
            MsgBox("Revise el campo Nombre")
        End If

        If guardar = True Then
            Dim calle As String = Funciones.QuitarEspacios(Me.txt_calle.Text)
            Dim numero As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_numero.Text))
            Dim localidad As Integer = Me.cmb_localidad.FindStringExact(Me.cmb_localidad.SelectedText)


            Dim idDomicilio As Integer = Conexion.CrearDomicilio(calle, numero, localidad)

            Dim nombre As String = Funciones.QuitarEspacios(Me.txt_nombre.Text)
            Dim apellido As String = Funciones.QuitarEspacios(Me.txt_apellido.Text)
            Dim documento As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text))
            Dim tipoDoc As Integer = cmb_tipoDocumento.SelectedValue

            Conexion.CrearPersona(idDomicilio, documento, tipoDoc, nombre, apellido)

        End If


    End Sub
End Class