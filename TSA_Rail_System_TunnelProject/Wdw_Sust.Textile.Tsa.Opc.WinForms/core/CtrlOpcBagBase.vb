' ***********************************************************************
' Assembly         : Wdw_Sust.Textile.Global.Opc.WinForms
' Author           : yeunc009
' Created          : 04-13-2017
'
' Last Modified By : yeunc009
' Last Modified On : 05-24-2017
' ***********************************************************************
' <copyright file="CtrlOpcBagBase.vb" company="Microsoft">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports Wdw_Sust.Core.Attributes
Imports Wdw_Sust.Core.Enums
Imports Wdw_Sust.Core.WinForms.Helpers
Imports Wdw_Sust.Textile.Core
Imports Wdw_Sust.Textile.Core.Enums
Imports Wdw_Sust.Textile.Core.EventArgs
Imports Wdw_Sust.Textile.Core.Interfaces
Imports Wdw_Sust.Textile.Global.Opc.WinForms.EventArgs

Namespace Core

    ''' <summary>
    ''' This button has to work with the UDT structure of Bag in the PLC!!
    ''' </summary>
    ''' <seealso cref="Wdw_Sust.Textile.Global.Opc.WinForms.Core.CtrlOpcBase" />
    ''' <seealso cref="Wdw_Sust.Textile.Core.Interfaces.ILintEditableBag" />
    Public Class CtrlOpcBagBase
        Inherits CtrlOpcBase


#Region "Fields"

        ''' <summary>
        ''' The cs manager
        ''' </summary>
        'Private WithEvents CsManagerWithEvents As Wdw_Sust.Core.WinForms.ContextStripManager

        ''' <summary>
        ''' The graphic border size for the round bag indicators when the weight of the bag has reached the max weight.
        ''' </summary>
        Public Const BORDER_SIZE_MAX_WEIGHT As Integer = 3

        ''' <summary>
        ''' The graphic border size for the round bag indicators.
        ''' </summary>
        Public Const BORDER_SIZE_NORMAL As Integer = 1

        ''' <summary>
        ''' The graphic border size for the round bag indicators when the weight of the bag has reached the over weight range.
        ''' </summary>
        Public Const BORDER_SIZE_OVER_WEIGHT As Integer = 4

        ''' <summary>
        ''' The percentage (%) of the release weight that will make this bag over weight.  This value should be a positive whole number from 0 to 99.  The default value should be 10.
        ''' </summary>
        Public Const PERCENTAGE_FOR_BAG_TO_BE_OVER_WEIGHT As Integer = 10

        ''' <summary>
        ''' This will put a border color around bag tags on the display to flag bags that are over weight.
        ''' </summary>
        Public Const SHOULD_HIGHLIGHT_OVERWEIGHT_BAGS_WITH_BORDER_COLOR As Boolean = False

        ''' <summary>
        ''' The text format
        ''' </summary>
        Protected Shared TextFormat As StringFormat

        ''' <summary>
        ''' The cache
        ''' </summary>
        Private Shared Cache As New Dictionary(Of Integer, Bitmap)

        ''' <summary>
        ''' The bag identifier
        ''' </summary>
        Private _bagId As Integer

        'Private _weight As Double
        ''' <summary>
        ''' The category
        ''' </summary>
        Private _category As Integer = 88

        ''' <summary>
        ''' The category detail
        ''' </summary>
       ' Private _categoryDetail As ILintCategoryDetail

        ''' <summary>
        ''' This list stores all the zones that should show that a bag is overweight.
        ''' </summary>
        Private _overwieght_zone_display_list As New List(Of LintZone)

        ''' <summary>
        ''' The roles to change bag
        ''' </summary>
        Private _rolesToChangeBag As List(Of LintUserType)
        Private BagDetail As Object

        'Check Manually Modified Bag
        '1.)When get bag data from db, check if the bit which indicates the bag
        '   to see if the bag has been manually modified
        'Set Modified bit to PLC
        '1.)Add the bit to tell the bag has been modified when update or add bag
        '2.)If the bag is added, it will not have a bag id until the bag moves to
        '   next location
        'Changes needed
        '1.)Add a bit to the PLC bag data structure
        '2.)Add a column in the bag data table

