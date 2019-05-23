Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim categorias As String() = {"A", "B", "C", "D"}
        cboCategoria.Items.AddRange(categorias)
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        Dim obj As New Pago(txtVendedor.Text, cboCategoria.SelectedIndex,
                             Integer.Parse(txtHoras.Text))
        txtSalario.Text = obj.SalarioBruto().ToString("n2")
        txtDescuento.Text = obj.Descuento().ToString("n2")
        txtNeto.Text = obj.Neto().ToString("n2")
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategoria.SelectedIndexChanged
        If cboCategoria.SelectedIndex >= 0 Then
            btnProceso_Click(sender, e)
        End If
    End Sub
End Class