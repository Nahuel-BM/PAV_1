Imports MySql.Data.MySqlClient


Public Class AltaPropiedad

    ReadOnly Servidor As String = "52.37.245.6"
    ReadOnly Usuario As String = "PAV_1"
    ReadOnly Password As String = "pass"
    ReadOnly BaseDatos As String = "PAV_1"
    ReadOnly Puerto As Integer = 3306

    Dim idTipoPropiedad As Integer = 0
    Dim encontrado As Boolean = False


    Friend conexion As MySqlConnection
    ReadOnly ConnectionString As String = "server=" & Servidor & ";" & "user id=" & Usuario & ";" & "password=" & Password & ";" & "port=" & Puerto & ";" & "database=" & BaseDatos & ";"

    Private Sub AltaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_combo(Me.cmb_provincia, "Provincia", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_localidad, "Localidad", "Nombre", "id", "WHERE Provincia = 1 ORDER BY Nombre ASC;")
        'Cargo las localidades de Buenos aires (Provincia = 1) ya que es el que primero se selecciona..

        Me.cargar_combo(Me.cmb_tipoDocumento, "Tipo_Documento", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_tipo_propiedad, "Tipo_Propiedad", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_encargado, "Persona", "Nombre", "id", "")

    End Sub

    Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_propietarios.CellClick
        ' elimino la fila
        If e.ColumnIndex = 5 Then
            Dim result As Integer = MessageBox.Show("¿Realmente desea quitar al Propietario?", "Alerta", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.grid_propietarios.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub GuardarEnBaseDeDatos()

        Dim row As String() = New String() {"1", "Nahuel 1", "Bustamante 1", "1", "DNI"}
        grid_propietarios.Rows.Add(row)



        Dim btn As New DataGridViewButtonColumn()
        grid_propietarios.Columns.Add(btn)
        btn.HeaderText = "Accion"
        btn.Text = "Eliminar"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True



    End Sub


    Private Sub btnAddClick(ByVal sender As System.Object, e As EventArgs) Handles btn_add.Click

        If Me.encontrado Then

            Dim fila As DataGridViewRow = Me.grid_Busqueda.CurrentRow
            Me.grid_Busqueda.Rows.Clear()
            Me.txt_numeroBusquedaDocumento.Text = ""
            Me.btn_add.Enabled = False

            If Me.IsDataGridViewEmpty(Me.grid_propietarios) Then
                Me.grid_propietarios.Rows.Add(fila)
            Else

                For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows
                    If Not dgitem.Cells(3).Value.Equals(fila.Cells(3).Value) Then
                        Me.grid_propietarios.Rows.Add(fila)
                    Else
                        MsgBox("La Persona ya es Propietaria del inmueble.")
                    End If
                Next

            End If

        End If

    End Sub

    Private Sub AgregarEnListaDePropietarios()

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByVal nombre_tabla As String, ByVal descripcion As String, ByVal pk As String, ByVal filtro As String)

        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = Me.ConnectionString
            conexion.Open()

            Dim adapter As New MySqlDataAdapter
            Dim sql As String

            Dim tabla As New Data.DataTable

            sql = " SELECT * FROM " + nombre_tabla + " " + filtro
            Dim cmd As New MySqlCommand
            cmd.Connection = conexion
            cmd.CommandText = sql
            adapter.SelectCommand = cmd

            tabla.Load(cmd.ExecuteReader())
            conexion.Close()

            combo.DataSource = tabla
            combo.DisplayMember = descripcion
            combo.ValueMember = pk

        Catch ex As Exception
            MsgBox("Error al conectar al servidor MySQL " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)

        If (senderComboBox.SelectionLength > 0) Then
            Dim idProvincia As Integer = senderComboBox.SelectedValue
            Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"

            Me.cargar_combo(Me.cmb_localidad, "Localidad", "Nombre", "id", sql2)

        End If
    End Sub

    Private Sub cambiarTipoInmuebleSeleccionado(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_tipo_propiedad.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)

        idTipoPropiedad = senderComboBox.SelectedValue

        If idTipoPropiedad = 1 Then
            Me.cmb_encargado.Enabled = True
            Me.txt_denominacion_departamento.Enabled = True
            Me.txt_piso.Enabled = True
        Else
            Me.cmb_encargado.Enabled = False
            Me.txt_denominacion_departamento.Enabled = False
            Me.txt_piso.Enabled = False

        End If


    End Sub




 

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = Me.ConnectionString
            conexion.Open()

            Dim adapter As New MySqlDataAdapter
            Dim sql As String

            Dim tabla As New Data.DataTable

            Dim idTipoDoc As Integer = Me.cmb_tipoDocumento.SelectedValue

            sql = " SELECT * FROM Persona WHERE Documento = '" & Me.txt_numeroBusquedaDocumento.Text & "' AND Tipo_Documento = " & idTipoDoc & ";"


            'If Me.DataGridView1.Rows.Contains()


            Dim cmd As New MySqlCommand
            cmd.Connection = conexion
            cmd.CommandText = sql
            adapter.SelectCommand = cmd

            tabla.Load(cmd.ExecuteReader())
            conexion.Close()


            Me.grid_Busqueda.Rows.Clear()


            Dim recorrido As Integer = 0
            For recorrido = 0 To tabla.Rows.Count() - 1
                Me.grid_Busqueda.Rows.Add()
                Me.grid_Busqueda.Rows(recorrido).Cells("nombre_encontrados").Value = tabla.Rows(recorrido)("Nombre")
                Me.grid_Busqueda.Rows(recorrido).Cells("apellido_encontrado").Value = tabla.Rows(recorrido)("Apellido")

                Me.grid_Busqueda.Rows(recorrido).Cells("num_documento").Value = tabla.Rows(recorrido)("Documento")
                Me.grid_Busqueda.Rows(recorrido).Cells("tipo_documento").Value = tabla.Rows(recorrido)("Tipo_Documento")
            Next


            If tabla.Rows.Count() >= 1 Then
                Me.encontrado = True
            Else
                Me.encontrado = False
            End If


            Me.btn_add.Enabled = Me.encontrado



        Catch ex As Exception
            MsgBox("Error al conectar al servidor MySQL " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub




    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function


End Class