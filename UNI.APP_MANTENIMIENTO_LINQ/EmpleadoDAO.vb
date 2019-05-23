Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class EmpleadoDAO
    Dim cn As New SqlConnection(ConnectionStrings("cno").ConnectionString)
    Dim da As New SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ds As New DataSet

    Public Function EmpleadoListar() As DataSet
        da = New SqlDataAdapter("usp_EmpleadoListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function DistritoListar() As DataSet
        da = New SqlDataAdapter("usp_DistritoListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function CargoListar() As DataSet
        da = New SqlDataAdapter("usp_CargoListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Sub EmpleadoInsertar(ape As String, nom As String, fecnac As Date, _
                  diremp As String, iddis As Integer, fono As String, idcargo As Integer, _
                  fec As Date)
        cn.Open()
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "usp_EmpleadoInsertar"
            With cmd.Parameters
                .AddWithValue("@Ape", ape)
                .AddWithValue("@Nom", nom)
                .AddWithValue("@FecNac", fecnac)
                .AddWithValue("@DirEmp", diremp)
                .AddWithValue("@idDis", iddis)
                .AddWithValue("@fono", fono)
                .AddWithValue("@idCargo", idcargo)
                .AddWithValue("@FecContrato", fec)
            End With
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Empleado Registrado.....", "AVISO")
            Catch ex As Exception
                MessageBox.Show("ERROR en la transacción.....", "AVISO")
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub EmpleadoActualizar(idemp As Integer, ape As String, nom As String, fecnac As Date, _
                  diremp As String, iddis As Integer, fono As String, idcargo As Integer, _
                  fec As Date)
        cn.Open()
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "usp_EmpleadoActualizar"
            With cmd.Parameters
                .AddWithValue("@IdEmp", idemp)
                .AddWithValue("@Ape", ape)
                .AddWithValue("@Nom", nom)
                .AddWithValue("@FecNac", fecnac)
                .AddWithValue("@DirEmp", diremp)
                .AddWithValue("@idDis", iddis)
                .AddWithValue("@fono", fono)
                .AddWithValue("@idCargo", idcargo)
                .AddWithValue("@FecContrato", fec)
            End With
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Los datos fueron Actualizados.....", "AVISO")
            Catch ex As Exception
                MessageBox.Show("ERROR en la transacción.....", "AVISO")
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub EmpleadoBaja(idemp As Integer)
        cn.Open()
        Using cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "usp_EmpleadoBaja"
            With cmd.Parameters
                .AddWithValue("@IdEmp", idemp)
            End With
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("El Empleado fue dado de Baja...", "AVISO")
            Catch ex As Exception
                MessageBox.Show("ERROR en la transacción.....", "AVISO")
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
End Class
