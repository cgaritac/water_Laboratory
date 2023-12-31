<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPadreMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControlMuestras = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMuestrasPotable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuControlResultados = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResultadosPotable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVentanas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOrganizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpciones, Me.mnuVentanas, Me.mnuSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.mnuVentanas
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(10, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(1332, 30)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuOpciones
        '
        Me.mnuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuControlMuestras, Me.mnuControlResultados})
        Me.mnuOpciones.Name = "mnuOpciones"
        Me.mnuOpciones.Size = New System.Drawing.Size(83, 24)
        Me.mnuOpciones.Text = "Opciones"
        '
        'mnuControlMuestras
        '
        Me.mnuControlMuestras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnuControlMuestras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMuestrasPotable})
        Me.mnuControlMuestras.Image = Global.ProyectoVirtual2.My.Resources.Resources.kisspng_chemistry_test_tubes_laboratory_glassware_laborato_laboratory_5abf621e3e4a49_0221010115224919342552
        Me.mnuControlMuestras.Name = "mnuControlMuestras"
        Me.mnuControlMuestras.Size = New System.Drawing.Size(230, 26)
        Me.mnuControlMuestras.Text = "Control de Muestras"
        '
        'mnuMuestrasPotable
        '
        Me.mnuMuestrasPotable.Image = Global.ProyectoVirtual2.My.Resources.Resources.Aguapatable
        Me.mnuMuestrasPotable.Name = "mnuMuestrasPotable"
        Me.mnuMuestrasPotable.Size = New System.Drawing.Size(173, 26)
        Me.mnuMuestrasPotable.Text = "Agua Potable"
        '
        'mnuControlResultados
        '
        Me.mnuControlResultados.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResultadosPotable})
        Me.mnuControlResultados.Image = Global.ProyectoVirtual2.My.Resources.Resources.laboratorio
        Me.mnuControlResultados.Name = "mnuControlResultados"
        Me.mnuControlResultados.Size = New System.Drawing.Size(230, 26)
        Me.mnuControlResultados.Text = "Control de Resultados"
        '
        'mnuResultadosPotable
        '
        Me.mnuResultadosPotable.Image = Global.ProyectoVirtual2.My.Resources.Resources.Aguapatable
        Me.mnuResultadosPotable.Name = "mnuResultadosPotable"
        Me.mnuResultadosPotable.Size = New System.Drawing.Size(173, 26)
        Me.mnuResultadosPotable.Text = "Agua Potable"
        '
        'mnuVentanas
        '
        Me.mnuVentanas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCascada, Me.mnuVertical, Me.mnuHorizontal, Me.mnuOrganizar})
        Me.mnuVentanas.Name = "mnuVentanas"
        Me.mnuVentanas.Size = New System.Drawing.Size(80, 24)
        Me.mnuVentanas.Text = "&Ventanas"
        '
        'mnuCascada
        '
        Me.mnuCascada.Name = "mnuCascada"
        Me.mnuCascada.Size = New System.Drawing.Size(211, 26)
        Me.mnuCascada.Text = "&Cascada"
        '
        'mnuVertical
        '
        Me.mnuVertical.Name = "mnuVertical"
        Me.mnuVertical.Size = New System.Drawing.Size(211, 26)
        Me.mnuVertical.Text = "Mosaico &vertical"
        '
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(211, 26)
        Me.mnuHorizontal.Text = "Mosaico &horizontal"
        '
        'mnuOrganizar
        '
        Me.mnuOrganizar.Name = "mnuOrganizar"
        Me.mnuOrganizar.Size = New System.Drawing.Size(211, 26)
        Me.mnuOrganizar.Text = "&Organizar iconos"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(50, 24)
        Me.mnuSalir.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 778)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 24, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1332, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'FrmPadreMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1332, 803)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "FrmPadreMenu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventana principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuOrganizar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVentanas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuOpciones As ToolStripMenuItem
    Friend WithEvents mnuControlMuestras As ToolStripMenuItem
    Friend WithEvents mnuMuestrasPotable As ToolStripMenuItem
    Friend WithEvents mnuControlResultados As ToolStripMenuItem
    Friend WithEvents mnuResultadosPotable As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
