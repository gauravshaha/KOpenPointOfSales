Imports K.Common.R2.Identity.Entities
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports K.Common.R2.Identity.Repositories

Namespace UnitTest
    <TestClass()>
    Public Class ConfigBaseTest
        <TestMethod()>
        Public Sub TestGetAll()
            Using _repo = New ConfigBaseRepository()
                _repo.Initialize("K.Common.R2")
                Dim _result = _repo.ExecuteAll(Of ConfigBase)()
                Assert.AreEqual(58, _result.Count())
            End Using
        End Sub
    End Class
End Namespace