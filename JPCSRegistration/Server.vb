Public Class Server


    Public CheckServer As Boolean = True

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        AcceptButton = Button1
        tboxServer.Text = My.Settings.server

        MySQLConn.ConnectionString = connstring

        Try
            MySQLConn.Open()
            MySQLConn.Close()
            Me.Dispose()
            Form1.Show()
        Catch ex As Exception
            MsgBox("Database Server Authentication needed!", MsgBoxStyle.Information, "Junior Philippine Computer Society")
            CheckServer = False
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Settings.server = tboxServer.Text
        My.Settings.username = tbox_server_username.Text
        My.Settings.password = tbox_server_password.Text
        My.Settings.Save()
        If CheckServer = False Then
            Application.Restart()
        End If
        Me.Dispose()
        Form1.Show()
    End Sub

    Public Sub Check_old_data()
    End Sub
End Class