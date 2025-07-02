
Public Class LintEngineeringDiagnosticData
    Inherits LintObjectBase(Of LintEngineeringDiagnosticData)

#Region "Fields"
    Private _alarmDescription As String
    Private _alarmGlobalID As Integer
    Private _faultCount As Integer
#End Region

#Region "Properties"

    Public Property AlarmDescription() As String
        Get
            Return _alarmDescription
        End Get
        Set(ByVal value As String)
            _alarmDescription = value
        End Set
    End Property
    Public Property AlarmGlobalID() As Integer
        Get
            Return _alarmGlobalID
        End Get
        Set(ByVal value As Integer)
            _alarmGlobalID = value
        End Set
    End Property
    Public Property FaultCount() As Integer
        Get
            Return _faultCount
        End Get
        Set(ByVal value As Integer)
            _faultCount = value
        End Set
    End Property

#End Region

End Class

