Imports K.OpenPos.Products.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class ProductStockJournalMap
        Public Class ProductStockJournalMap
            Inherits ClassMap(Of ProductStockJournal)

            Public Sub New()
                MyBase.New()
                Table("ProductStockJournal")
                LazyLoad()
                Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
                References(Function(x) x.Products).Column("ProductId")
                Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
                Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
                Map(Function(x) x.TransactionCode).Column("TransactionCode").[Not].Nullable().Length(3)
                Map(Function(x) x.TransactionDate).Column("TransactionDate").[Not].Nullable()
                Map(Function(x) x.QuantityAvailable).Column("QuantityAvailable").[Not].Nullable().Precision(53)
                Map(Function(x) x.QuantityAllocated).Column("QuantityAllocated").[Not].Nullable().Precision(53)
                Map(Function(x) x.QuantityTurnover).Column("QuantityTurnover").[Not].Nullable().Precision(53)
                Map(Function(x) x.AllocatedTurnover).Column("AllocatedTurnover").[Not].Nullable().Precision(53)
                Map(Function(x) x.Notes).Column("Notes").[Not].Nullable().Length(256)
                Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
                Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
                Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
                Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
            End Sub
        End Class
    End Class
End Namespace