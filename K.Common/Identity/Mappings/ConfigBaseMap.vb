Imports K.Common.R2.Identity.Entities
Imports NHibernate.Mapping.ByCode.Conformist
Imports NHibernate.Mapping.ByCode

Namespace Identity.Mappings

    Public Class ConfigBaseMap
        Inherits ClassMapping(Of ConfigBase)

        Public Sub New()
            MyBase.New()
            Schema("dbo")
            Lazy(True)
            Id(Function(x) x.Seq, Sub(map) map.Generator(Generators.Assigned))
            [Property](Function(x) x.BranchCode, Sub(map)
                                                     map.NotNullable(True)
                                                     map.Length(3)
                                                 End Sub)
            [Property](Function(x) x.ConfigName, Sub(map)
                                                     map.NotNullable(True)
                                                     map.Length(24)
                                                 End Sub)
            [Property](Function(x) x.ConfigValue, Sub(map)
                                                      map.NotNullable(True)
                                                      map.Length(64)
                                                  End Sub)
        End Sub
    End Class
End Namespace