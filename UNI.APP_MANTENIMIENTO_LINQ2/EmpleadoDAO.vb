
Public Class EmpleadoDAO
    Dim modelo As New Negocios2015DataContext

    Public Function EmpleadoListar() As List(Of usp_EmpleadoListarResult)
        Return modelo.usp_EmpleadoListar.ToList()
    End Function

    Public Function DistritoListar() As List(Of usp_DistritoListarResult)
        Return modelo.usp_DistritoListar.ToList()
    End Function

    Public Function CargoListar() As List(Of usp_CargoListarResult)
        Return modelo.usp_CargoListar.ToList()
    End Function

    Public Sub EmpleadoInsertar(ape As String, nom As String, fecnac As Date, _
                  diremp As String, iddis As Integer, fono As String, idcargo As Integer, _
                  fec As Date)
       
        Dim objemp As New empleados
        objemp.ApeEmpleado = ape
        objemp.NomEmpleado = nom
        objemp.DirEmpleado = diremp
        objemp.FecNac = fecnac
        objemp.idDistrito = iddis
        objemp.fonoEmpleado = fono
        objemp.idCargo = idcargo
        objemp.FecContrata = fec
        objemp.Activo = 1

        modelo.empleados.InsertOnSubmit(objemp)
        modelo.SubmitChanges()
    End Sub

    Public Sub EmpleadoActualizar(idemp As Integer, ape As String, nom As String, fecnac As Date, _
                  diremp As String, iddis As Integer, fono As String, idcargo As Integer, _
                  fec As Date)
        Dim emp = From empleado In modelo.empleados
                  Where empleado.IdEmpleado = idemp

        Dim objemp As New empleados
        objemp = emp.First
        objemp.IdEmpleado = idemp
        objemp.ApeEmpleado = ape
        objemp.NomEmpleado = nom
        objemp.DirEmpleado = diremp
        objemp.FecNac = fecnac
        objemp.idDistrito = iddis
        objemp.fonoEmpleado = fono
        objemp.idCargo = idcargo
        objemp.FecContrata = fec

        modelo.SubmitChanges()
    End Sub

    Public Sub EmpleadoBaja(idemp As Integer)
        Dim emp = From empleado In modelo.empleados
                  Where empleado.IdEmpleado = idemp

        Dim objemp As New empleados
        objemp = emp.First
        objemp.Activo = 0

        modelo.SubmitChanges()
    End Sub
End Class
