Public Class AddNewEmployeeForm

    'Variable Declaration
    Dim v_e_id_text As String
    Dim v_e_id_num As Integer
    Dim v_e_type As String
    Dim v_e_JD As Date
    Dim v_e_salary As Integer
    Dim v_e_name As String
    Dim v_e_DOB As Date
    Dim v_e_CNIC As ULong
    Dim v_e_mobile_no As ULong
    Dim v_e_f_name As String
    Dim v_e_martial_status As String
    Dim v_e_nationality As String
    Dim v_e_city As String
    Dim v_e_BP As String
    Dim v_e_religion As String
    Dim v_e_gender As String
    Dim v_e_present_address As String
    Dim v_e_permanent_address As String

    Private Sub AddNewEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
        GetEmployeeID()
    End Sub

    Private Sub btn_e_submit_Click(sender As Object, e As EventArgs) Handles btn_e_submit.Click
        On Error GoTo abc

        'Validation for Employee Type

        'Validation for Employee Joining Date
        If date_e_JD.Value.Day > Date.Today.Day Then
            lab_e_JD_error.Text = "Please Enter a Valid Date"
            date_e_JD.Focus()
            Exit Sub
        End If
        lab_e_JD_error.Text = ""

        'Validation for Employee Salary
        If FeesValidFunction(CStr(txt_e_salary.Text), lab_e_salary_error.Text, "Please Enter a Employee Salary", "Only Enter a Numeric", "Employee Salary between in 5,000 to 1,000,000 rupees", 5000, 1000000) = False Then
            txt_e_salary.Focus()
            Exit Sub
        End If

        'Validation for Employee Name
        If StringValidFunction(txt_e_name.Text, lab_e_name_error.Text, "Please Enter the Employee Name", "Only Enter a Alphabets", "Employee Name between in 5 to 30 charactes", 5, 30) = False Then
            txt_e_name.Focus()
            Exit Sub
        End If

        'Validation for Employee Date of Birth

        'Validation for Employee CNIC
        If NumberValidFunction(txt_e_CNIC.Text, lab_e_CNIC_error.Text, "Please Enter the CNIC No", "Only Enter a Numeric Number", "CNIC No is Less than 13 Numbers", "CNIC No is Greater than 13 Numbers", 13, 13) = False Then
            txt_e_CNIC.Focus()
            Exit Sub
        End If

        'Validation for Employee Mobile No
        If NumberValidFunction(txt_e_mobile_no.Text, lab_e_mobile_error.Text, "Please Enter the Mobile No", "Only Enter a Numeric Number", "Mobile No is Less than 11 Numbers", "Mobile No is Greater than 11 Numbers", 11, 11) = False Then
            txt_e_mobile_no.Focus()
            Exit Sub
        End If

        'Validation for Employee Father Name
        If StringValidFunction(txt_e_f_name.Text, lab_e_f_name_error.Text, "Please Enter the Father Name", "Only Enter a Alphabets", "Father Name between in 5 to 30 charactes", 5, 30) = False Then
            txt_e_f_name.Focus()
            Exit Sub
        End If

        'Validation for Employee Martial Status

        'Validation for Employee Nationality

        'Validation for Employee City

        'Validation for Employee Birth Place

        'Validation for Employee Religion

        'Validation for Employee Gender
        If Not (RB_e_male.Checked Or RB_e_female.Checked) Then
            lab_e_gender_error.Text = "Please Check a One Button"
            Exit Sub

        ElseIf RB_e_male.Checked = True Then
            v_e_gender = "Male"
        ElseIf RB_e_female.Checked = True Then
            v_e_gender = "Female"
        End If

        lab_e_gender_error.Text = ""

        'Validation for Employee Present Address
        If StringValidFunction(txt_e_present_address.Text, lab_e_pre_address_error.Text, "Please Enter the Present Address", "Only Enter a Alphabets and Numeric", "Present Address between 10 to 100 Characters", 10, 100, "Address") = False Then
            txt_e_present_address.Focus()
            Exit Sub
        End If

        'Validation for Employee Permanent Address
        If StringValidFunction(txt_e_permanent_address.Text, lab_e_per_address_error.Text, "Please Enter the Permanent Address", "Only Enter a Alphabets and Numeric", "Permanent Address between 10 to 100 Characters", 10, 100, "Address") = False Then
            txt_e_permanent_address.Focus()
            Exit Sub
        End If

        v_e_id_text = CStr(txt_e_id.Text)
        v_e_type = CStr(combo_e_type.Text)
        v_e_JD = CDate(date_e_JD.Value)
        v_e_salary = CStr(txt_e_salary.Text)
        v_e_name = CStr(txt_e_name.Text)
        v_e_DOB = CDate(date_e_DOB.Value)
        v_e_CNIC = CULng(txt_e_CNIC.Text)
        v_e_mobile_no = CULng(txt_e_mobile_no.Text)
        v_e_f_name = CStr(txt_e_f_name.Text)
        v_e_martial_status = CStr(combo_e_martial_status.Text)
        v_e_nationality = CStr(combo_e_nationality.Text)
        v_e_city = CStr(combo_e_city.Text)
        v_e_BP = CStr(combo_e_BP.Text)
        v_e_religion = CStr(combo_e_religion.Text)
        v_e_present_address = CStr(txt_e_present_address.Text)
        v_e_permanent_address = CStr(txt_e_permanent_address.Text)

        'For Insert Data Into Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlinsert = "INSERT INTO employee_table(employee_id,employee_type,employee_JD,employee_salary,employee_name,employee_DOB,employee_CNIC,employee_mobile,employee_f_name,employee_martial_status,employee_nationality,employee_city,employee_BP,employee_religion,employee_gender,employee_present_address,employee_permanent_address)VALUES('" & v_e_id_text & "','" & v_e_type & " ','" & v_e_JD & "','" & v_e_salary & "','" & v_e_name & "','" & v_e_DOB & "','" & v_e_CNIC & "','" & v_e_mobile_no & "','" & v_e_f_name & "','" & v_e_martial_status & "','" & v_e_nationality & "','" & v_e_city & "','" & v_e_BP & "','" & v_e_religion & "','" & v_e_gender & "','" & v_e_present_address & "','" & v_e_permanent_address & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        GetEmployeeID()
        combo_e_type.Items.Clear()
        txt_e_salary.Text = ""
        txt_e_name.Text = ""
        txt_e_CNIC.Text = ""
        txt_e_mobile_no.Text = ""
        txt_e_f_name.Text = ""
        combo_e_martial_status.Items.Clear()
        combo_e_nationality.Items.Clear()
        combo_e_city.Items.Clear()
        combo_e_BP.Items.Clear()
        combo_e_religion.Items.Clear()
        txt_e_present_address.Text = ""
        txt_e_permanent_address.Text = ""

