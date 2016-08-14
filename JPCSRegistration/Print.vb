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

        MySQLConn.Open()




        query = "SELECT * FROM studentlist order by coyesec, lname"
        head = ""
        Dim header As New ReportParameter("course", head)
        Dim adapter As New MySqlDataAdapter
        Dim ds As New DataSet1

        adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
        adapter.Fill(ds.Tables(0))

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.SetParameters(header)
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




            query = "SELECT * FROM studentlist where coyesec!='FACULTY' order by coyesec, lname"
            head = ""
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

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSIT-4A" Then
            MySQLConn.Open()


            head = "BSIT-4A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT fname, mname, lname, studnum, timein from studentlist where coyesec='BSIT-4A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSIT-3A" Then
            MySQLConn.Open()


            head = "BSIT-3A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSIT-3A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSIT-2A" Then
            MySQLConn.Open()


            head = "BSIT-2A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSIT-2A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSIT-1A" Then
            MySQLConn.Open()


            head = "BSIT-1A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSIT-1A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCS-4A" Then
            MySQLConn.Open()


            head = "BSCS-4A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCS-4A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCS-3A" Then
            MySQLConn.Open()


            head = "BSCS-3A"
            query = "SELECT * FROM studentlist where coyesec='BSCS-3A'"
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

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCS-2A" Then
            MySQLConn.Open()


            head = "BSCS-2A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCS-2A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCS-1A" Then
            MySQLConn.Open()


            head = "BSCS-1A"
            query = "SELECT * FROM studentlist where coyesec='BSCS-1A'"
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

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCPE-5A" Then
            MySQLConn.Open()


            head = "BSCPE-5A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCPE-5A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCPE-4A" Then
            MySQLConn.Open()


            head = "BSCPE-4A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCPE-4A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCPE-3A" Then
            MySQLConn.Open()


            head = "BSCPE-3A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCPE-3A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCPE-2A" Then
            MySQLConn.Open()


            head = "BSCPE-2A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCPE-2A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "BSCPE-1A" Then
            MySQLConn.Open()


            head = "BSCPE-1A"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec='BSCPE-1A'"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "All BSIT" Then
            MySQLConn.Open()


            head = "BSIT"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec LIKE 'BSIT%' ORDER BY lname ASC"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "All BSCS" Then
            MySQLConn.Open()


            head = "BSCS"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec LIKE 'BSCS%' ORDER BY lname ASC"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "All BSCPE" Then
            MySQLConn.Open()


            head = "BSCPE"
            Dim header As New ReportParameter("course", head)
            query = "SELECT * FROM studentlist where coyesec LIKE 'BSCPE%' ORDER BY lname ASC"
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet1
            adapter.SelectCommand = New MySqlCommand(query, MySQLConn)
            adapter.Fill(ds.Tables(0))


            ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.SetParameters(header)
            ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()
        ElseIf ComboBoxConditions.Text = "All Faculty" Then
            MySQLConn.ConnectionString = connstring

            MySQLConn.Open()




            query = "SELECT * FROM studentlist where coyesec='FACULTY' order by coyesec, lname"
            head = "FACULTY"
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

            'Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            MySQLConn.Close()


        End If


    End Sub
End Class