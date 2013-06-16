Imports K.OpenPos.Common.Interfaces

Namespace Models

    Public Class BranchDetailModel
        Implements IBranchDetailModel

        Public Property Id() As Guid Implements IBranchDetailModel.Id
        Public Property Branch() As IBranchModel Implements IBranchDetailModel.Branch
        Public Property RowStatus() As Byte Implements IBranchDetailModel.RowStatus
        Public Property RowVersion() As Date Implements IBranchDetailModel.RowVersion
        Public Property Address() As String Implements IBranchDetailModel.Address
        Public Property ZipCode() As String Implements IBranchDetailModel.ZipCode
        Public Property City() As String Implements IBranchDetailModel.City
        Public Property State() As String Implements IBranchDetailModel.State
        Public Property PhoneLine1() As String Implements IBranchDetailModel.PhoneLine1
        Public Property PhoneLine2() As String Implements IBranchDetailModel.PhoneLine2
        Public Property FaxOffice() As String Implements IBranchDetailModel.FaxOffice
        Public Property Email() As String Implements IBranchDetailModel.Email
        Public Property Description() As String Implements IBranchDetailModel.Description
        Public Property CreatedBy() As String Implements IBranchDetailModel.CreatedBy
        Public Property CreatedDate() As Date Implements IBranchDetailModel.CreatedDate
        Public Property ModifiedBy() As String Implements IBranchDetailModel.ModifiedBy
        Public Property ModifiedDate() As Date? Implements IBranchDetailModel.ModifiedDate
    End Class
End Namespace