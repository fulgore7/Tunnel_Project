Imports Wdw_Sust.OpcDa.Core.Interfaces

Namespace Softing

    Public NotInheritable Class SoftingOPCTagGenerator
        Inherits OpcTagGeneratorBase

        Protected Overrides Function GenerateOpcElementTagName(obj As IOpcObject) As String
            Return String.Format("{0}.{1}", obj.PlcName, obj.TagName)
        End Function

        Protected Overrides Function GenerateOpcTagName(plcTopicName As String, tagName As String, subTagName As String) As String
            Return String.Format("{0}.{1}.{2}", plcTopicName, tagName, subTagName)
        End Function

    End Class

End Namespace