Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Reflection

Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization
Imports Wdw_Sust.Core.Sort
Imports Wdw_Sust.Core.Validation

<Serializable()>
Public MustInherit Class LintObjectBase
    Inherits LintJobManagerBase
    Implements ICanBeDirty, ICanCheckValidity

    Public Property IsDirty As Boolean Implements ICanBeDirty.IsDirty

    ''' <summary>
    ''' This is to test if the object has business rules associated with it.
    ''' If there are any, by calling this property the object will verify its data
    ''' to the rules and return a boolean to indicate if this is valid or not.
    ''' Default is returned "True"
    ''' </summary>
    ''' <value>Boolean value to indicate if the object is valid or not.</value>
    ''' <returns></returns>
    ''' <remarks>Please check the class "BusinessRuleManager" to learn how to apply business rules.</remarks>
    Public Overridable ReadOnly Property IsValid As Boolean Implements ICanCheckValidity.IsValid
        Get
            Dim isObjectValid As Boolean = True
            If BusinessRuleManager.HasRules(Me.GetType) Then
                isObjectValid = BusinessRuleManager.CheckRules(Me)
            End If
            Return isObjectValid
        End Get
    End Property

End Class

<Serializable()>
Public MustInherit Class LintObjectBase(Of T)
    Inherits LintObjectBase
    Implements IComparable, ICloneable, IEditableObject, INotifyPropertyChanged

#Region "Fields"

    Private Shared _comparer As SortManager(Of Object)

#End Region

#Region "Properties"

    ''' <summary>
    ''' This is to tell how to sort a list of the same object. This property
    ''' only works if you are only sorting one property at a time
    ''' </summary>
    ''' <value>Ascending or descending</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Property Sort() As SortDirection
        Get
            Return Comparer.Sort
        End Get
        Set(value As SortDirection)
            Comparer.Sort = value
        End Set
    End Property

    ''' <summary>
    ''' Property name used to be sorting the elements in the list. Property names are case sensitive.
    ''' For example "PropertyNameA, PropertyNameB DESC", where PropertyNameA is sorted in ascending order
    ''' and PropertyNameB in descending order.
    ''' </summary>
    ''' <value>Name of the property</value>
    ''' <returns></returns>
    ''' <remarks>This must be the same as the name of the property</remarks>
    Public Shared Property SortBy() As String
        Get
            Return Comparer.SortBy
        End Get
        Set(value As String)
            If Not value.Contains(",") AndAlso Not value.Contains(" ") Then
                Comparer.SortBy = String.Format("{0} {1}", value, Sort.ToString)
            Else
                Comparer.SortBy = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Comparer to make the sorting algorithm work
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared ReadOnly Property Comparer() As SortManager(Of Object)
        Get
            If _comparer Is Nothing Then
                _comparer = New SortManager(Of Object)(SortDirection.ASC)
            End If
            Return _comparer
        End Get
    End Property

    Public Shared Sub ReverseSort()
        If Comparer.Sort = SortDirection.ASC Then
            Comparer.Sort = SortDirection.DESC
        Else
            Comparer.Sort = SortDirection.ASC
        End If
    End Sub

#End Region

#Region "Events"

    <NonSerialized()>
    Public Event CloneProcessCompleted(sender As Object, e As System.EventArgs)

    <NonSerialized()>
    Public Event OnValidatingEvent(sender As Object, e As System.EventArgs)

#End Region

#Region "Methods"

    ''' <summary>
    ''' Start edit of object
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        ' code was commented out and removed.  See history for what was originally here.
    End Sub

    ''' <summary>
    ''' Cancel edit of the object
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CancelEdit() Implements IEditableObject.CancelEdit
        ' code was commented out and removed.  See history for what was originally here.
    End Sub

    ''' <summary>
    ''' Create a clone of the object with data. This is a deep clone of the object.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Clone() As T
        Try
            Dim obj As T = CType(SerializationManager.DeserializeData(SerializationManager.SerializeData(Me)), T)
            RaiseEvent CloneProcessCompleted(Me, System.EventArgs.Empty)
            Return obj
        Catch ex As Exception
            Console.WriteLine("Clone failed for object type {0}", Me.GetType.ToString)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Tell the interface if the object needs to be updated
    ''' to the database
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
        Return Comparer.Compare(Me, obj)
    End Function

    ''' <summary>
    ''' Finish edit of the object
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EndEdit() Implements IEditableObject.EndEdit
        ' code was commented out and removed.  See history for what was originally here.
    End Sub

    Private Function ICloneable_Clone() As Object Implements System.ICloneable.Clone
        Return Clone()
    End Function

#End Region

#Region "Good Stuff"

    <NonSerialized>
    Public Shadows Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    Protected Shadows Sub OnPropertyChanged(Of U)(propertyExpression As Expression(Of Func(Of U)))
        Dim propertyName As String = ExtractPropertyName(propertyExpression)
        OnPropertyChanged(propertyName)
    End Sub

    Private Shared Function ExtractPropertyName(Of U)(propertyExpression As Expression(Of Func(Of U))) As String
        If propertyExpression Is Nothing Then Throw New ArgumentNullException(NameOf(propertyExpression))
        Dim memberExpression As MemberExpression = propertyExpression.Body
        If memberExpression Is Nothing Then Throw New ArgumentException("memberExpression")
        Dim prop As PropertyInfo = memberExpression.Member
        If prop Is Nothing Then Throw New ArgumentException("property")
        Dim getMethod As MethodInfo = prop.GetGetMethod(True)
        If getMethod.IsStatic Then Throw New ArgumentException("static method")
        Return memberExpression.Member.Name
    End Function

    Private Shadows Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

#End Region

End Class