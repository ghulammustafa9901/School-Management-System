Public Class AddNewSubjectForm
    'Variable Declaration
    Dim v_s_id_text As String
    Dim v_s_id_num As Integer
    Dim v_s_name As String
    Dim v_s_for_class_name As String
    Dim v_s_for_class_id As Integer

    Private Sub AddNewSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
        GetSubjectID()
    End Sub

    Private Sub btn_s_add_Click(sender As Object, e As EventArgs) Handles btn_s_add.Click

        'Validation for Subject Name
        If StringValidFunction(CStr(txt_s_name.Text), lab_s_name_error.Text, "Please Enter a Subject Name", "Only Enter a Alphabets", "Subject Name between in 4 to 30 charactes", 4, 30, "String") = False Then
            txt_s_name.Focus()
            Exit Sub
        End If

        'Validation Subject For Class
        If combo_s_for_class.Text = "" Then
            lab_s_for_class_error.Text = "Please Select a Class Name"
            combo_s_for_class.Focus()
            Exit Sub
        End If
        lab_s_for_class_error.Text = ""

        'Store Data into Variables
        v_s_id_text = CStr(txt_s_id.Text)
        v_s_name = CStr(txt_s_name.Text)
        v_s_for_class_name = CStr(combo_s_for_class.Text)

        'For Insert Data Into Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlinsert = "INSERT INTO subject_table(subject_id,subject_name,subject_for_class)VALUES('" & v_s_id_text & "','" & v_s_name & "','" & v_s_for_class_id & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        GetSubjectID()
        txt_s_name.Text = ""
        combo_s_for_class.Items.Clear()
    End Sub

    Private Sub combo_s_for_class_GotFocus(sender As Object, e As EventArgs) Handles combo_s_for_class.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT class_name FROM class_table ORDER BY class_name ASC"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_s_for_class.Items.Clear()
        While rsdb.EOF <> True
            combo_s_for_class.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub combo_s_for_class_DropDownClosed(sender As Object, e As EventArgs) Handles combo_s_for_class.DropDownClosed
        'For Get Class ID Against Class Name
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM class_table WHERE class_name='" & CStr(combo_s_for_class.Text) & "'"
        rsdb = conndb.Execute(sqlselect)
        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If
        v_s_for_class_id = CInt(rsdb(0).Value)
    End Sub

    Private Sub btn_s_cancel_Click(sender As Object, e As EventArgs) Handles btn_s_cancel.Click
        Me.Close()
    End Sub

    Sub GetSubjectID()
        'For Get Class ID and Show in TextBox
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM subject_table ORDER BY ID DESC"
        rsdb = conndb.Execute(sqlselect)
        v_s_id_num = CInt(rsdb(0).Value + 1)
        txt_s_id.Text = "SUB" + CStr(v_s_id_num)
    End Sub
End Class