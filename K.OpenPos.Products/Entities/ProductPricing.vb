Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class ProductPricing
        Public Overridable Property Id() As Guid
        Public Overridable Property Products() As Products
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(4)> _
        Public Overridable Property PriceCode() As String
        <Required(), _
            StringLength(16)> _
        Public Overridable Property PriceCodeDisplayed() As String
        <Required()> _
        Public Overridable Property StartSalesPrice() As Single
        <Required()> _
        Public Overridable Property EndSalesPrice() As Single
        <Required()> _
        Public Overridable Property StartActiveDate() As Date
        <Required()> _
        Public Overridable Property EndActiveDate() As Date
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