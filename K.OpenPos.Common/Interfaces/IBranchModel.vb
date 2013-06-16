


Namespace Interfaces
    Public Interface IBranchModel
        Property Id() As Guid
        Property RowStatus() As Byte
        Property RowVersion() As Date
        Property BranchCode() As String
        Property BranchName() As String
        Property IsHeadOffice() As Boolean
        Property CreatedBy() As String
        Property CreatedDate() As Date
        Property ModifiedBy() As String
        Property ModifiedDate() As Date?
        Property BranchDetail() As IList(Of IBranchDetailModel)
    End Interface
End Namespace