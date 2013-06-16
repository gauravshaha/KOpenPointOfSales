Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class InvoiceCollectingMap
        Inherits ClassMap(Of InvoiceCollecting)

        Public Sub New()
            MyBase.New()
            Table("InvoiceCollecting")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Invoices).Column("InvoiceId")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.CollectingCode).Column("CollectingCode").Length(16)
            Map(Function(x) x.CollectorName).Column("CollectorName").Length(64)
            Map(Function(x) x.CollectingDate).Column("CollectingDate")
            Map(Function(x) x.CollectingReportDate).Column("CollectingReportDate")
            Map(Function(x) x.PaymentType).Column("PaymentType").[Not].Nullable().Precision(3)
            Map(Function(x) x.PaymentRefNumber).Column("PaymentRefNumber").Length(24)
            Map(Function(x) x.PayerName).Column("PayerName").Length(64)
            Map(Function(x) x.PayerAddress).Column("PayerAddress").Length(64)
            Map(Function(x) x.PayerPhoneNumber).Column("PayerPhoneNumber").Length(16)
            Map(Function(x) x.Amount).Column("Amount").[Not].Nullable().Precision(53)
            Map(Function(x) x.Notes).Column("Notes").Length(128)
            Map(Function(x) x.NotesReport).Column("NotesReport").Length(128)
            Map(Function(x) x.IsOneTime).Column("IsOneTime").[Not].Nullable()
            Map(Function(x) x.FromFrontDesk).Column("FromFrontDesk").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace