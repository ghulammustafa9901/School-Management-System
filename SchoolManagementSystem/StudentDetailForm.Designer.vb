<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentDetailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentDetailForm))
        Me.btn_s_cancel = New System.Windows.Forms.Button()
        Me.btn_s_print = New System.Windows.Forms.Button()
        Me.RB_s_female = New System.Windows.Forms.RadioButton()
        Me.RB_s_male = New System.Windows.Forms.RadioButton()
        Me.s_picbox = New System.Windows.Forms.PictureBox()
        Me.combo_s_class_name = New System.Windows.Forms.ComboBox()
        Me.date_s_DOB = New System.Windows.Forms.DateTimePicker()
        Me.date_s_DOA = New System.Windows.Forms.DateTimePicker()
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
        Me.txt_s_present_address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_s_m_mobile_no = New System.Windows.Forms.TextBox()
        Me.txt_s_permanent_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_s_m_name = New System.Windows.Forms.TextBox()
        Me.txt_s_f_mobile_no = New System.Windows.Forms.TextBox()
        Me.txt_s_f_name = New System.Windows.Forms.TextBox()
        Me.txt_s_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_s_reg_no = New System.Windows.Forms.TextBox()
        Me.combo_s_roll_no = New System.Windows.Forms.ComboBox()
        Me.txt_s_nationality = New System.Windows.Forms.TextBox()
        Me.txt_s_city = New System.Windows.Forms.TextBox()
        Me.txt_s_BP = New System.Windows.Forms.TextBox()
        Me.txt_s_religion = New System.Windows.Forms.TextBox()
        CType(Me.s_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_s_cancel
        '
        Me.btn_s_cancel.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_s_cancel.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatAppearance.BorderSize = 3
        Me.btn_s_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_s_cancel.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_s_cancel.Location = New System.Drawing.Point(876, 551)
        Me.btn_s_cancel.Name = "btn_s_cancel"
        Me.btn_s_cancel.Size = New System.Drawing.Size(114, 37)
        Me.btn_s_cancel.TabIndex = 88
        Me.btn_s_cancel.Text = "Cancel"
        Me.btn_s_cancel.UseVisualStyleBackColor = False
        '
        'btn_s_print
        '
        Me.btn_s_print.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_s_print.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btn_s_print.FlatAppearance.BorderSize = 3
        Me.btn_s_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btn_s_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_s_print.Font = New System.Drawing.Font("Raleway", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_s_print.Location = New System.Drawing.Point(740, 551)
        Me.btn_s_print.Name = "btn_s_print"
        Me.btn_s_print.Size = New System.Drawing.Size(114, 37)
        Me.btn_s_print.TabIndex = 87
        Me.btn_s_print.Text = "Print"
        Me.btn_s_print.UseVisualStyleBackColor = False
        '
        'RB_s_female
        '
        Me.RB_s_female.AutoSize = True
        Me.RB_s_female.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_s_female.Location = New System.Drawing.Point(172, 564)
        Me.RB_s_female.Name = "RB_s_female"
        Me.RB_s_female.Size = New System.Drawing.Size(75, 20)
        Me.RB_s_female.TabIndex = 16
        Me.RB_s_female.TabStop = True
        Me.RB_s_female.Text = "Female"
        Me.RB_s_female.UseVisualStyleBackColor = True
        '
        'RB_s_male
        '
        Me.RB_s_male.AutoSize = True
        Me.RB_s_male.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_s_male.Location = New System.Drawing.Point(95, 564)
        Me.RB_s_male.Name = "RB_s_male"
        Me.RB_s_male.Size = New System.Drawing.Size(58, 20)
        Me.RB_s_male.TabIndex = 15
        Me.RB_s_male.TabStop = True
        Me.RB_s_male.Text = "Male"
        Me.RB_s_male.UseVisualStyleBackColor = True
        '
        's_picbox
        '
        Me.s_picbox.BackColor = System.Drawing.Color.Transparent
        Me.s_picbox.Image = CType(resources.GetObject("s_picbox.Image"), System.Drawing.Image)
        Me.s_picbox.Location = New System.Drawing.Point(740, 72)
        Me.s_picbox.Name = "s_picbox"
        Me.s_picbox.Size = New System.Drawing.Size(163, 169)
        Me.s_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.s_picbox.TabIndex = 57
        Me.s_picbox.TabStop = False
        '
        'combo_s_class_name
        '
        Me.combo_s_class_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_s_class_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_s_class_name.FormattingEnabled = True
        Me.combo_s_class_name.IntegralHeight = False
        Me.combo_s_class_name.Location = New System.Drawing.Point(414, 72)
        Me.combo_s_class_name.Name = "combo_s_class_name"
        Me.combo_s_class_name.Size = New System.Drawing.Size(250, 27)
        Me.combo_s_class_name.Sorted = True
        Me.combo_s_class_name.TabIndex = 2
        '
        'date_s_DOB
        '
        Me.date_s_DOB.Enabled = False
        Me.date_s_DOB.Location = New System.Drawing.Point(414, 214)
        Me.date_s_DOB.Name = "date_s_DOB"
        Me.date_s_DOB.Size = New System.Drawing.Size(250, 23)
        Me.date_s_DOB.TabIndex = 6
        '
        'date_s_DOA
        '
        Me.date_s_DOA.Enabled = False
        Me.date_s_DOA.Location = New System.Drawing.Point(95, 141)
        Me.date_s_DOA.Name = "date_s_DOA"
        Me.date_s_DOA.Size = New System.Drawing.Size(250, 23)
        Me.date_s_DOA.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(410, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Roll No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(736, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 19)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Student Image"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(410, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Class Name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(410, 471)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 19)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "Religion"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(736, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 19)
        Me.Label17.TabIndex = 100
        Me.Label17.Text = "Present Address"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(736, 428)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(162, 19)
        Me.Label16.TabIndex = 99
        Me.Label16.Text = "Permanent Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(410, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 19)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "Mobile No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(410, 398)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 19)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(410, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 19)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Mobile No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(410, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Date of Birth"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(91, 542)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 19)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Gender"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(91, 471)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 19)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "Birth Place"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(91, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Mother Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(91, 398)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 19)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Nationality"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(91, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 19)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Father Name"
        '
        'txt_s_present_address
        '
        Me.txt_s_present_address.Enabled = False
        Me.txt_s_present_address.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_present_address.Location = New System.Drawing.Point(740, 329)
        Me.txt_s_present_address.Multiline = True
        Me.txt_s_present_address.Name = "txt_s_present_address"
        Me.txt_s_present_address.ReadOnly = True
        Me.txt_s_present_address.Size = New System.Drawing.Size(250, 60)
        Me.txt_s_present_address.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(91, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Full Name"
        '
        'txt_s_m_mobile_no
        '
        Me.txt_s_m_mobile_no.Enabled = False
        Me.txt_s_m_mobile_no.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_m_mobile_no.Location = New System.Drawing.Point(414, 353)
        Me.txt_s_m_mobile_no.Name = "txt_s_m_mobile_no"
        Me.txt_s_m_mobile_no.ReadOnly = True
        Me.txt_s_m_mobile_no.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_m_mobile_no.TabIndex = 10
        '
        'txt_s_permanent_address
        '
        Me.txt_s_permanent_address.Enabled = False
        Me.txt_s_permanent_address.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_permanent_address.Location = New System.Drawing.Point(740, 450)
        Me.txt_s_permanent_address.Multiline = True
        Me.txt_s_permanent_address.Name = "txt_s_permanent_address"
        Me.txt_s_permanent_address.ReadOnly = True
        Me.txt_s_permanent_address.Size = New System.Drawing.Size(250, 60)
        Me.txt_s_permanent_address.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(91, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Date of Add"
        '
        'txt_s_m_name
        '
        Me.txt_s_m_name.Enabled = False
        Me.txt_s_m_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_m_name.Location = New System.Drawing.Point(95, 353)
        Me.txt_s_m_name.Name = "txt_s_m_name"
        Me.txt_s_m_name.ReadOnly = True
        Me.txt_s_m_name.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_m_name.TabIndex = 9
        '
        'txt_s_f_mobile_no
        '
        Me.txt_s_f_mobile_no.Enabled = False
        Me.txt_s_f_mobile_no.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_f_mobile_no.Location = New System.Drawing.Point(414, 282)
        Me.txt_s_f_mobile_no.Name = "txt_s_f_mobile_no"
        Me.txt_s_f_mobile_no.ReadOnly = True
        Me.txt_s_f_mobile_no.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_f_mobile_no.TabIndex = 8
        '
        'txt_s_f_name
        '
        Me.txt_s_f_name.Enabled = False
        Me.txt_s_f_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_f_name.Location = New System.Drawing.Point(95, 282)
        Me.txt_s_f_name.Name = "txt_s_f_name"
        Me.txt_s_f_name.ReadOnly = True
        Me.txt_s_f_name.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_f_name.TabIndex = 7
        '
        'txt_s_name
        '
        Me.txt_s_name.Enabled = False
        Me.txt_s_name.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_name.Location = New System.Drawing.Point(95, 212)
        Me.txt_s_name.Name = "txt_s_name"
        Me.txt_s_name.ReadOnly = True
        Me.txt_s_name.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_name.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration No"
        '
        'txt_s_reg_no
        '
        Me.txt_s_reg_no.Enabled = False
        Me.txt_s_reg_no.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_reg_no.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_s_reg_no.Location = New System.Drawing.Point(95, 71)
        Me.txt_s_reg_no.Name = "txt_s_reg_no"
        Me.txt_s_reg_no.ReadOnly = True
        Me.txt_s_reg_no.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_reg_no.TabIndex = 1
        '
        'combo_s_roll_no
        '
        Me.combo_s_roll_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_s_roll_no.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_s_roll_no.FormattingEnabled = True
        Me.combo_s_roll_no.IntegralHeight = False
        Me.combo_s_roll_no.Location = New System.Drawing.Point(413, 137)
        Me.combo_s_roll_no.Name = "combo_s_roll_no"
        Me.combo_s_roll_no.Size = New System.Drawing.Size(250, 27)
        Me.combo_s_roll_no.Sorted = True
        Me.combo_s_roll_no.TabIndex = 4
        '
        'txt_s_nationality
        '
        Me.txt_s_nationality.Enabled = False
        Me.txt_s_nationality.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_nationality.Location = New System.Drawing.Point(95, 419)
        Me.txt_s_nationality.Name = "txt_s_nationality"
        Me.txt_s_nationality.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_nationality.TabIndex = 9
        '
        'txt_s_city
        '
        Me.txt_s_city.Enabled = False
        Me.txt_s_city.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_city.Location = New System.Drawing.Point(413, 419)
        Me.txt_s_city.Name = "txt_s_city"
        Me.txt_s_city.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_city.TabIndex = 10
        '
        'txt_s_BP
        '
        Me.txt_s_BP.Enabled = False
        Me.txt_s_BP.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_BP.Location = New System.Drawing.Point(95, 492)
        Me.txt_s_BP.Name = "txt_s_BP"
        Me.txt_s_BP.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_BP.TabIndex = 9
        '
        'txt_s_religion
        '
        Me.txt_s_religion.Enabled = False
        Me.txt_s_religion.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_s_religion.Location = New System.Drawing.Point(413, 492)
        Me.txt_s_religion.Name = "txt_s_religion"
        Me.txt_s_religion.Size = New System.Drawing.Size(250, 26)
        Me.txt_s_religion.TabIndex = 10
        '
        'StudentDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1130, 657)
        Me.Controls.Add(Me.btn_s_cancel)
        Me.Controls.Add(Me.btn_s_print)
        Me.Controls.Add(Me.RB_s_female)
        Me.Controls.Add(Me.RB_s_male)
        Me.Controls.Add(Me.s_picbox)
        Me.Controls.Add(Me.combo_s_roll_no)
        Me.Controls.Add(Me.combo_s_class_name)
        Me.Controls.Add(Me.date_s_DOB)
        Me.Controls.Add(Me.date_s_DOA)
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
        Me.Controls.Add(Me.txt_s_present_address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_s_religion)
        Me.Controls.Add(Me.txt_s_city)
        Me.Controls.Add(Me.txt_s_m_mobile_no)
        Me.Controls.Add(Me.txt_s_permanent_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_s_BP)
        Me.Controls.Add(Me.txt_s_nationality)
        Me.Controls.Add(Me.txt_s_m_name)
        Me.Controls.Add(Me.txt_s_f_mobile_no)
        Me.Controls.Add(Me.txt_s_f_name)
        Me.Controls.Add(Me.txt_s_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_s_reg_no)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "StudentDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Detail Form"
        CType(Me.s_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_s_cancel As Button
    Friend WithEvents btn_s_print As Button
    Friend WithEvents RB_s_female As RadioButton
    Friend WithEvents RB_s_male As RadioButton
    Friend WithEvents s_picbox As PictureBox
    Friend WithEvents combo_s_class_name As ComboBox
    Friend WithEvents date_s_DOB As DateTimePicker
    Friend WithEvents date_s_DOA As DateTimePicker
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
    Friend WithEvents txt_s_present_address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_s_m_mobile_no As TextBox
    Friend WithEvents txt_s_permanent_address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_s_m_name As TextBox
    Friend WithEvents txt_s_f_mobile_no As TextBox
    Friend WithEvents txt_s_f_name As TextBox
    Friend WithEvents txt_s_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_s_reg_no As TextBox
    Friend WithEvents combo_s_roll_no As ComboBox
    Friend WithEvents txt_s_nationality As TextBox
    Friend WithEvents txt_s_city As TextBox
    Friend WithEvents txt_s_BP As TextBox
    Friend WithEvents txt_s_religion As TextBox
End Class
