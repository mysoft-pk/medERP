Imports System.Configuration
Imports System.Data.SqlClient

Class User
    Private Shared myConn As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString
    Public Property UserID As String
    Public Property UserName As String
    Public Property Password As String
    Public Property Inactive As Integer
    Public Property ComputerName As String
    Public Property WindowsUserID As String
    Public Property IsAdmin As Integer

    Private Const SelectQuery As String = "Select * from Users"
    Private Const InsertQuery As String = "INSERT INTO Users(UserID,UserName,[Password],inactive,ComputerName,WinUserID,IsAdmin) Values (@UserID,@UserName,@Password,@inactive,@ComputerName,@WinUserID,@IsAdmin)"
    Private Const UpdateQuery As String = "UPDATE Users set UserName=@UserName,[Password]=@Password,inactive=@inactive,ComputerName=@ComputerName,WinUserID=@WinUserID,IsAdmin = @IsAdmin where UserID=@UserID"
    Private Const DeleteQuery As String = "Delete from Users where UserID=@UserID"
    Private Const LoginQuery As String = "Select * from Users Where UserID = @UserID"
    Private Const MenuQuery As String = "Select * From Menu Where Type <> 'List' Order By SortID"
    Private Const ChangePasswordQuery As String = "Update Users Set [Password] = @Password Where UserID = @UserID"
    Private Const ListQuery As String = "Update Users Set [Password] = @Password Where UserID = @UserID"
    Private Const ObjectListQuery As String = "SELECT MENU.MENUID,CASE WHEN LEFT(MENU.PARENT,2)='PH' THEN 'Pharmecy->' WHEN LEFT(MENU.PARENT,2)='AD' THEN '' WHEN LEFT(MENU.PARENT,2)='Ri' THEN '' ELSE '' END + MENU1.MENUDESC AS GROUPDESC,MENU.MENUDESC FROM MENU LEFT OUTER JOIN MENU AS MENU1 ON MENU.PARENT = MENU1.MENUID WHERE MENU.TYPE in ('LIST','Edit') ORDER BY MENU.LEVELNO,MENU.SORTID"
    Private Const DeleteAuthQuery As String = "Delete from USERAUTH where UserID=@UserID"
    Private Const InsertAuthQuery As String = "INSERT INTO UserAuth(UserID,ListID,Rights,AuditDate,AuditUser,AuditComputer) VALUES(@UserID,@ListID,@Rights,GetDate(),@AuditUser,@AuditComputer)"
    Private Const AuthUserUpdateQuery As String = "Update UserAuth set userid = @ToUserID where userid = @FromUserID"
    Private Const GetUserAuthQuery As String = "Select * From UserAuth Where UserID = @UserID"
    Private Const FillListQuery As String = "Select Menu.* From Menu inner join userauth on userauth.listid = menu.menuid Where menu.Type = 'List' and userauth.userid = @UserID and userauth.rights=1 and menu.Parent = @ParentID Order By SortID"

    Public Function GetUsers() As DataTable
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

    Public Function GetUserMenu() As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(MenuQuery, con)

                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function GetObjectList() As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(ObjectListQuery, con)

                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function GetLogin(user As User) As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(LoginQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function


    Public Function GetUserAuth(user As User) As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(GetUserAuthQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function GetFillList(ByVal xUserID As String, ByVal xParentID As String) As DataTable
        Dim datatable = New DataTable()

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(FillListQuery, con)
                com.Parameters.AddWithValue("@UserID", xUserID)
                com.Parameters.AddWithValue("@ParentID", xParentID)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using

        Return datatable
    End Function

    Public Function InsertUser(ByVal user As User) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(InsertQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                com.Parameters.AddWithValue("@UserName", user.UserName)
                com.Parameters.AddWithValue("@Password", user.Password)
                com.Parameters.AddWithValue("@inactive", user.Inactive)
                com.Parameters.AddWithValue("@ComputerName", user.ComputerName)
                com.Parameters.AddWithValue("@WinUserID", user.WindowsUserID)
                com.Parameters.AddWithValue("@IsAdmin", user.IsAdmin)

                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function UpdateUser(ByVal user As User) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(UpdateQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                com.Parameters.AddWithValue("@UserName", user.UserName)
                com.Parameters.AddWithValue("@Password", user.Password)
                com.Parameters.AddWithValue("@inactive", user.Inactive)
                com.Parameters.AddWithValue("@ComputerName", user.ComputerName)
                com.Parameters.AddWithValue("@WinUserID", user.WindowsUserID)
                com.Parameters.AddWithValue("@IsAdmin", user.IsAdmin)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function


    Public Function UpdatePassword(ByVal user As User) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(ChangePasswordQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                com.Parameters.AddWithValue("@Password", user.Password)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function DeleteUser(ByVal user As User) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(DeleteQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function DeleteUserAuth(ByVal user As User) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(DeleteAuthQuery, con)
                com.Parameters.AddWithValue("@UserID", user.UserID)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function


    Public Function HasRights(ByVal xObjectID As String, ByVal xUserID As String) As Boolean
        Dim datatable = New DataTable()
        Dim rows As Integer = 0

        If UserID = "ADMIN" Then
            Return True
            Exit Function
        End If

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand("Select * from UserAuth Where LISTID=@ObjectID And UserID=@UserID", con)
                com.Parameters.AddWithValue("@UserID", xUserID)
                com.Parameters.AddWithValue("@ObjectID", xObjectID)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(com)
                    adapter.Fill(datatable)
                End Using
            End Using
        End Using
        If datatable.Rows.Count = 0 Then
            Using con As SqlConnection = New SqlConnection(myConn)
                con.Open()

                Using com As SqlCommand = New SqlCommand("INSERT INTO USERAUTH VALUES(@UserID,@ObjectID,0,GetDate(),@AuditUser,@AuditComputer)", con)
                    com.Parameters.AddWithValue("@UserID", xUserID)
                    com.Parameters.AddWithValue("@ObjectID", xObjectID)
                    com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                    com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)
                    rows = com.ExecuteNonQuery()
                End Using
            End Using
            Return False
        Else
            Return datatable.Rows(0)("Rights")
        End If
    End Function

    Public Function InsertAuthorization(ByVal xUser As String, ByVal xObjectID As String, ByVal xRights As Boolean) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(InsertAuthQuery, con)
                com.Parameters.AddWithValue("@UserID", xUser)
                com.Parameters.AddWithValue("@ListID", xObjectID)
                com.Parameters.AddWithValue("@Rights", xRights)
                com.Parameters.AddWithValue("@AuditUser", My.Application.Userid)
                com.Parameters.AddWithValue("@AuditComputer", Environment.MachineName)

                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

    Public Function MoveAuthorization(ByVal xFromUser As String, ByVal xToUser As String) As Boolean
        Dim rows As Integer

        Using con As SqlConnection = New SqlConnection(myConn)
            con.Open()

            Using com As SqlCommand = New SqlCommand(AuthUserUpdateQuery, con)
                com.Parameters.AddWithValue("@FromUserID", xFromUser)
                com.Parameters.AddWithValue("@ToUserID", xToUser)
                rows = com.ExecuteNonQuery()
            End Using
        End Using

        Return If((rows > 0), True, False)
    End Function

End Class
