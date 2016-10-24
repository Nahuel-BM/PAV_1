<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaOperacionInmobiliaria
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_tipoPropiedad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_designacion = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_NuevaBusqueda = New System.Windows.Forms.Button()
        Me.lbl_superficie = New System.Windows.Forms.Label()
        Me.lbl_tipo_propiedad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_siguiente = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.grid_Busqueda = New System.Windows.Forms.DataGridView()
        Me.idPropiedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInmueble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbox_Persona = New System.Windows.Forms.GroupBox()
        Me.txt_docPersona = New System.Windows.Forms.MaskedTextBox()
        Me.btn_buscar_persona = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_domicilio2 = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_fechaOp = New System.Windows.Forms.Label()
        Me.lbl_tipoOp = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbox_Persona.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_tipoPropiedad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_designacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'cmb_tipoPropiedad
        '
        Me.cmb_tipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoPropiedad.FormattingEnabled = True
        Me.cmb_tipoPropiedad.Location = New System.Drawing.Point(336, 19)
        Me.cmb_tipoPropiedad.Name = "cmb_tipoPropiedad"
        Me.cmb_tipoPropiedad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoPropiedad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Propiedad"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(463, 17)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_designacion
        '
        Me.txt_designacion.Location = New System.Drawing.Point(122, 19)
        Me.txt_designacion.Name = "txt_designacion"
        Me.txt_designacion.Size = New System.Drawing.Size(123, 20)
        Me.txt_designacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Designación Catastral"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_NuevaBusqueda)
        Me.GroupBox3.Controls.Add(Me.lbl_superficie)
        Me.GroupBox3.Controls.Add(Me.lbl_tipo_propiedad)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbl_domicilio)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(550, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Propiedad Seleccionada"
        '
        'btn_NuevaBusqueda
        '
        Me.btn_NuevaBusqueda.Location = New System.Drawing.Point(430, 71)
        Me.btn_NuevaBusqueda.Name = "btn_NuevaBusqueda"
        Me.btn_NuevaBusqueda.Size = New System.Drawing.Size(113, 23)
        Me.btn_NuevaBusqueda.TabIndex = 8
        Me.btn_NuevaBusqueda.Text = "Nueva Busqueda"
        Me.btn_NuevaBusqueda.UseVisualStyleBackColor = True
        '
        'lbl_superficie
        '
        Me.lbl_superficie.AutoSize = True
        Me.lbl_superficie.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_superficie.Location = New System.Drawing.Point(69, 51)
        Me.lbl_superficie.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.Name = "lbl_superficie"
        Me.lbl_superficie.Size = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.TabIndex = 6
        '
        'lbl_tipo_propiedad
        '
        Me.lbl_tipo_propiedad.AutoSize = True
        Me.lbl_tipo_propiedad.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_tipo_propiedad.Location = New System.Drawing.Point(446, 29)
        Me.lbl_tipo_propiedad.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_tipo_propiedad.Name = "lbl_tipo_propiedad"
        Me.lbl_tipo_propiedad.Size = New System.Drawing.Size(50, 13)
        Me.lbl_tipo_propiedad.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Superficie:"
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_domicilio.Location = New System.Drawing.Point(69, 29)
        Me.lbl_domicilio.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo de Propiedad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Domicilio: "
        '
        'btn_siguiente
        '
        Me.btn_siguiente.Enabled = False
        Me.btn_siguiente.Location = New System.Drawing.Point(435, 541)
        Me.btn_siguiente.Name = "btn_siguiente"
        Me.btn_siguiente.Size = New System.Drawing.Size(120, 23)
        Me.btn_siguiente.TabIndex = 12
        Me.btn_siguiente.Text = "Siguiente"
        Me.btn_siguiente.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(21, 541)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'grid_Busqueda
        '
        Me.grid_Busqueda.AllowUserToAddRows = False
        Me.grid_Busqueda.AllowUserToDeleteRows = False
        Me.grid_Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Busqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPropiedad, Me.idInmueble, Me.textDomicilio})
        Me.grid_Busqueda.Location = New System.Drawing.Point(12, 71)
        Me.grid_Busqueda.Name = "grid_Busqueda"
        Me.grid_Busqueda.ReadOnly = True
        Me.grid_Busqueda.Size = New System.Drawing.Size(550, 116)
        Me.grid_Busqueda.TabIndex = 14
        '
        'idPropiedad
        '
        Me.idPropiedad.HeaderText = "idPropiedad"
        Me.idPropiedad.Name = "idPropiedad"
        Me.idPropiedad.ReadOnly = True
        Me.idPropiedad.Visible = False
        Me.idPropiedad.Width = 300
        '
        'idInmueble
        '
        Me.idInmueble.HeaderText = "idInmueble"
        Me.idInmueble.Name = "idInmueble"
        Me.idInmueble.ReadOnly = True
        Me.idInmueble.Visible = False
        Me.idInmueble.Width = 74
        '
        'textDomicilio
        '
        Me.textDomicilio.HeaderText = "Domicilio"
        Me.textDomicilio.Name = "textDomicilio"
        Me.textDomicilio.ReadOnly = True
        Me.textDomicilio.Width = 430
        '
        'gbox_Persona
        '
        Me.gbox_Persona.Controls.Add(Me.txt_docPersona)
        Me.gbox_Persona.Controls.Add(Me.btn_buscar_persona)
        Me.gbox_Persona.Controls.Add(Me.Button1)
        Me.gbox_Persona.Controls.Add(Me.Label12)
        Me.gbox_Persona.Location = New System.Drawing.Point(12, 299)
        Me.gbox_Persona.Name = "gbox_Persona"
        Me.gbox_Persona.Size = New System.Drawing.Size(550, 45)
        Me.gbox_Persona.TabIndex = 15
        Me.gbox_Persona.TabStop = False
        Me.gbox_Persona.Text = "Busqueda Persona"
        '
        'txt_docPersona
        '
        Me.txt_docPersona.Location = New System.Drawing.Point(122, 18)
        Me.txt_docPersona.Mask = "00000000"
        Me.txt_docPersona.Name = "txt_docPersona"
        Me.txt_docPersona.Size = New System.Drawing.Size(123, 20)
        Me.txt_docPersona.TabIndex = 3
        '
        'btn_buscar_persona
        '
        Me.btn_buscar_persona.Location = New System.Drawing.Point(251, 16)
        Me.btn_buscar_persona.Name = "btn_buscar_persona"
        Me.btn_buscar_persona.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar_persona.TabIndex = 2
        Me.btn_buscar_persona.Text = "Buscar"
        Me.btn_buscar_persona.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-250, -268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Número de documento"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPersona, Me.nombre, Me.apellido, Me.documento, Me.domicilio, Me.telefono})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(550, 86)
        Me.DataGridView1.TabIndex = 4
        '
        'idPersona
        '
        Me.idPersona.HeaderText = "idPersona"
        Me.idPersona.Name = "idPersona"
        Me.idPersona.ReadOnly = True
        Me.idPersona.Visible = False
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
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        '
        'domicilio
        '
        Me.domicilio.HeaderText = "Domicilio"
        Me.domicilio.Name = "domicilio"
        Me.domicilio.ReadOnly = True
        Me.domicilio.Width = 400
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_telefono)
        Me.GroupBox2.Controls.Add(Me.lbl_documento)
        Me.GroupBox2.Controls.Add(Me.lbl_domicilio2)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lbl_fechaOp)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoOp)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 442)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 93)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Persona"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_telefono.Location = New System.Drawing.Point(367, 48)
        Me.lbl_telefono.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(50, 13)
        Me.lbl_telefono.TabIndex = 23
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_documento.Location = New System.Drawing.Point(380, 16)
        Me.lbl_documento.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(50, 13)
        Me.lbl_documento.TabIndex = 22
        '
        'lbl_domicilio2
        '
        Me.lbl_domicilio2.AutoSize = True
        Me.lbl_domicilio2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_domicilio2.Location = New System.Drawing.Point(63, 71)
        Me.lbl_domicilio2.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio2.Name = "lbl_domicilio2"
        Me.lbl_domicilio2.Size = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio2.TabIndex = 21
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_apellido.Location = New System.Drawing.Point(63, 48)
        Me.lbl_apellido.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(50, 13)
        Me.lbl_apellido.TabIndex = 20
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_nombre.Location = New System.Drawing.Point(63, 21)
        Me.lbl_nombre.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(50, 13)
        Me.lbl_nombre.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Domicilio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Telefono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(312, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Documento"
        '
        'lbl_fechaOp
        '
        Me.lbl_fechaOp.AutoSize = True
        Me.lbl_fechaOp.Location = New System.Drawing.Point(6, 48)
        Me.lbl_fechaOp.Name = "lbl_fechaOp"
        Me.lbl_fechaOp.Size = New System.Drawing.Size(44, 13)
        Me.lbl_fechaOp.TabIndex = 4
        Me.lbl_fechaOp.Text = "Apellido"
        '
        'lbl_tipoOp
        '
        Me.lbl_tipoOp.AutoSize = True
        Me.lbl_tipoOp.Location = New System.Drawing.Point(6, 21)
        Me.lbl_tipoOp.Name = "lbl_tipoOp"
        Me.lbl_tipoOp.Size = New System.Drawing.Size(44, 13)
        Me.lbl_tipoOp.TabIndex = 0
        Me.lbl_tipoOp.Text = "Nombre"
        '
        'AltaOperacionInmobiliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbox_Persona)
        Me.Controls.Add(Me.grid_Busqueda)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_siguiente)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AltaOperacionInmobiliaria"
        Me.Text = "Nueva Operacion Inmobiliaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbox_Persona.ResumeLayout(False)
        Me.gbox_Persona.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipoPropiedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_designacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_propiedad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_siguiente As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_superficie As System.Windows.Forms.Label
    Friend WithEvents grid_Busqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btn_NuevaBusqueda As System.Windows.Forms.Button
    Friend WithEvents idPropiedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idInmueble As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents textDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbox_Persona As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_docPersona As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_buscar_persona As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoOp As System.Windows.Forms.Label
    Friend WithEvents idPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio2 As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
