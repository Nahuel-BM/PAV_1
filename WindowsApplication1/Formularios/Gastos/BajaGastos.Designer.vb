<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaGastos
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lbl_comprobanteNº = New System.Windows.Forms.Label()
        Me.grid_resultadosBusqueda = New System.Windows.Forms.DataGridView()
        Me.id_gasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nro_comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_buscarComprobante = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        CType(Me.grid_resultadosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(103, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 20)
        Me.TextBox3.TabIndex = 9
        '
        'lbl_comprobanteNº
        '
        Me.lbl_comprobanteNº.AutoSize = True
        Me.lbl_comprobanteNº.Location = New System.Drawing.Point(12, 19)
        Me.lbl_comprobanteNº.Name = "lbl_comprobanteNº"
        Me.lbl_comprobanteNº.Size = New System.Drawing.Size(85, 13)
        Me.lbl_comprobanteNº.TabIndex = 8
        Me.lbl_comprobanteNº.Text = "Comprobante Nº"
        '
        'grid_resultadosBusqueda
        '
        Me.grid_resultadosBusqueda.AllowUserToAddRows = False
        Me.grid_resultadosBusqueda.AllowUserToDeleteRows = False
        Me.grid_resultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_resultadosBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_gasto, Me.nro_comprobante, Me.Gasto, Me.Importe})
        Me.grid_resultadosBusqueda.Location = New System.Drawing.Point(12, 54)
        Me.grid_resultadosBusqueda.Name = "grid_resultadosBusqueda"
        Me.grid_resultadosBusqueda.ReadOnly = True
        Me.grid_resultadosBusqueda.Size = New System.Drawing.Size(486, 185)
        Me.grid_resultadosBusqueda.TabIndex = 10
        '
        'id_gasto
        '
        Me.id_gasto.HeaderText = "id_gasto"
        Me.id_gasto.Name = "id_gasto"
        Me.id_gasto.ReadOnly = True
        Me.id_gasto.Visible = False
        '
        'nro_comprobante
        '
        Me.nro_comprobante.HeaderText = "Nº comprobante"
        Me.nro_comprobante.Name = "nro_comprobante"
        Me.nro_comprobante.ReadOnly = True
        '
        'Gasto
        '
        Me.Gasto.HeaderText = "Gasto"
        Me.Gasto.Name = "Gasto"
        Me.Gasto.ReadOnly = True
        Me.Gasto.Width = 200
        '
        'Importe
        '
        Me.Importe.HeaderText = "importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(22, 256)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 18
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscarComprobante
        '
        Me.btn_buscarComprobante.Location = New System.Drawing.Point(275, 14)
        Me.btn_buscarComprobante.Name = "btn_buscarComprobante"
        Me.btn_buscarComprobante.Size = New System.Drawing.Size(147, 23)
        Me.btn_buscarComprobante.TabIndex = 17
        Me.btn_buscarComprobante.Text = "Buscar Comprobante"
        Me.btn_buscarComprobante.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(371, 256)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(127, 23)
        Me.btn_confirmar.TabIndex = 19
        Me.btn_confirmar.Text = "Confirmar Eliminacion"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'BajaGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 291)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscarComprobante)
        Me.Controls.Add(Me.grid_resultadosBusqueda)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lbl_comprobanteNº)
        Me.Name = "BajaGastos"
        Me.Text = "BajaGastos"
        CType(Me.grid_resultadosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_comprobanteNº As System.Windows.Forms.Label
    Friend WithEvents grid_resultadosBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents id_gasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nro_comprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Gasto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscarComprobante As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
End Class
