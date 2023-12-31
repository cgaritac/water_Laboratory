Public Class FrmMuestrasPotable

    Dim SalidaEquipos As New DatosSalidaEquiposDataContext
    Dim fechaSal As Date
    Dim codMuestreo As Integer = 0
    Dim codEntrada As Integer = 0
    Dim tipoPrueba As String
    Dim urgentes As String
    Dim registros
    Dim mensaje As String = ""
    Dim nodo1Sec As TreeNode = New TreeNode("/")
    Dim nodo2Sec As TreeNode = New TreeNode("/")
    Dim nodo2Princ As TreeNode = New TreeNode("N1", New TreeNode() {nodo1Sec, nodo2Sec})

    Private Sub FrmMuestrasPotable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpFechaS.Value = DateTime.Now.ToLocalTime()
        dtpFechaE.Value = DateTime.Now.ToLocalTime()
        dtpFechaM.Value = DateTime.Now.ToLocalTime()
        txtCodigoMS.Text = codMuestreo
        ToolStripStatusLabel1.Text = DateTime.Now.ToLocalTime()
    End Sub

    Private Sub txtResponsable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResponsable.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtClienteS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClienteS.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub txtTelClienteS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelClienteS.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub



    Private Sub txtMuestreador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMuestreador.KeyPress
        e.Handled = IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solamente letras", "Error ingreso de datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnLimpiarS_Click(sender As Object, e As EventArgs) Handles btnLimpiarS.Click
        dtpFechaS.Value = DateTime.Now.ToLocalTime()
        txtCodigoMS.Text = "0"
        txtResponsable.Text = ""
        chkMicrobS.Checked = False
        chkFQS.Checked = False
        txtClienteS.Text = ""
        txtTelClienteS.Text = ""
        txtCorClienteS.Text = ""
        cbPestadorS.SelectedIndex = -1
        txtSistemaS.Text = ""
        txtObservacionesS.Text = ""
        rbSi.Checked = False
        rbNo.Checked = False
        dgvSalida.Rows.Clear()
    End Sub

    Private Sub btnLimpiarE_Click(sender As Object, e As EventArgs) Handles btnLimpiarE.Click
        dtpFechaE.Value = DateTime.Now.ToLocalTime()
        dtpFechaM.Value = DateTime.Now.ToLocalTime()
        txtCodigoME.Text = "0"
        txtMuestreador.Text = ""
        cbPuntoMuestreo.SelectedIndex = -1
        txtNombrePuntoM.Text = ""
        txtObservacionesE.Text = ""
        chklPruebas.SetItemChecked(0, False)
        chklPruebas.SetItemChecked(1, False)
        chklPruebas.SetItemChecked(2, False)
        chklPruebas.SetItemChecked(3, False)
        dgvEntrada.Rows.Clear()
        tvPruebas.Nodes.Clear()
    End Sub

    Private Sub btnGuardarS_Click(sender As Object, e As EventArgs) Handles btnGuardarS.Click
        codMuestreo = 1

        If txtCodigoMS.Text = "" Or txtCorClienteS.Text = "" Or txtSistemaS.Text = "" Or txtObservacionesS.Text = "" Or cbPestadorS.SelectedIndex = -1 Or txtResponsable.Text = "" Or txtClienteS.Text = "" Or txtTelClienteS.Text = "" Or (rbSi.Checked = False And rbNo.Checked = False) Or (chkMicrobS.Checked = False And chkFQS.Checked = False) Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If txtTelClienteS.TextLength < 8 Or txtTelClienteS.TextLength > 8 Then
                MessageBox.Show("Error, favor ingrese el número de teléfono con formato de 8 dígitos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If rbSi.Checked = True Then
                    urgentes = "Si"
                Else
                    urgentes = "No"
                End If

                If chkMicrobS.Checked = True And chkFQS.Checked = False Then
                    tipoPrueba = "Microbiológica"
                End If

                If chkMicrobS.Checked = False And chkFQS.Checked = True Then
                    tipoPrueba = "Físico-Química"
                End If

                If chkMicrobS.Checked = True And chkFQS.Checked = True Then
                    tipoPrueba = "Microbiológica y Físico-Química"
                End If

                SalidaEquipos.GUARDAR_SALIDAEQUIPO(codMuestreo, dtpFechaS.Value, txtResponsable.Text, tipoPrueba, txtClienteS.Text, txtTelClienteS.Text, txtCorClienteS.Text, cbPestadorS.Text, txtSistemaS.Text, urgentes, txtObservacionesS.Text)
                dgvSalida.Rows.Add(New String() {codMuestreo, dtpFechaS.Value, txtResponsable.Text, tipoPrueba, txtClienteS.Text, txtTelClienteS.Text, txtCorClienteS.Text, cbPestadorS.Text, txtSistemaS.Text, urgentes, txtObservacionesS.Text})
                MessageBox.Show("Datos ingresados correctamente")

                codMuestreo = codMuestreo + 1
                txtCodigoMS.Text = codMuestreo

                dtpFechaS.Value = DateTime.Now.ToLocalTime()
                txtResponsable.Text = ""
                chkMicrobS.Checked = False
                chkFQS.Checked = False
                txtClienteS.Text = ""
                txtTelClienteS.Text = ""
                txtCorClienteS.Text = ""
                cbPestadorS.SelectedIndex = -1
                txtSistemaS.Text = ""
                txtObservacionesS.Text = ""
                rbSi.Checked = False
                rbNo.Checked = False
            End If
        End If

    End Sub

    Private Sub txtCodigoMS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoMS.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnBuscarS_Click(sender As Object, e As EventArgs) Handles btnBuscarS.Click

        Dim responsableSal As String = ""
        Dim clienteSal As String = ""
        Dim telefClien As Integer
        Dim corrClient As String = ""
        Dim prestSal As String = ""
        Dim sistemaSal As String = ""
        Dim observSal As String = ""

        dgvSalida.Rows.Clear()

        If Not String.IsNullOrEmpty(txtCodigoMS.Text) Then

            codMuestreo = CType(txtCodigoMS.Text, Integer)

            registros = SalidaEquipos.BUSCAR_SALIDAEQUIPO(codMuestreo, mensaje)
            MessageBox.Show(mensaje)

            If mensaje = "El muestreo no existe !!! " Then
            Else
                For Each registro In registros
                    fechaSal = registro.FechaSalida
                    responsableSal = registro.Responsable
                    tipoPrueba = registro.TipoPrueba
                    clienteSal = registro.Cliente
                    telefClien = registro.TelCliente
                    corrClient = registro.CorreoCliente
                    prestSal = registro.Pestador
                    sistemaSal = registro.Sistema
                    urgentes = registro.Urgente
                    observSal = registro.Observaciones
                Next

                dgvSalida.Rows.Add(New String() {codMuestreo, fechaSal, responsableSal, tipoPrueba, clienteSal, telefClien, corrClient, prestSal, sistemaSal, urgentes, observSal})

            End If
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que desea buscar")
        End If

    End Sub

    Private Sub btnEliminarS_Click(sender As Object, e As EventArgs) Handles btnEliminarS.Click

        If Not String.IsNullOrEmpty(txtCodigoMS.Text) Then
            codMuestreo = CType(txtCodigoMS.Text, Integer)
            SalidaEquipos.ELIMINAR_SALIDAEQUIPO(codMuestreo, mensaje)
            MessageBox.Show(mensaje)
            dgvSalida.Rows.Clear()
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que desea eliminar")
        End If

    End Sub

    Private Sub btnGuardarE_Click(sender As Object, e As EventArgs) Handles btnGuardarE.Click
        tvPruebas.Nodes.Clear()
        If txtCodigoME.Text = "" Or txtMuestreador.Text = "" Or txtNombrePuntoM.Text = "" Or txtObservacionesE.Text = "" Or cbPuntoMuestreo.SelectedIndex = -1 Or (chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False)) Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Else
            If dtpFechaE.Value < dtpFechaM.Value Then
                MessageBox.Show("Error, la fecha de ingreso debe ser mayor o igual que la fecha de muestreo", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If Not String.IsNullOrEmpty(txtCodigoME.Text) Then

                    codMuestreo = CType(txtCodigoME.Text, Integer)

                    registros = SalidaEquipos.BUSCAR_SALIDAEQUIPO(codMuestreo, mensaje)
                    MessageBox.Show(mensaje)

                    If mensaje = "El muestreo no existe !!! " Then

                    Else
                        For Each registro In registros
                            fechaSal = registro.FechaSalida
                        Next

                        If dtpFechaM.Value < fechaSal Then
                            MessageBox.Show("Error, la fecha de muestreo debe ser mayor o igual que la fecha de salida", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Else

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Microbiológica"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Físico-Química"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N2"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Completa"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Microbiológica y N2"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N1 Microbiológica y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Físico-Química y N2"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N1 Físico-Química y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N2 y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                tipoPrueba = "N1 Completa y N2"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N1 Físico-Química, N2 y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N1 Microbiológica, N2 y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "N1 Completa y N3"
                            End If

                            If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                tipoPrueba = "Completa"
                            End If

                            SalidaEquipos.GUARDAR_ENTRADAMUESTRA(codEntrada, txtCodigoME.Text, dtpFechaE.Value, dtpFechaM.Value, txtMuestreador.Text, cbPuntoMuestreo.Text, txtNombrePuntoM.Text, tipoPrueba, txtObservacionesE.Text, mensaje)
                            MessageBox.Show(mensaje)
                            If mensaje = "El registro de ingreso del muestreo ya existe !!! " Then
                            Else
                                dgvEntrada.Rows.Add(New String() {txtCodigoME.Text, dtpFechaE.Value, dtpFechaM.Value, txtMuestreador.Text, cbPuntoMuestreo.Text, txtNombrePuntoM.Text, tipoPrueba, txtObservacionesE.Text})
                                codEntrada = codEntrada + 1

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    tvPruebas.Nodes.Add("N2")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    nodo2Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    tvPruebas.Nodes.Add("N2")
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(False) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    nodo2Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(False) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(False) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(False) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    nodo2Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N3")
                                End If

                                If chklPruebas.GetItemChecked(0).Equals(True) And chklPruebas.GetItemChecked(1).Equals(True) And chklPruebas.GetItemChecked(2).Equals(True) And chklPruebas.GetItemChecked(3).Equals(True) Then
                                    nodo1Sec.Text = "N1 Microbiológica"
                                    nodo2Sec.Text = "N1 Físico-Química"
                                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                                    tvPruebas.Nodes.Add("N2")
                                    tvPruebas.Nodes.Add("N3")

                                    dtpFechaE.Value = DateTime.Now.ToLocalTime()
                                    dtpFechaM.Value = DateTime.Now.ToLocalTime()
                                    txtCodigoME.Text = ""
                                    txtMuestreador.Text = ""
                                    cbPuntoMuestreo.SelectedIndex = -1
                                    txtNombrePuntoM.Text = ""
                                    txtObservacionesE.Text = ""
                                    chklPruebas.SetItemChecked(0, False)
                                    chklPruebas.SetItemChecked(1, False)
                                    chklPruebas.SetItemChecked(2, False)
                                    chklPruebas.SetItemChecked(3, False)
                                End If
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo")
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscarE_Click(sender As Object, e As EventArgs) Handles btnBuscarE.Click

        Dim fechaEnt As Date
        Dim fechaMuest As Date
        Dim muestreador As String = ""
        Dim puntMuest As String = ""
        Dim nombPuntMuest As String = ""
        Dim prueb As String = ""
        Dim observEnt As String = ""

        dgvEntrada.Rows.Clear()
        tvPruebas.Nodes.Clear()

        If Not String.IsNullOrEmpty(txtCodigoME.Text) Then

            codMuestreo = CType(txtCodigoME.Text, Integer)

            registros = SalidaEquipos.BUSCAR_ENTRADAMUESTRA(codMuestreo, mensaje)
            MessageBox.Show(mensaje)

            If mensaje = "El muestreo no existe !!! " Then

            Else
                For Each registro In registros
                    fechaEnt = registro.FechaEntrada
                    fechaMuest = registro.FechaMuestreo
                    muestreador = registro.Muestreador
                    puntMuest = registro.PuntoMuestreo
                    nombPuntMuest = registro.NombrePuntoMuestreo
                    prueb = registro.Pruebas
                    observEnt = registro.Observaciones
                Next

                dgvEntrada.Rows.Add(New String() {codMuestreo, fechaEnt, fechaMuest, muestreador, puntMuest, nombPuntMuest, prueb, observEnt})

                If prueb.Equals("N1 Microbiológica") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                End If

                If prueb.Equals("N1 Físico-Química") Then
                    nodo1Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                End If

                If prueb.Equals("N2") Then
                    tvPruebas.Nodes.Add("N2")
                End If

                If prueb.Equals("N3") Then
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N1 Completa") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    nodo2Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                End If

                If prueb.Equals("N1 Microbiológica y N2") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                End If

                If prueb.Equals("N1 Microbiológica y N3") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N1 Físico-Química y N2") Then
                    nodo1Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                End If

                If prueb.Equals("N1 Físico-Química y N3") Then
                    nodo1Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N2 y N3") Then
                    tvPruebas.Nodes.Add("N2")
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N1 Completa y N2") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    nodo2Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                End If

                If prueb.Equals("N1 Físico-Química, N2 y N3") Then
                    nodo1Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N1 Microbiológica, N2 y N3") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("N1 Completa y N3") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    nodo2Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N3")
                End If

                If prueb.Equals("Completa") Then
                    nodo1Sec.Text = "N1 Microbiológica"
                    nodo2Sec.Text = "N1 Físico-Química"
                    tvPruebas.Nodes.AddRange(New TreeNode() {nodo2Princ})
                    tvPruebas.Nodes.Add("N2")
                    tvPruebas.Nodes.Add("N3")
                End If

            End If
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que desea buscar")
        End If
    End Sub

    Private Sub btnEliminarE_Click(sender As Object, e As EventArgs) Handles btnEliminarE.Click
        If Not String.IsNullOrEmpty(txtCodigoME.Text) Then
            codMuestreo = CType(txtCodigoME.Text, Integer)
            SalidaEquipos.ELIMINAR_ENTRADAMUESTRA(codMuestreo, mensaje)
            MessageBox.Show(mensaje)
            dgvEntrada.Rows.Clear()
            tvPruebas.Nodes.Clear()
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que del registro de entrada que desea eliminar")
        End If
    End Sub


End Class