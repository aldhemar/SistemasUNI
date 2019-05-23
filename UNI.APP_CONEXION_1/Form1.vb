Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NEGOCIOS2015DataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.NEGOCIOS2015DataSet.productos)
        lblTotal.Text = dgProductos.RowCount - 1
    End Sub
End Class
