Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ShippingOrderLogMap
        Inherits ClassMap(Of ShippingOrderLog)

        Public Sub New()
            MyBase.New()
            Table("ShippingOrderLog")
            LazyLoad()
            Id(Function(x) x.Sequence).GeneratedBy.Identity().Column("Sequence")
            References(Function(x) x.ShippingOrders).Column("ShippingOrderId")
            Map(Function(x) x.Logs).Column("Logs").[Not].Nullable().Length(2147483647)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
        End Sub
    End Class
End Namespace