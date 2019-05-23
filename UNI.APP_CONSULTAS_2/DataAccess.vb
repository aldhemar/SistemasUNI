Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class DataAccess
    Dim cn As New SqlConnection(ConnectionStrings("cno").ConnectionString)
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Public Function ProductoListar() As DataSet
        da = New SqlDataAdapter("usp_ProductoListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function EmpleadoListar() As DataSet
        da = New SqlDataAdapter("usp_EmpleadoListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function ProductoNombre(ByVal nomprod As String) As DataSet
        da = New SqlDataAdapter("usp_ProductoNombre", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@NomProducto", nomprod)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    'listado de Clientes
    Public Function ClienteListar() As DataSet
        da = New SqlDataAdapter("usp_ClienteListar", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function
    'pedidos por cliente
    Public Function PedidosCliente(IdCliente As String) As DataSet
        da = New SqlDataAdapter("usp_PedidosCliente", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdCliente", IdCliente)
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

    Public Function EmpleadoDistrito(iddis As Integer) As DataSet
        da = New SqlDataAdapter("usp_EmpleadoDistrito", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdDis", iddis)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function ClienteEmpleado(IdEmpleado As Integer) As DataSet
        da = New SqlDataAdapter("usp_ClienteEmpleado", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdEmpleado", IdEmpleado)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function

    Public Function PedidoECfechas(idemp As Integer, idcli As String,
                                   fec1 As Date, fec2 As Date) As DataSet
        da = New SqlDataAdapter("usp_PedidoECFechas", cn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdEmpleado", idemp)
        da.SelectCommand.Parameters.AddWithValue("@IdCliente", idcli)
        da.SelectCommand.Parameters.AddWithValue("@fec1", fec1)
        da.SelectCommand.Parameters.AddWithValue("@fec2", fec2)
        ds = New DataSet
        da.Fill(ds)
        Return ds
    End Function
End Class
