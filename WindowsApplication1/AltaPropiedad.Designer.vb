<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaPropiedad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_crearPropiedad = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_encargado = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_denominacion_departamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_superficie = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_piso = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_tipo_propiedad = New System.Windows.Forms.ComboBox()
        Me.txt_denominacion_catastral = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_numeroCalle = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_propietarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cmb_tipoDocumento = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_numeroBusquedaDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grid_Busqueda = New System.Windows.Forms.DataGridView()
        Me.id_busqueda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_encontrados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido_encontrado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_propietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provincia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calle"
        '
        'btn_crearPropiedad
        '
        Me.btn_crearPropiedad.Location = New System.Drawing.Point(469, 511)
        Me.btn_crearPropiedad.Name = "btn_crearPropiedad"
        Me.btn_crearPropiedad.Size = New System.Drawing.Size(97, 23)
        Me.btn_crearPropiedad.TabIndex = 11
        Me.btn_crearPropiedad.Text = "Crear Propiedad"
        Me.btn_crearPropiedad.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(11, 511)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 12
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_encargado)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmb_moneda)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_monto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_denominacion_departamento)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_superficie)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_piso)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_tipo_propiedad)
        Me.GroupBox1.Controls.Add(Me.txt_denominacion_catastral)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_numeroCalle)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_calle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_localidad)
        Me.GroupBox1.Controls.Add(Me.cmb_provincia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(554, 180)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Inmueble"
        '
        'cmb_encargado
        '
        Me.cmb_encargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_encargado.FormattingEnabled = True
        Me.cmb_encargado.Location = New System.Drawing.Point(404, 150)
        Me.cmb_encargado.Name = "cmb_encargado"
        Me.cmb_encargado.Size = New System.Drawing.Size(143, 21)
        Me.cmb_encargado.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(339, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Encargado"
        '
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(96, 150)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(143, 21)
        Me.cmb_moneda.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 153)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Moneda"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(95, 124)
        Me.txt_monto.Mask = "999999999"
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(144, 20)
        Me.txt_monto.TabIndex = 19
        Me.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_monto.ValidatingType = GetType(Integer)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Monto"
        '
        'txt_denominacion_departamento
        '
        Me.txt_denominacion_departamento.Location = New System.Drawing.Point(404, 124)
        Me.txt_denominacion_departamento.Mask = "L"
        Me.txt_denominacion_departamento.Name = "txt_denominacion_departamento"
        Me.txt_denominacion_departamento.Size = New System.Drawing.Size(144, 20)
        Me.txt_denominacion_departamento.TabIndex = 17
        Me.txt_denominacion_departamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(323, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Denominación"
        '
        'txt_superficie
        '
        Me.txt_superficie.Location = New System.Drawing.Point(95, 98)
        Me.txt_superficie.Mask = "99999"
        Me.txt_superficie.Name = "txt_superficie"
        Me.txt_superficie.Size = New System.Drawing.Size(144, 20)
        Me.txt_superficie.TabIndex = 15
        Me.txt_superficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_superficie.ValidatingType = GetType(Integer)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Superficie"
        '
        'txt_piso
        '
        Me.txt_piso.Location = New System.Drawing.Point(404, 98)
        Me.txt_piso.Mask = "09"
        Me.txt_piso.Name = "txt_piso"
        Me.txt_piso.Size = New System.Drawing.Size(144, 20)
        Me.txt_piso.TabIndex = 13
        Me.txt_piso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(371, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Piso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo Propiedad"
        '
        'cmb_tipo_propiedad
        '
        Me.cmb_tipo_propiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_propiedad.FormattingEnabled = True
        Me.cmb_tipo_propiedad.Location = New System.Drawing.Point(95, 72)
        Me.cmb_tipo_propiedad.Name = "cmb_tipo_propiedad"
        Me.cmb_tipo_propiedad.Size = New System.Drawing.Size(144, 21)
        Me.cmb_tipo_propiedad.TabIndex = 11
        '
        'txt_denominacion_catastral
        '
        Me.txt_denominacion_catastral.Location = New System.Drawing.Point(404, 72)
        Me.txt_denominacion_catastral.Mask = "????????????????????"
        Me.txt_denominacion_catastral.Name = "txt_denominacion_catastral"
        Me.txt_denominacion_catastral.Size = New System.Drawing.Size(144, 20)
        Me.txt_denominacion_catastral.TabIndex = 10
        Me.txt_denominacion_catastral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Denominación Catastral"
        '
        'txt_numeroCalle
        '
        Me.txt_numeroCalle.Location = New System.Drawing.Point(404, 46)
        Me.txt_numeroCalle.Mask = "099999"
        Me.txt_numeroCalle.Name = "txt_numeroCalle"
        Me.txt_numeroCalle.Size = New System.Drawing.Size(144, 20)
        Me.txt_numeroCalle.TabIndex = 4
        Me.txt_numeroCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(354, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Número"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(96, 46)
        Me.txt_calle.Mask = "????????????????????"
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(143, 20)
        Me.txt_calle.TabIndex = 3
        Me.txt_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Localidad"
        '
        'cmb_localidad
        '
        Me.cmb_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(404, 19)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(144, 21)
        Me.cmb_localidad.TabIndex = 1
        '
        'cmb_provincia
        '
        Me.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(96, 19)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(143, 21)
        Me.cmb_provincia.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_propietarios)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 377)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 128)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Propietarios del Inmueble"
        '
        'grid_propietarios
        '
        Me.grid_propietarios.AllowUserToAddRows = False
        Me.grid_propietarios.AllowUserToDeleteRows = False
        Me.grid_propietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_propietarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.apellido, Me.numeroDocumento, Me.tipoDocumento})
        Me.grid_propietarios.Location = New System.Drawing.Point(6, 19)
        Me.grid_propietarios.Name = "grid_propietarios"
        Me.grid_propietarios.ReadOnly = True
        Me.grid_propietarios.Size = New System.Drawing.Size(542, 97)
        Me.grid_propietarios.TabIndex = 10
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'numeroDocumento
        '
        Me.numeroDocumento.HeaderText = "Num Documento"
        Me.numeroDocumento.Name = "numeroDocumento"
        Me.numeroDocumento.ReadOnly = True
        '
        'tipoDocumento
        '
        Me.tipoDocumento.HeaderText = "Tipo Doc."
        Me.tipoDocumento.Name = "tipoDocumento"
        Me.tipoDocumento.ReadOnly = True
        Me.tipoDocumento.Width = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_add)
        Me.GroupBox3.Controls.Add(Me.cmb_tipoDocumento)
        Me.GroupBox3.Controls.Add(Me.btn_buscar)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_numeroBusquedaDocumento)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.grid_Busqueda)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 173)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selección de Dueños"
        '
        'btn_add
        '
        Me.btn_add.Enabled = False
        Me.btn_add.Location = New System.Drawing.Point(473, 144)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Añadir"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cmb_tipoDocumento
        '
        Me.cmb_tipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoDocumento.FormattingEnabled = True
        Me.cmb_tipoDocumento.Location = New System.Drawing.Point(341, 13)
        Me.cmb_tipoDocumento.Name = "cmb_tipoDocumento"
        Me.cmb_tipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoDocumento.TabIndex = 6
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(474, 11)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 7
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo Documento"
        '
        'txt_numeroBusquedaDocumento
        '
        Me.txt_numeroBusquedaDocumento.Location = New System.Drawing.Point(114, 13)
        Me.txt_numeroBusquedaDocumento.Mask = "99999999"
        Me.txt_numeroBusquedaDocumento.Name = "txt_numeroBusquedaDocumento"
        Me.txt_numeroBusquedaDocumento.Size = New System.Drawing.Size(121, 20)
        Me.txt_numeroBusquedaDocumento.TabIndex = 5
        Me.txt_numeroBusquedaDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Número Documento"
        '
        'grid_Busqueda
        '
        Me.grid_Busqueda.AllowUserToAddRows = False
        Me.grid_Busqueda.AllowUserToDeleteRows = False
        Me.grid_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Busqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_busqueda, Me.nombre_encontrados, Me.apellido_encontrado, Me.num_documento, Me.tipo_documento})
        Me.grid_Busqueda.Location = New System.Drawing.Point(6, 40)
        Me.grid_Busqueda.Name = "grid_Busqueda"
        Me.grid_Busqueda.ReadOnly = True
        Me.grid_Busqueda.Size = New System.Drawing.Size(542, 98)
        Me.grid_Busqueda.TabIndex = 8
        '
        'id_busqueda
        '
        Me.id_busqueda.HeaderText = "id"
        Me.id_busqueda.Name = "id_busqueda"
        Me.id_busqueda.ReadOnly = True
        Me.id_busqueda.Visible = False
        '
        'nombre_encontrados
        '
        Me.nombre_encontrados.HeaderText = "Nombre"
        Me.nombre_encontrados.Name = "nombre_encontrados"
        Me.nombre_encontrados.ReadOnly = True
        '
        'apellido_encontrado
        '
        Me.apellido_encontrado.HeaderText = "Apellido"
        Me.apellido_encontrado.Name = "apellido_encontrado"
        Me.apellido_encontrado.ReadOnly = True
        '
        'num_documento
        '
        Me.num_documento.HeaderText = "Num. Doc."
        Me.num_documento.Name = "num_documento"
        Me.num_documento.ReadOnly = True
        '
        'tipo_documento
        '
        Me.tipo_documento.HeaderText = "Tipo Doc."
        Me.tipo_documento.Name = "tipo_documento"
        Me.tipo_documento.ReadOnly = True
        '
        'AltaPropiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 540)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_crearPropiedad)
        Me.Name = "AltaPropiedad"
        Me.Text = "Creación de Propiedad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_propietarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_crearPropiedad As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_propietarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_numeroCalle As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_numeroBusquedaDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grid_Busqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_propiedad As System.Windows.Forms.ComboBox
    Friend WithEvents txt_denominacion_catastral As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_superficie As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_piso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_denominacion_departamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmb_encargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_monto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents id_busqueda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_encontrados As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido_encontrado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents num_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
