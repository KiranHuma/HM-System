
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.

Public Class frmdashboard
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
    Dim cs As String = "Data Source=ANIRUDH;Initial Catalog=db_hmsystem;Integrated Security=True"
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
    'it will show data of occupied room in LABEL which are reserved
    Private Sub occupied_rooms()
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select COUNT(EntryNumber) from db_reservation WHERE Reservation_Status = 'Reserved'"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then
                Label4.Text = dbr.GetValue(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed:Selected Value of members" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'it will show data of total roomregistered 
    Private Sub total_rooms()
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select COUNT(roomnumber) from db_roomreg "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then
                Label10.Text = dbr.GetValue(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed:Selected Value of members" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'it  show data of checkin of today date
    Private Sub checkin_rooms()
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select COUNT(EntryNumber) from db_reservation  where Reservation_Status = 'Reserved' And Check_In_Date = '" & Label16.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then
                Label11.Text = dbr.GetValue(0)

            End If

        Catch ex As Exception
            MessageBox.Show("Failed:Selected Value of checkin rooms" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'it  show data of checkout of today date
    Private Sub checkout_rooms()
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select COUNT(Transacion_ID) from db_payment  where Status = 'CheckOut' And Check_Out_Date = '" & Label16.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then
                Label12.Text = dbr.GetValue(0)

            End If


        Catch ex As Exception
            MessageBox.Show("Failed:Selected Value of members" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data of room available 

    Private Sub getdata_available()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select roomnumber,roomtype,roomprice from db_roomreg where  Reservation_Status='Available'", con)
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

    'Show some data of customers who reserved room
    Private Sub customer_data()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select EntryNumber,Customer_Name,Room_Number,Room_Type from db_reservation ", con)
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
    'search function for searching the name of customer by textbox
    Private Sub searchcustomer()
        Dim str As String
        Try
            con.Open()
            str = "Select  EntryNumber,Customer_Name,Room_Number,Room_Type from db_reservation where Customer_Name like '" & TextBox1.Text & "%'"
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
    'search function for searching the name of roomtype by textbox
    Private Sub searchroom_type()
        Dim str As String
        Try
            con.Open()
            str = "Select  roomnumber,roomtype,roomprice from db_roomreg where  Reservation_Status='Available' And roomtype Like '" & TextBox2.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_reservation")
            con.Close()
            reservation_Grid.DataSource = ds
            reservation_Grid.DataMember = "db_reservation"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Customer Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        searchcustomer()

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        searchroom_type()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        searchroom_type()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        FrmServices.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        FrmCheckin_out.Show()
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles TextBox2.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(TextBox2, "Search By Room Type")
    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(TextBox1, "Search By Customer Name")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        frmroomsData.Show()
    End Sub

    Private Sub closee_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        FrmPayment.Show()
    End Sub
    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label16.Text = Format(Now, "yyyy-MM-dd")
        dbaccessconnection()
        occupied_rooms()
        total_rooms()
        checkin_rooms()
        customer_data()
        getdata_available()
        checkout_rooms()
    End Sub
End Class
