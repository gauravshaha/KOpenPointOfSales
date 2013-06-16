Imports System.ComponentModel.DataAnnotations

Namespace Identity.Entities

    Public Class UserDetails
        Public Overridable Property Id() As Guid
        Public Overridable Property UserProfile() As UserProfile
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        Public Overridable Property RegisterDate() As Date?
        Public Overridable Property ActivationDate() As Date?
        <StringLength(64)> _
        Public Overridable Property ActivationKey() As String
        <StringLength(256)> _
        Public Overridable Property SecurityQuestion() As String
        <StringLength(128)> _
        Public Overridable Property SecurityAnswer() As String
        <Required(), _
            StringLength(24)> _
        Public Overridable Property CreatedBy() As String
        <Required()> _
        Public Overridable Property CreatedDate() As Date
        <StringLength(24)> _
        Public Overridable Property ModifiedBy() As String
        Public Overridable Property ModifiedDate() As Date?
    End Class
End Namespace