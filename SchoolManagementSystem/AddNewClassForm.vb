Public Class AddNewClassForm

    'Variable Declaration
    Dim v_c_id_text As String
    Dim v_c_id_num As Integer
    Dim v_c_name As String
    Dim v_c_duration As String
    Dim v_c_fees As Integer
    Dim v_c_max_student As Integer

    Private Sub AddNewClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
        GetClassID()
    End Sub

    Private Sub btn_c_cancel_Click(sender As Object, e As EventArgs) Handles btn_c_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_c_add_Click(sender As Object, e As EventArgs) Handles btn_c_add.Click

        'Validation for Class Name
        If StringValidFunction(CStr(txt_c_name.Text), lab_c_name_error.Text, "Please Enter a Class Name", "Only Enter a Alphabets and Numeric", "Class Name between in 5 to 30 charactes", 5, 30, "StringAndNumber") = False Then
            txt_c_name.Focus()
            Exit Sub
        End If

        'Validation for Class Duration
        If StringValidFunction(CStr(txt_c_duration.Text), lab_c_duration_error.Text, "Please Enter a Class Duration", "Only Enter a Alphabets and Numeric", "Class Duration between in 1 to 7 charactes", 1, 7, "StringAndNumber") = False Then
            txt_c_duration.Focus()
            Exit Sub
        End If

        'Validation for Class Fees
        If FeesValidFunction(CStr(txt_c_fees.Text), lab_c_fees_error.Text, "Please Enter a Class Fees", "Only Enter a Numeric", "Class Fees between in 500 to 5000 rupees", 500, 5000) = False Then
            txt_c_fees.Focus()
            Exit Sub
        End If

        'Validation for Class Max Student
        If FeesValidFunction(CStr(txt_c_max_student.Text), lab_c_max_student_error.Text, "Please Enter a Class Max Student", "Only Enter a Numeric", "Class Fees between in 20 to 50 charactes", 20, 50) = False Then
            txt_c_max_student.Focus()
            Exit Sub
        End If

        'Store Data into Variables
        v_c_id_text = CStr(txt_c_id.Text)
        v_c_name = CStr(txt_c_name.Text)
        v_c_duration = CStr(txt_c_duration.Text)
        v_c_fees = CInt(txt_c_fees.Text)
        v_c_max_student = CInt(txt_c_max_student.Text)

        'For Insert Data Into Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlinsert = "INSERT INTO class_table(class_id,class_name,class_duration,class_fees,class_max_student)VALUES('" & v_c_id_text & "','" & v_c_name & "','" & v_c_duration & "','" & v_c_fees & "','" & v_c_max_student & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        GetClassID()
        txt_c_name.Text = ""
        txt_c_duration.Text = ""
        txt_c_fees.Text = ""
        txt_c_max_student.Text = ""

    End Sub

    Sub GetClassID()
        'For Get Class ID and Show in TextBox
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM class_table ORDER BY ID DESC"
        rsdb = conndb.Execute(sqlselect)
        v_c_id_num = CInt(rsdb(0).Value + 1)
        txt_c_id.Text = "CLS" + CStr(v_c_id_num)
    End Sub
End Class