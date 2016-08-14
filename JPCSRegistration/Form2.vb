Imports MySql.Data.MySqlClient

Public Class Form2


    Public charactersAllowed As String = "0123456789-"
    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

    Private Sub txt_studnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_studnum.KeyPress
        If txt_studnum.Text.Contains("-") Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        Else
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-")
        End If
    End Sub

    Private Sub txt_studnum_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txt_studnum.PreviewKeyDown
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            If txt_studnum.Text.Length > 0 Then
                txt_studnum.Text = ""
                txt_studnum.Select(txt_studnum.Text.Length, 0)
            End If
        End If


    End Sub
    Private Sub txt_studnum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_studnum.TextChanged
        'Dim theText As String = txt_studnum.Text
        'Dim Letter As String
        'Dim SelectionIndex As Integer = txt_studnum.SelectionStart
        'Dim Change As Integer

        'For x As Integer = 0 To txt_studnum.Text.Length - 1
        '    Letter = txt_studnum.Text.Substring(x, 1)
        '    If charactersAllowed.Contains(Letter) = False Then
        '        theText = theText.Replace(Letter, String.Empty)
        '        Change = 1
        '    End If
        'Next

        'txt_studnum.Text = theText
        'txt_studnum.Select(SelectionIndex - Change, 0)
        If txt_studnum.Text.Contains("-") = False Then
            If txt_studnum.Text.Length = 2 Then
                txt_studnum.Text = txt_studnum.Text + "-"
            End If

            txt_studnum.Select(txt_studnum.Text.Length, 0)
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CancelButton = btn_cancel
        AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    

        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If

        Dim query As String
        Dim timenow As String = Now.ToString("HH:mm:ss")


        MySQLConn.ConnectionString = connstring

        If String.IsNullOrEmpty(txt_fname.Text) Or String.IsNullOrEmpty(txt_lname.Text) Or String.IsNullOrEmpty(txt_mname.Text) Or String.IsNullOrEmpty(txt_studnum.Text) Or String.IsNullOrEmpty(cbox_cys.Text) Or txt_studnum.Text.Length < 8 Then

            MsgBox("All fields are required to be filled up.", MsgBoxStyle.Critical, "Registration")

        Else
            Try
                MySQLConn.Open()
                query = "SELECT * FROM studentlist where studnum=@inputtedstudentnumber"
                comm = New MySqlCommand(query, MySQLConn)
                comm.Parameters.AddWithValue("inputtedstudentnumber", txt_studnum.Text)
                reader = comm.ExecuteReader
                Dim count As Integer

                While reader.Read
                    count = count + 1
                End While

                If count >= 1 Then
                    MsgBox("The Student Number you have entered is already registered", MsgBoxStyle.Critical, "JPCS Registration")
                Else
                    Try
                        MySQLConn.Close()
                        MySQLConn.Open()
                        query = "INSERT INTO studentlist values(@fname, @mname, @lname, @coyesec, @studnum, @timein)"
                        comm = New MySqlCommand(query, MySQLConn)
                        comm.Parameters.AddWithValue("fname", txt_fname.Text)
                        comm.Parameters.AddWithValue("mname", txt_mname.Text)
                        comm.Parameters.AddWithValue("lname", txt_lname.Text)
                        comm.Parameters.AddWithValue("studnum", txt_studnum.Text)
                        comm.Parameters.AddWithValue("coyesec", cbox_cys.Text)
                        comm.Parameters.AddWithValue("timein", timenow)
                        reader = comm.ExecuteReader
                        MySQLConn.Close()
                        MsgBox("You have succesfully registerd. You may now proceeed to LA Auditorium.", MsgBoxStyle.Information, "Registration")

                        txt_fname.Focus()
                        If cbox_cys.Text.Contains("BSIT") Then
                            Form1.LoadTable_BSIT()
                            Form1.ChangeTabBSIT()
                        ElseIf cbox_cys.Text.Contains("BSCPE") Then
                            Form1.LoadTable_BSCPE()
                            Form1.ChangeTabBSCPE()
                        ElseIf cbox_cys.Text.Contains("BSCS") Then
                            Form1.LoadTable_BSCS()
                            Form1.TabBSCS.Focus()
                            Form1.ChangeTabBSCS()
                        ElseIf cbox_cys.Text.Contains("FACULTY") Then
                            Form1.Load_Faculty()
                            Form1.ChangeTabFACULTY()
                        End If

                        txt_fname.Clear()
                        txt_mname.Clear()
                        txt_lname.Clear()
                        txt_studnum.Clear()
                        cbox_cys.Refresh()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        MySQLConn.Dispose()
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_studnum.Text = ""
    End Sub
End Class