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
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(510, 404)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(99, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(12, 404)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(99, 23)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 146)
        Me.GroupBox2.TabIndex = 3
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
        'Datos_Transaccion_AltaOperacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 440)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Name = "Datos_Transaccion_AltaOperacion"
        Me.Text = "Datos_Transaccion_AltaOperacion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_venta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_factura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_MontoMensual As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fechaFin As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_fechaOperacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_escribano As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents cmb_tipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_tipoOp As System.Windows.Forms.Label
End Class
