Namespace Sort

    ''' <summary>
    ''' Used to sort data
    ''' </summary>
    ''' <typeparam name="T">Generic type for the data to sort</typeparam>
    ''' <remarks></remarks>
    Public Class SortManager(Of T)
        Implements IComparer(Of T)

        Private _sortBy As String
        Private _sortPropertyExpressions As SortedProperty()

        Public Property Sort() As SortDirection

        Public Overridable Function Compare(ByVal x As T, ByVal y As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare
            If SortBy Is Nothing Then
                If Attribute.IsDefined(x.GetType, GetType(DefaultSortByPropertyAttribute)) Then
                    Dim a As DefaultSortByPropertyAttribute = Attribute.GetCustomAttribute(x.GetType, GetType(DefaultSortByPropertyAttribute))
                    SortBy = String.Format("{0} {1}", a.DefaultSortByPropertyName, a.SortDirection.ToString)
                Else
                    Throw New Exception("Specify which property of the class to sort by using Class_Name.Comparer.SortBy!!")
                End If
            End If
            Return CheckSort(0, x, y)
        End Function

        ''' <summary>
        ''' This is a recursive function to compare each property to perform a multi property sort. If there is
        ''' is a tie it will perform the function recursively until there is no tie or all properties needed 
        ''' to be sorted has been tried already.
        ''' </summary>
        ''' <param name="sortLevel">Keeping track of which level it is sorting at the moment</param>
        ''' <param name="x"></param>
        ''' <param name="y"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function CheckSort(ByVal sortLevel As Integer, ByVal x As T, ByVal y As T) As Integer
            Try
                Dim returnValue As Integer = 0
                If _sortPropertyExpressions.Length - 1 >= sortLevel Then
                    Dim xValue, yValue As IComparable
                    Dim itemX As T = DirectCast(x, T)
                    Dim itemY As T = DirectCast(y, T)
                    xValue = itemX.GetType.GetProperty(_sortPropertyExpressions(sortLevel).PropertyName).GetValue(itemX, Nothing)
                    yValue = itemY.GetType.GetProperty(_sortPropertyExpressions(sortLevel).PropertyName).GetValue(itemY, Nothing)
                    Select Case _sortPropertyExpressions(sortLevel).SortDirection
                        Case SortDirection.ASC
                            returnValue = xValue.CompareTo(yValue)
                        Case SortDirection.DESC
                            returnValue = yValue.CompareTo(xValue)
                    End Select
                    If returnValue = 0 Then
                        returnValue = CheckSort(sortLevel + 1, x, y)
                    End If
                End If
                Return returnValue
            Catch ex As Exception
                Throw New Exception("Property name not defined properly. Please check spelling!!")
            End Try

        End Function

        ''' <summary>
        ''' This is to keep track of which property needs to be sorted.
        ''' </summary>
        ''' <param name="sortExpression"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetSortedByList(ByVal sortExpression As String) As SortedProperty()
            Dim list() As String = sortExpression.Split(",")
            Dim listOfProperties As New List(Of SortedProperty)
            For Each s As String In list
                If s.ToLower.EndsWith(" desc") Then
                    listOfProperties.Add(New SortedProperty(s.Substring(0, s.Length - 5).Trim, SortDirection.DESC))
                ElseIf s.ToLower.EndsWith(" asc") Then
                    listOfProperties.Add(New SortedProperty(s.Substring(0, s.Length - 4).Trim, SortDirection.ASC))
                Else
                    listOfProperties.Add(New SortedProperty(s.Trim, SortDirection.ASC))
                End If
            Next
            Return listOfProperties.ToArray
        End Function

        Public Sub New(ByVal sort As SortDirection, ByVal sortBy As String)
            _Sort = sort
            _sortBy = sortBy
        End Sub

        Public Sub New(ByVal sort As SortDirection)
            _Sort = sort
            _sortBy = Nothing
        End Sub

        ''' <summary>
        ''' This 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property SortBy() As String
            Get
                Return _sortBy
            End Get
            Set(ByVal value As String)
                _sortBy = value
                _sortPropertyExpressions = GetSortedByList(_sortBy)
            End Set
        End Property
    End Class

    Friend Class SortedProperty

        Private _sortDirection As SortDirection
        Private _propertyName As String

        Public Property PropertyName() As String
            Get
                Return _propertyName
            End Get
            Set(ByVal value As String)
                _propertyName = value
            End Set
        End Property

        Public Property SortDirection() As SortDirection
            Get
                Return _sortDirection
            End Get
            Set(ByVal value As SortDirection)
                _sortDirection = value
            End Set
        End Property

        Public Sub New(ByVal propertyName As String, ByVal sortDirection As SortDirection)
            _propertyName = propertyName
            _sortDirection = sortDirection
        End Sub
    End Class

    <AttributeUsage(AttributeTargets.Class)>
    Public Class DefaultSortByPropertyAttribute
        Inherits Attribute

        Public Property DefaultSortByPropertyName As String
        Public Property SortDirection As SortDirection

        Public Sub New(ByVal defaultSortByPropertyName As String, Optional ByVal sortDirection As SortDirection = SortDirection.ASC)
            Me.DefaultSortByPropertyName = defaultSortByPropertyName
            Me.SortDirection = sortDirection
        End Sub
    End Class
End Namespace

