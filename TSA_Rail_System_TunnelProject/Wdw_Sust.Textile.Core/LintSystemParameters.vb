Public Class LintSystemParameters
    Inherits List(Of LINTSystemParameter)
    Implements ICloneable

#Region "Methods"

    Public Function GetParameter(ByVal systemParameterID As LintSystemParameterId) As LINTSystemParameter
        Return Find(Function(a) a.Key = systemParameterID)
    End Function

    Public Function GetParameterValue(Of T)(ByVal systemParameterID As LintSystemParameterId) As T
        Dim p As LINTSystemParameter = GetParameter(systemParameterID)
        If p IsNot Nothing Then
            If GetType(T).IsEnum AndAlso [Enum].IsDefined(GetType(T), p.Value) Then Return DirectCast([Enum].Parse(GetType(T), p.Value), T)
            Return CType(p.Value, T)
        End If
    End Function

    Public Sub SetParameterValue(Of T)(ByVal systemParameterID As LintSystemParameterId, ByVal value As T)
        Dim p As LINTSystemParameter = Find(Function(a) a.Key = systemParameterID)
        If p IsNot Nothing Then
            If value.GetType Is GetType(Boolean) Then
                p.Value = Math.Abs(CInt(CObj(value)))
            Else
                p.Value = value
            End If
            p.IsDirty = True
        End If
    End Sub

    Private Function ICloneable_Clone() As Object Implements System.ICloneable.Clone
        Return Clone()
    End Function

    Public Function Clone() As LintSystemParameters
        Dim c As New LintSystemParameters
        Me.ForEach(Sub(a) c.Add(a.Clone))
        Return c
    End Function

    Public Function GetChangedParameters() As List(Of LINTSystemParameter)
        Return FindAll(Function(a) a.IsDirty = True)
    End Function
#End Region

End Class