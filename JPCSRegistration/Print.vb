Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Print

    Public query As String
    Public head As String

    Private Sub Print_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub


    Private Sub Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        MySQLConn.ConnectionString = connstring
        Load_Courses()

        MySQLConn.Open()




        query = "SELECT * FROM " & eventtable & " order by coyesec, lname"
        head = ""
        Dim header As New ReportParameter("course", head)
        Dim ename As New ReportParameter("eventname", eventname)
        Dim edate As New ReportParameter("eventdate", eventdate)
        Dim etime As New ReportParameter("eventtime", eventtime)
        Dim elocation As New ReportParameter("eventlocation", eventlocation)

        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1

        adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
        adapter.Fill(ds.Tables(0))

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.SetParameters(header)
        ReportViewer1.LocalReport.SetParameters(ename)
        ReportViewer1.LocalReport.SetParameters(edate)
        ReportViewer1.LocalReport.SetParameters(etime)
        ReportViewer1.LocalReport.SetParameters(elocation)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

        'Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        MySQLConn.Close()

    End Sub

    Private Sub ComboBoxConditions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxConditions.SelectedIndexChanged

        If ComboBoxConditions.Text = "All Students" Then
            MySQLConn.ConnectionString = connstring

            MySQLConn.Open()


            query = "SELECT * FROM " & eventtable & " where coyesec!='FACULTY' order by coyesec, lname"
            head = ""
            Dim ename As New ReportParameter("eventname", eventname)
            Dim edate As New ReportParameter("eventdate", eventdate)
            Dim etime As New ReportParameter("eventtime", eventtime)
            Dim elocation As New ReportParameter("eventlocation", eventlocation)
            Dim header As New ReportParameter("course", head)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1

            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSIT" Or ComboBoxConditions.Text = "BSCS" Or ComboBoxConditions.Text = "BSCPE" Then

            MySQLConn.Open()


            head = ComboBoxConditions.Text
            Dim ename As New ReportParameter("eventname", eventname)
            Dim edate As New ReportParameter("eventdate", eventdate)
            Dim etime As New ReportParameter("eventtime", eventtime)
            Dim header As New ReportParameter("course", head)
            query = "SELECT fname, mname, lname, studnum, timein, coyesec from " & eventtable & " where coyesec like '%" & ComboBoxConditions.Text & "%'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()


        ElseIf ComboBoxConditions.Text <> "All Students" Then

            MySQLConn.Open()


            head = ComboBoxConditions.Text
            Dim ename As New ReportParameter("eventname", eventname)
            Dim edate As New ReportParameter("eventdate", eventdate)
            Dim etime As New ReportParameter("eventtime", eventtime)
            Dim header As New ReportParameter("course", head)
            query = "SELECT fname, mname, lname, studnum, timein, coyesec from " & eventtable & " where coyesec=@comboboxcourse"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.SelectCommand.Parameters.AddWithValue("comboboxcourse", ComboBoxConditions.Text)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()

           


        End If


    End Sub
    Public Sub Load_Courses()
        If MySQLConn.State = ConnectionState.Open Then
            MySQLConn.Close()
        End If
        Dim query As String

        Try
            MySQLConn.Open()
            query = "SELECT * FROM courseyearsectionlist"
            comm = New MySqlCommand(query, MySQLConn)
            reader = comm.ExecuteReader
            While reader.Read
                ComboBoxConditions.Items.Remove(reader.GetString("coyesec"))
                ComboBoxConditions.Items.Add(reader.GetString("coyesec"))
            End While
            MySQLConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class