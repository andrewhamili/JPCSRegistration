Imports MySql.Data.MySqlClient
Class Statistics

    Private Sub Statistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        population_bsit1a()
        population_bsit2a()
        population_bsit3a()
        population_bsit4a()

        population_bscs1a()
        population_bscs2a()
        population_bscs3a()
        population_bscs4a()

        population_bscpe1a()
        population_bscpe2a()
        population_bscpe3a()
        population_bscpe4a()
        population_bscpe5a()
        lbl_total.Text = CInt(lbl_bscpe_total.Text) + CInt(lbl_bsit_total.Text) + CInt(lbl_bscs_total.Text)
    End Sub
    Public Sub population_bsit1a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSIT-1A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bsit1a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try

    End Sub
    Public Sub population_bsit2a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSIT-2A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bsit2a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub population_bsit3a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSIT-3A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bsit3a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub population_bsit4a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSIT-4A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bsit4a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        lbl_bsit_total.Text = CInt(lbl_bsit1a.Text) + CInt(lbl_bsit2a.Text) + CInt(lbl_bsit3a.Text) + CInt(lbl_bsit4a.Text)
    End Sub

    Public Sub population_bscs1a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCS-1A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscs1a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub population_bscs2a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCS-2A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscs2a.Text = reader.GetString("count")
            End While

            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub population_bscs3a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCS-3A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscs3a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub

    Public Sub population_bscs4a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCS-4A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscs4a.Text = reader.GetString("count")
            End While

            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        lbl_bscs_total.Text = CInt(lbl_bscs1a.Text) + CInt(lbl_bscs2a.Text) + CInt(lbl_bscs3a.Text) + CInt(lbl_bscs4a.Text)
    End Sub


    Public Sub population_bscpe1a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCPE-1A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscpe1a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub population_bscpe2a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCPE-2A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscpe2a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub population_bscpe3a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCPE-3A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscpe3a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub population_bscpe4a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCPE-4A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscpe4a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
    End Sub
    Public Sub population_bscpe5a()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        MySQLConn.ConnectionString = connstring
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT count(coyesec) AS  count FROM " & eventtable & " WHERE  coyesec='BSCPE-5A'"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                lbl_bscpe5a.Text = reader.GetString("count")
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySQLConn.Dispose()
        End Try
        lbl_bscpe_total.Text = CInt(lbl_bscpe1a.Text) + CInt(lbl_bscpe2a.Text) + CInt(lbl_bscpe3a.Text) + CInt(lbl_bscpe4a.Text) + CInt(lbl_bscpe5a.Text)

    End Sub
End Class