#End Region

#Region "Events"

        ''' <summary>
        ''' Occurs when the bag edit form is needed
        ''' </summary>
        ' Public Event OnDisplayBagEditForm As EventHandler(Of BagEditFormEventArgs)

        ''' <summary>
        ''' Occurs when bag issue form is needed
        ''' </summary>
        ' Public Event OnDisplayBagIssueForm As EventHandler(Of BagIssueReportFormEventArgs)

        ''' <summary>
        ''' Occurs when after the bag being displayed
        ''' </summary>
        Public Event OnDisplayedBagData(sender As Object, e As System.EventArgs)

        ''' <summary>
        ''' Occurs when on displaying the bag
        ''' </summary>
        ' Public Event OnDisplayingBagData(sender As Object, e As LintBagEventArgs)

#End Region

#Region "Properties"

        ''' <summary>
        ''' Gets or sets the color of the bag back.
        ''' </summary>
        ''' <value>The color of the bag back.</value>
        '  <NotConnectableOpcItem(), Browsable(False)>
        Public Property BagBackColor() As Color = SystemColors.Control

        ''' <summary>
        ''' Gets or sets the bag drawing mode.
        ''' </summary>
        ''' <value>The bag drawing mode.</value>
      '  <NotConnectableOpcItem(), Category("Custom Object Properties")>
        Public Shared Property BagDrawingMode() As BagDrawingMode = BagDrawingMode.THREE_DIMENSION_FADE_IN

        ''' <summary>
        ''' Gets or sets the bag mode.
        ''' </summary>
        ''' <value>The bag mode.</value>
        '<NotConnectableOpcItem(),
        'DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        'Category("Custom Object Properties"),
        'Description("Set the bag to be read only and cannot be edited")>
        ' Public Property BagMode() As FormMode = FormMode.NORMAL Implements ILintEditableBag.BagMode

        ''' <summary>
        ''' Gets or sets the bag rundown zone.
        ''' </summary>
        ''' <value>The bag rundown zone.</value>
        ' <NotConnectableOpcItem(), Category("Custom Object Properties")>
        Public Property BagRundownZone() As LintRundownZone

        ''' <summary>
        ''' Gets the color of the bag text.
        ''' </summary>
        ''' <value>The color of the bag text.</value>
       ' <NotConnectableOpcItem(), Browsable(False)>
        Public Property BagTextColor() As Color = Color.Black

        ''' <summary>
        ''' Gets or sets the category.
        ''' </summary>
        ''' <value>The category.</value>
        <Browsable(False)>
        Public Property Category() As Integer
            Get
                Return _category
            End Get
            Set(value As Integer)
                If _category <> value Then
                    _category = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets the font of the text displayed by the control.
        ''' </summary>
        ''' <value>The font.</value>
        ''' <PermissionSet>
        '''   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        '''   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        '''   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        '''   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ''' </PermissionSet>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
        Public Overrides Property Font() As Font
            Get
                Return MyBase.Font
            End Get
            Set(value As Font)
                MyBase.Font = value
                Cache.Remove(Category)
            End Set
        End Property

        ''' <summary>
        ''' This method indicates whether this instance is at max weight or over.
        ''' </summary>
        ''' <value><c>true</c> if this instance is over weight; otherwise, <c>false</c>.</value>
       ' <Browsable(False), NotConnectableOpcItem()>
        Public Overridable ReadOnly Property IsMaxWeight() As Boolean
            Get
                Dim theWeight As Double = Weight()
                Dim theReleaseWeight As Integer = ReleaseWeight()

                Return Category <> 99 'AndAlso
                ' Category <> 98 AndAlso
                'theWeight > 0 AndAlso
                ' theReleaseWeight > 0 AndAlso
                'CategoryDetail IsNot Nothing AndAlso
                'CInt(theWeight) >= theReleaseWeight
            End Get
        End Property

        ''' <summary>
        ''' Gets a value indicating whether this instance is over weight.
        ''' </summary>
        ''' <value><c>true</c> if this instance is over weight; otherwise, <c>false</c>.</value>
       ' <Browsable(False), NotConnectableOpcItem()>
        Public Overridable ReadOnly Property IsOverWeight() As Boolean
            Get
                Dim theWeight As Double = Weight()
                Dim theReleaseWeight As Integer = ReleaseWeight()

                Return Category <> 99 'AndAlso
                'Category <> 98 AndAlso
                'theWeight > 0 AndAlso
                'theReleaseWeight > 0 AndAlso
                'CategoryDetail IsNot Nothing AndAlso
                'CInt(theWeight * 100) > (100 + PERCENTAGE_FOR_BAG_TO_BE_OVER_WEIGHT) * theReleaseWeight ' This will calculate if the bag is over weight.
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the PLC bag identifier.
        ''' </summary>
        ''' <value>The PLC bag identifier.</value>
        <Browsable(False)>
        Public Overridable Property PLC_Bag_ID() As Integer

        ''' <summary>
        ''' Gets the release weight.
        ''' </summary>
        ''' <value>The release weight.</value>
       ' <Browsable(False), NotConnectableOpcItem()>
        Public Overridable ReadOnly Property ReleaseWeight() As Integer
            Get
            End Get
        End Property

        ''' <summary>
        ''' Gets the roles to change bag since some bag editing might need custom rights
        ''' </summary>
        ''' <value>The roles to change bag.</value>
       ' <NotConnectableOpcItem(), Category("Custom Object Properties")>
        Public ReadOnly Property RolesToChangeBag() As List(Of LintUserType)
            Get
                Return _rolesToChangeBag
            End Get
        End Property

        ''' <summary>
        ''' Gets the weight.
        ''' </summary>
        ''' <value>The weight.</value>
       ' <Browsable(False), NotConnectableOpcItem()>
        Public Overridable ReadOnly Property Weight() As Double
            Get
                If BagDetail Is Nothing Then
                    Return 0.0
                End If
                Return 0.0
            End Get
        End Property

        ''' <summary>
        ''' Gets or sets the zone.
        ''' </summary>
        ''' <value>The zone.</value>
       ' <NotConnectableOpcItem(), Category("Custom Object Properties")>
        Public Property Zone() As LintZone

        ''' <summary>
        ''' Gets or sets the bag detail.
        ''' </summary>
        ''' <value>The bag detail.</value>
       ' Protected Property BagDetail As ILintBagDetail

        ''' <summary>
        ''' Gets the bag identifier.
        ''' </summary>
        ''' <value>The bag identifier.</value>
       ' <NotConnectableOpcItem()>
        Protected Property BagId() As Integer
            Get
                Return _bagId
            End Get
            Private Set(value As Integer)
                _bagId = value
            End Set
        End Property

        Public Property ToolTipText As String
        Public Property CategoryDetail As Object

        ''' <summary>
        ''' Gets the category detail.
        ''' </summary>
        ''' <value>The category detail.</value>
        'Protected Property CategoryDetail() As ILintCategoryDetail
        '    Get
        '        Return _categoryDetail
        '    End Get
        '    Private Set(value As ILintCategoryDetail)
        '        _categoryDetail = value
        '    End Set
        'End Property

        ''' <summary>
        ''' Gets the context strip manager.
        ''' </summary>
        ''' <value>The cs manager.</value>
        '<NotConnectableOpcItem(), Browsable(False)>
        'Private ReadOnly Property CsManager() As Wdw_Sust.Core.WinForms.ContextStripManager
        '    Get
        '        If CsManagerWithEvents Is Nothing Then CsManagerWithEvents = New Wdw_Sust.Core.WinForms.ContextStripManager(1)
        '        Return CsManagerWithEvents
        '    End Get
        'End Property

