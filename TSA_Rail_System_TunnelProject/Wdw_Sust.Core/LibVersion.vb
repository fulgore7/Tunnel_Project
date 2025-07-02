Imports System.Reflection

Public Module LibVersion

    Public Function LibraryVersion()
        Return Assembly.GetEntryAssembly().GetName().Version
    End Function
End Module
