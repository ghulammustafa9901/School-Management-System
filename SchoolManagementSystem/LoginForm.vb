Public Class LoginForm

    'Variable Declaration
    Dim v_signup_usertype As String
    Dim v_signup_username As String
    Dim v_signup_email As String
    Dim v_signup_password As String
    Dim v_signup_flag As Byte = 0

    Dim v_signin_usertype As String
    Dim v_signin_usertype_id As Byte
    Dim v_signin_username As String
    Dim v_signin_email As String
    Dim v_signin_password As String
    Dim v_signin_flag As Byte = 0

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initial_program()
    End Sub

    Private Sub tab_signin_Click(sender As Object, e As EventArgs) Handles tab_signin.Click
        If panal_signin.Left = 675 Then
            panal_signup.Visible = False
            panal_signup.Left = 675

            panal_signin.Visible = False
            panal_signin.Left = 61
            panal_signin.Visible = True
            panal_signin.Refresh()

            tab_signin.ForeColor = Color.SeaGreen
            tab_signin.OnIdleState.ForeColor = Color.SeaGreen
            separator.Left = tab_signin.Left
            separator.Width = tab_signin.Width
        End If
    End Sub

    Private Sub tab_signup_Click(sender As Object, e As EventArgs) Handles tab_signup.Click
        If panal_signup.Left = 675 Then
            panal_signin.Visible = False
            panal_signin.Left = 675

            panal_signup.Visible = False
            panal_signup.Left = 61
            panal_signup.Visible = True
            panal_signup.Refresh()

            tab_signup.ForeColor = Color.SeaGreen
            separator.Left = tab_signup.Left
            separator.Width = tab_signup.Width
        End If
    End Sub

    Private Sub img_cross_Click(sender As Object, e As EventArgs) Handles img_cross.Click
        End
    End Sub

    Private Sub img_cross_MouseHover(sender As Object, e As EventArgs) Handles img_cross.MouseHover
        img_cross.Image = My.Resources.icon_cross_1
    End Sub

    Private Sub img_cross_MouseLeave(sender As Object, e As EventArgs) Handles img_cross.MouseLeave
        img_cross.Image = My.Resources.icon_cross_2
    End Sub

    Private Sub img_minimize_Click(sender As Object, e As EventArgs) Handles img_minimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub img_minimize_MouseHover(sender As Object, e As EventArgs) Handles img_minimize.MouseHover
        img_minimize.Image = My.Resources.icon_minimize_3
    End Sub

    Private Sub img_minimize_MouseLeave(sender As Object, e As EventArgs) Handles img_minimize.MouseLeave
        img_minimize.Image = My.Resources.icon_minimize_1
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        'For Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection

        'Validation for Usertype
        If cbo_signin_usertype.Text = "" Then
            lab_signin_usertype_error.Text = "Please Select a Usertype"
            cbo_signin_usertype.Focus()
            Exit Sub
        End If
        lab_signin_usertype_error.Text = ""

        'Validation for Username
        If StringValidFunction(txt_signin_username.Text, lab_signin_username_error.Text, "Please Enter the Username", "Only Enter a Alphabets, Numeric and . _ - @ #", "Username between in 6 to 20 charactes", 6, 20, "Username") = False Then
            txt_signin_username.Focus()
            Exit Sub
        End If

        'Validation for Password
        If StringValidFunction(txt_signin_password.Text, lab_signin_password_error.Text, "Please Enter the Password", "Only Enter a Alphabets, Numeric and . _ - @ #", "Password between in 8 to 30 charactes", 8, 30, "Username") = False Then
            txt_signup_password.Focus()
            Exit Sub
        End If

        'For Get ID Against usertype
        conndb.Open(addressdb)
        sqlselect = "SELECT ID FROM usertype_table WHERE usertype_name='" & CStr(cbo_signin_usertype.Text) & "'"
        rsdb = conndb.Execute(sqlselect)
        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If
        v_usertype_id = rsdb(0).Value
        'v_signin_usertype_id = rsdb(0).Value
        conndb.Close()

        'Sent Data to Home Page For Display Meun
        'Dim homeObj As New HomeForm
        'homeObj.v_get_usertype_id = v_signin_usertype_id

        'Check User account have or not
        Dim v_login_check As Byte = 0
        conndb.Open(addressdb)
        sqlselect = "SELECT user_usertype,user_username,user_password FROM user_table"
        rsdb = conndb.Execute(sqlselect)
        While rsdb.EOF <> True
            If rsdb(0).Value = cbo_signin_usertype.Text And rsdb(1).Value = txt_signin_username.Text And rsdb(2).Value = txt_signin_password.Text Then
                Me.Hide()
                HomeForm.Show()
                v_login_check = 1
            End If
            rsdb.MoveNext()
        End While
        If v_login_check = 0 Then
            MsgBox("Your Username and Password is Incorrect", vbCritical, msgtitle)
        End If
        conndb.Close()

    End Sub

    Private Sub cbo_signin_usertype_GotFocus(sender As Object, e As EventArgs) Handles cbo_signin_usertype.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "Select usertype_name FROM usertype_table"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record Is found In the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        cbo_signin_usertype.Items.Clear()
        While rsdb.EOF <> True
            cbo_signin_usertype.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click

        'For Database
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection

        'Validation for Usertype
        If cbo_signup_usertype.Text = "" Then
            lab_signup_usertype_error.Text = "Please Select a Usertype"
            cbo_signup_usertype.Focus()
            Exit Sub
        End If
        lab_signup_usertype_error.Text = ""

        'Validation for Username
        If StringValidFunction(txt_signup_username.Text, lab_signup_username_error.Text, "Please Enter the Username", "Only Enter a Alphabets, Numeric And . _ - @ #", "Username between In 6 To 20 charactes", 6, 20, "Username") = False Then
            txt_signup_username.Focus()
            Exit Sub
        End If

        'Compare For Username Already Exist
        conndb.Open(addressdb)
        sqlselect = "Select user_usertype,user_username FROM user_table"
        rsdb = conndb.Execute(sqlselect)
        While rsdb.EOF <> True
            If rsdb(0).Value = cbo_signup_usertype.Text And rsdb(1).Value = txt_signup_username.Text Then
                lab_signup_username_error.Text = "Username already exist"
                Exit Sub
            End If
            rsdb.MoveNext()
        End While
        conndb.Close()

        'Validation for Email
        If EmailValidFunction(txt_signup_email.Text, lab_signup_email_error.Text, "Please Enter a Email", "Please Enter a Valid Email") = False Then
            txt_signup_email.Focus()
            Exit Sub
        End If

        'Compare For Email Already Exist
        conndb.Open(addressdb)
        sqlselect = "Select user_email FROM user_table"
        rsdb = conndb.Execute(sqlselect)
        While rsdb.EOF <> True
            If rsdb(0).Value = txt_signup_email.Text Then
                lab_signup_email_error.Text = "Email already exist"
                Exit Sub
            End If
            rsdb.MoveNext()
        End While
        conndb.Close()

        'Validation for Password
        If StringValidFunction(txt_signup_password.Text, lab_signup_password_error.Text, "Please Enter the Password", "Only Enter a Alphabets, Numeric And . _ - @ #", "Password between In 8 To 30 charactes", 8, 30, "Username") = False Then
            txt_signup_password.Focus()
            Exit Sub
        End If

        'Store Data into Variables
        v_signup_usertype = CStr(cbo_signup_usertype.Text)
        v_signup_username = CStr(txt_signup_username.Text)
        v_signup_email = CStr(txt_signup_email.Text)
        v_signup_password = CStr(txt_signup_password.Text)

        'For Insert Data Into Database
        conndb.Open(addressdb)
        sqlinsert = "INSERT INTO user_table(user_usertype,user_username,user_email,user_password)VALUES('" & v_signup_usertype & "','" & v_signup_username & "','" & v_signup_email & "','" & v_signup_password & "')"
        conndb.Execute(sqlinsert)
        conndb.Close()
        MsgBox("Data Inserted into Database", vbInformation, msgtitle)

        cbo_signup_usertype.Text = ""
        txt_signup_username.Text = ""
        txt_signup_email.Text = ""
        txt_signup_password.Text = ""

    End Sub

    Private Sub cbo_signup_usertype_GotFocus(sender As Object, e As EventArgs) Handles cbo_signup_usertype.GotFocus
        rsdb = New ADODB.Recordset
        conndb = New ADODB.Connection
        conndb.Open(addressdb)
        sqlselect = "SELECT usertype_name FROM usertype_table"
        rsdb = conndb.Execute(sqlselect)

        If rsdb.EOF = True Then
            conndb.Close()
            MsgBox("No such record is found in the database.", vbInformation, msgtitle)
            Exit Sub
        End If

        cbo_signup_usertype.Items.Clear()
        While rsdb.EOF <> True
            cbo_signup_usertype.Items.Add(CStr(Trim(rsdb(0).Value)))
            rsdb.MoveNext()
        End While
        conndb.Close()
    End Sub

    Private Sub txt_signin_password_OnIconRightClick(sender As Object, e As EventArgs) Handles txt_signin_password.OnIconRightClick

        If v_signin_flag = 0 Then
            'Below Code for Open Eye
            txt_signin_password.IconRight = My.Resources.icon_open_eye_1
            v_signin_flag = 1
            txt_signin_password.UseSystemPasswordChar = False
        Else
            'Below Code for Hide Eye
            txt_signin_password.IconRight = My.Resources.icon_hide_eye_1
            v_signin_flag = 0
            If txt_signin_password.Text = "" Then
                txt_signin_password.UseSystemPasswordChar = False
            Else
                txt_signin_password.UseSystemPasswordChar = True
            End If
        End If

    End Sub

    Private Sub txt_signin_password_TextChange(sender As Object, e As EventArgs) Handles txt_signin_password.TextChange
        txt_signin_password_OnIconRightClick(sender, e)
    End Sub

    Private Sub txt_signup_password_OnIconRightClick(sender As Object, e As EventArgs) Handles txt_signup_password.OnIconRightClick

        If v_signin_flag = 0 Then
            'Below Code for Open Eye
            txt_signup_password.IconRight = My.Resources.icon_open_eye_1
            v_signin_flag = 1
            txt_signup_password.UseSystemPasswordChar = False
        Else
            'Below Code for Hide Eye
            txt_signup_password.IconRight = My.Resources.icon_hide_eye_1
            v_signin_flag = 0
            If txt_signup_password.Text = "" Then
                txt_signup_password.UseSystemPasswordChar = False
            Else
                txt_signup_password.UseSystemPasswordChar = True
            End If
        End If

    End Sub

    Private Sub txt_signup_password_TextChange(sender As Object, e As EventArgs) Handles txt_signup_password.TextChange
        txt_signup_password_OnIconRightClick(sender, e)
    End Sub
End Class