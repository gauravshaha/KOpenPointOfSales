
Imports K.Common.R2.Identity.Entities
Imports FluentNHibernate.Mapping

Namespace Identity.Mappings

   Public Class UserDetailsMap
        Inherits ClassMap(Of UserDetails)
        Public Sub New()
            MyBase.New()
            Table("UserDetails")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            References(Function(x) x.UserProfile).Column("Id")
            Map(Function(x) x.RowStatus).Column("RowStatus").[Not].Nullable().Precision(3)
            Map(Function(x) x.RowVersion).Column("RowVersion").[Not].Nullable()
            Map(Function(x) x.RegisterDate).Column("RegisterDate")
            Map(Function(x) x.ActivationDate).Column("ActivationDate")
            Map(Function(x) x.ActivationKey).Column("ActivationKey").Length(64)
            Map(Function(x) x.SecurityQuestion).Column("SecurityQuestion").Length(256)
            Map(Function(x) x.SecurityAnswer).Column("SecurityAnswer").Length(128)
            Map(Function(x) x.CreatedBy).Column("CreatedBy").[Not].Nullable().Length(24)
            Map(Function(x) x.CreatedDate).Column("CreatedDate").[Not].Nullable()
            Map(Function(x) x.ModifiedBy).Column("ModifiedBy").Length(24)
            Map(Function(x) x.ModifiedDate).Column("ModifiedDate")
        End Sub
    End Class
End Namespace