Imports System.Runtime.CompilerServices

Namespace Extensions
    Public Module TimeSpanExtensions
        <Extension()>
        Function ConvertToProperTimeStringFormat(ByVal span As TimeSpan) As String
            Dim formatted As String = String.Format("{0}{1}{2}{3}",
                                                     IIf(span.Duration().Days > 0, String.Format("{0:0} day{1}, ", span.Days, IIf(span.Days = 1, String.Empty, "s")), String.Empty),
                                                     IIf(span.Duration().Hours > 0, String.Format("{0:0} hour{1}, ", span.Hours, IIf(span.Hours = 1, String.Empty, "s")), String.Empty),
                                                     IIf(span.Duration().Minutes > 0, String.Format("{0:0} minute{1}, ", span.Minutes, IIf(span.Minutes = 1, String.Empty, "s")), String.Empty), IIf(span.Duration().Seconds > 0, String.Format("{0:0} second{1}", span.Seconds, IIf(span.Seconds = 1, String.Empty, "s")), String.Empty))
            If formatted.EndsWith(", ") Then formatted = formatted.Substring(0, formatted.Length - 2)

            If String.IsNullOrEmpty(formatted) Then formatted = "0 seconds"
            Return formatted
        End Function
        <Extension()>
        Function ConvertToProperShortTimeStringFormat(ByVal span As TimeSpan) As String
            Return String.Format("{0}:{1}:{2}", span.Hours.ToString("00"), span.Minutes.ToString("00"), span.Seconds.ToString("00"))
        End Function
    End Module


End Namespace
