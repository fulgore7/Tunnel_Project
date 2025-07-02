''' <summary>
''' This class is to log application event into the database
''' </summary>
''' <remarks></remarks>
<Serializable()>
Public Class LintApplicationEventLog
    Inherits LintObjectBase(Of LintApplicationEventLog)

#Region "Fields"
    Private _dateOccurred As DateTime
    Private _logDescription As String
    Private _workstation As String
    Private _applicationID As LintApplicationId

    Public Property ApplicationID() As LintApplicationId
        Get
            Return _applicationID
        End Get
        Set(ByVal value As LintApplicationId)
            _applicationID = value
        End Set
    End Property

    Public Property DateOccurred() As DateTime
        Get
            Return _dateOccurred
        End Get
        Set(ByVal value As DateTime)
            _dateOccurred = value
        End Set
    End Property

    Public Property LogDescription() As String
        Get
            Return _logDescription
        End Get
        Set(ByVal value As String)
            _logDescription = value
        End Set
    End Property

    Public Property Workstation() As String
        Get
            Return _workstation
        End Get
        Set(ByVal value As String)
            _workstation = value
        End Set
    End Property

#End Region

#Region "Properties"

#End Region

#Region "Constructors"
    Public Sub New(ByVal applicationID As LintApplicationId, ByVal dateOccurred As DateTime, ByVal logDescription As String, ByVal workstation As String)
        _applicationID = applicationID
        _dateOccurred = dateOccurred
        _logDescription = logDescription
        _workstation = workstation
    End Sub

#End Region

End Class