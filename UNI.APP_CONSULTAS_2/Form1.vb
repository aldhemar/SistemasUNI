Public Class Form1
    Dim obj As New DataAccess

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgProductos.DataSource = obj.ProductoListar.Tables(0)
        lblTotal.Text = obj.ProductoListar.Tables(0).Rows.Count
    End Sub
End Class
