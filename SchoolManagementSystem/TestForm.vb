Public Class TestForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim v_test As String

        'v_test = CStr(TextBox1.Text)

        'rsdb = New ADODB.Recordset
        'conndb = New ADODB.Connection
        'conndb.Open(addressdb)

        'sqlinsert = "insert into test_table(test_field)values('" & v_test & "')"

        'conndb.Execute(sqlinsert)


        'conndb.Close()

        'MsgBox("1 new city name is inserted into the database.", vbInformation, msgtitle)

        'TextBox1.Text = ""

        'TextBox1.Focus()

        'If NumberValidFunction1(TextBox1.Text, Label1.Text, "empty", "not valid", "Fees", 500, 5000, "min len for number", "max len for number", "Fees between in 500 to 5000 rupees") = False Then
        '    TextBox1.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
    End Sub
End Class