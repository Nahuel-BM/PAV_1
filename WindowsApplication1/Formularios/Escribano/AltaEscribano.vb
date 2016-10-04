Public Class AltaEscribano

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Private Sub AltaEscribano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Carga.setTotalDeEventos(1)
        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.lbl_nombre.Text = ""
        Me.txt_documento.Text = ""
        Me.txt_matricula.Text = ""
        Me.cmd_crear.Enabled = False
        Me.cmd_nuevo.Enabled = False
        Me.txt_matricula.Enabled = False
        Me.cmd_buscar.Enabled = True
        Me.txt_documento.Focus()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

        Try

            Dim documento As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text))
            Dim Data As DataRow = getPersona(documento)

            Me.lbl_nombre.Text = Data("Apellido") & "," & Data("Nombre") & "."

            Me.cmd_buscar.Enabled = False
            Me.txt_documento.Enabled = False
            Me.cmb_tipoDocumento.Enabled = False

            Me.txt_matricula.Enabled = True
            Me.cmd_crear.Enabled = True


        Catch ex As Exception

        End Try


    End Sub

    Private Function getPersona(ByVal Documento As Integer) As System.Data.DataRow
        Dim retorno As System.Data.DataRow = Nothing


        Dim tabla As DataTable = Me.Conexion.BusquedaExactaEnTabla("Persona", "Documento", Documento)

        Try
            retorno = tabla.Rows(0)

        Catch ex As Exception

        End Try

        Return retorno

    End Function


    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
    End Sub

    Private Sub cmd_crear_Click(sender As Object, e As EventArgs) Handles cmd_crear.Click

    End Sub
End Class