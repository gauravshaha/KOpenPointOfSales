Imports NHibernate.Mapping.ByCode
Imports NHibernate.Mapping.ByCode.Conformist
Imports K.Common.R2.Identity.Entities

Namespace Identity.Mappings


    Public Class UserProfileMap
        Inherits ClassMapping(Of UserProfile)

        Public Sub New()
            MyBase.New()
            Schema("dbo")
            Lazy(True)
            Id(Function(x) x.Id, Sub(map) map.Generator(Generators.Assigned))
            [Property](Function(x) x.RowStatus, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Precision(3)
                                                End Sub)
            [Property](Function(x) x.RowVersion, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.BranchCode, Sub(map)
                                                     map.NotNullable(True)
                                                     map.Length(3)
                                                 End Sub)
            [Property](Function(x) x.AppCode, Sub(map)
                                                  map.NotNullable(True)
                                                  map.Length(3)
                                              End Sub)
            [Property](Function(x) x.UserName, Sub(map)
                                                   map.NotNullable(True)
                                                   map.Length(24)
                                               End Sub)
            [Property](Function(x) x.FullName, Sub(map)
                                                   map.NotNullable(True)
                                                   map.Length(64)
                                               End Sub)
            [Property](Function(x) x.Email, Sub(map)
                                                map.NotNullable(True)
                                                map.Length(128)
                                            End Sub)
            [Property](Function(x) x.CssProfile, Sub(map)
                                                     map.NotNullable(True)
                                                     map.Length(128)
                                                 End Sub)
            [Property](Function(x) x.CreatedBy, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Length(24)
                                                End Sub)
            [Property](Function(x) x.CreatedDate, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.ModifiedBy, Sub(map) map.Length(24))
            [Property](Function(x) x.ModifiedDate)
            ManyToOne(Function(x) x.UserSecurity, Sub(map)
                                                      map.Column("Id")
                                                      map.Cascade(Cascade.None)
                                                  End Sub)
            Bag(Of UserDetails)(Function(xProfile) xProfile.UserDetails, CollectionMapping(), Sub(map) map.OneToMany())
        End Sub

        Private Shared Function CollectionMapping() As Action(Of IBagPropertiesMapper(Of UserProfile, UserDetails))
            Return Sub(colmap)
                       colmap.Key(Function(x) x.Column("Id"))
                       colmap.Inverse(True)
                   End Sub
        End Function

    End Class


End Namespace