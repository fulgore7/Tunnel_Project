Imports Wdw_Sust.Core.Attributes

<Serializable()>
Public Class OpcElement
    Inherits OpcObjectBase

#Region "Fields"

    Private _value As Object

#End Region

#Region "Properties"

    <NotConnectableOpcItem>
    Public Overridable Property Value() As Object
        Get
            Return _value
        End Get
        Set(value As Object)
            If Me._value <> value Then
                Me.ValueFromObjectToPlc("Value", value)
                SetField(_value, value)
                _value = value
            End If
        End Set
    End Property

#End Region

#Region "Methods"

    Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
        Select Case index
            Case 1
                _value = value
            Case Else
                Throw New IndexOutOfRangeException("Index is out of range!!")
        End Select
    End Sub

#End Region

#Region "Constructors"

    Public Sub New(plcName As String, tagName As String, groupName As String)
        MyBase.New(plcName, tagName, groupName)
    End Sub

    ''' <summary>
    ''' Create new object for the class. if groupName is not defined, it will be the same as the TagName)
    ''' </summary>
    ''' <param name="plcName">Name of the PLC topic name</param>
    ''' <param name="tagName">Name of the tag name</param>
    ''' <remarks></remarks>
    Public Sub New(plcName As String, tagName As String)
        MyBase.New(plcName, tagName)
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class

<Serializable()>
Public Class OpcElement(Of T)
    Inherits OpcElement

    Public Shadows Property Value As T

    Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
        Me.Value = CType(value, T)
    End Sub

#Region "Constructors"

    Public Sub New(plcName As String, tagName As String, groupName As String)
        MyBase.New(plcName, tagName, groupName)
    End Sub

    ''' <summary>
    ''' Create new object for the class. if groupName is not defined, it will be the same as the TagName)
    ''' </summary>
    ''' <param name="plcName">Name of the PLC topic name</param>
    ''' <param name="tagName">Name of the tag name</param>
    ''' <remarks></remarks>
    Public Sub New(plcName As String, tagName As String)
        MyBase.New(plcName, tagName)
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class