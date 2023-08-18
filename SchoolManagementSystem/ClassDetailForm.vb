Public Class ClassDetailForm
    Dim v_s_class_id As Integer

    Private Sub ClassDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
    End Sub

    Private Sub combo_c_name_GotFocus(sender As Object, e As EventArgs) Handles combo_c_name.GotFocus
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

        combo_c_name.Items.Clear()
        While rsdb.EOF <> True
            combo_c_name.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub combo_c_name_DropDownClosed(sender As Object, e As EventArgs) Handles combo_c_name.DropDownClosed
        'On Error GoTo abc
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT class_id,class_duration,class_fees,class_max_student,class_total_student FROM class_table WHERE class_name='" & CStr(combo_c_name.Text) & "'"
        rsdb = conndb.Execute(sqlselect)

        'Show Class Data in Textbox
        txt_c_id.Text = CStr(rsdb(0).Value)
        txt_c_duration.Text = rsdb(1).Value
        txt_c_fees.Text = CStr(rsdb(2).Value)
        txt_c_max_student.Text = CStr(rsdb(3).Value)
        txt_c_pre_student.Text = CStr(rsdb(4).Value)

        'For Get Class ID Against Class Name
        sqlselect = "SELECT ID FROM class_table WHERE class_name='" & CStr(combo_c_name.Text) & "'"
        rsdb = conndb.Execute(sqlselect)
        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If
        v_s_class_id = CInt(rsdb(0).Value)

        'Show Data in ListView
        sqlselect = "SELECT s_reg_no,s_roll_no,s_name,s_gender,s_DOA FROM student_reg_table WHERE s_class_name=" & v_s_class_id & ""
        rsdb = conndb.Execute(sqlselect)
        ListView1.Items.Clear()
        While rsdb.EOF <> True
            Dim a As ListViewItem = ListView1.Items.Add(rsdb(0).Value)
            a.SubItems.Add(rsdb(1).Value)
            a.SubItems.Add(rsdb(2).Value)
            a.SubItems.Add(rsdb(3).Value)
            a.SubItems.Add(rsdb(4).Value)
            rsdb.MoveNext()
        End While


        'abc:
        '        MsgBox("Error Description:" & Err.Description, Err.Number)


    End Sub

End Class