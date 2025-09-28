Imports System.ComponentModel

Namespace Interfaces

    Public Interface IOpcObject
        Inherits IOpcPlcNameLinkable

#Region "Properties"

        ReadOnly Property FilterProperties As String()

        ''' <summary>
        ''' Group name of the item
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property GroupName() As String

        ''' <summary>
        ''' To tell if the object is still loading information to the properties
        ''' </summary>
        ''' <value>Boolean to tell if it is still registering</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <Browsable(False)>
        ReadOnly Property IsRegisteringInProgress() As Boolean

        ReadOnly Property IsSerializable() As Boolean

        ReadOnly Property ListOfOpcTags() As Dictionary(Of String, Integer)

        <Browsable(False)>
        Property RegisterItems() As Integer

        ''' <summary>
        ''' Tag number of the item. If this is an UDT the format of the tag would be [PLC_Topic_Name]TagName.SubTagName.SubSubTagName
        ''' </summary>
        ''' <value>Name of the tag</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property TagName() As String

        ''' <summary>
        ''' Time stamp to show when the item was come in
        ''' </summary>
        Property TimeStamp() As DateTime

#End Region

#Region "Events"

        ''' <summary>
        ''' Items registering has been completed. This only fires one time
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Event ItemsRegisteringCompleted(sender As IOpcObject, e As System.EventArgs)

        ''' <summary>
        ''' Raise event to tell the object's properties have been changed
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Event PropertiesUpdateCompleted(sender As IOpcObject, e As System.EventArgs)

#End Region

#Region "Methods"

        ''' <summary>
        ''' This is used to get the tag name of a property in a class. The format should be
        ''' [PLCName]TagName.Property.SubProperty etc...
        ''' </summary>
        ''' <param name="itemName">Should not be included the TagName</param>
        ''' <returns>PLC compliance tag name</returns>
        ''' <remarks></remarks>
        Function GetPlcTagName(itemName As String) As String

        ''' <summary>
        ''' Get the tag name in the opc item format [PLC_Topic_Name]Item_Name.Sub_Item_Name.Sub_Sub_Item_Name
        ''' </summary>
        ''' <returns>List of opc items</returns>
        ''' <remarks></remarks>
        Function GetPlcTagNames() As String()

        ''' <summary>
        ''' Get the index of the index so that the OPC server can put value in the right property
        ''' </summary>
        ''' <param name="plcTag">PLC tag is in the format of [PLC_Topic_Name]TagName.SubTagName</param>
        ''' <returns>Index of the property</returns>
        ''' <remarks></remarks>
        Function GetPropertyIndex(plcTag As String) As Integer

        ''' <summary>
        ''' This is to tell the object to raise an event if any of the property value has been
        ''' changed in the data change event
        ''' </summary>
        ''' <param name="e">Dummy System.EventArgs</param>
        ''' <remarks></remarks>
        Sub RaisePropertiesUpdatedEvent(e As System.EventArgs)

        ''' <summary>
        ''' Create a copy of the object
        ''' </summary>
        Function ShallowClone() As IOpcObject

        ''' <summary>
        ''' Value to be put in to the PLC from the OPC object
        ''' </summary>
        Sub ValueFromObjectToPlc(itemName As String, value As Object, Optional asyncWrite As Boolean = False)

        ''' <summary>
        ''' Value requested from the PLC and stored in the OPC object
        ''' </summary>
        Sub ValueFromPlcToObject(index As Integer, value As Object)

#End Region

    End Interface

End Namespace