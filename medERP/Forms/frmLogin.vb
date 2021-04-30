Public Class frmLogin
    'Dim dtorgs As DataTable
    'Dim blsec As New Security
    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
    ''    Try
    '        If UsernameTextBox.Text = "" Then
    '            MsgBox("Please enter valid user id", MsgBoxStyle.Critical, "Login Failed")
    '            Exit Sub
    '        End If

    '        Dim uinfo As New Security.UserInfo
    '        uinfo = blsec.GetUserinfo(UsernameTextBox.Text)
    '        If uinfo.UserId = "" Then
    '            MsgBox("Username does not exist", MsgBoxStyle.Critical, "Login Failed")
    '            Exit Sub
    '        End If
    '        If uinfo.password <> PasswordTextBox.Text Then
    '            MsgBox("Invalid Username or Password", MsgBoxStyle.Critical, "Login Failed")
    '            Exit Sub
    '        End If
    '        If uinfo.inactive = "True" Then
    '            MsgBox("You are not allowed to Login. Your Account is Inactive.", MsgBoxStyle.Critical)
    '            Exit Sub
    '        End If
    '        'If uinfo.ComputerName <> "" AndAlso uinfo.ComputerName <> My.Computer.Name Then
    '        ' MsgBox("You are not allowed to Login on this Computer", MsgBoxStyle.Critical)
    '        ' Exit Sub
    '        'End If
    '        My.Application.Userid = UsernameTextBox.Text
    '        'My.Application.UserName = blsec.fcnDecrpt(uinfo.UserName)
    '        My.Application.UserName = uinfo.UserName
    '        Dim drow As DataRow()
    '        drow = dtorgs.Select("DATABASEID='" & cmborg.SelectedValue & "'")
    '        If drow.Length > 0 Then
    '            My.Application.CnString = drow(0)("Connectionstring")
    '            'My.Application.CnString = blsec.m_connectionstring
    '            My.Application.CompanyName = drow(0)("Description")
    '            My.Application.CompanyAddress = "Demo Address, Faisalabad."
    '            My.Application.CompanyPhine = "Phone No.: +92-41-1234567  Fax No.:Phone No.: +92-41-1234568  UAN:11-786-786"
    '            My.Application.ServerName = drow(0)("ServerName")
    '            My.Application.LoginID = drow(0)("UserID")
    '            My.Application.Password = drow(0)("Password")
    '            My.Application.Database = drow(0)("Database")
    '        End If
    '        'my.Application.cnstring=dtorgs.Rows(
    '        SaveSetting(My.Application.Info.ProductName, "Login", "Userid", UsernameTextBox.Text)
    '        SaveSetting(My.Application.Info.ProductName, "Login", "APPID", cmborg.SelectedValue)
    '        My.Application.LoginOrgName = cmborg.Text
    '        My.Application.SDate = dtpSesndate.Value
    '        Me.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub
    'Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
    '    End
    'End Sub

    'Private Sub btnChangePw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePw.Click
    '    Dim frm As New frmChangePw
    '    frm.UsernameTextBox.Text = UsernameTextBox.Text
    '    frm.ShowDialog()
    '    If UsernameTextBox.Text <> "" Then
    '        PasswordTextBox.Focus()
    '    End If
    'End Sub
    'Private Sub frmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    blsec = Nothing
    '    dtorgs = Nothing
    'End Sub
    'Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    Dim i As Integer, j As Integer
    '    Dim blsec As New Security
    '    'Debug.Print(blsec.fcnEncrypt("BFEBFBFF000206A7"))
    '    UsernameTextBox.Text = (GetSetting(My.Application.Info.ProductName, "Login", "Userid", "ADMIN"))
    '    dtorgs = blsec.GetOrgs '("PROJECTID='" & blsec.fcnEncrypt(My.Application.Info.ProductName) & "'")
    '    cmborg.DataSource = dtorgs
    '    For i = 0 To dtorgs.Rows.Count - 1
    '        For j = 1 To dtorgs.Columns.Count - 1
    '            If Not IsDBNull(dtorgs.Rows(i)(j)) AndAlso dtorgs.Rows(i)(j).GetType.Name = "String" Then
    '                'dtorgs.Rows(i)(j) = blsec.fcnDecrpt(dtorgs.Rows(i)(j))
    '                dtorgs.Rows(i)(j) = dtorgs.Rows(i)(j)
    '            End If
    '        Next
    '        If IsDBNull(dtorgs.Rows(i)("ProjectId")) OrElse dtorgs.Rows(i)("ProjectId") <> My.Application.Info.ProductName Then
    '            dtorgs.Rows(i).Delete()
    '        End If
    '    Next
    '    'MsgBox(dtorgs.Rows.Count)
    '    cmborg.DisplayMember = (dtorgs.Columns("Description").ColumnName)
    '    cmborg.ValueMember = (dtorgs.Columns("DATABASEID").ColumnName)

    '    cmborg.SelectedValue = GetSetting(My.Application.Info.ProductName, "Login", "APPID", "FICMASTER")
    '    dtpSesndate.Value = blsec.GetServerDate
    'End Sub

    'Private Sub frmLogin_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    PasswordTextBox.Focus()
    'End Sub
End Class