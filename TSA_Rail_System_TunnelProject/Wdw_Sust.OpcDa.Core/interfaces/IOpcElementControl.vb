Namespace Interfaces

    ''' <summary>
    ''' This is to address the problem when the control need to call ValueFromObjectToPLC is used.
    ''' Any OPC control that the tag name itself is the name of the whole tag, the control needs to
    ''' implement this interface for OPCComm to work properly.
    ''' </summary>
    ''' <remarks></remarks>
    Public Interface IOpcElementControl

    End Interface

End Namespace