Imports Wdw_Sust.Core.Interfaces

Namespace Job
    <Serializable()>
    Public Class SpecificRunTimeJobDetail
        Inherits JobDetailBase
        Implements ISpecificRunTimeJobDetail

#Region "Fields"

        Private _listOfRunTime As List(Of JobRunTime)

#End Region

#Region "Properties"

        ''' <summary>
        ''' Do not use this to add JobRunTime to the object or it might
        ''' have unpredicted behavior.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ListOfRunTime As List(Of JobRunTime) Implements ISpecificRunTimeJobDetail.ListOfRunTime
            Get
                Return _listOfRunTime
            End Get
            Set(value As List(Of JobRunTime))
                _listOfRunTime = value
            End Set
        End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' Subscribes the specified job scheduler.
        ''' </summary>
        ''' <param name="jobScheduler">The job scheduler.</param>
        ''' <param name="runImmediately">if set to <c>true</c> [run immediately].</param>
        ''' <exception cref="System.InvalidOperationException">No ListOfRunTime is defined!</exception>
        Public Overrides Sub Subscribe(jobScheduler As IJobManager, Optional runImmediately As Boolean = False)
            If ListOfRunTime Is Nothing Then Throw New InvalidOperationException("No ListOfRunTime is defined!")
            MyBase.Subscribe(jobScheduler, runImmediately)
        End Sub

        Public Sub AddJobRunTime(ByVal runFrequence As Frequency, Optional useNowAsOrigin As Boolean = False)
            Dim second As Integer = IIf(useNowAsOrigin, Now.Second, 0)
            Dim minute As Integer = IIf(useNowAsOrigin, Now.Minute, 0)
            Dim hour As Integer = IIf(useNowAsOrigin, Now.Hour, 0)
            Select Case runFrequence
                Case Frequency.DAILY
                    AddJobRunTime(hour, minute, second)
                Case Frequency.HOURLY
                    AddJobRunTime(minute, second)
                Case Frequency.MINUTELY
                    AddJobRunTime(second)
                Case Else
                    Throw New ArgumentException(String.Format("Run frequency {0} is not supported", runFrequence))
            End Select
        End Sub

        Public Sub AddJob(ByVal jobName As String, ByVal jobToPerform As Action)
            Me.JobName = jobName
            DefineJob(jobToPerform)
        End Sub

        ''' <summary>
        ''' This will run the job every day and every hour and every minute at a specific second.
        ''' </summary>
        ''' <param name="second"></param>
        ''' <remarks></remarks>
        Public Sub AddJobRunTime(ByVal second As Integer)
            For min As Integer = 0 To 59
                AddJobRunTime(min, second)
            Next
        End Sub

        ''' <summary>
        ''' This will run the job every day and every hour at a specific minute and second.
        ''' </summary>
        ''' <param name="minute"></param>
        ''' <param name="second"></param>
        ''' <remarks></remarks>
        Public Sub AddJobRunTime(ByVal minute As Integer, ByVal second As Integer)
            For hour As Integer = 0 To 23
                AddJobRunTime(hour, minute, second)
            Next
        End Sub

        ''' <summary>
        ''' This will run the job every day at a specific hour, minute and second.
        ''' </summary>
        ''' <param name="hour"></param>
        ''' <param name="minute"></param>
        ''' <param name="second"></param>
        ''' <remarks></remarks>
        Public Sub AddJobRunTime(ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer)
            Dim jobRunTime As JobRunTime
            For Each value As DayOfWeek In [Enum].GetValues(GetType(DayOfWeek))
                jobRunTime = New JobRunTime(value, hour, minute, second)
                If Not CheckIfJobExists(jobRunTime) Then _listOfRunTime.Add(jobRunTime)
            Next
        End Sub

        Public Sub AddJobRunTime(ByVal dayOfWeek As DayOfWeek, ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer)
            Dim jobRunTime As New JobRunTime(dayOfWeek, hour, minute, second)
            If CheckIfJobExists(jobRunTime) Then Throw New Exception("Time specified has already had a job defined!!")
            _listOfRunTime.Add(jobRunTime)
        End Sub

        Public Sub AddJobRunTime(ByVal jobRunTime As JobRunTime)
            If CheckIfJobExists(jobRunTime) Then Throw New Exception("Time specified has already had a job defined!!")
            _listOfRunTime.Add(jobRunTime)
        End Sub

        Private Function CheckIfJobExists(ByVal jobRunTime As JobRunTime) As Boolean
            With jobRunTime
                Return _listOfRunTime.Exists(Function(a) a.DayOfWeek = .DayOfWeek AndAlso a.Hour = .Hour AndAlso a.Minute = .Minute AndAlso a.Second = .Second)
            End With
        End Function

#End Region

#Region "Contructors"

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal jobRunTime As JobRunTime)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
            AddJobRunTime(jobRunTime)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
            AddJobRunTime(hour, minute, second)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal second As Integer)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
            AddJobRunTime(second)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal minute As Integer, ByVal second As Integer)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
            AddJobRunTime(minute, second)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal timeOfDate As Date)
            _listOfRunTime = New List(Of JobRunTime)
            AddJob(jobName, jobToPerform)
            AddJobRunTime(timeOfDate.Hour, timeOfDate.Minute, timeOfDate.Second)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, ByVal dayOfWeek As DayOfWeek, ByVal hour As Integer, ByVal minute As Integer, ByVal second As Integer)
            _listOfRunTime = New List(Of JobRunTime)
            Me.JobName = jobName
            AddJobRunTime(dayOfWeek, hour, minute, second)
            DefineJob(jobToPerform)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal jobToPerform As Action, runFrequence As Frequency, Optional useNowAsOrigin As Boolean = False)
            _listOfRunTime = New List(Of JobRunTime)
            Me.JobName = jobName
            AddJobRunTime(runFrequence, useNowAsOrigin)
            DefineJob(jobToPerform)
        End Sub
#End Region

    End Class
End Namespace