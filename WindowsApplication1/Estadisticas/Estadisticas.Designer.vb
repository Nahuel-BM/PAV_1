﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadisticas
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EstadisticasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstadisticas = New Grupo_Edisur.DataSetEstadisticas()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EstadisticaStringBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropiedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EstadisticasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.EstadisticaStringBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstadisticasBindingSource
        '
        Me.EstadisticasBindingSource.DataMember = "Estadisticas"
        Me.EstadisticasBindingSource.DataSource = Me.DataSetEstadisticas
        '
        'DataSetEstadisticas
        '
        Me.DataSetEstadisticas.DataSetName = "DataSetEstadisticas"
        Me.DataSetEstadisticas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Location = New System.Drawing.Point(4, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(812, 539)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(804, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PropiedadxSuperficie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.EstadisticasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_PropiedadxSuperficie.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 6)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(797, 501)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(804, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PropiedadxMonto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.EstadisticasBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_PropiedadxMonto.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(7, 7)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(794, 500)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(804, 513)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "OperacionInmobiliariaxMontoMensual"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.EstadisticasBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_OpInmobiliariaxMontoMensual.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(12, 6)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(786, 504)
        Me.ReportViewer3.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(804, 513)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "OperacionInmobiliariaxComision"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.EstadisticasBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_OpInmobiliariaxComision.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(5, 7)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(799, 469)
        Me.ReportViewer4.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(804, 513)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "OperacionInmobiliariaxDuracion"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.EstadisticasBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_OperacioxPropiedad.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(6, 6)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(791, 501)
        Me.ReportViewer5.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(804, 513)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "GastosxImporte"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.EstadisticasBindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_GastosxImporte.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(0, 6)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(801, 501)
        Me.ReportViewer6.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.ReportViewer7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(804, 513)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "FacturaxImporte"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'ReportViewer7
        '
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.EstadisticasBindingSource
        Me.ReportViewer7.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer7.LocalReport.ReportEmbeddedResource = "Grupo_Edisur.Estadistica_FacturaxMonto.rdlc"
        Me.ReportViewer7.Location = New System.Drawing.Point(12, 6)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.Size = New System.Drawing.Size(789, 504)
        Me.ReportViewer7.TabIndex = 0
        '
        'EstadisticaStringBindingSource
        '
        Me.EstadisticaStringBindingSource.DataMember = "EstadisticaString"
        Me.EstadisticaStringBindingSource.DataSource = Me.DataSetEstadisticas
        '
        'PropiedadBindingSource
        '
        Me.PropiedadBindingSource.DataMember = "Propiedad"
        Me.PropiedadBindingSource.DataSource = Me.DataSetEstadisticas
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 555)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        CType(Me.EstadisticasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        CType(Me.EstadisticaStringBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents PropiedadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetEstadisticas As Grupo_Edisur.DataSetEstadisticas
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadisticasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EstadisticaStringBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
End Class
