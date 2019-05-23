Public Class Form5

    Private Sub txtCliente_Leave(sender As Object, e As EventArgs) Handles txtCliente.Leave
        If txtCliente.Text.Trim = String.Empty Then
            MessageBox.Show("Dato Obligatorio....", "AVISO")
            txtCliente.Focus()
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        If Not (Char.IsNumber(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            'Toma control del evento. (Revierte la accion que se produjo con la pulsacion de una tecla)
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNI_Validated(sender As Object, e As EventArgs) Handles txtDNI.Validated
        If txtDNI.Text.Length <> 8 Then
            MessageBox.Show("Error, el DNI debe tener 8 dígitos...", "AVISO")
            txtDNI.Focus()
        End If
    End Sub

    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        Dim oLider As New Lider
        oLider.Cliente = txtCliente.Text.ToUpper
        oLider.Dni = txtDNI.Text
        oLider.Horas = Integer.Parse(txtHoras.Text)

        If txtTarifa.Text.Trim <> String.Empty Then
            oLider.Tarifa = Decimal.Parse(txtTarifa.Text)
        End If

        lstResultado.Items.Clear()
        lstResultado.Items.Add("Cliente :" + oLider.Cliente.ToString())
        lstResultado.Items.Add("DNI: " + oLider.Dni.ToString())
        lstResultado.Items.Add("Horas Alquiladas: " + oLider.Horas.ToString())
        lstResultado.Items.Add("Monsto por garantia : " + oLider.Garantia().ToString())
        lstResultado.Items.Add("Importe Bruto : " + oLider.ImporteBruto().ToString())
        lstResultado.Items.Add("Descuento : " + oLider.Descuento().ToString())
        lstResultado.Items.Add("Importe Neto: " + oLider.Neto().ToString())
    End Sub
End Class