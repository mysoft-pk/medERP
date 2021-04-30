Imports System.Data.SqlClient
Public Class SqlHelper
    Private cn As SqlConnection

    Public Sub New(ByVal connectionString As String)
        cn = New SqlConnection(connectionString)
    End Sub

    Public ReadOnly Property IsConnection As Boolean
        Get
            If cn.State = System.Data.ConnectionState.Closed Then cn.Open()
            Return True
        End Get
    End Property
End Class
