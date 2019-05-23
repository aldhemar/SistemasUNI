Public Class Form3
    Dim obj As New DataAccess

    Sub llenaProductos(ByVal prod As String)
        Dim dst As New DataSet
        dst = obj.ProductoNombre(prod)
        dgProductos.DataSource = dst.Tables(0)
        dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        lblTotal.Text = dst.Tables(0).Rows.Count
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaProductos(String.Empty)
    End Sub

    Private Sub txtProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged
        Try
            llenaProductos(txtProducto.Text.Trim)
        Catch ex As Exception
        End Try
    End Sub
End Class