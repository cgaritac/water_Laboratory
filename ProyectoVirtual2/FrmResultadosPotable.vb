Public Class FrmResultadosPotable
    Dim SalidaEquipos As New DatosSalidaEquiposDataContext
    Dim codMuestreo As Integer = 0
    Dim codResult As Integer = 0
    Dim tipoPrueba As String
    Dim registros
    Dim mensaje As String = ""

    Private Sub FrmResultadosPotable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbcResult.TabPages(0).Enabled = False
        tbcResult.TabPages(1).Enabled = False
        tbcResult.TabPages(2).Enabled = False
        tbcResult.TabPages(3).Enabled = False
        ToolStripStatusLabel1.Text = DateTime.Now.ToLocalTime()
    End Sub

    Private Sub txtCodigoMResultados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoMResultados.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Error, favor ingresar solo números", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnN3Limpiar_Click(sender As Object, e As EventArgs) Handles btnN3Limpiar.Click
        txtN3Amon.Text = ""
        txtN3Antim.Text = ""
        txtN3Arsen.Text = ""
        txtN3Cadm.Text = ""
        txtN3Cian.Text = ""
        txtN3Crom.Text = ""
        txtN3Merc.Text = ""
        txtN3Niqu.Text = ""
        txtN3Nitrat.Text = ""
        txtN3Nitrit.Text = ""
        txtN3Plom.Text = ""
        txtN3Selen.Text = ""
        dgvN3.Rows.Clear()
    End Sub

    Private Sub btnLimpiarN2_Click(sender As Object, e As EventArgs) Handles btnLimpiarN2.Click
        txtN2Alum.Text = ""
        txtN2Calc.Text = ""
        txtN2Clor.Text = ""
        txtN2Cob.Text = ""
        txtN2DurezaTot.Text = ""
        txtN2Fluor.Text = ""
        txtN2Hier.Text = ""
        txtN2Mag.Text = ""
        txtN2Mang.Text = ""
        txtN2Pot.Text = ""
        txtN2Sod.Text = ""
        txtN2Sulf.Text = ""
        txtN2Zinc.Text = ""
        dgvN2.Rows.Clear()
    End Sub

    Private Sub btnLimpiarN1FQ_Click(sender As Object, e As EventArgs) Handles btnLimpiarN1FQ.Click
        txtN1CloroResComb.Text = ""
        txtN1CloroResLib.Text = ""
        txtN1ColorAp.Text = ""
        txtN1Cond.Text = ""
        txtN1pH.Text = ""
        txtN1Temp.Text = ""
        txtN1Turb.Text = ""
        dgvN1FQ.Rows.Clear()
    End Sub

    Private Sub btnLimpiarN1Mic_Click(sender As Object, e As EventArgs) Handles btnLimpiarN1Mic.Click
        txtN1CF.Text = ""
        txtN1Ecoli.Text = ""
        dgvN1Mic.Rows.Clear()
    End Sub

    Private Sub txtN1CF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1CF.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1Ecoli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1Ecoli.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1CloroResComb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1CloroResComb.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1CloroResLib_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1CloroResLib.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1ColorAp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1ColorAp.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1Cond_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1Cond.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1pH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1pH.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1Temp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1Temp.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN1Turb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN1Turb.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Alum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Alum.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Calc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Calc.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Clor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Clor.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Cob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Cob.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2DurezaTot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2DurezaTot.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Fluor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Fluor.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Hier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Hier.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Mag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Mag.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Mang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Mang.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Pot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Pot.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Sod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Sod.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Sulf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Sulf.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN2Zinc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN2Zinc.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Amon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Amon.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Antim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Antim.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Arsen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Arsen.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Cadm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Cadm.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Cian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Cian.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Crom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Crom.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Merc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Merc.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Niqu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Niqu.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Nitrat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Nitrat.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Nitrit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Nitrit.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Plom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Plom.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub txtN3Selen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtN3Selen.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(44) And tb.Text.IndexOf(",") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(44)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "," Then

            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(",")

            If parts.Length > 1 Then
                If parts(1).Length > 4 Then
                    e.Handled = True
                End If
            End If

        End If
    End Sub

    Private Sub btnGuardarN1Mic_Click(sender As Object, e As EventArgs) Handles btnGuardarN1Mic.Click
        Dim vmaCF As Double = 0.0
        Dim vmaEcoli As Double = 0.0
        Dim conformidadCF As String
        Dim conformidadEcoli As String

        If txtN1CF.Text = "" Or txtN1Ecoli.Text = "" Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            If txtN1CF.Text = vmaCF Then
                conformidadCF = "Conforme"
            Else
                conformidadCF = "No conforme"
            End If

            If txtN1Ecoli.Text = vmaEcoli Then
                conformidadEcoli = "Conforme"
            Else
                conformidadEcoli = "No conforme"
            End If

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Microbiológico", lblN1CFPar.Text, txtN1CF.Text, lblN1CFUn.Text, vmaCF, conformidadCF)
            dgvN1Mic.Rows.Add(New String() {lblN1CFPar.Text, txtN1CF.Text, lblN1CFUn.Text, vmaCF, conformidadCF})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Microbiológico", lblN1EcoliPar.Text, txtN1Ecoli.Text, lblN1EcoliUn.Text, vmaEcoli, conformidadEcoli)
            dgvN1Mic.Rows.Add(New String() {lblN1CFPar.Text, txtN1Ecoli.Text, lblN1CFUn.Text, vmaCF, conformidadCF})

            codResult = codResult + 1

            txtN1CF.Text = ""
            txtN1Ecoli.Text = ""
        End If
    End Sub

    Private Sub btnGuardarN1FQ_Click(sender As Object, e As EventArgs) Handles btnGuardarN1FQ.Click

        Dim vmaCloroResComb As Double = 1.8
        Dim vmaCloroResLib As Double = 0.6
        Dim vmaColorAp As Double = 15
        Dim vmaCond As Double = 400
        Dim vmapH As Double = 8.0
        Dim vmaTemp As Double = 30.0
        Dim vmaTurb As Double = 5.0
        Dim conformidadCloroResComb As String
        Dim conformidadCloroResLib As String
        Dim conformidadColorAp As String
        Dim conformidadCond As String
        Dim conformidadpH As String
        Dim conformidadTemp As String
        Dim conformidadTurb As String

        If txtN1CloroResComb.Text = "" Or txtN1CloroResLib.Text = "" Or txtN1ColorAp.Text = "" Or txtN1Cond.Text = "" Or txtN1pH.Text = "" Or txtN1Temp.Text = "" Or txtN1Turb.Text = "" Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            If txtN1CloroResComb.Text < vmaCloroResComb Then
                conformidadCloroResComb = "Conforme"
            Else
                conformidadCloroResComb = "No conforme"
            End If

            If txtN1CloroResLib.Text < vmaCloroResLib Then
                conformidadCloroResLib = "Conforme"
            Else
                conformidadCloroResLib = "No conforme"
            End If

            If txtN1ColorAp.Text < vmaColorAp Then
                conformidadColorAp = "Conforme"
            Else
                conformidadColorAp = "No conforme"
            End If

            If txtN1Cond.Text < vmaCond Then
                conformidadCond = "Conforme"
            Else
                conformidadCond = "No conforme"
            End If

            If txtN1pH.Text < vmapH Then
                conformidadpH = "Conforme"
            Else
                conformidadpH = "No conforme"
            End If

            If txtN1Temp.Text < vmaTemp Then
                conformidadTemp = "Conforme"
            Else
                conformidadTemp = "No conforme"
            End If

            If txtN1Turb.Text < vmaTurb Then
                conformidadTurb = "Conforme"
            Else
                conformidadTurb = "No conforme"
            End If

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1ClorCombPar.Text, txtN1CloroResComb.Text, lblN1ClorCombUn.Text, vmaCloroResComb, conformidadCloroResComb)
            dgvN1FQ.Rows.Add(New String() {lblN1ClorCombPar.Text, txtN1CloroResComb.Text, lblN1ClorCombPar.Text, vmaCloroResComb, conformidadCloroResComb})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1ClorLibPar.Text, txtN1CloroResLib.Text, lblN1ClorLibUn.Text, vmaCloroResLib, conformidadCloroResLib)
            dgvN1FQ.Rows.Add(New String() {lblN1ClorLibPar.Text, txtN1CloroResLib.Text, lblN1ClorLibUn.Text, vmaCloroResLib, conformidadCloroResLib})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1ColApPar.Text, txtN1ColorAp.Text, lblN1ColApUn.Text, vmaColorAp, conformidadColorAp)
            dgvN1FQ.Rows.Add(New String() {lblN1ColApPar.Text, txtN1ColorAp.Text, lblN1ColApUn.Text, vmaColorAp, conformidadColorAp})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1CondPar.Text, txtN1Cond.Text, lblN1CondUn.Text, vmaCond, conformidadCond)
            dgvN1FQ.Rows.Add(New String() {lblN1CondPar.Text, txtN1Cond.Text, lblN1CondUn.Text, vmaCond, conformidadCond})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1pHPar.Text, txtN1pH.Text, "", vmapH, conformidadpH)
            dgvN1FQ.Rows.Add(New String() {lblN1pHPar.Text, txtN1pH.Text, "", vmapH, conformidadpH})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1TempPar.Text, txtN1Temp.Text, lblN1TempUn.Text, vmaTemp, conformidadTemp)
            dgvN1FQ.Rows.Add(New String() {lblN1TempPar.Text, txtN1Temp.Text, lblN1TempUn.Text, vmaTemp, conformidadTemp})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N1 Físico-Químico", lblN1TurbPar.Text, txtN1Turb.Text, lblN1TurbUn.Text, vmaTurb, conformidadTurb)
            dgvN1FQ.Rows.Add(New String() {lblN1TurbPar.Text, txtN1Turb.Text, lblN1TurbUn.Text, vmaTurb, conformidadTurb})

            codResult = codResult + 1

            txtN1CloroResComb.Text = ""
            txtN1CloroResLib.Text = ""
            txtN1ColorAp.Text = ""
            txtN1Cond.Text = ""
            txtN1pH.Text = ""
            txtN1Temp.Text = ""
            txtN1Turb.Text = ""
        End If
    End Sub

    Private Sub btnGuardarN2_Click(sender As Object, e As EventArgs) Handles btnGuardarN2.Click

        Dim vmaAlum As Double = 0.2
        Dim vmaCalc As Double = 100.0
        Dim vmaClor As Double = 250.0
        Dim vmaCob As Double = 2.0
        Dim vmaDurezaTot As Double = 400.0
        Dim vmaFluor As Double = 1.5
        Dim vmaHier As Double = 0.3
        Dim vmaMag As Double = 50.0
        Dim vmaMang As Double = 0.5
        Dim vmaPot As Double = 10.0
        Dim vmaSod As Double = 200.0
        Dim vmaSulf As Double = 250.0
        Dim vmaZinc As Double = 3.0
        Dim conformidadAlum As String
        Dim conformidadCalc As String
        Dim conformidadClor As String
        Dim conformidadCob As String
        Dim conformidadDurezaTot As String
        Dim conformidadFluor As String
        Dim conformidadHier As String
        Dim conformidadMag As String
        Dim conformidadMang As String
        Dim conformidadPot As String
        Dim conformidadSod As String
        Dim conformidadSulf As String
        Dim conformidadZinc As String

        If txtN2Alum.Text = "" Or txtN2Calc.Text = "" Or txtN2Clor.Text = "" Or txtN2Cob.Text = "" Or txtN2DurezaTot.Text = "" Or txtN2Fluor.Text = "" Or txtN2Hier.Text = "" Or txtN2Mag.Text = "" Or txtN2Mang.Text = "" Or txtN2Pot.Text = "" Or txtN2Sod.Text = "" Or txtN2Sulf.Text = "" Or txtN2Zinc.Text = "" Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            If txtN2Alum.Text < vmaAlum Then
                conformidadAlum = "Conforme"
            Else
                conformidadAlum = "No conforme"
            End If

            If txtN2Calc.Text < vmaCalc Then
                conformidadCalc = "Conforme"
            Else
                conformidadCalc = "No conforme"
            End If

            If txtN2Clor.Text < vmaClor Then
                conformidadClor = "Conforme"
            Else
                conformidadClor = "No conforme"
            End If

            If txtN2Cob.Text < vmaCob Then
                conformidadCob = "Conforme"
            Else
                conformidadCob = "No conforme"
            End If

            If txtN2DurezaTot.Text < vmaDurezaTot Then
                conformidadDurezaTot = "Conforme"
            Else
                conformidadDurezaTot = "No conforme"
            End If

            If txtN2Fluor.Text < vmaFluor Then
                conformidadFluor = "Conforme"
            Else
                conformidadFluor = "No conforme"
            End If

            If txtN2Hier.Text < vmaHier Then
                conformidadHier = "Conforme"
            Else
                conformidadHier = "No conforme"
            End If

            If txtN2Mag.Text < vmaMag Then
                conformidadMag = "Conforme"
            Else
                conformidadMag = "No conforme"
            End If

            If txtN2Mang.Text < vmaMang Then
                conformidadMang = "Conforme"
            Else
                conformidadMang = "No conforme"
            End If

            If txtN2Pot.Text < vmaPot Then
                conformidadPot = "Conforme"
            Else
                conformidadPot = "No conforme"
            End If

            If txtN2Sod.Text < vmaSod Then
                conformidadSod = "Conforme"
            Else
                conformidadSod = "No conforme"
            End If

            If txtN2Sulf.Text < vmaSulf Then
                conformidadSulf = "Conforme"
            Else
                conformidadSulf = "No conforme"
            End If

            If txtN2Zinc.Text < vmaZinc Then
                conformidadZinc = "Conforme"
            Else
                conformidadZinc = "No conforme"
            End If

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2AlumPar.Text, txtN2Alum.Text, lblN2AlumUn.Text, vmaAlum, conformidadAlum)
            dgvN2.Rows.Add(New String() {lblN2AlumPar.Text, txtN2Alum.Text, lblN2AlumUn.Text, vmaAlum, conformidadAlum})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2CalcPar.Text, txtN2Calc.Text, lblN2CalcUn.Text, vmaCalc, conformidadCalc)
            dgvN2.Rows.Add(New String() {lblN2CalcPar.Text, txtN2Calc.Text, lblN2CalcUn.Text, vmaCalc, conformidadCalc})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2ClorPar.Text, txtN2Clor.Text, lblN2ClorUn.Text, vmaClor, conformidadClor)
            dgvN2.Rows.Add(New String() {lblN2ClorPar.Text, txtN2Clor.Text, lblN2ClorUn.Text, vmaClor, conformidadClor})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2CobPar.Text, txtN2Cob.Text, lblN2CobUn.Text, vmaCob, conformidadCob)
            dgvN2.Rows.Add(New String() {lblN2CobPar.Text, txtN2Cob.Text, lblN2CobUn.Text, vmaCob, conformidadCob})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2DurTotPar.Text, txtN2DurezaTot.Text, lblN2DurTotUn.Text, vmaDurezaTot, conformidadDurezaTot)
            dgvN2.Rows.Add(New String() {lblN2DurTotPar.Text, txtN2DurezaTot.Text, lblN2DurTotUn.Text, vmaDurezaTot, conformidadDurezaTot})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2FlourPar.Text, txtN2Fluor.Text, lblN2FlourUn.Text, vmaFluor, conformidadFluor)
            dgvN2.Rows.Add(New String() {lblN2FlourPar.Text, txtN2Fluor.Text, lblN2FlourUn.Text, vmaFluor, conformidadFluor})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2HierroPar.Text, txtN2Hier.Text, lblN2HierUn.Text, vmaHier, conformidadHier)
            dgvN2.Rows.Add(New String() {lblN2HierroPar.Text, txtN2Hier.Text, lblN2HierUn.Text, vmaHier, conformidadHier})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2MagPar.Text, txtN2Mag.Text, lblN2MagUn.Text, vmaMag, conformidadMag)
            dgvN2.Rows.Add(New String() {lblN2MagPar.Text, txtN2Mag.Text, lblN2MagUn.Text, vmaMag, conformidadMag})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2MangPar.Text, txtN2Mang.Text, lblN2MangUn.Text, vmaMang, conformidadMang)
            dgvN2.Rows.Add(New String() {lblN2MangPar.Text, txtN2Mang.Text, lblN2MangUn.Text, vmaMang, conformidadMang})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2PotPar.Text, txtN2Pot.Text, lblN2PotUn.Text, vmaPot, conformidadPot)
            dgvN2.Rows.Add(New String() {lblN2PotPar.Text, txtN2Pot.Text, lblN2PotUn.Text, vmaPot, conformidadPot})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2SodPar.Text, txtN2Pot.Text, lblN2PotUn.Text, vmaPot, conformidadPot)
            dgvN2.Rows.Add(New String() {lblN2SodPar.Text, txtN2Pot.Text, lblN2PotUn.Text, vmaPot, conformidadPot})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2SulfPar.Text, txtN2Sulf.Text, lblN2SulfUn.Text, vmaSulf, conformidadSulf)
            dgvN2.Rows.Add(New String() {lblN2SulfPar.Text, txtN2Sulf.Text, lblN2SulfUn.Text, vmaSulf, conformidadSulf})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N2", lblN2ZincPar.Text, txtN2Zinc.Text, lblN2ZincUn.Text, vmaZinc, conformidadZinc)
            dgvN2.Rows.Add(New String() {lblN2ZincPar.Text, txtN2Zinc.Text, lblN2ZincUn.Text, vmaZinc, conformidadZinc})

            codResult = codResult + 1

            txtN2Alum.Text = ""
            txtN2Calc.Text = ""
            txtN2Clor.Text = ""
            txtN2Cob.Text = ""
            txtN2DurezaTot.Text = ""
            txtN2Fluor.Text = ""
            txtN2Hier.Text = ""
            txtN2Mag.Text = ""
            txtN2Mang.Text = ""
            txtN2Pot.Text = ""
            txtN2Sod.Text = ""
            txtN2Sulf.Text = ""
            txtN2Zinc.Text = ""
        End If
    End Sub

    Private Sub btnBuscarRes_Click(sender As Object, e As EventArgs) Handles btnBuscarRes.Click

        dgvN1Mic.Rows.Clear()
        dgvN1FQ.Rows.Clear()
        dgvN2.Rows.Clear()
        dgvN3.Rows.Clear()
        tbcResult.TabPages(0).Enabled = False
        tbcResult.TabPages(1).Enabled = False
        tbcResult.TabPages(2).Enabled = False
        tbcResult.TabPages(3).Enabled = False

        If Not String.IsNullOrEmpty(txtCodigoMResultados.Text) Then

            codMuestreo = CType(txtCodigoMResultados.Text, Integer)

            registros = SalidaEquipos.BUSCAR_ENTRADAMUESTRA(codMuestreo, mensaje)
            MessageBox.Show(mensaje)

            If mensaje = "El muestreo no existe !!! " Then

            Else
                For Each registro In registros
                    tipoPrueba = registro.Pruebas
                Next

                If tipoPrueba = "N1 Microbiológica" Then
                    tbcResult.TabPages(0).Enabled = True
                End If

                If tipoPrueba = "N1 Físico-Química" Then
                    tbcResult.TabPages(1).Enabled = True
                End If

                If tipoPrueba = "N2" Then
                    tbcResult.TabPages(2).Enabled = True
                End If

                If tipoPrueba = "N3" Then
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N1 Completa" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(1).Enabled = True
                End If

                If tipoPrueba = "N1 Microbiológica y N2" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                End If

                If tipoPrueba = "N1 Microbiológica y N3" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N1 Físico-Química y N2" Then
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                End If

                If tipoPrueba = "N1 Físico-Química y N3" Then
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N2 y N3" Then
                    tbcResult.TabPages(2).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N1 Completa y N2" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                End If

                If tipoPrueba = "N1 Físico-Química, N2 y N3" Then
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N1 Microbiológica, N2 y N3" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "N1 Completa y N3" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If

                If tipoPrueba = "Completa" Then
                    tbcResult.TabPages(0).Enabled = True
                    tbcResult.TabPages(1).Enabled = True
                    tbcResult.TabPages(2).Enabled = True
                    tbcResult.TabPages(3).Enabled = True
                End If
            End If
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que desea buscar")
        End If
    End Sub

    Private Sub btnEliminarRes_Click(sender As Object, e As EventArgs) Handles btnEliminarRes.Click
        If Not String.IsNullOrEmpty(txtCodigoMResultados.Text) Then
            codMuestreo = CType(txtCodigoMResultados.Text, Integer)
            SalidaEquipos.ELIMINAR_RESULT(codMuestreo, mensaje)
            MessageBox.Show(mensaje)
        Else
            MessageBox.Show("Error de ingreso de datos, por favor ingrese el código del muestreo que del registro que desea eliminar")
        End If
    End Sub

    Private Sub hscbN1Temp_Scroll(sender As Object, e As ScrollEventArgs) Handles hscbN1Temp.Scroll
        txtN1Temp.Text = hscbN1Temp.Value
    End Sub

    Private Sub btnGuardarN3_Click(sender As Object, e As EventArgs) Handles btnGuardarN3.Click
        Dim vmaAmon As Double = 0.5
        Dim vmaAntim As Double = 0.005
        Dim vmaArsen As Double = 0.01
        Dim vmaCadm As Double = 0.003
        Dim vmaCian As Double = 0.07
        Dim vmaCrom As Double = 0.05
        Dim vmaMerc As Double = 0.001
        Dim vmaNiqu As Double = 0.02
        Dim vmaNitrat As Double = 50
        Dim vmaNitrit As Double = 0.1
        Dim vmaPlom As Double = 0.01
        Dim vmaSelen As Double = 0.01
        Dim conformidadAmon As String
        Dim conformidadAntim As String
        Dim conformidadArsen As String
        Dim conformidadCadm As String
        Dim conformidadCian As String
        Dim conformidadCrom As String
        Dim conformidadMerc As String
        Dim conformidadNiqu As String
        Dim conformidadNitrat As String
        Dim conformidadNitrit As String
        Dim conformidadPlom As String
        Dim conformidadSelen As String

        If txtN3Amon.Text = "" Or txtN3Antim.Text = "" Or txtN3Arsen.Text = "" Or txtN3Cadm.Text = "" Or txtN3Cian.Text = "" Or txtN3Crom.Text = "" Or txtN3Merc.Text = "" Or txtN3Niqu.Text = "" Or txtN3Nitrat.Text = "" Or txtN3Nitrit.Text = "" Or txtN3Plom.Text = "" Or txtN3Selen.Text = "" Then
            MessageBox.Show("Error, no hay información, favor ingrese todos los datos", "Error ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else

            If txtN3Amon.Text < vmaAmon Then
                conformidadAmon = "Conforme"
            Else
                conformidadAmon = "No conforme"
            End If

            If txtN3Antim.Text < vmaAntim Then
                conformidadAntim = "Conforme"
            Else
                conformidadAntim = "No conforme"
            End If

            If txtN3Arsen.Text < vmaArsen Then
                conformidadArsen = "Conforme"
            Else
                conformidadArsen = "No conforme"
            End If

            If txtN3Cadm.Text < vmaCadm Then
                conformidadCadm = "Conforme"
            Else
                conformidadCadm = "No conforme"
            End If

            If txtN3Cian.Text < vmaCian Then
                conformidadCian = "Conforme"
            Else
                conformidadCian = "No conforme"
            End If

            If txtN3Crom.Text < vmaCrom Then
                conformidadCrom = "Conforme"
            Else
                conformidadCrom = "No conforme"
            End If

            If txtN3Merc.Text < vmaMerc Then
                conformidadMerc = "Conforme"
            Else
                conformidadMerc = "No conforme"
            End If

            If txtN3Niqu.Text < vmaNiqu Then
                conformidadNiqu = "Conforme"
            Else
                conformidadNiqu = "No conforme"
            End If

            If txtN3Nitrat.Text < vmaNitrat Then
                conformidadNitrat = "Conforme"
            Else
                conformidadNitrat = "No conforme"
            End If

            If txtN3Nitrit.Text < vmaNitrit Then
                conformidadNitrit = "Conforme"
            Else
                conformidadNitrit = "No conforme"
            End If

            If txtN3Plom.Text < vmaPlom Then
                conformidadPlom = "Conforme"
            Else
                conformidadPlom = "No conforme"
            End If

            If txtN3Selen.Text < vmaSelen Then
                conformidadSelen = "Conforme"
            Else
                conformidadSelen = "No conforme"
            End If

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3AmonPar.Text, txtN3Amon.Text, lblN3AmonUn.Text, vmaAmon, conformidadAmon)
            dgvN3.Rows.Add(New String() {lblN3AmonPar.Text, txtN3Amon.Text, lblN3AmonUn.Text, vmaAmon, conformidadAmon})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3AntimPar.Text, txtN3Antim.Text, lblN3AntimUn.Text, vmaAntim, conformidadAntim)
            dgvN3.Rows.Add(New String() {lblN3AntimPar.Text, txtN3Antim.Text, lblN3AntimUn.Text, vmaAntim, conformidadAntim})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3ArsenPar.Text, txtN3Arsen.Text, lblN3ArsenUn.Text, vmaArsen, conformidadArsen)
            dgvN3.Rows.Add(New String() {lblN3ArsenPar.Text, txtN3Arsen.Text, lblN3ArsenUn.Text, vmaArsen, conformidadArsen})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3CadmPar.Text, txtN3Cadm.Text, lblN3CadmUn.Text, vmaCadm, conformidadCadm)
            dgvN3.Rows.Add(New String() {lblN3CadmPar.Text, txtN3Cadm.Text, lblN3CadmUn.Text, vmaCadm, conformidadCadm})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3CianPar.Text, txtN3Cian.Text, lblN3CianUn.Text, vmaCian, conformidadCian)
            dgvN3.Rows.Add(New String() {lblN3CianPar.Text, txtN3Cian.Text, lblN3CianUn.Text, vmaCian, conformidadCian})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3CromPar.Text, txtN3Crom.Text, lblN3CromUn.Text, vmaCrom, conformidadCrom)
            dgvN3.Rows.Add(New String() {lblN3CromPar.Text, txtN3Crom.Text, lblN3CromUn.Text, vmaCrom, conformidadCrom})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3MercPar.Text, txtN3Merc.Text, lblN3MercUn.Text, vmaMerc, conformidadMerc)
            dgvN3.Rows.Add(New String() {lblN3MercPar.Text, txtN3Merc.Text, lblN3MercUn.Text, vmaMerc, conformidadMerc})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3NiquPar.Text, txtN3Niqu.Text, lblN3NiquUn.Text, vmaNiqu, conformidadNiqu)
            dgvN3.Rows.Add(New String() {lblN3NiquPar.Text, txtN3Niqu.Text, lblN3NiquUn.Text, vmaNiqu, conformidadNiqu})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3NitratPar.Text, txtN3Nitrat.Text, lblN3NitratUn.Text, vmaNitrat, conformidadNitrat)
            dgvN3.Rows.Add(New String() {lblN3NitratPar.Text, txtN3Nitrat.Text, lblN3NitratUn.Text, vmaNitrat, conformidadNitrat})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3NitritPar.Text, txtN3Nitrit.Text, lblN3NitritUn.Text, vmaNitrit, conformidadNitrit)
            dgvN3.Rows.Add(New String() {lblN3NitritPar.Text, txtN3Nitrit.Text, lblN3NitritUn.Text, vmaNitrit, conformidadNitrit})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3PlomPar.Text, txtN3Plom.Text, lblN3PlomUn.Text, vmaPlom, conformidadPlom)
            dgvN3.Rows.Add(New String() {lblN3PlomPar.Text, txtN3Plom.Text, lblN3PlomUn.Text, vmaPlom, conformidadPlom})

            codResult = codResult + 1

            SalidaEquipos.GUARDAR_RESULT(codResult, codMuestreo, "N3", lblN3SelenPar.Text, txtN3Selen.Text, lblN3SelenUn.Text, vmaSelen, conformidadSelen)
            dgvN3.Rows.Add(New String() {lblN3SelenPar.Text, txtN3Selen.Text, lblN3SelenUn.Text, vmaSelen, conformidadSelen})

            codResult = codResult + 1

            txtN3Amon.Text = ""
            txtN3Antim.Text = ""
            txtN3Arsen.Text = ""
            txtN3Cadm.Text = ""
            txtN3Cian.Text = ""
            txtN3Crom.Text = ""
            txtN3Merc.Text = ""
            txtN3Niqu.Text = ""
            txtN3Nitrat.Text = ""
            txtN3Nitrit.Text = ""
            txtN3Plom.Text = ""
            txtN3Selen.Text = ""
        End If
    End Sub
End Class