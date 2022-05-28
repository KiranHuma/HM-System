<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.closee = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.welcomemsg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.customerRnumber_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.re_address_txt = New System.Windows.Forms.RichTextBox()
        Me.price_txt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.phonenumber_txt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.re_customer_txt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.re_checkin_dte = New System.Windows.Forms.DateTimePicker()
        Me.re_roomtype_txt = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.transactiondte_txt = New System.Windows.Forms.DateTimePicker()
        Me.transactionid_txt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Cname_txt = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.payment_Grid = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.payment_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1302, 725)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.TextBox7)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.closee)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.welcomemsg)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnupdate)
        Me.TabPage1.Controls.Add(Me.btnadd)
        Me.TabPage1.Controls.Add(Me.btndel)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.RichTextBox2)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.customerRnumber_txt)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.re_address_txt)
        Me.TabPage1.Controls.Add(Me.price_txt)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.phonenumber_txt)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.re_customer_txt)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.re_checkin_dte)
        Me.TabPage1.Controls.Add(Me.re_roomtype_txt)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.transactiondte_txt)
        Me.TabPage1.Controls.Add(Me.transactionid_txt)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Cname_txt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1294, 693)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Payment And Check Out"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(671, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 427
        Me.Button3.Text = "Total Bill"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 426
        Me.Button2.Text = "Total Service and room charges"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(655, 371)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(103, 22)
        Me.TextBox7.TabIndex = 425
        Me.TextBox7.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(538, 193)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(220, 22)
        Me.TextBox6.TabIndex = 424
        Me.TextBox6.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(764, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 423
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'closee
        '
        Me.closee.BackColor = System.Drawing.SystemColors.Control
        Me.closee.BackgroundImage = CType(resources.GetObject("closee.BackgroundImage"), System.Drawing.Image)
        Me.closee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closee.ForeColor = System.Drawing.SystemColors.Control
        Me.closee.Location = New System.Drawing.Point(1253, 7)
        Me.closee.Margin = New System.Windows.Forms.Padding(4)
        Me.closee.Name = "closee"
        Me.closee.Size = New System.Drawing.Size(34, 33)
        Me.closee.TabIndex = 422
        Me.closee.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(668, 411)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 17)
        Me.Label18.TabIndex = 421
        Me.Label18.Text = "CheckOut"
        Me.Label18.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(538, 142)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(220, 22)
        Me.TextBox5.TabIndex = 420
        Me.TextBox5.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(398, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 17)
        Me.Label11.TabIndex = 419
        Me.Label11.Text = "Total Service Prices"
        '
        'welcomemsg
        '
        Me.welcomemsg.AutoSize = True
        Me.welcomemsg.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomemsg.Location = New System.Drawing.Point(329, 606)
        Me.welcomemsg.Name = "welcomemsg"
        Me.welcomemsg.Size = New System.Drawing.Size(0, 31)
        Me.welcomemsg.TabIndex = 418
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(1209, 643)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "sssssss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(1070, 643)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 416
        Me.Label7.Text = "sssssss"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.Sienna
        Me.btnupdate.Enabled = False
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Location = New System.Drawing.Point(1061, 609)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 31)
        Me.btnupdate.TabIndex = 413
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.SeaGreen
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(822, 609)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 31)
        Me.btnadd.TabIndex = 415
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Red
        Me.btndel.Enabled = False
        Me.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndel.ForeColor = System.Drawing.Color.White
        Me.btndel.Location = New System.Drawing.Point(1191, 609)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 31)
        Me.btndel.TabIndex = 414
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.DarkGreen
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(937, 609)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 412
        Me.btnsave.Text = "CheckOut"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(538, 298)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 22)
        Me.TextBox3.TabIndex = 411
        Me.TextBox3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(444, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "Total Bill"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(538, 246)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 22)
        Me.TextBox2.TabIndex = 409
        Me.TextBox2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 408
        Me.Label3.Text = "Discount"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(868, 85)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(220, 78)
        Me.RichTextBox2.TabIndex = 406
        Me.RichTextBox2.Text = ""
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(865, 65)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(109, 17)
        Me.Label36.TabIndex = 407
        Me.Label36.Text = "Services Details"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(538, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 22)
        Me.TextBox1.TabIndex = 405
        Me.TextBox1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 404
        Me.Label1.Text = "Service Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label2.Location = New System.Drawing.Point(415, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 402
        Me.Label2.Text = "Service Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(538, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(220, 24)
        Me.ComboBox1.TabIndex = 403
        '
        'customerRnumber_txt
        '
        Me.customerRnumber_txt.Enabled = False
        Me.customerRnumber_txt.Location = New System.Drawing.Point(155, 136)
        Me.customerRnumber_txt.Name = "customerRnumber_txt"
        Me.customerRnumber_txt.Size = New System.Drawing.Size(220, 22)
        Me.customerRnumber_txt.TabIndex = 401
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 17)
        Me.Label14.TabIndex = 400
        Me.Label14.Text = "Room Number"
        '
        're_address_txt
        '
        Me.re_address_txt.Enabled = False
        Me.re_address_txt.Location = New System.Drawing.Point(155, 286)
        Me.re_address_txt.Name = "re_address_txt"
        Me.re_address_txt.Size = New System.Drawing.Size(220, 72)
        Me.re_address_txt.TabIndex = 399
        Me.re_address_txt.Text = ""
        '
        'price_txt
        '
        Me.price_txt.Enabled = False
        Me.price_txt.Location = New System.Drawing.Point(155, 410)
        Me.price_txt.Name = "price_txt"
        Me.price_txt.Size = New System.Drawing.Size(220, 22)
        Me.price_txt.TabIndex = 398
        Me.price_txt.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(34, 419)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 17)
        Me.Label17.TabIndex = 397
        Me.Label17.Text = "Price"
        '
        'phonenumber_txt
        '
        Me.phonenumber_txt.Enabled = False
        Me.phonenumber_txt.Location = New System.Drawing.Point(155, 373)
        Me.phonenumber_txt.Name = "phonenumber_txt"
        Me.phonenumber_txt.Size = New System.Drawing.Size(220, 22)
        Me.phonenumber_txt.TabIndex = 396
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(34, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 395
        Me.Label16.Text = "Phone Number"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(34, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 17)
        Me.Label15.TabIndex = 394
        Me.Label15.Text = "Address"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 393
        Me.Label13.Text = "Check In Date"
        '
        're_customer_txt
        '
        Me.re_customer_txt.Enabled = False
        Me.re_customer_txt.Location = New System.Drawing.Point(155, 212)
        Me.re_customer_txt.Name = "re_customer_txt"
        Me.re_customer_txt.Size = New System.Drawing.Size(220, 22)
        Me.re_customer_txt.TabIndex = 392
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 391
        Me.Label9.Text = "No. of Customer"
        '
        're_checkin_dte
        '
        Me.re_checkin_dte.Enabled = False
        Me.re_checkin_dte.Location = New System.Drawing.Point(155, 249)
        Me.re_checkin_dte.Name = "re_checkin_dte"
        Me.re_checkin_dte.Size = New System.Drawing.Size(220, 22)
        Me.re_checkin_dte.TabIndex = 390
        '
        're_roomtype_txt
        '
        Me.re_roomtype_txt.Enabled = False
        Me.re_roomtype_txt.FormattingEnabled = True
        Me.re_roomtype_txt.Items.AddRange(New Object() {"VIP", "Single Bed", "Double Bed"})
        Me.re_roomtype_txt.Location = New System.Drawing.Point(155, 173)
        Me.re_roomtype_txt.Name = "re_roomtype_txt"
        Me.re_roomtype_txt.Size = New System.Drawing.Size(220, 24)
        Me.re_roomtype_txt.TabIndex = 389
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 388
        Me.Label10.Text = "Room Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label6.Location = New System.Drawing.Point(27, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 17)
        Me.Label6.TabIndex = 387
        Me.Label6.Text = "Transaction Date"
        '
        'transactiondte_txt
        '
        Me.transactiondte_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactiondte_txt.Location = New System.Drawing.Point(155, 465)
        Me.transactiondte_txt.Name = "transactiondte_txt"
        Me.transactiondte_txt.Size = New System.Drawing.Size(220, 22)
        Me.transactiondte_txt.TabIndex = 386
        '
        'transactionid_txt
        '
        Me.transactionid_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transactionid_txt.ForeColor = System.Drawing.SystemColors.InfoText
        Me.transactionid_txt.Location = New System.Drawing.Point(155, 60)
        Me.transactionid_txt.Name = "transactionid_txt"
        Me.transactionid_txt.ReadOnly = True
        Me.transactionid_txt.Size = New System.Drawing.Size(220, 22)
        Me.transactionid_txt.TabIndex = 384
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label12.Location = New System.Drawing.Point(32, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 381
        Me.Label12.Text = "Customer Name"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label31.Location = New System.Drawing.Point(29, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 17)
        Me.Label31.TabIndex = 383
        Me.Label31.Text = "Transaction #"
        '
        'Cname_txt
        '
        Me.Cname_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cname_txt.FormattingEnabled = True
        Me.Cname_txt.Location = New System.Drawing.Point(155, 97)
        Me.Cname_txt.Name = "Cname_txt"
        Me.Cname_txt.Size = New System.Drawing.Size(220, 24)
        Me.Cname_txt.TabIndex = 385
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.payment_Grid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1294, 693)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Search Customer"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(10, 107)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(222, 22)
        Me.TextBox4.TabIndex = 173
        '
        'payment_Grid
        '
        Me.payment_Grid.AllowUserToAddRows = False
        Me.payment_Grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.payment_Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.payment_Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.payment_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.payment_Grid.BackgroundColor = System.Drawing.Color.LightCoral
        Me.payment_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.payment_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.payment_Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.payment_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.payment_Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.payment_Grid.EnableHeadersVisualStyles = False
        Me.payment_Grid.GridColor = System.Drawing.Color.LightCoral
        Me.payment_Grid.Location = New System.Drawing.Point(22, 152)
        Me.payment_Grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.payment_Grid.Name = "payment_Grid"
        Me.payment_Grid.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.payment_Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.payment_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.payment_Grid.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.payment_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.payment_Grid.Size = New System.Drawing.Size(1251, 519)
        Me.payment_Grid.TabIndex = 172
        '
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 754)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPayment"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.payment_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents transactiondte_txt As DateTimePicker
    Friend WithEvents transactionid_txt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Cname_txt As ComboBox
    Friend WithEvents customerRnumber_txt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents re_address_txt As RichTextBox
    Friend WithEvents price_txt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents phonenumber_txt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents re_customer_txt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents re_checkin_dte As DateTimePicker
    Friend WithEvents re_roomtype_txt As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents welcomemsg As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents payment_Grid As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents closee As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
