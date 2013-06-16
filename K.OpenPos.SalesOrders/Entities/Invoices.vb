Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class Invoices
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Property Id() As Guid
        Public Overridable Property Orders() As Orders
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required()> _
        Public Overridable Property InvoiceDate() As Date
        <Required(), _
            StringLength(24)> _
        Public Overridable Property InvoiceNumber() As String
        <Required()> _
        Public Overridable Property PrintCounter() As Integer
        <Required()> _
        Public Overridable Property LastPrintDate() As Date
        <Required()> _
        Public Overridable Property DiscountAllowances() As Boolean
        Public Overridable Property PaymentDiscount() As Decimal?
        Public Overridable Property DueDaysDiscount() As Byte?
        Public Overridable Property PaymentTerm() As Byte?
        <StringLength(3)> _
        Public Overridable Property TermType() As String
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