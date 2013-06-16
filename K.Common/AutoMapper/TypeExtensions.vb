Imports System.Runtime.CompilerServices

Namespace AutoMapper
    <Extension> _
    Module TypeExtensionsModule
        <Extension> _
        Public Function IsEnumerable(type As Type) As Boolean
            If type.IsGenericType Then
                If type.GetGenericTypeDefinition().GetInterfaces().Contains(GetType(IEnumerable)) Then
                    Return True
                End If
            End If
            Return False
        End Function
    End Module
End Namespace