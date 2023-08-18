Imports System.Text.RegularExpressions
Imports System.Drawing.Color
Module Module1

    'For Database
    Public rsdb As ADODB.Recordset
    Public conndb As ADODB.Connection
    Public sqlselect, sqlinsert, sqlupdate, sqldelete As String
    Public v_usertype_id As Byte

    Public addressdb As String
    Public msgtitle As String

    Public Sub initial_program()
        addressdb = "dsn=SMS_MDB"
        msgtitle = "School Management System"
    End Sub

    'For Color
    Public a As Color = New Color


    'Pattern For String
    Dim regexForString As Regex = New Regex("^[a-zA-Z ]*$")
    Dim isValidForString As Boolean

    'Pattern For Address
    Dim regexForAddress As Regex = New Regex("^[a-zA-Z0-9\.\'\-\#\, ]*$")
    Dim isValidForAddress As Boolean

    'Pattern For String and Number
    Dim regexForStringAndNumber As Regex = New Regex("^[a-zA-Z0-9\- ]*$")
    Dim isValidForStringAndNumber As Boolean

    'Pattern For Username
    Dim regexForUsername As Regex = New Regex("^[a-zA-Z0-9_\-\#\@\. ]*$")
    Dim isValidForUsername As Boolean

    'Pattern For Number
    Dim regexForNumber As Regex = New Regex("^[0-9]*$")
    Dim isValidForNumber As Boolean

    'Pattern For Email
    Dim regex As Regex = New Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
    Dim isValidForEmail As Boolean

    Public Function StringValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String, Optional ByVal lab_text_len As String = "", Optional ByVal MinLen As Integer = 0, Optional ByVal MaxLen As Byte = 0, Optional ByVal ForString As String = "String") As Boolean
        isValidForString = regexForString.IsMatch(txt_name)
        isValidForAddress = regexForAddress.IsMatch(txt_name)
        isValidForStringAndNumber = regexForStringAndNumber.IsMatch(txt_name)
        isValidForUsername = regexForUsername.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False
        End If

        If ForString = "String" Then
            If Not isValidForString Then
                lab_name = lab_notValid
                Return False
            End If
        End If

        If ForString = "Address" Then
            If Not isValidForAddress Then
                lab_name = lab_notValid
                Return False
            End If
        End If

        If ForString = "StringAndNumber" Then
            If Not isValidForStringAndNumber Then
                lab_name = lab_notValid
                Return False
            End If
        End If

        If ForString = "Username" Then
            If Not isValidForUsername Then
                lab_name = lab_notValid
                Return False
            End If
        End If

        If Len(txt_name) < MinLen Or Len(txt_name) > MaxLen Then
            lab_name = lab_text_len
            Return False
        End If

        lab_name = ""
        Return True
    End Function

    Public Function NumberValidFunction1(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String, Optional ByVal ForNumber As String = "Simple", Optional ByVal MinLen As Integer = 0, Optional ByVal MaxLen As Integer = 0, Optional ByVal lab_text_minLen As String = "", Optional ByVal lab_text_maxLen As String = "", Optional ByVal lab_text_len As String = "") As Boolean
        isValidForNumber = regexForNumber.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False
        End If

        If Not isValidForNumber Then
            lab_name = lab_notValid
            Return False
        End If

        If ForNumber = "Number" Then
            If Len(txt_name) < MinLen Then
                lab_name = lab_text_minLen
                Return False
            End If

            If Len(txt_name) > MaxLen Then
                lab_name = lab_text_maxLen
                Return False
            End If
        End If

        If ForNumber = "Fees" Then
            If txt_name < MinLen Or txt_name > MaxLen Then
                lab_name = lab_text_len
                Return False
            End If
        End If

        lab_name = ""
        Return True
    End Function

    Public Function NumberValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String, ByVal lab_text_minLen As String, ByVal lab_text_maxLen As String, ByVal MinLen As Byte, ByVal MaxLen As Byte) As Boolean
        isValidForNumber = regexForNumber.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False

        ElseIf Not isValidForNumber Then
            lab_name = lab_notValid
            Return False

        ElseIf Len(txt_name) < MinLen Then
            lab_name = lab_text_minLen
            Return False

        ElseIf Len(txt_name) > MaxLen Then
            lab_name = lab_text_maxLen
            Return False

        End If

        lab_name = ""
        Return True
    End Function

    Public Function FeesValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String, ByVal lab_text_len As String, ByVal MinLen As Integer, ByVal MaxLen As Integer) As Boolean
        isValidForNumber = regexForNumber.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False

        ElseIf Not isValidForNumber Then
            lab_name = lab_notValid
            Return False

        ElseIf txt_name < MinLen Or txt_name > MaxLen Then
            lab_name = lab_text_len
            Return False

        End If

        lab_name = ""
        Return True
    End Function

    Public Function SimpleNumberValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String) As Boolean
        isValidForNumber = regexForNumber.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False

        ElseIf Not isValidForNumber Then
            lab_name = lab_notValid
            Return False

        End If

        lab_name = ""
        Return True
    End Function

    Public Function EmailValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal lab_empty As String, ByVal lab_notValid As String) As Boolean
        isValidForEmail = regex.IsMatch(txt_name)

        If txt_name = "" Then
            lab_name = lab_empty
            Return False

        ElseIf Not isValidForEmail Then
            lab_name = lab_notValid
            Return False

        End If

        lab_name = ""
        Return True
    End Function

    Public Function DateValidFunction(ByRef txt_name As String, ByRef lab_name As String, ByVal optionValue As Boolean, Optional ByRef txt_name_year As Integer = -1, Optional ByRef txt_name_month As Integer = -1, Optional ByRef txt_name_day As Integer = -1, Optional ByVal year As Integer = -1) As Boolean

        If optionValue = True Then

            If txt_name_day > Date.Today.Day Then
                If txt_name_month > Date.Today.Month Then
                    If txt_name_year > Date.Today.Year Then
                        lab_name = "Please Enter a Valid Date"
                        Return False
                    End If
                End If
            End If

            If txt_name_year > year Then
                lab_name = "You are not eligible for apply"
                Return False
            End If

            lab_name = ""
            Return True
        Else
            If txt_name > Date.Today.Day Then
                lab_name = "Please Enter a Valid Date else"
                Return False
            End If

            lab_name = ""
            Return True
        End If

    End Function
End Module
