Public Class Form3

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        Dim obj As New clsCalculo2(txtProducto.Text, Double.Parse(txtPrecio.Text),
                                   Integer.Parse(txtCantidad.Text))
        'Mostrar Resultados
        txtSubTotal.Text = obj.SubTotal().ToString("n2")
        txtIgv.Text = obj.Igv().ToString("n2")
        txtTotal.Text = obj.Total().ToString("n2")
    End Sub
End Class