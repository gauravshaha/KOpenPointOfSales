Namespace AutoMapper

    Public NotInheritable Class Mapper
        Private Sub New()
        End Sub
        'map source to an existing target
        Public Shared Function Map(Of TSource, TTarget)(source As TSource, target As TTarget) As TTarget
            target = MapperFactory.GetMapper(Of TSource, TTarget)().Map(source, target)
            Return target
        End Function

        'create a new target and map source on it 
        Public Shared Function Map(Of TSource, TTarget)(source As TSource) As TTarget
            Dim _target = DirectCast(Creator.Create(GetType(TTarget)), TTarget)
            Return MapperFactory.GetMapper(Of TSource, TTarget)().Map(source, _target)
        End Function

        Public Shared Function Map(source As Object, target As Object, sourceType As Type, targetType As Type) As Object
            target = If(target, Creator.Create(targetType))
            Dim _get_mapper = GetType(MapperFactory).GetMethod("GetMapper").MakeGenericMethod(sourceType, targetType)
            Dim _mapper = _get_mapper.Invoke(Nothing, Nothing)
            Dim _map_1 = _mapper.[GetType]().GetMethod("Map")
            Return _map_1.Invoke(_mapper, New Object() {source, target})
        End Function
    End Class
End Namespace