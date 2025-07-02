Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Dal

Public Class WcfTsaLocalRailInfoServiceClient
    Inherits WcfTsaRailInfoServiceClient

    Protected Overrides Function CreateFactoryObject() As ILintFactoryProvider
        Return LintLocalFactoryProvider.Instance
    End Function

    Public Sub New(bindingType As WcfBindingType)
        MyBase.New(bindingType)
    End Sub
End Class