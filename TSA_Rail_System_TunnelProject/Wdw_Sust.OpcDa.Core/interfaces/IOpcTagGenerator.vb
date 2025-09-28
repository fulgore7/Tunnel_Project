Namespace Interfaces

    Public Interface IOpcTagGenerator

        Function GenerateOpcTags(obj As IOpcObject) As String()
        Function GenerateOpcTagName() As String()
        Property PrintTagNameWhenDebug As Boolean
        Function HandleOpcArrayTagName(tagName As String, propertyName As String, index As Integer) As String
    End Interface



End Namespace