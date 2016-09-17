<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaPropiedad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_denominacionCatastral = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_resultadosBusqueda = New System.Windows.Forms.DataGridView()
        Me.ID_DOMICILIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_INMUEBLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PROPIEDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_tipoPropiedad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_resultadosBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_tipoPropiedad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_denominacionCatastral)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Propiedad"
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(542, 17)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_denominacionCatastral
        '
        Me.txt_denominacionCatastral.Location = New System.Drawing.Point(121, 19)
        Me.txt_denominacionCatastral.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Me.txt_denominacionCatastral.Name = "txt_denominacionCatastral"
        Me.txt_denominacionCatastral.Size = New System.Drawing.Size(199, 20)
        Me.txt_denominacionCatastral.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_resultadosBusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 210)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'grid_resultadosBusqueda
        '
        Me.grid_resultadosBusqueda.AllowUserToAddRows = False
        Me.grid_resultadosBusqueda.AllowUserToDeleteRows = False
        Me.grid_resultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_resultadosBusqueda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_DOMICILIO, Me.ID_INMUEBLE, Me.ID_PROPIEDAD, Me.Domicilio, Me.designacion})
        Me.grid_resultadosBusqueda.Location = New System.Drawing.Point(9, 19)
        Me.grid_resultadosBusqueda.Name = "grid_resultadosBusqueda"
        Me.grid_resultadosBusqueda.ReadOnly = True
        Me.grid_resultadosBusqueda.Size = New System.Drawing.Size(608, 185)
        Me.grid_resultadosBusqueda.TabIndex = 0
        '
        'ID_DOMICILIO
        '
        Me.ID_DOMICILIO.HeaderText = "id_domicilio"
        Me.ID_DOMICILIO.Name = "ID_DOMICILIO"
        Me.ID_DOMICILIO.ReadOnly = True
        Me.ID_DOMICILIO.Visible = False
        Me.ID_DOMICILIO.Width = 5
        '
        'ID_INMUEBLE
        '
        Me.ID_INMUEBLE.HeaderText = "id_inmueble"
        Me.ID_INMUEBLE.Name = "ID_INMUEBLE"
        Me.ID_INMUEBLE.ReadOnly = True
        Me.ID_INMUEBLE.Visible = False
        Me.ID_INMUEBLE.Width = 5
        '
        'ID_PROPIEDAD
        '
        Me.ID_PROPIEDAD.HeaderText = "id_propiedad"
        Me.ID_PROPIEDAD.Name = "ID_PROPIEDAD"
        Me.ID_PROPIEDAD.ReadOnly = True
        Me.ID_PROPIEDAD.Visible = False
        Me.ID_PROPIEDAD.Width = 5
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.Name = "Domicilio"
        Me.Domicilio.ReadOnly = True
        Me.Domicilio.Width = 300
        '
        'designacion
        '
        Me.designacion.HeaderText = "Designacion Catastral"
        Me.designacion.Name = "designacion"
        Me.designacion.ReadOnly = True
        Me.designacion.Width = 163
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(560, 288)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo Propiedad"
        '
        'cmb_tipoPropiedad
        '
        Me.cmb_tipoPropiedad.FormattingEnabled = True
        Me.cmb_tipoPropiedad.Location = New System.Drawing.Point(415, 19)
        Me.cmb_tipoPropiedad.Name = "cmb_tipoPropiedad"
        Me.cmb_tipoPropiedad.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipoPropiedad.TabIndex = 4
        '
        'BajaPropiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 321)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BajaPropiedad"
        Me.Text = "Eliminar Datos de Propiedad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_resultadosBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents txt_denominacionCatastral As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_resultadosBusqueda As System.Windows.Forms.DataGridView
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents ID_DOMICILIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_INMUEBLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PROPIEDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents designacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmb_tipoPropiedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
