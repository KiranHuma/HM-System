Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.
Public Class AdminPanel
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
    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AddUsers.ShowDialog()
        Me.Close()
    End Sub
    Private Sub usersdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select U_ID,UserRole,Username,Name,Password,Gender,Contact_no,Email from Users ", con)
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
            For i = Me.DataGridView1.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from Users where U_ID='" & DataGridView1.SelectedRows(i).Cells("U_ID").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.DataGridView1.Rows.Remove(Me.DataGridView1.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usersdata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmdashboard.Show()
        Me.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteSelecedRows()
        AddUsers.ShowDialog()
        Me.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        AddUsers.Uid_txt.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AddUsers.Label14.Text = Me.Label1.Text
        AddUsers.button1.Visible = True
        AddUsers.label7.Visible = False
        AddUsers.button2.Visible = False
        AddUsers.Button3.Visible = True
        AddUsers.ShowDialog()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class