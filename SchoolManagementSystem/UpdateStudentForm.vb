Public Class UpdateStudentForm
    Dim v_s_class_id As Integer
    Dim v_s_roll_no As Integer

    Private Sub UpdateStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
    End Sub

    Private Sub btn_s_cancel_Click(sender As Object, e As EventArgs) Handles btn_s_cancel.Click
        Me.Close()
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

    Private Sub combo_s_roll_no_GotFocus(sender As Object, e As EventArgs) Handles combo_s_roll_no.GotFocus

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

        'For All Select Student Roll No
        sqlselect = "SELECT s_roll_no FROM student_reg_table WHERE s_class_name=" & v_s_class_id & ""
        rsdb = conndb.Execute(sqlselect)
        combo_s_roll_no.Items.Clear()
        While rsdb.EOF <> True
            combo_s_roll_no.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub combo_s_roll_no_DropDownClosed(sender As Object, e As EventArgs) Handles combo_s_roll_no.DropDownClosed
        v_s_roll_no = combo_s_roll_no.Text

        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT s_reg_no,s_DOA,s_name,s_DOB,s_f_name,s_f_mobile,s_m_name,s_m_mobile,s_nationality,s_city,s_BP,s_religion,s_present_address,s_permanent_address,s_gender FROM student_reg_table WHERE s_class_name=" & v_s_class_id & " AND s_roll_no=" & v_s_roll_no & ""
        rsdb = conndb.Execute(sqlselect)

        txt_s_reg_no.Text = CStr(rsdb(0).Value)
        date_s_DOA.Value = CDate(rsdb(1).Value)
        txt_s_name.Text = CStr(rsdb(2).Value)
        date_s_DOB.Value = CDate(rsdb(3).Value)
        txt_s_f_name.Text = CStr(rsdb(4).Value)
        txt_s_f_mobile_no.Text = CStr(rsdb(5).Value)
        txt_s_m_name.Text = CStr(rsdb(6).Value)
        txt_s_m_mobile_no.Text = CStr(rsdb(7).Value)
        combo_s_nationality.Items.Add(CStr(rsdb(8).Value))
        combo_s_city.Items.Add(CStr(rsdb(9).Value))
        combo_s_BP.Items.Add((rsdb(10).Value))
        combo_s_religion.Items.Add(CStr(rsdb(11).Value))
        txt_s_present_address.Text = CStr(rsdb(12).Value)
        txt_s_permanent_address.Text = CStr(rsdb(13).Value)
        If CStr(rsdb(14).Value) = "Male" Then
            RB_s_male.Focus()
        Else
            RB_s_female.Focus()
        End If
        conndb.Close()
    End Sub
End Class