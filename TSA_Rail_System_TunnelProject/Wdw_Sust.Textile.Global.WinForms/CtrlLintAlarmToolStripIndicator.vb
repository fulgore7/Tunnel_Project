Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.Drawing
Imports Wdw_Sust.Textile.Core.Enums
Imports System.Windows.Forms

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip Or ToolStripItemDesignerAvailability.StatusStrip)>
Public Class CtrlLintAlarmToolStripIndicator
    Inherits System.Windows.Forms.ToolStripControlHost

#Region "Proeprties"
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
     Category("Custom Object Properties"), Description("Determine which alarms to be subscribed.")>
    Public ReadOnly Property SubscribedAlarms() As List(Of Integer)
        Get
            Return CType(Control, CtrlLintAlarmMonitoringStatusIcon).SubscribedAlarms
        End Get
    End Property

    ''' <summary>
    ''' Show when the value is true. If not defined the control will hide with value is true.
    ''' </summary>
    ''' <value>Image to be displayed</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <Category("Custom Object Properties"), Description("Show when the value is true. If not defined the control will hide with value is true.")>
    Public Property GraphicShownWhenFalse() As System.Drawing.Image
        Get
            Return CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenFalse
        End Get
        Set(ByVal value As System.Drawing.Image)
            CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenFalse = value
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
            Return CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenTrue
        End Get
        Set(ByVal value As System.Drawing.Image)
            CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenTrue = value
        End Set
    End Property

    <Category("Custom Object Properties"), Description("Show specified picture on the designer for testing purposes.")>
    Public Property PictureShownInDesigner As PictureShown
        Get
            Return CType(Control, CtrlLintAlarmMonitoringStatusIcon).PictureShownInDesigner
        End Get
        Set(value As PictureShown)
            CType(Control, CtrlLintAlarmMonitoringStatusIcon).PictureShownInDesigner = value
            Select Case value
                Case PictureShown.TRUE_PICTURE
                    If GraphicShownWhenTrue IsNot Nothing Then
                        CType(Control, CtrlLintAlarmMonitoringStatusIcon).PictureBox1.Image = CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenTrue
                    Else
                        Throw New ArgumentException("Please specified an image before setting this property")
                    End If
                Case PictureShown.FALSE_PICTURE
                    If GraphicShownWhenTrue IsNot Nothing Then
                        CType(Control, CtrlLintAlarmMonitoringStatusIcon).PictureBox1.Image = CType(Control, CtrlLintAlarmMonitoringStatusIcon).GraphicShownWhenFalse
                    Else
                        Throw New ArgumentException("Please specified an image before setting this property")
                    End If
                Case PictureShown.UNDETERMINED
                    'CType(Control, CtrlLintAlarmMonitoringStatusIcon).PictureBox1.Image = My.Resources.Help
            End Select
        End Set
    End Property


#End Region

#Region "Methods"

#End Region

#Region "Constructors"

    Public Sub New()
        MyBase.New(New CtrlLintAlarmMonitoringStatusIcon)
        Control.Dock = DockStyle.Fill
        AutoSize = False
        Size = New Size(32, 32)
    End Sub


    Public Sub New(ByVal c As Control)
        MyBase.New(c)
    End Sub

    Public Sub New(ByVal c As Control, ByVal name As String)
        MyBase.New(c, name)
    End Sub

#End Region

End Class


