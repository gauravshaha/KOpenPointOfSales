Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class Orders
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Property Id() As Guid
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(3)> _
        Public Overridable Property BranchCode() As String
        <Required(), _
            StringLength(12)> _
        Public Overridable Property OrderNo() As String
        <Required(), _
            StringLength(16)> _
        Public Overridable Property ExternalDocumentNo() As String
        <Required()> _
        Public Overridable Property OrderType() As Byte
        <Required()> _
        Public Overridable Property OrderStatus() As Byte
        <Required()> _
        Public Overridable Property PaymentType() As Byte
        <Required()> _
        Public Overridable Property OrderDate() As Date
        <Required()> _
        Public Overridable Property DateRequireShipment() As Date
        <Required()> _
        Public Overridable Property CustomerId() As System.Guid
        <Required()> _
        Public Overridable Property DownPayment() As Single
        <Required()> _
        Public Overridable Property ShippingCharge() As Single
        <Required()> _
        Public Overridable Property AddValueTax() As Single
        <Required()> _
        Public Overridable Property OtherTax() As Single
        <Required()> _
        Public Overridable Property TotalOrders() As Single
        <Required(), _
            StringLength(256)> _
        Public Overridable Property Notes() As String
        <Required()> _
        Public Overridable Property IsOrderFullFill() As Boolean
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