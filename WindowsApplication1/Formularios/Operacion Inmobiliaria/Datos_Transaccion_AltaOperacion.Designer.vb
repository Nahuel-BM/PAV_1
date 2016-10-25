<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Transaccion_AltaOperacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_duracion = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_idpersona = New System.Windows.Forms.Label()
        Me.txt_venta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_idprop = New System.Windows.Forms.Label()
        Me.txt_MontoMensual = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fechaOperacion = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_escribano = New System.Windows.Forms.ComboBox()
        Me.cmb_moneda = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_fechaOp = New System.Windows.Forms.Label()
        Me.cmb_tipoOperacion = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoOp = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.lbl_domicilio2 = New System.Windows.Forms.Label()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.lbl_tipo_propiedad = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(436, 382)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(152, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar Operacion"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(14, 382)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 23)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_duracion)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lbl_idpersona)
        Me.GroupBox2.Controls.Add(Me.txt_venta)
        Me.GroupBox2.Controls.Add(Me.lbl_idprop)
        Me.GroupBox2.Controls.Add(Me.txt_MontoMensual)
        Me.GroupBox2.Controls.Add(Me.txt_fechaOperacion)
        Me.GroupBox2.Controls.Add(Me.cmb_escribano)
        Me.GroupBox2.Controls.Add(Me.cmb_moneda)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_fechaOp)
        Me.GroupBox2.Controls.Add(Me.cmb_tipoOperacion)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoOp)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 150)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Operacion"
        '
        'txt_duracion
        '
        Me.txt_duracion.Location = New System.Drawing.Point(135, 98)
        Me.txt_duracion.Mask = "99999"
        Me.txt_duracion.Name = "txt_duracion"
        Me.txt_duracion.Size = New System.Drawing.Size(144, 20)
        Me.txt_duracion.TabIndex = 26
        Me.txt_duracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_duracion.ValidatingType = GetType(Integer)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Duracion en meses"
        '
        'lbl_idpersona
        '
        Me.lbl_idpersona.AutoSize = True
        Me.lbl_idpersona.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_idpersona.Location = New System.Drawing.Point(621, 78)
        Me.lbl_idpersona.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_idpersona.Name = "lbl_idpersona"
        Me.lbl_idpersona.Size = New System.Drawing.Size(50, 13)
        Me.lbl_idpersona.TabIndex = 23
        '
        'txt_venta
        '
        Me.txt_venta.Enabled = False
        Me.txt_venta.Location = New System.Drawing.Point(394, 71)
        Me.txt_venta.Mask = "99999"
        Me.txt_venta.Name = "txt_venta"
        Me.txt_venta.Size = New System.Drawing.Size(144, 20)
        Me.txt_venta.TabIndex = 10
        Me.txt_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_venta.ValidatingType = GetType(Integer)
        '
        'lbl_idprop
        '
        Me.lbl_idprop.AutoSize = True
        Me.lbl_idprop.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_idprop.Location = New System.Drawing.Point(605, 18)
        Me.lbl_idprop.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_idprop.Name = "lbl_idprop"
        Me.lbl_idprop.Size = New System.Drawing.Size(50, 13)
        Me.lbl_idprop.TabIndex = 22
        '
        'txt_MontoMensual
        '
        Me.txt_MontoMensual.Enabled = False
        Me.txt_MontoMensual.Location = New System.Drawing.Point(135, 71)
        Me.txt_MontoMensual.Mask = "99999"
        Me.txt_MontoMensual.Name = "txt_MontoMensual"
        Me.txt_MontoMensual.Size = New System.Drawing.Size(144, 20)
        Me.txt_MontoMensual.TabIndex = 11
        Me.txt_MontoMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_MontoMensual.ValidatingType = GetType(Integer)
        '
        'txt_fechaOperacion
        '
        Me.txt_fechaOperacion.Enabled = False
        Me.txt_fechaOperacion.Location = New System.Drawing.Point(135, 45)
        Me.txt_fechaOperacion.Mask = "0000/00/00"
        Me.txt_fechaOperacion.Name = "txt_fechaOperacion"
        Me.txt_fechaOperacion.Size = New System.Drawing.Size(144, 20)
        Me.txt_fechaOperacion.TabIndex = 7
        Me.txt_fechaOperacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'cmb_moneda
        '
        Me.cmb_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_moneda.Enabled = False
        Me.cmb_moneda.FormattingEnabled = True
        Me.cmb_moneda.Location = New System.Drawing.Point(394, 18)
        Me.cmb_moneda.Name = "cmb_moneda"
        Me.cmb_moneda.Size = New System.Drawing.Size(144, 21)
        Me.cmb_moneda.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(308, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Moneda"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(308, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Comision Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Monto Mensual"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_telefono)
        Me.GroupBox1.Controls.Add(Me.lbl_documento)
        Me.GroupBox1.Controls.Add(Me.lbl_domicilio2)
        Me.GroupBox1.Controls.Add(Me.lbl_apellido)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 89)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Persona"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Documento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Nombre"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Domicilio: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(343, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Tipo de Propiedad:"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_tipo_propiedad)
        Me.GroupBox3.Controls.Add(Me.lbl_domicilio)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 49)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Propiedad Seleccionada"
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(445, 179)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(142, 23)
        Me.btn_confirmar.TabIndex = 19
        Me.btn_confirmar.Text = "Confirmar Datos"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'Datos_Transaccion_AltaOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 417)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Datos_Transaccion_AltaOperacion"
        Me.Text = "Datos_Transaccion_AltaOperacion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_venta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_MontoMensual As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fechaOperacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_escribano As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoOp As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_documento As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio2 As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_propiedad As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_idpersona As System.Windows.Forms.Label
    Friend WithEvents lbl_idprop As System.Windows.Forms.Label
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_duracion As System.Windows.Forms.MaskedTextBox
End Class
