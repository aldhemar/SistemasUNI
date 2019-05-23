Public Class Form2
    Dim obj As New DataAccess

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgEmpleados.DataSource = obj.EmpleadoListar.Tables(0)
        lblTotal.Text = obj.EmpleadoListar.Tables(0).Rows.Count
    End Sub
End Class