Public Class AltaEscribano

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Dim idPersonaBuscada As Integer = 0
    Dim esEdicion As Boolean = False
    Dim idEscribanoDeEdicion As Integer = 0



    Public Sub New(Optional ByVal idEscribano As Integer = 0)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        If idEscribano > 0 Then
            Me.esEdicion = True
            Me.idEscribanoDeEdicion = idEscribano
        End If


    End Sub




    Private Sub AltaEscribano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If esEdicion Then

            Me.Text = "Edicion de Escribano"
            Me.cmd_nuevo.Text = "Guardar"

            Me.Carga.setTotalDeEventos(2)
            Me.Carga.Run()

            Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
            Me.Carga.actualizarLoading("Combo Tipo Documento.")

            Me.cargarDatosDeEdicion()
            Me.Carga.actualizarLoading("Datos de Escribano.")
        Else
            Me.Carga.setTotalDeEventos(1)
            Me.Carga.Run()

            Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
            Me.Carga.actualizarLoading("Combo Tipo Documento.")

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.lbl_nombre.Text = ""
        Me.txt_documento.Text = ""
        Me.txt_matricula.Text = ""
        Me.cmd_crear.Enabled = False
        Me.cmd_nuevo.Enabled = False
        Me.txt_matricula.Enabled = False
        Me.cmd_buscar.Enabled = True
        Me.txt_documento.Enabled = True
        Me.cmb_tipoDocumento.Enabled = True

        Me.txt_documento.Focus()

        Me.idPersonaBuscada = 0
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click

        Try

            If Funciones.ValidarTextBox(Me.txt_documento) Then



                Dim documento As Integer = Integer.Parse(Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text))
                Dim Data As DataRow = getPersona(documento)

                Me.lbl_nombre.Text = Data("Apellido") & "," & Data("Nombre") & "."
                Me.idPersonaBuscada = Data("id")

                Me.cmd_buscar.Enabled = False
                Me.txt_documento.Enabled = False
                Me.cmb_tipoDocumento.Enabled = False

                Me.txt_matricula.Enabled = True
                Me.cmd_crear.Enabled = True
                Me.cmd_nuevo.Enabled = True

                Me.txt_matricula.Focus()
            Else
                MsgBox("Numero de Documento invalido.")
            End If

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
        Me.Close()
    End Sub

    Private Sub cmd_crear_Click(sender As Object, e As EventArgs) Handles cmd_crear.Click

        Dim Matricula As String = Funciones.QuitarTodosLosEspacios(Me.txt_matricula.Text)

        If Funciones.ValidarTextBox(Me.txt_matricula) Then
            ' MsgBox("Matricula: " & Matricula & " Persona: " & idPersonaBuscada)
            Try
                If esEdicion Then
                    Conexion.EditarEscribano(idEscribanoDeEdicion, Matricula)
                    MsgBox("Edicion Correcta.")
                Else
                    Conexion.CrearEscribano(Me.idPersonaBuscada, Matricula)
                    MsgBox("Escribano Creado Correctamente.")
                    Me.txt_matricula.Enabled = False
                    Me.cmd_crear.Enabled = False
                End If



            Catch ex As Exception
                Dim mensaje As String = ex.Message

                If esEdicion Then

                    MsgBox("Error al Editar Escribano.")

                Else
                    If mensaje.Contains("Matricula") Then
                        MsgBox("Error al crear escribano. La matricula ya esta registrada.")
                        Me.txt_matricula.Focus()
                    ElseIf mensaje.Contains("Persona") Then
                        MsgBox("Error al crear escribano. La persona ya tiene matricula registrada.")
                        Me.cmd_nuevo.Focus()
                    End If


                End If


               


            End Try




        Else
            MsgBox("Matricula Incorrecta.")
            Me.txt_matricula.Focus()
        End If

    End Sub


    Private Sub cargarDatosDeEdicion()
        Dim sql As String = "SELECT `Persona`.`Documento` AS `Documento`, `Persona`.`Tipo_Documento` AS `TipoDocumento`, CONCAT (`Persona`.`Nombre`, ', ' , `Persona`.`Apellido`) AS `NombreCompleto` , `Escribanos`.`Matricula` AS `Matricula` FROM `Escribanos` JOIN `Persona` ON `Persona`.`id` = `Escribanos`.`Persona` WHERE `Escribanos`.`id` = " & Me.idEscribanoDeEdicion & "; "
        Dim Datos As DataTable = Me.Conexion.Consulta(sql)

        Try
            Me.txt_documento.Text = Datos.Rows(0)("Documento")
            Me.txt_matricula.Text = Datos.Rows(0)("Matricula")
            Me.lbl_nombre.Text = Datos.Rows(0)("NombreCompleto")

            Me.txt_documento.Enabled = False
            Me.txt_matricula.Enabled = True
            Me.cmb_tipoDocumento.Enabled = False

            Me.cmd_crear.Text = "Guardar"
            Me.cmd_crear.Enabled = True
            Me.cmd_buscar.Enabled = False
            Me.cmd_nuevo.Text = "Nuevo"





        Catch ex As Exception
            MsgBox("Error" & ex.Message)
            MsgBox(sql)
        End Try




    End Sub

End Class