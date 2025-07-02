' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 01-20-2017
'
' Last Modified By : yeunc009
' Last Modified On : 03-31-2017
' ***********************************************************************
' <copyright file="JobDetailBase.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Imports System.Threading
Imports Wdw_Sust.Core.Interfaces

Namespace Job
    public Class TimeSpanCancellableJobDetail
        Inherits CancellableJobDetailBase

        Public Sub New(jobToPerform As Action(Of CancellationToken))
            MyBase.New(jobToPerform)
        End Sub

        Public Sub New(ByVal jobName As String, ByVal frequency As TimeSpan, ByVal jobPerform As Action(Of CancellationToken), Optional ByVal isEnabled As Boolean = True)
            MyBase.new(jobPerform)
            Me.IsEnabled = isEnabled
            Me.JobName = jobName
            Me.TimeSpanRunTime = frequency
            LastUpdate = Now
        End Sub

        Public Property TimeSpanRunTime As TimeSpan

    End Class
    Public MustInherit Class CancellableJobDetailBase
        Implements ICanCancel, IJobDetail
#Region "Events"
        ''' <summary>
        ''' Occurs when [job execute error].
        ''' </summary>
        Public Event JobExecuteError As EventHandler
        ''' <summary>
        ''' Occurs when [job executed].
        ''' </summary>
        Public Event JobExecuted As EventHandler
#End Region
        Private _cancelToken As CancellationTokenSource
        Private _jobScheduler As IJobManager
        Private ReadOnly _jobToPerform As Action(Of CancellationToken)

        Public Property IsBusy As Boolean Implements IJobDetail.IsBusy

        Public Property IsEnabled As Boolean Implements IJobDetail.IsEnabled

        Public Property JobName As String Implements IJobDetail.JobName

        Public Property JobScheduler As IJobManager Implements IJobDetail.JobScheduler
            Get

                Return _jobScheduler
            End Get
            Private Set(value As IJobManager)
                If Not ReferenceEquals(_jobScheduler, value) Then
                    _jobScheduler = value
                End If
            End Set

        End Property

        Public Property LastUpdate As Date Implements IJobDetail.LastUpdate


        Public Property MarkForRemoval As Boolean Implements IJobDetail.MarkForRemoval

        Private ReadOnly Property CancelToken As CancellationTokenSource
            Get
                If _cancelToken Is Nothing OrElse _cancelToken.IsCancellationRequested Then
                    _cancelToken = New CancellationTokenSource()
                End If
                Return _cancelToken
            End Get
        End Property

        Public Sub Cancal() Implements ICanCancel.Cancal
            _cancelToken.Cancel()
        End Sub

        Public Sub ExecuteJob() Implements IExecuteJob.ExecuteJob
            If _jobToPerform IsNot Nothing Then
                If Not IsBusy Then
                    IsBusy = True
                    Task.Factory.StartNew(Sub()
                                              Try
                                                  CancelToken.Token.ThrowIfCancellationRequested()
                                                  CancelToken.Token.Register(sub() RaiseEvent JobExecuteError(Me, System.EventArgs.Empty))
                                                  _jobToPerform(CancelToken.Token)
                                              Catch ex As Exception
                                                  RaiseEvent JobExecuteError(Me, System.EventArgs.Empty)
                                                  IsBusy = False
                                              End Try
                                          End Sub).ContinueWith(Sub()
                                                                    IsBusy = False
                                                                    LastUpdate = Now
                                                                    RaiseEvent JobExecuted(Me, System.EventArgs.Empty)
                                                                End Sub)
                End If
            ElseIf Not MarkForRemoval Then
                Throw New ArgumentException("No job is defined")
            End If
        End Sub
        ''' <summary>
        ''' Subscribes the specified job scheduler.
        ''' </summary>
        ''' <param name="scheduler">The job scheduler.</param>
        ''' <param name="runImmediately">if set to <c>true</c> [run immediately].</param>
        ''' <exception cref="System.NullReferenceException">jobScheduler</exception>
        Public Overridable Sub Subscribe(scheduler As IJobManager, Optional ByVal runImmediately As Boolean = False) Implements IJobDetail.Subscribe
            If scheduler Is Nothing Then Throw New NullReferenceException("scheduler")
            SetScheduler(scheduler)
            JobScheduler.AddJob(Me, runImmediately)
        End Sub

        ''' <summary>
        ''' Unsubscribes this instance.
        ''' </summary>
        Public Sub Unsubscribe() Implements IJobDetail.Unsubscribe
            If JobScheduler IsNot Nothing Then
                JobScheduler.RemoveJob(Me)
                SetScheduler(Nothing)
            End If
        End Sub

        Public Sub SetScheduler(scheduler As IJobManager) Implements IJobDetail.SetScheduler
            JobScheduler = scheduler
        End Sub

        Public sub New(ByVal jobToPerform As Action(Of CancellationToken))
            _jobToPerform = jobToPerform
        End sub
    End Class
    ''' <summary>
    ''' Class JobDetailBase.
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Core.Interfaces.IJobDetail" />
    Public MustInherit Class JobDetailBase
        Implements IJobDetail

#Region "Fields"
        ''' <summary>
        ''' The job to perform
        ''' </summary>
        Private _jobToPerform As Action
        ''' <summary>
        ''' The mark for removal
        ''' </summary>
        Private _markForRemoval As Boolean
        ''' <summary>
        ''' Job manager
        ''' </summary>
        Private _jobScheduler As IJobManager


#End Region

