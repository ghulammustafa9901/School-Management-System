Public Class EmployeeDetailForm
    Dim v_e_id_text As String

    Private Sub EmployeeDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
    End Sub



    Private Sub btn_e_cancel_Click(sender As Object, e As EventArgs) Handles btn_e_cancel.Click
        Me.Close()
    End Sub

    Private Sub combo_e_id_GotFocus(sender As Object, e As EventArgs) Handles combo_e_id.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT employee_id FROM employee_table"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        combo_e_id.Items.Clear()
        While rsdb.EOF <> True
            combo_e_id.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub combo_e_id_DropDownClosed(sender As Object, e As EventArgs) Handles combo_e_id.DropDownClosed
        v_e_id_text = combo_e_id.Text
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT employee_type,employee_JD,employee_salary,employee_name,employee_DOB,employee_CNIC,employee_mobile
,employee_f_name,employee_martial_status,employee_nationality,employee_city,employee_BP,employee_religion,employee_gender,employee_present_address,employee_permanent_address FROM employee_table WHERE employee_id='" & v_e_id_text & "'"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        txt_e_type.Text = CStr(rsdb(0).Value)
        date_e_JD.Value = CDate(rsdb(1).Value)
        txt_e_salary.Text = CStr(rsdb(2).Value)
        txt_e_name.Text = CStr(rsdb(3).Value)
        date_e_DOB.Value = CDate(rsdb(4).Value)
        txt_e_CNIC.Text = CStr(rsdb(5).Value)
        txt_e_mobile_no.Text = CStr(rsdb(6).Value)
        txt_e_f_name.Text = CStr(rsdb(7).Value)
        txt_e_martial_status.Text = CStr(rsdb(8).Value)
        txt_e_nationality.Text = CStr(rsdb(9).Value)
        txt_e_city.Text = CStr(rsdb(10).Value)
        txt_e_BP.Text = CStr(rsdb(11).Value)
        txt_e_religion.Text = CStr(rsdb(12).Value)
        If CStr(rsdb(13).Value) = "Male" Then
            RB_e_male.Focus()
        Else
            RB_e_female.Focus()
        End If
        txt_e_present_address.Text = CStr(rsdb(14).Value)
        txt_e_permanent_address.Text = CStr(rsdb(15).Value)
    End Sub
End Class