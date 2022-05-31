
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.


Public Class FrmCheckin_out
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
    'filter the checkout data of customer  by date 
    Private Sub checkout_searchdate()
        con.Close()

        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dfrom As DateTime = trandtefrom_txt.Value
        Dim dto As DateTime = trandteto_txt.Value
        myConnection.ConnectionString = cs
        myConnection.Open()
        Dim str As String = "Select * from db_payment where Check_Out_Date >= '" & Format(dfrom, "MM-dd-yyyy") & "' and Check_Out_Date <='" & Format(dto, "MM-dd-yyyy") & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(str, myConnection)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        myConnection.Close()
        DataGridView1.Refresh()
    End Sub
    'filter the checkin data of customer  by date 
    Private Sub checkin_searchdate()
        con.Close()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dfrom As DateTime = DateTimePicker2.Value
        Dim dto As DateTime = DateTimePicker1.Value
        myConnection.ConnectionString = cs
        myConnection.Open()
        Dim str As String = "Select * from db_reservation where Check_In_Date >= '" & Format(dfrom, "MM-dd-yyyy") & "' and Check_In_Date <='" & Format(dto, "MM-dd-yyyy") & "'"
        Dim da As SqlDataAdapter = New SqlDataAdapter(str, myConnection)
        da.Fill(dt)
        payment_Gridd.DataSource = dt
        myConnection.Close()
        payment_Gridd.Refresh()
    End Sub

    'search the customer name by textbox in checkin TAB
    Private Sub searchcustomer_checkin()
        Dim str As String
        Try
            con.Open()
            str = "Select * from db_reservation where Customer_Name like '" & TextBox1.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_reservation")
            con.Close()
            payment_Gridd.DataSource = ds
            payment_Gridd.DataMember = "db_reservation"
            payment_Gridd.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Customer Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    'search the customer name by textbox in checkout TAB
    Private Sub searchcustomer_checkout()
        Dim str As String
        Try
            con.Open()
            str = "Select  * from db_payment where Customer_Name like '" & TextBox2.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_payment")
            con.Close()
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "db_payment"
            DataGridView1.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Customer Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    'search get checkin data in checkinTAB(GRIDVIEW)
    Private Sub customer_checkindata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_reservation ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            payment_Gridd.DataSource = dt
            payment_Gridd.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'search get checkin data in checkOUTTAB(GRIDVIEW)
    Private Sub customer_checkoutdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_payment ", con)
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

    ''Above FUNCTION CALLS on BUTTONS AND TEXTBOXES
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        searchcustomer_checkout()
    End Sub
    Private Sub FrmCheckin_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        customer_checkindata()
        customer_checkoutdata()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) 
        checkin_searchdate()
    End Sub
    Private Sub transactioncheck_CheckedChanged(sender As Object, e As EventArgs) Handles transactioncheck.CheckedChanged
        checkin_searchdate()
        transactioncheck.Checked = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        checkout_searchdate()
        RadioButton1.Checked = False
    End Sub

    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        searchcustomer_checkin()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class