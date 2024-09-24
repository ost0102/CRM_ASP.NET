Imports System.ServiceModel
Imports System.Data
Imports System.Collections.Generic

' NOTE: If you change the class name "IServices" here, you must also update the reference to "IServices" in Web.config.
Namespace YJIT.WCF

    '<ServiceContract(SessionMode:=SessionMode.Required)> _
    <ServiceContract()> _
    Public Interface IBizService
        <OperationContract()> _
        Function MethodCall(ByVal controllerId As String, ByVal actionId As String, ByVal dsParams As DataSet) As DataSet

        <OperationContract()> _
        Function MethodCallJson(ByVal controllerId As String, ByVal actionId As String, ByVal dsParams As DataSet) As String

        '<OperationContract()> _
        'Function MethodCallDs(ByVal controllerId As String, ByVal actionId As String, ByVal dsParams As DataSet) As DataSet


        ''NOTE: 3 code functions below can not be called from Service Call because their parameters contain dictionary type.
        ''Reason: WCF supports dictionary type directly but doesn't support an array of dictionaries (e.g: parameter = {searchParams, dataParams....})
        '<OperationContract()> _
        'Function CodeList(ByVal codeType As String, ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As DataSet
        '<OperationContract()> _
        'Function CodeSearch(ByVal codeType As String, ByVal searchParams As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object), Optional ByVal usePaging As Boolean = True, Optional ByVal targetPage As Integer = 1, Optional ByVal pageSize As Integer = 10, Optional ByVal pageSetSize As Integer = 10) As DataSet
        '<OperationContract()> _
        'Function CodeValidate(ByVal codeType As String, ByVal validateKeys As Dictionary(Of String, Object), ByVal dataParams As Dictionary(Of String, Object)) As DataSet

        '<OperationContract()> _
        'Function Login(ByVal userName As String, ByVal password As String) As DataSet

    End Interface
End Namespace