#Region "Properties"
        ''' <summary>
        ''' Indicate if the job is enabled at the moment. Even though the job is in
        ''' the manager, this bit can be set to true when you want to
        ''' temporarily disable th job from running
        ''' </summary>
        ''' <value><c>true</c> if this instance is enabled; otherwise, <c>false</c>.</value>
        Public Property IsEnabled As Boolean Implements IJobDetail.IsEnabled
        ''' <summary>
        ''' Gets or sets the name of the job.
        ''' </summary>
        ''' <value>The name of the job.</value>
        Public Property JobName As String Implements IJobDetail.JobName
        ''' <summary>
        ''' Gets or sets the last update.
        ''' </summary>
        ''' <value>The last update.</value>
        Public Property LastUpdate As Date = Date.MinValue Implements IJobDetail.LastUpdate
        ''' <summary>
        ''' Gets the job arguments.
        ''' </summary>
        ''' <value>The job arguments.</value>
        Public Property JobArguments As Object() = Nothing
        ''' <summary>
        ''' Gets or sets a value indicating whether the job will be removed from the job manager.
        ''' </summary>
        ''' <value><c>true</c> if [mark for removal]; otherwise, <c>false</c>.</value>
        Private Property MarkForRemoval As Boolean Implements IJobDetail.MarkForRemoval
            Get
                Return _markForRemoval
            End Get
            Set(value As Boolean)
                If _markForRemoval Then Exit Property
                If _markForRemoval <> value Then
                    _markForRemoval = value
                    _jobToPerform = Nothing
                End If
            End Set
        End Property
        ''' <summary>
        ''' Indicate if the job is being processed at the moment.
        ''' </summary>
        ''' <value><c>true</c> if this instance is busy; otherwise, <c>false</c>.</value>
        Friend Property IsBusy As Boolean Implements IJobDetail.IsBusy

        ''' <summary>
        ''' Gets the job scheduler.
        ''' </summary>
        ''' <value>The job scheduler.</value>
        Public Property JobScheduler As IJobManager Implements IJobDetail.JobScheduler
            Get
                Return _jobScheduler
            End Get
            Private Set(value As IJobManager)
                If Not ReferenceEquals(_jobScheduler, value) Then
                    'If _jobScheduler IsNot Nothing
                    '    Unsubscribe()
                    'End If
                    _jobScheduler = value
                End If
            End Set
        End Property
        
#End Region

#Region "Events"
        ''' <summary>
        ''' Occurs when [job execute error].
        ''' </summary>
        Public Event JobExecuteError As EventHandler
        ''' <summary>
        ''' Occurs when [job executed].
        ''' </summary>
        Public Event JobExecuted As EventHandler
#End Region

#Region "Methods"
        ''' <summary>
        ''' Defines the job.
        ''' </summary>
        ''' <param name="jobToPerform">The job to perform.</param>
        ''' <param name="args">The arguments.</param>
        Protected Sub DefineJob(ByVal jobToPerform As Action, Optional ByVal args As Object() = Nothing)
            _jobToPerform = jobToPerform
            JobArguments = args
        End Sub

        ''' <summary>
        ''' Executes the job.
        ''' </summary>
        ''' <exception cref="System.ArgumentException">No job is defined</exception>
        Public Sub ExecuteJob() Implements IJobDetail.ExecuteJob
            If _jobToPerform IsNot Nothing Then
                If Not IsBusy Then
                    IsBusy = True
                    Try
                        _jobToPerform.BeginInvoke(New AsyncCallback(Sub()
                                                                        IsBusy = False
                                                                        LastUpdate = Now
                                                                        RaiseEvent JobExecuted(Me, System.EventArgs.Empty)
                                                                    End Sub), Nothing)
                    Catch ex As Exception
                        RaiseEvent JobExecuteError(Me, System.EventArgs.Empty)
                        IsBusy = False
                    End Try
                End If
            ElseIf Not MarkForRemoval Then
                Throw New ArgumentException("No job is defined")
            End If
        End Sub

        ''' <summary>
        ''' Returns a <see cref="System.String" /> that represents this instance.
        ''' </summary>
        ''' <returns>A <see cref="System.String" /> that represents this instance.</returns>
        Public Overrides Function ToString() As String
            Return JobName
        End Function
#End Region

#Region "Constructors"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="JobDetailBase"/> class.
        ''' </summary>
        ''' <param name="isEnabled">if set to <c>true</c> [is enabled].</param>
        Public Sub New(Optional isEnabled As Boolean = True)
            Me.IsEnabled = isEnabled
        End Sub

        ''' <summary>
        ''' Subscribes the specified job scheduler.
        ''' </summary>
        ''' <param name="scheduler">The job scheduler.</param>
        ''' <param name="runImmediately">if set to <c>true</c> [run immediately].</param>
        ''' <exception cref="System.NullReferenceException">jobScheduler</exception>
        Public Overridable Sub Subscribe(scheduler As IJobManager, Optional ByVal runImmediately As Boolean = False) Implements IJobDetail.Subscribe
            If scheduler Is Nothing Then Throw New NullReferenceException("scheduler")
            SetScheduler(scheduler)
            JobScheduler.AddJob(Me, runImmediately)
        End Sub

        ''' <summary>
        ''' Unsubscribes this instance.
        ''' </summary>
        Public Sub Unsubscribe() Implements IJobDetail.Unsubscribe
            If JobScheduler IsNot Nothing Then
                JobScheduler.RemoveJob(Me)
                SetScheduler(Nothing)
            End If
        End Sub

        Public Sub SetScheduler(scheduler As IJobManager) Implements IJobDetail.SetScheduler
            JobScheduler = scheduler
        End Sub

#End Region

    End Class

End Namespace
