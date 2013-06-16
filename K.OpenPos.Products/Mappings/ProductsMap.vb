Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ProductsMap
        Inherits ClassMap(Of Entities.Products)

        Public Sub New()
            MyBase.New()
            Table("Products")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.ProductStock).Column("Id")
            References(Function(x) x.ItemCategory).Column("ItemCategoryId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.ProductCode).Column("ProductCode").[Not].Nullable().Length(8)
            Map(Function(x) x.ProductName).Column("ProductName").[Not].Nullable().Length(32)
            Map(Function(x) x.MarketName).Column("MarketName").[Not].Nullable().Length(32)
            Map(Function(x) x.GeneralCode).Column("GeneralCode").[Not].Nullable().Length(16)
            Map(Function(x) x.DefaultQaCode).Column("DefaultQaCode").[Not].Nullable().Length(2)
            Map(Function(x) x.DefaultUomCode).Column("DefaultUomCode").[Not].Nullable().Length(4)
            Map(Function(x) x.MethodValuating).Column("MethodValuating").[Not].Nullable().Precision(3)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace