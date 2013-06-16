Imports K.Common.R2.Identity.Entities
Imports NHibernate.Mapping.ByCode.Conformist
Imports NHibernate.Mapping.ByCode

Namespace Identity.Mappings

    Public Class UserDetailsMap
        Inherits ClassMapping(Of UserDetails)

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
            [Property](Function(x) x.RegisterDate)
            [Property](Function(x) x.ActivationDate)
            [Property](Function(x) x.ActivationKey, Sub(map) map.Length(64))
            [Property](Function(x) x.SecurityQuestion, Sub(map) map.Length(256))
            [Property](Function(x) x.SecurityAnswer, Sub(map) map.Length(128))
            [Property](Function(x) x.CreatedBy, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Length(24)
                                                End Sub)
            [Property](Function(x) x.CreatedDate, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.ModifiedBy, Sub(map) map.Length(24))
            [Property](Function(x) x.ModifiedDate)
            ManyToOne(Function(x) x.UserProfile, Sub(map)
                                                     map.Column("Id")
                                                     map.PropertyRef("Id")
                                                     map.Cascade(Cascade.None)
                                                 End Sub)

        End Sub
    End Class
End Namespace