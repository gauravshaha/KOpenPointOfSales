Imports System.ComponentModel.DataAnnotations

Namespace Identity.Entities

    Public Class UserSecurity
        Public Sub New()
            MyBase.New()
            UserProfile = New List(Of UserProfile)()
        End Sub
        Public Overridable Property Id() As Guid
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <StringLength(24)> _
        Public Overridable Property UserPassword() As String
        <Required()> _
        Public Overridable Property MustChangePassword() As Boolean
        <Required()> _
        Public Overridable Property IsWindowIdentity() As Boolean
        <Required(), _
            StringLength(24)> _
        Public Overridable Property CreatedBy() As String
        <Required()> _
        Public Overridable Property CreatedDate() As Date
        <StringLength(24)> _
        Public Overridable Property ModifiedBy() As String
        Public Overridable Property ModifiedDate() As Date?
        Public Overridable Property UserProfile() As IList(Of UserProfile)
    End Class
End Namespace