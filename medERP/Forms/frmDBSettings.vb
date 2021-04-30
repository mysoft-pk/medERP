Imports System.Configuration
Imports System.Data.SqlClient

Public Class frmDBSettings
    Private Sub frmDBSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        cboServer.Items.Add(".")
        cboServer.Items.Add("(local)")
        cboServer.Items.Add(".\SQLEXPRESS")
        cboServer.Items.Add(String.Format("{0}\SQLEXPRESS", Environment.MachineName))
        cboServer.SelectedIndex = 3

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString
        If connectionString <> "" Then
            Dim builder As SqlConnectionStringBuilder = New SqlConnectionStringBuilder(connectionString)
            cboServer.Items.Add(builder.DataSource.ToString)
            cboServer.SelectedIndex = 4
            txtDatabase.Text = builder.InitialCatalog.ToString
            txtUsername.Text = builder.UserID.ToString
            txtPassword.Text = builder.Password.ToString
            txtAdminPassword.Text = ""
        End If
    End Sub

    Private Sub txtAdminPassword_TextChanged(sender As Object, e As EventArgs) Handles txtAdminPassword.TextChanged
        If txtAdminPassword.Text = "M@nidagr8" Then
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim connectionString As String = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text)

        Try
            Dim helper As SqlHelper = New SqlHelper(connectionString)

            If helper.IsConnection Then
                Dim setting As AppSetting = New AppSetting()
                setting.SaveConnectionString("SQLConStr", connectionString)
                My.Application.ConnectionString = connectionString
                My.Application.ConnectionStringFinder = "Provider=SQLOLEDB;" & connectionString
                MessageBox.Show("Your connection string has been successfully saved.", "Message ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim connectionString As String = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cboServer.Text, txtDatabase.Text, txtUsername.Text, txtPassword.Text)

        Try
            Dim helper As SqlHelper = New SqlHelper(connectionString)
            If helper.IsConnection Then MessageBox.Show("Test connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub
End Class