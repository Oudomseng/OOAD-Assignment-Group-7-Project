Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()
    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM `tbluser` WHERE User_name= '" & username & "' and Pass = sha1('" & pass & "')")

            With Form1
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("UserRole") = "Administrator" Then
                        MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                        'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")
                        .Show()
                        frmLogin.Hide()

                    ElseIf dt.Rows(0).Item("UserRole") = "Librarian" Then

                        MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                        'Form1.Text = "User :" & dt.Rows(0).Item("Fullname")


                        .Show()
                        frmLogin.Hide()


                    ElseIf dt.Rows(0).Item("UserRole") = "Assistant" Then
                        MsgBox("Welcome " & dt.Rows(0).Item("UserRole"))
                        'With Form1

                        .Show()
                        frmLogin.Hide()
                    End If

                    'sql = "INSERT INTO `tbllogs` (`UserId`, `LogDate`,LogMode) " &
                    '   " VALUES ('" & dt.Rows(0).Item("UserID") & "',Now(),'Logged in')"
                    'create(sql)

                Else
                    MsgBox("Acount doest not exist!", MsgBoxStyle.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub
    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
