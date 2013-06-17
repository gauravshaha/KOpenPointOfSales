Imports K.Common.R2.Identity.Entities
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports K.Common.R2.Identity.Repositories

Namespace UnitTest
    <TestClass()>
    Public Class ConfigBaseTest
        <TestMethod()>
        Public Sub SeharusnyaMendapatRecordLebihDariSatu()
            Using _repo = New ConfigBaseRepository()
                _repo.Initialize()
                Dim _result = _repo.ExecuteAll(Of ConfigBase)()
                Assert.AreEqual(True, _result.Any())
            End Using
        End Sub
    End Class
End Namespace