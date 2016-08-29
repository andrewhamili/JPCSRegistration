<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_eventname = New System.Windows.Forms.TextBox()
        Me.tbox_date = New System.Windows.Forms.TextBox()
        Me.tbox_time = New System.Windows.Forms.TextBox()
        Me.tbox_location = New System.Windows.Forms.TextBox()
        Me.tbox_tablename = New System.Windows.Forms.TextBox()
        Me.Panel_newevent = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Panel_event = New System.Windows.Forms.Panel()
        Me.lbl_eventlocation = New System.Windows.Forms.Label()
        Me.lbl_eventtime = New System.Windows.Forms.Label()
        Me.lbl_eventdate = New System.Windows.Forms.Label()
        Me.lbl_eventname = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_useevent = New System.Windows.Forms.Button()
        Me.btn_deleteevent = New System.Windows.Forms.Button()
        Me.btn_editevent = New System.Windows.Forms.Button()
        Me.btn_addevent = New System.Windows.Forms.Button()
        Me.Listbox_existingevents = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_currentevent = New System.Windows.Forms.Label()
        Me.btn_dbaseBackup = New System.Windows.Forms.Button()
        Me.sfd_DatabaseBackup = New System.Windows.Forms.SaveFileDialog()
        Me.Panel_newevent.SuspendLayout()
        Me.Panel_event.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Event name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(125, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(125, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(99, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Database Table Name"
        '
        'tbox_eventname
        '
        Me.tbox_eventname.Location = New System.Drawing.Point(174, 8)
        Me.tbox_eventname.Name = "tbox_eventname"
        Me.tbox_eventname.Size = New System.Drawing.Size(189, 26)
        Me.tbox_eventname.TabIndex = 5
        Me.tbox_eventname.TabStop = False
        '
        'tbox_date
        '
        Me.tbox_date.Location = New System.Drawing.Point(174, 49)
        Me.tbox_date.Name = "tbox_date"
        Me.tbox_date.Size = New System.Drawing.Size(189, 26)
        Me.tbox_date.TabIndex = 6
        Me.tbox_date.TabStop = False
        '
        'tbox_time
        '
        Me.tbox_time.Location = New System.Drawing.Point(174, 86)
        Me.tbox_time.Name = "tbox_time"
        Me.tbox_time.Size = New System.Drawing.Size(189, 26)
        Me.tbox_time.TabIndex = 7
        Me.tbox_time.TabStop = False
        '
        'tbox_location
        '
        Me.tbox_location.Location = New System.Drawing.Point(174, 118)
        Me.tbox_location.Name = "tbox_location"
        Me.tbox_location.Size = New System.Drawing.Size(189, 26)
        Me.tbox_location.TabIndex = 8
        Me.tbox_location.TabStop = False
        '
        'tbox_tablename
        '
        Me.tbox_tablename.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbox_tablename.Location = New System.Drawing.Point(174, 152)
        Me.tbox_tablename.Name = "tbox_tablename"
        Me.tbox_tablename.Size = New System.Drawing.Size(189, 26)
        Me.tbox_tablename.TabIndex = 9
        Me.tbox_tablename.TabStop = False
        '
        'Panel_newevent
        '
        Me.Panel_newevent.Controls.Add(Me.btn_save)
        Me.Panel_newevent.Controls.Add(Me.btn_cancel)
        Me.Panel_newevent.Controls.Add(Me.Label1)
        Me.Panel_newevent.Controls.Add(Me.tbox_tablename)
        Me.Panel_newevent.Controls.Add(Me.Label2)
        Me.Panel_newevent.Controls.Add(Me.tbox_location)
        Me.Panel_newevent.Controls.Add(Me.Label3)
        Me.Panel_newevent.Controls.Add(Me.tbox_time)
        Me.Panel_newevent.Controls.Add(Me.Label4)
        Me.Panel_newevent.Controls.Add(Me.tbox_date)
        Me.Panel_newevent.Controls.Add(Me.Label5)
        Me.Panel_newevent.Controls.Add(Me.tbox_eventname)
        Me.Panel_newevent.Location = New System.Drawing.Point(240, 44)
        Me.Panel_newevent.Name = "Panel_newevent"
        Me.Panel_newevent.Size = New System.Drawing.Size(372, 248)
        Me.Panel_newevent.TabIndex = 10
        Me.Panel_newevent.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(235, 195)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(114, 37)
        Me.btn_save.TabIndex = 11
        Me.btn_save.TabStop = False
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(17, 195)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(115, 37)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Panel_event
        '
        Me.Panel_event.Controls.Add(Me.lbl_eventlocation)
        Me.Panel_event.Controls.Add(Me.lbl_eventtime)
        Me.Panel_event.Controls.Add(Me.lbl_eventdate)
        Me.Panel_event.Controls.Add(Me.lbl_eventname)
        Me.Panel_event.Controls.Add(Me.Label11)
        Me.Panel_event.Controls.Add(Me.Label10)
        Me.Panel_event.Controls.Add(Me.Label9)
        Me.Panel_event.Controls.Add(Me.Label8)
        Me.Panel_event.Controls.Add(Me.btn_useevent)
        Me.Panel_event.Controls.Add(Me.btn_deleteevent)
        Me.Panel_event.Controls.Add(Me.btn_editevent)
        Me.Panel_event.Controls.Add(Me.btn_addevent)
        Me.Panel_event.Controls.Add(Me.Listbox_existingevents)
        Me.Panel_event.Controls.Add(Me.Label7)
        Me.Panel_event.Location = New System.Drawing.Point(12, 52)
        Me.Panel_event.Name = "Panel_event"
        Me.Panel_event.Size = New System.Drawing.Size(533, 248)
        Me.Panel_event.TabIndex = 14
        '
        'lbl_eventlocation
        '
        Me.lbl_eventlocation.AutoSize = True
        Me.lbl_eventlocation.ForeColor = System.Drawing.Color.White
        Me.lbl_eventlocation.Location = New System.Drawing.Point(315, 128)
        Me.lbl_eventlocation.Name = "lbl_eventlocation"
        Me.lbl_eventlocation.Size = New System.Drawing.Size(123, 18)
        Me.lbl_eventlocation.TabIndex = 25
        Me.lbl_eventlocation.Text = "lbl_eventlocation"
        Me.lbl_eventlocation.Visible = False
        '
        'lbl_eventtime
        '
        Me.lbl_eventtime.AutoSize = True
        Me.lbl_eventtime.ForeColor = System.Drawing.Color.White
        Me.lbl_eventtime.Location = New System.Drawing.Point(315, 99)
        Me.lbl_eventtime.Name = "lbl_eventtime"
        Me.lbl_eventtime.Size = New System.Drawing.Size(99, 18)
        Me.lbl_eventtime.TabIndex = 24
        Me.lbl_eventtime.Text = "lbl_eventtime"
        Me.lbl_eventtime.Visible = False
        '
        'lbl_eventdate
        '
        Me.lbl_eventdate.AutoSize = True
        Me.lbl_eventdate.ForeColor = System.Drawing.Color.White
        Me.lbl_eventdate.Location = New System.Drawing.Point(315, 67)
        Me.lbl_eventdate.Name = "lbl_eventdate"
        Me.lbl_eventdate.Size = New System.Drawing.Size(100, 18)
        Me.lbl_eventdate.TabIndex = 23
        Me.lbl_eventdate.Text = "lbl_eventdate"
        Me.lbl_eventdate.Visible = False
        '
        'lbl_eventname
        '
        Me.lbl_eventname.AutoSize = True
        Me.lbl_eventname.ForeColor = System.Drawing.Color.White
        Me.lbl_eventname.Location = New System.Drawing.Point(315, 39)
        Me.lbl_eventname.Name = "lbl_eventname"
        Me.lbl_eventname.Size = New System.Drawing.Size(108, 18)
        Me.lbl_eventname.TabIndex = 22
        Me.lbl_eventname.Text = "lbl_eventname"
        Me.lbl_eventname.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(236, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 18)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(236, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(236, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(236, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Name"
        '
        'btn_useevent
        '
        Me.btn_useevent.Location = New System.Drawing.Point(16, 135)
        Me.btn_useevent.Name = "btn_useevent"
        Me.btn_useevent.Size = New System.Drawing.Size(91, 40)
        Me.btn_useevent.TabIndex = 17
        Me.btn_useevent.TabStop = False
        Me.btn_useevent.Text = "Use Event"
        Me.btn_useevent.UseVisualStyleBackColor = True
        '
        'btn_deleteevent
        '
        Me.btn_deleteevent.Location = New System.Drawing.Point(113, 181)
        Me.btn_deleteevent.Name = "btn_deleteevent"
        Me.btn_deleteevent.Size = New System.Drawing.Size(104, 49)
        Me.btn_deleteevent.TabIndex = 16
        Me.btn_deleteevent.TabStop = False
        Me.btn_deleteevent.Text = "Delete Event"
        Me.btn_deleteevent.UseVisualStyleBackColor = True
        '
        'btn_editevent
        '
        Me.btn_editevent.Location = New System.Drawing.Point(16, 181)
        Me.btn_editevent.Name = "btn_editevent"
        Me.btn_editevent.Size = New System.Drawing.Size(91, 49)
        Me.btn_editevent.TabIndex = 15
        Me.btn_editevent.TabStop = False
        Me.btn_editevent.Text = "Edit Event"
        Me.btn_editevent.UseVisualStyleBackColor = True
        '
        'btn_addevent
        '
        Me.btn_addevent.Location = New System.Drawing.Point(113, 135)
        Me.btn_addevent.Name = "btn_addevent"
        Me.btn_addevent.Size = New System.Drawing.Size(104, 40)
        Me.btn_addevent.TabIndex = 14
        Me.btn_addevent.TabStop = False
        Me.btn_addevent.Text = "Add Event"
        Me.btn_addevent.UseVisualStyleBackColor = True
        '
        'Listbox_existingevents
        '
        Me.Listbox_existingevents.FormattingEnabled = True
        Me.Listbox_existingevents.ItemHeight = 18
        Me.Listbox_existingevents.Location = New System.Drawing.Point(16, 35)
        Me.Listbox_existingevents.Name = "Listbox_existingevents"
        Me.Listbox_existingevents.Size = New System.Drawing.Size(201, 94)
        Me.Listbox_existingevents.TabIndex = 13
        Me.Listbox_existingevents.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Existing Events"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Current Event"
        '
        'lbl_currentevent
        '
        Me.lbl_currentevent.AutoSize = True
        Me.lbl_currentevent.ForeColor = System.Drawing.Color.White
        Me.lbl_currentevent.Location = New System.Drawing.Point(150, 21)
        Me.lbl_currentevent.Name = "lbl_currentevent"
        Me.lbl_currentevent.Size = New System.Drawing.Size(116, 18)
        Me.lbl_currentevent.TabIndex = 12
        Me.lbl_currentevent.Text = "lbl_currentevent"
        '
        'btn_dbaseBackup
        '
        Me.btn_dbaseBackup.Location = New System.Drawing.Point(47, 329)
        Me.btn_dbaseBackup.Name = "btn_dbaseBackup"
        Me.btn_dbaseBackup.Size = New System.Drawing.Size(182, 32)
        Me.btn_dbaseBackup.TabIndex = 15
        Me.btn_dbaseBackup.Text = "Backup Database"
        Me.btn_dbaseBackup.UseVisualStyleBackColor = True
        '
        'sfd_DatabaseBackup
        '
        Me.sfd_DatabaseBackup.FileName = "JPCSRegistration"
        Me.sfd_DatabaseBackup.Filter = "7zip Encrypted Archive (*.7z)|*.7z"
        Me.sfd_DatabaseBackup.InitialDirectory = "%userprofile%\Desktop\Database\"
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 382)
        Me.Controls.Add(Me.btn_dbaseBackup)
        Me.Controls.Add(Me.Panel_event)
        Me.Controls.Add(Me.lbl_currentevent)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel_newevent)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Configuration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuration"
        Me.Panel_newevent.ResumeLayout(False)
        Me.Panel_newevent.PerformLayout()
        Me.Panel_event.ResumeLayout(False)
        Me.Panel_event.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbox_eventname As System.Windows.Forms.TextBox
    Friend WithEvents tbox_date As System.Windows.Forms.TextBox
    Friend WithEvents tbox_time As System.Windows.Forms.TextBox
    Friend WithEvents tbox_location As System.Windows.Forms.TextBox
    Friend WithEvents tbox_tablename As System.Windows.Forms.TextBox
    Friend WithEvents Panel_newevent As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_currentevent As System.Windows.Forms.Label
    Friend WithEvents Listbox_existingevents As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel_event As System.Windows.Forms.Panel
    Friend WithEvents btn_useevent As System.Windows.Forms.Button
    Friend WithEvents btn_deleteevent As System.Windows.Forms.Button
    Friend WithEvents btn_editevent As System.Windows.Forms.Button
    Friend WithEvents btn_addevent As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_eventlocation As Label
    Friend WithEvents lbl_eventtime As Label
    Friend WithEvents lbl_eventdate As Label
    Friend WithEvents lbl_eventname As Label
    Friend WithEvents btn_dbaseBackup As System.Windows.Forms.Button
    Friend WithEvents sfd_DatabaseBackup As System.Windows.Forms.SaveFileDialog
End Class
