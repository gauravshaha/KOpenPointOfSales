Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ShippingServiceDetailMap
        Inherits ClassMap(Of ShippingServiceDetail)

        Public Sub New()
            MyBase.New()
            Table("ShippingServiceDetail")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.ShippingServices).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.Address).Column("Address").Length(128)
            Map(Function(x) x.City).Column("City").Length(64)
            Map(Function(x) x.PostalCode).Column("PostalCode").Length(5)
            Map(Function(x) x.PhoneLine1).Column("PhoneLine1").Length(16)
            Map(Function(x) x.PhoneLine2).Column("PhoneLine2").Length(16)
            Map(Function(x) x.Fax).Column("Fax").Length(16)
            Map(Function(x) x.Email).Column("Email").Length(128)
            Map(Function(x) x.Notes).Column("Notes").Length(256)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace