Imports Wdw_Sust.Core.Extensions

Namespace EventArgs

    Public Class LintProductivitySummaryEventArgs
        Inherits DataRetrievalEventArgs

#Region "Properties"

        Public Property LastUpdateTime() As Date
        Public Property ListOfOperatorStatus() As New List(Of LintOperatorProductivitySummaryData)

        Public ReadOnly Property NumberOfHangingLogin() As Integer
            Get
                If ListOfOperatorStatus Is Nothing Then Return 0
                Return ListOfOperatorStatus.Where(Function(a) a.MachineID.IsWithin(22500, 22599) AndAlso a.RFBadgeUserID > 0).Count
            End Get
        End Property

        Public ReadOnly Property NumberOfIronerLogin() As Integer
            Get
                If ListOfOperatorStatus Is Nothing Then Return 0
                Return ListOfOperatorStatus.Where(Function(a)
                                                      Select Case Plant
                                                          Case Plant.TSA
                                                              Return a.MachineID.IsWithin(11300, 11399) AndAlso a.RFBadgeUserID > 0
                                                          Case Plant.ASA
                                                              Return a.MachineID.IsWithin(31300, 31399) AndAlso a.RFBadgeUserID > 0
                                                          Case Else
                                                              Return (a.MachineID.IsWithin(11300, 11399) OrElse a.MachineID.IsWithin(31300, 31399)) AndAlso a.RFBadgeUserID > 0
                                                      End Select
                                                  End Function).Count
            End Get
        End Property

        Public ReadOnly Property NumberOfTowelFoldLogin() As Integer
            Get
                If ListOfOperatorStatus Is Nothing Then Return 0
                Return ListOfOperatorStatus.Where(Function(a)
                                                      Select Case Plant
                                                          Case Plant.TSA
                                                              Return a.MachineID.IsWithin(11400, 11499) AndAlso a.RFBadgeUserID > 0
                                                          Case Plant.ASA
                                                              Return a.MachineID.IsWithin(31400, 31499) AndAlso a.RFBadgeUserID > 0
                                                          Case Else
                                                              Return (a.MachineID.IsWithin(11400, 11499) OrElse a.MachineID.IsWithin(31400, 31499)) AndAlso a.RFBadgeUserID > 0
                                                      End Select
                                                  End Function).Count
            End Get
        End Property

        Public Property Plant As Plant

#End Region

#Region "Constructors"

        Public Sub New()

        End Sub

#End Region

    End Class

End Namespace