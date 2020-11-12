Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Security.Cryptography
Imports System.Text

Public Class frmroomsData
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
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=DESKTOP-H2H8TNI;Initial Catalog=db_hmsystem;Integrated Security=True"
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
    Private Sub frmroomsData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        txtboxid()
        getdata()
        search_txt_grid()
        txtboxid_reserve()
        getdata_reserve()
        getdata_roomsdetails()
        getdata_cancellroomsdetails()
    End Sub
    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into db_roomreg(roomnumber,roomtype,roomprice,roomregdate,Reservation_Status)values('" & roomnum_txt.Text & "','" & roomtype_txt.Text & "','" & roomrate_txt.Text & "','" & regdate_txt.Value & "','" & status_lbl.Text & "')"
            cmd.ExecuteNonQuery()
            welcomemsg.Text = "'Room" & roomnum_txt.Text & "' saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            getdata()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    '
    'this function will autoincrement the rommnumber
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(roomnumber) FROM db_roomreg "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                roomnum_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                roomnum_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Room Number Entry" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'funtion of insert called on btnsave
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        insert()
        getdata_reserve()
        getdata_roomsdetails()
    End Sub
    'Show data of room registration in grid

    Private Sub getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select roomnumber,roomtype,roomprice,roomregdate from db_roomreg ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            roomreg_Grid.DataSource = dt
            roomreg_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'this function will empty the textboxes,auto increment room number and get updated data
    Private Sub fun_addnew()

        txtboxid()
        getdata()
        status_lbl.Text = "Available"
        roomtype_txt.Text = ""
        roomrate_txt.Text = ""
        roomtype_txt.Enabled = True
        roomrate_txt.Enabled = True
        btnsave.Enabled = True

        btndel.Enabled = False
        btnupdate.Enabled = False
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        fun_addnew()
    End Sub
    'edit function
    Private Sub edit()
        Try
            dbaccessconnection()
            con.Open()
            If roomtype_txt.Text = "" Then
                MessageBox.Show("Empty RoomType")

            Else
                cmd.CommandText = ("UPDATE db_roomreg SET  roomnumber= '" & roomnum_txt.Text & "', roomtype= '" & roomtype_txt.Text & "',roomprice= '" & roomrate_txt.Text & "',roomregdate= '" & regdate_txt.Value & "' where roomnumber=" & roomnum_txt.Text & "")
                cmd.ExecuteNonQuery()

                welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
                welcomemsg.Text = "'Room" & roomnum_txt.Text & "' update successfully!"
                roomreg_Grid.Refresh()
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
            For i = Me.roomreg_Grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from db_roomreg where roomnumber='" & roomreg_Grid.SelectedRows(i).Cells("roomnumber").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.roomreg_Grid.Rows.Remove(Me.roomreg_Grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        edit()
        getdata()

    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        DeleteSelecedRows()
    End Sub

    Private Sub roomreg_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles roomreg_Grid.CellContentClick
        btnsave.Enabled = False
        btndel.Enabled = True
        btnupdate.Enabled = True
    End Sub

    Private Sub roomreg_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles roomreg_Grid.CellMouseClick
        Try
            btnsave.Enabled = False
            btndel.Enabled = True
            btnupdate.Enabled = True
            Me.roomnum_txt.Text = roomreg_Grid.CurrentRow.Cells(0).Value.ToString
            Me.roomtype_txt.Text = roomreg_Grid.CurrentRow.Cells(1).Value.ToString
            Me.roomrate_txt.Text = roomreg_Grid.CurrentRow.Cells(2).Value.ToString
            Me.regdate_txt.Value = roomreg_Grid.CurrentRow.Cells(3).Value.ToString


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


    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        If btndel.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label6, "Select the rows from Grid to delete")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label6, "Click to Delete")
        End If
    End Sub

    '' The function of tab2 of reservation are below
    Private Sub insert_reserve()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into db_reservation(EntryNumber,Customer_Name,Room_Number,Room_Type,Number_of_Customers,Check_In_Date,Address,Phone_Number,Price,Reservation_Status)values('" & entry_txt.Text & "','" & customer_txt.Text & "','" & customerRnumber_txt.Text & "','" & re_roomtype_txt.Text & "','" & re_customer_txt.Text & "','" & re_checkin_dte.Value & "','" & re_address_txt.Text & "','" & phonenumber_txt.Text & "','" & price_txt.Text & "','" & status_lbl.Text & "')"
            cmd.ExecuteNonQuery()
            welcomemsg.Text = "'" & customer_txt.Text & "' saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            'getdata_reserve()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub update_reserve_status()
        con.Close()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = ("UPDATE db_roomreg SET Reservation_Status= 'Reserved'  where roomnumber=" & customerRnumber_txt.Text & "")
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("Status Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub
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
    Private Sub update_Cancellreserved_status()
        con.Close()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = ("UPDATE db_reservation SET Reservation_Status= 'Cancell'  where EntryNumber=" & entry_txt.Text & "")
            cmd.ExecuteNonQuery()
            ' MessageBox.Show("Status Updated")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnsave_reser.Click
        status_lbl.Text = "Reserved"
        insert_reserve()
        update_reserve_status()
        getdata_reserve()
        getdata_roomsdetails()
    End Sub

    Private Sub txtboxid_reserve()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(EntryNumber) FROM db_reservation "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                entry_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                entry_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Entrynumber" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'Show data of availabe rooms in grid

    Private Sub getdata_reserve()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_roomreg where  Reservation_Status='Available'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            reservation_Grid.DataSource = dt
            reservation_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnupdate_rserv.Click

        TabControl1.SelectedTab = TabPage3
        edit_reserve()
        getdata_reserve()
        getdata_roomsdetails()
    End Sub
    'edit of reservation function
    Private Sub edit_reserve()
        Try
            dbaccessconnection()
            con.Open()
            If customer_txt.Text = "" Then
                MessageBox.Show("Empty Customer Name")

            Else
                cmd.CommandText = ("UPDATE db_reservation SET EntryNumber='" & entry_txt.Text & "', Customer_Name='" & customer_txt.Text & "', Room_Number='" & customerRnumber_txt.Text & "',Room_Type= '" & re_roomtype_txt.Text & "',Number_of_Customers= '" & re_customer_txt.Text & "',Check_In_Date= '" & re_checkin_dte.Value & "',Address= '" & re_address_txt.Text & "',Phone_Number= '" & phonenumber_txt.Text & "',Price= '" & price_txt.Text & "' where EntryNumber=" & entry_txt.Text & "")

                cmd.ExecuteNonQuery()

                welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
                welcomemsg.Text = "'" & customer_txt.Text & "' update successfully!"
                roomreg_Grid.Refresh()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub

    Private Sub reservation_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles reservation_Grid.CellContentClick

    End Sub
    'the data of room from gird will transfer to textboxes on mouse click.
    Private Sub reservation_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles reservation_Grid.CellMouseClick
        Try
            btnsave.Enabled = False
            btndel.Enabled = True
            btnupdate.Enabled = True
            Me.customerRnumber_txt.Text = reservation_Grid.CurrentRow.Cells(0).Value.ToString
            Me.re_roomtype_txt.Text = reservation_Grid.CurrentRow.Cells(1).Value.ToString
            Me.price_txt.Text = reservation_Grid.CurrentRow.Cells(2).Value.ToString



        Catch ex As Exception
            MsgBox("Failed:GridCick " & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles reservedgrid.CellContentClick
        btnsave_reser.Enabled = False
        btndelete_rserve.Enabled = True
        btnupdate_rserv.Enabled = True
        Button1.Enabled = True
    End Sub
    'Tab 3 contains the data of customer who reserved the room with some rooms details.
    Private Sub getdata_roomsdetails()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_reservation where  Reservation_Status='Reserved'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            reservedgrid.DataSource = dt
            reservedgrid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub getdata_cancellroomsdetails()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_reservation where  Reservation_Status='Cancell'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            cancell_Grid.DataSource = dt
            cancell_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub addnew_reservation()
        txtboxid_reserve()
        customer_txt.Text = ""
        customerRnumber_txt.Text = ""
        re_roomtype_txt.Text = ""
        re_customer_txt.Text = ""
        re_address_txt.Text = ""
        phonenumber_txt.Text = ""
        price_txt.Text = ""
    End Sub
    Private Sub btnadd_res_Click(sender As Object, e As EventArgs) Handles btnadd_res.Click
        btnsave_reser.Enabled = True
        addnew_reservation()
        getdata_reserve()
        getdata_roomsdetails()
    End Sub

    Private Sub reservedgrid_MouseClick(sender As Object, e As MouseEventArgs) Handles reservedgrid.MouseClick
        Try
            TabControl1.SelectedTab = TabPage2
            btnupdate_rserv.Enabled = True
            btndelete_rserve.Enabled = True
            Me.entry_txt.Text = reservedgrid.CurrentRow.Cells(0).Value.ToString
            Me.customer_txt.Text = reservedgrid.CurrentRow.Cells(1).Value.ToString
            Me.customerRnumber_txt.Text = reservedgrid.CurrentRow.Cells(2).Value.ToString
            Me.re_roomtype_txt.Text = reservedgrid.CurrentRow.Cells(3).Value.ToString
            Me.re_customer_txt.Text = reservedgrid.CurrentRow.Cells(4).Value.ToString
            Me.re_checkin_dte.Value = reservedgrid.CurrentRow.Cells(5).Value.ToString
            Me.re_address_txt.Text = reservedgrid.CurrentRow.Cells(6).Value.ToString
            Me.phonenumber_txt.Text = reservedgrid.CurrentRow.Cells(7).Value.ToString
            Me.price_txt.Text = reservedgrid.CurrentRow.Cells(8).Value.ToString


        Catch ex As Exception
            MessageBox.Show("Failed:Selected Value of Cellcontent", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Dispose()
        End Try
    End Sub
    'Delete function
    Private Sub DeleteSelecedRows_reserve()
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
            For i = Me.reservedgrid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from db_reservation where EntryNumber='" & reservedgrid.SelectedRows(i).Cells("EntryNumber").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.reservedgrid.Rows.Remove(Me.reservedgrid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub btndelete_rserve_Click(sender As Object, e As EventArgs) Handles btndelete_rserve.Click
        TabControl1.SelectedTab = TabPage3

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' status_lbl.Text = "Cancell"

        update_Cancell_status()
        update_Cancellreserved_status()
        getdata_reserve()
        getdata_roomsdetails()
        getdata_cancellroomsdetails()
    End Sub
    Private Sub cancel_btn()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        DeleteSelecedRows_reserve()
    End Sub
    'search customer name in grid

    Private Sub search_txt_grid()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_reservation ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select * from db_reservation where Customer_Name like '" & TextBox3.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_reservation")
            con.Close()
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "db_reservation"
            DataGridView1.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Customer Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        search_txt()
    End Sub



    Private Sub Label19_MouseHover(sender As Object, e As EventArgs) Handles Label19.MouseHover
        If Button1.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label19, "Select the rows from ReservedRoom Tab to Cancel")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label9, "Click to Cancel")
        End If

    End Sub

    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class