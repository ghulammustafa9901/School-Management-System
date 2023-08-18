Public Class AddNewStudentForm
    'Variable Declaration
    Dim v_s_reg_no As String
    Dim v_s_reg_id As Integer
    Dim v_s_class_name As String
    Dim v_s_class_id As Integer
    Dim v_s_DOA As Date
    Dim v_s_roll_no As Integer
    Dim v_s_name As String
    Dim v_s_DOB As Date
    Dim v_s_DOB_cal As Integer
    Dim v_s_f_name As String
    Dim v_s_f_mobile_no As Long
    Dim v_s_m_name As String
    Dim v_s_m_mobile_no As Long
    Dim v_s_nationality As String
    Dim v_s_city As String
    Dim v_s_BP As String
    Dim v_s_religion As String
    Dim v_s_present_address As String
    Dim v_s_permanent_address As String
    Dim v_s_gender As String

    Private Sub AddNewStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
        GetRegistrationID()
    End Sub

    Private Sub btn_s_reg_Click(sender As Object, e As EventArgs) Handles btn_s_reg.Click
        On Error GoTo abc

        'Validation for Student Class
        If combo_s_class_name.Text = "" Then
            lab_s_class_name_error.Text = "Please Select a Class Name"
            combo_s_class_name.Focus()
            Exit Sub
        End If
        lab_s_class_name_error.Text = ""

        'Validation for Student Date of Add
        'If DateValidFunction(date_s_DOA.Value.Day, lab_s_DOA_error.Text, False) = False Then
        '    date_s_DOA.Focus()
        '    Exit Sub
        'End If
        If date_s_DOA.Value.Day > Date.Today.Day Then
            lab_s_DOA_error.Text = "Please Enter a Valid Date"
            date_s_DOA.Focus()
            Exit Sub
        End If
        lab_s_DOA_error.Text = ""

        'Validation for Student Name
        If StringValidFunction(txt_s_name.Text, lab_s_name_error.Text, "Please Enter the Student Name", "Only Enter a Alphabets", "Student Name between in 5 to 30 charactes", 5, 30) = False Then
            txt_s_name.Focus()
            Exit Sub
        End If

        'Validation for Student Date of Birth
        'v_s_DOB_cal = Date.Today.Year - 4
        'If DateValidFunction(date_s_DOB.Value, lab_s_DOB_error.Text, True, date_s_DOB.Value.Year, date_s_DOB.Value.Month, date_s_DOB.Value.Day, v_s_DOB_cal) = False Then
        '    date_s_DOB.Focus()
        '    Exit Sub
        'End If

        'Validation for Student Father Name
        If StringValidFunction(txt_s_f_name.Text, lab_s_f_name_error.Text, "Please Enter the Father Name", "Only Enter a Alphabets", "Father Name between in 5 to 30 charactes", 5, 30) = False Then
            txt_s_f_name.Focus()
            Exit Sub
        End If

        'Validation for Student Father Mobile No
        If NumberValidFunction(CStr(txt_s_f_mobile_no.Text), lab_s_f_mobile_error.Text, "Please Enter the Father Phone No", "Only Enter a Numeric Number", "Father Phone No is Less than 11 Numbers", "Father Phone No is Greater than 11 Numbers", 11, 11) = False Then
            txt_s_f_mobile_no.Focus()
            Exit Sub
        End If

        'Validation for Student Mother Name
        If StringValidFunction(txt_s_m_name.Text, lab_s_m_name_error.Text, "Please Enter the Mother Name", "Only Enter a Alphabets", "Mother Name between in 5 to 30 charactes", 5, 30) = False Then
            txt_s_m_name.Focus()
            Exit Sub
        End If

        'Validation for Student Mother Mobile No
        If NumberValidFunction(txt_s_m_mobile_no.Text, lab_s_m_mobile_error.Text, "Please Enter the Mother Phone No", "Only Enter a Numeric Number", "Mother Phone No is Less than 11 Numbers", "Mother Phone No is Greater than 11 Numbers", 11, 11) = False Then
            txt_s_m_mobile_no.Focus()
            Exit Sub
        End If

        'Validation for Student Nationality
        If combo_s_nationality.Text = "" Then
            lab_s_nationality_error.Text = "Please Select a Nationality"
            combo_s_nationality.Focus()
            Exit Sub
        End If
        lab_s_nationality_error.Text = ""

        'Validation for Student City
        If combo_s_city.Text = "" Then
            lab_s_city_error.Text = "Please Select a City"
            combo_s_city.Focus()
            Exit Sub
        End If
        lab_s_city_error.Text = ""

        'Validation for Student Birth Place
        If combo_s_BP.Text = "" Then
            lab_s_BP_error.Text = "Please Select a Birth Place"
            combo_s_BP.Focus()
            Exit Sub
        End If
        lab_s_BP_error.Text = ""

        'Validation for Student Religion
        If combo_s_religion.Text = "" Then
            lab_s_religion_error.Text = "Please Select a Religion"
            combo_s_religion.Focus()
            Exit Sub
        End If
        lab_s_religion_error.Text = ""

        'Validation for Student Gender
        If Not (RB_s_male.Checked Or RB_s_female.Checked) Then
            lab_s_gender_error.Text = "Please Check a One Button"
            Exit Sub

        ElseIf RB_s_male.Checked = True Then
            v_s_gender = "Male"
        ElseIf RB_s_female.Checked = True Then
            v_s_gender = "Female"
        End If

        lab_s_gender_error.Text = ""

        'Validation for Student Present Address
        If StringValidFunction(txt_s_present_address.Text, lab_s_pre_address_error.Text, "Please Enter the Present Address", "Only Enter a Alphabets and Numeric", "Present Address between 10 to 100 Characters", 10, 100, "Address") = False Then
            txt_s_present_address.Focus()
            Exit Sub
        End If

        'Validation for Student Permanent Address
        If StringValidFunction(txt_s_permanent_address.Text, lab_s_per_address_error.Text, "Please Enter the Permanent Address", "Only Enter a Alphabets and Numeric", "Permanent Address between 10 to 100 Characters", 10, 100, "Address") = False Then
            txt_s_permanent_address.Focus()
            Exit Sub
        End If

        v_s_reg_no = CStr(txt_s_reg_no.Text)
        v_s_class_name = CStr(combo_s_class_name.Text)
        v_s_DOA = CDate(date_s_DOA.Value)
        v_s_roll_no = CInt(txt_s_roll_no.Text)
        v_s_name = CStr(txt_s_name.Text)
        v_s_DOB = CDate(date_s_DOB.Value)
        v_s_f_name = CStr(txt_s_f_name.Text)
        v_s_f_mobile_no = CLng(txt_s_f_mobile_no.Text)
        v_s_m_name = CStr(txt_s_m_name.Text)
        v_s_m_mobile_no = CLng(txt_s_m_mobile_no.Text)
        v_s_nationality = CStr(combo_s_nationality.Text)
        v_s_city = CStr(combo_s_city.Text)
        v_s_BP = CStr(combo_s_BP.Text)
        v_s_religion = CStr(combo_s_religion.Text)
        v_s_present_address = CStr(txt_s_present_address.Text)
        v_s_permanent_address = CStr(txt_s_permanent_address.Text)

        'For Insert Data Into Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        'For Insert Total Student into Class Table
        'sqlinsert = "INSERT INTO class_table(class_present_student)VALUES('" & v_s_roll_no & "') WHERE class_name='" & v_s_class_name & "'"
        'conndb.Execute(sqlinsert)
        'For Insert Student Data into Student Table
        sqlinsert = "INSERT INTO student_reg_table(s_reg_no,s_class_name,s_DOA,s_roll_no,s_name,s_DOB,s_f_name,s_f_mobile,s_m_name,s_m_mobile,s_nationality,s_city,s_religion,s_BP,s_present_address,s_permanent_address,s_gender)VALUES('" & v_s_reg_no & "','" & v_s_class_id & " ','" & v_s_DOA & "','" & v_s_roll_no & "','" & v_s_name & "','" & v_s_DOB & "','" & v_s_f_name & "','" & v_s_f_mobile_no & "','" & v_s_m_name & "','" & v_s_m_mobile_no & "','" & v_s_nationality & "','" & v_s_city & "','" & v_s_BP & "','" & v_s_religion & "','" & v_s_present_address & "','" & v_s_permanent_address & "','" & v_s_gender & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        GetRegistrationID()
        combo_s_class_name.Items.Clear()
        txt_s_roll_no.Text = ""
        txt_s_name.Text = ""
        txt_s_f_name.Text = ""
        txt_s_f_mobile_no.Text = ""
        txt_s_m_name.Text = ""
        txt_s_m_mobile_no.Text = ""
        combo_s_nationality.Items.Clear()
        combo_s_city.Items.Clear()
        combo_s_BP.Items.Clear()
        combo_s_religion.Items.Clear()
        txt_s_present_address.Text = ""
        txt_s_permanent_address.Text = ""
