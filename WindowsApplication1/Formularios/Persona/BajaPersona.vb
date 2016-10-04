Public Class BajaPersona

    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles
    Dim editar As Boolean = False

    Dim Carga As New Form_con_Pantalla_de_Carga_Incluida

    Public Sub New(ByVal edicion As Boolean)
        InitializeComponent()
        editar = edicion

    End Sub



    Private Sub BajaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Carga.setTotalDeEventos(1)

        Me.Carga.Run()

        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Me.Carga.actualizarLoading("Combo Tipo Documento.")

        If editar = True Then
            Funciones.AddButtonColumn(Me.DataGridView1, "Editar", "Acción", 3)
        Else
            Funciones.AddButtonColumn(Me.DataGridView1, "Eliminar", "Acción", 3)
        End If

    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Me.DataGridView1.Rows.Clear()

        Dim numero As String = Funciones.QuitarTodosLosEspacios(Me.txt_documento.Text)

        Dim tabla As DataTable = Conexion.Consulta("SELECT `Tipo_Documento`.`Nombre` AS `TIPO`, `Persona`.`id`, `Persona`.`Nombre`, `Persona`.`Documento`, `Persona`.`Apellido` FROM `Persona` JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE `Persona`.`Documento` = " & numero & ";")

        Dim recorrido As Integer = 0
        For recorrido = 0 To tabla.Rows.Count() - 1
            Me.DataGridView1.Rows.Add()

            Me.DataGridView1.Rows(recorrido).Cells("id").Value = tabla.Rows(recorrido)("id")
            Me.DataGridView1.Rows(recorrido).Cells("nombre").Value = tabla.Rows(recorrido)("Nombre") & ", " & tabla.Rows(recorrido)("Apellido") & "."
            Me.DataGridView1.Rows(recorrido).Cells("documento").Value = tabla.Rows(recorrido)("Documento") & "(" & tabla.Rows(recorrido)("TIPO") & ")"

        Next

    End Sub




    Private Sub EventoEliminarPersona(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' elimino la fila
        If e.ColumnIndex = 3 Then
            Dim result As Integer

            If editar = True Then
                result = MessageBox.Show("¿Realmente desea editar la Persona?", "Alerta", MessageBoxButtons.OKCancel)
            Else
                result = MessageBox.Show("¿Realmente desea quitar la Persona?", "Alerta", MessageBoxButtons.OKCancel)
            End If

            If result = DialogResult.OK Then
                Dim Id_Persona As Integer = Integer.Parse(Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
                Try
                    If editar = True Then
                        Dim frm As New AltaPersona(True, Id_Persona)
                        frm.Show()
                        Me.Dispose()
                    Else

                        If Conexion.ComprobarFK("Duenios", "Duenio", Id_Persona) Then
                            Conexion.BorrarPersona(Id_Persona)
                            Me.DataGridView1.Rows.RemoveAt(e.RowIndex)
                            MsgBox("Persona eliminada Correctamente.")
                        Else
                            MsgBox("Error al eliminar Persona. La Persona esta ligada a una propiedad.")
                        End If

                    End If

                Catch ex As Exception
                    MsgBox("Error al eliminar Persona. " & ex.Message)
                End Try
            End If
        End If
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class