Imports System.Configuration
Imports System.Data.SqlClient
Public NotInheritable Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Hide()
        If CheckConnectionString() = False Then
            frmDBSettings.ShowDialog()
        End If
        frmMain.Show()
    End Sub

    Private Function CheckConnectionString() As Boolean
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString
        If connectionString = "" Then
            Return False
        End If
        Dim con As SqlConnection = New SqlConnection(connectionString)
        Try
            con.Open()
            My.Application.ConnectionString = connectionString
            My.Application.ConnectionStringFinder = "Provider=SQLOLEDB;" & connectionString
            Return True
        Catch ex As Exception
            MsgBox("Error --> " & ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
