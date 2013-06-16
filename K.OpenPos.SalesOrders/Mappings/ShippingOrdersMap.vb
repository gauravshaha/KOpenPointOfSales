Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ShippingOrdersMap
        Inherits ClassMap(Of ShippingOrders)

        Public Sub New()
            MyBase.New()
            Table("ShippingOrders")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Orders).Column("Id")
            References(Function(x) x.ShippingServices).Column("ShippingServicesId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.ShipmentNo).Column("ShipmentNo").[Not].Nullable().Length(16)
            Map(Function(x) x.ShipmentNoExternal).Column("ShipmentNoExternal").Length(16)
            Map(Function(x) x.ShipmentStatus).Column("ShipmentStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.ShipmentType).Column("ShipmentType").[Not].Nullable().Precision(3)
            Map(Function(x) x.ShipmentDate).Column("ShipmentDate").[Not].Nullable()
            Map(Function(x) x.ReceiverName).Column("ReceiverName").[Not].Nullable().Length(64)
            Map(Function(x) x.ReceiverNotes).Column("ReceiverNotes").Length(256)
            Map(Function(x) x.TransporterNotes).Column("TransporterNotes").Length(256)
            Map(Function(x) x.PrintCounter).Column("PrintCounter").[Not].Nullable().Precision(10)
            Map(Function(x) x.PrintDate).Column("PrintDate").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace