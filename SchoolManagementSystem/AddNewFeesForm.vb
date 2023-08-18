Public Class AddNewFeesForm

    'Variable Declaration
    Dim v_f_id_text As String
    Dim v_f_id_num As Integer
    Dim v_f_date_add As Date
    Dim v_f_title As String
    Dim v_f_amount As Integer
    Dim v_f_for_class_text As String
    Dim v_f_for_class_id As Integer
    Dim v_f_description As String

    Private Sub AddNewFeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
        GetFeesID()
    End Sub

    Private Sub btn_f_add_Click(sender As Object, e As EventArgs) Handles btn_f_add.Click

        'Validation for Fees Title
        If StringValidFunction(CStr(txt_f_title.Text), lab_f_title_error.Text, "Please Enter a Fees Title", "Only Enter a Alphabets", "Fees Title between in 5 to 30 charactes", 5, 30, "String") = False Then
            txt_f_title.Focus()
            Exit Sub
        End If

        'Validation for Fees Amount
        If FeesValidFunction(CStr(txt_f_amount.Text), lab_f_amount_error.Text, "Please Enter a Fees Amount", "Only Enter a Numeric", "Fees Amount between in 500 to 50,000 rupees", 500, 50000) = False Then
            txt_f_amount.Focus()
            Exit Sub
        End If

        'Validation Fees For class
        If combo_f_for_class.Text = "" Then
            lab_f_for_class_error.Text = "Please Select a Class Name"
            combo_f_for_class.Focus()
            Exit Sub
        End If
        lab_f_for_class_error.Text = ""

        'Validation Fees Description
        If StringValidFunction(txt_f_description.Text, lab_f_description.Text, "Please Enter the Fees Description", "Only Enter a Alphabets and Numeric", "Fees Description between 5 to 100 Characters", 5, 100, "Address") = False Then
            txt_f_description.Focus()
            Exit Sub
        End If

        v_f_id_text = CStr(txt_f_id.Text)
        v_f_date_add = CDate(date_f_add.Value)
        v_f_title = CStr(txt_f_title.Text)
        v_f_amount = CInt(txt_f_amount.Text)
        v_f_for_class_text = CStr(combo_f_for_class.Text)
        If txt_f_description.Text = "" Then
            v_f_description = "Nothing"
        Else
            v_f_description = CStr(txt_f_description.Text)
        End If

        'For Insert Data Into Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlinsert = "INSERT INTO fees_table(fees_id,fees_add_date,fees_title,fees_amount,fees_for_class,fees_description)VALUES('" & v_f_id_text & "','" & v_f_date_add & "','" & v_f_title & "'," & v_f_amount & "," & v_f_for_class_id & ",'" & v_f_description & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        GetFeesID()
        txt_f_title.Text = ""
        txt_f_amount.Text = ""
        combo_f_for_class.Items.Clear()
        txt_f_description.Text = ""

    End Sub

    Private Sub combo_f_for_class_GotFocus(sender As Object, e As EventArgs) Handles combo_f_for_class.GotFocus
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

        combo_f_for_class.Items.Clear()
        While rsdb.EOF <> True
            combo_f_for_class.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub combo_f_for_class_DropDownClosed(sender As Object, e As EventArgs) Handles combo_f_for_class.DropDownClosed
        'For Get Class ID Against Class Name
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM class_table WHERE class_name='" & CStr(combo_f_for_class.Text) & "'"
        rsdb = conndb.Execute(sqlselect)
        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If
        v_f_for_class_id = CInt(rsdb(0).Value)
    End Sub

    Private Sub btn_f_cancel_Click(sender As Object, e As EventArgs) Handles btn_f_cancel.Click
        Me.Close()
    End Sub

    Sub GetFeesID()
        'For Get Class ID and Show in TextBox
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM fees_table ORDER BY ID DESC"
        rsdb = conndb.Execute(sqlselect)
        v_f_id_num = CInt(rsdb(0).Value + 1)
        txt_f_id.Text = "FEES" + CStr(v_f_id_num)
    End Sub
End Class