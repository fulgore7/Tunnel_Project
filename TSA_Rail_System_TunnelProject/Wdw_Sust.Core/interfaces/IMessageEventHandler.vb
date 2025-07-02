Imports Wdw_Sust.Core.Communications

Namespace Interfaces
    Public Interface IMessageEventHandler
        Sub MessageHandler(ByVal incomingConnection As IncomingConnection, ByVal message As INetworkMessage)
    End Interface
End Namespace