Public Class Server

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AcceptButton = Button1
        tboxServer.Text = My.Settings.server

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Settings.server = tboxServer.Text
        My.Settings.username = tbox_server_username.Text
        My.Settings.password = tbox_server_password.Text
        My.Settings.Save()
        Me.Dispose()
        Form1.Show()
    End Sub
End Class