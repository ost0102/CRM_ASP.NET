﻿Imports System.Data

Namespace YJIT.BIZ
    Public Class SvrUsedStatisList
        Public Shared Function Search(ByVal ds As DataSet) As Dictionary(Of String, Object)
            Return YJQuery.Search(ds)
        End Function
    End Class
End Namespace