#End Region

#Region "Methods"

        ''' <summary>
        ''' Invalidate the bag graphics stored in the memory so the new color can be re-read from the database
        ''' </summary>
        Public Shared Sub InvalidateCache()
            Cache.Clear()
        End Sub

        ''' <summary>
        ''' Constructs the tool tip text when control is pressed.
        ''' </summary>
        Protected Overridable Sub ConstructToolTipTextWhenControlIsPressed()
            ToolTipText = GetPlcTagDataAsText()
        End Sub

        ''' <summary>
        ''' Constructs the tool tip text when normal.
        ''' </summary>
        Protected Overridable Sub ConstructToolTipTextWhenNormal()
            If CategoryDetail IsNot Nothing Then
                ToolTipText = GetCategoryDataAsText()
            End If
        End Sub

        ''' <summary>
        ''' Constructs the tool tip text when shift is pressed.
        ''' </summary>
        Protected Overridable Sub ConstructToolTipTextWhenShiftIsPressed()

        End Sub

        ''' <summary>
        ''' Gets the bag data.
        ''' </summary>
        ''' <param name="bagId">The bag identifier.</param>
        ''' <returns>ILintBagDetail.</returns>
        ''' <exception cref="System.InvalidOperationException">This needs to be overridden to provide a concrete implementation to get bag detail</exception>
        Protected Overridable Function GetBagData(bagId As Integer)
            Throw New InvalidOperationException("This needs to be overridden to provide a concrete implementation to get bag detail")
        End Function

        ''' <summary>
        ''' Gets the bag edit data.
        ''' </summary>
        ''' <param name="bagID">The bag identifier.</param>
        ''' <returns>System.String.</returns>
        Protected Function GetBagEditData(bagID As Integer) As String
            Dim sb As New StringBuilder
            sb.Append("Edit History:")

            'For Each detail As LintBagEditDetail In Factory.Rail.GetBagEditDetails(bagID)
            '    With detail
            '        sb.Append(String.Format("{0}{1}{2}{3}Name: {4}{5}{6}{7}Old CC: {8}{9}New CC: {10}",
            '                                         vbCrLf, .TimeOfAction, vbTab, vbTab,
            '                                         .EmployeeName, vbTab, vbTab, vbTab,
            '                                         .OldCategoryCode, vbTab,
            '                                         .NewCategoryCode))
            '    End With
            'Next
            Return sb.ToString()

        End Function

        ''' <summary>
        ''' Gets the category data as text.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Protected Overridable Function GetCategoryDataAsText() As String
            Dim theWeight As Double = Weight()
            If CategoryDetail IsNot Nothing Then
                If theWeight > 0 Then
                    Return String.Format("{0} - {1:F2} lbs ({2} lbs)", CategoryDetail.CategoryDescription, theWeight, ReleaseWeight)
                Else
                    Return String.Format("{0} - Not Recorded ({1} lbs)", CategoryDetail.CategoryDescription, ReleaseWeight)
                End If
            Else
                Return String.Format("No Category Detail/Description - {0:F2} lbs ({1} lbs)", theWeight, ReleaseWeight)
            End If
        End Function

        ''' <summary>
        ''' Called when [updated PLC bag identifier].
        ''' </summary>
        Protected Overridable Sub OnUpdatedPlcBagId()

        End Sub

        ''' <summary>
        ''' Updates the category code.
        ''' </summary>
        ''' <param name="categoryCode">The category code.</param>
        Protected Sub UpdateCategoryCode(categoryCode As Integer)
            Category = categoryCode
            If Category = 0 Then
                Visible = False
                CategoryDetail = Nothing
                BagDetail = Nothing
            Else
                Visible = True
                'CategoryDetail = Factory.Rail.GetCategoryDetail(_category)
                'BagBackColor = ConvertDecRgbToColor(_categoryDetail.GetBagColor.BackColor)
                'BagTextColor = ConvertDecRgbToColor(_categoryDetail.GetBagColor.TextColor)
                Invalidate()
            End If
        End Sub

        ''' <summary>
        ''' Updates the PLC bag identifier.
        ''' </summary>
        ''' <param name="plcBagId">The PLC bag identifier.</param>
        Protected Sub UpdatePlcBagId(plcBagId As Integer)
            BagId = plcBagId
            'If BagId > 0 AndAlso CONFIGURATION.ApplicationMode = ProgramMode.PRODUCTION Then
            '    BagDetail = GetBagData(BagId)
            'End If
            OnUpdatedPlcBagId()
        End Sub

        ''' <summary>
        ''' This is where the handshaking takes place
        ''' </summary>
        ''' <param name="index">Property index</param>
        ''' <param name="value">Value of the item that has this property index</param>
        ''' <exception cref="System.ArgumentException">Index Out Of Range!!</exception>
        Protected Overrides Sub ValueFromPlcToObject(index As Integer, value As Object)
            Select Case index
                Case 1
                    'SyncContext.Post(New SendOrPostCallback(Sub() UpdateCategoryCode(CInt(value))), Nothing)
                    'PostSyncCallbackAsync(Sub() UpdateCategoryCode(value))
                Case 2
                    UpdatePlcBagId(value)
                Case Else
                    Throw New ArgumentException("Index Out Of Range!!")
            End Select
        End Sub

        ''' <summary>
        ''' Constructs the tool tip text.
        ''' </summary>
        Private Sub ConstructToolTipText()
            ToolTipText = String.Empty
            If IsShiftPressed() AndAlso Not CONFIGURATION.IsFailOverMode Then
                ConstructToolTipTextWhenShiftIsPressed()
            ElseIf IsControlPressed() Then
                ConstructToolTipTextWhenControlIsPressed()
            Else
                ConstructToolTipTextWhenNormal()
            End If
        End Sub

        ''' <summary>
        ''' Handles the ShowContextStrip event of the _csManager_ control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub CsManager__ShowContextStrip(sender As Object, e As System.EventArgs) Handles CsManagerWithEvents._ShowContextStrip
            ContextMenuStrip1.Show(Me, PointToClient(MousePosition))
            CsManagerWithEvents = Nothing
        End Sub

        ''' <summary>
        ''' Gets the PLC tag data as text.
        ''' </summary>
        ''' <returns>System.String.</returns>
        Private Function GetPlcTagDataAsText() As String
            Return String.Format("PLC Name:{0}{1}PLC Tag:{2}{3}Group Name:{4}{5}Zone:{6}{7}Rundown:{8}",
                                                                    PlcName, vbCrLf,
                                                                    TagName, vbCrLf,
                                                                    GroupName, vbCrLf,
                                                                    Zone.ToString, vbCrLf,
                                                                    BagRundownZone)
        End Function

#Region "Mouse Actions"

        ''' <summary>
        ''' Handles the MouseEnter event of the Bag control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Public Sub Bag_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Me.MouseHover
            ConstructToolTipText()
            ShowToolTip()
        End Sub

        ''' <summary>
        ''' Reports the bag issue.
        ''' </summary>
        Protected Overridable Sub ReportBagIssue()
            Dim args As New BagIssueReportFormEventArgs() With {.PlcName = CONFIGURATION.PlcTopics.TsaCleanworkPlc, .TagName = TagName}
            RaiseEvent OnDisplayBagIssueForm(Me, args)
        End Sub

        ''' <summary>
        ''' Handles the MouseDown event of the Bag control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        Private Sub Bag_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
            If e.Button = MouseButtons.Left Then
                '_dragManager.StartDragging()
                'DoDragDrop(5, DragDropEffects.All)
            ElseIf e.Button = MouseButtons.Right Then
                CsManager.StartHolding()
            End If
        End Sub

        ''' <summary>
        ''' Handles the MouseLeave event of the Bag control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub Bag_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
            HideToolTip()
        End Sub

        ''' <summary>
        ''' Handles the MouseUp event of the Bag control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        Private Sub Bag_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
            If CsManagerWithEvents IsNot Nothing Then
                CsManager.CancelHolding()
            End If
        End Sub

        ''' <summary>
        ''' Creates the bag edit argument.
        ''' </summary>
        ''' <param name="message">The message.</param>
        ''' <param name="bagMode">The bag mode.</param>
        ''' <returns>BagEditFormEventArgs.</returns>
        Private Function CreateBagEditArgument(message As String, bagMode As FormMode) As BagEditFormEventArgs
            Return New BagEditFormEventArgs With
                                             {
                                                .BagDetail = BagDetail,
                                                .Message = message,
                                                .BagMode = bagMode,
                                                .PlcName = PlcName,
                                                .TagName = TagName,
                                                .RolesToChangeBag = RolesToChangeBag,
                                                .Zone = Zone
                                             }
        End Function

        ''' <summary>
        ''' Edits the bag.
        ''' </summary>
        Private Sub EditBag()
            Dim args As New LintBagEventArgs(BagMode, Zone, BagRundownZone)
            RaiseEvent OnDisplayingBagData(Me, args)

            If args.BagMode <> FormMode.NOT_CLICKABLE Then
                Dim bagArgs As BagEditFormEventArgs = CreateBagEditArgument(args.Message, args.BagMode)
                RaiseEvent OnDisplayBagEditForm(Me, bagArgs)
            End If
        End Sub

        ''' <summary>
        ''' Handles the MouseClick event of the OPCBag control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        Private Sub OPCBag_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
            If Category <> 88 AndAlso _BagMode <> FormMode.NOT_CLICKABLE Then
                Select Case e.Button
                    Case MouseButtons.Left
                        EditBag()
                    Case MouseButtons.Right
                        If CONFIGURATION.IsFailOverMode OrElse PlcName <> CONFIGURATION.PlcTopics.TsaCleanworkPlc Then
                            ContextMenuStrip1.Items.RemoveByKey("ReportBagIssueToolStripMenuItem")
                        End If
                        ContextMenuStrip1.Items.RemoveByKey("SendBagToMaintenanceToolStripMenuItem")
                        ContextMenuStrip1.Show(Me, PointToClient(MousePosition))
                End Select
            End If
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ReportBagIssueToolStripMenuItem control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub ReportBagIssueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReportBagIssueToolStripMenuItem.Click
            ReportBagIssue()
        End Sub

        ''' <summary>
        ''' Handles the Click event of the ShowBagDetailToolStripMenuItem control.
        ''' </summary>
        ''' <param name="sender">The source of the event.</param>
        ''' <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        Private Sub ShowBagDetailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowBagDetailToolStripMenuItem.Click
            EditBag()
        End Sub

