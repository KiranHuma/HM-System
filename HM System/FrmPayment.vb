
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.


Public Class FrmPayment
    Private bitmap As Bitmap 'for print grid
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=MITTA-MISHAL;Initial Catalog=db_hmsystem;Integrated Security=True"
    'Database Connection
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'insert data into database
    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into db_payment(Transacion_ID,Customer_Name,Room_Number,Room_Type,Number_of_Customers,Check_In_Date,Address,Phone_Number,Price,Check_Out_Date,Service_Details,Total_Service_Rate,Status,Discount,Total_Bill)values('" & transactionid_txt.Text & "','" & Cname_txt.Text & "','" & customerRnumber_txt.Text & "','" & re_roomtype_txt.Text & "','" & re_customer_txt.Text & "','" & re_checkin_dte.Value & "','" & re_address_txt.Text & "','" & phonenumber_txt.Text & "','" & price_txt.Text & "','" & transactiondte_txt.Value & "','" & RichTextBox2.Text & "','" & TextBox5.Text & "','" & Label18.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            cmd.ExecuteNonQuery()
            welcomemsg.Text = "'Payment" & transactionid_txt.Text & "' saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            getdata()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'this function will autoincrement the TransactionID
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(Transacion_ID) FROM db_payment "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                transactionid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                transactionid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Transaction ID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'edit function
    Private Sub edit()
        Try
            dbaccessconnection()
            con.Open()
            If Cname_txt.Text = "" Then
                MessageBox.Show("Empty Service Name")

            Else
                'Transacion_ID,Customer_Name,Room_Number,Room_Type,Number_of_Customers,Check_In_Date,Address,Phone_Number,Price,Check_Out_Date,Service_Details,Total_Service_Rate,Status,Discount,Total_Bill
                cmd.CommandText = ("UPDATE db_payment SET  Transacion_ID= '" & transactionid_txt.Text & "', Check_Out_Date= '" & transactiondte_txt.Value & "',Service_Details= '" & RichTextBox2.Text & "',Total_Service_Rate= '" & TextBox5.Text & "',Status= '" & Label18.Text & "',Discount= '" & TextBox2.Text & "',Total_Bill= '" & TextBox3.Text & "' where Transacion_ID=" & transactionid_txt.Text & "")
                cmd.ExecuteNonQuery()

                welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
                welcomemsg.Text = "'" & transactionid_txt.Text & "' update successfully!"
                payment_Grid.Refresh()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Data Not Updated")
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    'Delete function
    Private Sub DeleteSelecedRows()
        Try
            Dim ObjConnection As New SqlConnection()
            Dim i As Integer
            Dim mResult
            mResult = MsgBox("Want you really delete the selected records?",
            vbYesNo + vbQuestion, "Removal confirmation")
            If mResult = vbNo Then
                Exit Sub
            End If
            ObjConnection.ConnectionString = cs
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = ObjConnection
            For i = Me.payment_Grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from db_payment where Transacion_ID='" & payment_Grid.SelectedRows(i).Cells("Transacion_ID").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.payment_Grid.Rows.Remove(Me.payment_Grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data of payments in grid

    Private Sub getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_payment ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            payment_Grid.DataSource = dt
            payment_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'search the data of payments in records by textbox (GRIDVIEW)
    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select * from db_payment where Customer_Name like '" & TextBox4.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_payment")
            con.Close()
            payment_Grid.DataSource = ds
            payment_Grid.DataMember = "db_payment"
            payment_Grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Customer Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'this function will empty the textboxes,auto increment transaction id and get updated data
    Private Sub fun_addnew()

        txtboxid()
        getdata()

        Cname_txt.Text = ""
        customerRnumber_txt.Text = ""
        re_roomtype_txt.Text = ""
        re_customer_txt.Text = ""
        re_address_txt.Text = ""
        phonenumber_txt.Text = ""
        price_txt.Text = "0"
        ComboBox1.Text = ""
        RichTextBox2.Text = ""
        TextBox1.Text = ""
        TextBox5.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        welcomemsg.Text = ""
        btnsave.Enabled = True
        btndel.Enabled = False
        btnupdate.Enabled = False
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        fun_addnew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        insert()
        getdata()
        update_Cancell_status()
        update_reservation_status()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        edit()
        getdata()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        DeleteSelecedRows()
    End Sub

    Private Sub payment_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles payment_Grid.CellContentClick
        btnsave.Enabled = False
        btndel.Enabled = True
        btnupdate.Enabled = True
    End Sub

    Private Sub payment_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles payment_Grid.CellMouseClick
        Try
            btnsave.Enabled = False
            btndel.Enabled = True
            btnupdate.Enabled = True
            TabControl1.SelectedTab = TabPage1
            Me.transactionid_txt.Text = payment_Grid.CurrentRow.Cells(0).Value.ToString
            Me.Cname_txt.Text = payment_Grid.CurrentRow.Cells(1).Value.ToString
            Me.customerRnumber_txt.Text = payment_Grid.CurrentRow.Cells(2).Value.ToString
            Me.re_roomtype_txt.Text = payment_Grid.CurrentRow.Cells(3).Value.ToString
            Me.re_customer_txt.Text = payment_Grid.CurrentRow.Cells(4).Value.ToString
            Me.re_checkin_dte.Value = payment_Grid.CurrentRow.Cells(5).Value.ToString
            Me.re_address_txt.Text = payment_Grid.CurrentRow.Cells(6).Value.ToString
            Me.phonenumber_txt.Text = payment_Grid.CurrentRow.Cells(7).Value.ToString
            Me.price_txt.Text = payment_Grid.CurrentRow.Cells(8).Value.ToString
            Me.transactiondte_txt.Value = payment_Grid.CurrentRow.Cells(9).Value.ToString
            Me.RichTextBox2.Text = payment_Grid.CurrentRow.Cells(10).Value.ToString
            Me.TextBox5.Text = payment_Grid.CurrentRow.Cells(11).Value.ToString
            Me.Label18.Text = payment_Grid.CurrentRow.Cells(12).Value.ToString
            Me.TextBox2.Text = payment_Grid.CurrentRow.Cells(13).Value.ToString
            Me.TextBox3.Text = payment_Grid.CurrentRow.Cells(14).Value.ToString
        Catch ex As Exception
            MsgBox("Failed:GridCick " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        If btnupdate.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label5, "Select the field from Grid to Edit")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label5, "Click to Edit")
        End If
    End Sub

    Private Sub Label7_MouseHover(sender As Object, e As EventArgs) Handles Label7.MouseHover
        If btndel.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Select the rows from Grid to delete")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Click to Delete")
        End If
    End Sub

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        txtboxid()
        customer_FillCombo()
        services_FillCombo()
        getdata()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        search_txt()
    End Sub

    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub
    'fill the dropdown menu with customer name to get the customer details in respective textboxes
    Private Sub customer_FillCombo()
        Try

            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection

            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT Customer_Name from db_reservation where Reservation_Status='Reserved'", myConnToAccess)
            da.Fill(ds, "db_reservation")
            Dim view1 As New DataView(tables(0))
            With Cname_txt
                .DataSource = ds.Tables("db_reservation")
                .DisplayMember = "Customer_Name"
                .ValueMember = "Customer_Name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("Error in Entrynumber" & ex.Message)
        End Try
    End Sub
    'fill the dropdown menu with services name to get the services details in respective textboxes
    Private Sub services_FillCombo()
        Try

            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection

            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT Service_Name from db_services", myConnToAccess)
            da.Fill(ds, "db_services")
            Dim view1 As New DataView(tables(0))
            With ComboBox1
                .DataSource = ds.Tables("db_services")
                .DisplayMember = "Service_Name"
                .ValueMember = "Service_Name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("Error in Entrynumber" & ex.Message)
        End Try
    End Sub
    'based on customer name,the other textboxes will fill according to it
    Private Sub Cname_txt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cname_txt.SelectedIndexChanged
        Try
            Dim strsql As String = "select * from db_reservation where Customer_Name like('" + Cname_txt.Text + "%')"
            Dim strcon As String = cs
            Dim odapre As New SqlDataAdapter(strsql, strcon)
            Dim datTable As New DataTable
            Dim incount As Integer
            odapre.Fill(datTable)
            For incount = 0 To datTable.Rows.Count - 1
                customerRnumber_txt.Text = datTable.Rows(incount)("Room_Number").ToString
                re_roomtype_txt.Text = datTable.Rows(incount)("Room_Type").ToString
                re_customer_txt.Text = datTable.Rows(incount)("Number_of_Customers").ToString
                re_checkin_dte.Value = datTable.Rows(incount)("Check_In_Date").ToString
                re_address_txt.Text = datTable.Rows(incount)("Address").ToString
                phonenumber_txt.Text = datTable.Rows(incount)("Phone_Number").ToString
                price_txt.Text = datTable.Rows(incount)("Price").ToString

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:EmployeeName Populating", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'based on service name,the other textboxes will fill according to it
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim strsql As String = "select Service_Name,Service_Rate from db_services where Service_Name like('" + ComboBox1.Text + "%')"
            Dim strcon As String = cs
            Dim odapre As New SqlDataAdapter(strsql, strcon)
            Dim datTable As New DataTable
            Dim incount As Integer
            odapre.Fill(datTable)
            For incount = 0 To datTable.Rows.Count - 1
                TextBox1.Text = datTable.Rows(incount)("Service_Rate").ToString


            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:EmployeeName Populating", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        p_nameadd()
        s_pricetotal()

    End Sub
    'add more than one in richtextbox
    Private Sub p_nameadd()
        RichTextBox2.Text &= "Name" & ":" & ComboBox1.Text & "," & "Price" & ":" + TextBox1.Text & vbNewLine
    End Sub
    'calculate the total price of services
    Private Sub s_pricetotal()
        Dim addd As Double
        addd = Double.Parse(TextBox1.Text) + Double.Parse(TextBox5.Text)
        TextBox5.Text = Convert.ToString(addd)
    End Sub
    'calculate the total of room and services charges
    Private Sub servRoom_pricetotal()
        Dim addd As Double
        addd = Double.Parse(price_txt.Text) + Double.Parse(TextBox5.Text)
        TextBox6.Text = Convert.ToString(addd)
    End Sub
    'pop up 
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "Press the button to calculate the services total")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        servRoom_pricetotal()
    End Sub

    'discount function
    Private Sub services_discount()
        Dim PercentageNumberResult As Double
        PercentageNumberResult = TextBox6.Text / 100 * TextBox2.Text
        TextBox7.Text = PercentageNumberResult
        Dim subtractdiscount As Double
        subtractdiscount = TextBox6.Text - TextBox7.Text
        TextBox3.Text = subtractdiscount
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        services_discount()
    End Sub
    'it make the room available after checkout
    Private Sub update_Cancell_status()
        con.Close()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = ("UPDATE db_roomreg SET Reservation_Status= 'Available'  where roomnumber=" & customerRnumber_txt.Text & "")
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("Status Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub
    'it will change the reserved status in reservation table to CHECKOUT
    Private Sub update_reservation_status()
        con.Close()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = ("UPDATE db_reservation SET Reservation_Status= 'CheckOut'  where Room_Number=" & customerRnumber_txt.Text & "")
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("Status Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub


End Class