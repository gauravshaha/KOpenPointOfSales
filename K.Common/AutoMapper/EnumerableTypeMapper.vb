

Namespace AutoMapper

    Public Class EnumerableTypeMapper(Of TSource As Class, TTarget As Class)
        Implements ITypeMapper(Of TSource, TTarget)

        Public Function Map(ByVal source As TSource, ByVal target As TTarget) As TTarget Implements ITypeMapper(Of TSource, TTarget).Map
            If source Is Nothing Then
                Return Nothing
            End If
            Dim _target_argument_type = GetType(TTarget).GetGenericArguments()(0)

            Dim _list = Activator.CreateInstance(GetType(List(Of )).MakeGenericType(_target_argument_type))
            Dim _add = _list.GetType().GetMethod("Add")

            For Each o In TryCast(source, IEnumerable)
                Dim _t = Creator.Create(_target_argument_type)
                Dim _att As Object() = {Mapper.Map(o, _t, o.GetType(), _target_argument_type)}
                _add.Invoke(_list, _att)
            Next
            Return DirectCast(_list, TTarget)
        End Function
    End Class
End Namespace