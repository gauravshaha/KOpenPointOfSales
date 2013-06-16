

Namespace AutoMapper

    Public NotInheritable Class MapperFactory
        Private Sub New()
        End Sub
        Private Shared ReadOnly Mappers As IDictionary(Of Type, Object) = New Dictionary(Of Type, Object)()

        Public Shared Function GetMapper(Of TSource, TTarget)() As ITypeMapper(Of TSource, TTarget)
            'if we have a specified TypeMapper for <TSource,Target> return it
            If Mappers.ContainsKey(GetType(ITypeMapper(Of TSource, TTarget))) Then
                Return TryCast(Mappers(GetType(ITypeMapper(Of TSource, TTarget))), ITypeMapper(Of TSource, TTarget))
            End If

            'if both Source and Target types are Enumerables return new EnumerableTypeMapper<TSource,TTarget>()
            If GetType(TSource).IsEnumerable() AndAlso GetType(TTarget).IsEnumerable() Then
                Return DirectCast(Activator.CreateInstance(GetType(EnumerableTypeMapper(Of ,)).MakeGenericType(GetType(TSource), GetType(TTarget))), ITypeMapper(Of TSource, TTarget))
            End If

            'return the default TypeMapper
            Return New TypeMapper(Of TSource, TTarget)()
        End Function

        Public Shared Sub AddMapper(Of TS, TT)(o As ITypeMapper(Of TS, TT))
            Mappers.Add(GetType(ITypeMapper(Of TS, TT)), o)
        End Sub

        Public Shared Sub ClearMappers()
            Mappers.Clear()
        End Sub
    End Class
End Namespace