Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = (GetSetting(My.Application.Info.ProductName, "Login", "Userid", "ADMIN"))

        dtpSesndate.Value = Now
    End Sub

    Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        txtPassword.Focus()
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.L And e.Modifiers = Keys.Control) Then
            OK_Click(Me, e)
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt) Then
            Cancel_Click(Me, e)
        End If
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            If txtUsername.Text = "" Then
                MsgBox("Please enter valid User Name", MsgBoxStyle.Critical, "Login Failed")
                My.Application.DoEvents()
                txtUsername.Focus()
                Exit Sub
            End If

            Dim xUser As New User
            Dim dtUser As DataTable

            xUser.UserID = txtUsername.Text

            dtUser = xUser.GetLogin(xUser)

            If dtUser.Rows.Count = 0 Then
                MsgBox("User does not exist. Please Enter Correct User.", MsgBoxStyle.Critical, "Login Failed")
                My.Application.DoEvents()
                txtUsername.Focus()
                Exit Sub
            End If

            If dtUser.Rows(0)("Password") <> txtPassword.Text Then
                MsgBox("Invalid Password. Please Enter correct Password.", MsgBoxStyle.Critical, "Login Failed")
                Exit Sub
            End If
            If dtUser.Rows(0)("inactive") = 1 Then
                MsgBox("You are not allowed to Login. Your Account is Inactive." & vbCrLf & "Please Contact System Administrator.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            'If uinfo.ComputerName <> "" AndAlso uinfo.ComputerName <> My.Computer.Name Then
            '    MsgBox("You are not allowed to Login on this Computer", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If

            My.Application.Userid = txtUsername.Text
            My.Application.UserName = dtUser.Rows(0)("UserName")
            SaveSetting(My.Application.Info.ProductName, "Login", "Userid", txtUsername.Text)
            My.Application.SDate = dtpSesndate.Value
            Me.Close()
            frmMain.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub btnChangePw_Click(sender As Object, e As EventArgs) Handles btnChangePw.Click
        Dim frm As New frmChangePassword
        frm.txtUserName.Text = txtUsername.Text
        frm.ShowDialog()
    End Sub
End Class