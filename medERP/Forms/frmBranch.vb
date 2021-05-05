Imports System.ComponentModel

Public Class frmBranch
    Dim xLocation As New PharmacyLocation
    Dim dtLocation As DataTable
    Dim xSuccess As Boolean = False
    Private Sub frmBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearAll()

    End Sub

    Private Sub ClearAll()
        txtBranchID.Text = ""
        txtBranchName.Text = ""
        txtBranchAddress.Text = ""
        txtBranchPhone.Text = ""
        txtPHCRegNo.Text = ""
        chkInactive.Checked = False
        chkPurchase.Checked = False
        btnAdd.Text = "&Add"
        dtLocation = xLocation.GetNewBranchID()
        txtBranchID.Text = dtLocation.Rows(0)(0)
    End Sub

    Private Sub frmBranch_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        My.Application.DoEvents()
        txtBranchName.Focus()
    End Sub

    Private Sub cmdNewLoc_Click(sender As Object, e As EventArgs) Handles cmdNewLoc.Click
        ClearAll()
        My.Application.DoEvents()
        txtBranchName.Focus()
    End Sub
    Private Sub txtBranchID_Validating(sender As Object, e As CancelEventArgs) Handles txtBranchID.Validating
        If txtBranchID.Text <> "" Then
            xLocation.BranchID = txtBranchID.Text
            dtLocation = xLocation.GetBranch(xLocation)
            If dtLocation.Rows.Count = 0 Then
                ClearAll()
            Else
                txtBranchName.Text = dtLocation.Rows(0)("BranchName")
                txtBranchAddress.Text = dtLocation.Rows(0)("BranchAddress")
                txtBranchPhone.Text = dtLocation.Rows(0)("BranchPhone")
                txtPHCRegNo.Text = dtLocation.Rows(0)("BranchPHCRegNo")
                chkInactive.Text = IIf(dtLocation.Rows(0)("BranchInactive") = 1, True, False)
                chkPurchase.Text = IIf(dtLocation.Rows(0)("AllowPurchase") = 1, True, False)
                btnAdd.Text = "&Save"
            End If
            My.Application.DoEvents()
            txtBranchName.Focus()
        End If
    End Sub

    Private Sub btnFindLoc_Click(sender As Object, e As EventArgs) Handles btnFindLoc.Click
        Dim Finder As New Common.Finder
        Dim dtRet As New DataTable
        With Finder
            .Caption = "Pharmacy Branch Finder"
            .ConnectionString = My.Application.ConnectionStringFinder
            .SQL = "SELECT BranchID,BranchName,BranchAddress,BranchPhone from PHBranches"
            .Finder()
            dtRet = .ReturnDataTable
            If dtRet.Rows.Count = 1 Then
                txtBranchID.Text = dtRet.Rows(0)("BranchID")
                txtBranchID_Validating(Me, e)
            Else
                ClearAll()
                My.Application.DoEvents()
                txtBranchName.Focus()
            End If
        End With
    End Sub

    Private Sub frmBranch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S And e.Modifiers = Keys.Control) Then
            If btnAdd.Enabled Then
                btnAdd_Click(Me, e)
            End If
        ElseIf (e.KeyCode = Keys.N And e.Modifiers = Keys.Control) Then
            If btnAdd.Enabled Then
                btnFindLoc_Click(Me, e)
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt) Then
            btnClose_Click(Me, e)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtBranchID.Text = "" Then
            MsgBox("Please Enter Branch ID.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtBranchID.Focus()
            Exit Sub
        End If
        If txtBranchName.Text = "" Then
            MsgBox("Please Enter Branch Name.", MsgBoxStyle.Critical, "medERP")
            My.Application.DoEvents()
            txtBranchName.Focus()
            Exit Sub
        End If
        Try
            With xLocation
                .BranchID = txtBranchID.Text
                .BranchName = txtBranchName.Text
                .BranchAddress = txtBranchAddress.Text
                .BranchPhone = txtBranchPhone.Text
                .PHCRegNo = txtPHCRegNo.Text
                .Inactive = IIf(chkInactive.Checked, 1, 0)
                .AllowPurchase = IIf(chkPurchase.Checked, 1, 0)
            End With
            If btnAdd.Text = "&Add" Then
                xSuccess = xLocation.InsertBranch(xLocation)
                If xSuccess = True Then
                    MsgBox("Branch Created Successfully.", MsgBoxStyle.Information, "medERP")
                    ClearAll()
                Else
                    MsgBox("There is Some Problem in Creating Branch.", MsgBoxStyle.Critical, "medERP")
                End If
            Else
                xSuccess = xLocation.UpdateBranch(xLocation)
                If xSuccess = True Then
                    MsgBox("Branch Updated Successfully.", MsgBoxStyle.Information, "medERP")
                    ClearAll()
                Else
                    MsgBox("There is Some Problem in Updating Branch.", MsgBoxStyle.Critical, "medERP")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class