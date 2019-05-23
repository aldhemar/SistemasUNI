Public Class Form1
    Dim obj As New EmpleadoDAO

    Sub cargaDistritos()
        cboDistrito.DataSource = obj.DistritoListar.Tables(0)
        cboDistrito.DisplayMember = "nomDistrito"
        cboDistrito.ValueMember = "idDistrito"
    End Sub

    Sub cargaCargos()
        cboCargo.DataSource = obj.CargoListar.Tables(0)
        cboCargo.DisplayMember = "desCargo"
        cboCargo.ValueMember = "idCargo"
    End Sub

    Sub cargaEmpleados()
        dgEmpleados.DataSource = obj.EmpleadoListar.Tables(0)
        dgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaCargos()
        cargaDistritos()
        cargaEmpleados()
    End Sub
End Class
