Public Class Form2

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'txtProducto.Text = String.Empty
        For Each obj As Control In Me.Controls
            If TypeOf obj Is TextBox Then obj.Text = String.Empty
        Next
        txtProducto.Focus()
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        'Instanciar la clase
        Dim obj As New clsCalculo1
        obj.Producto = txtProducto.Text.ToUpper
        obj.Cantidad = Integer.Parse(txtCantidad.Text)
        obj.Precio = Double.Parse(txtPrecio.Text)

        txtSubTotal.Text = obj.SubTotal().ToString("n2")
        txtIgv.Text = obj.Igv().ToString("n2")
        txtTotal.Text = obj.Total().ToString("n2")
    End Sub
End Class