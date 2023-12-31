<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMuestrasPotable
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpiarS = New System.Windows.Forms.Button()
        Me.btnEliminarS = New System.Windows.Forms.Button()
        Me.btnBuscarS = New System.Windows.Forms.Button()
        Me.btnGuardarS = New System.Windows.Forms.Button()
        Me.dgvSalida = New System.Windows.Forms.DataGridView()
        Me.CodigoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prestador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sistema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Urgente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtObservacionesS = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSistemaS = New System.Windows.Forms.TextBox()
        Me.txtCorClienteS = New System.Windows.Forms.TextBox()
        Me.txtTelClienteS = New System.Windows.Forms.TextBox()
        Me.txtClienteS = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.txtCodigoMS = New System.Windows.Forms.TextBox()
        Me.cbPestadorS = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFQS = New System.Windows.Forms.CheckBox()
        Me.chkMicrobS = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpFechaS = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tvPruebas = New System.Windows.Forms.TreeView()
        Me.btnLimpiarE = New System.Windows.Forms.Button()
        Me.btnEliminarE = New System.Windows.Forms.Button()
        Me.btnBuscarE = New System.Windows.Forms.Button()
        Me.btnGuardarE = New System.Windows.Forms.Button()
        Me.dgvEntrada = New System.Windows.Forms.DataGridView()
        Me.txtObservacionesE = New System.Windows.Forms.TextBox()
        Me.txtNombrePuntoM = New System.Windows.Forms.TextBox()
        Me.txtMuestreador = New System.Windows.Forms.TextBox()
        Me.txtCodigoME = New System.Windows.Forms.TextBox()
        Me.cbPuntoMuestreo = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chklPruebas = New System.Windows.Forms.CheckedListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpFechaE = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaM = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CodigoM2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PuntoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePuntoM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pruebas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label22.Location = New System.Drawing.Point(446, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(391, 39)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Muestras Agua Potable"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1258, 864)
        Me.TabControl1.TabIndex = 49
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnLimpiarS)
        Me.TabPage1.Controls.Add(Me.btnEliminarS)
        Me.TabPage1.Controls.Add(Me.btnBuscarS)
        Me.TabPage1.Controls.Add(Me.btnGuardarS)
        Me.TabPage1.Controls.Add(Me.dgvSalida)
        Me.TabPage1.Controls.Add(Me.txtObservacionesS)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtSistemaS)
        Me.TabPage1.Controls.Add(Me.txtCorClienteS)
        Me.TabPage1.Controls.Add(Me.txtTelClienteS)
        Me.TabPage1.Controls.Add(Me.txtClienteS)
        Me.TabPage1.Controls.Add(Me.txtResponsable)
        Me.TabPage1.Controls.Add(Me.txtCodigoMS)
        Me.TabPage1.Controls.Add(Me.cbPestadorS)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1250, 829)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Salida para muestreo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(899, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Nota: 8 dígitos sin guiones ni espacios"
        '
        'btnLimpiarS
        '
        Me.btnLimpiarS.Location = New System.Drawing.Point(1100, 488)
        Me.btnLimpiarS.Name = "btnLimpiarS"
        Me.btnLimpiarS.Size = New System.Drawing.Size(94, 36)
        Me.btnLimpiarS.TabIndex = 78
        Me.btnLimpiarS.Text = "Limpiar"
        Me.btnLimpiarS.UseVisualStyleBackColor = True
        '
        'btnEliminarS
        '
        Me.btnEliminarS.Location = New System.Drawing.Point(972, 488)
        Me.btnEliminarS.Name = "btnEliminarS"
        Me.btnEliminarS.Size = New System.Drawing.Size(102, 36)
        Me.btnEliminarS.TabIndex = 77
        Me.btnEliminarS.Text = "Eliminar"
        Me.btnEliminarS.UseVisualStyleBackColor = True
        '
        'btnBuscarS
        '
        Me.btnBuscarS.Location = New System.Drawing.Point(724, 488)
        Me.btnBuscarS.Name = "btnBuscarS"
        Me.btnBuscarS.Size = New System.Drawing.Size(97, 36)
        Me.btnBuscarS.TabIndex = 75
        Me.btnBuscarS.Text = "Buscar"
        Me.btnBuscarS.UseVisualStyleBackColor = True
        '
        'btnGuardarS
        '
        Me.btnGuardarS.Location = New System.Drawing.Point(602, 488)
        Me.btnGuardarS.Name = "btnGuardarS"
        Me.btnGuardarS.Size = New System.Drawing.Size(99, 36)
        Me.btnGuardarS.TabIndex = 74
        Me.btnGuardarS.Text = "Guardar"
        Me.btnGuardarS.UseVisualStyleBackColor = True
        '
        'dgvSalida
        '
        Me.dgvSalida.AllowUserToAddRows = False
        Me.dgvSalida.AllowUserToDeleteRows = False
        Me.dgvSalida.AllowUserToResizeColumns = False
        Me.dgvSalida.AllowUserToResizeRows = False
        Me.dgvSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoM, Me.FechaS, Me.Responsable, Me.TipoEq, Me.Cliente, Me.TelCliente, Me.CorreoCliente, Me.Prestador, Me.Sistema, Me.Urgente, Me.Observaciones})
        Me.dgvSalida.Location = New System.Drawing.Point(26, 540)
        Me.dgvSalida.Name = "dgvSalida"
        Me.dgvSalida.RowHeadersVisible = False
        Me.dgvSalida.RowTemplate.Height = 24
        Me.dgvSalida.Size = New System.Drawing.Size(1203, 228)
        Me.dgvSalida.TabIndex = 73
        '
        'CodigoM
        '
        Me.CodigoM.HeaderText = "Código Muestreo"
        Me.CodigoM.Name = "CodigoM"
        '
        'FechaS
        '
        Me.FechaS.HeaderText = "Fecha Salida"
        Me.FechaS.Name = "FechaS"
        '
        'Responsable
        '
        Me.Responsable.HeaderText = "Responsable"
        Me.Responsable.Name = "Responsable"
        '
        'TipoEq
        '
        Me.TipoEq.HeaderText = "Tipo Equipo"
        Me.TipoEq.Name = "TipoEq"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'TelCliente
        '
        Me.TelCliente.HeaderText = "Teléfono Cliente"
        Me.TelCliente.Name = "TelCliente"
        '
        'CorreoCliente
        '
        Me.CorreoCliente.HeaderText = "Correo Cliente"
        Me.CorreoCliente.Name = "CorreoCliente"
        '
        'Prestador
        '
        Me.Prestador.HeaderText = "Prestador"
        Me.Prestador.Name = "Prestador"
        '
        'Sistema
        '
        Me.Sistema.HeaderText = "Sistema"
        Me.Sistema.Name = "Sistema"
        '
        'Urgente
        '
        Me.Urgente.HeaderText = "Urgente"
        Me.Urgente.Name = "Urgente"
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        '
        'txtObservacionesS
        '
        Me.txtObservacionesS.Location = New System.Drawing.Point(727, 331)
        Me.txtObservacionesS.Multiline = True
        Me.txtObservacionesS.Name = "txtObservacionesS"
        Me.txtObservacionesS.Size = New System.Drawing.Size(502, 112)
        Me.txtObservacionesS.TabIndex = 72
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(538, 334)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(142, 24)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Observaciones:"
        '
        'txtSistemaS
        '
        Me.txtSistemaS.Location = New System.Drawing.Point(727, 259)
        Me.txtSistemaS.Name = "txtSistemaS"
        Me.txtSistemaS.Size = New System.Drawing.Size(158, 28)
        Me.txtSistemaS.TabIndex = 69
        '
        'txtCorClienteS
        '
        Me.txtCorClienteS.Location = New System.Drawing.Point(727, 144)
        Me.txtCorClienteS.Name = "txtCorClienteS"
        Me.txtCorClienteS.Size = New System.Drawing.Size(166, 28)
        Me.txtCorClienteS.TabIndex = 68
        '
        'txtTelClienteS
        '
        Me.txtTelClienteS.Location = New System.Drawing.Point(727, 82)
        Me.txtTelClienteS.Name = "txtTelClienteS"
        Me.txtTelClienteS.Size = New System.Drawing.Size(166, 28)
        Me.txtTelClienteS.TabIndex = 67
        '
        'txtClienteS
        '
        Me.txtClienteS.Location = New System.Drawing.Point(727, 30)
        Me.txtClienteS.Name = "txtClienteS"
        Me.txtClienteS.Size = New System.Drawing.Size(166, 28)
        Me.txtClienteS.TabIndex = 66
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(230, 284)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(151, 28)
        Me.txtResponsable.TabIndex = 65
        '
        'txtCodigoMS
        '
        Me.txtCodigoMS.Location = New System.Drawing.Point(230, 30)
        Me.txtCodigoMS.Name = "txtCodigoMS"
        Me.txtCodigoMS.Size = New System.Drawing.Size(100, 28)
        Me.txtCodigoMS.TabIndex = 63
        '
        'cbPestadorS
        '
        Me.cbPestadorS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPestadorS.FormattingEnabled = True
        Me.cbPestadorS.Items.AddRange(New Object() {"AyA", "ESPH", "ASADA", "Municipalidad", "Privado"})
        Me.cbPestadorS.Location = New System.Drawing.Point(727, 201)
        Me.cbPestadorS.Name = "cbPestadorS"
        Me.cbPestadorS.Size = New System.Drawing.Size(121, 30)
        Me.cbPestadorS.TabIndex = 62
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(538, 263)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 24)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Sistema:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(538, 204)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 24)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Prestador:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNo)
        Me.GroupBox2.Controls.Add(Me.rbSi)
        Me.GroupBox2.Location = New System.Drawing.Point(954, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 119)
        Me.GroupBox2.TabIndex = 59
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Urgente:"
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(16, 75)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(56, 28)
        Me.rbNo.TabIndex = 14
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Location = New System.Drawing.Point(16, 41)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(47, 28)
        Me.rbSi.TabIndex = 13
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 24)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Correo Cliente:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFQS)
        Me.GroupBox1.Controls.Add(Me.chkMicrobS)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 133)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Equipo:"
        '
        'chkFQS
        '
        Me.chkFQS.AutoSize = True
        Me.chkFQS.Location = New System.Drawing.Point(16, 86)
        Me.chkFQS.Name = "chkFQS"
        Me.chkFQS.Size = New System.Drawing.Size(159, 28)
        Me.chkFQS.TabIndex = 11
        Me.chkFQS.Text = "Fisico-Químico"
        Me.chkFQS.UseVisualStyleBackColor = True
        '
        'chkMicrobS
        '
        Me.chkMicrobS.AutoSize = True
        Me.chkMicrobS.Location = New System.Drawing.Point(16, 41)
        Me.chkMicrobS.Name = "chkMicrobS"
        Me.chkMicrobS.Size = New System.Drawing.Size(156, 28)
        Me.chkMicrobS.TabIndex = 10
        Me.chkMicrobS.Text = "Microbiológico"
        Me.chkMicrobS.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 24)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Teléfono Cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(538, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 24)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Responsable:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Fecha Salida:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 24)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Código Muestreo:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dtpFechaS)
        Me.Panel3.Location = New System.Drawing.Point(59, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(341, 54)
        Me.Panel3.TabIndex = 70
        '
        'dtpFechaS
        '
        Me.dtpFechaS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaS.Location = New System.Drawing.Point(171, 6)
        Me.dtpFechaS.Name = "dtpFechaS"
        Me.dtpFechaS.Size = New System.Drawing.Size(141, 28)
        Me.dtpFechaS.TabIndex = 55
        Me.dtpFechaS.Value = New Date(2018, 11, 25, 12, 7, 33, 0)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tvPruebas)
        Me.TabPage2.Controls.Add(Me.btnLimpiarE)
        Me.TabPage2.Controls.Add(Me.btnEliminarE)
        Me.TabPage2.Controls.Add(Me.btnBuscarE)
        Me.TabPage2.Controls.Add(Me.btnGuardarE)
        Me.TabPage2.Controls.Add(Me.dgvEntrada)
        Me.TabPage2.Controls.Add(Me.txtObservacionesE)
        Me.TabPage2.Controls.Add(Me.txtNombrePuntoM)
        Me.TabPage2.Controls.Add(Me.txtMuestreador)
        Me.TabPage2.Controls.Add(Me.txtCodigoME)
        Me.TabPage2.Controls.Add(Me.cbPuntoMuestreo)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.chklPruebas)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1250, 829)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Entrada de muestra"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tvPruebas
        '
        Me.tvPruebas.Location = New System.Drawing.Point(891, 46)
        Me.tvPruebas.Name = "tvPruebas"
        Me.tvPruebas.Size = New System.Drawing.Size(265, 114)
        Me.tvPruebas.TabIndex = 84
        '
        'btnLimpiarE
        '
        Me.btnLimpiarE.Location = New System.Drawing.Point(1109, 463)
        Me.btnLimpiarE.Name = "btnLimpiarE"
        Me.btnLimpiarE.Size = New System.Drawing.Size(94, 36)
        Me.btnLimpiarE.TabIndex = 83
        Me.btnLimpiarE.Text = "Limpiar"
        Me.btnLimpiarE.UseVisualStyleBackColor = True
        '
        'btnEliminarE
        '
        Me.btnEliminarE.Location = New System.Drawing.Point(980, 463)
        Me.btnEliminarE.Name = "btnEliminarE"
        Me.btnEliminarE.Size = New System.Drawing.Size(102, 36)
        Me.btnEliminarE.TabIndex = 82
        Me.btnEliminarE.Text = "Eliminar"
        Me.btnEliminarE.UseVisualStyleBackColor = True
        '
        'btnBuscarE
        '
        Me.btnBuscarE.Location = New System.Drawing.Point(736, 463)
        Me.btnBuscarE.Name = "btnBuscarE"
        Me.btnBuscarE.Size = New System.Drawing.Size(97, 36)
        Me.btnBuscarE.TabIndex = 80
        Me.btnBuscarE.Text = "Buscar"
        Me.btnBuscarE.UseVisualStyleBackColor = True
        '
        'btnGuardarE
        '
        Me.btnGuardarE.Location = New System.Drawing.Point(601, 463)
        Me.btnGuardarE.Name = "btnGuardarE"
        Me.btnGuardarE.Size = New System.Drawing.Size(99, 36)
        Me.btnGuardarE.TabIndex = 79
        Me.btnGuardarE.Text = "Guardar"
        Me.btnGuardarE.UseVisualStyleBackColor = True
        '
        'dgvEntrada
        '
        Me.dgvEntrada.AllowUserToAddRows = False
        Me.dgvEntrada.AllowUserToDeleteRows = False
        Me.dgvEntrada.AllowUserToResizeColumns = False
        Me.dgvEntrada.AllowUserToResizeRows = False
        Me.dgvEntrada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntrada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoM2, Me.FechaE, Me.FechaM, Me.Muestreador, Me.PuntoM, Me.NombrePuntoM, Me.Pruebas, Me.Observaciones2})
        Me.dgvEntrada.Location = New System.Drawing.Point(31, 548)
        Me.dgvEntrada.Name = "dgvEntrada"
        Me.dgvEntrada.RowHeadersVisible = False
        Me.dgvEntrada.RowTemplate.Height = 24
        Me.dgvEntrada.Size = New System.Drawing.Size(1196, 228)
        Me.dgvEntrada.TabIndex = 74
        '
        'txtObservacionesE
        '
        Me.txtObservacionesE.Location = New System.Drawing.Point(776, 190)
        Me.txtObservacionesE.Multiline = True
        Me.txtObservacionesE.Name = "txtObservacionesE"
        Me.txtObservacionesE.Size = New System.Drawing.Size(439, 142)
        Me.txtObservacionesE.TabIndex = 68
        '
        'txtNombrePuntoM
        '
        Me.txtNombrePuntoM.Location = New System.Drawing.Point(319, 417)
        Me.txtNombrePuntoM.Name = "txtNombrePuntoM"
        Me.txtNombrePuntoM.Size = New System.Drawing.Size(188, 28)
        Me.txtNombrePuntoM.TabIndex = 67
        '
        'txtMuestreador
        '
        Me.txtMuestreador.Location = New System.Drawing.Point(319, 283)
        Me.txtMuestreador.Name = "txtMuestreador"
        Me.txtMuestreador.Size = New System.Drawing.Size(188, 28)
        Me.txtMuestreador.TabIndex = 66
        '
        'txtCodigoME
        '
        Me.txtCodigoME.Location = New System.Drawing.Point(227, 24)
        Me.txtCodigoME.Name = "txtCodigoME"
        Me.txtCodigoME.Size = New System.Drawing.Size(100, 28)
        Me.txtCodigoME.TabIndex = 65
        '
        'cbPuntoMuestreo
        '
        Me.cbPuntoMuestreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPuntoMuestreo.FormattingEnabled = True
        Me.cbPuntoMuestreo.Items.AddRange(New Object() {"Fuente de abastecimiento", "Tanque de Almacenamiento", "Red de distribución"})
        Me.cbPuntoMuestreo.Location = New System.Drawing.Point(319, 352)
        Me.cbPuntoMuestreo.Name = "cbPuntoMuestreo"
        Me.cbPuntoMuestreo.Size = New System.Drawing.Size(188, 30)
        Me.cbPuntoMuestreo.TabIndex = 63
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(49, 421)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(249, 24)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Nombre Punto de Muestreo:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(587, 193)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(142, 24)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Observaciones:"
        '
        'chklPruebas
        '
        Me.chklPruebas.FormattingEnabled = True
        Me.chklPruebas.Items.AddRange(New Object() {"N1 - Microbiológico", "N1 - Fisico-Químico", "N2", "N3"})
        Me.chklPruebas.Location = New System.Drawing.Point(591, 54)
        Me.chklPruebas.Name = "chklPruebas"
        Me.chklPruebas.Size = New System.Drawing.Size(257, 73)
        Me.chklPruebas.TabIndex = 60
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(587, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(165, 24)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Pruebas a realizar:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(175, 24)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Punto de Muestreo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(49, 286)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 24)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Muestreador:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(54, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 24)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Fecha Muestreo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 24)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Fecha Entrada:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 24)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Código Muestreo:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpFechaE)
        Me.Panel1.Location = New System.Drawing.Point(53, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 58)
        Me.Panel1.TabIndex = 69
        '
        'dtpFechaE
        '
        Me.dtpFechaE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaE.Location = New System.Drawing.Point(174, 11)
        Me.dtpFechaE.Name = "dtpFechaE"
        Me.dtpFechaE.Size = New System.Drawing.Size(141, 28)
        Me.dtpFechaE.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFechaM)
        Me.Panel2.Location = New System.Drawing.Point(53, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 61)
        Me.Panel2.TabIndex = 70
        '
        'dtpFechaM
        '
        Me.dtpFechaM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaM.Location = New System.Drawing.Point(174, 14)
        Me.dtpFechaM.Name = "dtpFechaM"
        Me.dtpFechaM.Size = New System.Drawing.Size(141, 28)
        Me.dtpFechaM.TabIndex = 55
        Me.dtpFechaM.Value = New Date(2018, 11, 27, 0, 0, 0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 928)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1282, 25)
        Me.StatusStrip1.TabIndex = 50
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'CodigoM2
        '
        Me.CodigoM2.HeaderText = "Código Muestreo"
        Me.CodigoM2.Name = "CodigoM2"
        '
        'FechaE
        '
        Me.FechaE.HeaderText = "Fecha Entrada"
        Me.FechaE.Name = "FechaE"
        '
        'FechaM
        '
        Me.FechaM.HeaderText = "Fecha Muestreo"
        Me.FechaM.Name = "FechaM"
        '
        'Muestreador
        '
        Me.Muestreador.HeaderText = "Muestreador"
        Me.Muestreador.Name = "Muestreador"
        '
        'PuntoM
        '
        Me.PuntoM.HeaderText = "Punto Muestreo"
        Me.PuntoM.Name = "PuntoM"
        '
        'NombrePuntoM
        '
        Me.NombrePuntoM.HeaderText = "Nombre Punto Muestreo"
        Me.NombrePuntoM.Name = "NombrePuntoM"
        '
        'Pruebas
        '
        Me.Pruebas.HeaderText = "Pruebas"
        Me.Pruebas.Name = "Pruebas"
        '
        'Observaciones2
        '
        Me.Observaciones2.HeaderText = "Observaciones"
        Me.Observaciones2.Name = "Observaciones2"
        '
        'FrmMuestrasPotable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMuestrasPotable"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de muestras de Agua Potable"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label22 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtSistemaS As TextBox
    Friend WithEvents txtCorClienteS As TextBox
    Friend WithEvents txtTelClienteS As TextBox
    Friend WithEvents txtClienteS As TextBox
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents txtCodigoMS As TextBox
    Friend WithEvents cbPestadorS As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFQS As CheckBox
    Friend WithEvents chkMicrobS As CheckBox
    Friend WithEvents dtpFechaS As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtObservacionesE As TextBox
    Friend WithEvents txtNombrePuntoM As TextBox
    Friend WithEvents txtMuestreador As TextBox
    Friend WithEvents txtCodigoME As TextBox
    Friend WithEvents cbPuntoMuestreo As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents chklPruebas As CheckedListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpFechaM As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpFechaE As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtObservacionesS As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnLimpiarS As Button
    Friend WithEvents btnEliminarS As Button
    Friend WithEvents btnBuscarS As Button
    Friend WithEvents btnGuardarS As Button
    Friend WithEvents dgvSalida As DataGridView
    Friend WithEvents dgvEntrada As DataGridView
    Friend WithEvents btnLimpiarE As Button
    Friend WithEvents btnEliminarE As Button
    Friend WithEvents btnBuscarE As Button
    Friend WithEvents btnGuardarE As Button
    Friend WithEvents CodigoM As DataGridViewTextBoxColumn
    Friend WithEvents FechaS As DataGridViewTextBoxColumn
    Friend WithEvents Responsable As DataGridViewTextBoxColumn
    Friend WithEvents TipoEq As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents TelCliente As DataGridViewTextBoxColumn
    Friend WithEvents CorreoCliente As DataGridViewTextBoxColumn
    Friend WithEvents Prestador As DataGridViewTextBoxColumn
    Friend WithEvents Sistema As DataGridViewTextBoxColumn
    Friend WithEvents Urgente As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents tvPruebas As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents CodigoM2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaE As DataGridViewTextBoxColumn
    Friend WithEvents FechaM As DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As DataGridViewTextBoxColumn
    Friend WithEvents PuntoM As DataGridViewTextBoxColumn
    Friend WithEvents NombrePuntoM As DataGridViewTextBoxColumn
    Friend WithEvents Pruebas As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones2 As DataGridViewTextBoxColumn
End Class
