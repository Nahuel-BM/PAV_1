Public Class AltaPropiedad

    Dim idTipoPropiedad As Integer = 0
    Dim encontrado As Boolean = False
    Dim Conexion As Conexion = Constantes.accesoMySQL
    Dim Funciones As New FuncionesUtiles

    Enum monedas
        peso
        dolar
        euro
    End Enum

    Private Sub AltaPropiedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Conexion.cargarComboTipo(Me.cmb_provincia, "Provincia")
        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", "WHERE Provincia = 1 ORDER BY Nombre ASC;")
        'Cargo las localidades de Buenos aires (Provincia = 1) ya que es el que primero se selecciona..

        Conexion.cargarComboTipo(Me.cmb_tipoDocumento, "Tipo_Documento")
        Conexion.cargarComboTipo(Me.cmb_tipo_propiedad, "Tipo_Propiedad")
        Conexion.cargarComboTipo(Me.cmb_encargado, "Persona")

        Me.cargarMonedas(Me.cmb_moneda)
        Funciones.AddButtonColumn(Me.grid_propietarios, "Accion", "Eliminar", 4)

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

            Dim alturaCalle As Integer = Integer.Parse(Funciones.QuitarEspacios(Me.txt_numeroCalle.Text))
            Dim sqlDomicilio As String = "INSERT INTO `Domicilio`(`Calle`, `Numero`, `Localidad`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_calle.Text) & "', " & alturaCalle & "," & Me.cmb_localidad.SelectedValue & ");"

            'Ejecutar consulta "sqlDomicilio"

            Conexion.ejecutarInsert(sqlDomicilio)

            Dim idDomicilio As Integer = Conexion.ultimoIdInsertado()
            Dim sqlInmueble As String

            If Me.idTipoPropiedad = 1 Then
                'Si es un edificio..
                sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`, `Encargado`, `Cantidad_Departamentos`, `Superficie_Edificio`, `Ascensor`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & "," & cmb_encargado.SelectedValue & "," & Integer.Parse(Funciones.QuitarEspacios(Me.txt_total_departamento.Text)) & "," & Double.Parse(Funciones.QuitarEspacios(Me.txt_superficie.Text)) & "," & chk_ascensor.CheckState & ")"
            Else
                sqlInmueble = "INSERT INTO `Inmueble`(`Designacion_Catastral`, `Domicilio`) VALUES ('" & Funciones.QuitarEspacios(Me.txt_denominacion_catastral.Text) & "'," & idDomicilio & ");"
            End If

            'Ejecutar consulta "sqlInmueble"

            Conexion.ejecutarInsert(sqlInmueble)

            Dim idInmueble As Integer = Conexion.ultimoIdInsertado()
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
                                         & idInmueble & ", " & Funciones.QuitarEspacios(Me.txt_piso.Text) & ", '" & Funciones.QuitarEspacios(Me.txt_denominacion_departamento.Text) & "', " & Me.cmb_tipo_propiedad.SelectedValue & ", " _
                                         & Funciones.QuitarEspacios(Me.txt_superficie.Text.Replace(",", ".")) & ", " _
                                         & Funciones.QuitarEspacios(Me.txt_monto.Text.Replace(",", ".")) & ", '" _
                                         & moneda & "');"


            Conexion.ejecutarInsert(sqlPropiedad)

            Dim idPropiedad As Integer = Conexion.ultimoIdInsertado()

            'por cada dueño una consulta..

            For Each dgitem As DataGridViewRow In Me.grid_propietarios.Rows

                Dim sqlDuenio As String = "INSERT INTO `Duenios`(`Propiedad`, `Duenio`) VALUES (" & idPropiedad & ", " & dgitem.Cells(0).Value & ");"
                '"dgitem.Cells(0).Value" corresponde al id de la persona 
                Conexion.ejecutarInsert(sqlDuenio)

            Next

        End If



    End Sub


    Private Sub AgregarEnListaDePropietarios(ByVal sender As System.Object, e As EventArgs) Handles btn_add.Click

        If Me.encontrado Then

            Dim fila As DataGridViewRow = Me.grid_Busqueda.CurrentRow
            Me.grid_Busqueda.Rows.Clear()
            Me.txt_numeroBusquedaDocumento.Text = ""
            Me.btn_add.Enabled = False

            If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
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

    Private Sub cambiarProvinciaSeleccionada(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_provincia.SelectionChangeCommitted

        Dim senderComboBox As ComboBox = CType(sender, ComboBox)
        Dim idProvincia As Integer = senderComboBox.SelectedValue
        Dim sql2 As String = "WHERE Provincia = " + idProvincia.ToString + " ORDER BY Nombre ASC;"


        Conexion.cargarComboTipo(Me.cmb_localidad, "Localidad", sql2)

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
            Dim idTipoDoc As Integer = Me.cmb_tipoDocumento.SelectedValue

            Dim Sql As String = " SELECT `Tipo_Documento`.`Nombre` AS `Tipo_Documento`, `Persona`.`Nombre`, `Persona`.`Apellido`, `Persona`.`id`, `Persona`.`Documento` FROM Persona LEFT JOIN `Tipo_Documento` ON `Persona`.`Tipo_Documento` = `Tipo_Documento`.`id` WHERE Documento = '" & Me.txt_numeroBusquedaDocumento.Text & "' AND Tipo_Documento = " & idTipoDoc & ";"
            Dim tabla As New Data.DataTable

            tabla = Conexion.Consulta(Sql)

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
            MsgBox("Error " &
                   vbCrLf & vbCrLf & ex.Message,
                   MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End Try
    End Sub




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

        If Funciones.IsDataGridViewEmpty(Me.grid_propietarios) Then
            MessageBox.Show("La propiedad debe tener al menos un propietario. Busque uno.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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


    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub



End Class