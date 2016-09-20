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
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_escribano = New System.Windows.Forms.TextBox()
        Me.txt_comision = New System.Windows.Forms.TextBox()
        Me.txt_NroFactura = New System.Windows.Forms.TextBox()
        Me.txt_montoMensual = New System.Windows.Forms.TextBox()
        Me.txt_duracion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fechaOperacion = New System.Windows.Forms.TextBox()
        Me.lbl_fechaOp = New System.Windows.Forms.Label()
        Me.txt_personaInterviniente = New System.Windows.Forms.TextBox()
        Me.lbl_Pinterviniente = New System.Windows.Forms.Label()
        Me.cmb_tipoOperacion = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoOp = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_superficie = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_tipoPropiedad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_domicilio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_tipoPropiedad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
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
        Me.cmb_tipoPropiedad.TabIndex = 4
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
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(122, 19)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.MaskedTextBox1.TabIndex = 1
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
        Me.GroupBox2.Controls.Add(Me.cmb_estado)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_escribano)
        Me.GroupBox2.Controls.Add(Me.txt_comision)
        Me.GroupBox2.Controls.Add(Me.txt_NroFactura)
        Me.GroupBox2.Controls.Add(Me.txt_montoMensual)
        Me.GroupBox2.Controls.Add(Me.txt_duracion)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_fechaOperacion)
        Me.GroupBox2.Controls.Add(Me.lbl_fechaOp)
        Me.GroupBox2.Controls.Add(Me.txt_personaInterviniente)
        Me.GroupBox2.Controls.Add(Me.lbl_Pinterviniente)
        Me.GroupBox2.Controls.Add(Me.cmb_tipoOperacion)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoOp)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Operacion"
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(68, 157)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(121, 21)
        Me.cmb_estado.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Estado"
        '
        'txt_escribano
        '
        Me.txt_escribano.Location = New System.Drawing.Point(320, 124)
        Me.txt_escribano.Name = "txt_escribano"
        Me.txt_escribano.Size = New System.Drawing.Size(121, 20)
        Me.txt_escribano.TabIndex = 15
        '
        'txt_comision
        '
        Me.txt_comision.Location = New System.Drawing.Point(346, 87)
        Me.txt_comision.Name = "txt_comision"
        Me.txt_comision.Size = New System.Drawing.Size(121, 20)
        Me.txt_comision.TabIndex = 14
        '
        'txt_NroFactura
        '
        Me.txt_NroFactura.Location = New System.Drawing.Point(324, 52)
        Me.txt_NroFactura.Name = "txt_NroFactura"
        Me.txt_NroFactura.Size = New System.Drawing.Size(121, 20)
        Me.txt_NroFactura.TabIndex = 13
        '
        'txt_montoMensual
        '
        Me.txt_montoMensual.Location = New System.Drawing.Point(346, 15)
        Me.txt_montoMensual.Name = "txt_montoMensual"
        Me.txt_montoMensual.Size = New System.Drawing.Size(121, 20)
        Me.txt_montoMensual.TabIndex = 12
        '
        'txt_duracion
        '
        Me.txt_duracion.Location = New System.Drawing.Point(78, 124)
        Me.txt_duracion.Name = "txt_duracion"
        Me.txt_duracion.Size = New System.Drawing.Size(121, 20)
        Me.txt_duracion.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Escribano"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Duracion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Comision Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Monto Mensual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Factura Nº"
        '
        'txt_fechaOperacion
        '
        Me.txt_fechaOperacion.Location = New System.Drawing.Point(122, 90)
        Me.txt_fechaOperacion.Name = "txt_fechaOperacion"
        Me.txt_fechaOperacion.Size = New System.Drawing.Size(121, 20)
        Me.txt_fechaOperacion.TabIndex = 5
        '
        'lbl_fechaOp
        '
        Me.lbl_fechaOp.AutoSize = True
        Me.lbl_fechaOp.Location = New System.Drawing.Point(22, 93)
        Me.lbl_fechaOp.Name = "lbl_fechaOp"
        Me.lbl_fechaOp.Size = New System.Drawing.Size(90, 13)
        Me.lbl_fechaOp.TabIndex = 4
        Me.lbl_fechaOp.Text = "Fecha_operacion"
        '
        'txt_personaInterviniente
        '
        Me.txt_personaInterviniente.Location = New System.Drawing.Point(135, 56)
        Me.txt_personaInterviniente.Name = "txt_personaInterviniente"
        Me.txt_personaInterviniente.Size = New System.Drawing.Size(110, 20)
        Me.txt_personaInterviniente.TabIndex = 3
        '
        'lbl_Pinterviniente
        '
        Me.lbl_Pinterviniente.AutoSize = True
        Me.lbl_Pinterviniente.Location = New System.Drawing.Point(22, 59)
        Me.lbl_Pinterviniente.Name = "lbl_Pinterviniente"
        Me.lbl_Pinterviniente.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Pinterviniente.TabIndex = 2
        Me.lbl_Pinterviniente.Text = "Persona Interviniente"
        '
        'cmb_tipoOperacion
        '
        Me.cmb_tipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoOperacion.FormattingEnabled = True
        Me.cmb_tipoOperacion.Location = New System.Drawing.Point(122, 19)
        Me.cmb_tipoOperacion.Name = "cmb_tipoOperacion"
        Me.cmb_tipoOperacion.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoOperacion.TabIndex = 1
        '
        'lbl_tipoOp
        '
        Me.lbl_tipoOp.AutoSize = True
        Me.lbl_tipoOp.Location = New System.Drawing.Point(22, 22)
        Me.lbl_tipoOp.Name = "lbl_tipoOp"
        Me.lbl_tipoOp.Size = New System.Drawing.Size(95, 13)
        Me.lbl_tipoOp.TabIndex = 0
        Me.lbl_tipoOp.Text = "Tipo de Operación"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_superficie)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lbl_tipoPropiedad)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lbl_domicilio)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(550, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Propiedad"
        '
        'lbl_superficie
        '
        Me.lbl_superficie.AutoSize = True
        Me.lbl_superficie.Location = New System.Drawing.Point(119, 42)
        Me.lbl_superficie.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.Name = "lbl_superficie"
        Me.lbl_superficie.Size = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Superficie:"
        '
        'lbl_tipoPropiedad
        '
        Me.lbl_tipoPropiedad.AutoSize = True
        Me.lbl_tipoPropiedad.Location = New System.Drawing.Point(119, 29)
        Me.lbl_tipoPropiedad.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_tipoPropiedad.Name = "lbl_tipoPropiedad"
        Me.lbl_tipoPropiedad.Size = New System.Drawing.Size(50, 13)
        Me.lbl_tipoPropiedad.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo de Propiedad:"
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(119, 16)
        Me.lbl_domicilio.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Domicilio: "
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(442, 387)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(120, 23)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "Aceptar Operacion"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 387)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'AltaOperacionInmobiliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 422)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipoPropiedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_tipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoOp As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_domicilio As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_superficie As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_tipoPropiedad As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fechaOperacion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents txt_personaInterviniente As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Pinterviniente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_escribano As System.Windows.Forms.TextBox
    Friend WithEvents txt_comision As System.Windows.Forms.TextBox
    Friend WithEvents txt_NroFactura As System.Windows.Forms.TextBox
    Friend WithEvents txt_montoMensual As System.Windows.Forms.TextBox
    Friend WithEvents txt_duracion As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
