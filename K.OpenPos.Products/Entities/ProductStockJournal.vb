Imports System.ComponentModel.DataAnnotations

Namespace Entities
    Class ProductStockJournal
        Public Overridable Property Id() As Guid
        Public Overridable Property Products() As Products
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(3)> _
        Public Overridable Property TransactionCode() As String
        <Required()> _
        Public Overridable Property TransactionDate() As Date
        <Required()> _
        Public Overridable Property QuantityAvailable() As Single
        <Required()> _
        Public Overridable Property QuantityAllocated() As Single
        <Required()> _
        Public Overridable Property QuantityTurnover() As Single
        <Required()> _
        Public Overridable Property AllocatedTurnover() As Single
        <Required(), _
            StringLength(256)> _
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