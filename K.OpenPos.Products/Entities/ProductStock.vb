Imports System.ComponentModel.DataAnnotations

Namespace Entities

    Class ProductStock
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Property Id() As Guid
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required()> _
        Public Overridable Property QuantityAvailable() As Single
        <Required()> _
        Public Overridable Property QuantityAllocated() As Single
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