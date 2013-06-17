Imports K.Common.R2.Identity.Entities
Imports FluentNHibernate.Mapping

Namespace Identity.Mappings

    Public Class ConfigBaseMap
        Inherits ClassMap(Of ConfigBase)

        Public Sub New()
            MyBase.New()
            Table("ConfigBase")
            LazyLoad()
            Id(Function(x) x.Seq).GeneratedBy.Assigned().Column("Seq")
            Map(Function(x) x.BranchCode).Column("BranchCode").[Not].Nullable().Length(3)
            Map(Function(x) x.ConfigName).Column("ConfigName").[Not].Nullable().Length(24)
            Map(Function(x) x.ConfigValue).Column("ConfigValue").[Not].Nullable().Length(64)
        End Sub
    End Class
End Namespace