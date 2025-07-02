' ***********************************************************************
' Assembly         : Wdw_Sust.Core
' Author           : yeunc009
' Created          : 05-31-2017
'
' Last Modified By : yeunc009
' Last Modified On : 05-31-2017
' ***********************************************************************
' <copyright file="ConnectableOpcItemAttribute.vb" company="TWDC">
'     Copyright © Microsoft 2016
' </copyright>
' <summary></summary>
' ***********************************************************************
Namespace Attributes
    ''' <summary>
    ''' An attribute declaration to indicate that the property is connectable to the Plc.
    ''' </summary>
    ''' <seealso cref="System.Attribute" />
    <AttributeUsage(AttributeTargets.Property)>
    Public Class ConnectableOpcItemAttribute
        Inherits Attribute
    End Class
End Namespace
