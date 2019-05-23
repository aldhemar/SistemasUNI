Public Class Form5
    Dim obj As New DataAccess

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboDistrito.DataSource = obj.DistritoListar.Tables(0)
        cboDistrito.DisplayMember = "NomDistrito"
        cboDistrito.ValueMember = "IdDistrito"
        cboDistrito_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cboDistrito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDistrito.SelectedIndexChanged
        Try
            Dim id As Integer = Integer.Parse(cboDistrito.SelectedValue.ToString)
            dgEmpleados.DataSource = obj.EmpleadoDistrito(id).Tables(0)
            dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
        End Try
    End Sub
End Class