Imports Omu.ValueInjecter

Namespace AutoMapper

    Public Class IntToEnum
        Inherits ConventionInjection
        Protected Overrides Function Match(c As ConventionInfo) As Boolean
            Return c.SourceProp.Name = c.TargetProp.Name AndAlso c.SourceProp.Type = GetType(Integer) AndAlso c.TargetProp.Type.IsSubclassOf(GetType([Enum]))
        End Function
    End Class
End Namespace