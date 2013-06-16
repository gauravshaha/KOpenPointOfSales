Imports Omu.ValueInjecter

Namespace AutoMapper
    Public Class TypeMapper (Of TSource, TTarget)
        Implements ITypeMapper(Of TSource, TTarget)

        Public Function Map(ByVal source As TSource, ByVal target As TTarget) As TTarget _
            Implements ITypeMapper(Of TSource, TTarget).Map
            CType(
                CType(
                    CType(
                        CType(CType(target.InjectFrom(source), TTarget).InjectFrom (Of NullablesToNormal)(source),
                              TTarget).InjectFrom (Of NormalToNullables)(source),
                        TTarget).InjectFrom (Of IntToEnum)(source),
                    TTarget).InjectFrom (Of EnumToInt)(source),
                TTarget).InjectFrom (Of MapperInjection)(source)
            Return target
        End Function
    End Class
End Namespace