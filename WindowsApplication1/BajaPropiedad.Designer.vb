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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grid_grilla = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ID_DOMICILIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_INMUEBLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PROPIEDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Propiedad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(542, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(121, 19)
        Me.MaskedTextBox1.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(415, 20)
        Me.MaskedTextBox1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grid_grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(623, 210)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'grid_grilla
        '
        Me.grid_grilla.AllowUserToAddRows = False
        Me.grid_grilla.AllowUserToDeleteRows = False
        Me.grid_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_DOMICILIO, Me.ID_INMUEBLE, Me.ID_PROPIEDAD, Me.Domicilio, Me.designacion, Me.Eliminar})
        Me.grid_grilla.Location = New System.Drawing.Point(9, 19)
        Me.grid_grilla.Name = "grid_grilla"
        Me.grid_grilla.ReadOnly = True
        Me.grid_grilla.Size = New System.Drawing.Size(608, 185)
        Me.grid_grilla.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(560, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Aceptar"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Accion"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'BajaPropiedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 321)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BajaPropiedad"
        Me.Text = "Eliminar Datos de Propiedad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid_grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid_grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ID_DOMICILIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_INMUEBLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PROPIEDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents designacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
