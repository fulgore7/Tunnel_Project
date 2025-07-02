Imports Wdw_Sust.Core.Interfaces

Namespace Configurations
    Public Class EditableSingletonConfigurationManager(Of TConfigurationMangaer As IEditableConfigurationManager(Of T), T As IConfigurationFile)
        Inherits EditableConfigurationManager(Of T)
#Region "Fields"
        Private Shared _instance As TConfigurationMangaer
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
        Public Shared ReadOnly Property Instance As TConfigurationMangaer
            Get
                If _instance Is Nothing Then
                    SyncLock LOCK_OBJECT
                        _instance = Activator.CreateInstance(GetType(TConfigurationMangaer))
                    End SyncLock
                End If
                Return _instance
            End Get
        End Property

#End Region

#Region "Constructors"
        Protected Sub New()

        End Sub
#End Region


    End Class
End Namespace

