Imports NHibernate.Mapping.ByCode
Imports NHibernate.Mapping.ByCode.Conformist
Imports K.Common.R2.Identity.Entities

Namespace Identity.Mappings

    Public Class UserSecurityMap
        Inherits ClassMapping(Of UserSecurity)

        Public Sub New()
            MyBase.New()
            Table("UserProfile")
            Schema("dbo")
            Lazy(True)
            Id(Function(x) x.Id, Sub(map) map.Generator(Generators.Assigned))
            [Property](Function(x) x.RowStatus, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Precision(3)
                                                End Sub)
            [Property](Function(x) x.RowVersion, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.UserPassword, Sub(map) map.Length(24))
            [Property](Function(x) x.MustChangePassword, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.IsWindowIdentity, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.CreatedBy, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Length(24)
                                                End Sub)
            [Property](Function(x) x.CreatedDate, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.ModifiedBy, Sub(map) map.Length(24))
            [Property](Function(x) x.ModifiedDate)
            Bag(Of UserProfile)(Function(x) x.UserProfile, Sub(colmap) colmap.Key(Function(x) CType(x, IKeyMapper).Column("Id")), Sub(map) map.OneToMany())
        End Sub

    End Class
End Namespace