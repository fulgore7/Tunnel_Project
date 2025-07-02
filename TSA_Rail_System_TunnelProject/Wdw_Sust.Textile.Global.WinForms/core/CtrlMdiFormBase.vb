Imports System.Windows.Forms

Imports Wdw_Sust.Core.WinForms.Interfaces
Imports Wdw_Sust.Core.Timer
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Core.WinForms

Namespace Wdw_Sust.Textile.Global.WinForms.Core
    Public Class CtrlMdiFormBase
        Inherits CtrlMainFormBase
        Implements IManageForms

#Region "Fields"
        Private ReadOnly _benchmarkTimer As New HighResolutionTimer()
        Private _formChildren As Dictionary(Of Type, Form)
        Private configPath As String
#End Region

#Region "Properties"
        'Public ReadOnly Property PreviousApplicationMode As ProgramMode
        '    Get
        '        Return _previousApplicationMode
        '    End Get
        'End Property
#End Region

#Region "Methods"
        Protected Function ShowChildForm(Of T As Form)(Optional ByVal parameters As Object() = Nothing, Optional formName As String = Nothing, Optional ByVal setAsChild As Boolean = True, Optional ByVal isDialog As Boolean = False, Optional ByVal showLoadingScreen As Boolean = True, Optional ByVal centerParent As Boolean = True) As T
            Dim singleInstance As Boolean = True
            Dim frm As T = GetFormChild(GetType(T))
            Try
                _benchmarkTimer.StartTimer()
                Application.DoEvents()
                If frm Is Nothing Then
                    If showLoadingScreen Then LoadingManager.StartLoading(frm)
                    If isDialog Then setAsChild = False
                    OnChildFormCreating(GetType(T), parameters)
                    frm = Activator.CreateInstance(GetType(T), parameters)
                    OnChildFormCreated(frm, singleInstance)
                    AddHandler frm.FormClosed, AddressOf ReleaseForm
                    If setAsChild Then
                        frm.MdiParent = Me
                    End If
                    If singleInstance Then FormChildren.Add(frm.GetType, frm)
                End If
                If isDialog Then
                    If LoadingManager.IsLoading Then LoadingManager.StopLoading(frm)
                    If setAsChild Then
                        frm.MdiParent = Me
                    End If
                    frm.Visible = False
                    frm.ShowDialog()
                Else
                    frm.ShowInTaskbar = False
                    frm.Show()
                    frm.Select()
                    frm.BringToFront()
                End If
                _benchmarkTimer.StopTimer()
                If formName IsNot Nothing Then frm.Text = formName
                Return frm
            Catch ex As Exception
                Return Nothing
            Finally
                If LoadingManager.IsLoading Then LoadingManager.StopLoading(frm)
            End Try
        End Function

        ''' <summary>
        ''' Called when [child form created].
        ''' </summary>
        ''' <param name="frm">The form object created.</param>
        ''' <param name="singleInstance">if set to <c>true</c> we can create more than one form object of the same type. Default is set to true.</param>
        Protected Overridable Sub OnChildFormCreated(ByVal frm As Form, ByRef singleInstance As Boolean)

        End Sub

        Protected Overridable Sub OnChildFormCreating(ByVal frmType As Type, ByVal parameters As Object())

        End Sub

        Public Sub CloseFormChild(type As System.Type) Implements IManageForms.CloseFormChild
            If FormChildren.ContainsKey(type) Then
                Dim frm As Form = FormChildren(type)
                frm.Close()
                FormChildren.Remove(type)
            End If
        End Sub

        Private Sub ReleaseForm(sender As Object, e As System.Windows.Forms.FormClosedEventArgs)
            Dim frm As Form = TryCast(sender, Form)
            If frm Is Nothing Then Throw New ArgumentException("sender has to be a form object!!")
            RemoveHandler frm.FormClosed, AddressOf ReleaseForm
            frm.Hide()
            _formChildren.Remove(sender.GetType)
            If frm.MdiParent IsNot Nothing Then frm.MdiParent = Nothing
        End Sub

        Public Function DoesChildExist(ByVal type As Type) As Boolean
            Return GetFormChild(type) IsNot Nothing
        End Function

        Public ReadOnly Property FormChildren As Dictionary(Of Type, System.Windows.Forms.Form) Implements IManageForms.FormChildren
            Get
                If _formChildren Is Nothing Then _formChildren = New Dictionary(Of Type, Form)
                Return _formChildren
            End Get
        End Property

        Public Function GetFormChild(ByVal type As Type) As Form Implements IManageForms.GetFormChild
            If FormChildren.ContainsKey(type) Then Return FormChildren(type)
            Return Nothing
        End Function

#End Region

#Region "Constructors"
        Public Sub New(configPath As String)
            MyBase.New(configPath)
            Init()
        End Sub

        Public Sub New(configPath As String, ByVal plant As Plant, ByVal appId As LintApplicationId)
            MyBase.New(configPath, plant, appId)
            Init()
        End Sub

        Public Sub New(ByVal plant As Plant, ByVal appId As LintApplicationId)
            MyBase.New(plant, appId)
            Init()
        End Sub

        Public Sub New()
            MyBase.New()
            Init()
        End Sub

        Private Sub Init()
            InitializeComponent()
            DoubleBuffered = True
            Me.KeyPreview = True
            Me.TabStop = False
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
            UpdateStyles()
            AddHandler _benchmarkTimer.TimerStopped, Sub() Console.WriteLine("Time Loading Child Form: {0} seconds", _benchmarkTimer.GetTotalElapsedTimeInSeconds)
        End Sub
#End Region

    End Class

End Namespace