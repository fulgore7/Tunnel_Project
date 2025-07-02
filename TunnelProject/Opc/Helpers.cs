namespace TunnelProject.Opc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.IO;
    using System.Net;
    using System.Net.NetworkInformation;
    using System.Reflection;
    using System.Threading;

    public static class Helpers
    {
        public static string BuildAndGetFilePath(string folderName, Environment.SpecialFolder location)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(location), folderName);
            Directory.CreateDirectory(filePath);
            return filePath;
        }

        public static bool CanConnect(string ipAddressOrDomain)
        {
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send(ipAddressOrDomain);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in CanConnect " + ex.Message);
                return false;
            }
        }

        public static T Convert<T>(object fromObject, Type toObjectType) where T : class
        {
            var toObject = Activator.CreateInstance(toObjectType);
            if (fromObject.GetType().Name != toObject.GetType().Name)
                return null;
            return toObject as T;
        }

        public static long Convert2IntegersToLong(int lowerBytes, int higherBytes)
        {
            var valuesToBeConverted = new List<byte>();
            valuesToBeConverted.AddRange(BitConverter.GetBytes(lowerBytes));
            valuesToBeConverted.AddRange(BitConverter.GetBytes(higherBytes));
            return BitConverter.ToInt64(valuesToBeConverted.ToArray(), 0);
        }

        public static byte ConvertHexToAsciiByte(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return (byte)(48 + (byte)char.GetNumericValue(hexDigit));
            }
            else
            {
                switch (char.ToLower(hexDigit))
                {
                    case 'a': return 65;
                    case 'b': return 66;
                    case 'c': return 67;
                    case 'd': return 68;
                    case 'e': return 69;
                    case 'f': return 70;
                    default: throw new ArgumentException($"{hexDigit} is not in HEX format");
                }
            }
        }

        public static DateTime ConvertToDateTime(long timeInMicroSecond, DateTime referenceTime)
        {
            double milliseconds = (double)timeInMicroSecond / 1000;
            return referenceTime.AddMilliseconds(milliseconds).ToLocalTime();
        }

        public static Thread CreateAndRunBackgroundThread(ThreadStart ts, ThreadPriority threadPriority = ThreadPriority.Normal)
        {
            var t = CreateBackgroundThread(ts);
            t.Priority = threadPriority;
            t.Start();
            return t;
        }

        public static Thread CreateBackgroundThread(ThreadStart ts)
        {
            var t = new Thread(ts) { Priority = ThreadPriority.Normal, IsBackground = true };
            t.TrySetApartmentState(ApartmentState.MTA);
            return t;
        }

        public static string DisplayMilliSecondInTimeFormat(long milliSecond)
        {
            if (milliSecond < 0)
                throw new ArgumentException("Parameter has to be an integer!");
            return DisplaySecondInTimeFormat(milliSecond / 1000);
        }

        public static string DisplaySecondInTimeFormat(long second)
        {
            if (second < 0)
                throw new ArgumentException("Parameter has to be an integer!");
            var span = new TimeSpan(TimeSpan.TicksPerSecond * second);
            return string.Format("{0}:{1}:{2}", span.Hours.ToString("00"), span.Minutes.ToString("00"), span.Seconds.ToString("00"));
        }

        public static string DisplayValueInTimeFormat(long value, TimeUnit unit)
        {
            switch (unit)
            {
                case TimeUnit.MilliSecond:
                    return DisplayMilliSecondInTimeFormat(value);
                case TimeUnit.Second:
                    return DisplaySecondInTimeFormat(value);
                default:
                    throw new ArgumentException("Time unit not supported!");
            }
        }

        public static bool DoesFileExist(string fileName)
        {
            return File.Exists(fileName);
        }

        public static T FixNull<T>(object dbValue, T defaultValue = default)
        {
            if (dbValue == DBNull.Value)
            {
                return defaultValue;
            }
            else
            {
                return (T)dbValue;
            }
        }

        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static T GetAppSetting<T>(string keyName)
        {
            var appSettings = ConfigurationManager.AppSettings;
            return (T)Convert.ChangeType(appSettings[keyName], typeof(T));
        }

        public static string GetClassLibraryAssemblyVersion()
        {
            var versionInfo = Assembly.GetCallingAssembly().GetName().Version;
            return $"{versionInfo.Major}.{versionInfo.Minor}.{versionInfo.Build}.{versionInfo.Revision}";
        }

        public static string GetConfigFilePath(string appName)
        {
            return BuildAndGetFilePath($"Wdw_sust Application Settings{Path.DirectorySeparatorChar}{appName}", Environment.SpecialFolder.CommonDocuments);
        }

        public static List<string> GetEnumDescriptions(Type enumType)
        {
            var list = new List<string>();
            foreach (var name in Enum.GetNames(enumType))
            {
                list.Add(name);
            }
            list.Sort();
            return list;
        }

        public static double GetEpochTime(DateTime inTime)
        {
            var _timeSpan = (inTime.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            return _timeSpan.TotalSeconds;
        }

        public static string GetExecutingFileName()
        {
            return Path.GetFileName(Assembly.GetEntryAssembly().Location);
        }

        public static List<T> GetListOfEnumsFromInteger<T>(int integerValue) where T : Enum
        {
            var types = new List<T>();
            foreach (T a in Enum.GetValues(typeof(T)))
            {
                if ((Convert.ToInt32(a) & integerValue) == Convert.ToInt32(a))
                    types.Add(a);
            }
            if (types.Count == 0) return null;
            return types;
        }

        public static string GetMemoryUsage()
        {
            using (var thisProc = Process.GetCurrentProcess())
            {
                return string.Format("{0} KB", thisProc.PrivateMemorySize64 / 1024);
            }
        }

        public static string GetProcessId()
        {
            using (var thisProc = Process.GetCurrentProcess())
            {
                return thisProc.Id.ToString();
            }
        }

        public static int GetRandomNumber()
        {
            var r = new Random();
            return r.Next(1, int.MaxValue);
        }

        public static int GetTowelFoldProductCode(int incomingProductCode)
        {
            int outgoingProductCode;
            switch (incomingProductCode)
            {
                case 1:
                case 2:
                    outgoingProductCode = 4; // hand towels
                    break;
                case 3:
                case 4:
                    outgoingProductCode = 5; // bath towels
                    break;
                case 5:
                case 6:
                    outgoingProductCode = 6; // bath mats
                    break;
                case 7:
                case 8:
                    outgoingProductCode = 7; // pool towels
                    break;
                default:
                    outgoingProductCode = 999;
                    break;
            }
            return outgoingProductCode;
        }

        public static string GetWorkStationName()
        {
            return Dns.GetHostName();
        }

        public static void OpenInBrowser(string url)
        {
            Process.Start(url);
        }

        public static void RaiseMultiThreadedEvent(Delegate e, object[] data)
        {
            if (e != null)
            {
                foreach (Delegate c in e.GetInvocationList())
                {
                    var t = c.Target as ISynchronizeInvoke;
                    if (t != null && t.InvokeRequired)
                    {
                        t.BeginInvoke(c, data);
                    }
                    else
                    {
                        c.DynamicInvoke(data);
                    }
                }
            }
        }

        public static bool TryAction(Action act)
        {
            return TryAction<Exception>(act);
        }

        public static bool TryAction(Action act, out string messageOut, bool writeLogIfError = true, int errorTraceCode = 0)
        {
            return TryAction<Exception>(act, out messageOut, writeLogIfError, errorTraceCode);
        }

        public static bool TryAction<T>(Action act, out string messageOut, bool writeLogIfError = true, int errorTraceCode = 0) where T : Exception
        {
            messageOut = null;
            try
            {
                act();
                return true;
            }
            catch (T ex)
            {
                messageOut = ex.Message;
                if (writeLogIfError)
                {
                    ThreadPool.QueueUserWorkItem(_ =>
                        WriteLog($"{act.Target} - {act.Method.Name} - {ex.Message} - {ex.InnerException}, {errorTraceCode}", AppDomain.CurrentDomain.FriendlyName, true, TraceEventType.Error));
                }
                return false;
            }
        }

        public static bool TryAction<T>(Action<T> act, T parameter1, out string messageOut, bool writeLogIfError = true)
        {
            messageOut = null;
            try
            {
                act(parameter1);
                return true;
            }
            catch (Exception ex)
            {
                messageOut = ex.Message;
                if (writeLogIfError)
                {
                    ThreadPool.QueueUserWorkItem(_ =>
                        WriteLog($"{act.Method.Name} - {ex.Message} - {ex.InnerException}", AppDomain.CurrentDomain.FriendlyName, true, TraceEventType.Error));
                }
                return false;
            }
        }

        public static TResult TryActionWithReturn<TResult>(Func<TResult> func, out string messageOut)
        {
            messageOut = null;
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                messageOut = ex.Message;
                return Activator.CreateInstance<TResult>();
            }
        }

        public static TResult TryActionWithReturn<T, TResult>(Func<T, TResult> func, T arg, out string messageOut, bool writeLogIfError = true)
        {
            messageOut = null;
            try
            {
                return func(arg);
            }
            catch (Exception ex)
            {
                messageOut = ex.Message;
                if (writeLogIfError)
                {
                    ThreadPool.QueueUserWorkItem(_ =>
                        WriteLog($"{func.Target} - {func.Method.Name} - {ex.Message} - {ex.InnerException}", AppDomain.CurrentDomain.FriendlyName, true, TraceEventType.Error));
                }
                return Activator.CreateInstance<TResult>();
            }
        }

        // Note: The WriteLog methods below are stubs. You will need to implement logging as appropriate for your application.
        public static void WriteLog(string logMessage, string applicationName, bool enabledDetailedInformation = true, TraceEventType type = TraceEventType.Information, bool appendFile = true, string customFileName = null, int maximunFileSizeInBytes = 10000000, int errorNumber = 0)
        {
            // Implement logging logic here as needed for your application/environment.
            // This is a stub for translation purposes.
        }

        public static void WriteLog(string logMessage, FileLoggerConfigDetail config)
        {
            // Implement logging logic here as needed for your application/environment.
            // This is a stub for translation purposes.
        }
    }

    // You will need to define the following types/enums/classes as appropriate for your project:
    public enum TimeUnit
    {
        MilliSecond,
        Second
    }

    public class FileLoggerConfigDetail
    {
        public string FileLocation { get; set; }
        public bool ShouldAutoFlush { get; set; }
        public bool ShouldAppend { get; set; }
        public bool EnableDetailedInformation { get; set; }
        public int MaxFileSize { get; set; }
        public string ColumnDelimiter { get; set; }
        public TraceEventType LogFileCreationSchedule { get; set; }
        public string FileName { get; set; }
        public string ApplicationName { get; set; }
        public TraceEventType TraceEventType { get; set; }
    }
}
