Imports Wdw_Sust.Core.Helpers

<Serializable()>
Public Class LintApplicationMonitoringDetail
    Inherits LintObjectBase(Of LintApplicationMonitoringDetail)
    Implements IHavePlant

#Region "Properties"

    Public Property AlarmGlobalID As Integer
    Public Property ApplicationID As LintApplicationId
    Public Property ApplicationLastSeenTime As DateTime
    Public Property ApplicationName As String
    Public Property ComputerDescritpion As String
    Public Property IsOnline As Boolean
    Public Property PlantID As Plant Implements IHavePlant.Plant

#End Region

#Region "Constructors"

    Public Sub New(ByVal reader As IDataReader)
        ApplicationID = reader("Application_ID")
        ApplicationName = reader("Application_Name")
        ComputerDescritpion = FixNull(Of String)(reader("Computer_Description"))
        ApplicationLastSeenTime = reader("Application_Last_Seen")
        PlantID = FixNull(Of Plant)(reader("Plant_ID"), Plant.UNKNOWN)
        AlarmGlobalID = FixNull(Of Integer)(reader("Alarm_Global_ID"), 0)
        IsOnline = FixNull(Of Boolean)(reader("Is_Online"), True)
    End Sub

#End Region

End Class