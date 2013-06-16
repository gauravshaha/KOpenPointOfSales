Imports K.OpenPos.Products.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ProductStockMap
        Inherits ClassMap(Of ProductStock)

        Public Sub New()
            MyBase.New()
            Table("ProductStock")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.QuantityAvailable).Column("QuantityAvailable").[Not].Nullable().Precision(53)
            Map(Function(x) x.QuantityAllocated).Column("QuantityAllocated").[Not].Nullable().Precision(53)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace