Public Class Statistics

    Private Sub Statistics_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub population_bscpe()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) as 'Course' FROM jpcsreg.studentlistgeneralassembly2016 WHERE coyesec like '%BSCPE%';"
        Catch ex As Exception

        End Try

    End Sub
End Class