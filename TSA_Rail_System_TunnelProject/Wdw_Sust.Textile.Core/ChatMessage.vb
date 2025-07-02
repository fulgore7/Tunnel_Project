Imports System.Data
Imports Wdw_Sust.Textile.Core.Interfaces

<Serializable()>
Public Class ChatMessage
    Implements IChatMessage

#Region "Properties"

    Public Property Message As String Implements IChatMessage.Message
    Public Property MessageSubmittedBy As String Implements IChatMessage.MessageSubmittedBy
    Public Property TimeCreated As Date Implements IChatMessage.TimeCreated
    Public Property Plant As Plant Implements IChatMessage.Plant
    Public Property EmployeeID As Integer Implements IChatMessage.EmployeeID

    Private Property IChatMessage_Plant As Wdw_Sust.Textile.Core.Plant Implements IChatMessage.Plant
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Wdw_Sust.Textile.Core.Plant)
            Throw New NotImplementedException()
        End Set
    End Property

#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("Plant:{0}|[{1}] {2} - {3}", Plant, TimeCreated.ToShortTimeString, MessageSubmittedBy, Message)
    End Function
#End Region

#Region "Constructors"

    Public Sub New(ByVal reader As IDataReader)
        Message = reader("Message")
        TimeCreated = reader("Message_Created")
        MessageSubmittedBy = reader("Message_Submitted_By")
        Plant = reader("Plant_ID")
        EmployeeID = reader("Employee_ID")
    End Sub

    Public Sub New()

    End Sub
#End Region

End Class


