Imports K.OpenPos.Common.Interfaces
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports K.OpenPos.Common.Repositories

Namespace UnitTest

    <TestClass()> Public Class BranchRepositoryTest
        'Public Sub New()
        '    Dim hibernateBase = New BranchRepository()
        '    hibernateBase.Initialize("NHibernate.GuitarStore")
        'End Sub
        <TestMethod()> Public Sub TestGetAll()
            Using _repo = New BranchRepository()
                _repo.Initialize("K.OpenPos.Common")
                Dim _result = _repo.ExecuteAll(Of IBranchModel)()
                Assert.AreEqual(20, _result.Count())
            End Using
        End Sub
    End Class
End Namespace