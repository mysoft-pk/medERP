<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompany
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.imgPic = New System.Windows.Forms.PictureBox()
        Me.btnBrowseImg = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNTN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSTN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCmpPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCmpAddress = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCmpName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPHCRegNo = New System.Windows.Forms.TextBox()
        CType(Me.imgPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'imgPic
        '
        Me.imgPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgPic.Location = New System.Drawing.Point(339, 4)
        Me.imgPic.Name = "imgPic"
        Me.imgPic.Size = New System.Drawing.Size(140, 146)
        Me.imgPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPic.TabIndex = 9216
        Me.imgPic.TabStop = False
        '
        'btnBrowseImg
        '
        Me.btnBrowseImg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseImg.Location = New System.Drawing.Point(339, 151)
        Me.btnBrowseImg.Name = "btnBrowseImg"
        Me.btnBrowseImg.Size = New System.Drawing.Size(140, 23)
        Me.btnBrowseImg.TabIndex = 9207
        Me.btnBrowseImg.Text = "Browse Image"
        Me.btnBrowseImg.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 9215
        Me.Label6.Text = "NTN"
        '
        'txtNTN
        '
        Me.txtNTN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNTN.Location = New System.Drawing.Point(123, 136)
        Me.txtNTN.MaxLength = 250
        Me.txtNTN.Name = "txtNTN"
        Me.txtNTN.Size = New System.Drawing.Size(197, 22)
        Me.txtNTN.TabIndex = 9206
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 9214
        Me.Label5.Text = "STN"
        '
        'txtSTN
        '
        Me.txtSTN.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTN.Location = New System.Drawing.Point(123, 110)
        Me.txtSTN.MaxLength = 250
        Me.txtSTN.Name = "txtSTN"
        Me.txtSTN.Size = New System.Drawing.Size(197, 22)
        Me.txtSTN.TabIndex = 9205
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 9213
        Me.Label4.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsite.Location = New System.Drawing.Point(123, 84)
        Me.txtWebsite.MaxLength = 250
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(197, 22)
        Me.txtWebsite.TabIndex = 9204
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 9212
        Me.Label3.Text = "Phone No."
        '
        'txtCmpPhone
        '
        Me.txtCmpPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmpPhone.Location = New System.Drawing.Point(123, 58)
        Me.txtCmpPhone.MaxLength = 250
        Me.txtCmpPhone.Name = "txtCmpPhone"
        Me.txtCmpPhone.Size = New System.Drawing.Size(197, 22)
        Me.txtCmpPhone.TabIndex = 9203
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 9211
        Me.Label2.Text = "Address"
        '
        'txtCmpAddress
        '
        Me.txtCmpAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmpAddress.Location = New System.Drawing.Point(123, 32)
        Me.txtCmpAddress.MaxLength = 250
        Me.txtCmpAddress.Name = "txtCmpAddress"
        Me.txtCmpAddress.Size = New System.Drawing.Size(197, 22)
        Me.txtCmpAddress.TabIndex = 9202
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(231, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 25)
        Me.btnClose.TabIndex = 9209
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 9210
        Me.Label1.Text = "Company Name"
        '
        'txtCmpName
        '
        Me.txtCmpName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCmpName.Location = New System.Drawing.Point(123, 6)
        Me.txtCmpName.MaxLength = 250
        Me.txtCmpName.Name = "txtCmpName"
        Me.txtCmpName.Size = New System.Drawing.Size(197, 22)
        Me.txtCmpName.TabIndex = 9201
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(15, 196)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 9208
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 9218
        Me.Label7.Text = "PHC Reg. No."
        '
        'txtPHCRegNo
        '
        Me.txtPHCRegNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHCRegNo.Location = New System.Drawing.Point(123, 164)
        Me.txtPHCRegNo.MaxLength = 250
        Me.txtPHCRegNo.Name = "txtPHCRegNo"
        Me.txtPHCRegNo.Size = New System.Drawing.Size(197, 22)
        Me.txtPHCRegNo.TabIndex = 9217
        '
        'frmCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 231)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPHCRegNo)
        Me.Controls.Add(Me.imgPic)
        Me.Controls.Add(Me.btnBrowseImg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNTN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSTN)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCmpPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCmpAddress)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCmpName)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Setup"
        CType(Me.imgPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents imgPic As PictureBox
    Friend WithEvents btnBrowseImg As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNTN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSTN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCmpPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCmpAddress As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCmpName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPHCRegNo As TextBox
End Class
