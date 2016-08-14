Imports MySql.Data.MySqlClient
Public Class Configuration

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
End Class