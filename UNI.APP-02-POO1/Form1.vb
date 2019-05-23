Public Class Form1

    Private Sub btnUtilizar_Click(sender As Object, e As EventArgs) Handles btnUtilizar.Click
        'Instanciar objeto de la clase clsPersona
        Dim obj As New clsPersona

        obj.Apellido = txtApellido.Text.ToUpper
        obj.Nombre = txtNombre.Text.ToUpper
        obj.Edad = Integer.Parse(txtEdad.Text)
        obj.Direccion = txtDireccion.Text.ToUpper

        lstDatos.Items.Clear()
        lstDatos.Items.Add(obj.Nombre)
        lstDatos.Items.Add(obj.Apellido)
        lstDatos.Items.Add(obj.Edad.ToString)
        lstDatos.Items.Add(obj.Direccion)
    End Sub
End Class
