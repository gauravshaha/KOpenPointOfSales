

Imports K.OpenPos.Common.Entities
Imports K.OpenPos.Common.Interfaces
Imports K.Common.R2.Data
Imports K.OpenPos.Common.Models
Imports K.Common.R2.AutoMapper.Mapper

Namespace Repositories

    Class BranchRepository
        Inherits BaseRepository
        Implements IDataManager
        
        Friend Function Save(Of T)(ByVal businessModel As T) As Integer Implements IDataManager.Save
            Throw New NotImplementedException()
        End Function

        Friend Function Update(Of T)(ByVal businessModel As T) As Integer Implements IDataManager.Update
            Throw New NotImplementedException()
        End Function

        Friend Function Delete(ByVal id As Integer) As Integer Implements IDataManager.Delete
            Throw New NotImplementedException()
        End Function

        Friend Function ExecuteAll(Of T)() As IEnumerable(Of T) Implements IDataManager.ExecuteAll
            Using _transaction = Session.BeginTransaction()
                Try
                    Dim _branches = Session.QueryOver(Of Branch)().List()
                    _transaction.Commit()
                    Dim _branch_models = New List(Of IBranchModel)
                    For Each _branch As Branch In _branches
                        Dim _model As IBranchModel = New BranchModel()
                        Map(_branch, _model)
                        _branch_models.Add(_model)
                    Next
                    Return TryCast(_branch_models, IEnumerable(Of T))
                Catch _ex As Exception
                    _transaction.Rollback()
                    Throw New Exception("Error On ExecuteAll", _ex)
                End Try
            End Using
        End Function

        Friend Function ExecuteByWhereTerm(Of T)(ByVal ParamArray parameter As IListParameter()) As IEnumerable(Of T) Implements IDataManager.ExecuteByWhereTerm
            Throw New NotImplementedException()
        End Function

        Friend Function ExecuteSingleRecord(Of T)(ByVal ParamArray parameter As IListParameter()) As T Implements IDataManager.ExecuteSingleRecord
            Throw New NotImplementedException()
        End Function

        Friend Function ExecuteByWhereTerm(Of T)(ByVal start As Integer, ByVal limit As Integer, ByVal sort As String, ByVal dir As String, ByVal totalCount As Integer, ByVal ParamArray parameter As IListParameter()) As IEnumerable(Of T) Implements IDataManager.ExecuteByWhereTerm
            Throw New NotImplementedException()
        End Function

        Friend Sub Dispose() Implements IDisposable.Dispose

        End Sub
    End Class
End Namespace