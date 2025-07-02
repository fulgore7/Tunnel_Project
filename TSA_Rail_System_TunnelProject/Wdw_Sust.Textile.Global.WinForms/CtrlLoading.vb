
Public NotInheritable Class CtrlLoading
    ''Private _animation As New AnimationObject(30, AddressOf UpdateImage)

    'Private Sub frmLoading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Application.DoEvents()
    '    '_animation.LoadImage(My.Resources.Loading)
    '    '_animation.LoadImage(My.Resources.Loading_1_Dot)
    '    '_animation.LoadImage(My.Resources.Loading_2_Dot)
    '    '_animation.LoadImage(My.Resources.Loading_3_Dot)
    '    '_animation.StartAnimation()
    'End Sub

    ''Private Sub UpdateImage(ByVal sender As Object, ByVal img As Bitmap)
    ''    If InvokeRequired Then
    ''        Invoke(Sub() UpdateImage(sender, img), New Object() {sender, img})
    ''    Else
    ''        BackgroundImage = img
    ''        Refresh()
    ''    End If

    ''End Sub

    ''Protected Overrides Sub OnFormClosing(ByVal e As System.Windows.Forms.FormClosingEventArgs)
    ''    _animation.StopAnimation()
    ''    _animation.Dispose()
    ''    MyBase.OnFormClosing(e)
    ''End Sub

End Class
