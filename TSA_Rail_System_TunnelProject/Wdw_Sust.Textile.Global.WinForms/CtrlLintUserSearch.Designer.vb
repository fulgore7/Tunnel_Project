
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CtrlLintUserSearch


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtrlLintUserSearch))
        Me.GroupBoxFindOptions = New System.Windows.Forms.GroupBox()
        Me.LinkOpenRFIDReader = New System.Windows.Forms.LinkLabel()
        Me.LabelRFIDFind = New System.Windows.Forms.Label()
        Me.RadioButtonRFIDCard = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPersonelNumber = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEmployeeName = New System.Windows.Forms.RadioButton()
        Me.TextBoxFind = New System.Windows.Forms.TextBox()
        Me.LabelFindCriteria = New System.Windows.Forms.Label()
        Me.ButtonFind = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBoxNameReturn = New System.Windows.Forms.ListBox()
        Me.GroupBoxFindOptions.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFindOptions
        '
        Me.GroupBoxFindOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxFindOptions.Controls.Add(Me.LinkOpenRFIDReader)
        Me.GroupBoxFindOptions.Controls.Add(Me.LabelRFIDFind)
        Me.GroupBoxFindOptions.Controls.Add(Me.RadioButtonRFIDCard)
        Me.GroupBoxFindOptions.Controls.Add(Me.RadioButtonPersonelNumber)
        Me.GroupBoxFindOptions.Controls.Add(Me.RadioButtonEmployeeName)
        Me.GroupBoxFindOptions.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxFindOptions.Name = "GroupBoxFindOptions"
        Me.GroupBoxFindOptions.Size = New System.Drawing.Size(275, 92)
        Me.GroupBoxFindOptions.TabIndex = 0
        Me.GroupBoxFindOptions.TabStop = False
        Me.GroupBoxFindOptions.Text = "Search Criteria"
        '
        'LinkOpenRFIDReader
        '
        Me.LinkOpenRFIDReader.AutoSize = True
        Me.LinkOpenRFIDReader.Location = New System.Drawing.Point(205, 70)
        Me.LinkOpenRFIDReader.Name = "LinkOpenRFIDReader"
        Me.LinkOpenRFIDReader.Size = New System.Drawing.Size(30, 13)
        Me.LinkOpenRFIDReader.TabIndex = 4
        Me.LinkOpenRFIDReader.TabStop = True
        Me.LinkOpenRFIDReader.Text = "Here"
        '
        'LabelRFIDFind
        '
        Me.LabelRFIDFind.AutoSize = True
        Me.LabelRFIDFind.Location = New System.Drawing.Point(117, 70)
        Me.LabelRFIDFind.Name = "LabelRFIDFind"
        Me.LabelRFIDFind.Size = New System.Drawing.Size(90, 13)
        Me.LabelRFIDFind.TabIndex = 3
        Me.LabelRFIDFind.Text = "Have Card? Click"
        '
        'RadioButtonRFIDCard
        '
        Me.RadioButtonRFIDCard.AutoSize = True
        Me.RadioButtonRFIDCard.Location = New System.Drawing.Point(9, 68)
        Me.RadioButtonRFIDCard.Name = "RadioButtonRFIDCard"
        Me.RadioButtonRFIDCard.Size = New System.Drawing.Size(105, 17)
        Me.RadioButtonRFIDCard.TabIndex = 2
        Me.RadioButtonRFIDCard.TabStop = True
        Me.RadioButtonRFIDCard.Text = "Productivity Card"
        Me.RadioButtonRFIDCard.UseVisualStyleBackColor = True
        '
        'RadioButtonPersonelNumber
        '
        Me.RadioButtonPersonelNumber.AutoSize = True
        Me.RadioButtonPersonelNumber.Location = New System.Drawing.Point(9, 45)
        Me.RadioButtonPersonelNumber.Name = "RadioButtonPersonelNumber"
        Me.RadioButtonPersonelNumber.Size = New System.Drawing.Size(106, 17)
        Me.RadioButtonPersonelNumber.TabIndex = 1
        Me.RadioButtonPersonelNumber.TabStop = True
        Me.RadioButtonPersonelNumber.Text = "Personel Number"
        Me.RadioButtonPersonelNumber.UseVisualStyleBackColor = True
        '
        'RadioButtonEmployeeName
        '
        Me.RadioButtonEmployeeName.AutoSize = True
        Me.RadioButtonEmployeeName.Location = New System.Drawing.Point(9, 22)
        Me.RadioButtonEmployeeName.Name = "RadioButtonEmployeeName"
        Me.RadioButtonEmployeeName.Size = New System.Drawing.Size(118, 17)
        Me.RadioButtonEmployeeName.TabIndex = 0
        Me.RadioButtonEmployeeName.TabStop = True
        Me.RadioButtonEmployeeName.Text = "Cast Member Name"
        Me.RadioButtonEmployeeName.UseVisualStyleBackColor = True
        '
        'TextBoxFind
        '
        Me.TextBoxFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFind.Location = New System.Drawing.Point(12, 142)
        Me.TextBoxFind.Name = "TextBoxFind"
        Me.TextBoxFind.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxFind.TabIndex = 1
        '
        'LabelFindCriteria
        '
        Me.LabelFindCriteria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelFindCriteria.AutoSize = True
        Me.LabelFindCriteria.Location = New System.Drawing.Point(15, 114)
        Me.LabelFindCriteria.Name = "LabelFindCriteria"
        Me.LabelFindCriteria.Size = New System.Drawing.Size(204, 13)
        Me.LabelFindCriteria.TabIndex = 2
        Me.LabelFindCriteria.Text = "Input information based on Search Criteria"
        '
        'ButtonFind
        '
        Me.ButtonFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFind.Location = New System.Drawing.Point(154, 139)
        Me.ButtonFind.Name = "ButtonFind"
        Me.ButtonFind.Size = New System.Drawing.Size(72, 25)
        Me.ButtonFind.TabIndex = 3
        Me.ButtonFind.Text = "Find"
        Me.ButtonFind.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClose.Location = New System.Drawing.Point(233, 140)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(62, 24)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxFindOptions)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonFind)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelFindCriteria)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxFind)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBoxNameReturn)
        Me.SplitContainer1.Size = New System.Drawing.Size(467, 170)
        Me.SplitContainer1.SplitterDistance = 299
        Me.SplitContainer1.TabIndex = 5
        '
        'ListBoxNameReturn
        '
        Me.ListBoxNameReturn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxNameReturn.FormattingEnabled = True
        Me.ListBoxNameReturn.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxNameReturn.Name = "ListBoxNameReturn"
        Me.ListBoxNameReturn.Size = New System.Drawing.Size(161, 160)
        Me.ListBoxNameReturn.TabIndex = 0
        '
        'CtrlLintUserSearch
        '
        Me.AcceptButton = Me.ButtonFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(467, 170)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CtrlLintUserSearch"
        Me.Text = "Cast Memeber Search"
        Me.GroupBoxFindOptions.ResumeLayout(False)
        Me.GroupBoxFindOptions.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxFindOptions As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonRFIDCard As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPersonelNumber As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEmployeeName As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxFind As System.Windows.Forms.TextBox
    Friend WithEvents LabelFindCriteria As System.Windows.Forms.Label
    Friend WithEvents LinkOpenRFIDReader As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelRFIDFind As System.Windows.Forms.Label
    Friend WithEvents ButtonFind As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListBoxNameReturn As System.Windows.Forms.ListBox
End Class


