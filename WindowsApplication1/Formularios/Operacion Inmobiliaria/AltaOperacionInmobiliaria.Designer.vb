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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_venta = New System.Windows.Forms.MaskedTextBox()
        Me.txt_factura = New System.Windows.Forms.MaskedTextBox()
        Me.txt_MontoMensual = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaFin = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaOperacion = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_escribano = New System.Windows.Forms.ComboBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fechaOp = New System.Windows.Forms.Label()
        Me.cmb_tipoOperacion = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoOp = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_NuevaBusqueda = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.lbl_superficie = New System.Windows.Forms.Label()
        Me.lbl_tipo_propiedad = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.grid_Busqueda = New System.Windows.Forms.DataGridView()
        Me.idPropiedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idInmueble = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.textDomicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_venta)
        Me.GroupBox2.Controls.Add(Me.txt_factura)
        Me.GroupBox2.Controls.Add(Me.txt_MontoMensual)
        Me.GroupBox2.Controls.Add(Me.txt_fechaFin)
        Me.GroupBox2.Controls.Add(Me.txt_fechaOperacion)
        Me.GroupBox2.Controls.Add(Me.cmb_escribano)
        Me.GroupBox2.Controls.Add(Me.cmb_estado)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_fechaOp)
        Me.GroupBox2.Controls.Add(Me.cmb_tipoOperacion)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoOp)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 422)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 134)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Operacion"
        '
        'txt_venta
        '
        Me.txt_venta.Enabled = False
        Me.txt_venta.Location = New System.Drawing.Point(394, 97)
        Me.txt_venta.Mask = "99999"
        Me.txt_venta.Name = "txt_venta"
        Me.txt_venta.Size = New System.Drawing.Size(144, 20)
        Me.txt_venta.TabIndex = 10
        Me.txt_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_venta.ValidatingType = GetType(Integer)
        '
        'txt_factura
        '
        Me.txt_factura.Enabled = False
        Me.txt_factura.Location = New System.Drawing.Point(394, 71)
        Me.txt_factura.Mask = "99999"
        Me.txt_factura.Name = "txt_factura"
        Me.txt_factura.Size = New System.Drawing.Size(144, 20)
        Me.txt_factura.TabIndex = 8
        Me.txt_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_factura.ValidatingType = GetType(Integer)
        '
        'txt_MontoMensual
        '
        Me.txt_MontoMensual.Enabled = False
        Me.txt_MontoMensual.Location = New System.Drawing.Point(135, 97)
        Me.txt_MontoMensual.Mask = "99999"
        Me.txt_MontoMensual.Name = "txt_MontoMensual"
        Me.txt_MontoMensual.Size = New System.Drawing.Size(144, 20)
        Me.txt_MontoMensual.TabIndex = 11
        Me.txt_MontoMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_MontoMensual.ValidatingType = GetType(Integer)
        '
        'txt_fechaFin
        '
        Me.txt_fechaFin.Enabled = False
        Me.txt_fechaFin.Location = New System.Drawing.Point(135, 71)
        Me.txt_fechaFin.Mask = "00/00/0000"
        Me.txt_fechaFin.Name = "txt_fechaFin"
        Me.txt_fechaFin.Size = New System.Drawing.Size(144, 20)
        Me.txt_fechaFin.TabIndex = 9
        Me.txt_fechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_fechaFin.ValidatingType = GetType(Date)
        '
        'txt_fechaOperacion
        '
        Me.txt_fechaOperacion.Enabled = False
        Me.txt_fechaOperacion.Location = New System.Drawing.Point(135, 45)
        Me.txt_fechaOperacion.Mask = "00/00/0000"
        Me.txt_fechaOperacion.Name = "txt_fechaOperacion"
        Me.txt_fechaOperacion.Size = New System.Drawing.Size(144, 20)
        Me.txt_fechaOperacion.TabIndex = 7
        Me.txt_fechaOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_fechaOperacion.ValidatingType = GetType(Date)
        '
        'cmb_escribano
        '
        Me.cmb_escribano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_escribano.Enabled = False
        Me.cmb_escribano.FormattingEnabled = True
        Me.cmb_escribano.Location = New System.Drawing.Point(394, 45)
        Me.cmb_escribano.Name = "cmb_escribano"
        Me.cmb_escribano.Size = New System.Drawing.Size(144, 21)
        Me.cmb_escribano.TabIndex = 6
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Enabled = False
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(394, 18)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(144, 21)
        Me.cmb_estado.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(308, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Escribano"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha Fin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Comision Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Monto Mensual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Factura Nº"
        '
        'lbl_fechaOp
        '
        Me.lbl_fechaOp.AutoSize = True
        Me.lbl_fechaOp.Location = New System.Drawing.Point(6, 48)
        Me.lbl_fechaOp.Name = "lbl_fechaOp"
        Me.lbl_fechaOp.Size = New System.Drawing.Size(89, 13)
        Me.lbl_fechaOp.TabIndex = 4
        Me.lbl_fechaOp.Text = "Fecha Operacion"
        '
        'cmb_tipoOperacion
        '
        Me.cmb_tipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoOperacion.Enabled = False
        Me.cmb_tipoOperacion.FormattingEnabled = True
        Me.cmb_tipoOperacion.Location = New System.Drawing.Point(135, 18)
        Me.cmb_tipoOperacion.Name = "cmb_tipoOperacion"
        Me.cmb_tipoOperacion.Size = New System.Drawing.Size(144, 21)
        Me.cmb_tipoOperacion.TabIndex = 3
        '
        'lbl_tipoOp
        '
        Me.lbl_tipoOp.AutoSize = True
        Me.lbl_tipoOp.Location = New System.Drawing.Point(6, 21)
        Me.lbl_tipoOp.Name = "lbl_tipoOp"
        Me.lbl_tipoOp.Size = New System.Drawing.Size(95, 13)
        Me.lbl_tipoOp.TabIndex = 0
        Me.lbl_tipoOp.Text = "Tipo de Operación"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_NuevaBusqueda)
        Me.GroupBox3.Controls.Add(Me.btn_confirmar)
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
        Me.btn_NuevaBusqueda.Location = New System.Drawing.Point(6, 71)
        Me.btn_NuevaBusqueda.Name = "btn_NuevaBusqueda"
        Me.btn_NuevaBusqueda.Size = New System.Drawing.Size(113, 23)
        Me.btn_NuevaBusqueda.TabIndex = 8
        Me.btn_NuevaBusqueda.Text = "Nueva Busqueda"
        Me.btn_NuevaBusqueda.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(468, 71)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 7
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
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
        'btn_aceptar
        '
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Location = New System.Drawing.Point(430, 587)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(120, 23)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Aceptar Operacion"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(21, 587)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(550, 117)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-250, -268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(122, 18)
        Me.MaskedTextBox1.Mask = "00000000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.MaskedTextBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(529, 66)
        Me.DataGridView1.TabIndex = 4
        '
        'AltaOperacionInmobiliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 615)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grid_Busqueda)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AltaOperacionInmobiliaria"
        Me.Text = "Nueva Operacion Inmobiliaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grid_Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipoPropiedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_designacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoOp As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_propiedad As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_fechaFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fechaOperacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_escribano As System.Windows.Forms.ComboBox
    Friend WithEvents txt_venta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_factura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_MontoMensual As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lbl_superficie As System.Windows.Forms.Label
    Friend WithEvents grid_Busqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btn_NuevaBusqueda As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents idPropiedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idInmueble As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents textDomicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
