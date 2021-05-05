Public Class frmUser
    Dim xUser As New User
    Dim dtUser As DataTable
    Dim xSuccess As Boolean = False
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtUserid.Text = "" Then
            MsgBox("Please Enter User ID.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtUserid.Focus()
            Exit Sub
        End If
        If txtPw.Text = "" Then
            MsgBox("Please Enter Password.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtPw.Focus()
            Exit Sub
        End If
        If txtPw.Text <> txtConfPw.Text Then
            MsgBox("The Password fields do not Match." & vbCrLf & "Please Enter Same Password in Both Fields.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtConfPw.Focus()
            Exit Sub
        End If
        'If txtUserid.Text = "ADMIN" And Not btnAdd.Text = "&Add" Then
        '    MsgBox("Not allowed changes in admin user", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Try
            With xUser
                .UserID = (txtUserid.Text)
                .UserName = txtUserName.Text
                .Password = txtPw.Text
                .Inactive = IIf(chkInactive.Checked, 1, 0)
                .ComputerName = txtCompName.Text
                .WindowsUserID = txtWinUName.Text
                .IsAdmin = IIf(chkIsAdmin.Checked, 1, 0)
            End With
            If btnAdd.Text = "&Add" Then
                xSuccess = xUser.InsertUser(xUser)
                If xSuccess = True Then
                    MsgBox("User Created Successfully.", MsgBoxStyle.Information, "medERP")
                    ClearAll()
                Else
                    MsgBox("There is Some Problem in Creating User.", MsgBoxStyle.Critical, "medERP")
                End If
            Else
                xSuccess = xUser.UpdateUser(xUser)
                If xSuccess = True Then
                    MsgBox("User Updated Successfully.", MsgBoxStyle.Information, "medERP")
                    ClearAll()
                Else
                    MsgBox("There is Some Problem in Updating User.", MsgBoxStyle.Critical, "medERP")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtUserid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserid.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnFindUser_Click(Me, e)
        End If
    End Sub
    Private Sub txtUserid_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserid.Validated
        If txtUserid.Text <> "" Then
            Finduser()
        End If
    End Sub
    Private Sub Finduser()
        xUser.UserID = txtUserid.Text
        dtUser = xUser.GetLogin(xUser)
        If dtUser.Rows.Count > 0 Then
            txtUserName.Text = dtUser.Rows(0)("UserName")
            txtPw.Text = dtUser.Rows(0)("Password")
            txtCompName.Text = dtUser.Rows(0)("ComputerName")
            txtWinUName.Text = dtUser.Rows(0)("WinUserID")
            txtConfPw.Text = txtPw.Text
            If dtUser.Rows(0)("inactive") = 1 Then
                chkInactive.CheckState = CheckState.Checked
            Else
                chkInactive.CheckState = CheckState.Unchecked
            End If

            If dtUser.Rows(0)("IsAdmin") = 1 Then
                chkIsAdmin.CheckState = CheckState.Checked
            Else
                chkIsAdmin.CheckState = CheckState.Unchecked
            End If

            btnAdd.Text = "&Save"
        Else
            btnAdd.Text = "&Add"
        End If
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmCSUserCreation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S And e.Modifiers = Keys.Control) Then
            If btnAdd.Enabled Then
                btnAdd_Click(Me, e)
            End If
        ElseIf (e.KeyCode = Keys.N And e.Modifiers = Keys.Control) Then
            If btnAdd.Enabled Then
                cmdNewUser_Click(Me, e)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt) Then
            btnClose_Click(Me, e)
        End If
    End Sub

    Private Sub FrmCSUserCreation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearAll()
    End Sub
    Private Sub ClearAll()
        txtUserid.Text = ""
        txtUserName.Text = ""
        txtPw.Text = ""
        txtCompName.Text = ""
        txtWinUName.Text = ""
        txtConfPw.Text = ""
        chkInactive.Checked = False
        chkIsAdmin.Checked = False
        btnAdd.Text = "&Add"
        txtUserid.Focus()
    End Sub

    Private Sub cmdNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewUser.Click
        ClearAll()
    End Sub

    Private Sub btnFindUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindUser.Click
        Dim Finder As New Common.Finder
        Dim dtRet As New DataTable
        With Finder
            .Caption = "User Finder"
            .ConnectionString = My.Application.ConnectionStringFinder
            .SQL = "SELECT UserID,UserName from Users"
            .Filter = ""
            .Finder()
            dtRet = .ReturnDataTable
            If dtRet.Rows.Count = 1 Then
                txtUserid.Text = dtRet.Rows(0)("UserID")
                Finduser()
                btnAdd.Text = "&Save"
                My.Application.DoEvents()
                txtUserName.Focus()
            Else
                ClearAll()
            End If
        End With
    End Sub
End Class