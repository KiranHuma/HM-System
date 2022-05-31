
Imports System.Data.SqlClient   'FOR SQL CONNECTION AND COMMAND.
Public Class FrmServices

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
            cmd.CommandText = "insert into db_services(Service_ID,Service_Name,Service_Rate,Service_Reg_Date)values('" & service_txt.Text & "','" & serviceName_txt.Text & "','" & serviceRate_txt.Text & "','" & serviceDate_txt.Value & "')"
            cmd.ExecuteNonQuery()
            welcomemsg.Text = "'Service" & service_txt.Text & "' saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            con.Close()
            getdata()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'this function will autoincrement the ServiceID
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(Service_ID) FROM db_services "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                service_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                service_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Service ID Entry" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'edit function
    Private Sub edit()
        Try
            dbaccessconnection()
            con.Open()
            If serviceName_txt.Text = "" Then
                MessageBox.Show("Empty Service Name")

            Else
                cmd.CommandText = ("UPDATE db_services SET  Service_ID= '" & service_txt.Text & "', Service_Name= '" & serviceName_txt.Text & "',Service_Rate= '" & serviceRate_txt.Text & "',Service_Reg_Date= '" & serviceDate_txt.Value & "' where Service_ID=" & service_txt.Text & "")
                cmd.ExecuteNonQuery()
                welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
                welcomemsg.Text = "'Service" & serviceName_txt.Text & "' update successfully!"
                servicereg_Grid.Refresh()
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
            For i = Me.servicereg_Grid.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from db_services where Service_ID='" & servicereg_Grid.SelectedRows(i).Cells("Service_ID").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.servicereg_Grid.Rows.Remove(Me.servicereg_Grid.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data of services in grid
    Private Sub getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * from db_services ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            servicereg_Grid.DataSource = dt
            servicereg_Grid.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'search service name textbox
    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select * from db_services where Service_Name like '" & TextBox1.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "db_services")
            con.Close()
            servicereg_Grid.DataSource = ds
            servicereg_Grid.DataMember = "db_services"
            servicereg_Grid.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Service Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'this function will empty the textboxes,auto increment service id and get updated data
    Private Sub fun_addnew()
        txtboxid()
        getdata()
        serviceName_txt.Text = ""
        serviceRate_txt.Text = ""
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
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        edit()
        getdata()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        DeleteSelecedRows()
    End Sub

    Private Sub servicereg_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles servicereg_Grid.CellContentClick
        btnsave.Enabled = False
        btndel.Enabled = True
        btnupdate.Enabled = True
    End Sub
    'on mouseclick data migrate to textboxes
    Private Sub servicereg_Grid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles servicereg_Grid.CellMouseClick
        Try
            btnsave.Enabled = False
            btndel.Enabled = True
            btnupdate.Enabled = True
            Me.service_txt.Text = servicereg_Grid.CurrentRow.Cells(0).Value.ToString
            Me.serviceName_txt.Text = servicereg_Grid.CurrentRow.Cells(1).Value.ToString
            Me.serviceRate_txt.Text = servicereg_Grid.CurrentRow.Cells(2).Value.ToString
            Me.serviceDate_txt.Value = servicereg_Grid.CurrentRow.Cells(3).Value.ToString
        Catch ex As Exception
            MsgBox("Failed:GridCick " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'pop up on update button
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
    'popup on delete button
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
    Private Sub FrmServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbaccessconnection()
        txtboxid()
        getdata()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        search_txt()
    End Sub
    Private Sub closee_Click(sender As Object, e As EventArgs) Handles closee.Click
        Me.Dispose()
    End Sub
End Class