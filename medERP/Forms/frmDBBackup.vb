Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmDBBackup
    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtFilePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        If txtFilePath.Text = "" Then
            MsgBox("Please Select a Folder for Database Backup.", vbCritical, "medERP")
            Exit Sub
        End If
        Dim xFileName As String = ""
        xFileName = "medERP" & Format(Date.Now, "yyyyMMddHHMMSS") & ".bak"
        Try
            Dim SqlconString As String = ConfigurationManager.ConnectionStrings("SQLConStr").ConnectionString

            Using sqlCon As SqlConnection = New SqlConnection(SqlconString)
                sqlCon.Open()
                Dim cmd As SqlCommand = New SqlCommand("spBackUp", sqlCon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Path", SqlDbType.NVarChar).Value = txtFilePath.Text & "\"
                cmd.Parameters.AddWithValue("@bkDB", SqlDbType.NVarChar).Value = xFileName
                cmd.ExecuteNonQuery()
                sqlCon.Close()
            End Using
            MsgBox("Database Backup Successfull." & vbCrLf & "File Name : " & xFileName, vbInformation, "medERP")
        Catch ex As Exception
            MsgBox(Err.Description, vbCritical, "medERP")
        End Try
    End Sub
End Class