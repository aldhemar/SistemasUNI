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
End Class
