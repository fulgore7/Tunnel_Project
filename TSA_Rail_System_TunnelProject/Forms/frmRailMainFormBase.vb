Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Extensions
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Global.Opc.WinForms.Core
Imports Wdw_Sust.Core.Helpers
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class frmRailMainFormBase
    Inherits CtrlOpcRailMainFormBase
    Implements INotifyPropertyChanged

#Region "Fields"
    Private _shiftTimeString As String
    Private _colorValue As Integer
    Private v As String
#End Region

#Region "Events"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
#End Region

#Region "Properties"
    Public Property ShiftTimeString As String
        Get
            Return _shiftTimeString
        End Get
        Private Set(value As String)
            SetField(_shiftTimeString, value)
        End Set
    End Property
#End Region

#Region "Methods"
    Private Sub SetUpShiftClock()
        If TryAction(Sub() SHIFT_CLOCK = New LintShiftClock(Factory.Services.GetSystemParameters(CONFIGURATION.Plant))) Then
            If Not ContainsJob("LINT_Clock") Then AddJob("LINT_Clock", TimeSpan.FromSeconds(60), AddressOf SHIFT_CLOCK.CheckShiftStatus)
            If Not ContainsJob("UpdateShiftTime") Then AddJob("UpdateShiftTime", TimeSpan.FromSeconds(1), AddressOf UpdateShiftTime)
        End If
    End Sub
    Private Sub UpdateShiftTime()
        If SHIFT_CLOCK Is Nothing Then
            ShiftTimeString = "Clock not initialized"
        Else
            If Not SHIFT_CLOCK.IsBreakInProgress Then
                ShiftTimeString = String.Format("{0} ({1:F2} hrs)", SHIFT_CLOCK.CurrentShift.GetFriendlyName, SHIFT_CLOCK.CurrentShiftTimeInHours)
            Else
                ShiftTimeString = Shift.NON_SHIFT.GetFriendlyName
            End If
        End If
    End Sub
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        SetUpShiftClock()
    End Sub
    Protected Function SetField(Of T)(ByRef field As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing) As Boolean
        If EqualityComparer(Of T).Default.Equals(field, value) Then
            Return False
        End If
        field = value
        OnPropertyChanged(propertyName)
        Return True
    End Function

    Protected Overridable Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
#End Region

#Region "Constructors"
    Public Sub New(configPath As String)
        MyBase.New(configPath)
        InitializeComponent()
    End Sub

    Public Sub New(configPath As String, ByVal plant As Plant, ByVal appId As LintApplicationId)
        MyBase.New(configPath, plant, appId)
        InitializeComponent()
    End Sub

    Public Sub New(ByVal plant As Plant, ByVal appId As LintApplicationId)
        MyBase.New(plant, appId)
        InitializeComponent()
    End Sub

    Public Sub New()
        MyBase.New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region

End Class