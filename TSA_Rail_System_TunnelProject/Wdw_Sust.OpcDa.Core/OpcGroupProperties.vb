Imports Wdw_Sust.Core.Helpers
Imports Wdw_Sust.OpcDa.Core.EventArgs
Imports Wdw_Sust.OpcDa.Core.Interfaces

Public NotInheritable Class OpcGroupProperties
    Implements IDisposable

#Region "Fields"

    Private _isAsyncInProgress As Boolean
    Private _isGroupConnected As Boolean
    Private _isGroupSyncronized As Boolean
    Private _isOPCGlobalDataChangeEventSuppressing As Boolean
    Private _opcObjects As New List(Of IOpcObject)
    Private _opcPLCTagList As New Dictionary(Of String, Integer)

#End Region

#Region "Events"

    ''' <summary>
    ''' This event will only be raised if IsOPCGlobalDataChangeEventSuppressing is set to true
    ''' </summary>
    ''' <param name="sender">Instance of the class</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Event DataChangeEvent(sender As OpcGroupProperties, e As OpcGroupDataChangeEventArgs)

#End Region

#Region "Properties"

    Public Property IsGroupConnected() As Boolean
        Get
            Return _isGroupConnected
        End Get
        Set(value As Boolean)
            _isGroupConnected = value
        End Set
    End Property

    Public Property IsGroupSyncronized() As Boolean
        Get
            Return _isGroupSyncronized
        End Get
        Set(value As Boolean)
            _isGroupSyncronized = value
        End Set
    End Property

    Public Property IsOPCGlobalDataChangeEventSuppressing() As Boolean
        Get
            Return _isOPCGlobalDataChangeEventSuppressing
        End Get
        Set(value As Boolean)
            _isOPCGlobalDataChangeEventSuppressing = value
        End Set
    End Property

    Friend Property IsAsyncInProgress() As Boolean
        Get
            Return _isAsyncInProgress
        End Get
        Set(value As Boolean)
            _isAsyncInProgress = value
        End Set
    End Property

    Friend ReadOnly Property OPCObjects() As List(Of IOpcObject)
        Get
            Return _opcObjects
        End Get
    End Property

#End Region

#Region "Constructors"

    Public Sub New()
        _isGroupConnected = False
        _isGroupSyncronized = True
    End Sub

#End Region

#Region "Methods"

    Friend Sub AddOPCItemObjectToList(ByRef item As IOpcObject)
        _opcObjects.Add(item)
    End Sub

    Friend Function AddTag(plcTagName As String, clientHandle As Integer) As Boolean
        If Not _opcPLCTagList.ContainsKey(plcTagName) Then
            _opcPLCTagList.Add(plcTagName, clientHandle)
            Return True
        End If
        Return False
    End Function

    Friend Function GetClientHandle(plcTagName As String) As Integer
        Return _opcPLCTagList(plcTagName)
    End Function

    Friend Function GetClientHandles() As List(Of Integer)
        Dim listOfHandles As New List(Of Integer)
        GetListOfTags.ForEach(Sub(a) listOfHandles.Add(GetClientHandle(a)))
        'For Each plcTagName As String In GetListOfTags()
        '    listOfHandles.Add(GetClientHandle(plcTagName))
        'Next
        Return listOfHandles
    End Function

    Friend Function GetListOfTags() As List(Of String)
        Dim list As New List(Of String)
        For Each s As String In _opcPLCTagList.Keys
            list.Add(s)
        Next
        Return list
    End Function

    Friend Function GetPLCTagCounts() As Integer
        Return _opcPLCTagList.Count
    End Function

    Friend Function GetPLCTagName(clientHandle As Integer) As String
        Dim i As IEnumerator = _opcPLCTagList.GetEnumerator
        While i.MoveNext
            Dim de As KeyValuePair(Of String, Integer) = i.Current
            If de.Value = clientHandle Then
                Return CStr(de.Key)
            End If
        End While
        Throw New Exception("Tag is not defined for the client handle!!")
    End Function

    Friend Function GetPLCTagNames() As List(Of String)
        Dim list As New List(Of String)
        For Each pair As KeyValuePair(Of String, Integer) In _opcPLCTagList
            list.Add(pair.Key)
        Next
        Return list
    End Function

    Friend Function GetPLCTagNameWithHandles() As Dictionary(Of String, Integer)
        Return _opcPLCTagList
    End Function

    ''' <summary>
    ''' This sub will only be fired if IsOPCGlobalDataChangeEventSuppressing is set to true
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Friend Sub RaiseGroupDataChangeEvent(e As OpcGroupDataChangeEventArgs)
        If OpcComm.ThreadMode = OpcThreadMode.MULTI_THREADED Then
            RaiseMultiThreadedEvent(DataChangeEventEvent, New Object() {Me, e})
        Else
            RaiseEvent DataChangeEvent(Me, e)
        End If
    End Sub

#End Region

#Region "IDisposable Support"

    Private disposedValue As Boolean ' To detect redundant calls

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    ' IDisposable
    Protected Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _opcObjects.Clear()
                _opcPLCTagList.Clear()
                _opcObjects = Nothing
                _opcPLCTagList = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

#End Region

End Class