Imports System.ComponentModel
Imports System.IO

Imports Wdw_Sust.Core.Interfaces
Imports Wdw_Sust.Core.Serialization
Imports Wdw_Sust.Core.Validation

Namespace Configurations

    <Serializable>
    Public Class ConfigurationManager(Of T As IConfigurationFile)
        Implements IConfigurationManager(Of T)

#Region "Fields"
        Private _configObject As T
        Private _isConfigFileADefault As Boolean
#End Region

#Region "Events"
        Public Event ConfigFileNotFoundEvent As EventHandler(Of System.EventArgs)
        Public Event ConfigFileDoesNotMatchTypeEvent As EventHandler(Of System.EventArgs)
        Public Event ConfigFileIsCorruptedEvent As EventHandler(Of System.EventArgs)
        Public Event ConfigFileSavedEvent As EventHandler(Of System.EventArgs)
        Public Event ConfigObjectChanged As EventHandler(Of PropertyChangedEventArgs)
        Public Event ConfigFileLoadCompletedEvent As EventHandler(Of System.EventArgs)
#End Region

#Region "Properties"
        Public Property ConfigurationFileName As String Implements IConfigurationManager.ConfigurationFileName
        Public ReadOnly Property IsConfigFileADefault As Boolean
            Get
                Return _isConfigFileADefault
            End Get
        End Property

        Public Property ConfigurationDirectory As String Implements IConfigurationManager.ConfigurationDirectory
        ''' <summary>
        ''' By calling config file.
        ''' </summary>
        ''' <value>The configuration file.</value>
        Public Property ConfigFile As T Implements IConfigurationManager(Of T).ConfigFile
            Get
                If _configObject Is Nothing Then
                    Load()
                    AddHandler _configObject.PropertyChanged, AddressOf OnPropertyChanged
                End If
                Return _configObject
            End Get
            Set(value As T)
                _configObject = value
            End Set
        End Property
        Public ReadOnly Property ConfigurationFilePath As String Implements IConfigurationManager.ConfigurationFilePath
            Get
                If String.IsNullOrEmpty(ConfigurationDirectory) Then Return ConfigurationFileName
                If ConfigurationDirectory.EndsWith("\") Then Return String.Format("{0}{1}", ConfigurationDirectory, ConfigurationFileName)
                Return String.Format("{0}\{1}", ConfigurationDirectory, ConfigurationFileName)
            End Get
        End Property
#End Region

#Region "Methods"
        Protected Sub AddConfigurationCheckBusinessRule(ByVal ruleName As String, ByVal rule As Func(Of Object, Boolean), ByVal msgToDisplayWhenFail As String)
            BusinessRuleManager.AddRule(GetType(T), msgToDisplayWhenFail, ruleName, Function() rule(False))
        End Sub
        ''' <summary>
        ''' Determines whether the config file is valid. This is returning true with no checking until the function is overridden
        ''' with the IsValid property.
        ''' </summary>
        ''' <returns><c>true</c> if [is configured properly]; otherwise, <c>false</c>.</returns>
        Public Overridable Function IsConfiguredProperly() As Boolean
            Return ConfigFile.IsValid
        End Function

        ''' <summary>
        ''' This sub routine is called after the file is saved
        ''' </summary>
        ''' <param name="e"></param>
        Protected Sub OnSavedConfigFileEvent(ByVal e As System.EventArgs)
            RaiseEvent ConfigFileSavedEvent(Me, e)
        End Sub

        ''' <summary>
        ''' The event-invoking method that derived classes can override.
        ''' </summary>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Protected Sub OnConfigFileNotFoundEvent(e As System.EventArgs)
            RaiseEvent ConfigFileNotFoundEvent(Me, e)
        End Sub

        Protected Sub OnConfigFileDoesNotMatchTypeEvent(e As System.EventArgs)
            RaiseEvent ConfigFileDoesNotMatchTypeEvent(Me, e)
        End Sub

        Protected Sub OnConfigFileLoadCompletedEvent(e As System.EventArgs)
            RaiseEvent ConfigFileLoadCompletedEvent(Me, e)
        End Sub

        Protected Sub OnConfigFileIsCorruptedEvent(e As System.EventArgs)
            RaiseEvent ConfigFileIsCorruptedEvent(Me, e)
        End Sub

        Public Function Exist() As Boolean Implements IConfigurationManager(Of T).Exist
            Return IO.File.Exists(ConfigurationFilePath)
        End Function

        ''' <summary>
        ''' Loads from configuration object.
        ''' </summary>
        ''' <param name="configFile">The configuration file.</param>
        Public Sub LoadFromConfigObject(ByVal configFile As T)
            _configObject = configFile
        End Sub

        Protected Overridable Function OnCreateConfigFileObject() As T
            Return SerializationManager.DeserializeFromXmlFile(Of T)(ConfigurationFilePath)
        End Function

        Public Sub Load() Implements IConfigurationManager(Of T).Load
            If Not Exist() Then
                _isConfigFileADefault = True
                _configObject = GetDefaultSettings()
                OnConfigFileNotFoundEvent(System.EventArgs.Empty)
            Else
                _configObject = OnCreateConfigFileObject()
                If Not TypeOf _configObject Is T Then
                    OnConfigFileDoesNotMatchTypeEvent(System.EventArgs.Empty)
                    _configObject = GetDefaultSettings()
                End If
                If _configObject Is Nothing Then
                    OnConfigFileIsCorruptedEvent(System.EventArgs.Empty)
                    _configObject = GetDefaultSettings()
                End If
            End If
            OnConfigFileLoadCompletedEvent(System.EventArgs.Empty)
        End Sub

        ''' <summary>
        ''' This function needs to be called to get the config file saved.
        ''' </summary>
        ''' <returns><c>true</c> if the file is save successfully, <c>false</c> otherwise.</returns>
        Public Overridable Function Save() As Boolean Implements IConfigurationManager.Save
            Try
                If _configObject IsNot Nothing Then
                    ConfigFile.LastUpdated = Now()
                    If Directory.Exists(ConfigurationDirectory) = False Then Directory.CreateDirectory(ConfigurationDirectory)
                    SerializationManager.SerializeToXML(ConfigurationFilePath, ConfigFile, FileMode.OpenOrCreate)
                    OnSavedConfigFileEvent(System.EventArgs.Empty)
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        Public Function SaveWhenFileNotFound() As Boolean
            If Not Exist() Then Return Save()
            Return False
        End Function

        Private Sub Save(ByVal configFile As IConfigurationFile)
            configFile.LastUpdated = Now
            SerializationManager.SerializeToXML(Of T)(ConfigurationFilePath, configFile, FileMode.Create)
        End Sub

        Protected Sub OnPropertyChanged(ByVal sender As Object, e As PropertyChangedEventArgs)
            If IsConfigFileADefault Then _isConfigFileADefault = False
            RaiseEvent ConfigObjectChanged(Me, e)
        End Sub

        Protected Overridable Function GetDefaultSettings() As T
            Return Activator.CreateInstance(GetType(T))
        End Function

#End Region

#Region "Constructors"
        Public Sub New()
            Me.New(".")
        End Sub

        Public Sub New(configurationDirectory As String, Optional ByVal configurationFileName As String = Nothing)
            If String.IsNullOrEmpty(configurationDirectory) Then
                Throw New ArgumentException("configurationDirectory")
            End If
            If (Not Directory.Exists(configurationDirectory)) Then
                Directory.CreateDirectory(configurationDirectory)
            End If
            Me.ConfigurationDirectory = configurationDirectory
            If configurationFileName Is Nothing Then Me.ConfigurationFileName = String.Format("{0}.xml", GetType(T).Name)
        End Sub
#End Region

    End Class
End Namespace




