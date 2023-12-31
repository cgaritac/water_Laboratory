<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.lblUsuarioTit = New System.Windows.Forms.Label()
        Me.pnlUsuario = New System.Windows.Forms.Panel()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnAccesoSalir = New System.Windows.Forms.Button()
        Me.btnAccesoIngresar = New System.Windows.Forms.Button()
        Me.lblUsuarioUsuario = New System.Windows.Forms.Label()
        Me.lblUsuarioContra = New System.Windows.Forms.Label()
        Me.lblUsuarioSis = New System.Windows.Forms.Label()
        Me.ptbUsuarioIm = New System.Windows.Forms.PictureBox()
        Me.ptbUsuarioFondo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlUsuario.SuspendLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbUsuarioFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuarioTit
        '
        Me.lblUsuarioTit.AutoSize = True
        Me.lblUsuarioTit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioTit.ForeColor = System.Drawing.Color.Blue
        Me.lblUsuarioTit.Location = New System.Drawing.Point(332, 135)
        Me.lblUsuarioTit.Name = "lblUsuarioTit"
        Me.lblUsuarioTit.Size = New System.Drawing.Size(158, 31)
        Me.lblUsuarioTit.TabIndex = 14
        Me.lblUsuarioTit.Text = "Bienvenido"
        '
        'pnlUsuario
        '
        Me.pnlUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlUsuario.Controls.Add(Me.txtUsuario)
        Me.pnlUsuario.Controls.Add(Me.txtContrasena)
        Me.pnlUsuario.Controls.Add(Me.btnAccesoSalir)
        Me.pnlUsuario.Controls.Add(Me.btnAccesoIngresar)
        Me.pnlUsuario.Controls.Add(Me.lblUsuarioUsuario)
        Me.pnlUsuario.Controls.Add(Me.lblUsuarioContra)
        Me.pnlUsuario.Location = New System.Drawing.Point(159, 192)
        Me.pnlUsuario.Name = "pnlUsuario"
        Me.pnlUsuario.Size = New System.Drawing.Size(487, 191)
        Me.pnlUsuario.TabIndex = 15
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(201, 29)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(247, 28)
        Me.txtUsuario.TabIndex = 0
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(201, 78)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(247, 28)
        Me.txtContrasena.TabIndex = 1
        '
        'btnAccesoSalir
        '
        Me.btnAccesoSalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAccesoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesoSalir.Location = New System.Drawing.Point(295, 138)
        Me.btnAccesoSalir.Name = "btnAccesoSalir"
        Me.btnAccesoSalir.Size = New System.Drawing.Size(119, 33)
        Me.btnAccesoSalir.TabIndex = 3
        Me.btnAccesoSalir.Text = "Salir"
        Me.btnAccesoSalir.UseVisualStyleBackColor = False
        '
        'btnAccesoIngresar
        '
        Me.btnAccesoIngresar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAccesoIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccesoIngresar.Location = New System.Drawing.Point(120, 138)
        Me.btnAccesoIngresar.Name = "btnAccesoIngresar"
        Me.btnAccesoIngresar.Size = New System.Drawing.Size(111, 33)
        Me.btnAccesoIngresar.TabIndex = 2
        Me.btnAccesoIngresar.Text = "Ingresar"
        Me.btnAccesoIngresar.UseVisualStyleBackColor = False
        '
        'lblUsuarioUsuario
        '
        Me.lblUsuarioUsuario.AutoSize = True
        Me.lblUsuarioUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioUsuario.Location = New System.Drawing.Point(52, 32)
        Me.lblUsuarioUsuario.Name = "lblUsuarioUsuario"
        Me.lblUsuarioUsuario.Size = New System.Drawing.Size(81, 24)
        Me.lblUsuarioUsuario.TabIndex = 4
        Me.lblUsuarioUsuario.Text = "Usuario"
        '
        'lblUsuarioContra
        '
        Me.lblUsuarioContra.AutoSize = True
        Me.lblUsuarioContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioContra.Location = New System.Drawing.Point(52, 81)
        Me.lblUsuarioContra.Name = "lblUsuarioContra"
        Me.lblUsuarioContra.Size = New System.Drawing.Size(116, 24)
        Me.lblUsuarioContra.TabIndex = 5
        Me.lblUsuarioContra.Text = "Contraseña"
        '
        'lblUsuarioSis
        '
        Me.lblUsuarioSis.AutoSize = True
        Me.lblUsuarioSis.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuarioSis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioSis.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblUsuarioSis.Location = New System.Drawing.Point(528, 51)
        Me.lblUsuarioSis.Name = "lblUsuarioSis"
        Me.lblUsuarioSis.Size = New System.Drawing.Size(243, 54)
        Me.lblUsuarioSis.TabIndex = 16
        Me.lblUsuarioSis.Text = "Sistema Control de Resultados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "              Versión 1.0.0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                     " &
    "2018"
        '
        'ptbUsuarioIm
        '
        Me.ptbUsuarioIm.BackColor = System.Drawing.Color.Azure
        Me.ptbUsuarioIm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbUsuarioIm.Image = Global.ProyectoVirtual2.My.Resources.Resources._451986_laci_marchetti_s_r_l_persona_con_un__tubo_de_ensayo_en_la_mano
        Me.ptbUsuarioIm.Location = New System.Drawing.Point(63, 25)
        Me.ptbUsuarioIm.Name = "ptbUsuarioIm"
        Me.ptbUsuarioIm.Size = New System.Drawing.Size(184, 127)
        Me.ptbUsuarioIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptbUsuarioIm.TabIndex = 13
        Me.ptbUsuarioIm.TabStop = False
        '
        'ptbUsuarioFondo
        '
        Me.ptbUsuarioFondo.BackColor = System.Drawing.Color.White
        Me.ptbUsuarioFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbUsuarioFondo.Image = Global.ProyectoVirtual2.My.Resources.Resources.depositphotos_40189333_stock_photo_futuristic_background
        Me.ptbUsuarioFondo.Location = New System.Drawing.Point(2, 1)
        Me.ptbUsuarioFondo.Name = "ptbUsuarioFondo"
        Me.ptbUsuarioFondo.Size = New System.Drawing.Size(796, 420)
        Me.ptbUsuarioFondo.TabIndex = 9
        Me.ptbUsuarioFondo.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 25)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 451)
        Me.Controls.Add(Me.lblUsuarioSis)
        Me.Controls.Add(Me.pnlUsuario)
        Me.Controls.Add(Me.lblUsuarioTit)
        Me.Controls.Add(Me.ptbUsuarioIm)
        Me.Controls.Add(Me.ptbUsuarioFondo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al sistema"
        Me.pnlUsuario.ResumeLayout(False)
        Me.pnlUsuario.PerformLayout()
        CType(Me.ptbUsuarioIm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbUsuarioFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ptbUsuarioFondo As PictureBox
    Friend WithEvents ptbUsuarioIm As PictureBox
    Friend WithEvents lblUsuarioTit As Label
    Friend WithEvents pnlUsuario As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnAccesoSalir As Button
    Friend WithEvents btnAccesoIngresar As Button
    Friend WithEvents lblUsuarioUsuario As Label
    Friend WithEvents lblUsuarioContra As Label
    Friend WithEvents lblUsuarioSis As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
