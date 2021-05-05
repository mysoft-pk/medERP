<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWinUName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConfPw = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserid = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmdNewUser = New System.Windows.Forms.Button()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsAdmin.Location = New System.Drawing.Point(129, 185)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(115, 20)
        Me.chkIsAdmin.TabIndex = 8
        Me.chkIsAdmin.Text = "Admin Account"
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 9081
        Me.Label6.Text = "Window's Login"
        '
        'txtWinUName
        '
        Me.txtWinUName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinUName.Location = New System.Drawing.Point(129, 136)
        Me.txtWinUName.MaxLength = 50
        Me.txtWinUName.Name = "txtWinUName"
        Me.txtWinUName.Size = New System.Drawing.Size(197, 22)
        Me.txtWinUName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 9080
        Me.Label5.Text = "Computer Name"
        '
        'txtCompName
        '
        Me.txtCompName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompName.Location = New System.Drawing.Point(129, 110)
        Me.txtCompName.MaxLength = 50
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(197, 22)
        Me.txtCompName.TabIndex = 5
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInactive.Location = New System.Drawing.Point(129, 162)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(143, 20)
        Me.chkInactive.TabIndex = 7
        Me.chkInactive.Text = "Account is Disabled"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 9079
        Me.Label4.Text = "Re-type Password"
        '
        'txtConfPw
        '
        Me.txtConfPw.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPw.Location = New System.Drawing.Point(129, 84)
        Me.txtConfPw.MaxLength = 50
        Me.txtConfPw.Name = "txtConfPw"
        Me.txtConfPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfPw.Size = New System.Drawing.Size(197, 22)
        Me.txtConfPw.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 9076
        Me.Label3.Text = "Password"
        '
        'txtPw
        '
        Me.txtPw.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPw.Location = New System.Drawing.Point(129, 58)
        Me.txtPw.MaxLength = 50
        Me.txtPw.Name = "txtPw"
        Me.txtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw.Size = New System.Drawing.Size(197, 22)
        Me.txtPw.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 9072
        Me.Label2.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(129, 32)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(197, 22)
        Me.txtUserName.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(238, 206)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 25)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 9068
        Me.Label1.Text = "User ID"
        '
        'txtUserid
        '
        Me.txtUserid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserid.Location = New System.Drawing.Point(129, 6)
        Me.txtUserid.MaxLength = 50
        Me.txtUserid.Name = "txtUserid"
        Me.txtUserid.Size = New System.Drawing.Size(139, 22)
        Me.txtUserid.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(15, 206)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 25)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cmdNewUser
        '
        Me.cmdNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNewUser.Image = Global.medERP.My.Resources.Resources.document24
        Me.cmdNewUser.Location = New System.Drawing.Point(302, 6)
        Me.cmdNewUser.Name = "cmdNewUser"
        Me.cmdNewUser.Size = New System.Drawing.Size(24, 21)
        Me.cmdNewUser.TabIndex = 9083
        Me.cmdNewUser.TabStop = False
        Me.cmdNewUser.UseVisualStyleBackColor = True
        '
        'btnFindUser
        '
        Me.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindUser.Image = Global.medERP.My.Resources.Resources.binoculars24
        Me.btnFindUser.Location = New System.Drawing.Point(274, 6)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(24, 21)
        Me.btnFindUser.TabIndex = 9082
        Me.btnFindUser.TabStop = False
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 239)
        Me.Controls.Add(Me.chkIsAdmin)
        Me.Controls.Add(Me.cmdNewUser)
        Me.Controls.Add(Me.btnFindUser)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtWinUName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.chkInactive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConfPw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserid)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkIsAdmin As CheckBox
    Friend WithEvents cmdNewUser As Button
    Friend WithEvents btnFindUser As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtWinUName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCompName As TextBox
    Friend WithEvents chkInactive As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConfPw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPw As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserid As TextBox
    Friend WithEvents btnAdd As Button
End Class
