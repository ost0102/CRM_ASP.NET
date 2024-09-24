Imports Microsoft.VisualBasic
Imports System.Data
Imports YJIT.Data
Imports YJIT.Biz.Common
Namespace YJIT.Biz

    Public Class EVBSendStatis
        'Search
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
    End Class
End Namespace