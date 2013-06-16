Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class OrderDetailMap
        Inherits ClassMap(Of OrderDetail)

        Public Sub New()
            MyBase.New()
            Table("OrderDetail")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Orders).Column("OrderId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.OrderLine).Column("OrderLine").[Not].Nullable().Precision(5)
            Map(Function(x) x.ProductCode).Column("ProductCode").Length(8)
            Map(Function(x) x.ProductName).Column("ProductName").Length(32)
            Map(Function(x) x.MarketName).Column("MarketName").Length(32)
            Map(Function(x) x.GeneralCode).Column("GeneralCode").Length(16)
            Map(Function(x) x.UnitPrice).Column("UnitPrice").[Not].Nullable().Precision(53)
            Map(Function(x) x.Quantity).Column("Quantity").[Not].Nullable().Precision(53)
            Map(Function(x) x.Discount).Column("Discount").[Not].Nullable().Precision(53)
            Map(Function(x) x.QaCode).Column("QaCode").[Not].Nullable().Length(2)
            Map(Function(x) x.UomCode).Column("UomCode").[Not].Nullable().Length(4)
            Map(Function(x) x.Notes).Column("Notes").[Not].Nullable().Length(128)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace