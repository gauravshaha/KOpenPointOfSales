

Namespace Fault

    Public Class KWarnException(Of T As {Class})
        Inherits Exception
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub


    End Class
End Namespace