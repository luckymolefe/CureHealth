<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class AdminLogin
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtAdminEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtAdminEmail = New System.Windows.Forms.TextBox()
        Me.txtAdminPassword = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.notifyAlert = New System.Windows.Forms.Panel()
        Me.lblAlertMsg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.notifyAlert.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(14, 53)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Username:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.PasswordLabel.Location = New System.Drawing.Point(17, 114)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAdminEmail
        '
        Me.txtAdminEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtAdminEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtAdminEmail.Location = New System.Drawing.Point(17, 79)
        Me.txtAdminEmail.Name = "txtAdminEmail"
        Me.txtAdminEmail.Size = New System.Drawing.Size(299, 29)
        Me.txtAdminEmail.TabIndex = 1
        '
        'txtAdminPassword
        '
        Me.txtAdminPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdminPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtAdminPassword.Location = New System.Drawing.Point(17, 140)
        Me.txtAdminPassword.Name = "txtAdminPassword"
        Me.txtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAdminPassword.Size = New System.Drawing.Size(299, 29)
        Me.txtAdminPassword.TabIndex = 2
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Image = CType(resources.GetObject("loginBtn.Image"), System.Drawing.Image)
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn.Location = New System.Drawing.Point(117, 192)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(95, 30)
        Me.loginBtn.TabIndex = 3
        Me.loginBtn.Text = "&Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.MistyRose
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.cancelBtn.Image = CType(resources.GetObject("cancelBtn.Image"), System.Drawing.Image)
        Me.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cancelBtn.Location = New System.Drawing.Point(220, 192)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(95, 30)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "&Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.UsernameLabel)
        Me.Panel1.Controls.Add(Me.cancelBtn)
        Me.Panel1.Controls.Add(Me.PasswordLabel)
        Me.Panel1.Controls.Add(Me.loginBtn)
        Me.Panel1.Controls.Add(Me.txtAdminEmail)
        Me.Panel1.Controls.Add(Me.txtAdminPassword)
        Me.Panel1.Location = New System.Drawing.Point(128, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 258)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(90, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 28)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(117, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Admin Login"
        '
        'notifyAlert
        '
        Me.notifyAlert.BackColor = System.Drawing.Color.Salmon
        Me.notifyAlert.Controls.Add(Me.lblAlertMsg)
        Me.notifyAlert.ForeColor = System.Drawing.Color.Red
        Me.notifyAlert.Location = New System.Drawing.Point(145, 342)
        Me.notifyAlert.Name = "notifyAlert"
        Me.notifyAlert.Size = New System.Drawing.Size(299, 51)
        Me.notifyAlert.TabIndex = 7
        Me.notifyAlert.Visible = False
        '
        'lblAlertMsg
        '
        Me.lblAlertMsg.AutoSize = True
        Me.lblAlertMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertMsg.Image = CType(resources.GetObject("lblAlertMsg.Image"), System.Drawing.Image)
        Me.lblAlertMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlertMsg.Location = New System.Drawing.Point(61, 16)
        Me.lblAlertMsg.Name = "lblAlertMsg"
        Me.lblAlertMsg.Size = New System.Drawing.Size(201, 20)
        Me.lblAlertMsg.TabIndex = 8
        Me.lblAlertMsg.Text = "    Invalid Login Credentials!"
        '
        'AdminLogin
        '
        Me.AcceptButton = Me.loginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.cancelBtn
        Me.ClientSize = New System.Drawing.Size(580, 429)
        Me.Controls.Add(Me.notifyAlert)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.notifyAlert.ResumeLayout(False)
        Me.notifyAlert.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents notifyAlert As System.Windows.Forms.Panel
    Friend WithEvents lblAlertMsg As System.Windows.Forms.Label

End Class
