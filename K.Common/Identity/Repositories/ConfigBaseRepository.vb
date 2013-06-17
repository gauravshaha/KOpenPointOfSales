Imports K.Common.R2.Fault
Imports K.Common.R2.Identity.Entities
Imports K.Common.R2.Data

Namespace Identity.Repositories
    Class ConfigBaseRepository
        Inherits BaseRepository
        Implements IDataManager

        Sub New()
            TableName = "ConfigBase"
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose

        End Sub

        Public Sub Save(Of T)(ByVal businessModel As T) Implements IDataManager.Save
            If Not TypeOf businessModel Is ConfigBase Then
                Throw New KFatalException(Of ConfigBase)(FaultValue.REPO_FAULT_MODEL)
            End If
            Session.Save(TableName, businessModel)
        End Sub

        Public Sub Update(Of T)(ByVal businessModel As T) Implements IDataManager.Update
            If Not TypeOf businessModel Is ConfigBase Then
                Throw New KFatalException(Of ConfigBase)(FaultValue.REPO_FAULT_MODEL)
            End If
            Session.Update(TableName, businessModel)
        End Sub

        Public Sub Delete(ByVal id As Guid) Implements IDataManager.Delete
            Dim _query = Session.QueryOver(Of ConfigBase).Where(Function(x) x.Id = id).Select(Function(a) a).SingleOrDefault()
            If _query Is Nothing Then
                Throw New KWarnException(Of ConfigBase)(FaultValue.REPO_FAULT_NO_RECORD)
            End If
            Session.Delete(_query)
        End Sub

        Public Function ExecuteAll(Of T)() As IEnumerable(Of T) Implements IDataManager.ExecuteAll
            Dim _config_bases = Session.QueryOver(Of ConfigBase)().List()
            Return TryCast(_config_bases, IEnumerable(Of T))
        End Function

        Public Function ExecuteByWhereTerm(Of T)(ByVal ParamArray parameter As IListParameter()) As IEnumerable(Of T) Implements IDataManager.ExecuteByWhereTerm
            Throw New NotImplementedException()
        End Function

        Public Function ExecuteSingleRecord(Of T)(ByVal ParamArray parameter As IListParameter()) As T Implements IDataManager.ExecuteSingleRecord
            Throw New NotImplementedException()
        End Function

        Public Function ExecuteByWhereTerm(Of T)(ByVal start As Integer, ByVal limit As Integer, ByVal sort As String, ByVal dir As String, ByVal totalCount As Integer, ByVal ParamArray parameter As IListParameter()) As IEnumerable(Of T) Implements IDataManager.ExecuteByWhereTerm
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace