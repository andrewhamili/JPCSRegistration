Imports MySql.Data.MySqlClient
Public Class Configuration

    Public pendingeventtablename As String

    Private Sub Configuration_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_currentevent.Text = eventname
        Load_ExistingEvents()
    End Sub

    Public Sub Load_ExistingEvents()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            query = "SELECT eventname FROM existingevents"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                Listbox_existingevents.Items.Remove(reader.GetString("eventname"))
                Listbox_existingevents.Items.Add(reader.GetString("eventname"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_addevent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addevent.Click
        Panel_newevent.Visible = True
        Panel_event.Visible = False
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Panel_newevent.Visible = False
        Panel_event.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        Dim charactersAllowed As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_"
        Dim EventNameAndTableNameFusion As String = tbox_tablename.Text.ToLower + tbox_eventname.Text.ToLower

        Dim newtablename As String = EventNameAndTableNameFusion
        Dim Letter As String
        Dim Change As Integer

        For x As Integer = 0 To EventNameAndTableNameFusion.Length - 1
            Letter = EventNameAndTableNameFusion.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                newtablename = newtablename.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        MySQLConn.ConnectionString = connstring
        Try
            MySQLConn.Open()
            query = "SELECT * FROM existingevents WHERE eventname=@eventname"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("eventname", tbox_eventname.Text)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count += 1
            End While
            If count > 0 Then
                MsgBox("The Event exists!. Please use a more specific Event Name", MsgBoxStyle.Critical, "")
            Else
                MySQLConn.Close()
                MySQLConn.Open()
                query = "INSERT INTO existingevents VALUES(@eventname, @eventdate, @eventtime, @eventlocation, @eventtable, 'I');CREATE TABLE " & newtablename & " like referencetableregistration"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("eventname", tbox_eventname.Text)
                comm.Parameters.AddWithValue("eventdate", tbox_date.Text)
                comm.Parameters.AddWithValue("eventtime", tbox_time.Text)
                comm.Parameters.AddWithValue("eventlocation", tbox_location.Text)
                comm.Parameters.AddWithValue("eventtable", newtablename)
                reader = comm.ExecuteReader
                MySQLConn.Close()
                MsgBox("The event has been created successfully", MsgBoxStyle.Information, "Junior Philippine Computer Society")
                Load_ExistingEvents()
                Panel_newevent.Visible = False
                Panel_event.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_useevent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_useevent.Click
        If Listbox_existingevents.Text <> eventname Then
            If Listbox_existingevents.Text <> "" Then
                If MySQLConn.State = ConnectionState.Open Then
                    MySQLConn.Close()
                End If
                Dim query As String
                Try
                    MySQLConn.Open()
                    query = "UPDATE existingevents SET status='I';UPDATE existingevents SET status='A' WHERE eventname=@selectedevent"
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("selectedevent", Listbox_existingevents.Text)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("The Current event has been successfully changed. The System Needs to be closed for the New event to be applied. You can Launch the System after it has automatically closed", MsgBoxStyle.Information, "Junior Philippine Computer Society")
                    End
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    MySQLConn.Dispose()


                End Try
            Else
                MsgBox("You have not selected an event!", MsgBoxStyle.Exclamation, "Junior Philippine Computer Society")
            End If
        Else
            MsgBox("The selected event is already the active event!", MsgBoxStyle.Critical, "Junior Philippine Computer Society")
        End If


    End Sub

    Private Sub btn_deleteevent_Click(sender As Object, e As EventArgs) Handles btn_deleteevent.Click
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        If Listbox_existingevents.Text <> "" Then
            Dim query As String
            If Listbox_existingevents.Text <> eventname Then
                Try
                    MySQLConn.Open()
                    query = "DELETE FROM existingevents WHERE eventname=@selectedevent;DROP TABLE " & pendingeventtablename & ""
                    comm = New MySqlCommand(query, MySQLConn)
                    comm.Parameters.AddWithValue("selectedevent", Listbox_existingevents.Text)
                    reader = comm.ExecuteReader
                    MySQLConn.Close()
                    MsgBox("The Event has been successfully deleted.")
                    Listbox_existingevents.Items.Remove(Listbox_existingevents.Text)
                    lbl_eventname.Visible = False
                    lbl_eventdate.Visible = False
                    lbl_eventtime.Visible = False
                    lbl_eventlocation.Visible = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("You cannot delete an active event!", MsgBoxStyle.Critical, "Junior Philippine Computer Society")
            End If
        Else
            MsgBox("You have not selected an event!", MsgBoxStyle.Exclamation, "Junior Philippine Computer Society")
        End If

    End Sub

    Private Sub Listbox_existingevents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox_existingevents.SelectedIndexChanged
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String
        Try
            MySQLConn.Open()
            query = "SELECT * FROM existingevents WHERE eventname=@selectedevent"
            comm = New MySqlCommand(query, MySQLConn)
            comm.Parameters.AddWithValue("selectedevent", Listbox_existingevents.Text)
            reader = comm.ExecuteReader
            While reader.Read
                lbl_eventname.Text = reader.GetString("eventname")
                lbl_eventdate.Text = reader.GetString("date")
                lbl_eventtime.Text = reader.GetString("time")
                lbl_eventlocation.Text = reader.GetString("location")
                pendingeventtablename = reader.GetString("eventtable")
            End While
            MySQLConn.Close()
            lbl_eventname.Visible = True
            lbl_eventdate.Visible = True
            lbl_eventtime.Visible = True
            lbl_eventlocation.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_dbaseBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dbaseBackup.Click
        'Dim filename As String
        'If sfd_DatabaseBackup.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
        '    filename = sfd_DatabaseBackup.FileName
        '    Database_Backup(filename)
        'End If
        Database_Backup()

    End Sub
    Public Sub Database_Backup()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        MySQLConn.ConnectionString = connstring
        comm = New MySqlCommand()
        comm.Connection = MySQLConn
        Dim mb As New MySqlBackup(comm)
        Try
            MySQLConn.Open()
            mb.ExportInfo.AddCreateDatabase = True
            mb.ExportToFile("jpcsreg.sql")
            MySQLConn.Close()
            MsgBox("The Database was successfully exported.", MsgBoxStyle.Information, "Junior Philippine Computer Society")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Junior Philippine Computer Society")
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
End Class