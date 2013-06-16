Namespace AutoMapper

    Public NotInheritable Class Creator
        Private Sub New()
        End Sub
        Public Shared Function Create(type As Type) As Object
            If type.IsEnumerable() Then
                Return Activator.CreateInstance(GetType(List(Of )).MakeGenericType(type.GetGenericArguments()(0)))
            End If

            If type.IsInterface Then
                Throw New Exception("don't know any implementation of this type: " + type.Name)
            End If

            Return Activator.CreateInstance(type)
        End Function
    End Class
End Namespace