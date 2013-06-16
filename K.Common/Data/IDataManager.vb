Namespace Data
    Public Interface IDataManager
        Inherits IDisposable
        Function Save(Of T)(businessModel As T) As Integer
        Function Update(Of T)(businessModel As T) As Integer
        Function Delete(id As Integer) As Integer
        Function ExecuteAll(Of T)() As IEnumerable(Of T)
        Function ExecuteByWhereTerm(Of T)(ParamArray parameter As IListParameter()) As IEnumerable(Of T)
        Function ExecuteSingleRecord(Of T)(ParamArray parameter As IListParameter()) As T
        Function ExecuteByWhereTerm(Of T)(start As Integer, limit As Integer, sort As String, dir As String, totalCount As Integer, ParamArray parameter As IListParameter()) As IEnumerable(Of T)
    End Interface
End Namespace