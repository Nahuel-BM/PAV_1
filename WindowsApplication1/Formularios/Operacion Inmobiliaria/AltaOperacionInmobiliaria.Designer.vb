﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fechaOp = New System.Windows.Forms.Label()
        Me.lbl_Pinterviniente = New System.Windows.Forms.Label()
        Me.cmb_tipoOperacion = New System.Windows.Forms.ComboBox()
        Me.lbl_tipoOp = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
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
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(122, 19)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(123, 20)
        Me.MaskedTextBox1.TabIndex = 0
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
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox6)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.cmb_estado)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_fechaOp)
        Me.GroupBox2.Controls.Add(Me.lbl_Pinterviniente)
        Me.GroupBox2.Controls.Add(Me.cmb_tipoOperacion)
        Me.GroupBox2.Controls.Add(Me.lbl_tipoOp)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 159)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Operacion"
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Enabled = False
        Me.MaskedTextBox6.Location = New System.Drawing.Point(394, 97)
        Me.MaskedTextBox6.Mask = "99999"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(144, 20)
        Me.MaskedTextBox6.TabIndex = 10
        Me.MaskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox6.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Enabled = False
        Me.MaskedTextBox5.Location = New System.Drawing.Point(394, 71)
        Me.MaskedTextBox5.Mask = "99999"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(144, 20)
        Me.MaskedTextBox5.TabIndex = 8
        Me.MaskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox5.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Enabled = False
        Me.MaskedTextBox4.Location = New System.Drawing.Point(135, 123)
        Me.MaskedTextBox4.Mask = "99999"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(144, 20)
        Me.MaskedTextBox4.TabIndex = 11
        Me.MaskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox4.ValidatingType = GetType(Integer)
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Enabled = False
        Me.MaskedTextBox3.Location = New System.Drawing.Point(135, 97)
        Me.MaskedTextBox3.Mask = "00/00/0000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(144, 20)
        Me.MaskedTextBox3.TabIndex = 9
        Me.MaskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox3.ValidatingType = GetType(Date)
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(135, 45)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Enabled = False
        Me.MaskedTextBox2.Location = New System.Drawing.Point(135, 71)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(144, 20)
        Me.MaskedTextBox2.TabIndex = 7
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(394, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 6
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
        Me.Label10.Location = New System.Drawing.Point(308, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Escribano"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 100)
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
        Me.Label6.Location = New System.Drawing.Point(6, 126)
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
        Me.lbl_fechaOp.Location = New System.Drawing.Point(6, 74)
        Me.lbl_fechaOp.Name = "lbl_fechaOp"
        Me.lbl_fechaOp.Size = New System.Drawing.Size(89, 13)
        Me.lbl_fechaOp.TabIndex = 4
        Me.lbl_fechaOp.Text = "Fecha Operacion"
        '
        'lbl_Pinterviniente
        '
        Me.lbl_Pinterviniente.AutoSize = True
        Me.lbl_Pinterviniente.Location = New System.Drawing.Point(6, 48)
        Me.lbl_Pinterviniente.Name = "lbl_Pinterviniente"
        Me.lbl_Pinterviniente.Size = New System.Drawing.Size(107, 13)
        Me.lbl_Pinterviniente.TabIndex = 2
        Me.lbl_Pinterviniente.Text = "Persona Interviniente"
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
        Me.GroupBox3.Controls.Add(Me.Label12)
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(119, 73)
        Me.Label12.MinimumSize = New System.Drawing.Size(50, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 6
        '
        'lbl_superficie
        '
        Me.lbl_superficie.AutoSize = True
        Me.lbl_superficie.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_superficie.Location = New System.Drawing.Point(119, 51)
        Me.lbl_superficie.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.Name = "lbl_superficie"
        Me.lbl_superficie.Size = New System.Drawing.Size(50, 13)
        Me.lbl_superficie.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Superficie:"
        '
        'lbl_tipoPropiedad
        '
        Me.lbl_tipoPropiedad.AutoSize = True
        Me.lbl_tipoPropiedad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_tipoPropiedad.Location = New System.Drawing.Point(119, 29)
        Me.lbl_tipoPropiedad.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_tipoPropiedad.Name = "lbl_tipoPropiedad"
        Me.lbl_tipoPropiedad.Size = New System.Drawing.Size(50, 13)
        Me.lbl_tipoPropiedad.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo de Propiedad:"
        '
        'lbl_domicilio
        '
        Me.lbl_domicilio.AutoSize = True
        Me.lbl_domicilio.Location = New System.Drawing.Point(119, 29)
        Me.lbl_domicilio.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.Name = "lbl_domicilio"
        Me.lbl_domicilio.Size = New System.Drawing.Size(50, 13)
        Me.lbl_domicilio.TabIndex = 1
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
        Me.btn_aceptar.Location = New System.Drawing.Point(430, 342)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(120, 23)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Aceptar Operacion"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(21, 342)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 13
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'AltaOperacionInmobiliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 373)
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
    Friend WithEvents lbl_fechaOp As System.Windows.Forms.Label
    Friend WithEvents lbl_Pinterviniente As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBox6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
