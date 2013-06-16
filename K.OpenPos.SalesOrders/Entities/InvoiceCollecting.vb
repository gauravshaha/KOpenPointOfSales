Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class InvoiceCollecting
        Public Overridable Property Id() As Guid
        Public Overridable Property Invoices() As Invoices
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <StringLength(16)> _
        Public Overridable Property CollectingCode() As String
        <StringLength(64)> _
        Public Overridable Property CollectorName() As String
        Public Overridable Property CollectingDate() As Date?
        Public Overridable Property CollectingReportDate() As Date?
        <Required()> _
        Public Overridable Property PaymentType() As Byte
        <StringLength(24)> _
        Public Overridable Property PaymentRefNumber() As String
        <StringLength(64)> _
        Public Overridable Property PayerName() As String
        <StringLength(64)> _
        Public Overridable Property PayerAddress() As String
        <StringLength(16)> _
        Public Overridable Property PayerPhoneNumber() As String
        <Required()> _
        Public Overridable Property Amount() As Single
        <StringLength(128)> _
        Public Overridable Property Notes() As String
        <StringLength(128)> _
        Public Overridable Property NotesReport() As String
        <Required()> _
        Public Overridable Property IsOneTime() As Boolean
        <Required()> _
        Public Overridable Property FromFrontDesk() As Boolean
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