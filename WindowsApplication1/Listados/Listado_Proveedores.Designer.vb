<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_Proveedores
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Grupo_Edisur.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lbl_condProveedor = New System.Windows.Forms.Label()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "Proveedor"
        Me.ProveedorBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProveedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Lista_Proveedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(727, 467)
        Me.ReportViewer1.TabIndex = 0
        '
        'lbl_condProveedor
        '
        Me.lbl_condProveedor.AutoSize = True
        Me.lbl_condProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_condProveedor.Location = New System.Drawing.Point(85, 531)
        Me.lbl_condProveedor.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_condProveedor.Name = "lbl_condProveedor"
        Me.lbl_condProveedor.Size = New System.Drawing.Size(50, 13)
        Me.lbl_condProveedor.TabIndex = 20
        '
        'Listado_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 491)
        Me.Controls.Add(Me.lbl_condProveedor)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Listado_Proveedores"
        Me.Text = "Listado de Proveedores"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Grupo_Edisur.DataSet1
    Friend WithEvents lbl_condProveedor As System.Windows.Forms.Label
End Class
