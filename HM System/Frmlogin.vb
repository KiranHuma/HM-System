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
    Dim cs As String = "Data Source=MITTA-MISHAL;Initial Catalog=db_hmsystem;Integrated Security=True"
    ' Dim cs As String = "Data Source=MITTA-MISHAL;Initial Catalog=db_hmsystem;Integrated Security=True"
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
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If selectUser.Text = "User" Then

            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" & txtUsername.Text & "' AND Password='" & txtPass.Text & "' AND UserRole='user'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then
                'Me.Close()

                frmdashboard.username_lbl.Text = Me.txtUsername.Text
                frmdashboard.Show()
                Me.Close()
            Else
                MessageBox.Show("Invalid username or password")
            End If
        ElseIf selectUser.Text = "Admin" Then
            Dim con As New SqlConnection(cs) ' making connection
            Dim sda As New SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Username='" & txtUsername.Text & "' AND UserRole='admin'", con)
            ' in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. 
            Dim dt As New DataTable() 'this is creating a virtual table
            sda.Fill(dt)
            If dt.Rows(0)(0).ToString() = "1" Then


                AdminPanel.Show()
                Me.Close()
            Else
                MessageBox.Show("Your username Or password is not match", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                label6.ForeColor = Color.Red
                label6.Text = " Not succsessfully login "
            End If
        Else
            MessageBox.Show("Select your choice", "ADMIN or USER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
    End Sub
End Class