abc:
        MsgBox("Error Description:" & Err.Description, Err.Number)
    End Sub

    Private Sub combo_e_type_GotFocus(sender As Object, e As EventArgs) Handles combo_e_type.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT employee_type_name FROM employee_type_table ORDER BY employee_type_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_e_type.Items.Clear()
        While rsdb.EOF <> True
            combo_e_type.Items.Add(Trim(rsdb(0).Value))
            rsdb.MoveNext()
        End While
    End Sub

    Private Sub combo_e_martial_status_GotFocus(sender As Object, e As EventArgs) Handles combo_e_martial_status.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT martial_status_name FROM martial_status_table"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_e_martial_status.Items.Clear()
        While rsdb.EOF <> True
            combo_e_martial_status.Items.Add(Trim(rsdb(0).Value))
            rsdb.MoveNext()
        End While
    End Sub

    Private Sub combo_e_nationality_GotFocus(sender As Object, e As EventArgs) Handles combo_e_nationality.GotFocus
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

        combo_e_nationality.Items.Clear()
        While rsdb.EOF <> True
            combo_e_nationality.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_e_city_GotFocus(sender As Object, e As EventArgs) Handles combo_e_city.GotFocus
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

        combo_e_city.Items.Clear()
        While rsdb.EOF <> True
            combo_e_city.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_e_BP_GotFocus(sender As Object, e As EventArgs) Handles combo_e_BP.GotFocus
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

        combo_e_BP.Items.Clear()
        While rsdb.EOF <> True
            combo_e_BP.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub combo_e_religion_GotFocus(sender As Object, e As EventArgs) Handles combo_e_religion.GotFocus
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

        combo_e_religion.Items.Clear()
        While rsdb.EOF <> True
            combo_e_religion.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()

    End Sub

    Private Sub btn_e_copy_address_Click(sender As Object, e As EventArgs) Handles btn_e_copy_address.Click

        If txt_e_present_address.Text = "" Then
            lab_e_pre_address_error.Text = "Please Enter the Present Address"
            txt_e_present_address.Focus()
            Exit Sub
        Else
            v_e_present_address = CStr(txt_e_present_address.Text)
            txt_e_permanent_address.Text = v_e_present_address
        End If

    End Sub

    Private Sub btn_e_cancel_Click(sender As Object, e As EventArgs) Handles btn_e_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_e_select_img_Click(sender As Object, e As EventArgs) Handles btn_e_select_img.Click
        Dim OFD As New OpenFileDialog
        'OFD.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png"
        OFD.Filter = " JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*"
        Dim imageLocation As String

        If OFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            imageLocation = OFD.FileName
            's_picbox.Image = Image.FromFile(OFD.FileName)
            e_picbox.ImageLocation = imageLocation
        End If
    End Sub

    Sub GetEmployeeID()
        'For Get Employee ID and Show in TextBox
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM employee_table ORDER BY ID DESC"
        rsdb = conndb.Execute(sqlselect)
        v_e_id_num = CInt(rsdb(0).Value) + 1
        v_e_id_text = "EMP" + CStr(v_e_id_num)
        txt_e_id.Text = v_e_id_text
        conndb.Close()
    End Sub

End Class