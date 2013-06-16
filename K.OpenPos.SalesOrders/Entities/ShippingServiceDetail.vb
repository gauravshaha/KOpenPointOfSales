Imports System.ComponentModel.DataAnnotations

Namespace Entities
    Friend Class ShippingServiceDetail
        Public Overridable Property Id() As Guid
        Public Overridable Property ShippingServices() As ShippingServices
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <StringLength(128)> _
        Public Overridable Property Address() As String
        <StringLength(64)> _
        Public Overridable Property City() As String
        <StringLength(5)> _
        Public Overridable Property PostalCode() As String
        <StringLength(16)> _
        Public Overridable Property PhoneLine1() As String
        <StringLength(16)> _
        Public Overridable Property PhoneLine2() As String
        <StringLength(16)> _
        Public Overridable Property Fax() As String
        <StringLength(128)> _
        Public Overridable Property Email() As String
        <StringLength(256)> _
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