abc:
        MsgBox("Error Description:" & Err.Description, Err.Number)
    End Sub

    Private Sub combo_s_class_name_GotFocus(sender As Object, e As EventArgs) Handles combo_s_class_name.GotFocus

        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT class_name FROM class_table"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_class_name.Items.Clear()
        While rsdb.EOF <> True
            combo_s_class_name.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_s_class_name_DropDownClosed(sender As Object, e As EventArgs) Handles combo_s_class_name.DropDownClosed

        'For Get Class ID Against Class Name
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM class_table WHERE class_name='" & CStr(combo_s_class_name.Text) & "'"
        rsdb = conndb.Execute(sqlselect)
        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If
        v_s_class_id = CInt(rsdb(0).Value)

        'For Create a Student Roll No
        sqlselect = "SELECT COUNT(s_class_name) FROM student_reg_table WHERE s_class_name=" & v_s_class_id & ""
        rsdb = conndb.Execute(sqlselect)
        txt_s_roll_no.Text = CInt(rsdb(0).Value + 1)
        conndb.Close()
    End Sub

    Private Sub combo_s_nationality_GotFocus(sender As Object, e As EventArgs) Handles combo_s_nationality.GotFocus

        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT country_name FROM country_table ORDER BY country_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_nationality.Items.Clear()
        While rsdb.EOF <> True
            combo_s_nationality.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_s_city_GotFocus(sender As Object, e As EventArgs) Handles combo_s_city.GotFocus

        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT city_name FROM city_table ORDER BY city_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_city.Items.Clear()
        While rsdb.EOF <> True
            combo_s_city.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_s_BP_GotFocus(sender As Object, e As EventArgs) Handles combo_s_BP.GotFocus

        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT city_name FROM city_table ORDER BY city_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_BP.Items.Clear()
        While rsdb.EOF <> True
            combo_s_BP.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_s_religion_GotFocus(sender As Object, e As EventArgs) Handles combo_s_religion.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT religion_name FROM religion_table ORDER BY religion_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_religion.Items.Clear()
        While rsdb.EOF <> True
            combo_s_religion.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub btn_s_copy_address_Click(sender As Object, e As EventArgs) Handles btn_s_copy_address.Click

        If txt_s_present_address.Text = "" Then
            lab_s_pre_address_error.Text = "Please Enter the Present Address"
            txt_s_present_address.Focus()
            Exit Sub
        Else
            v_s_present_address = CStr(txt_s_present_address.Text)
            txt_s_permanent_address.Text = v_s_present_address
        End If

    End Sub

    Private Sub btn_s_cancel_Click(sender As Object, e As EventArgs) Handles btn_s_cancel.Click
        'Dim StudentRegistrationPage As New StudentRegistrationForm
        'StudentRegistrationPage.Close()
        Me.Close()
    End Sub

    Private Sub btn_s_select_img_Click(sender As Object, e As EventArgs) Handles btn_s_select_img.Click
        Dim OFD As New OpenFileDialog
        'OFD.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png"
        OFD.Filter = " JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*"
        Dim imageLocation As String

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            imageLocation = OFD.FileName
            's_picbox.Image = Image.FromFile(OFD.FileName)
            s_picbox.ImageLocation = imageLocation
        End If
    End Sub

    Sub GetRegistrationID()
        'For Get Student ID and Show Registration No in TextBox
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM student_reg_table ORDER BY ID DESC"
        rsdb = conndb.Execute(sqlselect)
        v_s_reg_id = CInt(rsdb(0).Value + 1)
        txt_s_reg_no.Text = "REG" + CStr(v_s_reg_id)
        conndb.Close()
    End Sub
End Class