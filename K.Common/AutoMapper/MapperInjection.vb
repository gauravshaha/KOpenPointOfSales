Imports Omu.ValueInjecter

Namespace AutoMapper

    Public Class MapperInjection
        Inherits ConventionInjection
        Protected Overrides Function Match(c As ConventionInfo) As Boolean
            Return c.SourceProp.Name = c.TargetProp.Name AndAlso Not c.SourceProp.Type.IsValueType AndAlso c.SourceProp.Type <> GetType(String) AndAlso Not c.SourceProp.Type.IsGenericType AndAlso Not c.TargetProp.Type.IsGenericType OrElse c.SourceProp.Type.IsEnumerable() AndAlso c.TargetProp.Type.IsEnumerable()
        End Function

        Protected Overrides Function SetValue(c As ConventionInfo) As Object
            If c.SourceProp.Value Is Nothing Then
                Return Nothing
            End If
            Return Mapper.Map(c.SourceProp.Value, c.TargetProp.Value, c.SourceProp.Type, c.TargetProp.Type)
        End Function
    End Class
End Namespace