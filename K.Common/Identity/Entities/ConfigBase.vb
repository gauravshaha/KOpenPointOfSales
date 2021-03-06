﻿Imports System.ComponentModel.DataAnnotations

Namespace Identity.Entities

    Class ConfigBase
        Public Overridable Property Id() As Guid
        <Required(), _
            StringLength(3)> _
        Public Overridable Property BranchCode() As String
        <Required(), _
            StringLength(24)> _
        Public Overridable Property ConfigName() As String
        <Required(), _
            StringLength(64)> _
        Public Overridable Property ConfigValue() As String
    End Class
End Namespace