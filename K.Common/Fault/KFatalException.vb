Imports System.Text
Imports System.Reflection

Namespace Fault
    <Serializable()> Public Class KFatalException(Of T As {Class})
        Inherits Exception
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

        Public Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

        Public Sub New(message As String, model As T)
            MyBase.New(message)
            BusinessModel = model
        End Sub

        Public Sub New(message As String, model As T, innerException As Exception)
            MyBase.New(message, innerException)
            BusinessModel = model
        End Sub

        Public Overrides ReadOnly Property StackTrace() As String
            Get
                Dim _result = New StringBuilder()
                If BusinessModel IsNot Nothing Then
                    For Each _property As PropertyInfo In BusinessModel.GetType().GetProperties()
                        _result.AppendLine(vbTab + _property.Name + ": " + _property.GetValue(BusinessModel, Nothing).ToString())
                    Next
                End If
                Return _result.ToString() + MyBase.StackTrace
            End Get
        End Property

        Public Property BusinessModel() As T

    End Class
End Namespace