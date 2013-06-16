Namespace Data
    Public Interface IListParameter
        Property ParamDataType() As EnumParamterDataTypes
        Function GetValue() As Object
        Property TableName() As String
        Property ColumnName() As String
        Property [Operator]() As SqlOperator
        ReadOnly Property HasValue() As Boolean
    End Interface
End Namespace