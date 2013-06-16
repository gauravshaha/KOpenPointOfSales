Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ShippingServicesMap
        Inherits ClassMap(Of ShippingServices)

        Public Sub New()
            MyBase.New()
            Table("ShippingServices")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.Priority).Column("Priority").[Not].Nullable().Precision(3)
            Map(Function(x) x.ShippingCharge).Column("ShippingCharge").[Not].Nullable().Precision(53)
            Map(Function(x) x.LegalName).Column("LegalName").[Not].Nullable().Length(64)
            Map(Function(x) x.MarketName).Column("MarketName").[Not].Nullable().Length(32)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace