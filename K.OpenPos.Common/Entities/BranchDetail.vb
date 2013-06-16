Imports System.ComponentModel.DataAnnotations

Namespace Entities
    Friend Class BranchDetail
        Public Overridable Property Id() As Guid
        Public Overridable Property Branch() As Branch

        <Required()>
        Public Overridable Property RowStatus() As Byte

        <Required()>
        Public Overridable Property RowVersion() As Date

        <Required()>
        Public Overridable Property BranchId() As Integer

        <StringLength(64)>
        Public Overridable Property Address() As String

        <StringLength(5)>
        Public Overridable Property ZipCode() As String

        <StringLength(64)>
        Public Overridable Property City() As String

        <StringLength(64)>
        Public Overridable Property State() As String

        <StringLength(16)>
        Public Overridable Property PhoneLine1() As String

        <StringLength(16)>
        Public Overridable Property PhoneLine2() As String

        <StringLength(16)>
        Public Overridable Property FaxOffice() As String

        <StringLength(128)>
        Public Overridable Property Email() As String

        <StringLength(256)>
        Public Overridable Property Description() As String

        <Required(),
            StringLength(24)>
        Public Overridable Property CreatedBy() As String

        <Required()>
        Public Overridable Property CreatedDate() As Date

        <StringLength(24)>
        Public Overridable Property ModifiedBy() As String

        Public Overridable Property ModifiedDate() As Date?
    End Class
End Namespace