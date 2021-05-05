Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmCompany
    Dim xCompany As New Company
    Dim dtCompany As DataTable
    Dim xSuccess As Boolean = False
    Private Sub btnBrowseImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseImg.Click
        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "C:\"
        ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            imgPic.Image = Image.FromFile(ImageDialogue.FileName)
        End If
    End Sub
    Private Sub frmCompany_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S And e.Modifiers = Keys.Control) Then
            If btnAdd.Enabled Then
                btnAdd_Click(Me, e)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt) Then
            btnClose_Click(Me, e)
        End If
    End Sub

    Private Sub frmCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtCompany = xCompany.GetCompany
            If dtCompany.Rows.Count > 0 Then
                txtCmpName.Text = dtCompany.Rows(0)("CompanyName")
                txtCmpAddress.Text = dtCompany.Rows(0)("CompanyAddress")
                txtCmpPhone.Text = dtCompany.Rows(0)("CompanyPhone")
                txtWebsite.Text = dtCompany.Rows(0)("Website")
                txtSTN.Text = dtCompany.Rows(0)("NTN")
                txtNTN.Text = dtCompany.Rows(0)("STN")
                txtPHCRegNo.Text = dtCompany.Rows(0)("PHCRegNo")
                imgPic.Image = Nothing
                btnAdd.Text = "&Save"
                LoadImage()
            Else
                txtCmpName.Text = ""
                txtCmpAddress.Text = ""
                txtCmpPhone.Text = ""
                txtWebsite.Text = ""
                txtSTN.Text = ""
                txtNTN.Text = ""
                txtPHCRegNo.Text = ""
                imgPic.Image = Nothing
                btnAdd.Text = "&Add"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoadImage()
        Try
            Dim sqlconn As SqlClient.SqlConnection
            Dim conn As String = My.Application.ConnectionString
            Dim dr As SqlClient.SqlDataReader
            sqlconn = New SqlClient.SqlConnection(conn)
            Dim sqlquery As New SqlClient.SqlCommand

            'Insert the details into the database
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "SELECT * FROM CMSETUP"
            dr = sqlquery.ExecuteReader()
            If dr.HasRows = True Then
                dr.Read()
                If IsDBNull(dr("Logo")) = True Then
                    imgPic.Image = Nothing
                    Exit Sub
                End If
                Dim data As Byte() = DirectCast(dr("Logo"), Byte())
                Dim ms As New IO.MemoryStream(data)
                imgPic.Image = Image.FromStream(ms)
            End If
            sqlconn.Close()
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Sub
    Private Sub UpdatePicture()
        Try
            Dim sqlconn As SqlClient.SqlConnection
            Dim conn As String = My.Application.ConnectionString
            sqlconn = New SqlClient.SqlConnection(conn)
            Dim sqlquery As New SqlClient.SqlCommand

            Dim ms As New IO.MemoryStream()
            imgPic.Image.Save(ms, imgPic.Image.RawFormat)
            Dim data As Byte() = ms.GetBuffer()

            'Insert the details into the database
            sqlquery.Connection = sqlconn
            sqlconn.Open()

            sqlquery.CommandText = "UPDATE CMSETUP Set  Logo=@pic"
            sqlquery.Parameters.Add("@pic", SqlDbType.Image).Value = data

            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch err As Exception
            MsgBox(err.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtCmpName.Text = "" Then
            MsgBox("Please Enter Company Name.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            With xCompany
                .CompanyName = getText(txtCmpName.Text)
                .CompanyAddress = getText(txtCmpAddress.Text)
                .CompanyPhone = getText(txtCmpPhone.Text)
                .Website = getText(txtWebsite.Text)
                .NTN = txtNTN.Text
                .STN = txtSTN.Text
                .PHCRegNo = txtPHCRegNo.Text
            End With
            If btnAdd.Text = "&Add" Then
                xSuccess = xCompany.InsertCompany(xCompany)
                If xSuccess = True Then
                    MsgBox("Company Data Saved Successfully.", vbInformation, "medERP")
                    UpdatePicture()
                    btnAdd.Text = "&Save"
                Else
                    MsgBox("There is some problem in saving company data.", vbCritical, "medERP")
                    Exit Sub
                End If
            Else
                xSuccess = xCompany.UpdateCompany(xCompany)
                If xSuccess = True Then
                    MsgBox("Company Data Updated Successfully.", vbInformation, "medERP")
                    UpdatePicture()
                    btnAdd.Text = "&Save"
                Else
                    MsgBox("There is some problem in updating company data.", vbCritical, "medERP")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Function getText(ByVal xText As String) As String
        getText = xText.Replace("'", "''")
    End Function
    Private Sub ScaleImage(ByVal p As PictureBox, ByRef i As Bitmap)
        If i.Height > p.Height Then
            Dim diff As Integer = i.Height - p.Height
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
        If i.Width > p.Width Then
            Dim diff As Integer = i.Width - p.Width
            Dim Resized As Bitmap = New Bitmap(i, New Size(i.Width - diff, i.Height - diff))
            i = Resized
        End If
        p.Image = i
    End Sub

    Private Sub txtPHCRegNo_TextChanged(sender As Object, e As EventArgs) Handles txtPHCRegNo.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class