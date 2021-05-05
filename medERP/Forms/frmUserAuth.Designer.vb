<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAuth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdSelectAll = New System.Windows.Forms.Button()
        Me.ctlTab = New System.Windows.Forms.TabControl()
        Me.tpUser = New System.Windows.Forms.TabPage()
        Me.lblToUser = New System.Windows.Forms.Label()
        Me.lblFromUser = New System.Windows.Forms.Label()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.cmdCopyRights = New System.Windows.Forms.Button()
        Me.cmdMoveRights = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtToUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFromUser = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmdAddUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPasswordC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserNameC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUserIDC = New System.Windows.Forms.TextBox()
        Me.tpAuth = New System.Windows.Forms.TabPage()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.lblUserNameA = New System.Windows.Forms.Label()
        Me.txtUserIDA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDetail = New System.Windows.Forms.DataGridView()
        Me.ObjectID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObjectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allowed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tpChangePW = New System.Windows.Forms.TabPage()
        Me.cmdOKPW = New System.Windows.Forms.Button()
        Me.txtConfirmPasswordPW = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNewPasswordPW = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOldPasswordPW = New System.Windows.Forms.TextBox()
        Me.txtUserIDPW = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.ctlTab.SuspendLayout()
        Me.tpUser.SuspendLayout()
        Me.tpAuth.SuspendLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpChangePW.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSelectAll
        '
        Me.cmdSelectAll.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSelectAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectAll.Location = New System.Drawing.Point(218, 317)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Size = New System.Drawing.Size(78, 27)
        Me.cmdSelectAll.TabIndex = 1002
        Me.cmdSelectAll.Text = "Select All"
        Me.cmdSelectAll.UseVisualStyleBackColor = False
        '
        'ctlTab
        '
        Me.ctlTab.Controls.Add(Me.tpUser)
        Me.ctlTab.Controls.Add(Me.tpAuth)
        Me.ctlTab.Controls.Add(Me.tpChangePW)
        Me.ctlTab.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctlTab.Location = New System.Drawing.Point(12, 12)
        Me.ctlTab.Name = "ctlTab"
        Me.ctlTab.SelectedIndex = 0
        Me.ctlTab.Size = New System.Drawing.Size(452, 300)
        Me.ctlTab.TabIndex = 1001
        '
        'tpUser
        '
        Me.tpUser.Controls.Add(Me.lblToUser)
        Me.tpUser.Controls.Add(Me.lblFromUser)
        Me.tpUser.Controls.Add(Me.PB)
        Me.tpUser.Controls.Add(Me.cmdCopyRights)
        Me.tpUser.Controls.Add(Me.cmdMoveRights)
        Me.tpUser.Controls.Add(Me.Label6)
        Me.tpUser.Controls.Add(Me.txtToUser)
        Me.tpUser.Controls.Add(Me.Label5)
        Me.tpUser.Controls.Add(Me.txtFromUser)
        Me.tpUser.Controls.Add(Me.CheckBox1)
        Me.tpUser.Controls.Add(Me.cmdAddUser)
        Me.tpUser.Controls.Add(Me.Label3)
        Me.tpUser.Controls.Add(Me.txtPasswordC)
        Me.tpUser.Controls.Add(Me.Label2)
        Me.tpUser.Controls.Add(Me.txtUserNameC)
        Me.tpUser.Controls.Add(Me.Label4)
        Me.tpUser.Controls.Add(Me.txtUserIDC)
        Me.tpUser.Location = New System.Drawing.Point(4, 25)
        Me.tpUser.Name = "tpUser"
        Me.tpUser.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUser.Size = New System.Drawing.Size(444, 271)
        Me.tpUser.TabIndex = 0
        Me.tpUser.Text = "Users"
        Me.tpUser.UseVisualStyleBackColor = True
        '
        'lblToUser
        '
        Me.lblToUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblToUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToUser.Location = New System.Drawing.Point(193, 189)
        Me.lblToUser.Name = "lblToUser"
        Me.lblToUser.Size = New System.Drawing.Size(245, 19)
        Me.lblToUser.TabIndex = 108
        '
        'lblFromUser
        '
        Me.lblFromUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFromUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFromUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromUser.Location = New System.Drawing.Point(193, 160)
        Me.lblFromUser.Name = "lblFromUser"
        Me.lblFromUser.Size = New System.Drawing.Size(245, 19)
        Me.lblFromUser.TabIndex = 107
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(14, 227)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(249, 23)
        Me.PB.TabIndex = 106
        '
        'cmdCopyRights
        '
        Me.cmdCopyRights.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdCopyRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCopyRights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCopyRights.Location = New System.Drawing.Point(368, 227)
        Me.cmdCopyRights.Name = "cmdCopyRights"
        Me.cmdCopyRights.Size = New System.Drawing.Size(66, 25)
        Me.cmdCopyRights.TabIndex = 25
        Me.cmdCopyRights.Text = "Copy"
        Me.cmdCopyRights.UseVisualStyleBackColor = False
        '
        'cmdMoveRights
        '
        Me.cmdMoveRights.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdMoveRights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMoveRights.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMoveRights.Location = New System.Drawing.Point(273, 227)
        Me.cmdMoveRights.Name = "cmdMoveRights"
        Me.cmdMoveRights.Size = New System.Drawing.Size(66, 25)
        Me.cmdMoveRights.TabIndex = 24
        Me.cmdMoveRights.Text = "Move"
        Me.cmdMoveRights.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "To User"
        '
        'txtToUser
        '
        Me.txtToUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtToUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtToUser.Location = New System.Drawing.Point(95, 189)
        Me.txtToUser.MaxLength = 50
        Me.txtToUser.Name = "txtToUser"
        Me.txtToUser.Size = New System.Drawing.Size(92, 22)
        Me.txtToUser.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "From User"
        '
        'txtFromUser
        '
        Me.txtFromUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFromUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFromUser.Location = New System.Drawing.Point(95, 160)
        Me.txtFromUser.MaxLength = 50
        Me.txtFromUser.Name = "txtFromUser"
        Me.txtFromUser.Size = New System.Drawing.Size(92, 22)
        Me.txtFromUser.TabIndex = 22
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 138)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(316, 20)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Move/Copy the rights from one user to other user. "
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmdAddUser
        '
        Me.cmdAddUser.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdAddUser.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddUser.Location = New System.Drawing.Point(245, 98)
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.Size = New System.Drawing.Size(78, 24)
        Me.cmdAddUser.TabIndex = 11
        Me.cmdAddUser.Text = "Create User"
        Me.cmdAddUser.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'txtPasswordC
        '
        Me.txtPasswordC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordC.Location = New System.Drawing.Point(95, 70)
        Me.txtPasswordC.MaxLength = 50
        Me.txtPasswordC.Name = "txtPasswordC"
        Me.txtPasswordC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordC.Size = New System.Drawing.Size(228, 22)
        Me.txtPasswordC.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "User Name"
        '
        'txtUserNameC
        '
        Me.txtUserNameC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserNameC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserNameC.Location = New System.Drawing.Point(95, 44)
        Me.txtUserNameC.MaxLength = 50
        Me.txtUserNameC.Name = "txtUserNameC"
        Me.txtUserNameC.Size = New System.Drawing.Size(228, 22)
        Me.txtUserNameC.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "User ID"
        '
        'txtUserIDC
        '
        Me.txtUserIDC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserIDC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDC.Location = New System.Drawing.Point(95, 18)
        Me.txtUserIDC.MaxLength = 50
        Me.txtUserIDC.Name = "txtUserIDC"
        Me.txtUserIDC.Size = New System.Drawing.Size(228, 22)
        Me.txtUserIDC.TabIndex = 8
        '
        'tpAuth
        '
        Me.tpAuth.Controls.Add(Me.btnFindUser)
        Me.tpAuth.Controls.Add(Me.lblUserNameA)
        Me.tpAuth.Controls.Add(Me.txtUserIDA)
        Me.tpAuth.Controls.Add(Me.Label1)
        Me.tpAuth.Controls.Add(Me.dgvDetail)
        Me.tpAuth.Location = New System.Drawing.Point(4, 25)
        Me.tpAuth.Name = "tpAuth"
        Me.tpAuth.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAuth.Size = New System.Drawing.Size(444, 271)
        Me.tpAuth.TabIndex = 1
        Me.tpAuth.Text = "Authorization"
        Me.tpAuth.UseVisualStyleBackColor = True
        '
        'btnFindUser
        '
        Me.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindUser.Image = Global.medERP.My.Resources.Resources.binoculars24
        Me.btnFindUser.Location = New System.Drawing.Point(165, 6)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(25, 21)
        Me.btnFindUser.TabIndex = 9061
        Me.btnFindUser.TabStop = False
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'lblUserNameA
        '
        Me.lblUserNameA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUserNameA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserNameA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameA.Location = New System.Drawing.Point(193, 6)
        Me.lblUserNameA.Name = "lblUserNameA"
        Me.lblUserNameA.Size = New System.Drawing.Size(240, 19)
        Me.lblUserNameA.TabIndex = 99
        '
        'txtUserIDA
        '
        Me.txtUserIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserIDA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDA.Location = New System.Drawing.Point(43, 5)
        Me.txtUserIDA.Name = "txtUserIDA"
        Me.txtUserIDA.Size = New System.Drawing.Size(118, 22)
        Me.txtUserIDA.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "User"
        '
        'dgvDetail
        '
        Me.dgvDetail.AllowUserToDeleteRows = False
        Me.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ObjectID, Me.Group, Me.ObjectName, Me.Allowed})
        Me.dgvDetail.Location = New System.Drawing.Point(11, 35)
        Me.dgvDetail.Name = "dgvDetail"
        Me.dgvDetail.Size = New System.Drawing.Size(422, 233)
        Me.dgvDetail.TabIndex = 96
        '
        'ObjectID
        '
        Me.ObjectID.HeaderText = "ObjectID"
        Me.ObjectID.Name = "ObjectID"
        Me.ObjectID.ReadOnly = True
        Me.ObjectID.Visible = False
        '
        'Group
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Group.DefaultCellStyle = DataGridViewCellStyle7
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        Me.Group.Width = 90
        '
        'ObjectName
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ObjectName.DefaultCellStyle = DataGridViewCellStyle8
        Me.ObjectName.HeaderText = "Object Name"
        Me.ObjectName.Name = "ObjectName"
        Me.ObjectName.ReadOnly = True
        Me.ObjectName.Width = 180
        '
        'Allowed
        '
        Me.Allowed.HeaderText = "Allowed"
        Me.Allowed.Name = "Allowed"
        Me.Allowed.Width = 70
        '
        'tpChangePW
        '
        Me.tpChangePW.Controls.Add(Me.cmdOKPW)
        Me.tpChangePW.Controls.Add(Me.txtConfirmPasswordPW)
        Me.tpChangePW.Controls.Add(Me.Label9)
        Me.tpChangePW.Controls.Add(Me.txtNewPasswordPW)
        Me.tpChangePW.Controls.Add(Me.Label10)
        Me.tpChangePW.Controls.Add(Me.txtOldPasswordPW)
        Me.tpChangePW.Controls.Add(Me.txtUserIDPW)
        Me.tpChangePW.Controls.Add(Me.PasswordLabel)
        Me.tpChangePW.Controls.Add(Me.UsernameLabel)
        Me.tpChangePW.Location = New System.Drawing.Point(4, 25)
        Me.tpChangePW.Name = "tpChangePW"
        Me.tpChangePW.Size = New System.Drawing.Size(444, 271)
        Me.tpChangePW.TabIndex = 2
        Me.tpChangePW.Text = "Change Password"
        Me.tpChangePW.UseVisualStyleBackColor = True
        '
        'cmdOKPW
        '
        Me.cmdOKPW.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdOKPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOKPW.Location = New System.Drawing.Point(198, 175)
        Me.cmdOKPW.Name = "cmdOKPW"
        Me.cmdOKPW.Size = New System.Drawing.Size(129, 27)
        Me.cmdOKPW.TabIndex = 20
        Me.cmdOKPW.Text = "Change Password"
        Me.cmdOKPW.UseVisualStyleBackColor = False
        '
        'txtConfirmPasswordPW
        '
        Me.txtConfirmPasswordPW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPasswordPW.Location = New System.Drawing.Point(117, 137)
        Me.txtConfirmPasswordPW.Name = "txtConfirmPasswordPW"
        Me.txtConfirmPasswordPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPasswordPW.Size = New System.Drawing.Size(210, 22)
        Me.txtConfirmPasswordPW.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "&Confirm Password"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewPasswordPW
        '
        Me.txtNewPasswordPW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPasswordPW.Location = New System.Drawing.Point(117, 96)
        Me.txtNewPasswordPW.Name = "txtNewPasswordPW"
        Me.txtNewPasswordPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPasswordPW.Size = New System.Drawing.Size(210, 22)
        Me.txtNewPasswordPW.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(220, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "&New Password"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOldPasswordPW
        '
        Me.txtOldPasswordPW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPasswordPW.Location = New System.Drawing.Point(117, 55)
        Me.txtOldPasswordPW.Name = "txtOldPasswordPW"
        Me.txtOldPasswordPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPasswordPW.Size = New System.Drawing.Size(210, 22)
        Me.txtOldPasswordPW.TabIndex = 17
        '
        'txtUserIDPW
        '
        Me.txtUserIDPW.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserIDPW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserIDPW.Location = New System.Drawing.Point(117, 14)
        Me.txtUserIDPW.Name = "txtUserIDPW"
        Me.txtUserIDPW.Size = New System.Drawing.Size(210, 22)
        Me.txtUserIDPW.TabIndex = 16
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(21, 52)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 21
        Me.PasswordLabel.Text = "&Old Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(21, 11)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(89, 23)
        Me.UsernameLabel.TabIndex = 20
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(386, 317)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(78, 27)
        Me.cmdClose.TabIndex = 1000
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(302, 317)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 27)
        Me.cmdSave.TabIndex = 999
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'frmUserAuth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 348)
        Me.Controls.Add(Me.cmdSelectAll)
        Me.Controls.Add(Me.ctlTab)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Name = "frmUserAuth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Authrization"
        Me.ctlTab.ResumeLayout(False)
        Me.tpUser.ResumeLayout(False)
        Me.tpUser.PerformLayout()
        Me.tpAuth.ResumeLayout(False)
        Me.tpAuth.PerformLayout()
        CType(Me.dgvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpChangePW.ResumeLayout(False)
        Me.tpChangePW.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSelectAll As Button
    Friend WithEvents ctlTab As TabControl
    Friend WithEvents tpUser As TabPage
    Friend WithEvents lblToUser As Label
    Friend WithEvents lblFromUser As Label
    Friend WithEvents PB As ProgressBar
    Friend WithEvents cmdCopyRights As Button
    Friend WithEvents cmdMoveRights As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtToUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFromUser As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cmdAddUser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPasswordC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserNameC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUserIDC As TextBox
    Friend WithEvents tpAuth As TabPage
    Friend WithEvents btnFindUser As Button
    Friend WithEvents lblUserNameA As Label
    Friend WithEvents txtUserIDA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDetail As DataGridView
    Friend WithEvents tpChangePW As TabPage
    Friend WithEvents cmdOKPW As Button
    Friend WithEvents txtConfirmPasswordPW As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNewPasswordPW As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOldPasswordPW As TextBox
    Friend WithEvents txtUserIDPW As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents ObjectID As DataGridViewTextBoxColumn
    Friend WithEvents Group As DataGridViewTextBoxColumn
    Friend WithEvents ObjectName As DataGridViewTextBoxColumn
    Friend WithEvents Allowed As DataGridViewCheckBoxColumn
End Class
