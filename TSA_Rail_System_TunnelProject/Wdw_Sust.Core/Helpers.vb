Imports System.ComponentModel
Imports System.Configuration
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Reflection
Imports System.Threading

Public Module Helpers

    ''' <summary>
    ''' Creates a folder in the directory specified, and returns the path as a string.
    '''
    ''' By default System.IO.Directory.CreateDirectory checks if the path exists, and creates if necessary.
    ''' </summary>
    ''' <param name="folderName">String</param>
    ''' <param name="location">Environment.SpecialFolder</param>
    ''' <returns>String</returns>
    Public Function BuildAndGetFilePath(folderName As String, location As Environment.SpecialFolder) As String
        Dim filePath As String = Path.Combine(Environment.GetFolderPath(location), folderName)

        Directory.CreateDirectory(filePath)

        Return filePath
    End Function

    ''' <summary>
    ''' Determines whether this instance can connect the specified IP address or domain.
    ''' </summary>
    ''' <param name="ipAddressOrDomain">The IP address or domain.</param>
    ''' <returns><c>true</c> if this instance can connect the specified IP address or domain; otherwise, <c>false</c>.</returns>
    Public Function CanConnect(ipAddressOrDomain As String) As Boolean
        Try
            Dim ping As New Ping()
            Dim reply = ping.Send(ipAddressOrDomain)
            Return reply.Status = IPStatus.Success
        Catch ex As Exception
            Debug.WriteLine("Exception in CanConnect " & ex.Message)
            Return False
        End Try
    End Function

    Public Function Convert(Of toType)(fromObject As Object, toObjectType As Type) As toType
        Dim toObject As Object = Activator.CreateInstance(toObjectType)
        If fromObject.GetType.Name <> toObject.GetType.Name Then
            Return Nothing
        End If
        Return toObject
    End Function

    ''' <summary>
    ''' Combine 2 integer values to a long value
    ''' </summary>
    ''' <param name="lowerBytes">The lower 32 bits of a long data-type</param>
    ''' <param name="higherBytes">The higher 32 bits of a long data-type</param>
    ''' <returns>a long value of the combined value</returns>
    ''' <remarks></remarks>
    Function Convert2IntegersToLong(lowerBytes As Integer, higherBytes As Integer) As Long
        Dim valuesToBeConverted As New List(Of Byte)
        valuesToBeConverted.AddRange(BitConverter.GetBytes(lowerBytes))
        valuesToBeConverted.AddRange(BitConverter.GetBytes(higherBytes))
        Return BitConverter.ToInt64(valuesToBeConverted.ToArray, 0)
    End Function

    ''' <summary>
    ''' Converts the hexadecimal to ASCII byte.
    ''' </summary>
    ''' <param name="hexDigit">The hexadecimal digit.</param>
    ''' <returns>System.Byte.</returns>
    Public Function ConvertHexToAsciiByte(hexDigit As Char) As Byte
        If Char.IsDigit(hexDigit) Then
            Return 48 + Val(hexDigit)
        Else
            Select Case Char.ToLower(hexDigit)
                Case "a"
                    Return 65
                Case "b"
                    Return 66
                Case "c"
                    Return 67
                Case "d"
                    Return 68
                Case "e"
                    Return 69
                Case "f"
                    Return 70
                Case Else
                    Throw New ArgumentException(String.Format("{0} is not in HEX format", hexDigit))
            End Select
        End If
    End Function

    ''' <summary>
    ''' Convert a long value to a Date Object
    ''' </summary>
    ''' <param name="timeInMicroSecond">Value in microsecond</param>
    ''' <param name="referenceTime">Time reference for the conversion of a long value</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConvertToDateTime(timeInMicroSecond As Int64, referenceTime As Date) As Date
        Dim milliseconds As Double = CDbl(timeInMicroSecond / 1000)
        Return referenceTime.AddMilliseconds(milliseconds).ToLocalTime
    End Function

    Public Function CreateAndRunBackgroundThread(ts As ThreadStart, Optional threadPriority As ThreadPriority = ThreadPriority.Normal) As Thread
        Dim t As Thread = CreateBackgroundThread(ts)
        t.Priority = threadPriority
        t.Start()
        Return t
    End Function

    Public Function CreateBackgroundThread(ts As ThreadStart) As Thread
        Dim t As New Thread(ts) With {.Priority = ThreadPriority.Normal, .IsBackground = True}
        t.TrySetApartmentState(ApartmentState.MTA)
        Return t
    End Function

    ''' <summary>
    ''' Displays the millisecond in time format.
    ''' </summary>
    ''' <param name="milliSecond">The millisecond.</param>
    ''' <returns>System.String.</returns>
    ''' <exception cref="ArgumentException">Parameter has to be an integer!</exception>
    Function DisplayMilliSecondInTimeFormat(milliSecond As Long) As String
        If Not IsNumeric(milliSecond) AndAlso milliSecond < 0 Then
            Throw New ArgumentException("Parameter has to be an integer!")
        End If
        Return DisplaySecondInTimeFormat(CInt(milliSecond / 1000))
    End Function

    ''' <summary>
    ''' Use to display the value into 00:00:00 format. Mainly this is used as a cycle timer
    ''' </summary>
    ''' <param name="second">Number of seconds in Long format</param>
    ''' <returns>String in 00:00:00 format</returns>
    ''' <remarks></remarks>
    Function DisplaySecondInTimeFormat(second As Long) As String
        If Not IsNumeric(second) AndAlso second < 0 Then
            Throw New ArgumentException("Parameter has to be an integer!")
        End If
        Dim span As New TimeSpan(TimeSpan.TicksPerSecond * second)
        Return String.Format("{0}:{1}:{2}", span.Hours.ToString("00"), span.Minutes.ToString("00"), span.Seconds.ToString("00"))
    End Function

    Function DisplayValueInTimeFormat(value As Long, unit As TimeUnit) As String
        Select Case unit
            Case TimeUnit.MilliSecond
                Return DisplayMilliSecondInTimeFormat(value)
            Case TimeUnit.Second
                Return DisplaySecondInTimeFormat(value)
            Case Else
                Throw New ArgumentException("Time unit not supported!")
        End Select
    End Function

    Public Function DoesFileExist(fileName As String) As Boolean
        If (File.Exists(fileName)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function FixNull(Of T)(dbValue As Object, Optional defaultValue As T = Nothing) As T
        If IsDBNull(dbValue) Then
            If defaultValue Is Nothing Then
                Return Nothing
            Else
                Return defaultValue
            End If
        Else
            Return CType(dbValue, T)
        End If
    End Function

    Public Function GetAppSetting(key As String) As String
        Dim value = ConfigurationManager.AppSettings(key)

        Return value
    End Function

    Public Function GetAppSetting(Of T)(keyName As String) As T
        Dim appSettings = ConfigurationManager.AppSettings
        Dim returnVal = CType(CObj(appSettings(keyName)), T)

        Return returnVal
    End Function

    ''' <summary>
    ''' Gets the class library assembly version.
    ''' </summary>
    ''' <returns>System.String.</returns>
    Public Function GetClassLibraryAssemblyVersion() As String
        Dim versionInfo As Version = Assembly.GetCallingAssembly.GetName.Version
        Return String.Format("{0}.{1}.{2}.{3}", versionInfo.Major, versionInfo.Minor, versionInfo.Build, versionInfo.Revision)
    End Function

    Public Function GetConfigFilePath(appName As String) As String
        Return BuildAndGetFilePath($"Wdw_sust Application Settings{Path.DirectorySeparatorChar}{appName}", Environment.SpecialFolder.CommonDocuments)
    End Function

    ''' <summary>
    ''' Gets the descriptions from an Enum type.
    ''' </summary>
    ''' <param name="enumType">Type of the enum.</param>
    ''' <returns>List(Of System.String).</returns>
    Function GetEnumDescriptions(enumType As System.Type) As List(Of String)
        Dim list As New List(Of String)
        'For Each name As [Enum] In [Enum].get
        For Each name As String In [Enum].GetNames(enumType)
            list.Add(name)
        Next
        list.Sort()
        Return list
    End Function

    Public Function GetEpochTime(inTime As DateTime) As Double
        Dim _timeSpan = (inTime.ToUniversalTime() - New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
        Return _timeSpan.TotalSeconds()
    End Function

    Public Function GetExecutingFileName() As String
        Return Path.GetFileName(Assembly.GetEntryAssembly().Location)
    End Function

    ''' <summary>
    ''' This is to break out an integer back to a list of enum. In order for this to work, the
    ''' enum values as to be in the binary format (1,2,4,8,16,32...)
    ''' </summary>
    ''' <typeparam name="T">The enum type</typeparam>
    ''' <param name="integerValue">Integer Value that holds a list of ENUMs</param>
    Public Function GetListOfEnumsFromInteger(Of T)(integerValue As Integer) As List(Of T)
        If Not GetType(T).IsEnum Then Throw New ArgumentException("Generic Type T must be an Enum Type")
        Dim types As New List(Of T)
        Array.ForEach(Of T)([Enum].GetValues(GetType(T)), Sub(a) If (CInt(CObj(a)) And integerValue) = CInt(CObj(a)) Then types.Add(a))
        If types.Count = 0 Then Return Nothing
        Return types
    End Function

    Function GetMemoryUsage() As String
        Using thisProc As Process = Process.GetCurrentProcess()
            Return String.Format("{0} KB", thisProc.PrivateMemorySize64 / 1024)
        End Using
        'Return Nothing
    End Function

    Function GetProcessId() As String
        Using thisProc As Process = Process.GetCurrentProcess()
            Return String.Format("{0}", thisProc.Id.ToString())
        End Using
        'Return Nothing
    End Function

    ''' <summary>
    ''' Get a random number between 1 and integer.MaxValue
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetRandomNumber() As Integer
        Dim r As New Random
        Return r.Next(1, Integer.MaxValue)
    End Function

    Public Function GetTowelFoldProductCode(incomingProductCode As Integer) As Integer
        Dim outgoingProductCode As Integer

        Select Case incomingProductCode
            Case 1 Or 2
                outgoingProductCode = 4 'hand towels
            Case 3 Or 4
                outgoingProductCode = 5 'bath towels
            Case 5 Or 6
                outgoingProductCode = 6 'bath mats
            Case 7 Or 8
                outgoingProductCode = 7 'pool towels
            Case Else
                outgoingProductCode = 999
        End Select

        Return outgoingProductCode
    End Function

    Public Function GetWorkStationName() As String
        Return Net.Dns.GetHostName()
    End Function

    Public Sub OpenInBrowser(url As String)
        Dim webAddress As String = url
        Process.Start(webAddress)
    End Sub

    Sub RaiseMultiThreadedEvent(e As [Delegate], data As Object())
        If e IsNot Nothing Then
            For Each c As [Delegate] In e.GetInvocationList
                Dim t As ISynchronizeInvoke = TryCast(c.Target, ISynchronizeInvoke)
                If t IsNot Nothing AndAlso t.InvokeRequired Then
                    t.BeginInvoke(c, data)
                Else
                    c.DynamicInvoke(data)
                End If
            Next
        End If
    End Sub

    Public Function TryAction(act As Action) As Boolean
        Return TryAction(Of Exception)(act)
    End Function

    Public Function TryAction(act As Action, Optional ByRef messageOut As String = Nothing, Optional writeLogIfError As Boolean = True, Optional errorTraceCode As Integer = 0) As Boolean
        Return TryAction(Of Exception)(act, messageOut, writeLogIfError, errorTraceCode)
    End Function

    Public Function TryAction(Of T As Exception)(act As Action, Optional ByRef messageOut As String = Nothing, Optional writeLogIfError As Boolean = True, Optional errorTraceCode As Integer = 0) As Boolean
        Try
            act()
            Return True
        Catch ex As T
            If messageOut IsNot Nothing Then messageOut = ex.Message
            If writeLogIfError Then ThreadPool.QueueUserWorkItem(Sub() WriteLog(String.Format("{0} - {1} - {2} - {3}, {4}",
                                                                                                act.Target.ToString,
                                                                                                act.Method.Name,
                                                                                                ex.Message,
                                                                                                ex.InnerException,
                                                                                                errorTraceCode), My.Application.Info.ProductName, , TraceEventType.Error))
            Return False
        End Try
    End Function

    Public Function TryAction(Of T)(act As Action(Of T), parameter1 As T, Optional ByRef messageOut As String = Nothing, Optional writeLogIfError As Boolean = True) As Boolean
        Try
            act(parameter1)
            Return True
        Catch ex As Exception
            If messageOut IsNot Nothing Then messageOut = ex.Message
            If writeLogIfError Then ThreadPool.QueueUserWorkItem(Sub() WriteLog(String.Format("{0} - {1} - {2}", act.Method.Name, ex.Message, ex.InnerException), My.Application.Info.ProductName, , TraceEventType.Error))
            Return False
        End Try
    End Function

    Function TryActionWithReturn(Of TResult)(func As Func(Of TResult), Optional ByRef messageOut As String = Nothing) As TResult
        Try
            Return func()
        Catch ex As Exception
            If messageOut IsNot Nothing Then messageOut = ex.Message
            Return Activator.CreateInstance(Of TResult)()
        End Try
    End Function

    Function TryActionWithReturn(Of T, TResult)(func As Func(Of T, TResult), arg As T, Optional ByRef messageOut As String = Nothing, Optional writeLogIfError As Boolean = True) As TResult
        Try
            Return func(arg)
        Catch ex As Exception
            If messageOut IsNot Nothing Then messageOut = ex.Message
            If writeLogIfError Then ThreadPool.QueueUserWorkItem(Sub() WriteLog(String.Format("{0} - {1} - {2} - {3}",
                                                                                func.Target.ToString,
                                                                                func.Method.Name,
                                                                                ex.Message,
                                                                                ex.InnerException), My.Application.Info.ProductName, , TraceEventType.Error))
            Return Activator.CreateInstance(Of TResult)()
        End Try
    End Function

    ''' <summary>
    ''' This is to write log to a text file for troubleshooting
    ''' </summary>
    ''' <param name="logMessage"></param>
    ''' <param name="applicationName"></param>
    ''' <param name="enabledDetailedInformation"></param>
    ''' <param name="type"></param>
    ''' <param name="appendFile"></param>
    ''' <param name="customFileName"></param>
    ''' <param name="maximunFileSizeInBytes"></param>
    ''' <param name="errorNumber">If used this helps identify the caller</param>
    ''' <remarks></remarks>
    Public Sub WriteLog(logMessage As String, applicationName As String, Optional enabledDetailedInformation As Boolean = True, Optional type As TraceEventType = TraceEventType.Information, Optional appendFile As Boolean = True, Optional customFileName As String = Nothing, Optional maximunFileSizeInBytes As Integer = 10000000, Optional errorNumber As Integer = 0)
        TryAction(Sub()
                      With My.Application.Log.DefaultFileLogWriter
                          .Location = Microsoft.VisualBasic.Logging.LogFileLocation.Custom
                          .CustomLocation = String.Format("{0}\Logs\{1}", BuildAndGetFilePath(String.Format("{0}{1}", applicationName, "logs"), Environment.SpecialFolder.CommonDocuments), Format(Now, "yyy_MM"))
                          .AutoFlush = True
                          .Append = appendFile
                          .IncludeHostName = enabledDetailedInformation
                          .MaxFileSize = maximunFileSizeInBytes
                          .Delimiter = ","
                          .LogFileCreationSchedule = Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption.Daily

                          If customFileName <> Nothing Then .BaseFileName = customFileName
                      End With
                      Dim sb As New System.Text.StringBuilder
                      If errorNumber <> 0 Then logMessage = String.Format("{0} - {1}", errorNumber, logMessage)
                      If enabledDetailedInformation Then
                          logMessage = logMessage.Replace(",", "-")
                          sb.Append(Format(Now, "yyyMMddhhmmss"))
                          sb.Append(",")
                          sb.Append(logMessage)
                          sb.Append(",")
                          sb.Append(My.User.Name)
                          sb.Append(",")
                          sb.Append(My.Computer.Info.OSFullName)
                          sb.Append(",")
                          sb.Append(applicationName)
                          sb.Append(",")
                          sb.Append(My.Application.Info.Version)
                          sb.Append(",")
                          sb.Append(My.Application.Info.AssemblyName)
                          sb.Append(",")
                          sb.Append(My.Computer.Info.InstalledUICulture)
                          sb.Append(",")
                          My.Application.Log.WriteEntry(sb.ToString, type)
                      Else
                          My.Application.Log.WriteEntry(logMessage, type)
                      End If
                  End Sub)
    End Sub

    Public Sub WriteLog(logMessage As String, config As FileLoggerConfigDetail)
        TryAction(Sub()
                      With My.Application.Log.DefaultFileLogWriter
                          .Location = Microsoft.VisualBasic.Logging.LogFileLocation.Custom
                          .CustomLocation = config.FileLocation
                          .AutoFlush = config.ShouldAutoFlush
                          .Append = config.ShouldAppend
                          .IncludeHostName = config.EnableDetailedInformation
                          .MaxFileSize = config.MaxFileSize
                          .Delimiter = config.ColumnDelimiter
                          .LogFileCreationSchedule = config.LogFileCreationSchedule
                          If config.FileName <> Nothing Then .BaseFileName = config.FileName
                      End With
                      Dim sb As New System.Text.StringBuilder
                      If config.EnableDetailedInformation Then
                          logMessage = logMessage.Replace(",", "-")
                          sb.Append(Format(Now, "yyyMMddhhmmss"))
                          sb.Append(",")
                          sb.Append(logMessage)
                          sb.Append(",")
                          sb.Append(My.User.Name)
                          sb.Append(",")
                          sb.Append(My.Computer.Info.OSFullName)
                          sb.Append(",")
                          sb.Append(config.ApplicationName)
                          sb.Append(",")
                          sb.Append(My.Application.Info.Version)
                          sb.Append(",")
                          sb.Append(My.Application.Info.AssemblyName)
                          sb.Append(",")
                          sb.Append(My.Computer.Info.InstalledUICulture)
                          sb.Append(",")
                          My.Application.Log.WriteEntry(sb.ToString, config.TraceEventType)
                      Else
                          My.Application.Log.WriteEntry(logMessage, config.TraceEventType)
                      End If
                  End Sub)
    End Sub

End Module