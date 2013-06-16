Imports System.ComponentModel.DataAnnotations

Namespace Entities
    Class ProductPicture
        Public Overridable Property Id() As Guid
        Public Overridable Property Products() As Products
        <Required()> _
        Public Overridable Property RowStatus() As Byte
        <Required()> _
        Public Overridable Property RowVersion() As Date
        <Required(), _
            StringLength(64)> _
        Public Overridable Property FileName() As String
        <Required()> _
        Public Overridable Property ProductPictureVal() As Byte()
        <StringLength(64)> _
        Public Overridable Property Description() As String
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