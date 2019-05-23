Public Class EmpleadoDAO
    Dim modelo As New Negocios2015Entities

    Public Function EmpleadoListar() As List(Of usp_EmpleadoListar_Result)
        Return modelo.usp_EmpleadoListar.ToList()
    End Function

    Public Function DistritoListar() As List(Of usp_DistritoListar_Result)
        Return modelo.usp_DistritoListar.ToList()
    End Function

    Public Function CargoListar() As List(Of usp_CargoListar_Result)
        Return modelo.usp_CargoListar.ToList()
    End Function

    Public Function CargoListado() As IEnumerable
        Dim lista = From c In modelo.paises
                    Select c.Idpais, c.NombrePais

        Return lista.ToList
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

        modelo.empleados.Add(objemp)
        modelo.SaveChanges()
    End Sub

    Public Sub EmpleadoActualizar(idemp As Integer, ape As String, nom As String, fecnac As Date, _
             diremp As String, iddis As Integer, fono As String, idcargo As Integer, _
             fec As Date)
        Dim emp = modelo.empleados.Find(idemp)
        If Not emp Is Nothing Then
            emp.IdEmpleado = idemp
            emp.ApeEmpleado = ape
            emp.NomEmpleado = nom
            emp.DirEmpleado = diremp
            emp.FecNac = fecnac
            emp.idDistrito = iddis
            emp.fonoEmpleado = fono
            emp.idCargo = idcargo
            emp.FecContrata = fec
            modelo.SaveChanges()
        End If
    End Sub

    Public Sub EmpleadoBaja(idemp As Integer)
        Dim emp = modelo.empleados.Find(idemp)
        emp.Activo = 0

        modelo.SaveChanges()
    End Sub
End Class
