Namespace Interfaces

    ''' <summary>
    ''' For dy
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface IOpcPlcNameLinkable

        ''' <summary>
        ''' Topic name in RSLINX. If topic name is not setup, an exception will be thrown
        ''' </summary>
        ''' <value>name of the topic, usually the name of the PLC</value>
        Property PlcName() As String

    End Interface

End Namespace