﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicial
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPropiedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaPropiedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MdoficarPropiedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPropiedadesPorLocalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarPropiedadesPorTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionInmobiliariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaOperacionInmobiliariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaOperacionInmobiliariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarOperacionInmobiliariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarOperacionInmobiliariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GAstosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.PersonasToolStripMenuItem, Me.OperacionInmobiliariaToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.GAstosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPropiedadToolStripMenuItem, Me.BajaPropiedadToolStripMenuItem, Me.MdoficarPropiedadToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.EstadisticasToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.ToolStripMenuItem1.Text = "Propiedad"
        '
        'AltaPropiedadToolStripMenuItem
        '
        Me.AltaPropiedadToolStripMenuItem.Name = "AltaPropiedadToolStripMenuItem"
        Me.AltaPropiedadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AltaPropiedadToolStripMenuItem.Text = "Alta Propiedad"
        '
        'BajaPropiedadToolStripMenuItem
        '
        Me.BajaPropiedadToolStripMenuItem.Name = "BajaPropiedadToolStripMenuItem"
        Me.BajaPropiedadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BajaPropiedadToolStripMenuItem.Text = "Baja Propiedad"
        '
        'MdoficarPropiedadToolStripMenuItem
        '
        Me.MdoficarPropiedadToolStripMenuItem.Name = "MdoficarPropiedadToolStripMenuItem"
        Me.MdoficarPropiedadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.MdoficarPropiedadToolStripMenuItem.Text = "Modificar Propiedad"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarPropiedadesPorLocalidadToolStripMenuItem, Me.ListarPropiedadesPorTipoToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ListarPropiedadesPorLocalidadToolStripMenuItem
        '
        Me.ListarPropiedadesPorLocalidadToolStripMenuItem.Name = "ListarPropiedadesPorLocalidadToolStripMenuItem"
        Me.ListarPropiedadesPorLocalidadToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ListarPropiedadesPorLocalidadToolStripMenuItem.Text = "Listar Propiedades por Localidad"
        '
        'ListarPropiedadesPorTipoToolStripMenuItem
        '
        Me.ListarPropiedadesPorTipoToolStripMenuItem.Name = "ListarPropiedadesPorTipoToolStripMenuItem"
        Me.ListarPropiedadesPorTipoToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ListarPropiedadesPorTipoToolStripMenuItem.Text = "Listar Propiedades por Tipo"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaPersonaToolStripMenuItem, Me.BajaPersonaToolStripMenuItem, Me.ModificarPersonaToolStripMenuItem})
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PersonasToolStripMenuItem.Text = "Persona"
        '
        'AltaPersonaToolStripMenuItem
        '
        Me.AltaPersonaToolStripMenuItem.Name = "AltaPersonaToolStripMenuItem"
        Me.AltaPersonaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AltaPersonaToolStripMenuItem.Text = "Nueva Persona"
        '
        'BajaPersonaToolStripMenuItem
        '
        Me.BajaPersonaToolStripMenuItem.Name = "BajaPersonaToolStripMenuItem"
        Me.BajaPersonaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BajaPersonaToolStripMenuItem.Text = "Baja Persona"
        '
        'ModificarPersonaToolStripMenuItem
        '
        Me.ModificarPersonaToolStripMenuItem.Name = "ModificarPersonaToolStripMenuItem"
        Me.ModificarPersonaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ModificarPersonaToolStripMenuItem.Text = "Modificar Persona"
        '
        'OperacionInmobiliariaToolStripMenuItem
        '
        Me.OperacionInmobiliariaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaOperacionInmobiliariaToolStripMenuItem, Me.BajaOperacionInmobiliariaToolStripMenuItem, Me.ConsultarOperacionInmobiliariaToolStripMenuItem, Me.ModificarOperacionInmobiliariaToolStripMenuItem})
        Me.OperacionInmobiliariaToolStripMenuItem.Name = "OperacionInmobiliariaToolStripMenuItem"
        Me.OperacionInmobiliariaToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.OperacionInmobiliariaToolStripMenuItem.Text = "Operacion Inmobiliaria"
        '
        'AltaOperacionInmobiliariaToolStripMenuItem
        '
        Me.AltaOperacionInmobiliariaToolStripMenuItem.Name = "AltaOperacionInmobiliariaToolStripMenuItem"
        Me.AltaOperacionInmobiliariaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.AltaOperacionInmobiliariaToolStripMenuItem.Text = "Alta Operacion Inmobiliaria"
        '
        'BajaOperacionInmobiliariaToolStripMenuItem
        '
        Me.BajaOperacionInmobiliariaToolStripMenuItem.Name = "BajaOperacionInmobiliariaToolStripMenuItem"
        Me.BajaOperacionInmobiliariaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.BajaOperacionInmobiliariaToolStripMenuItem.Text = "Baja Operacion Inmobiliaria"
        '
        'ConsultarOperacionInmobiliariaToolStripMenuItem
        '
        Me.ConsultarOperacionInmobiliariaToolStripMenuItem.Name = "ConsultarOperacionInmobiliariaToolStripMenuItem"
        Me.ConsultarOperacionInmobiliariaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ConsultarOperacionInmobiliariaToolStripMenuItem.Text = "Consultar Operacion inmobiliaria"
        '
        'ModificarOperacionInmobiliariaToolStripMenuItem
        '
        Me.ModificarOperacionInmobiliariaToolStripMenuItem.Name = "ModificarOperacionInmobiliariaToolStripMenuItem"
        Me.ModificarOperacionInmobiliariaToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ModificarOperacionInmobiliariaToolStripMenuItem.Text = "Modificar Operacion Inmobiliaria"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'GAstosToolStripMenuItem
        '
        Me.GAstosToolStripMenuItem.Name = "GAstosToolStripMenuItem"
        Me.GAstosToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.GAstosToolStripMenuItem.Text = "Gastos"
        '
        'Inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Grupo_Edisur.My.Resources.Resources.edisur
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(640, 385)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicial"
        Me.Text = "Inicial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionInmobiliariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GAstosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaPropiedadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaPropiedadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MdoficarPropiedadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarPropiedadesPorLocalidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarPropiedadesPorTipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    '<<<<< HEAD
    Friend WithEvents AltaPersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaPersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarPersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaOperacionInmobiliariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BajaOperacionInmobiliariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarOperacionInmobiliariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarOperacionInmobiliariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    '=======
    '>>>>>>> master
End Class
