Imports K.Common.R2.Identity.Entities
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports K.Common.R2.Identity.Repositories

Namespace UnitTest
    <TestClass()> Public Class UserProfileTest
        <TestMethod()> Public Sub ExecuteAllTest()
            Using _repo = New UserProfileRepository()
                _repo.Initialize()
                Dim _result = _repo.ExecuteAll(Of UserProfile)()
                Assert.AreEqual(62, _result.Count())
            End Using
        End Sub
    End Class
End Namespace