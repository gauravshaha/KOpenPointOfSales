Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class Products
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Property Id() As Guid
        Public Overridable Property ProductStock() As ProductStock
        Public Overridable Property ItemCategory() As ItemCategory
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(3)> _
        Public Overridable Property BranchCode() As String
        <Required(), _
            StringLength(8)> _
        Public Overridable Property ProductCode() As String
        <Required(), _
            StringLength(32)> _
        Public Overridable Property ProductName() As String
        <Required(), _
            StringLength(32)> _
        Public Overridable Property MarketName() As String
        <Required(), _
            StringLength(16)> _
        Public Overridable Property GeneralCode() As String
        <Required(), _
            StringLength(2)> _
        Public Overridable Property DefaultQaCode() As String
        <Required(), _
            StringLength(4)> _
        Public Overridable Property DefaultUomCode() As String
        <Required()> _
        Public Overridable Property MethodValuating() As Byte
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