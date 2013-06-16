Imports K.OpenPos.Products.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings
    Class ProductDetailMap
        Inherits ClassMap(Of ProductDetail)

        Public Sub New()
            MyBase.New()
            Table("ProductDetail")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Products).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.GrossWeight).Column("GrossWeight").[Not].Nullable().Precision(53)
            Map(Function(x) x.NetWeight).Column("NetWeight").[Not].Nullable().Precision(53)
            Map(Function(x) x.Length).Column("Length").[Not].Nullable().Precision(53)
            Map(Function(x) x.Width).Column("Width").[Not].Nullable().Precision(53)
            Map(Function(x) x.Height).Column("Height").[Not].Nullable().Precision(53)
            Map(Function(x) x.ReorderPoint).Column("ReorderPoint").[Not].Nullable().Precision(53)
            Map(Function(x) x.MaxOrders).Column("MaxOrders").[Not].Nullable().Precision(53)
            Map(Function(x) x.MinOrders).Column("MinOrders").[Not].Nullable().Precision(53)
            Map(Function(x) x.WarnInstructions).Column("WarnInstructions").[Not].Nullable().Length(512)
            Map(Function(x) x.PickInstructions).Column("PickInstructions").[Not].Nullable().Length(512)
            Map(Function(x) x.DeliveryInstructions).Column("DeliveryInstructions").[Not].Nullable().Length(512)
            Map(Function(x) x.SafeInstructions).Column("SafeInstructions").[Not].Nullable().Length(512)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace