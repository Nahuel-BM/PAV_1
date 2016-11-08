Public Class Condicion_Propiedad_por_Dueño

    Dim Funciones As New FuncionesUtiles
    Dim idPersonaBuscada As Integer

    Dim Conexion As Conexion = Constantes.accesoMySQL

    'Variables de pantalla de carga
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida



    Private Sub Condicion_Propiedad_por_Dueño_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Carga.setTotalDeEventos(1)
        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.ComboBox1, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")



    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim frm As New Form_propiedades_por_dueño(idPersonaBuscada)

        frm.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Me.idPersonaBuscada = 0 Then

            Dim sql As String = "SELECT * FROM `Persona` WHERE `Documento` = " & Me.txt_documento.Text & " AND `Tipo_Documento` = " & Me.ComboBox1.SelectedValue & "; "
            Dim datos As DataTable = Conexion.Consulta(sql)
            Try
                lbl_apellido.Text = datos(0)("Apellido")
                lbl_nombre.Text = datos(0)("Nombre")
                Me.idPersonaBuscada = datos(0)("id")
                Me.btn_aceptar.Enabled = True

                Me.ComboBox1.Enabled = False
                Me.txt_documento.Enabled = False

                Me.btn_buscar.Text = "Nueva Busqueda"

            Catch ex As Exception
                MsgBox("No existe esa persona en el sistema.")
            End Try
        Else
            lbl_apellido.Text = ""
            lbl_nombre.Text = ""
            Me.idPersonaBuscada = 0
            Me.btn_aceptar.Enabled = False

            Me.ComboBox1.Enabled = True
            Me.txt_documento.Enabled = True

            Me.btn_buscar.Text = "Buscar"

        End If

    End Sub
End Class