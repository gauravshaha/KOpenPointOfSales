Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class InvoiceLogsMap
        Inherits ClassMap(Of InvoiceLogs)

        Public Sub New()
            MyBase.New()
            Table("InvoiceLogs")
            LazyLoad()
            Id(Function(x) x.Sequence).GeneratedBy.Identity().Column("Sequence")
            References(Function(x) x.Invoices).Column("InvoiceId")
            Map(Function(x) x.Logs).Column("Logs").[Not].Nullable().Length(2147483647)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
        End Sub
    End Class
End Namespace