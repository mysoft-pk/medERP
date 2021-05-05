Imports System.Configuration
Imports System.Data.SqlClient

Class PharmacyLocation
    Private Shared myConn As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString
    Public Property BranchID As Integer
    Public Property BranchName As String
    Public Property BranchAddress As String
    Public Property BranchPhone As String
    Public Property PHCRegNo As String
    Public Property Inactive As Integer
    Public Property AllowPurchase As Integer

    Private Const SelectQuery As String = "Select * from PHBranches"
    Private Const SelectOneQuery As String = "Select * from PHBranches Where BranchID = @BranchID"
    Private Const InsertQuery As String = "INSERT INTO PHBranches (BranchID,BranchName,BranchAddress,BranchPhone,BranchPHCRegNo,BranchInactive,AuditDate,AuditTime,AuditUser,AuditComputer,AuditWinUser,AllowPurchase) Values (@BranchID,@BranchName,@BranchAddress,@BranchPhone,@BranchPHCRegNo,@BranchInactive,CONVERT(char(8), GetDate(),112),GETDATE(),@AuditUser,@AuditComputer,@AuditWinUser,@AllowPurchase)"
    Private Const UpdateQuery As String = "BranchName=@BranchName,BranchAddress=@BranchAddress,BranchPhone=@BranchPhone,BranchPHCRegNo=@BranchPHCRegNo,BranchInactive=@BranchInactive,AuditDate=CONVERT(char(8), GetDate(),112),AuditTime=GetDate(),AuditUser=@AuditUser,AuditComputer=@AuditComputer,AuditWinUser=@AuditWinUser,AllowPurchase=@AllowPurchase Where BranchID = @BranchID"
    Private Const NewIDQuery As String = "Select ISNULL(MAX(BranchID),0)+1 As BranchID from PHBranches"

    Public Function GetBranchList() As DataTable
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

    Public Function GetBranch(ByVal Location As PharmacyLocation) As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(SelectOneQuery, con)
                com.Parameters.AddWithValue("@BranchID", Location.BranchID)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function GetNewBranchID() As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(NewIDQuery, con)

                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function


    Public Function InsertBranch(ByVal Location As PharmacyLocation) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(InsertQuery, con)
                com.Parameters.AddWithValue("@BranchID", Location.BranchID)
                com.Parameters.AddWithValue("@BranchName", Location.BranchName)
                com.Parameters.AddWithValue("@BranchAddress", Location.BranchAddress)
                com.Parameters.AddWithValue("@BranchPhone", Location.BranchPhone)
                com.Parameters.AddWithValue("@BranchPHCRegNo", Location.PHCRegNo)
                com.Parameters.AddWithValue("@BranchInactive", Location.Inactive)
                com.Parameters.AddWithValue("@AllowPurchase", Location.AllowPurchase)
                com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)
                com.Parameters.AddWithValue("@AuditWinUser", Environment.UserName)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function UpdateBranch(ByVal Location As PharmacyLocation) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(UpdateQuery, con)
                com.Parameters.AddWithValue("@BranchID", Location.BranchID)
                com.Parameters.AddWithValue("@BranchName", Location.BranchName)
                com.Parameters.AddWithValue("@BranchAddress", Location.BranchAddress)
                com.Parameters.AddWithValue("@BranchPhone", Location.BranchPhone)
                com.Parameters.AddWithValue("@BranchPHCRegNo", Location.PHCRegNo)
                com.Parameters.AddWithValue("@BranchInactive", Location.Inactive)
                com.Parameters.AddWithValue("@AllowPurchase", Location.AllowPurchase)
                com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)
                com.Parameters.AddWithValue("@AuditWinUser", Environment.UserName)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

End Class
