Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class ShippingOrders
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Property Id() As Guid
        Public Overridable Property Orders() As Orders
        Public Overridable Property ShippingServices() As ShippingServices
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(16)> _
        Public Overridable Property ShipmentNo() As String
        <StringLength(16)> _
        Public Overridable Property ShipmentNoExternal() As String
        <Required()> _
        Public Overridable Property ShipmentStatus() As Byte
        <Required()> _
        Public Overridable Property ShipmentType() As Byte
        <Required()> _
        Public Overridable Property ShipmentDate() As Date
        <Required(), _
            StringLength(64)> _
        Public Overridable Property ReceiverName() As String
        <StringLength(256)> _
        Public Overridable Property ReceiverNotes() As String
        <StringLength(256)> _
        Public Overridable Property TransporterNotes() As String
        <Required()> _
        Public Overridable Property PrintCounter() As Integer
        <Required()> _
        Public Overridable Property PrintDate() As Date
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