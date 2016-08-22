Public Class Server

    Private Sub Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim pName As String = "mysqld.exe"
        'Dim psList() As Process
        'Dim MySQLServerCheck As Boolean = False
        'Try
        '    psList = Process.GetProcessesByName(pName)

        '    For Each p As Process In psList
        '        If (pName = p.ProcessName) Then
        '            MsgBox("Process Found")
        '            MySQLServerCheck = True
        '        End If
        '    Next p

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'If MySQLServerCheck = True Then
        'Else
        '    MsgBox("The MySQL Server(mysqld.exe does not exist in the list of running processes in this Computer. This System cannot run without it. System will exit now", MsgBoxStyle.Critical, "Junior Philippine Computer Society")
        'End If

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