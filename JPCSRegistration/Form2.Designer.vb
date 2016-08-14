<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_studnum = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbox_cys = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Student Number"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(252, 14)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(234, 30)
        Me.txt_fname.TabIndex = 0
        '
        'txt_mname
        '
        Me.txt_mname.Location = New System.Drawing.Point(252, 51)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(234, 30)
        Me.txt_mname.TabIndex = 1
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(252, 88)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(234, 30)
        Me.txt_lname.TabIndex = 2
        '
        'txt_studnum
        '
        Me.txt_studnum.Location = New System.Drawing.Point(252, 124)
        Me.txt_studnum.MaxLength = 8
        Me.txt_studnum.Name = "txt_studnum"
        Me.txt_studnum.Size = New System.Drawing.Size(234, 30)
        Me.txt_studnum.TabIndex = 3
        '
        'btn_cancel
        '
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(15, 220)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(132, 54)
        Me.btn_cancel.TabIndex = 8
        Me.btn_cancel.TabStop = False
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(352, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 54)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Course, Year and Section"
        '
        'cbox_cys
        '
        Me.cbox_cys.AutoCompleteCustomSource.AddRange(New String() {"AIT-1A", "AIT-2A", "BSIT-3A", "BSIT-4A", "BSCPE-1A", "BSCPE-2A", "BSCPE-3A", "BSCPE-4A", "ACS-1A", "ACS-2A", "BSCS-3A", "BSCS-4A", "FACULTY"})
        Me.cbox_cys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_cys.FormattingEnabled = True
        Me.cbox_cys.Items.AddRange(New Object() {"BSIT-1A", "BSIT-2A", "BSIT-3A", "BSIT-4A", "BSCPE-1A", "BSCPE-2A", "BSCPE-3A", "BSCPE-4A", "BSCPE-5A", "BSCS-1A", "BSCS-2A", "BSCS-3A", "BSCS-4A", "FACULTY"})
        Me.cbox_cys.Location = New System.Drawing.Point(252, 162)
        Me.cbox_cys.Name = "cbox_cys"
        Me.cbox_cys.Size = New System.Drawing.Size(234, 31)
        Me.cbox_cys.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbox_cys)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_studnum)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents txt_studnum As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbox_cys As System.Windows.Forms.ComboBox
End Class
