Imports K.OpenPos.Products.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings
    Class ProductPricingMap
        Inherits ClassMap(Of ProductPricing)

        Public Sub New()
            MyBase.New()
            Table("ProductPricing")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Products).Column("ProductId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.PriceCode).Column("PriceCode").[Not].Nullable().Length(4)
            Map(Function(x) x.PriceCodeDisplayed).Column("PriceCodeDisplayed").[Not].Nullable().Length(16)
            Map(Function(x) x.StartSalesPrice).Column("StartSalesPrice").[Not].Nullable().Precision(53)
            Map(Function(x) x.EndSalesPrice).Column("EndSalesPrice").[Not].Nullable().Precision(53)
            Map(Function(x) x.StartActiveDate).Column("StartActiveDate").[Not].Nullable()
            Map(Function(x) x.EndActiveDate).Column("EndActiveDate").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace