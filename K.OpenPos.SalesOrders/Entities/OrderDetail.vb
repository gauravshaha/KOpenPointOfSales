Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class OrderDetail
        Public Overridable Property Id() As Guid
        Public Overridable Property Orders() As Orders
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(3)> _
        Public Overridable Property BranchCode() As String
        <Required()> _
        Public Overridable Property OrderLine() As Short
        <StringLength(8)> _
        Public Overridable Property ProductCode() As String
        <StringLength(32)> _
        Public Overridable Property ProductName() As String
        <StringLength(32)> _
        Public Overridable Property MarketName() As String
        <StringLength(16)> _
        Public Overridable Property GeneralCode() As String
        <Required()> _
        Public Overridable Property UnitPrice() As Single
        <Required()> _
        Public Overridable Property Quantity() As Single
        <Required()> _
        Public Overridable Property Discount() As Single
        <Required(), _
            StringLength(2)> _
        Public Overridable Property QaCode() As String
        <Required(), _
            StringLength(4)> _
        Public Overridable Property UomCode() As String
        <Required(), _
            StringLength(128)> _
        Public Overridable Property Notes() As String
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