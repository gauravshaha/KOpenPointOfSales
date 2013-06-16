Imports System.ComponentModel.DataAnnotations

Namespace Identity.Entities

    Public Class UserProfile
        Public Sub New()
            MyBase.New()
            UserDetails = New List(Of UserDetails)()
        End Sub
        Public Overridable Property Id() As Guid
        Public Overridable Property UserSecurity() As UserSecurity
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(3)> _
        Public Overridable Property BranchCode() As String
        <Required(), _
            StringLength(3)> _
        Public Overridable Property AppCode() As String
        <Required(), _
            StringLength(24)> _
        Public Overridable Property UserName() As String
        <Required(), _
            StringLength(64)> _
        Public Overridable Property FullName() As String
        <Required(), _
            StringLength(128)> _
        Public Overridable Property Email() As String
        <Required(), _
            StringLength(128)> _
        Public Overridable Property CssProfile() As String
        <Required(), _
            StringLength(24)> _
        Public Overridable Property CreatedBy() As String
        <Required()> _
        Public Overridable Property CreatedDate() As Date
        <StringLength(24)> _
        Public Overridable Property ModifiedBy() As String
        Public Overridable Property ModifiedDate() As Date?
        Public Overridable Property UserDetails() As IList(Of UserDetails)
    End Class
End Namespace