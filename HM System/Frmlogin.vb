Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Public Class Frmlogin
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
    'check the username and password

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Username!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!")
        End If
        If TextBox1.Text = "hotelmanage " Or TextBox2.Text = "hotel123" Then
            Beep()
            Beep()
            frmdashboard.ShowDialog()
            Me.Dispose()
        Else
            Label4.Visible = True
            Label4.ForeColor = System.Drawing.Color.Red
            Label4.Text = " Not succsessfully login "
        End If
        'End If
    End Sub
    'this enable the password to be written in asterik
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ControlChars.NullChar
            ' TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class