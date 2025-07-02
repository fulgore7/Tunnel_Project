Imports System.ComponentModel
Imports Wdw_Sust.Core.WinForms
Imports Wdw_Sust.Textile.Core.Enums

Public Class CtrlLintAlarmMonitoringStatusIcon
    Inherits CtrlLintAlarmIcon

#Region "Fields"
    Private _graphicShownWhenFalse As System.Drawing.Image = Nothing
    Private _graphicShownWhenTrue As System.Drawing.Image = Nothing
    Private _pictureShownInDesigner As PictureShown = PictureShown.UNDETERMINED
#End Region

#Region "Methods"
    Private Sub UpdateControl(ByVal value As Boolean)
        InvokeIfNeeded(Sub()
                           Select Case value
                               Case True
                                   If GraphicShownWhenTrue IsNot Nothing Then
                                       PictureBox1.Image = GraphicShownWhenTrue
                                   End If
                               Case False
                                   If GraphicShownWhenFalse IsNot Nothing Then
                                       PictureBox1.Image = GraphicShownWhenFalse
                                   End If
                           End Select
                       End Sub)
    End Sub
#End Region

#Region "Properties"
    ''' <summary>
    ''' Show when the value is true. If not defined the control will hide with value is true.
    ''' </summary>
    ''' <value>Image to be displayed</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Custom Object Properties"), Description("Show when the value is true. If not defined the control will hide with value is true.")>
    Public Property GraphicShownWhenFalse() As System.Drawing.Image
        Get
            Return _graphicShownWhenFalse
        End Get
        Set(ByVal value As System.Drawing.Image)
            _graphicShownWhenFalse = value
            If _graphicShownWhenFalse Is Nothing And PictureShownInDesigner = PictureShown.FALSE_PICTURE Then
                PictureShownInDesigner = PictureShown.UNDETERMINED
            End If
        End Set
    End Property

    ''' <summary>
    ''' Show when the value is false. If not defined the control will hide with value is false."
    ''' </summary>
    ''' <value>Image to be displayed</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Custom Object Properties"), Description("Show when the value is false. If not defined the control will hide with value is false.")>
    Public Property GraphicShownWhenTrue() As System.Drawing.Image
        Get
            Return _graphicShownWhenTrue
        End Get
        Set(ByVal value As System.Drawing.Image)
            _graphicShownWhenTrue = value
            If _graphicShownWhenTrue Is Nothing And PictureShownInDesigner = PictureShown.TRUE_PICTURE Then
                PictureShownInDesigner = PictureShown.UNDETERMINED
            End If
        End Set
    End Property

    <Category("Custom Object Properties"), Description("Show specified picture on the designer for testing purposes.")>
    Public Property PictureShownInDesigner As PictureShown
        Get
            Return _pictureShownInDesigner
        End Get
        Set(value As PictureShown)
            _pictureShownInDesigner = value
            Select Case _pictureShownInDesigner
                Case PictureShown.TRUE_PICTURE
                    If _graphicShownWhenTrue IsNot Nothing Then
                        PictureBox1.Image = _graphicShownWhenTrue
                    Else
                        Throw New ArgumentException("Please specified an image before setting this property")
                    End If
                Case PictureShown.FALSE_PICTURE
                    If _graphicShownWhenFalse IsNot Nothing Then
                        PictureBox1.Image = _graphicShownWhenFalse
                    Else
                        Throw New ArgumentException("Please specified an image before setting this property")
                    End If
                Case PictureShown.UNDETERMINED
                    PictureBox1.Image = My.Resources.Help
            End Select
        End Set
    End Property

    Protected Overrides Sub AlarmsProcessed()
        UpdateControl(ActiveAlarmList.Count <= 0)
    End Sub

    Protected Overrides Sub ConfigureControl()
        MyBase.ConfigureControl()
        Visible = True
    End Sub
#End Region

End Class
