Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Wdw_Sust.Core.Serialization

''' <summary>
''' Class NotifyableBase. All derived classes inherit from this class 
''' will take advantages of implementing INotifyPropertyChanged interface.
''' Call SetField function to funnel all PropertyChanged event logics when
''' setting properties.
''' </summary>
''' <seealso cref="Wdw_Sust.Core.CustomObjectBase" />
''' <seealso cref="System.ComponentModel.INotifyPropertyChanged" />
<Serializable>
Public MustInherit Class NotifyableBase
    Inherits CustomObjectBase
    Implements INotifyPropertyChanged

    ' boiler-plate
    <NonSerialized>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Protected Function SetField(Of T)(ByRef field As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing) As Boolean
        If EqualityComparer(Of T).Default.Equals(field, value) Then
            Return False
        End If
        field = value
        OnPropertyChanged(propertyName)
        Return True
    End Function
End Class

<Serializable>
Public MustInherit Class NotifyableBase(Of T)
    Inherits NotifyableBase
    Implements ICloneable

    Public Function Clone() As T
        Return SerializationManager.DeserializeData(SerializationManager.SerializeData(Me))
    End Function
    Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
        Return Clone()
    End Function
End Class