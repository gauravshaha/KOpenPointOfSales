Imports Omu.ValueInjecter

Namespace AutoMapper

    Public Class NullablesToNormal
        Inherits ConventionInjection
        Protected Overrides Function Match(c As ConventionInfo) As Boolean
            Return c.SourceProp.Name = c.TargetProp.Name AndAlso Nullable.GetUnderlyingType(c.SourceProp.Type) = c.TargetProp.Type
        End Function
    End Class
End Namespace