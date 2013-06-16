Namespace AutoMapper
    Public Interface ITypeMapper(Of TSource, TTarget)
        Function Map(source As TSource, target As TTarget) As TTarget
    End Interface
End Namespace