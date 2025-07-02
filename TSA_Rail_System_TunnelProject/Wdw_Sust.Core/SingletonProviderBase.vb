<Serializable()>
Public MustInherit Class SingletonProviderBase(Of SpecifiedProvider As Class)

#Region "Fields"
    Private Shared _instance As SpecifiedProvider
    Private Shared ReadOnly LOCK_OBJECT As New Object()
#End Region

#Region "Properties"
    ''' <summary>
    ''' This property should be used to ensure that one and only one 
    ''' instance is being pointed to and used at all time
    ''' </summary>
    ''' <value>An Instance of the class</value>
    ''' <returns>An Instance of the class</returns>
    ''' <remarks>An Instance of the class</remarks>
    Public Shared ReadOnly Property Instance(Optional ByVal parameters() As Object = Nothing) As SpecifiedProvider
        Get
            If _instance Is Nothing Then
                SyncLock LOCK_OBJECT
                    _instance = Activator.CreateInstance(GetType(SpecifiedProvider), parameters)
                End SyncLock
            End If
            Return _instance
        End Get
    End Property

#End Region

End Class

