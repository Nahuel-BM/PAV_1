<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Condicion_listado_operacionInmobiliaria
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
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_condicionMonto = New System.Windows.Forms.MaskedTextBox()
        Me.txt_Comision = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Location = New System.Drawing.Point(301, 131)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(95, 23)
        Me.btn_Mostrar.TabIndex = 0
        Me.btn_Mostrar.Text = "Mostrar Listado"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operaciones con Monto Mensual Menor a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Operacion con Comision Mayor a:"
        '
        'txt_condicionMonto
        '
        Me.txt_condicionMonto.Location = New System.Drawing.Point(228, 33)
        Me.txt_condicionMonto.Mask = "9999999"
        Me.txt_condicionMonto.Name = "txt_condicionMonto"
        Me.txt_condicionMonto.Size = New System.Drawing.Size(104, 20)
        Me.txt_condicionMonto.TabIndex = 3
        '
        'txt_Comision
        '
        Me.txt_Comision.Location = New System.Drawing.Point(228, 76)
        Me.txt_Comision.Mask = "9999999"
        Me.txt_Comision.Name = "txt_Comision"
        Me.txt_Comision.Size = New System.Drawing.Size(104, 20)
        Me.txt_Comision.TabIndex = 4
        '
        'Condicion_listado_operacionInmobiliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 161)
        Me.Controls.Add(Me.txt_Comision)
        Me.Controls.Add(Me.txt_condicionMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Name = "Condicion_listado_operacionInmobiliaria"
        Me.Text = "Condicion_listado_operacionInmobiliaria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_condicionMonto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Comision As System.Windows.Forms.MaskedTextBox
End Class
