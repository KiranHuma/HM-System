<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServices
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServices))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.closee = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.servicereg_Grid = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.serviceDate_txt = New System.Windows.Forms.DateTimePicker()
        Me.serviceName_txt = New System.Windows.Forms.ComboBox()
        Me.serviceRate_txt = New System.Windows.Forms.TextBox()
        Me.service_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.servicereg_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 750)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.closee)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.welcomemsg)
        Me.TabPage1.Controls.Add(Me.servicereg_Grid)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.btnupdate)
        Me.TabPage1.Controls.Add(Me.btnadd)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.serviceDate_txt)
        Me.TabPage1.Controls.Add(Me.serviceName_txt)
        Me.TabPage1.Controls.Add(Me.serviceRate_txt)
        Me.TabPage1.Controls.Add(Me.service_txt)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btndel)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1319, 718)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Register Services"
        '
        'closee
        '
        Me.closee.BackColor = System.Drawing.SystemColors.Control
        Me.closee.BackgroundImage = CType(resources.GetObject("closee.BackgroundImage"), System.Drawing.Image)
        Me.closee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closee.ForeColor = System.Drawing.SystemColors.Control
        Me.closee.Location = New System.Drawing.Point(1265, 20)
        Me.closee.Margin = New System.Windows.Forms.Padding(4)
        Me.closee.Name = "closee"
        Me.closee.Size = New System.Drawing.Size(34, 33)
        Me.closee.TabIndex = 394
        Me.closee.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(676, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Search Service"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(679, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 22)
        Me.TextBox1.TabIndex = 170
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomemsg.Location = New System.Drawing.Point(44, 529)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(0, 31)
        Me.welcomemsg.TabIndex = 169
        '
        'servicereg_Grid
        '
        Me.servicereg_Grid.AllowUserToAddRows = False
        Me.servicereg_Grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.servicereg_Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.servicereg_Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.servicereg_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.servicereg_Grid.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.servicereg_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.servicereg_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.servicereg_Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.servicereg_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.servicereg_Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.servicereg_Grid.EnableHeadersVisualStyles = False
        Me.servicereg_Grid.GridColor = System.Drawing.Color.RoyalBlue
        Me.servicereg_Grid.Location = New System.Drawing.Point(679, 132)
        Me.servicereg_Grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.servicereg_Grid.Name = "servicereg_Grid"
        Me.servicereg_Grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.servicereg_Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.servicereg_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.servicereg_Grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.servicereg_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.servicereg_Grid.Size = New System.Drawing.Size(601, 551)
        Me.servicereg_Grid.TabIndex = 168
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(466, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "sssssss"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(327, 446)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "sssssss"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Sienna
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(318, 412)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 31)
        Me.btnupdate.TabIndex = 155
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(79, 412)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 31)
        Me.btnadd.TabIndex = 165
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Date"
        '
        'serviceDate_txt
        '
        Me.serviceDate_txt.Location = New System.Drawing.Point(254, 309)
        Me.serviceDate_txt.Name = "serviceDate_txt"
        Me.serviceDate_txt.Size = New System.Drawing.Size(220, 22)
        Me.serviceDate_txt.TabIndex = 163
        '
        'serviceName_txt
        '
        Me.serviceName_txt.FormattingEnabled = True
        Me.serviceName_txt.Items.AddRange(New Object() {"Bed Sheet", "Extra Bed", "Spa"})
        Me.serviceName_txt.Location = New System.Drawing.Point(252, 213)
        Me.serviceName_txt.Name = "serviceName_txt"
        Me.serviceName_txt.Size = New System.Drawing.Size(222, 24)
        Me.serviceName_txt.TabIndex = 162
        '
        'serviceRate_txt
        '
        Me.serviceRate_txt.Location = New System.Drawing.Point(252, 262)
        Me.serviceRate_txt.Name = "serviceRate_txt"
        Me.serviceRate_txt.Size = New System.Drawing.Size(222, 22)
        Me.serviceRate_txt.TabIndex = 161
        '
        'service_txt
        '
        Me.service_txt.Location = New System.Drawing.Point(252, 168)
        Me.service_txt.Name = "service_txt"
        Me.service_txt.Size = New System.Drawing.Size(222, 22)
        Me.service_txt.TabIndex = 160
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Service Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Service Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Service ID"
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Red
        Me.btndel.Enabled = False
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(448, 412)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 31)
        Me.btndel.TabIndex = 156
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(194, 412)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 31)
        Me.btnsave.TabIndex = 154
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'FrmServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1327, 754)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmServices"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.servicereg_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents serviceDate_txt As DateTimePicker
    Friend WithEvents serviceName_txt As ComboBox
    Friend WithEvents serviceRate_txt As TextBox
    Friend WithEvents service_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btndel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents servicereg_Grid As DataGridView
    Friend WithEvents welcomemsg As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents closee As Button
End Class
