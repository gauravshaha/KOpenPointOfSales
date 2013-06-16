Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class InvoiceLogs
        Public Overridable Property Sequence() As Integer
        Public Overridable Property Invoices() As Invoices
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