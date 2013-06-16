Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class OrdersMap
        Inherits ClassMap(Of Orders)

        Public Sub New()
            MyBase.New()
            Table("Orders")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.OrderNo).Column("OrderNo").[Not].Nullable().Length(12)
            Map(Function(x) x.ExternalDocumentNo).Column("ExternalDocumentNo").[Not].Nullable().Length(16)
            Map(Function(x) x.OrderType).Column("OrderType").[Not].Nullable().Precision(3)
            Map(Function(x) x.OrderStatus).Column("OrderStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.PaymentType).Column("PaymentType").[Not].Nullable().Precision(3)
            Map(Function(x) x.OrderDate).Column("OrderDate").[Not].Nullable()
            Map(Function(x) x.DateRequireShipment).Column("DateRequireShipment").[Not].Nullable()
            Map(Function(x) x.CustomerId).Column("CustomerId").[Not].Nullable()
            Map(Function(x) x.DownPayment).Column("DownPayment").[Not].Nullable().Precision(53)
            Map(Function(x) x.ShippingCharge).Column("ShippingCharge").[Not].Nullable().Precision(53)
            Map(Function(x) x.AddValueTax).Column("AddValueTax").[Not].Nullable().Precision(53)
            Map(Function(x) x.OtherTax).Column("OtherTax").[Not].Nullable().Precision(53)
            Map(Function(x) x.TotalOrders).Column("TotalOrders").[Not].Nullable().Precision(53)
            Map(Function(x) x.Notes).Column("Notes").[Not].Nullable().Length(256)
            Map(Function(x) x.IsOrderFullFill).Column("IsOrderFullFill").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace