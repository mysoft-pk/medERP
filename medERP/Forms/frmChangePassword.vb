Public Class frmChangePassword

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Step-1 Verify the user name and password alread entered
        Try
            If txtUserName.Text = "" Then
                MsgBox("Please Enter Valid User ID.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtUserName.Focus()
                Exit Sub
            End If

            Dim xUser As New User
            Dim dtUser As DataTable

            xUser.UserID = txtUserName.Text
            dtUser = xUser.GetLogin(xUser)

            If dtUser.Rows.Count = 0 Then
                MsgBox("User ID does not Exists. Please Eneter a Valid User ID.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtUserName.Focus()
                Exit Sub
            End If

            If dtUser.Rows(0)("Password") <> txtPassword.Text Then
                MsgBox("Invalid Password. Please Enter Correct Password.", MsgBoxStyle.Critical, "medERP")
                Exit Sub
            End If

            'Step -2 Update the password after confirming the data
            If txtNewPw.Text = "" Then
                MsgBox("The New Password Can't be blank.", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtNewPw.Focus()
                Exit Sub
            End If

            If txtConfirmPW.Text <> txtNewPw.Text Then
                MsgBox("The New Password does not match with the Confirm Password", MsgBoxStyle.Critical, "medERP")
                My.Application.DoEvents()
                txtConfirmPW.Focus()
                Exit Sub
            End If
            xUser.UserID = txtUserName.Text
            xUser.Password = txtNewPw.Text

            Dim xSuccess As Boolean = False

            xSuccess = xUser.UpdatePassword(xUser)
            If xSuccess = True Then
                MsgBox("Password Changed successfully.", MsgBoxStyle.Exclamation, "medERP")
            Else
                MsgBox("There is So Error, Unabale to change Password.", MsgBoxStyle.Critical, "medERP")
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Dispose()
    End Sub

    Private Sub frmChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.L And e.Modifiers = Keys.Control) Then
            OK_Click(Me, e)
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt) Then
            Cancel_Click(Me, e)
        End If
    End Sub

    Private Sub frmChangePassword_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If txtUserName.Text <> "" Then
            txtPassword.Focus()
        End If
    End Sub
End Class