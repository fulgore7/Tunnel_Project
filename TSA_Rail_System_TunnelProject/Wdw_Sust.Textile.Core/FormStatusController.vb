Imports System.ComponentModel
Imports Wdw_Sust.Core.Enums


Public Class FormStatusController
    Implements INotifyPropertyChanged

    Private _mode As FormMode

    Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

    <Bindable(True)>
    Public Property FormMode As FormMode
        Get
            Return _mode
        End Get
        Set(value As FormMode)
            If _mode <> value Then
                _mode = value
                OnPropertyChanged("FormMode")
            End If
        End Set
    End Property

    Private Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class


