Imports K.OpenPos.Common.Entities
Imports NHibernate.Mapping.ByCode.Conformist
Imports NHibernate.Mapping.ByCode

Namespace Mappings

    Friend Class BranchDetailMap
        Inherits ClassMapping(Of BranchDetail)

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
            [Property](Function(x) x.Address, Sub(map) map.Length(64))
            [Property](Function(x) x.ZipCode, Sub(map) map.Length(5))
            [Property](Function(x) x.City, Sub(map) map.Length(64))
            [Property](Function(x) x.State, Sub(map) map.Length(64))
            [Property](Function(x) x.PhoneLine1, Sub(map) map.Length(16))
            [Property](Function(x) x.PhoneLine2, Sub(map) map.Length(16))
            [Property](Function(x) x.FaxOffice, Sub(map) map.Length(16))
            [Property](Function(x) x.Email, Sub(map) map.Length(128))
            [Property](Function(x) x.Description, Sub(map) map.Length(256))
            [Property](Function(x) x.CreatedBy, Sub(map)
                                                    map.NotNullable(True)
                                                    map.Length(24)
                                                End Sub)
            [Property](Function(x) x.CreatedDate, Sub(map) map.NotNullable(True))
            [Property](Function(x) x.ModifiedBy, Sub(map) map.Length(24))
            [Property](Function(x) x.ModifiedDate)
            ManyToOne(Function(x) x.Branch, Sub(map)
                                                map.Column("Id")
                                                map.Cascade(Cascade.None)
                                            End Sub)
        End Sub
    End Class
End Namespace