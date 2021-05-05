Imports System.Configuration
Imports System.Data.SqlClient

Class Company
    Private Shared myConn As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString
    Public Property CompanyName As String
    Public Property CompanyAddress As String
    Public Property CompanyPhone As String
    Public Property Website As String
    Public Property STN As String
    Public Property NTN As String
    Public Property PHCRegNo As String

    Private Const SelectQuery As String = "Select * from CMSETUP"
    Private Const InsertQuery As String = "Insert into CMSETUP (CompanyName,CompanyAddress,CompanyPhone,Website,STN,NTN,AuditDate,AuditTime,AuditUser,AuditComputer,AuditWinUser,PHCRegNo) Values (@CompanyName,@CompanyAddress,@CompanyPhone,@Website,@STN,@NTN,CONVERT(char(8), GetDate(),112),GetDate(),@AuditUser,@AuditComputer,@AuditWinUser,@PHCRegNo)"
    Private Const UpdateQuery As String = "UPDATE CMSETUP set CompanyName=@CompanyName,CompanyAddress=@CompanyAddress,CompanyPhone=@CompanyPhone,Website=@Website,STN=@STN,NTN=@NTN,AuditDate=CONVERT(char(8), GetDate(),112),AuditTime=GetDate(),AuditUser=@AuditUser,AuditComputer=@AuditComputer,AuditWinUser=@AuditWinUser,PHCRegNo=@PHCRegNo"

    Public Function GetCompany() As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(SelectQuery, con)

                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function InsertCompany(ByVal compnay As Company) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(InsertQuery, con)
                com.Parameters.AddWithValue("@CompanyName", compnay.CompanyName)
                com.Parameters.AddWithValue("@CompanyAddress", compnay.CompanyAddress)
                com.Parameters.AddWithValue("@CompanyPhone", compnay.CompanyPhone)
                com.Parameters.AddWithValue("@Website", compnay.Website)
                com.Parameters.AddWithValue("@STN", compnay.STN)
                com.Parameters.AddWithValue("@NTN", compnay.NTN)
                com.Parameters.AddWithValue("@PHCRegNo", compnay.PHCRegNo)
                com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)
                com.Parameters.AddWithValue("@AuditWinUser", Environment.UserName)

                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function UpdateCompany(ByVal compnay As Company) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(UpdateQuery, con)
                com.Parameters.AddWithValue("@CompanyName", compnay.CompanyName)
                com.Parameters.AddWithValue("@CompanyAddress", compnay.CompanyAddress)
                com.Parameters.AddWithValue("@CompanyPhone", compnay.CompanyPhone)
                com.Parameters.AddWithValue("@Website", compnay.Website)
                com.Parameters.AddWithValue("@STN", compnay.STN)
                com.Parameters.AddWithValue("@NTN", compnay.NTN)
                com.Parameters.AddWithValue("@PHCRegNo", compnay.PHCRegNo)
                com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)
                com.Parameters.AddWithValue("@AuditWinUser", Environment.UserName)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

End Class
