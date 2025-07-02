Imports System.Linq

Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms
Imports Wdw_Sust.Textile.Tsa.Wcf

Public Class frmSortingProductivity
    Inherits CtrlOpcRailFormBase

#Region "Fields"
    Private _totalProductivity As List(Of LintKeyValuePair(Of String, Integer))
    Private _machineData As List(Of LintMachineHourlyProductivityData)
    Private _cartDumpData As List(Of LintCartDumpProductivityData)
    Private _sortingData As List(Of LintSortingProductivityData)
    Private _shiftClock As LintShiftClock
#End Region

#Region "Methods"
    Protected Overrides Sub Initialize()
        If CONFIGURATION.ApplicationMode = ProgramMode.PRODUCTION Then
            InvokeIfNeeded(AddressOf InitalizeBeltTargets)
            AddJob("GetAllBeltData", TimeSpan.FromSeconds(60), AddressOf GetAllBeltData)
            AddJob("GetProductivitySummary", TimeSpan.FromSeconds(120), AddressOf GetProductivitySummary)
        End If
    End Sub

    Private Sub InitalizeBeltTargets()
        ctrlBeltA.Total = 5000
        ctrlBeltB.Total = 5000
        ctrlBeltC.Total = 5000
        ctrlBeltD.Total = 5000
        ctrlBeltTotal.Total = 20000
    End Sub

    Protected Overrides Sub OnFormClosing(e As System.Windows.Forms.FormClosingEventArgs)
        RemoveJobs("GetAllBeltData", "GetProductivitySummary")
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub GetAllBeltData()
        If TryAction(Sub() _totalProductivity = BllRailInfoProvider.Instance.Service.GetLast60MinutesSortingPounds) Then
            InvokeIfNeeded(Sub()
                               ctrlBeltTotal.Actual = _totalProductivity.Sum(Function(a As LintKeyValuePair(Of String, Integer)) a.Value)
                               ctrlBeltA.Actual = GetBeltTotal("Belt A")
                               ctrlBeltB.Actual = GetBeltTotal("Belt B")
                               ctrlBeltC.Actual = GetBeltTotal("Belt C")
                               ctrlBeltD.Actual = GetBeltTotal("Belt D")
                           End Sub)
        End If
    End Sub

    Private Sub GetProductivitySummary()
        Dim shiftData As LintShiftData = _shiftClock.GetCurrentShiftData
        If shiftData Is Nothing Then Exit Sub
        If TryAction(Sub()
                         _sortingData = BllRailInfoProvider.Instance.Service.GetSortingProductivityDetails(shiftData)
                         _cartDumpData = BllRailInfoProvider.Instance.Service.GetCartDumpProductivityData(shiftData)
                     End Sub) Then
            InvokeIfNeeded(Sub()
                               TSAMachineHourlyProductivityDataBindingSource.DataSource = _machineData
                               TSASortingProductivityDataBindingSource.DataSource = _sortingData
                               TSACartDumpProductivityDataBindingSource.DataSource = _cartDumpData
                           End Sub)
        End If
    End Sub

    Private Function GetBeltTotal(ByVal beltName As String) As Double
        Dim kvp As LintKeyValuePair(Of String, Integer) = _totalProductivity.Find(Function(a As LintKeyValuePair(Of String, Integer)) a.Key.StartsWith(beltName))
        If kvp IsNot Nothing Then Return kvp.Value Else : Return 0.0
    End Function

    Protected Overrides Sub ApplicationModeChanged()
        If CONFIGURATION.IsFailOverMode Then InvokeIfNeeded(AddressOf Close)
    End Sub

#End Region

    Public Sub New(ByVal shiftClock As LintShiftClock)
        InitializeComponent()
        _shiftClock = shiftClock
    End Sub
End Class