#End Region

#Region "Graphics"

        Public Function InvertColor(ByRef colorToInvert As Color) As Color
            Dim RGBMAX = 255

            Return Color.FromArgb(RGBMAX - colorToInvert.R, RGBMAX - colorToInvert.G, RGBMAX - colorToInvert.B)
        End Function

        ''' <summary>
        ''' Create the category background and stored in memory.
        ''' </summary>
        ''' <returns>Bitmap.</returns>
        Protected Overridable Function CreateCategoryBackground() As Bitmap
            Dim bp As New Bitmap(Width, Height, Imaging.PixelFormat.Format32bppPArgb)
            Using g As Graphics = Graphics.FromImage(bp)
                Using gp As New GraphicsPath
                    Dim rect As New Rectangle(1, 1, Width - 2, Height - 2)
                    gp.AddEllipse(rect)
                    Select Case BagDrawingMode
                        Case BagDrawingMode.THREE_DIMENSION_FADE_OUT
                            Draw3DCategoryFadeOutBackground(rect, gp, g)
                        Case BagDrawingMode.THREE_DIMENSION_FADE_IN
                            Draw3DCategoryFadeInBackground(rect, gp, g)
                        Case BagDrawingMode.TWO_DIMENSION
                            Draw2DCategoryBackground(rect, g)
                    End Select

                    Using pn As New Pen(Color.Black, BORDER_SIZE_NORMAL)
                        g.DrawPath(pn, gp)
                    End Using
                End Using
            End Using
            Return bp
        End Function

        ''' <summary>
        ''' Draw Category on the bag graphics. If it is an overweight bad the category number will turn red.
        ''' </summary>
        ''' <param name="categoryCode">Category number</param>
        ''' <param name="g">Graphics to be drawn on</param>
        Protected Overridable Sub DrawCategory(categoryCode As String, g As Graphics)

            Dim b As SolidBrush

            ' color the bag category value red if its in the sorting zone and is overweight.
            If _overwieght_zone_display_list.Contains(Zone) AndAlso IsOverWeight Then
                b = New SolidBrush(Color.Red)
                ' only color the bag if its over weight.
                'ElseIf isMaxWeight Then
                '    b = New SolidBrush(Color.OrangeRed)
            Else
                b = New SolidBrush(BagTextColor)
            End If

            Using b
                g.DrawString(categoryCode, Font, b, Height * 0.5, Width * 0.4, TextFormat)
            End Using
        End Sub

        ''' <summary>
        ''' Draws the category background.
        ''' </summary>
        ''' <param name="g">The g.</param>
        Protected Overridable Sub DrawCategoryBackground(g As Graphics)
            If CONFIGURATION.Plant = Plant.ASA OrElse _BagMode = FormMode.NOT_CLICKABLE Then
                Using bp As Bitmap = CreateCategoryBackground()
                    g.DrawImage(bp, 0, 0)
                End Using
            ElseIf Cache.ContainsKey(Category) Then
                g.DrawImage(Cache(Category), 0, 0)
            Else
                Dim bp As Bitmap = CreateCategoryBackground()
                g.DrawImage(bp, 0, 0)
                Cache.Add(Category, bp)
            End If
        End Sub

        ''' <summary>
        ''' Draw effect when the bag is being clicked
        ''' </summary>
        ''' <param name="g">The g.</param>
        Protected Overridable Sub DrawClickState(g As Graphics)
            Using gp As New GraphicsPath
                Dim rect As New Rectangle(1, 1, Width - 2, Height - 2)
                gp.AddEllipse(rect)
                Using pbr As New PathGradientBrush(gp)
                    pbr.CenterPoint = New PointF((rect.Width * 0.5), (rect.Height * 0.5))
                    pbr.CenterColor = ConvertDecRgbToColor(_categoryDetail.GetBagColor.BackColor)
                    g.FillEllipse(pbr, rect)
                End Using
                Using pn As New Pen(Color.Black, 1)
                    g.DrawPath(pn, gp)
                End Using
            End Using
        End Sub

        ''' <summary>
        ''' This sub can be overridden to provide extra information on the bag, such as drop destination,
        ''' manually edited bag etc.
        ''' </summary>
        ''' <param name="g">The graphics of the bag</param>
        Protected Overridable Sub DrawExtraInformation(g As Graphics)
            If _BagDetail IsNot Nothing Then
                If CONFIGURATION.Plant = Plant.TSA AndAlso
                    _BagDetail.Data_Changed_Manually Then
                    Using pn As New Pen(Color.Red, width:=1.3)
                        Using gp As New GraphicsPath
                            Dim rect As New Rectangle(x:=1, y:=1, width:=Width - 2, height:=Height - 2)
                            gp.AddEllipse(rect)
                            g.DrawPath(pn, gp)
                        End Using
                    End Using

                End If
            Else
                ' DONT DO THIS AT THIS TIME.
                '    Using pen As Pen = New Pen(Color.Yellow, Width:=1.3)
                '        Using graphicsPath As New GraphicsPath
                '            Dim rect As Rectangle = New Rectangle(x:=1, y:=1, Width:=Width - 2, Height:=Height - 2)
                '            gp.AddEllipse(rect)
                '            g.DrawPath(pen, graphicsPath)
                '        End Using
                '    End Using
            End If
        End Sub

        ''' <summary>
        ''' Draw effect when the bag is being hovered
        ''' </summary>
        ''' <param name="g">Graphics to be drawn on</param>
        Protected Overridable Sub DrawHoverState(g As Graphics)
            'To be determined
        End Sub

        Protected Overridable Sub DrawOverWeightBagBorderRing(g As Graphics)

            If IsMaxWeight Then
                Dim rectangle As New Rectangle(1, 1, Width - 2, Height - 2)
                Dim borderSize As Integer = BORDER_SIZE_MAX_WEIGHT
                Dim borderColor As Color = Color.Orange

                If IsOverWeight Then
                    borderSize = BORDER_SIZE_OVER_WEIGHT
                    borderColor = Color.Red
                End If

                Using graphicPath As New GraphicsPath
                    graphicPath.AddEllipse(rectangle)
                    Using pen As New Pen(borderColor, borderSize)
                        g.DrawPath(pen, graphicPath)
                    End Using
                End Using
            End If
        End Sub

        ''' <summary>
        ''' Draw bag details
        ''' </summary>
        ''' <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data.</param>
        Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
            DrawCategoryBackground(e.Graphics)
            DrawCategory(Category, e.Graphics)
            DrawExtraInformation(e.Graphics)
            If SHOULD_HIGHLIGHT_OVERWEIGHT_BAGS_WITH_BORDER_COLOR AndAlso _overwieght_zone_display_list.Contains(Zone) Then
                DrawOverWeightBagBorderRing(e.Graphics)
            End If
        End Sub

        ''' <summary>
        ''' Draw2s the d category background.
        ''' </summary>
        ''' <param name="rect">The rect.</param>
        ''' <param name="g">The g.</param>
        Private Sub Draw2DCategoryBackground(rect As Rectangle, g As Graphics)
            Using sb As New SolidBrush(BagBackColor)
                g.FillEllipse(sb, rect)
            End Using
        End Sub

        ''' <summary>
        ''' Draw3s the d category fade in background.
        ''' </summary>
        ''' <param name="rect">The rect.</param>
        ''' <param name="graphicsPath">The GraphicsPath.</param>
        ''' <param name="graphics">The Graphics.</param>
        Private Sub Draw3DCategoryFadeInBackground(rect As Rectangle, graphicsPath As GraphicsPath, graphics As Graphics)
            Using pbr As New PathGradientBrush(graphicsPath)
                Dim c As Color() = {BagBackColor}
                pbr.CenterPoint = New PointF((rect.Width * 0.5), (rect.Height * 0.5))
                pbr.SurroundColors = c
                graphics.FillEllipse(pbr, rect)
            End Using
        End Sub

        ''' <summary>
        ''' Draw3s the d category fade out background.
        ''' </summary>
        ''' <param name="rect">The rect.</param>
        ''' <param name="graphicsPath">The GraphicsPath.</param>
        ''' <param name="graphics">The Graphics.</param>
        Private Sub Draw3DCategoryFadeOutBackground(rect As Rectangle, graphicsPath As GraphicsPath, graphics As Graphics)
            Using pbr As New PathGradientBrush(graphicsPath)
                pbr.CenterPoint = New PointF((rect.Width * 0.5), (rect.Height * 0.5))
                pbr.CenterColor = BagBackColor
                graphics.FillEllipse(pbr, rect)
            End Using
        End Sub

#End Region

#End Region

#Region "Constructors"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="CtrlOpcBagBase"/> class.
        ''' </summary>
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            SetStyle(ControlStyles.DoubleBuffer, True)
            SetStyle(ControlStyles.UserPaint, True)
            SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            DoubleBuffered = True
            TextFormat = New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

            ' From Classified Loading Platform
            _overwieght_zone_display_list.Add(LintZone.SORTING)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_EMPTY_BAG_RETURN)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_ONGOING_BUFFER)

            ' From Classified Storage
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_STORAGE)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_ONGOING_BUFFER)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_OFFGOING_BUFFER)

            ' From Classified Discharger
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_STORAGE)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_DISCHARGER)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_OFFGOING_BUFFER)
            _overwieght_zone_display_list.Add(LintZone.CLASSIFIED_EMPTY_BAG_RETURN)

            ' remove any duplicates that were added to the list above.  Its okay to add duplicates.
            Dim uniqueLintZones As List(Of LintZone) = _overwieght_zone_display_list.Distinct().ToList()
            _overwieght_zone_display_list = uniqueLintZones

        End Sub

#End Region

    End Class

End Namespace