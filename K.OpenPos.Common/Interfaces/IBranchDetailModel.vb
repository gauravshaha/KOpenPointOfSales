

Namespace Interfaces
    Public Interface IBranchDetailModel
        Property Id() As Guid
        Property Branch() As IBranchModel
        Property RowStatus() As Byte
        Property RowVersion() As Date
        Property Address() As String
        Property ZipCode() As String
        Property City() As String
        Property State() As String
        Property PhoneLine1() As String
        Property PhoneLine2() As String
        Property FaxOffice() As String
        Property Email() As String
        Property Description() As String
        Property CreatedBy() As String
        Property CreatedDate() As Date
        Property ModifiedBy() As String
        Property ModifiedDate() As Date?
    End Interface
End Namespace