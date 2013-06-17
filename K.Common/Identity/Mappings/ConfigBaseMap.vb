Imports K.Common.R2.Identity.Entities
Imports FluentNHibernate.Mapping

Namespace Identity.Mappings

    Class ConfigBaseMap
        Inherits ClassMap(Of ConfigBase)

        Sub New()
            MyBase.New()
            Table("ConfigBase")
            LazyLoad()
            Id(Function(x) x.Id).GeneratedBy.Assigned().Column("Id")
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.ConfigName).Column("ConfigName").[Not].Nullable().Length(24)
            Map(Function(x) x.ConfigValue).Column("ConfigValue").[Not].Nullable().Length(64)
        End Sub
    End Class
End Namespace