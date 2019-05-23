Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.Table

Public Class Form2
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        crvPedidos.ReportSource = Nothing
        Dim ParamFec1 As New ParameterDiscreteValue
        Dim ParamFec2 As New ParameterDiscreteValue
        ParamFec1.Value = dtInicio.Value.Date
        ParamFec2.Value = dtFin.Value.Date

        Dim ParamList As New ParameterFields
        Dim ParamTemp1 As ParameterField
        Dim ParamTemp2 As ParameterField

        ParamTemp1 = New ParameterField
        ParamTemp1.ParameterFieldName = "@fec1"
        ParamTemp1.CurrentValues.Add(ParamFec1)
        ParamList.Add(ParamTemp1)

        ParamTemp2 = New ParameterField
        ParamTemp2.ParameterFieldName = "@fec2"
        ParamTemp2.CurrentValues.Add(ParamFec2)
        ParamList.Add(ParamTemp2)

        Dim reporte As New rptPedidosFechas
        crvPedidos.ParameterFieldInfo = ParamList
        crvPedidos.ReportSource = reporte

    End Sub
End Class