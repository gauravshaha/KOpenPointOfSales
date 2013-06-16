Imports Omu.ValueInjecter

Namespace AutoMapper

    Public Class NormalToNullables
        Inherits ConventionInjection
        Protected Overrides Function Match(c As ConventionInfo) As Boolean
            Return c.SourceProp.Name = c.TargetProp.Name AndAlso c.SourceProp.Type = Nullable.GetUnderlyingType(c.TargetProp.Type)
        End Function
    End Class
End Namespace