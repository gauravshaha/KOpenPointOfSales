
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Namespace Entities
    Friend Class Branch
        Public Sub New()
            MyBase.New()
            BranchDetail = New List(Of BranchDetail)()
        End Sub

        Public Overridable Property Id() As Guid

        <Required()>
        Public Overridable Property RowStatus() As Byte

        <Required()>
        Public Overridable Property RowVersion() As Date

        <Required(),
            StringLength(3)>
        Public Overridable Property BranchCode() As String

        <Required(),
            StringLength(64)>
        Public Overridable Property BranchName() As String

        <Required()>
        Public Overridable Property IsHeadOffice() As Boolean

        <Required(),
            StringLength(24)>
        Public Overridable Property CreatedBy() As String

        <Required()>
        Public Overridable Property CreatedDate() As Date

        <StringLength(24)>
        Public Overridable Property ModifiedBy() As String

        Public Overridable Property ModifiedDate() As Date?
        Public Overridable Property BranchDetail() As IList(Of BranchDetail)
    End Class
End Namespace