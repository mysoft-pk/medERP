Public Class frmMain
    Dim dtMenus As DataTable
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GetCompanyInformation()
            'GetCCInformation()
            lblCompany.Text = My.Application.CompanyName
            lblUser.Text = "Logged on User : " & My.Application.UserName & "(" & Format(My.Application.SDate, "dd/MM/yyyy hh:mm:ss tt") & ")"
            'If blsec.AppVersion() <> My.Application.Info.Version.ToString Then
            '    MsgBox("Software version is out of date." & vbCrLf & "Please contact system administrator for installation.", MsgBoxStyle.Critical)
            '    End
            'End If
            Dim xUser As New User
            dtMenus = xUser.GetUserMenu()
            tvTreeView.Nodes.RemoveByKey("Main")
            PopulateTreeView("0", Nothing)
            tvTreeView.ExpandAll()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub PopulateTreeView(ByVal parentId As String, ByVal parentNode As TreeNode)

        Dim childNode As TreeNode

        For Each dr As DataRow In dtMenus.[Select]("[parent]='" & parentId & "'")
            Dim t As TreeNode = New TreeNode()
            t.Text = IIf(dr("MenuDesc").ToString() = "Main", My.Application.CompanyName, dr("MenuDesc").ToString())
            t.Name = dr("MenuID").ToString()
            t.Tag = dtMenus.Rows.IndexOf(dr)
            t.ImageKey = dr("Icon").ToString()
            t.SelectedImageKey = dr("Icon").ToString()

            If parentNode Is Nothing Then
                tvTreeView.Nodes.Add(t)
                childNode = t
            Else
                parentNode.Nodes.Add(t)
                childNode = t
            End If

            PopulateTreeView(dr("MenuID").ToString(), childNode)
        Next
    End Sub
    Private Sub frmMain_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frmSplash.Dispose()
        frmLogin.Dispose()
        Me.Dispose(True)
    End Sub

    Private Sub GetCompanyInformation()
        Dim xCompany As New Company
        Dim dtCompany As DataTable

        dtCompany = xCompany.GetCompany()

        If dtCompany.Rows.Count > 0 Then
            My.Application.CompanyName = dtCompany.Rows(0)("CompanyName")
            My.Application.CompanyAddress = dtCompany.Rows(0)("CompanyAddress")
            My.Application.CompanyPhone = dtCompany.Rows(0)("CompanyPhone")
        Else
            My.Application.CompanyName = "N/A"
            My.Application.CompanyAddress = "N/A"
            My.Application.CompanyPhone = "N/A"
            MsgBox("Please Configure Company Details.", vbInformation, "medERP")
        End If
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Set Tile Bar Width Same as FrmMain
        picTitles.Width = Me.Width - picLogo.Width - 25

        'Set TreeView Position
        tvTreeView.Height = Me.Height - picTitles.Height - 50
        tvTreeView.Width = picLogo.Width

        'Set Picture Above the ListView
        picListView.Width = Me.Width - tvTreeView.Width - 25
        picListView.Height = tvTreeView.Height

        'Set the Listview Dimensions
        lvListView.Left = picListView.Left + 15
        lvListView.Width = picListView.Width - 30
        lvListView.Height = picListView.Height - 200
    End Sub

    Private Sub tvTreeView_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tvTreeView.AfterSelect
        Dim _selectedNode As TreeNode = Nothing
        _selectedNode = tvTreeView.SelectedNode
        lvListView.Items.Clear()
        lblMenu.Text = e.Node.FullPath

        If _selectedNode.Nodes.Count = 0 Then
            FillList(_selectedNode.Name)
        End If
    End Sub

    Private Sub FillList(ByVal ParentID As String)
        Dim strKey As String
        Dim strDesc As String
        Dim dtListObjects As DataTable = New DataTable()
        lvListView.Items.Clear()

        Dim xUser As New User
        dtListObjects = xUser.GetFillList(My.Application.Userid, ParentID)

        For Each dr As DataRow In dtListObjects.[Select]("[parent]='" & ParentID & "'")
            strKey = dr("MenuID").ToString()
            strDesc = dr("MenuDesc").ToString()
            Dim lv As ListViewItem = New ListViewItem(strDesc, 0)
            lv.Name = strKey
            lv.SubItems.Add(strKey)
            lv.ImageKey = dr("Icon").ToString()
            lvListView.Items.Add(lv)
        Next
    End Sub

    Private Sub lvListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvListView.DoubleClick
        If lvListView.Items.Count > 0 Then
            If lvListView.SelectedIndices.Count > 0 Then
                OpenForm(lvListView.SelectedItems(0).SubItems(0).Name.ToString())
            End If
        End If
    End Sub

    Private Sub lvListView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvListView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If lvListView.Items.Count > 0 Then
                If lvListView.SelectedIndices.Count > 0 Then
                    OpenForm(lvListView.SelectedItems(0).SubItems(0).Name.ToString())
                End If
            End If
        End If
    End Sub

    Private Sub lvListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvListView.SelectedIndexChanged
        'If lvListView.Items.Count > 0 Then

        '    If lvListView.SelectedIndices.Count > 0 Then
        '        OpenForm(lvListView.SelectedItems(0).SubItems(0).Name.ToString())
        '    End If
        'End If
    End Sub

    Public Shared Sub OpenForm(ByVal FormName As String)
        Dim bFormNameOpen As Boolean = False
        Dim fc As FormCollection = Application.OpenForms

        For Each frm As Form In fc

            If frm.Name = FormName Then
                bFormNameOpen = True
            End If
        Next

        If Not bFormNameOpen Then

            Try
                Dim xFound As Boolean = False
                Dim asm = System.Reflection.Assembly.GetExecutingAssembly

                Dim myTypes As Type() = asm.GetTypes()
                Dim frm As Form

                For Each t As Type In myTypes
                    If t.IsSubclassOf(GetType(System.Windows.Forms.Form)) AndAlso FormName = t.Name Then
                        xFound = True
                        frm = CType(Activator.CreateInstance(t), Form)
                        frm.Show()
                    End If
                Next

                If xFound = False Then
                    MessageBox.Show(FormName & " Form Not Found.", "medERP", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End If

                'Dim form = TryCast(Activator.CreateInstance(Type.[GetType](FormName)).Unwrap(), Form)
                'If form IsNot Nothing Then form.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
                'If ex.HResult = -2146233079 Then
                '    MessageBox.Show(FormName & " Form Not Found.", "myERP", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                'End If
            End Try
        End If
    End Sub

    Private Function FormByName(ByVal strFormName As String) As Form
        Return System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(ProductName & "." & strFormName)
    End Function


End Class