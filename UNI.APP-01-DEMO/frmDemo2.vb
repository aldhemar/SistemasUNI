Public Class frmDemo2

    Private Sub txtDato_TextChanged(sender As Object, e As EventArgs) Handles txtDato.TextChanged
        'Ocurre cuando se altera el contenido de la caja.
        txtCopia.Text = txtDato.Text.ToUpper
    End Sub

    Private Sub txtn1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn1.KeyPress
        'e.KeyChar
        'MsgBox("CODIGO ASCII :" & AscW(e.KeyChar).ToString)
        If AscW(e.KeyChar) = 13 And txtn1.Text <> String.Empty Then
            txtn2.Focus()
        End If
    End Sub

    Private Sub txtn2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn2.KeyPress
        If AscW(e.KeyChar) = 13 And txtn2.Text <> String.Empty Then
            txtn3.Focus()
        End If
    End Sub

    Private Sub txtn3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtn3.KeyPress
        If AscW(e.KeyChar) = 13 And txtn3.Text <> String.Empty Then
            txtPromedio.ReadOnly = True
            btnProcesar.Focus()
        End If
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim prom As Single = (Single.Parse(txtn1.Text) + Single.Parse(txtn2.Text) +
               Single.Parse(txtn3.Text)) / 3
        txtPromedio.Text = prom.ToString("n2")
    End Sub
End Class