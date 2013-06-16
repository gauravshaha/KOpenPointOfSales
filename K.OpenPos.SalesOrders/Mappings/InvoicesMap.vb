Imports K.OpenPos.SalesOrders.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings

    Class InvoicesMap
        Inherits ClassMap(Of Invoices)

        Public Sub New()
            MyBase.New()
            Table("Invoices")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.Orders).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.InvoiceDate).Column("InvoiceDate").[Not].Nullable()
            Map(Function(x) x.InvoiceNumber).Column("InvoiceNumber").[Not].Nullable().Length(24)
            Map(Function(x) x.PrintCounter).Column("PrintCounter").[Not].Nullable().Precision(10)
            Map(Function(x) x.LastPrintDate).Column("LastPrintDate").[Not].Nullable()
            Map(Function(x) x.DiscountAllowances).Column("DiscountAllowances").[Not].Nullable()
            Map(Function(x) x.PaymentDiscount).Column("PaymentDiscount").Precision(4).Scale(2)
            Map(Function(x) x.DueDaysDiscount).Column("DueDaysDiscount").Precision(3)
            Map(Function(x) x.PaymentTerm).Column("PaymentTerm").Precision(3)
            Map(Function(x) x.TermType).Column("TermType").Length(3)
            Map(Function(x) x.Notes).Column("Notes").[Not].Nullable().Length(256)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace