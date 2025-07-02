Imports DevExpress.XtraCharts
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Tsa.Dal
Imports Wdw_Sust.Textile.Tsa

Public Class frmProductDistribution
    Inherits CtrlOpcRailFormBase

    Private ReadOnly _toolTipString As String = "{0}{1}{2:F1} of {3} Tunnel(s){4}{5:F1} Classified Rail(s){6}{7:F1} Cleanwork Rail(s)"
    Private _toolTipShown As Boolean

#Region "Methods"

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        TsaProductivitySummaryBroadcaster.Instance.Refresh()
    End Sub

    Protected Overrides Sub Initialize()
        If Not CONFIGURATION.IsFailOverMode Then AddJob(SR.JOB_GET_PLANT_PRODUCT_DISTRIBUTION, TimeSpan.FromSeconds(60), AddressOf RefreshData)
        MyBase.Initialize()
    End Sub

    Private Sub RefreshData()
        Dim data As List(Of TsaProductDistributionDetail) = Nothing
        If TryAction(Sub() data = TsaProductDistributionBuilder.Build, errorTraceCode:=101) Then InvokeIfNeeded(Sub() TSAProductDistributionDetailBindingSource.DataSource = data)
    End Sub

    Protected Overrides Sub ApplicationModeChanged()
        MyBase.ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then InvokeIfNeeded(AddressOf Close)
    End Sub

    Private Sub ChartControl1_ObjectHotTracked(sender As Object, e As DevExpress.XtraCharts.HotTrackEventArgs) Handles ChartControl1.ObjectHotTracked
        If e.HitInfo.InSeries AndAlso Not _toolTipShown Then
            _toolTipShown = True
            Dim seriesPoint As SeriesPoint = CType(e.AdditionalObject, SeriesPoint) ' This is in place because some data coming back is already converted to 1 to 100 and some of them are still from 0 to 1
            Dim value As Double = seriesPoint.Values(0)
            Dim multiplier As Double = If(value >= 1, 0.01, 1)
            Dim msg As String = String.Format(_toolTipString,
                                              seriesPoint.Argument, vbCrLf,
                                              CDbl(value * Available_Washers.Value * multiplier), Available_Washers.Value, vbCrLf,
                                              CDbl(value * 40 * multiplier), vbCrLf,
                                              CDbl(value * 18 * multiplier))
            Me.ShowToolTip(New Point(e.HitInfo.HitPoint.X, e.HitInfo.HitPoint.Y - 40), msg)
        Else
            _toolTipShown = False
        End If
    End Sub

#End Region

End Class

