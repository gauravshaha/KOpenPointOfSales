Imports K.OpenPos.Common.Entities
Imports FluentNHibernate.Mapping

Namespace Mappings
    Friend Class BranchMap
        Inherits ClassMap(Of Branch)

        Public Sub New()
            MyBase.New()
            Table("Branch")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.BranchName).Column("BranchName").[Not].Nullable().Length(64)
            Map(Function(x) x.IsHeadOffice).Column("IsHeadOffice").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")

        End Sub

    End Class
End Namespace