Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class ShippingOrderLog
        Public Overridable Property Sequence() As Integer
        Public Overridable Property ShippingOrders() As ShippingOrders
        <Required(), _
            StringLength(2147483647)> _
        Public Overridable Property Logs() As String
        <Required(), _
            StringLength(24)> _
        Public Overridable Property CreatedBy() As String
        <Required()> _
        Public Overridable Property CreatedDate() As Date
    End Class
End Namespace