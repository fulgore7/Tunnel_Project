Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintCartDumpProductivityData
    Inherits LintObjectBase(Of LintCartDumpProductivityData)

#Region "Fields"

    Private _cycleTimeMin As Double
    Private _hour As Integer
    Private _machineName As String
    Private _numOperations As Integer

#End Region

#Region "Properties"

    Public Property CycleTimeMin() As Double
        Get
            Return _cycleTimeMin
        End Get
        Set
            _cycleTimeMin = Value
        End Set
    End Property

    Public Property Hour() As Integer
        Get
            Return _hour
        End Get
        Set
            _hour = Value
        End Set
    End Property

    Public Property MachineName() As String
        Get
            Return _machineName
        End Get
        Set
            _machineName = Value
        End Set
    End Property

    Public Property NumOperations() As Integer
        Get
            Return _numOperations
        End Get
        Set
            _numOperations = Value
        End Set
    End Property

#End Region



#Region "Constructors"

    Public Sub New(reader As IDataReader)
        CycleTimeMin = FixNull(Of Double)(reader("Cycle_Time_Min"))
        Hour = FixNull(Of Integer)(reader("Hour"))
        MachineName = FixNull(Of String)(reader("Machine_Name"))
        NumOperations = FixNull(Of Integer)(reader("Num_Operations"))
    End Sub

#End Region

End Class