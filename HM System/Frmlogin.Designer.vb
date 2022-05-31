<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmlogin))
        Me.selectUser = New System.Windows.Forms.ComboBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'selectUser
        '
        Me.selectUser.BackColor = System.Drawing.SystemColors.Control
        Me.selectUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectUser.ForeColor = System.Drawing.Color.Black
        Me.selectUser.FormattingEnabled = True
        Me.selectUser.Items.AddRange(New Object() {"User", "Admin"})
        Me.selectUser.Location = New System.Drawing.Point(333, 431)
        Me.selectUser.Name = "selectUser"
        Me.selectUser.Size = New System.Drawing.Size(269, 24)
        Me.selectUser.TabIndex = 79
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel3.Controls.Add(Me.pictureBox3)
        Me.panel3.Controls.Add(Me.txtPass)
        Me.panel3.Location = New System.Drawing.Point(333, 513)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(272, 37)
        Me.panel3.TabIndex = 78
        '
        'pictureBox3
        '
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(239, 2)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(27, 26)
        Me.pictureBox3.TabIndex = 2
        Me.pictureBox3.TabStop = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(5, 6)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(228, 27)
        Me.txtPass.TabIndex = 47
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.pictureBox2)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Location = New System.Drawing.Point(333, 470)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(272, 37)
        Me.Panel4.TabIndex = 77
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(239, 3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(27, 27)
        Me.pictureBox2.TabIndex = 2
        Me.pictureBox2.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(6, 4)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(224, 27)
        Me.txtUsername.TabIndex = 46
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(55, 639)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(46, 17)
        Me.label6.TabIndex = 74
        Me.label6.Text = "label6"
        Me.label6.Visible = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.RoyalBlue
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(333, 566)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(272, 34)
        Me.loginBtn.TabIndex = 73
        Me.loginBtn.Text = "&Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 398)
        Me.Panel1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Select User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 533)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(628, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 29)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "X"
        '
        'Frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 674)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectUser)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frmlogin"
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents selectUser As ComboBox
    Private WithEvents panel3 As Panel
    Private WithEvents pictureBox3 As PictureBox
    Friend WithEvents txtPass As TextBox
    Private WithEvents Panel4 As Panel
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Private WithEvents label6 As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents Label13 As Label
End Class
