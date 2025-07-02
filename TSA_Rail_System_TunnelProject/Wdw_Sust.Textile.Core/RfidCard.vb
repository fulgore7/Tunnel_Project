Imports System.Data.SqlClient
Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class RfidCard
    Inherits LintObjectBase(Of RfidCard)

#Region "Properties"

    Public Property CastInfo() As New LintCastMember
    '    Get
    '        If _castInfo Is Nothing Then _castInfo = New LINTCastMember
    '        Return _castInfo
    '    End Get
    '    Set(ByVal value As LINTCastMember)
    '        _castInfo = value
    '    End Set
    'End Property
    Public Overrides ReadOnly Property IsValid As Boolean
        Get
            Return MyBase.IsValid AndAlso _CastInfo.EmployeeID > 0
        End Get
    End Property

    Public Property IsCardValid() As Boolean
    Public Property TimeIssued() As Date
    Public Property RFBadgeGuidLoWord() As Long
    Public Property RFBadgeGuidHiWord() As Long
    Public Property RFBadgeUserID() As Int32
    Public Property TimeUnassigned() As Date
    Public ReadOnly Property AssignedTo As String
        Get
            Return _CastInfo?.EmployeeName
        End Get
    End Property

#End Region

#Region "Methods"
    Public Shared Function UndefinedCard(Optional ByVal rfidCardNumber = -1) As RfidCard
        Dim card As New RfidCard
        With card
            .CastInfo = Nothing
            .IsCardValid = False
            .RFBadgeUserID = rfidCardNumber
            .RFBadgeGuidHiWord = 0
            .RFBadgeGuidLoWord = 0
            .TimeIssued = Nothing
            .TimeUnassigned = Nothing
        End With
        Return card
    End Function

    Public Shared Function CreateRfidCard(ByVal rfidCardNumber As Integer, ByVal loWord As Long, ByVal hiWord As Long)
        Dim card As New RfidCard
        With card
            .CastInfo = New LintCastMember
            .IsCardValid = False
            .RFBadgeUserID = rfidCardNumber
            .RFBadgeGuidHiWord = hiWord
            .RFBadgeGuidLoWord = loWord
            .TimeIssued = Date.MinValue
            .TimeUnassigned = Date.MinValue
        End With
        Return card
    End Function
#End Region

#Region "Constructors"

    Public Sub New(ByVal rfBadgeUserId As Integer,
                       ByVal rfBadgeGuidLo As Long,
                       ByVal rfBadgeGuidHi As Long,
                       ByVal castFirstName As String,
                       ByVal castLastName As String)

        Me.RFBadgeUserID = rfBadgeUserId
        Me.RFBadgeGuidLoWord = rfBadgeGuidLo
        Me.RFBadgeGuidHiWord = rfBadgeGuidHi
        Me.CastInfo.FirstName = castFirstName
        Me.CastInfo.LastName = castLastName
    End Sub

    Public Sub New(ByVal rfBadgeUserId As Integer,
                       ByVal rfBadgeGuidLo As Long,
                       ByVal rfBadgeGuidHi As Long,
                       ByVal assignedTo As String)

        Me.RFBadgeUserID = rfBadgeUserId
        Me.RFBadgeGuidLoWord = rfBadgeGuidLo
        Me.RFBadgeGuidHiWord = rfBadgeGuidHi
        Dim assignedName As String = FixNull(Of String)(assignedTo)
        If assignedName = String.Empty Then
            CastInfo.FirstName = String.Empty
            CastInfo.LastName = String.Empty
        ElseIf Not assignedName.Contains(" ") Then
            CastInfo.FirstName = assignedName
        Else
            CastInfo.FirstName = assignedName.Substring(0, assignedName.LastIndexOf(" "))
            CastInfo.LastName = assignedName.Substring(assignedName.LastIndexOf(" "))
        End If
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal reader As SqlDataReader)
        RFBadgeGuidLoWord = reader("RF_Badge_GUID_LoWord")
        RFBadgeGuidHiWord = reader("RF_Badge_GUID_HiWord")
        RFBadgeUserID = reader("RF_Badge_User_ID")
        TimeIssued = reader("Date_Time_Issued")
        TimeUnassigned = reader("Date_Time_Unassigned")
        IsCardValid = reader("Card_Valid")
        Dim assignedName As String = FixNull(Of String)(reader("Assigned_To"))
        If assignedName = String.Empty Then
            _CastInfo.FirstName = String.Empty
            _CastInfo.LastName = String.Empty
        ElseIf Not assignedName.Contains(" ") Then
            _CastInfo.FirstName = assignedName
        Else
            _CastInfo.FirstName = assignedName.Substring(0, assignedName.LastIndexOf(" "))
            _CastInfo.LastName = assignedName.Substring(assignedName.LastIndexOf(" "))
        End If
    End Sub

#End Region

End Class

