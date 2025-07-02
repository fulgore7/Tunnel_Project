Imports System.Data
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Sort

<Serializable()>
Public Class LintProdStatus
    Inherits LintProdBase

#Region "Properties"
    Public Property MachineID() As Integer
    Public Property MachineName() As String
    Public Property SessionTypeID() As Integer
    Public Property CurrentTotalValue() As Double
    Public Property CurrentExpectedValue() As Double
    Public Property CurrentReject() As Double
    Public Property LastUpdated() As DateTime
    Public ReadOnly Property CurrentPace As Double
        Get
            If (CurrentExpectedValue > 0) Then
                Dim pace As Double = (CurrentTotalValue / CurrentExpectedValue)
                Return pace
            Else
                Return 0
            End If
        End Get
    End Property
    Public Property PlantID() As Integer
    'Public Property CurrentColor() As String 'Not stored in database, must be calculated based on current pace
    Public Property LoginStatus() As Integer
    Public Property OnBreak() As Boolean
#End Region

#Region "Constructors"
    Public Sub New(ByVal machineID As Integer, ByVal lintUserID As Integer, ByVal sessionTypeID As Integer,
                   ByVal shiftTotalValue As Integer, ByVal shiftReject As Integer, ByVal shiftExpected As Integer,
                   ByVal currentTotalValue As Integer, ByVal currentReject As Integer, ByVal currentExpected As Integer,
                   ByVal lastUpdated As DateTime, ByVal firstName As String, ByVal lastName As String,
                   ByVal machineName As String, ByVal plantID As Integer, ByVal loginStatus As Integer, ByVal onBreak As Boolean)
        MyBase.New(lintUserID, shiftTotalValue, shiftReject, shiftExpected, firstName, lastName)
        _MachineID = machineID
        _MachineName = machineName
        _SessionTypeID = sessionTypeID
        _CurrentTotalValue = currentTotalValue
        _CurrentReject = currentReject
        _CurrentExpectedValue = currentExpected
        _LastUpdated = lastUpdated
        _PlantID = plantID
        _LoginStatus = loginStatus
        _OnBreak = onBreak
    End Sub

    Public Sub New(ByVal reader As IDataReader)
        MyBase.New(reader)
        _MachineID = reader("machine_id")
        _MachineName = reader("machine_name")
        _PlantID = reader("Plant_ID")
        _SessionTypeID = reader("session_type_id")
        _CurrentTotalValue = reader("current_total_value")
        _CurrentReject = reader("current_reject")
        _CurrentExpectedValue = reader("current_expected_value")
        _LastUpdated = reader("last_updated_datetime")
        _LoginStatus = reader("Login_Status")
        OnBreak = reader("OnBreak")
    End Sub
#End Region

End Class
