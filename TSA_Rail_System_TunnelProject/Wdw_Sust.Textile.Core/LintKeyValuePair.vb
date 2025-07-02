Imports System.Data

''' <summary>
''' This class is used to create a list of name and value pair, such as Machine ID / Machine Name
''' or Rail Step ID / Rail Step description
''' </summary>
''' <remarks></remarks>
<Serializable()>
Public Class LintKeyValuePair(Of K, V)
    Inherits LintObjectBase(Of LintKeyValuePair(Of K, V))

    Private _key As K
    Private _value As V

#Region "Properties"
    Public Property Key() As K
        Get
            Return _key
        End Get
        Set(value As K)
            _key = value
        End Set
    End Property
    Public Property Value() As V
        Get
            Return _value
        End Get
        Set(value As V)
            _value = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Overrides Function ToString() As String
        Return String.Format("Key: {0}, Value: {1}", Key, Value)
    End Function
#End Region

#Region "Constructors"
    Public Sub New(ByVal key As K, ByVal value As V)
        _key = key
        _value = value
    End Sub

    Public Sub New(ByVal reader As IDataReader)
        _key = CType(reader(0), K)
        _value = CType(reader(1), V)
    End Sub

    Public Sub New()

    End Sub

#End Region

End Class