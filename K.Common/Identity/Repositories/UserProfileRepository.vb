Imports K.Common.R2.Identity.Entities
Imports K.Common.R2.Data

Namespace Identity.Repositories

    Public Class UserProfileRepository
        Inherits BaseRepository
        Implements IDataManager

        Friend Sub Dispose() Implements IDisposable.Dispose
        End Sub

        Friend Sub Save(Of T)(ByVal businessModel As T) Implements IDataManager.Save
            Throw New NotImplementedException()
        End Sub

        Friend Sub Update(Of T)(ByVal businessModel As T) Implements IDataManager.Update
            Throw New NotImplementedException()
        End Sub

        Friend Sub Delete(ByVal id As Guid) Implements IDataManager.Delete
            Throw New NotImplementedException()
        End Sub

        Friend Function ExecuteAll(Of T)() As IEnumerable(Of T) Implements IDataManager.ExecuteAll
            Using _transaction = Session.BeginTransaction()
                Try
                    Dim _config_bases = Session.QueryOver(Of UserProfile)().List()
                    _transaction.Commit()
                    Return TryCast(_config_bases, IEnumerable(Of T))
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
    End Class
End Namespace