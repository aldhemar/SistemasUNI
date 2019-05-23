Imports System.Data.SqlClient

Public Class Form2

    Dim cn As New SqlConnection(
        "Data Source=localhost;Initial Catalog=Negocios2015;UID=sa;PWD=sql")
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Sub llenaProductos()
        da = New SqlDataAdapter("SELECT * FROM Compras.PRODUCTOS", cn)
        da.Fill(ds, "Productos")
        dgProductos.DataSource = ds.Tables("Productos")
        dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        lblTotal.Text = ds.Tables("Productos").Rows.Count
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaProductos()
    End Sub
End Class