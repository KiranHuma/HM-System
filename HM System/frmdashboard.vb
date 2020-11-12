Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Security.Cryptography
Imports System.Text

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
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        frmroomsData.Show()
    End Sub

    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
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
    Private Sub total_rooms()
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select COUNT(EntryNumber) from db_reservation "
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
            MessageBox.Show("Failed:Selected Value of members" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label16.Text = Format(Now, "yyyy-MM-dd")
        dbaccessconnection()
        occupied_rooms()
        total_rooms()
        checkin_rooms()
        customer_data()
        getdata_available()
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
    Private Sub customer_data()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select EntryNumber,Customer_Name,Room_Number,Room_Type from db_reservation where  Reservation_Status='Reserved'", con)
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
End Class
