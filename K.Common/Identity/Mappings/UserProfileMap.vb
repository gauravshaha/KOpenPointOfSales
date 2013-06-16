Imports K.Common.R2.Identity.Entities
Imports FluentNHibernate.Mapping

Namespace Identity.Mappings


    Friend Class UserProfileMap
        Inherits ClassMap(Of UserProfile)

        Public Sub New()
            MyBase.New()
            Table("UserProfile")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.UserSecurity).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.AppCode).Column("AppCode").[Not].Nullable().Length(3)
            Map(Function(x) x.UserName).Column("UserName").[Not].Nullable().Length(24)
            Map(Function(x) x.FullName).Column("FullName").[Not].Nullable().Length(64)
            Map(Function(x) x.Email).Column("Email").[Not].Nullable().Length(128)
            Map(Function(x) x.CssProfile).Column("CssProfile").[Not].Nullable().Length(128)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")

        End Sub
    End Class
End Namespace