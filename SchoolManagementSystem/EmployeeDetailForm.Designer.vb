<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetailForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetailForm))
        Me.btn_e_cancel = New System.Windows.Forms.Button()
        Me.btn_e_print = New System.Windows.Forms.Button()
        Me.RB_e_female = New System.Windows.Forms.RadioButton()
        Me.RB_e_male = New System.Windows.Forms.RadioButton()
        Me.e_picbox = New System.Windows.Forms.PictureBox()
        Me.date_e_DOB = New System.Windows.Forms.DateTimePicker()
        Me.date_e_JD = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_e_present_address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_e_permanent_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_e_f_name = New System.Windows.Forms.TextBox()
        Me.txt_e_mobile_no = New System.Windows.Forms.TextBox()
        Me.txt_e_CNIC = New System.Windows.Forms.TextBox()
        Me.txt_e_salary = New System.Windows.Forms.TextBox()
        Me.txt_e_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_e_martial_status = New System.Windows.Forms.TextBox()
        Me.txt_e_nationality = New System.Windows.Forms.TextBox()
        Me.txt_e_BP = New System.Windows.Forms.TextBox()
        Me.txt_e_city = New System.Windows.Forms.TextBox()
        Me.txt_e_religion = New System.Windows.Forms.TextBox()
        Me.combo_e_id = New System.Windows.Forms.ComboBox()
        Me.txt_e_type = New System.Windows.Forms.TextBox()
        CType(Me.e_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_e_cancel
        '
        Me.btn_e_cancel.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_e_cancel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_e_cancel.FlatAppearance.BorderSize = 3
        Me.btn_e_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_e_cancel.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e_cancel.Location = New System.Drawing.Point(879, 553)
        Me.btn_e_cancel.Name = "btn_e_cancel"
        Me.btn_e_cancel.Size = New System.Drawing.Size(114, 37)
        Me.btn_e_cancel.TabIndex = 143
        Me.btn_e_cancel.Text = "Cancel"
        Me.btn_e_cancel.UseVisualStyleBackColor = False
        '
        'btn_e_print
        '
        Me.btn_e_print.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_e_print.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_e_print.FlatAppearance.BorderSize = 3
        Me.btn_e_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_e_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_e_print.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_e_print.Location = New System.Drawing.Point(743, 553)
        Me.btn_e_print.Name = "btn_e_print"
        Me.btn_e_print.Size = New System.Drawing.Size(114, 37)
        Me.btn_e_print.TabIndex = 142
        Me.btn_e_print.Text = "Print"
        Me.btn_e_print.UseVisualStyleBackColor = False
        '
        'RB_e_female
        '
        Me.RB_e_female.AutoSize = True
        Me.RB_e_female.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_e_female.Location = New System.Drawing.Point(175, 566)
        Me.RB_e_female.Name = "RB_e_female"
        Me.RB_e_female.Size = New System.Drawing.Size(75, 20)
        Me.RB_e_female.TabIndex = 137
        Me.RB_e_female.TabStop = True
        Me.RB_e_female.Text = "Female"
        Me.RB_e_female.UseVisualStyleBackColor = True
        '
        'RB_e_male
        '
        Me.RB_e_male.AutoSize = True
        Me.RB_e_male.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_e_male.Location = New System.Drawing.Point(98, 566)
        Me.RB_e_male.Name = "RB_e_male"
        Me.RB_e_male.Size = New System.Drawing.Size(58, 20)
        Me.RB_e_male.TabIndex = 136
        Me.RB_e_male.TabStop = True
        Me.RB_e_male.Text = "Male"
        Me.RB_e_male.UseVisualStyleBackColor = True
        '
        'e_picbox
        '
        Me.e_picbox.BackColor = System.Drawing.Color.Transparent
        Me.e_picbox.Image = CType(resources.GetObject("e_picbox.Image"), System.Drawing.Image)
        Me.e_picbox.Location = New System.Drawing.Point(743, 74)
        Me.e_picbox.Name = "e_picbox"
        Me.e_picbox.Size = New System.Drawing.Size(163, 169)
        Me.e_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.e_picbox.TabIndex = 112
        Me.e_picbox.TabStop = False
        '
        'date_e_DOB
        '
        Me.date_e_DOB.Enabled = False
        Me.date_e_DOB.Location = New System.Drawing.Point(417, 216)
        Me.date_e_DOB.Name = "date_e_DOB"
        Me.date_e_DOB.Size = New System.Drawing.Size(250, 23)
        Me.date_e_DOB.TabIndex = 111
        '
        'date_e_JD
        '
        Me.date_e_JD.Enabled = False
        Me.date_e_JD.Location = New System.Drawing.Point(98, 143)
        Me.date_e_JD.Name = "date_e_JD"
        Me.date_e_JD.Size = New System.Drawing.Size(250, 23)
        Me.date_e_JD.TabIndex = 108
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(413, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 19)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Salary"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(739, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 19)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Employee Image"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(413, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 19)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Employee Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(413, 473)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 19)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = "Religion"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(739, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 19)
        Me.Label17.TabIndex = 155
        Me.Label17.Text = "Present Address"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(739, 425)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 19)
        Me.Label16.TabIndex = 154
        Me.Label16.Text = "Permanent Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(413, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 19)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Employee Martial Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(413, 402)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 19)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(413, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Mobile No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(413, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Date of Birth"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(94, 544)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 19)
        Me.Label18.TabIndex = 150
        Me.Label18.Text = "Gender"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(94, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 19)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Birth Place"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(94, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 19)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Father Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(94, 402)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 19)
        Me.Label12.TabIndex = 160
        Me.Label12.Text = "Nationality"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(94, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "CNIC No"
        '
        'txt_e_present_address
        '
        Me.txt_e_present_address.Enabled = False
        Me.txt_e_present_address.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_present_address.Location = New System.Drawing.Point(743, 326)
        Me.txt_e_present_address.Multiline = True
        Me.txt_e_present_address.Name = "txt_e_present_address"
        Me.txt_e_present_address.ReadOnly = True
        Me.txt_e_present_address.Size = New System.Drawing.Size(250, 60)
        Me.txt_e_present_address.TabIndex = 139
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(94, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Full Name"
        '
        'txt_e_permanent_address
        '
        Me.txt_e_permanent_address.Enabled = False
        Me.txt_e_permanent_address.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_permanent_address.Location = New System.Drawing.Point(743, 447)
        Me.txt_e_permanent_address.Multiline = True
        Me.txt_e_permanent_address.Name = "txt_e_permanent_address"
        Me.txt_e_permanent_address.ReadOnly = True
        Me.txt_e_permanent_address.Size = New System.Drawing.Size(250, 60)
        Me.txt_e_permanent_address.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 19)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Joining Date"
        '
        'txt_e_f_name
        '
        Me.txt_e_f_name.Enabled = False
        Me.txt_e_f_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_f_name.Location = New System.Drawing.Point(98, 355)
        Me.txt_e_f_name.Name = "txt_e_f_name"
        Me.txt_e_f_name.ReadOnly = True
        Me.txt_e_f_name.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_f_name.TabIndex = 115
        '
        'txt_e_mobile_no
        '
        Me.txt_e_mobile_no.Enabled = False
        Me.txt_e_mobile_no.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_mobile_no.Location = New System.Drawing.Point(417, 284)
        Me.txt_e_mobile_no.Name = "txt_e_mobile_no"
        Me.txt_e_mobile_no.ReadOnly = True
        Me.txt_e_mobile_no.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_mobile_no.TabIndex = 114
        '
        'txt_e_CNIC
        '
        Me.txt_e_CNIC.Enabled = False
        Me.txt_e_CNIC.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_CNIC.Location = New System.Drawing.Point(98, 284)
        Me.txt_e_CNIC.Name = "txt_e_CNIC"
        Me.txt_e_CNIC.ReadOnly = True
        Me.txt_e_CNIC.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_CNIC.TabIndex = 113
        '
        'txt_e_salary
        '
        Me.txt_e_salary.Enabled = False
        Me.txt_e_salary.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_salary.Location = New System.Drawing.Point(417, 141)
        Me.txt_e_salary.Name = "txt_e_salary"
        Me.txt_e_salary.ReadOnly = True
        Me.txt_e_salary.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_salary.TabIndex = 109
        '
        'txt_e_name
        '
        Me.txt_e_name.Enabled = False
        Me.txt_e_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_name.Location = New System.Drawing.Point(98, 214)
        Me.txt_e_name.Name = "txt_e_name"
        Me.txt_e_name.ReadOnly = True
        Me.txt_e_name.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_name.TabIndex = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Employee ID"
        '
        'txt_e_martial_status
        '
        Me.txt_e_martial_status.Enabled = False
        Me.txt_e_martial_status.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_martial_status.Location = New System.Drawing.Point(417, 355)
        Me.txt_e_martial_status.Name = "txt_e_martial_status"
        Me.txt_e_martial_status.ReadOnly = True
        Me.txt_e_martial_status.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_martial_status.TabIndex = 114
        '
        'txt_e_nationality
        '
        Me.txt_e_nationality.Enabled = False
        Me.txt_e_nationality.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_nationality.Location = New System.Drawing.Point(98, 425)
        Me.txt_e_nationality.Name = "txt_e_nationality"
        Me.txt_e_nationality.ReadOnly = True
        Me.txt_e_nationality.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_nationality.TabIndex = 115
        '
        'txt_e_BP
        '
        Me.txt_e_BP.Enabled = False
        Me.txt_e_BP.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_BP.Location = New System.Drawing.Point(98, 495)
        Me.txt_e_BP.Name = "txt_e_BP"
        Me.txt_e_BP.ReadOnly = True
        Me.txt_e_BP.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_BP.TabIndex = 115
        '
        'txt_e_city
        '
        Me.txt_e_city.Enabled = False
        Me.txt_e_city.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_city.Location = New System.Drawing.Point(416, 424)
        Me.txt_e_city.Name = "txt_e_city"
        Me.txt_e_city.ReadOnly = True
        Me.txt_e_city.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_city.TabIndex = 114
        '
        'txt_e_religion
        '
        Me.txt_e_religion.Enabled = False
        Me.txt_e_religion.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_religion.Location = New System.Drawing.Point(416, 495)
        Me.txt_e_religion.Name = "txt_e_religion"
        Me.txt_e_religion.ReadOnly = True
        Me.txt_e_religion.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_religion.TabIndex = 114
        '
        'combo_e_id
        '
        Me.combo_e_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_e_id.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_e_id.FormattingEnabled = True
        Me.combo_e_id.IntegralHeight = False
        Me.combo_e_id.Location = New System.Drawing.Point(98, 74)
        Me.combo_e_id.Name = "combo_e_id"
        Me.combo_e_id.Size = New System.Drawing.Size(250, 27)
        Me.combo_e_id.Sorted = True
        Me.combo_e_id.TabIndex = 107
        '
        'txt_e_type
        '
        Me.txt_e_type.Enabled = False
        Me.txt_e_type.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_e_type.Location = New System.Drawing.Point(417, 75)
        Me.txt_e_type.Name = "txt_e_type"
        Me.txt_e_type.ReadOnly = True
        Me.txt_e_type.Size = New System.Drawing.Size(250, 26)
        Me.txt_e_type.TabIndex = 109
        '
        'EmployeeDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 657)
        Me.Controls.Add(Me.btn_e_cancel)
        Me.Controls.Add(Me.btn_e_print)
        Me.Controls.Add(Me.RB_e_female)
        Me.Controls.Add(Me.RB_e_male)
        Me.Controls.Add(Me.e_picbox)
        Me.Controls.Add(Me.combo_e_id)
        Me.Controls.Add(Me.date_e_DOB)
        Me.Controls.Add(Me.date_e_JD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_e_present_address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_e_permanent_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_e_BP)
        Me.Controls.Add(Me.txt_e_nationality)
        Me.Controls.Add(Me.txt_e_f_name)
        Me.Controls.Add(Me.txt_e_religion)
        Me.Controls.Add(Me.txt_e_city)
        Me.Controls.Add(Me.txt_e_martial_status)
        Me.Controls.Add(Me.txt_e_mobile_no)
        Me.Controls.Add(Me.txt_e_CNIC)
        Me.Controls.Add(Me.txt_e_type)
        Me.Controls.Add(Me.txt_e_salary)
        Me.Controls.Add(Me.txt_e_name)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "EmployeeDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Detail Form"
        CType(Me.e_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_e_cancel As Button
    Friend WithEvents btn_e_print As Button
    Friend WithEvents RB_e_female As RadioButton
    Friend WithEvents RB_e_male As RadioButton
    Friend WithEvents e_picbox As PictureBox
    Friend WithEvents date_e_DOB As DateTimePicker
    Friend WithEvents date_e_JD As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_e_present_address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_e_permanent_address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_e_f_name As TextBox
    Friend WithEvents txt_e_mobile_no As TextBox
    Friend WithEvents txt_e_CNIC As TextBox
    Friend WithEvents txt_e_salary As TextBox
    Friend WithEvents txt_e_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_e_martial_status As TextBox
    Friend WithEvents txt_e_nationality As TextBox
    Friend WithEvents txt_e_BP As TextBox
    Friend WithEvents txt_e_city As TextBox
    Friend WithEvents txt_e_religion As TextBox
    Friend WithEvents combo_e_id As ComboBox
    Friend WithEvents txt_e_type As TextBox
End Class
