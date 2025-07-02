' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 01-23-2017
'
' Last Modified By : yeunc009
' Last Modified On : 05-31-2017
' ***********************************************************************
' <copyright file="NotConnectableOpcItemAttribute.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Namespace Attributes
    ''' <summary>
    ''' An attribute declaration to indicate that the property cannot connect to the Plc.
    ''' </summary>
    ''' <seealso cref="System.Attribute" />
    <AttributeUsage(AttributeTargets.Property)>
    Public Class NotConnectableOpcItemAttribute
        Inherits Attribute
        ''' <summary>
        ''' When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.
        ''' </summary>
        ''' <param name="obj">An <see cref="T:System.Object" /> to compare with this instance of <see cref="T:System.Attribute" />.</param>
        ''' <returns>true if this instance equals <paramref name="obj" />; otherwise, false.</returns>
        Public Overrides Function Match(obj As Object) As Boolean
            Return True
        End Function
    End Class
End Namespace
