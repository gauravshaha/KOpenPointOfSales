Imports Omu.ValueInjecter

Namespace AutoMapper

    Public Class EnumToInt
        Inherits ConventionInjection
        Protected Overrides Function Match(c As ConventionInfo) As Boolean
            Return c.SourceProp.Name = c.TargetProp.Name AndAlso c.SourceProp.Type.IsSubclassOf(GetType([Enum])) AndAlso c.TargetProp.Type = GetType(Integer)
        End Function
    End Class
End Namespace