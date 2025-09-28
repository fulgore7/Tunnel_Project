Imports System.ComponentModel
Imports WDW_SUST.Textile.LINT.Core

Namespace Textile.LINT.OPC.Core
    <Serializable()> _
    Public Class OPCObjectBaseNew
        Implements IOPCObject, IOPCPLCNameLinkable, ILINTObject
        Private _filterProperties As String()
        ''' <summary>
        ''' To be overridden by the derived class for specific filtering
        ''' </summary>
        ''' <remarks>Override SetPropertyFilter</remarks>
        <NonSerialized()> _
        Private _filterString As String = "Date,DateTime,Chars,IsDirty,"
        Private _list As New Dictionary(Of Integer, OPCItemPropertyItem)
        Public Function GetPLCTagName(ByVal itemName As String) As String Implements IOPCObject.GetPLCTagName



        End Function
        ''' <summary>
        ''' Used to filter the property not needed for the OPC object class. This will optimize the OPC communication.
        ''' When an OPC object inherits from a normal class, some of the properties may not be needed for OPC. Those
        ''' properties can be put here.
        ''' </summary>
        <Attributes.NotConnectableOPCItem()> _
        Private ReadOnly Property FilterProperties() As String()
            Get
                If _filterProperties Is Nothing Then _filterProperties = SetPropertyFilter(_filterString)
                Return _filterProperties
            End Get
        End Property

        Public Function GetPLCTagNames() As String() Implements IOPCObject.GetPLCTagNames
            Dim list As New List(Of String)
            If _list.Count = 0 Then
                Dim propertyIndex As Integer = 1
                For Each tag As String In OPCHelper.GetPLCTags(Me, Filter)
                    _list.Add(OPCHelper.OPC_CLIENT_HANDLE_INDEX, New OPCItemPropertyItem With {.ClientHandle = OPC_CLIENT_HANDLE_INDEX, .PropertyIndex = propertyIndex, .PLCTagName = tag})
                    OPC_CLIENT_HANDLE_INDEX += 1
                    propertyIndex += 1
                Next
            End If
            For Each propertyItem As OPCItemPropertyItem In _list.Values
                list.Add(propertyItem.PLCTagName)
            Next
        End Function

        Public Function GetPropertyIndex(ByVal plcTag As String) As Integer Implements IOPCObject.GetPropertyIndex
            For Each propItem As OPCItemPropertyItem In _list.Values
                If propItem.PLCTagName = plcTag Then
                    Return propItem.PropertyIndex
                End If
            Next
            Throw New ArgumentException("PLC tag does not have a valid property index!!")
        End Function

        Public Property GroupName As String Implements IOPCObject.GroupName
#Region "Protected"
        ''' <summary>
        ''' Use to extend the filter to include any unnecessary items for the opc communication
        ''' in the class
        ''' </summary>
        ''' <param name="addedFilters">filter to be added</param>
        ''' <returns></returns>
        ''' <remarks>There is already a pre-defined filter already. If there are more items
        ''' needed to be removed, this function needs to be call</remarks>
        ''' <example>
        ''' <code>
        ''' Protected Overrides Function SetPropertyFilter(ByRef addedFilters As String) As String()
        '''     addedFilters += "Source_Washer,Recirculation_Destination,Estimated_Pieces,Soiled_Weight"
        '''     Return MyBase.SetPropertyFilter(addedFilters)
        ''' End Function
        ''' </code>
        ''' </example>
        Protected Overridable Function SetPropertyFilter(ByRef addedFilters As String) As String()
            _filterString = _filterString.Replace(" ", "")
            If _filterString.LastIndexOf(",") = _filterString.Length - 1 Then
                _filterString.Remove(_filterString.Length - 1, 1)
            End If
            Return _filterString.Split(",")
        End Function
        Public ReadOnly Property IsRegisteringInProgress As Boolean Implements IOPCObject.IsRegisteringInProgress
            Get

            End Get
        End Property

        Public ReadOnly Property IsSerializable As Boolean Implements IOPCObject.IsSerializable
            Get
                Return True
            End Get
        End Property

        Public Event ItemsRegisteringCompleted(ByVal sender As IOPCObject, ByVal e As System.EventArgs) Implements IOPCObject.ItemsRegisteringCompleted

        Public Event PropertiesUpdateCompleted(ByVal sender As IOPCObject, ByVal e As System.EventArgs) Implements IOPCObject.PropertiesUpdateCompleted

        Public Sub RaisePropertiesUpdatedEvent(ByVal e As System.EventArgs) Implements IOPCObject.RaisePropertiesUpdatedEvent

        End Sub

        Public Property RegisterItems As Integer Implements IOPCObject.RegisterItems


        Public Function ShallowClone() As IOPCObject Implements IOPCObject.ShallowClone

        End Function

        Public Property TagName As String Implements IOPCObject.TagName

        Public Property TimeStamp As Date Implements IOPCObject.TimeStamp


        Public Sub ValueFromObjectToPLC(ByVal itemName As String, ByVal value As Object, Optional ByVal asyncWrite As Boolean = False) Implements IOPCObject.ValueFromObjectToPLC

        End Sub

        Public Sub ValueFromPLCToObject(ByVal index As Integer, ByVal value As Object) Implements IOPCObject.ValueFromPLCToObject

        End Sub

        Public Property PLCName As String Implements IOPCPLCNameLinkable.PLCName

        Public Property ObjectIdentifier As String Implements WDW_SUST.Textile.LINT.Core.ILINTObject.ObjectIdentifier
            Get

            End Get
            Set(ByVal value As String)

            End Set
        End Property
    End Class
End Namespace