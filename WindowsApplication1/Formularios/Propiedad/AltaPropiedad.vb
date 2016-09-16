Imports MySql.Data.MySqlClient


Public Class AltaPropiedad

    ReadOnly Servidor As String = "52.37.245.6"
    ReadOnly Usuario As String = "PAV_1"
    ReadOnly Password As String = "pass"
    ReadOnly BaseDatos As String = "PAV_1"
    ReadOnly Puerto As Integer = 3306

    Dim idTipoPropiedad As Integer = 0
    Dim encontrado As Boolean = False



    Enum monedas
        peso
        dolar
        euro
    End Enum


    Friend conexion As MySqlConnection

    ReadOnly ConnectionString As String = "server=" & Servidor & ";" & "user id=" & Usuario & ";" & "password=" & Password & ";" & "port=" & Puerto & ";" & "database=" & BaseDatos & ";"

    Private Sub AltaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_combo(Me.cmb_provincia, "Provincia", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_localidad, "Localidad", "Nombre", "id", "WHERE Provincia = 1 ORDER BY Nombre ASC;")
        'Cargo las localidades de Buenos aires (Provincia = 1) ya que es el que primero se selecciona..

        Me.cargar_combo(Me.cmb_tipoDocumento, "Tipo_Documento", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_tipo_propiedad, "Tipo_Propiedad", "Nombre", "id", "")
        Me.cargar_combo(Me.cmb_encargado, "Persona", "Nombre", "id", "")

        Me.cargarMonedas(Me.cmb_moneda)
        Me.AddButtonColumn(Me.grid_propietarios, 4)

    End Sub

    Private Sub EventoEliminarPropietario(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_propietarios.CellClick
        ' elimino la fila
        If e.ColumnIndex = 4 Then
            Dim result As Integer = MessageBox.Show("¿Realmente desea quitar al Propietario?", "Alerta", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Me.grid_propietarios.Rows.RemoveAt(e.RowIndex)
            End If
        End If
    End Sub

    Private Sub GuardarEnBaseDeDatos()

        If Me.validar = True Then

            Dim alturaCalle As Integer = Integer.Parse(Me.QuitarEspacios(Me.txt_numeroCalle.Text))
            Dim sqlDomicilio As String = "INSERT INTO `Domicilio`(`Calle`, `Numero`, `Localidad`) VALUES ('" & Me.QuitarEspacios(Me.txt_calle.Text) & "', " & alturaCalle & "," & Me.cmb_localidad.SelectedValue & ");"

            'Ejecutar consulta "sqlDomicilio"

            Me.ejecutarInsert(sqlDomicilio)

            Dim idDomicilio As Integer = Me.ultimoIdInsertado()
            Dim sqlInmueble As String

            If Me.idTipoPropiedad = 1 Then
                'Si es un edificio..
                sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`, `Encargado`, `Cantidad_Departamentos`, `Superficie_Edificio`, `Ascensor`) VALUES ('" & Me.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & "," & cmb_encargado.SelectedValue & "," & Integer.Parse(Me.QuitarEspacios(Me.txt_total_departamento.Text)) & "," & Double.Parse(Me.QuitarEspacios(Me.txt_superficie.Text)) & "," & chk_ascensor.CheckState & ")"
            Else
                sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`) VALUES ('" & Me.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & ");"
            End If

            'Ejecutar consulta "sqlInmueble"

            Me.ejecutarInsert(sqlInmueble)

            Dim idInmueble As Integer = Me.ultimoIdInsertado()
            Dim moneda As String = ""

            If Me.cmb_moneda.SelectedValue = 0 Then
                moneda = "Peso"
            End If
            If Me.cmb_moneda.SelectedValue = 1 Then
                moneda = "Dolar"
            End If
            If Me.cmb_moneda.SelectedValue = 2 Then
                moneda = "Euro"
            End If



            Dim sqlPropiedad As String = "INSERT INTO `Propiedad`(`Id_Inmueble`, `Piso`, `Denominacion`, `Tipo_Propiedad`, `Superficie`, `Monto`, `Moneda`) VALUES (" _
                                         & idInmueble & ", " & Me.QuitarEspacios(Me.txt_piso.Text) & ", '" & Me.QuitarEspacios(Me.txt_denominacion_departamento.Text) & "', " & Me.cmb_tipo_propiedad.SelectedValue & ", " _
                                         & Me.QuitarEspacios(Me.txt_superficie.Text.Replace(",", ".")) & ", " _
                                         & Me.QuitarEspacios(Me.txt_monto.Text.Replace(",", ".")) & ", '" _
                                         & moneda & "');"


            Me.ejecutarInsert(sqlPropiedad)

            Dim idPropiedad As Integer = Me.ultimoIdInsertado()

            'por cada dueño una consulta..

            For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows

                Dim sqlDuenio As String = "INSERT INTO `Duenios`(`Propiedad`, `Duenio`) VALUES (" & idPropiedad & ", " & dgitem.Cells(0).Value & ");"
                '"dgitem.Cells(0).Value" corresponde al id de la persona 
                Me.ejecutarInsert(sqlDuenio)
                
            Next

        End If



    End Sub


    Private Sub AgregarEnListaDePropietarios(ByVal sender As System.Object, e As EventArgs) Handles btn_add.Click

        If Me.encontrado Then

            Dim fila As DataGridViewRow = Me.grid_Busqueda.CurrentRow
            Me.grid_Busqueda.Rows.Clear()
            Me.txt_numeroBusquedaDocumento.Text = ""
            Me.btn_add.Enabled = False

            If Me.IsDataGridViewEmpty(Me.grid_propietarios) Then
                Me.grid_propietarios.Rows.Add(fila)
            Else

                For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows
                    If Not dgitem.Cells(2).Value.Equals(fila.Cells(2).Value) Then
                        Me.grid_propietarios.Rows.Add(fila)
                    Else
                        MsgBox("La Persona ya es Propietaria del inmueble.")
                    End If
                Next

            End If

        End If

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
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"


        Me.cargar_combo(Me.cmb_localidad, "Localidad", "Nombre", "id", sql2)

    End Sub

    Private Sub cambiarTipoInmuebleSeleccionado(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_tipo_propiedad.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)

        idTipoPropiedad = senderComboBox.SelectedValue

        If idTipoPropiedad = 1 Then
            Me.cmb_encargado.Enabled = True
            Me.txt_denominacion_departamento.Enabled = True
            Me.txt_piso.Enabled = True
            Me.txt_total_departamento.Enabled = True
            Me.chk_ascensor.Enabled = True
        Else
            Me.cmb_encargado.Enabled = False
            Me.txt_denominacion_departamento.Enabled = False
            Me.txt_piso.Enabled = False
            Me.txt_total_departamento.Enabled = False
            Me.chk_ascensor.Enabled = False

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

            sql = " SELECT `Tipo_Documento`.`Nombre` AS `Tipo_Documento`, `Persona`.`Nombre`, `Persona`.`Apellido`, `Persona`.`id`, `Persona`.`Documento` FROM Persona LEFT JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE Documento = '" & Me.txt_numeroBusquedaDocumento.Text & "' AND Tipo_Documento = " & idTipoDoc & ";"

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
                Me.grid_Busqueda.Rows(recorrido).Cells("nombre_encontrados").Value = tabla.Rows(recorrido)("Nombre") & ", " & tabla.Rows(recorrido)("Apellido")
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


    Public Function ultimoIdInsertado() As Integer
        Dim retorno As Integer
        Dim sql As String = "SELECT LAST_INSERT_ID() AS LASTID;"


        conexion = New MySqlConnection()
        conexion.ConnectionString = Me.ConnectionString
        conexion.Open()

        Dim adapter As New MySqlDataAdapter

        Dim cmd As New MySqlCommand
        cmd.Connection = conexion
        cmd.CommandText = sql
        adapter.SelectCommand = cmd

        Dim sqlReader As MySqlDataReader = cmd.ExecuteReader()
        sqlReader.Read()

        retorno = Integer.Parse(sqlReader("LASTID").ToString())

        conexion.Close()

        Return retorno
    End Function



    Private Function validar() As Boolean
        If Me.txt_calle.Text = "" Then
            MessageBox.Show("La calle esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_calle.Focus()
            Return False
        End If

        If Me.txt_numeroCalle.Text = "" Then
            MessageBox.Show("El número de calle esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_numeroCalle.Focus()
            Return False
        End If

        If Me.txt_superficie.Text = "" Then
            MessageBox.Show("La superficie esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_superficie.Focus()
            Return False
        End If

        If Me.txt_monto.Text = "" Then
            MessageBox.Show("El monto de venta esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_monto.Focus()
            Return False
        End If

        If Me.txt_denominacion_catastral.Text = "" Then
            MessageBox.Show("La denominacion catastral esta vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_denominacion_catastral.Focus()
            Return False
        End If


        If Me.idTipoPropiedad = 1 Then

            If Me.txt_piso.Text = "" Then
                MessageBox.Show("El piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_piso.Focus()
                Return False
            End If

            If Me.txt_denominacion_departamento.Text = "" Then
                MessageBox.Show("La denominacion del piso del departamento esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_denominacion_catastral.Focus()
                Return False
            End If

            If Me.txt_total_departamento.Text = "" Then
                MessageBox.Show("El total de los departamentos esta vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Me.txt_denominacion_catastral.Focus()
                Return False
            End If

        End If

        'Separador de ratón..

        If Me.IsDataGridViewEmpty(Me.grid_propietarios) Then
            MessageBox.Show("La propiedad debe tener al menos un propietario.\n Busque uno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.txt_numeroBusquedaDocumento.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub btn_crearPropiedad_Click(sender As Object, e As EventArgs) Handles btn_crearPropiedad.Click
        Me.GuardarEnBaseDeDatos()
    End Sub

    Private Sub cargarMonedas(ByRef cmbmoneda)
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("id")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("id") = "0"
        dr("Descripcion") = "Peso"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "1"
        dr("Descripcion") = "Dolar"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("id") = "2"
        dr("Descripcion") = "Euro"
        dt.Rows.Add(dr)

        cmbmoneda.DataSource = dt
        cmbmoneda.ValueMember = "id"
        cmbmoneda.DisplayMember = "Descripcion"

    End Sub


    Private Sub ejecutarInsert(ByVal sql)

        Try
        conexion = New MySqlConnection()
        conexion.ConnectionString = Me.ConnectionString
        conexion.Open()

        Dim cmd As New MySqlCommand

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        conexion.Close()
         Catch ex As Exception
            MsgBox("Error al Ejecutar consulta MySQL " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try

    End Sub



    Private Sub AddButtonColumn(ByRef grid As DataGridView, Optional ByRef posicion As Integer = 0)
        Dim buttons As New DataGridViewButtonColumn()
        With buttons
            .HeaderText = "Accion"
            .Text = "Eliminar"
            .UseColumnTextForButtonValue = True
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
            .DisplayIndex = 0
        End With

        buttons.DisplayIndex = posicion

        grid.Columns.Add(buttons)

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()

    End Sub

    Private Function QuitarEspacios(ByVal cadena As String) As String
        Return LTrim(RTrim(cadena))
    End Function

End Class