Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums

Namespace Interfaces
    Public Interface ILintReportInfoProvider
        Function GetChatHistory(ByVal plant As Plant, ByVal startTime As DateTime, ByVal endTime As DateTime) As List(Of ChatMessage)
    End Interface
End Namespace