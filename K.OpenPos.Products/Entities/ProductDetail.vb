Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class ProductDetail
        Public Overridable Property Id() As Guid
        Public Overridable Property Products() As Products
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required()> _
        Public Overridable Property GrossWeight() As Single
        <Required()> _
        Public Overridable Property NetWeight() As Single
        <Required()> _
        Public Overridable Property Length() As Single
        <Required()> _
        Public Overridable Property Width() As Single
        <Required()> _
        Public Overridable Property Height() As Single
        <Required()> _
        Public Overridable Property ReorderPoint() As Single
        <Required()> _
        Public Overridable Property MaxOrders() As Single
        <Required()> _
        Public Overridable Property MinOrders() As Single
        <Required(), _
            StringLength(512)> _
        Public Overridable Property WarnInstructions() As String
        <Required(), _
            StringLength(512)> _
        Public Overridable Property PickInstructions() As String
        <Required(), _
            StringLength(512)> _
        Public Overridable Property DeliveryInstructions() As String
        <Required(), _
            StringLength(512)> _
        Public Overridable Property SafeInstructions() As String
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