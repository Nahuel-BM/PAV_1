<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Condicion_listado_Proveedores
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
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_condicionProveedor = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Location = New System.Drawing.Point(206, 87)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(99, 23)
        Me.btn_mostrar.TabIndex = 0
        Me.btn_mostrar.Text = "Mostrar Listado "
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Que sean de la Provincia:"
        '
        'txt_condicionProveedor
        '
        Me.txt_condicionProveedor.Location = New System.Drawing.Point(148, 48)
        Me.txt_condicionProveedor.Name = "txt_condicionProveedor"
        Me.txt_condicionProveedor.Size = New System.Drawing.Size(139, 20)
        Me.txt_condicionProveedor.TabIndex = 2
        '
        'Condicion_listado_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 122)
        Me.Controls.Add(Me.txt_condicionProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Name = "Condicion_listado_Proveedores"
        Me.Text = "Condicion_listado_Proveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mostrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_condicionProveedor As System.Windows.Forms.MaskedTextBox
End Class
