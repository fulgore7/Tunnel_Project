Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization
Imports Wdw_Sust.Core.Validation

Namespace Configurations.Core
    <Serializable>
    Public Class ConfigurationFileBase(Of T)
        Inherits BufferedNotifyableBase(Of T)
        Implements IConfigurationFile(Of T)

        Public Overridable ReadOnly Property IsValid As Boolean Implements ICanCheckValidity.IsValid
            Get
                Dim isObjectValid As Boolean = True
                If BusinessRuleManager.HasRules(Me.GetType) Then
                    isObjectValid = BusinessRuleManager.CheckRules(Me)
                End If
                Return isObjectValid
            End Get
        End Property

        Public Overridable ReadOnly Property IsInitialized As Boolean Implements IConfigurationFile.IsInitialized
            Get
                Return True
            End Get
        End Property

        Public Property LastUpdated As Date Implements IConfigurationFile.LastUpdated

        Public Function Clone() As T Implements IConfigurationFile(Of T).Clone
            Try
                Return SerializationManager.DeserializeData(SerializationManager.SerializeData(Me))
            Catch ex As Exception
                Console.WriteLine("Clone failed for object type {0}", Me.GetType.ToString)
                Return Nothing
            End Try
        End Function
    End Class

    <Serializable>
    Public Class ConfigurationFileBase
        Inherits NotifyableBase
        Implements IConfigurationFile

        ''' <summary>
        ''' Returns true if the object status is valid.
        ''' Check out <see cref="Wdw_Sust.Core.Validation.BusinessRuleManager"/> for more informations.
        ''' </summary>
        ''' <value><c>true</c> if this instance is valid; otherwise, <c>false</c>.</value>
        Public ReadOnly Property IsValid As Boolean Implements ICanCheckValidity.IsValid
            Get
                Dim isObjectValid As Boolean = True
                If BusinessRuleManager.HasRules(Me.GetType) Then
                    isObjectValid = BusinessRuleManager.CheckRules(Me)
                End If
                Return isObjectValid
            End Get
        End Property
        Public Overridable ReadOnly Property IsInitialized As Boolean Implements IConfigurationFile.IsInitialized
            Get
                Return True
            End Get
        End Property

        Public Property LastUpdated As Date Implements IConfigurationFile.LastUpdated
    End Class
End Namespace

