Imports K.OpenPos.Products.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ProductPictureMap
        Inherits ClassMap(Of ProductPicture)

        Public Sub New()
            MyBase.New()
            Table("ProductPicture")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Products).Column("ProductId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.FileName).Column("FileName").[Not].Nullable().Length(64)
            Map(Function(x) x.ProductPictureVal).Column("ProductPicture").[Not].Nullable().Length(2147483647)
            Map(Function(x) x.Description).Column("Description").Length(64)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace