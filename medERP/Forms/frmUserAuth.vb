Public Class frmUserAuth
    Dim oldUserText As String
    Dim xUser As New User
    Dim dtUser As DataTable
    Dim xSuccess As Boolean = False
    Private Sub Finduser()
        xUser.UserID = txtUserIDA.Text
        dtUser = xUser.GetLogin(xUser)
        If dtUser.Rows.Count > 0 Then
            lblUserNameA.Text = dtUser.Rows(0)("UserName")
            RefreshDetail()
        Else
            lblUserNameA.Text = ""
        End If
    End Sub
    Private Sub RefreshDetail()
        Dim dt As New DataTable, i As Integer, grdRow As DataGridViewRow
        dt = xUser.GetObjectList
        If dt.Rows.Count = 0 Then Exit Sub
        dgvDetail.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgvDetail.Rows.Add()
            grdRow = dgvDetail.Rows(dgvDetail.Rows.Count - 2)
            grdRow.Cells(0).Value = dt.Rows(i).Item(0)
            grdRow.Cells(1).Value = dt.Rows(i).Item(1)
            grdRow.Cells(2).Value = dt.Rows(i).Item(2)
            If xUser.HasRights(dt.Rows(i).Item(0), txtUserIDA.Text) = True Then
                grdRow.Cells(3).Value = True
            Else
                grdRow.Cells(3).Value = False
            End If
        Next
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        If lblUserNameA.Text = "" Then
            MsgBox("Please select a Valid User ID.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtUserIDA.Focus()
            Exit Sub
        End If
        Try
            If dgvDetail.Rows.Count > 0 Then
                xUser.UserID = txtUserIDA.Text
                xUser.DeleteUserAuth(xUser)
            End If
            For i = 0 To dgvDetail.Rows.Count - 2
                xUser.InsertAuthorization(txtUserIDA.Text, dgvDetail.Rows(i).Cells("ObjectID").Value, IIf(dgvDetail.Rows(i).Cells("Allowed").FormattedValue = True, 1, 0))
            Next
            MsgBox("The security rights saved successfully.", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Dispose()
    End Sub

    Private Sub FrmCSUserAuth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Dim bln As Boolean
        '    ctlTab.TabPages.Remove(tpUser)
        '    ctlTab.TabPages.Remove(tpAuth)
        '    bln = BlSec.IsAdmin(My.Application.Userid)
        '    If bln = False Then
        '        ctlTab.TabPages.Remove(tpUser)
        '        ctlTab.TabPages.Remove(tpAuth)
        '    Else
        '        ctlTab.TabPages.Insert(0, tpUser)
        '        ctlTab.TabPages.Insert(1, tpAuth)
        '    End If
        ctlTab.SelectedIndex = 1
    End Sub
    Private Sub btnFindUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindUser.Click
        Dim xFinder As New Common.Finder, dtRet As New DataTable
        Try
            With xFinder
                .Caption = "User Finder"
                .ConnectionString = My.Application.ConnectionStringFinder
                .SQL = "SELECT TOP 100 UserID,UserName from USERS"
                .Filter = ""
                .Finder()
                dtRet = .ReturnDataTable
                If dtRet.Rows.Count = 1 Then
                    txtUserIDA.Text = dtRet.Rows(0)("UserID")
                    lblUserNameA.Text = dtRet.Rows(0)("UserName")
                Else
                    txtUserIDA.Text = ""
                    lblUserNameA.Text = ""
                End If
                RefreshDetail()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtUserIDA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserIDA.GotFocus
        oldUserText = txtUserIDA.Text
    End Sub

    Private Sub txtUserIDA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserIDA.Validated
        If oldUserText <> txtUserIDA.Text Then
            Finduser()
        End If
    End Sub

    Private Sub cmdOKPW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOKPW.Click
        'Step-1 Verify the user name and password alread entered
        Try
            If txtUserIDPW.Text = "" Then
                MsgBox("Please Enter Valid User ID.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtUserIDPW.Focus()
                Exit Sub
            End If

            xUser.UserID = txtUserIDPW.Text
            dtUser = xUser.GetLogin(xUser)

            If dtUser.Rows.Count = 0 Then
                MsgBox("User ID does not Exists. Please Eneter a Valid User ID.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtUserIDPW.Focus()
                Exit Sub
            End If

            If dtUser.Rows(0)("Password") <> txtOldPasswordPW.Text Then
                MsgBox("Invalid Password. Please Enter Correct Password.", MsgBoxStyle.Critical, "medERP")
                Exit Sub
            End If

            'Step -2 Update the password after confirming the data
            If txtNewPasswordPW.Text = "" Then
                MsgBox("The New Password Can't be blank.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtNewPasswordPW.Focus()
                Exit Sub
            End If

            If txtConfirmPasswordPW.Text <> txtNewPasswordPW.Text Then
                MsgBox("The New Password does not match with the Confirm Password", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtConfirmPasswordPW.Focus()
                Exit Sub
            End If
            xUser.UserID = txtUserIDPW.Text
            xUser.Password = txtNewPasswordPW.Text

            Dim xSuccess As Boolean = False

            xSuccess = xUser.UpdatePassword(xUser)
            If xSuccess = True Then
                MsgBox("Password Changed successfully.", MsgBoxStyle.Exclamation, "medERP")
            Else
                MsgBox("There is So Error, Unabale to change Password.", MsgBoxStyle.Critical, "medERP")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUser.Click
        If txtUserIDC.Text = "ADMIN" Then
            MsgBox("Changes in ADMIN User are not Allowed.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txtUserIDC.Text = "" Then
            MsgBox("Please Enter User ID.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtUserIDC.Focus()
            Exit Sub
        End If
        If txtUserNameC.Text = "" Then
            MsgBox("Please Enter User Name.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtUserNameC.Focus()
            Exit Sub
        End If
        If txtPasswordC.Text = "" Then
            MsgBox("Please Enter Password.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtPasswordC.Focus()
            Exit Sub
        End If
        xUser.UserID = txtUserIDC.Text
        dtUser = xUser.GetLogin(xUser)
        If dtUser.Rows.Count > 0 Then
            MsgBox("User Already Exists in Database.", vbCritical, "medERP")
            txtUserIDC.Focus()
            Exit Sub
        End If
        Try
            With xUser
                .UserID = (txtUserIDC.Text)
                .UserName = txtUserNameC.Text
                .Password = txtPasswordC.Text
                .Inactive = 0
                .ComputerName = ""
                .WindowsUserID = ""
                .IsAdmin = 0
            End With
            xSuccess = xUser.InsertUser(xUser)
            If xSuccess = True Then
                MsgBox("User Created Successfully.", MsgBoxStyle.Information, "medERP")
            Else
                MsgBox("There is Some Problem in Creating User.", MsgBoxStyle.Critical, "medERP")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdMoveRights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMoveRights.Click
        If UCase(Trim(txtFromUser.Text)) = "ADMIN" Or UCase(Trim(txtFromUser.Text)) = "FAISAL" Or UCase(Trim(txtFromUser.Text)) = "USMAN" Then
            MsgBox("you can't move rights of this user.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If UCase(Trim(txtFromUser.Text)) = "" Or UCase(Trim(txtToUser.Text)) = "" Then
            MsgBox("Blank Users are not Allowed.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If UCase(Trim(txtToUser.Text)) = "ADMIN" Or UCase(Trim(txtToUser.Text)) = "FAISAL" Or UCase(Trim(txtToUser.Text)) = "USMAN" Then
            MsgBox("You can't create this user.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If
        If UCase(Trim(txtFromUser.Text)) = UCase(Trim(txtToUser.Text)) Then
            MsgBox("Both user are same please correct it ", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If txtFromUser.Text = "" Or lblFromUser.Text = "" Then
            MsgBox(UCase(txtFromUser.Text) & " user don't exist please check it.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If txtToUser.Text = "" Or lblToUser.Text = "" Then
            MsgBox(UCase(txtToUser.Text) & " user don't exist please check it.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        PB.Value = 0
        xUser.MoveAuthorization(UCase(txtFromUser.Text), UCase(txtToUser.Text))
        PB.Value = 75

        xUser.UserID = UCase(txtToUser.Text)
        xUser.UserName = UCase(txtToUser.Text)
        xUser.Password = "123"
        xUser.Inactive = 0
        xUser.ComputerName = ""
        xUser.WindowsUserID = ""
        xUser.IsAdmin = 0

        xUser.UpdateUser(xUser)

        PB.Value = 100
        MsgBox("user update with -- " & UCase(txtToUser.Text))

        txtFromUser.Text = ""
        txtToUser.Text = ""
        PB.Value = 0

    End Sub
    Private Function FindUserInfo(ByVal UserID As String) As String
        xUser.UserID = txtUserIDA.Text
        dtUser = xUser.GetLogin(xUser)
        If dtUser.Rows.Count > 0 Then
            Return dtUser.Rows(0)("UserName")
        Else
            Return ""
        End If
    End Function

    Private Sub txtFromUser_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFromUser.Validated
        lblFromUser.Text = FindUserInfo(txtFromUser.Text)
    End Sub
    Private Sub txtToUser_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtToUser.Validated
        lblToUser.Text = FindUserInfo(txtToUser.Text)
    End Sub

    Private Sub cmdCopyRights_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopyRights.Click
        If UCase(Trim(txtFromUser.Text)) = "USMAN" Then
            MsgBox("you can't copy this user.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If
        If UCase(Trim(txtToUser.Text)) = "ADMIN" Then
            MsgBox("you can't create this user.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If UCase(Trim(txtToUser.Text)) = "FAISAL" Then
            MsgBox("you can't create this user.", MsgBoxStyle.Critical, "medERP")
            Exit Sub
        End If

        If UCase(Trim(txtFromUser.Text)) = "" Or UCase(Trim(txtToUser.Text)) = "" Then
            MsgBox("Blank user not allowed.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If UCase(Trim(txtFromUser.Text)) = UCase(Trim(txtToUser.Text)) Then
            MsgBox("Both user are same please correct it.", MsgBoxStyle.Critical)
            Exit Sub
        End If


        If txtFromUser.Text = "" Or lblFromUser.Text = "" Then
            MsgBox(UCase(txtFromUser.Text) & " user don't exist please check it.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If txtToUser.Text = "" Or lblToUser.Text = "" Then
            MsgBox(UCase(txtToUser.Text) & " user don't exist please check it.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        PB.Value = 0

        PB.Value = 10

        xUser.UserID = UCase(txtToUser.Text)
        xUser.DeleteUserAuth(xUser)
        PB.Value = 20

        xUser.UserID = UCase(txtFromUser.Text)
        dtUser = xUser.GetUserAuth(xUser)

        Dim i As Integer
        If dtUser.Rows.Count > 0 Then
            For i = 0 To dtUser.Rows.Count - 1
                xUser.InsertAuthorization(UCase(txtToUser.Text), dtUser.Rows(i).Item("ListID"), IIf(dtUser.Rows(i).Item("Rights") = True, 1, 0))
            Next
        End If
        PB.Value = 100
        MsgBox("User Rights Updated with User. " & UCase(txtToUser.Text))
        txtFromUser.Text = ""
        txtToUser.Text = ""
        PB.Value = 0
        Exit Sub
cmdChange_Click_Error:
        MsgBox(Err.Description)

    End Sub
    Private Sub txtUserIDA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserIDA.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnFindUser_Click(Me, e)
        End If
    End Sub

    Private Sub cmdSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelectAll.Click
        Dim i As Integer, grdRow As DataGridViewRow
        For i = 0 To dgvDetail.RowCount - 2
            grdRow = dgvDetail.Rows(i)
            If cmdSelectAll.Text = "Select All" Then
                grdRow.Cells(3).Value = True
            Else
                grdRow.Cells(3).Value = False
            End If
        Next
        If cmdSelectAll.Text = "Select All" Then
            cmdSelectAll.Text = "Un Select All"
        Else
            cmdSelectAll.Text = "Select All"
        End If
    End Sub
End Class