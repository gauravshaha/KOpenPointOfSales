Imports FluentNHibernate.Mapping
Imports K.Common.R2.Identity.Entities

Namespace Identity.Mappings

    Public Class UserSecurityMap
        Inherits ClassMap(Of UserSecurity)

        Public Sub New()
            MyBase.New()
            Table("UserSecurity")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.UserProfile).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.UserPassword).Column("UserPassword").Length(24)
            Map(Function(x) x.MustChangePassword).Column("MustChangePassword").[Not].Nullable()
            Map(Function(x) x.IsWindowIdentity).Column("IsWindowIdentity").[Not].Nullable()
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub

    End Class
End Namespace