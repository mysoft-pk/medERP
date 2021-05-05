<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBranch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBranch))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPHCRegNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBranchAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.cmdNewLoc = New System.Windows.Forms.Button()
        Me.btnFindLoc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBranchID = New System.Windows.Forms.TextBox()
        Me.chkPurchase = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 9232
        Me.Label7.Text = "PHC Reg. No."
        '
        'txtPHCRegNo
        '
        Me.txtPHCRegNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHCRegNo.Location = New System.Drawing.Point(119, 118)
        Me.txtPHCRegNo.MaxLength = 250
        Me.txtPHCRegNo.Name = "txtPHCRegNo"
        Me.txtPHCRegNo.Size = New System.Drawing.Size(197, 22)
        Me.txtPHCRegNo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 9227
        Me.Label3.Text = "Phone No."
        '
        'txtBranchPhone
        '
        Me.txtBranchPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchPhone.Location = New System.Drawing.Point(119, 90)
        Me.txtBranchPhone.MaxLength = 250
        Me.txtBranchPhone.Name = "txtBranchPhone"
        Me.txtBranchPhone.Size = New System.Drawing.Size(197, 22)
        Me.txtBranchPhone.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 9226
        Me.Label2.Text = "Address"
        '
        'txtBranchAddress
        '
        Me.txtBranchAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchAddress.Location = New System.Drawing.Point(119, 64)
        Me.txtBranchAddress.MaxLength = 250
        Me.txtBranchAddress.Name = "txtBranchAddress"
        Me.txtBranchAddress.Size = New System.Drawing.Size(197, 22)
        Me.txtBranchAddress.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 9225
        Me.Label1.Text = "Branch Name"
        '
        'txtBranchName
        '
        Me.txtBranchName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(119, 38)
        Me.txtBranchName.MaxLength = 250
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(197, 22)
        Me.txtBranchName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(8, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(227, 208)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInactive.Location = New System.Drawing.Point(119, 151)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.Size = New System.Drawing.Size(129, 20)
        Me.chkInactive.TabIndex = 5
        Me.chkInactive.Text = "Branch is Inactive"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'cmdNewLoc
        '
        Me.cmdNewLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdNewLoc.Image = CType(resources.GetObject("cmdNewLoc.Image"), System.Drawing.Image)
        Me.cmdNewLoc.Location = New System.Drawing.Point(292, 10)
        Me.cmdNewLoc.Name = "cmdNewLoc"
        Me.cmdNewLoc.Size = New System.Drawing.Size(24, 21)
        Me.cmdNewLoc.TabIndex = 9236
        Me.cmdNewLoc.TabStop = False
        Me.cmdNewLoc.UseVisualStyleBackColor = True
        '
        'btnFindLoc
        '
        Me.btnFindLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFindLoc.Image = CType(resources.GetObject("btnFindLoc.Image"), System.Drawing.Image)
        Me.btnFindLoc.Location = New System.Drawing.Point(264, 10)
        Me.btnFindLoc.Name = "btnFindLoc"
        Me.btnFindLoc.Size = New System.Drawing.Size(24, 21)
        Me.btnFindLoc.TabIndex = 9235
        Me.btnFindLoc.TabStop = False
        Me.btnFindLoc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 9234
        Me.Label4.Text = "Branch ID"
        '
        'txtBranchID
        '
        Me.txtBranchID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBranchID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchID.Location = New System.Drawing.Point(119, 10)
        Me.txtBranchID.MaxLength = 50
        Me.txtBranchID.Name = "txtBranchID"
        Me.txtBranchID.ReadOnly = True
        Me.txtBranchID.Size = New System.Drawing.Size(139, 22)
        Me.txtBranchID.TabIndex = 0
        '
        'chkPurchase
        '
        Me.chkPurchase.AutoSize = True
        Me.chkPurchase.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPurchase.Location = New System.Drawing.Point(119, 177)
        Me.chkPurchase.Name = "chkPurchase"
        Me.chkPurchase.Size = New System.Drawing.Size(204, 20)
        Me.chkPurchase.TabIndex = 9237
        Me.chkPurchase.Text = "Branch is Allowed to Purchase"
        Me.chkPurchase.UseVisualStyleBackColor = True
        '
        'frmBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 238)
        Me.Controls.Add(Me.chkPurchase)
        Me.Controls.Add(Me.cmdNewLoc)
        Me.Controls.Add(Me.btnFindLoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBranchID)
        Me.Controls.Add(Me.chkInactive)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPHCRegNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBranchPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBranchAddress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBranchName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmBranch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pharmacy Branches "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPHCRegNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBranchPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBranchAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents chkInactive As CheckBox
    Friend WithEvents cmdNewLoc As Button
    Friend WithEvents btnFindLoc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBranchID As TextBox
    Friend WithEvents chkPurchase As CheckBox
End Class
