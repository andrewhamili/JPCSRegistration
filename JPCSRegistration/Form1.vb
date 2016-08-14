Imports MySql.Data.MySqlClient

Public Class Form1

    Public timer As Integer = 0
    Public dbdataset As New DataTable
    Public BSITFocus As Boolean = False
    Public BSCSFocus As Boolean = False
    Public BSCPEFocus As Boolean = False

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim a As Boolean = False
        Dim ans As String

        ans = InputBox("Enter the secret phrase to close the Registratioh form", "Exit...", "I do not know")
        If ans.IndexOf("charish", 0, StringComparison.CurrentCultureIgnoreCase) > -1 Then

            e.Cancel = False
        Else
            e.Cancel = True

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            MsgBox("Succesfully Connected to the database")
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox("There was an error connecting to the Database")
            End
        End Try
        Try
            MySQLConn.Open()
            query = "SELECT * FROM existingevents WHERE status='A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                eventname = reader.GetString("eventname")
                eventdate = reader.GetString("date")
                eventtime = reader.GetString("time")
                eventlocation = reader.GetString("location")
                eventtable = reader.GetString("eventtable")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        lbl_eventname.Text = eventname
        lbl_eventdate.Text = eventdate
        lbl_eventtime.Text = eventtime

        LoadTable_BSCPE()
        LoadTable_BSCS()
        LoadTable_BSIT()
        Load_Faculty()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If timer = 5 Then
            If Button1.BackColor = Color.Green Then
                Button1.BackColor = Color.Orange
            ElseIf Button1.BackColor = Color.Orange Then
                Button1.BackColor = Color.Red
            Else
                Button1.BackColor = Color.Green
            End If
            timer = 0
        End If
        timer = timer + 1

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.ShowDialog()

    End Sub

    Public Sub LoadTable_BSIT()

        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', studnum AS'Student ID', timein AS Time from " & eventtable & " where coyesec like 'BSIT%' ORDER BY timein DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridBSIT.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub LoadTable_BSCS()

        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter

        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', studnum AS'Student ID', timein AS Time from " & eventtable & " WHERE coyesec like 'BSCS%' ORDER BY timein DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridBSCS.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub LoadTable_BSCPE()

        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', studnum AS'Student ID', timein AS Time from " & eventtable & " where coyesec like 'BSCPE%' ORDER BY timein DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridBSCPE.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub Load_Faculty()
        dbdataset.Clear()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim adapter As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim query As String

        Try

            MySQLConn.Open()
            query = "SELECT lname AS 'Last Name', fname AS 'First Name', mname AS 'Middle Name', studnum AS'Student ID', timein AS Time from " & eventtable & " WHERE coyesec='FACULTY' ORDER BY timein DESC"
            comm = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand = comm
            adapter.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridFaculty.DataSource = bsource
            adapter.Update(dbdataset)



            MySQLConn.Close()




        Catch ex As MySqlException

            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Private Sub TabBSIT_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSIT.Enter
        LoadTable_BSIT()
        BSITFocus = True
    End Sub

    Private Sub TabBSCS_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSCS.Enter
        LoadTable_BSCS()
        BSCSFocus = True
    End Sub

    Private Sub TabBSCPE_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSCPE.Enter
        LoadTable_BSCPE()
        BSCPEFocus = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Cursor = Cursors.WaitCursor
        Print.Show()
        Me.Hide()
        Cursor = Cursors.Default

    End Sub

    Private Sub TabFACULTY_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabFACULTY.Enter
        Load_Faculty()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub TabBSIT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSIT.Leave
        BSITFocus = False
    End Sub

    Private Sub TabBSCPE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSCPE.Leave
        BSCPEFocus = False
    End Sub

    Private Sub TabBSCS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabBSCS.Leave
        BSCSFocus = False
    End Sub
    Public Sub ChangeTabBSIT()
        TabControl1.SelectedTab = TabBSIT
    End Sub
    Public Sub ChangeTabBSCS()
        TabControl1.SelectedTab = TabBSCS
    End Sub
    Public Sub ChangeTabBSCPE()
        TabControl1.SelectedTab = TabBSCPE
    End Sub
    Public Sub ChangeTabFACULTY()
        TabControl1.SelectedTab = TabFACULTY
    End Sub

    Private Sub DataGridBSCPE_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridBSCPE.CellDoubleClick
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Dim studentnum As String
        Dim query As String

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridBSCPE.Rows(e.RowIndex)

            studentnum = row.Cells("Student ID").Value.ToString


        End If

        Dim ans As Integer

        ans = MsgBox("Sure to delete this Student Record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "JPCS Registration System")
        If ans = 6 Then
            Try
                MySQLConn.Open()
                query = "DELETE FROM studentlist WHERE studnum=@inputtedstudentnumber"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("inputtedstudentnumber", studentnum)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Student " & studentnum & " has been successfully deleted to the Database!", MsgBoxStyle.Information, "JPCS Registration")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        LoadTable_BSCPE()
    End Sub

    Private Sub DataGridFaculty_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFaculty.CellDoubleClick
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Dim studentnum As String
        Dim query As String

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridFaculty.Rows(e.RowIndex)

            studentnum = row.Cells("Student ID").Value.ToString


        End If

        Dim ans As Integer

        ans = MsgBox("Sure to delete this Student Record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "JPCS Registration System")
        If ans = 6 Then
            Try
                MySQLConn.Open()
                query = "DELETE FROM studentlist WHERE studnum=@inputtedstudentnumber"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("inputtedstudentnumber", studentnum)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Student " & studentnum & " has been successfully deleted to the Database!", MsgBoxStyle.Information, "JPCS Registration")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        Load_Faculty()
    End Sub

    Private Sub DataGridBSIT_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridBSIT.CellDoubleClick
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Dim studentnum As String
        Dim query As String

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridBSIT.Rows(e.RowIndex)

            studentnum = row.Cells("Student ID").Value.ToString


        End If

        Dim ans As Integer

        ans = MsgBox("Sure to delete this Student Record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "JPCS Registration System")
        If ans = 6 Then
            Try
                MySQLConn.Open()
                query = "DELETE FROM studentlist WHERE studnum=@inputtedstudentnumber"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("inputtedstudentnumber", studentnum)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Student " & studentnum & " has been successfully deleted to the Database!", MsgBoxStyle.Information, "JPCS Registration")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        LoadTable_BSIT()

    End Sub

    Private Sub DataGridBSCS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridBSCS.CellDoubleClick
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring

        Dim studentnum As String
        Dim query As String

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = DataGridBSCS.Rows(e.RowIndex)

            studentnum = row.Cells("Student ID").Value.ToString


        End If

        Dim ans As Integer

        ans = MsgBox("Sure to delete this Student Record?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "JPCS Registration System")
        If ans = 6 Then
            Try
                MySQLConn.Open()
                query = "DELETE FROM studentlist WHERE studnum=@inputtedstudentnumber"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("inputtedstudentnumber", studentnum)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("Student " & studentnum & " has been successfully deleted to the Database!", MsgBoxStyle.Information, "JPCS Registration")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
        LoadTable_BSCS()
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Configuration.Show()
        Me.Hide()
    End Sub
End Class
