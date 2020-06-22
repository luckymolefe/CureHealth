<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DoctorPanel = New System.Windows.Forms.Button()
        Me.AdminPanel = New System.Windows.Forms.Button()
        Me.PatientPanel = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(214, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Health Cure Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 34)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(70, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login as"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(298, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 205)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(99, 165)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 205)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(499, 165)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 205)
        Me.Panel5.TabIndex = 3
        '
        'DoctorPanel
        '
        Me.DoctorPanel.BackColor = System.Drawing.Color.White
        Me.DoctorPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoctorPanel.FlatAppearance.BorderSize = 0
        Me.DoctorPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue
        Me.DoctorPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.DoctorPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoctorPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.DoctorPanel.Location = New System.Drawing.Point(298, 376)
        Me.DoctorPanel.Name = "DoctorPanel"
        Me.DoctorPanel.Size = New System.Drawing.Size(176, 40)
        Me.DoctorPanel.TabIndex = 2
        Me.DoctorPanel.Text = "Doctor"
        Me.DoctorPanel.UseVisualStyleBackColor = False
        '
        'AdminPanel
        '
        Me.AdminPanel.BackColor = System.Drawing.Color.White
        Me.AdminPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AdminPanel.FlatAppearance.BorderSize = 0
        Me.AdminPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue
        Me.AdminPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.AdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.AdminPanel.Location = New System.Drawing.Point(99, 376)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(176, 40)
        Me.AdminPanel.TabIndex = 1
        Me.AdminPanel.Text = "Admin"
        Me.AdminPanel.UseVisualStyleBackColor = False
        '
        'PatientPanel
        '
        Me.PatientPanel.BackColor = System.Drawing.Color.White
        Me.PatientPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PatientPanel.Enabled = False
        Me.PatientPanel.FlatAppearance.BorderSize = 0
        Me.PatientPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatientPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientPanel.ForeColor = System.Drawing.Color.LightGray
        Me.PatientPanel.Location = New System.Drawing.Point(499, 376)
        Me.PatientPanel.Name = "PatientPanel"
        Me.PatientPanel.Size = New System.Drawing.Size(176, 40)
        Me.PatientPanel.TabIndex = 3
        Me.PatientPanel.Text = "Guest"
        Me.PatientPanel.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(625, 66)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(116, 16)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot password?"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.White
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(745, 507)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PatientPanel)
        Me.Controls.Add(Me.AdminPanel)
        Me.Controls.Add(Me.DoctorPanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cure Health Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DoctorPanel As System.Windows.Forms.Button
    Friend WithEvents AdminPanel As System.Windows.Forms.Button
    Friend WithEvents PatientPanel As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
