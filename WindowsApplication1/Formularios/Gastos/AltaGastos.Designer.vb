<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaGastos
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
        Me.btn_altaGasto = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_comprobanteNº = New System.Windows.Forms.Label()
        Me.txt_ImporteTotal = New System.Windows.Forms.TextBox()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.lbl_concepto = New System.Windows.Forms.Label()
        Me.grid_Concepto = New System.Windows.Forms.DataGridView()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_añadirConcepto = New System.Windows.Forms.Button()
        Me.lbl_edificio = New System.Windows.Forms.Label()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        Me.txt_Fecha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_NumeroComprobante = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_Edificio = New System.Windows.Forms.ComboBox()
        Me.txt_Concepto = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Importe = New System.Windows.Forms.MaskedTextBox()
        CType(Me.grid_Concepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_altaGasto
        '
        Me.btn_altaGasto.Location = New System.Drawing.Point(435, 368)
        Me.btn_altaGasto.Name = "btn_altaGasto"
        Me.btn_altaGasto.Size = New System.Drawing.Size(75, 23)
        Me.btn_altaGasto.TabIndex = 11
        Me.btn_altaGasto.Text = "Crear Gasto"
        Me.btn_altaGasto.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(7, 368)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(60, 16)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Fecha"
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(299, 13)
        Me.lbl_proveedor.Name = "lbl_proveedor"
        Me.lbl_proveedor.Size = New System.Drawing.Size(56, 13)
        Me.lbl_proveedor.TabIndex = 4
        Me.lbl_proveedor.Text = "Proveedor"
        '
        'lbl_comprobanteNº
        '
        Me.lbl_comprobanteNº.AutoSize = True
        Me.lbl_comprobanteNº.Location = New System.Drawing.Point(12, 57)
        Me.lbl_comprobanteNº.Name = "lbl_comprobanteNº"
        Me.lbl_comprobanteNº.Size = New System.Drawing.Size(85, 13)
        Me.lbl_comprobanteNº.TabIndex = 6
        Me.lbl_comprobanteNº.Text = "Comprobante Nº"
        '
        'txt_ImporteTotal
        '
        Me.txt_ImporteTotal.Enabled = False
        Me.txt_ImporteTotal.Location = New System.Drawing.Point(79, 304)
        Me.txt_ImporteTotal.Name = "txt_ImporteTotal"
        Me.txt_ImporteTotal.Size = New System.Drawing.Size(126, 20)
        Me.txt_ImporteTotal.TabIndex = 8
        '
        'lbl_importe
        '
        Me.lbl_importe.AutoSize = True
        Me.lbl_importe.Location = New System.Drawing.Point(4, 307)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(69, 13)
        Me.lbl_importe.TabIndex = 9
        Me.lbl_importe.Text = "Importe Total"
        '
        'lbl_concepto
        '
        Me.lbl_concepto.AutoSize = True
        Me.lbl_concepto.Location = New System.Drawing.Point(44, 106)
        Me.lbl_concepto.Name = "lbl_concepto"
        Me.lbl_concepto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_concepto.TabIndex = 10
        Me.lbl_concepto.Text = "Concepto"
        '
        'grid_Concepto
        '
        Me.grid_Concepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Concepto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.concepto, Me.Importe})
        Me.grid_Concepto.Location = New System.Drawing.Point(7, 136)
        Me.grid_Concepto.Name = "grid_Concepto"
        Me.grid_Concepto.Size = New System.Drawing.Size(503, 145)
        Me.grid_Concepto.TabIndex = 7
        '
        'concepto
        '
        Me.concepto.HeaderText = "Concepto"
        Me.concepto.Name = "concepto"
        Me.concepto.Width = 150
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Width = 150
        '
        'btn_añadirConcepto
        '
        Me.btn_añadirConcepto.Location = New System.Drawing.Point(406, 302)
        Me.btn_añadirConcepto.Name = "btn_añadirConcepto"
        Me.btn_añadirConcepto.Size = New System.Drawing.Size(104, 23)
        Me.btn_añadirConcepto.TabIndex = 9
        Me.btn_añadirConcepto.Text = "Añadir Concepto"
        Me.btn_añadirConcepto.UseVisualStyleBackColor = True
        '
        'lbl_edificio
        '
        Me.lbl_edificio.AutoSize = True
        Me.lbl_edificio.Location = New System.Drawing.Point(314, 57)
        Me.lbl_edificio.Name = "lbl_edificio"
        Me.lbl_edificio.Size = New System.Drawing.Size(41, 13)
        Me.lbl_edificio.TabIndex = 13
        Me.lbl_edificio.Text = "Edificio"
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(361, 13)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(149, 21)
        Me.cmb_proveedor.TabIndex = 1
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(104, 16)
        Me.txt_Fecha.Mask = "00/00/0000"
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(125, 20)
        Me.txt_Fecha.TabIndex = 0
        Me.txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Fecha.ValidatingType = GetType(Date)
        '
        'txt_NumeroComprobante
        '
        Me.txt_NumeroComprobante.Location = New System.Drawing.Point(104, 54)
        Me.txt_NumeroComprobante.Mask = "9999999999"
        Me.txt_NumeroComprobante.Name = "txt_NumeroComprobante"
        Me.txt_NumeroComprobante.Size = New System.Drawing.Size(125, 20)
        Me.txt_NumeroComprobante.TabIndex = 3
        Me.txt_NumeroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_Edificio
        '
        Me.cmb_Edificio.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_Edificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Edificio.FormattingEnabled = True
        Me.cmb_Edificio.Location = New System.Drawing.Point(361, 54)
        Me.cmb_Edificio.Name = "cmb_Edificio"
        Me.cmb_Edificio.Size = New System.Drawing.Size(149, 21)
        Me.cmb_Edificio.TabIndex = 4
        '
        'txt_Concepto
        '
        Me.txt_Concepto.Location = New System.Drawing.Point(104, 99)
        Me.txt_Concepto.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL"
        Me.txt_Concepto.Name = "txt_Concepto"
        Me.txt_Concepto.Size = New System.Drawing.Size(126, 20)
        Me.txt_Concepto.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Importe"
        '
        'txt_Importe
        '
        Me.txt_Importe.Location = New System.Drawing.Point(361, 96)
        Me.txt_Importe.Mask = "99999999999"
        Me.txt_Importe.Name = "txt_Importe"
        Me.txt_Importe.Size = New System.Drawing.Size(149, 20)
        Me.txt_Importe.TabIndex = 6
        Me.txt_Importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AltaGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 403)
        Me.Controls.Add(Me.txt_Importe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Concepto)
        Me.Controls.Add(Me.txt_NumeroComprobante)
        Me.Controls.Add(Me.txt_Fecha)
        Me.Controls.Add(Me.cmb_proveedor)
        Me.Controls.Add(Me.cmb_Edificio)
        Me.Controls.Add(Me.lbl_edificio)
        Me.Controls.Add(Me.btn_añadirConcepto)
        Me.Controls.Add(Me.grid_Concepto)
        Me.Controls.Add(Me.lbl_concepto)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.txt_ImporteTotal)
        Me.Controls.Add(Me.lbl_comprobanteNº)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_altaGasto)
        Me.Name = "AltaGastos"
        Me.Text = "AltaGastos"
        CType(Me.grid_Concepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_altaGasto As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_comprobanteNº As System.Windows.Forms.Label
    Friend WithEvents txt_ImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_importe As System.Windows.Forms.Label
    Friend WithEvents lbl_concepto As System.Windows.Forms.Label
    Friend WithEvents grid_Concepto As System.Windows.Forms.DataGridView
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_añadirConcepto As System.Windows.Forms.Button
    Friend WithEvents lbl_edificio As System.Windows.Forms.Label
    Friend WithEvents cmb_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_NumeroComprobante As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_Edificio As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Concepto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Importe As System.Windows.Forms.MaskedTextBox
End Class
