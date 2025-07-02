namespace TunnelProject.Opc
{

        // EventArgs for job events
        public class JobEventArgs : EventArgs
        {
            public string JobName { get; set; }
            public bool Cancel { get; set; }

            public JobEventArgs(string jobName)
            {
                JobName = jobName;
            }
        }

        // IJobManager interface
        public interface IJobManager
        {
            IJobDetail AddJob(IJobDetail jobDetail, bool runImmediately = false);
            void RemoveJob(IJobDetail job);
        }

        // IJobDetail interface (simplified, expand as needed)
        public interface IJobDetail
        {
            string JobName { get; set; }
            bool IsEnabled { get; set; }
            bool IsBusy { get; set; }
            bool MarkForRemoval { get; set; }
            DateTime LastUpdate { get; set; }
            IJobManager JobScheduler { get; }
            void ExecuteJob();
            void Subscribe(IJobManager scheduler, bool runImmediately = false);
            void Unsubscribe();
            void SetScheduler(IJobManager scheduler);
        }

        // ITimeSpanJobDetail interface (simplified)
        public interface ITimeSpanJobDetail : IJobDetail
        {
            TimeSpan TimeSpanRunTime { get; set; }
        }

        // ISpecificRunTimeJobDetail interface (simplified)
        public interface ISpecificRunTimeJobDetail : IJobDetail
        {
            List<JobRunTime> ListOfRunTime { get; }
        }

        // JobRunTime class
        [Serializable]
        public class JobRunTime
        {
            public DayOfWeek DayOfWeek { get; set; }
            private int _hour;
            private int _minute;
            private int _second;

            public int Hour
            {
                get => _hour;
                set
                {
                    if (value >= 0 && value < 24)
                        _hour = value;
                    else
                        throw new ArgumentException("Hour can only have a value between 0 and 23");
                }
            }
            public int Minute
            {
                get => _minute;
                set
                {
                    if (value >= 0 && value < 60)
                        _minute = value;
                    else
                        throw new ArgumentException("Minute can only have a value between 0 and 59");
                }
            }
            public int Second
            {
                get => _second;
                set
                {
                    if (value >= 0 && value < 60)
                        _second = value;
                    else
                        throw new ArgumentException("Second can only have a value between 0 and 59");
                }
            }

            public JobRunTime() { }

            public JobRunTime(DayOfWeek dayOfWeek, int hour, int minute, int second)
            {
                DayOfWeek = dayOfWeek;
                Hour = hour;
                Minute = minute;
                Second = second;
            }

            public override string ToString()
            {
                return $"Day:{DayOfWeek}, Hour:{Hour}, Minute:{Minute}, Second:{Second}";
            }
        }

        // TimeSpanJobDetail class
        public class TimeSpanJobDetail : JobDetailBase, ITimeSpanJobDetail
        {
            public virtual TimeSpan TimeSpanRunTime { get; set; }

            public DateTime NextUpdate => LastUpdate.Add(TimeSpanRunTime);

            public TimeSpan TimeUntilNextUpdate => TimeSpanRunTime.Subtract(DateTime.Now.Subtract(LastUpdate));

            public override void Subscribe(IJobManager jobScheduler, bool runImmediately = false)
            {
                if (TimeSpanRunTime == TimeSpan.MinValue)
                    throw new InvalidOperationException("TimeSpanRunTime is not defined");
                base.Subscribe(jobScheduler, runImmediately);
            }

            public override string ToString()
            {
                return $"{JobName}: Interval: {TimeSpanRunTime.TotalSeconds:F0} Seconds: IsEnabled: {IsEnabled}";
            }

            public TimeSpanJobDetail(string jobName, TimeSpan frequency, Action jobPerform, bool isEnabled = true, object[] args = null)
                : base(isEnabled)
            {
                JobName = jobName;
                TimeSpanRunTime = frequency;
                DefineJob(jobPerform, args);
                LastUpdate = DateTime.Now;
            }

            public TimeSpanJobDetail() : base(false)
            {
                LastUpdate = DateTime.Now;
            }
        }

        // JobManagerBase class
        public abstract class JobManagerBase : IJobManager, IDisposable
        {
            protected readonly List<IJobDetail> _listOfJobDetails = new List<IJobDetail>();
            private readonly object _syncLockObject = new object();
            private DateTime _lastTickTime = DateTime.MinValue;
            private long _minTick = long.MaxValue;
            private long _maxTick = 0;

            public event EventHandler JobManagerStarted;
            public event EventHandler JobManagerStopped;
            public event EventHandler<JobEventArgs> OnProcessingJob;
            public event EventHandler<JobEventArgs> OnProcessedJob;
            public event EventHandler Tick;

            public IList<IJobDetail> JobDetails => _listOfJobDetails.AsReadOnly();
            public bool IsRunning { get; private set; }
            public int JobCounts => _listOfJobDetails.Count;
            public DateTime LastTickTime => _lastTickTime;
            public long MinTick => _minTick;
            public long MaxTick => _maxTick;

            protected abstract void ProcessJobs();

            private void CheckForDeletedJobs()
            {
                lock (_syncLockObject)
                {
                    _listOfJobDetails.RemoveAll(a =>
                    {
                        if (a.MarkForRemoval)
                        {
                            a.MarkForRemoval = false;
                            return true;
                        }
                        return false;
                    });
                }
            }

            public void ProcessJob(string jobName, bool throwIfJobDoesNotExist = false)
            {
                IJobDetail job;
                lock (_syncLockObject)
                {
                    job = _listOfJobDetails.Find(a => a.JobName.Equals(jobName, StringComparison.OrdinalIgnoreCase));
                }
                if (job != null && !job.MarkForRemoval)
                {
                    ExecuteJob(job);
                }
                else if (throwIfJobDoesNotExist)
                {
                    throw new ArgumentException("Job Does Not Exist!");
                }
            }

            public bool ContainsJob(string jobName)
            {
                if (!string.IsNullOrEmpty(jobName))
                {
                    bool returnValue;
                    lock (_syncLockObject)
                    {
                        returnValue = _listOfJobDetails.Any(a => a.JobName.Trim().Equals(jobName.Trim(), StringComparison.OrdinalIgnoreCase));
                    }
                    return returnValue;
                }
                return false;
            }

            public IJobDetail GetJob(string jobName)
            {
                IJobDetail jobToReturn;
                lock (_syncLockObject)
                {
                    jobToReturn = _listOfJobDetails.FirstOrDefault(a => a.JobName.Trim().Equals(jobName.Trim(), StringComparison.OrdinalIgnoreCase));
                }
                return jobToReturn;
            }

            protected void ExecuteJob(IJobDetail job)
            {
                var args = new JobEventArgs(job.JobName);
                OnProcessingJob?.Invoke(this, args);
                if (!args.Cancel)
                {
                    ThreadPool.QueueUserWorkItem(_ =>
                    {
                        job.ExecuteJob();
                        job.LastUpdate = DateTime.Now;
                    });
                }
                OnProcessedJob?.Invoke(this, args);
            }

            public List<string> GetJobNames()
            {
                var names = new List<string>();
                lock (_syncLockObject)
                {
                    names.AddRange(_listOfJobDetails.Select(a => a.ToString()));
                    names.Sort();
                }
                return names;
            }

            public virtual IJobDetail AddJob(IJobDetail jobDetail, bool runImmediately = false)
            {
                if (jobDetail == null)
                    throw new ArgumentException("jobDetail argument is null");
                if (string.IsNullOrEmpty(jobDetail.JobName))
                    throw new ArgumentException("Please provide a name for the job!!");
                lock (_syncLockObject)
                {
                    if (_listOfJobDetails.Any(a => a.JobName.Trim().Equals(jobDetail.JobName.Trim(), StringComparison.OrdinalIgnoreCase)))
                        throw new ArgumentException("Job has already been in the job manager!!");
                    _listOfJobDetails.Add(jobDetail);
                    if (jobDetail.JobScheduler == null)
                    {
                        jobDetail.SetScheduler(this);
                    }
                    else if (!ReferenceEquals(jobDetail.JobScheduler, this))
                    {
                        jobDetail.JobScheduler.RemoveJob(jobDetail);
                        jobDetail.SetScheduler(this);
                    }
                }
                if (runImmediately)
                {
                    ThreadPool.QueueUserWorkItem(_ => jobDetail.ExecuteJob());
                }
                return jobDetail;
            }

            public void RemoveJob(string jobName)
            {
                lock (_syncLockObject)
                {
                    var job = _listOfJobDetails.Find(a => a.JobName.Equals(jobName, StringComparison.OrdinalIgnoreCase));
                    if (job != null)
                    {
                        job.IsEnabled = false;
                        job.MarkForRemoval = true;
                        if (ReferenceEquals(job.JobScheduler, this))
                            job.SetScheduler(null);
                    }
                }
            }

            public void RemoveJob(IJobDetail job)
            {
                RemoveJob(job.JobName);
            }

            public void RemoveJobs()
            {
                lock (_syncLockObject)
                {
                    _listOfJobDetails.ForEach(a => a.MarkForRemoval = true);
                }
            }

            public void StartProcessingJobs()
            {
                IsRunning = true;
                JobManagerStarted?.Invoke(this, EventArgs.Empty);
                // Start timer logic here
            }

            public void StopProcessingJobs()
            {
                IsRunning = false;
                JobManagerStopped?.Invoke(this, EventArgs.Empty);
                // Stop timer logic here
            }

            public void Dispose()
            {
                _listOfJobDetails.Clear();
                // Dispose timer if needed
            }
        }

        // JobManager implementation
        public sealed class JobManager : JobManagerBase
        {
            protected override void ProcessJobs()
            {
                var time = DateTime.Now;
                foreach (var job in _listOfJobDetails.ToList())
                {
                    if (!job.MarkForRemoval && job.IsEnabled && !job.IsBusy)
                    {
                        if (job is ISpecificRunTimeJobDetail specificJob)
                        {
                            foreach (var run in specificJob.ListOfRunTime)
                            {
                                if (run.DayOfWeek == time.DayOfWeek &&
                                    run.Hour == time.Hour &&
                                    run.Minute == time.Minute &&
                                    run.Second == time.Second)
                                {
                                    ExecuteJob(job);
                                    continue;
                                }
                            }
                        }
                        else if (job is ITimeSpanJobDetail detail)
                        {
                            if (Math.Round((time - detail.LastUpdate).TotalMilliseconds) >= detail.TimeSpanRunTime.TotalMilliseconds)
                            {
                                ExecuteJob(job);
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if (job.IsBusy)
                            Console.WriteLine($"the job {job.JobName} currently is busy and cannot be executed again");
                    }
                }
            }

            public override IJobDetail AddJob(IJobDetail jobDetail, bool runImmediately = false)
            {
                if (jobDetail is ITimeSpanJobDetail tsJob && tsJob.TimeSpanRunTime.TotalSeconds < 1)
                    throw new ArgumentException("Lowest resolution for frequency is 1 second");
                return base.AddJob(jobDetail, runImmediately);
            }
        }

        // JobDetailBase class (simplified)
        public abstract class JobDetailBase : IJobDetail
        {
            private Action _jobToPerform;
            private bool _markForRemoval;
            private IJobManager _jobScheduler;

            public bool IsEnabled { get; set; }
            public string JobName { get; set; }
            public DateTime LastUpdate { get; set; } = DateTime.MinValue;
            public object[] JobArguments { get; set; } = null;
            public bool MarkForRemoval
            {
                get => _markForRemoval;
                set
                {
                    if (_markForRemoval) return;
                    if (_markForRemoval != value)
                    {
                        _markForRemoval = value;
                        _jobToPerform = null;
                    }
                }
            }
            public bool IsBusy { get; set; }
            public IJobManager JobScheduler
            {
                get => _jobScheduler;
                private set
                {
                    if (!ReferenceEquals(_jobScheduler, value))
                    {
                        _jobScheduler = value;
                    }
                }
            }

            public event EventHandler JobExecuteError;
            public event EventHandler JobExecuted;

            protected void DefineJob(Action jobToPerform, object[] args = null)
            {
                _jobToPerform = jobToPerform;
                JobArguments = args;
            }

            public void ExecuteJob()
            {
                if (_jobToPerform != null)
                {
                    if (!IsBusy)
                    {
                        IsBusy = true;
                        try
                        {
                            _jobToPerform.BeginInvoke(ar =>
                            {
                                IsBusy = false;
                                LastUpdate = DateTime.Now;
                                JobExecuted?.Invoke(this, EventArgs.Empty);
                            }, null);
                        }
                        catch (Exception)
                        {
                            JobExecuteError?.Invoke(this, EventArgs.Empty);
                            IsBusy = false;
                        }
                    }
                }
                else if (!MarkForRemoval)
                {
                    throw new ArgumentException("No job is defined");
                }
            }

            public override string ToString() => JobName;

            public virtual void Subscribe(IJobManager scheduler, bool runImmediately = false)
            {
                if (scheduler == null) throw new NullReferenceException("scheduler");
                SetScheduler(scheduler);
                JobScheduler.AddJob(this, runImmediately);
            }

            public void Unsubscribe()
            {
                if (JobScheduler != null)
                {
                    JobScheduler.RemoveJob(this);
                    SetScheduler(null);
                }
            }

            public void SetScheduler(IJobManager scheduler)
            {
                JobScheduler = scheduler;
            }

            protected JobDetailBase(bool isEnabled = true)
            {
                IsEnabled = isEnabled;
            }
        }
    
}
