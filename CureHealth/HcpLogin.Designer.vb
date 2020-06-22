<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HcpLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HcpLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hcpCloseBtn = New System.Windows.Forms.Button()
        Me.txtHcpPassword = New System.Windows.Forms.TextBox()
        Me.txtHcpEmail = New System.Windows.Forms.TextBox()
        Me.hcpLoginBtn = New System.Windows.Forms.Button()
        Me.notifyAlert = New System.Windows.Forms.Panel()
        Me.alertMsg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.notifyAlert.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.hcpCloseBtn)
        Me.Panel1.Controls.Add(Me.txtHcpPassword)
        Me.Panel1.Controls.Add(Me.txtHcpEmail)
        Me.Panel1.Controls.Add(Me.hcpLoginBtn)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(117, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 242)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(77, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 28)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(104, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctor Login"
        '
        'hcpCloseBtn
        '
        Me.hcpCloseBtn.BackColor = System.Drawing.Color.MistyRose
        Me.hcpCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hcpCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hcpCloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hcpCloseBtn.ForeColor = System.Drawing.Color.DarkRed
        Me.hcpCloseBtn.Image = CType(resources.GetObject("hcpCloseBtn.Image"), System.Drawing.Image)
        Me.hcpCloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hcpCloseBtn.Location = New System.Drawing.Point(204, 184)
        Me.hcpCloseBtn.Name = "hcpCloseBtn"
        Me.hcpCloseBtn.Size = New System.Drawing.Size(95, 30)
        Me.hcpCloseBtn.TabIndex = 4
        Me.hcpCloseBtn.Text = "&Cancel"
        Me.hcpCloseBtn.UseVisualStyleBackColor = False
        '
        'txtHcpPassword
        '
        Me.txtHcpPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHcpPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtHcpPassword.Location = New System.Drawing.Point(17, 131)
        Me.txtHcpPassword.Name = "txtHcpPassword"
        Me.txtHcpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtHcpPassword.Size = New System.Drawing.Size(282, 29)
        Me.txtHcpPassword.TabIndex = 3
        '
        'txtHcpEmail
        '
        Me.txtHcpEmail.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHcpEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtHcpEmail.Location = New System.Drawing.Point(17, 70)
        Me.txtHcpEmail.Name = "txtHcpEmail"
        Me.txtHcpEmail.Size = New System.Drawing.Size(282, 29)
        Me.txtHcpEmail.TabIndex = 2
        '
        'hcpLoginBtn
        '
        Me.hcpLoginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.hcpLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.hcpLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hcpLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hcpLoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hcpLoginBtn.ForeColor = System.Drawing.Color.White
        Me.hcpLoginBtn.Image = CType(resources.GetObject("hcpLoginBtn.Image"), System.Drawing.Image)
        Me.hcpLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hcpLoginBtn.Location = New System.Drawing.Point(101, 184)
        Me.hcpLoginBtn.Name = "hcpLoginBtn"
        Me.hcpLoginBtn.Size = New System.Drawing.Size(95, 30)
        Me.hcpLoginBtn.TabIndex = 1
        Me.hcpLoginBtn.Text = "&Login"
        Me.hcpLoginBtn.UseVisualStyleBackColor = False
        '
        'notifyAlert
        '
        Me.notifyAlert.BackColor = System.Drawing.Color.Salmon
        Me.notifyAlert.Controls.Add(Me.alertMsg)
        Me.notifyAlert.ForeColor = System.Drawing.Color.Red
        Me.notifyAlert.Location = New System.Drawing.Point(134, 329)
        Me.notifyAlert.Name = "notifyAlert"
        Me.notifyAlert.Size = New System.Drawing.Size(282, 51)
        Me.notifyAlert.TabIndex = 1
        Me.notifyAlert.Visible = False
        '
        'alertMsg
        '
        Me.alertMsg.AutoSize = True
        Me.alertMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alertMsg.Image = CType(resources.GetObject("alertMsg.Image"), System.Drawing.Image)
        Me.alertMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alertMsg.Location = New System.Drawing.Point(56, 18)
        Me.alertMsg.Name = "alertMsg"
        Me.alertMsg.Size = New System.Drawing.Size(188, 20)
        Me.alertMsg.TabIndex = 2
        Me.alertMsg.Text = "    Invalid login credentials"
        Me.alertMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HcpLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(580, 429)
        Me.Controls.Add(Me.notifyAlert)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HcpLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hcp Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.notifyAlert.ResumeLayout(False)
        Me.notifyAlert.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHcpEmail As System.Windows.Forms.TextBox
    Friend WithEvents hcpLoginBtn As System.Windows.Forms.Button
    Friend WithEvents txtHcpPassword As System.Windows.Forms.TextBox
    Friend WithEvents hcpCloseBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents notifyAlert As System.Windows.Forms.Panel
    Friend WithEvents alertMsg As System.Windows.Forms.Label

End Class
