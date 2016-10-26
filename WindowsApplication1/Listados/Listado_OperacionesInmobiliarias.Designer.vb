<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado_OperacionesInmobiliarias
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
        Me.OperacionInmobiliariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Grupo_Edisur.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_monto = New System.Windows.Forms.Label()
        Me.lbl_comision = New System.Windows.Forms.Label()
        CType(Me.OperacionInmobiliariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OperacionInmobiliariaBindingSource
        '
        Me.OperacionInmobiliariaBindingSource.DataMember = "Operacion_Inmobiliaria"
        Me.OperacionInmobiliariaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.OperacionInmobiliariaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Lista_OperacionesInmobiliarias.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(810, 494)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataMember = "Operacion_Inmobiliaria"
        Me.DataSet1BindingSource.DataSource = GetType(Grupo_Edisur.DataSet1)
        '
        'lbl_monto
        '
        Me.lbl_monto.AutoSize = True
        Me.lbl_monto.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_monto.Location = New System.Drawing.Point(822, 66)
        Me.lbl_monto.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_monto.Name = "lbl_monto"
        Me.lbl_monto.Size = New System.Drawing.Size(50, 13)
        Me.lbl_monto.TabIndex = 4
        '
        'lbl_comision
        '
        Me.lbl_comision.AutoSize = True
        Me.lbl_comision.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_comision.Location = New System.Drawing.Point(832, 156)
        Me.lbl_comision.MinimumSize = New System.Drawing.Size(50, 13)
        Me.lbl_comision.Name = "lbl_comision"
        Me.lbl_comision.Size = New System.Drawing.Size(50, 13)
        Me.lbl_comision.TabIndex = 5
        '
        'Listado_OperacionesInmobiliarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 518)
        Me.Controls.Add(Me.lbl_comision)
        Me.Controls.Add(Me.lbl_monto)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Listado_OperacionesInmobiliarias"
        Me.Text = "Listado_OperacionesInmobiliarias"
        CType(Me.OperacionInmobiliariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OperacionInmobiliariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Grupo_Edisur.DataSet1
    Friend WithEvents lbl_monto As System.Windows.Forms.Label
    Friend WithEvents lbl_comision As System.Windows.Forms.Label
End Class
