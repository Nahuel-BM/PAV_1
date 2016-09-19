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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_proveedor = New System.Windows.Forms.Label()
        Me.lbl_comprobanteNº = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.lbl_concepto = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_añadirConcepto = New System.Windows.Forms.Button()
        Me.lbl_edificio = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmb_proveedor = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_altaGasto
        '
        Me.btn_altaGasto.Location = New System.Drawing.Point(333, 368)
        Me.btn_altaGasto.Name = "btn_altaGasto"
        Me.btn_altaGasto.Size = New System.Drawing.Size(75, 23)
        Me.btn_altaGasto.TabIndex = 0
        Me.btn_altaGasto.Text = "Crear Gasto"
        Me.btn_altaGasto.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(7, 368)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(12, 16)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(37, 13)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Fecha"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 3
        '
        'lbl_proveedor
        '
        Me.lbl_proveedor.AutoSize = True
        Me.lbl_proveedor.Location = New System.Drawing.Point(197, 16)
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(103, 54)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(79, 304)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(126, 20)
        Me.TextBox4.TabIndex = 8
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
        Me.lbl_concepto.Location = New System.Drawing.Point(4, 128)
        Me.lbl_concepto.Name = "lbl_concepto"
        Me.lbl_concepto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_concepto.TabIndex = 10
        Me.lbl_concepto.Text = "Concepto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.concepto, Me.Importe})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(386, 104)
        Me.DataGridView1.TabIndex = 11
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
        Me.btn_añadirConcepto.Location = New System.Drawing.Point(289, 265)
        Me.btn_añadirConcepto.Name = "btn_añadirConcepto"
        Me.btn_añadirConcepto.Size = New System.Drawing.Size(104, 23)
        Me.btn_añadirConcepto.TabIndex = 12
        Me.btn_añadirConcepto.Text = "Añadir Concepto"
        Me.btn_añadirConcepto.UseVisualStyleBackColor = True
        '
        'lbl_edificio
        '
        Me.lbl_edificio.AutoSize = True
        Me.lbl_edificio.Location = New System.Drawing.Point(12, 92)
        Me.lbl_edificio.Name = "lbl_edificio"
        Me.lbl_edificio.Size = New System.Drawing.Size(41, 13)
        Me.lbl_edificio.TabIndex = 13
        Me.lbl_edificio.Text = "Edificio"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(60, 89)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'cmb_proveedor
        '
        Me.cmb_proveedor.BackColor = System.Drawing.SystemColors.Window
        Me.cmb_proveedor.FormattingEnabled = True
        Me.cmb_proveedor.Location = New System.Drawing.Point(259, 12)
        Me.cmb_proveedor.Name = "cmb_proveedor"
        Me.cmb_proveedor.Size = New System.Drawing.Size(149, 21)
        Me.cmb_proveedor.TabIndex = 33
        '
        'AltaGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 403)
        Me.Controls.Add(Me.cmb_proveedor)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_edificio)
        Me.Controls.Add(Me.btn_añadirConcepto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_concepto)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lbl_comprobanteNº)
        Me.Controls.Add(Me.lbl_proveedor)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_altaGasto)
        Me.Name = "AltaGastos"
        Me.Text = "AltaGastos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_altaGasto As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_fecha As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_proveedor As System.Windows.Forms.Label
    Friend WithEvents lbl_comprobanteNº As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_importe As System.Windows.Forms.Label
    Friend WithEvents lbl_concepto As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_añadirConcepto As System.Windows.Forms.Button
    Friend WithEvents lbl_edificio As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_proveedor As System.Windows.Forms.ComboBox
End Class
