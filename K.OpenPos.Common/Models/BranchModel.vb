Imports K.OpenPos.Common.Interfaces

Namespace Models

    Public Class BranchModel
        Implements IBranchModel

        Public Property Id() As Guid Implements IBranchModel.Id
        Public Property RowStatus() As Byte Implements IBranchModel.RowStatus
        Public Property RowVersion() As Date Implements IBranchModel.RowVersion
        Public Property BranchCode() As String Implements IBranchModel.BranchCode
        Public Property BranchName() As String Implements IBranchModel.BranchName
        Public Property IsHeadOffice() As Boolean Implements IBranchModel.IsHeadOffice
        Public Property CreatedBy() As String Implements IBranchModel.CreatedBy
        Public Property CreatedDate() As Date Implements IBranchModel.CreatedDate
        Public Property ModifiedBy() As String Implements IBranchModel.ModifiedBy
        Public Property ModifiedDate() As Date? Implements IBranchModel.ModifiedDate
        Public Property BranchDetail() As IList(Of IBranchDetailModel) Implements IBranchModel.BranchDetail
    End Class
End Namespace