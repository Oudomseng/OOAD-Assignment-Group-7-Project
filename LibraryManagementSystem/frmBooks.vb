Public Class frmBooks
    Private Sub txtAccessionNo_TextChanged(sender As Object, e As EventArgs) Handles txtAccessionNo.TextChanged


        Try
            sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` , `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType ,DeweyDecimal,Remark  FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND  `AccessionNo`= '" & txtAccessionNo.Text & "'"
            reloadtxt(sql)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtTitle.Text = .Item(1)
                    txtDesc.Text = .Item(2)
                    txtAuthor.Text = .Item(3)
                    dtpDatePublish.Value = Format(.Item(4), "MM/dd/yyyy")
                    txtPublisher.Text = .Item(5)
                    cboCategory.Text = .Item(6)
                    cboType.Text = .Item(7)
                    txtDeweyDecimal.Text = .Item(9)


                    btnUpdate.Enabled = True
                    btnSave.Enabled = False
                    btnDelete.Enabled = True
                End With
            Else
                txtTitle.Clear()
                txtDesc.Clear()
                txtAuthor.Clear()
                txtPublisher.Clear()
                cboType.Text = "Unknown"

                cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory")


                dtpDatePublish.Value = Format(Now(), "MM/dd/yyyy")

                btnUpdate.Enabled = False
                btnSave.Enabled = True
                btnDelete.Enabled = False
            End If

        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call btnNew_Click(sender, e)

        sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" & cboCategory.SelectedValue
        reloadtxt(sql)
        txtDeweyDecimal.Text = dt.Rows(0).Item(2)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cleartext(Me)
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price',DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` "
        reloadDtg(sql, dtgList)
        cbo_fill(cboCategory, "Category", "CategoryId", "tblcategory WHERE Category !='ALL'  ORDER BY CATEGORY ASC")



        btnUpdate.Enabled = False

        btnSave.Enabled = True

        btnDelete.Enabled = False

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`, BookType as 'TypeOfBooks', `BookPrice` as 'Price', DeweyDecimal,Remark,Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` AND (`BookTitle` Like '%" & txtSearch.Text & "%' OR `Author` Like '%" & txtSearch.Text & "%' OR `AccessionNo`  Like '%" & txtSearch.Text & "%')"
        reloadDtg(sql, dtgList)
    End Sub
#Region "Numbers only"


    Private Sub txtAccessionNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccessionNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 AndAlso Not e.KeyChar = "." Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        Try
            sql = "SELECT * FROM `tblcategory` WHERE  `CategoryId`=" & cboCategory.SelectedValue
            reloadtxt(sql)
            txtDeweyDecimal.Text = dt.Rows(0).Item(2)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to be filled up.", MsgBoxStyle.Exclamation)
            Else

                remarks = "Donate"

                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = " & txtAccessionNo.Text
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then
                    MsgBox("Accession number is already in used.", MsgBoxStyle.Exclamation)
                    Return
                End If

                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

                'adding books
                sqladd = "Insert Into `tblbooks` " &
                " (`AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`,Status,DeweyDecimal,OverAllQty,Remark,BookType) " &
                " VALUES ('" & txtAccessionNo.Text & "','" & txtTitle.Text & "','" & txtDesc.Text & "','" & txtAuthor.Text & "','" & datePublish & "','" & txtPublisher.Text & "','" & cboCategory.SelectedValue & "','0',1, 'Available' ,'" & txtDeweyDecimal.Text & "',1,'" & remarks & "','" & cboType.Text & "')"
                'updating books

                sqledit = "Update `tblbooks` Set `BookTitle`='" & txtTitle.Text &
                "', `BookDesc`='" & txtDesc.Text & "', `Author`='" & txtAuthor.Text & "', `PublishDate`='" & datePublish &
                "', `BookPublisher`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue &
                "',`DeweyDecimal`='" & txtDeweyDecimal.Text & "',Remark='" & remarks & "',BookType='" & cboType.Text & "'  WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"


                save_or_update(sql, sqladd, sqledit, "Books has been updated in the database.", "New books has been saved in the database.")


                'sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                'reloadtxt(sql)
                'If dt.Rows.Count > 0 Then

                '    ''put a codes here  
                '    sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" & txtTitle.Text & "'"
                '    updates(sql)

                'Else
                sql = "SELECT * FROM `tblbooknumber` WHERE `BOOKTITLE` = '" & txtTitle.Text &
                "'"
                reloadtxt(sql)
                If dt.Rows.Count > 0 Then

                    ''put a codes here  
                    sql = "UPDATE `tblbooknumber` SET `QTY`=`QTY`+ 1 WHERE `BOOKTITLE`='" & txtTitle.Text & "'"
                    updates(sql)

                Else
                    sql = "INSERT INTO  `tblbooknumber` (`BOOKTITLE`,`QTY`,`Desc`, `Author`, `PublishDate`, `Publisher`) " &
                    " VALUES ('" & txtTitle.Text & "',1,'" & txtDesc.Text & "','" & txtAuthor.Text & "','" & datePublish & "','" & txtPublisher.Text & "')"
                    create(sql)
                End If

                Call frmBooks_Load(sender, e)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim datePublish As String = Format(dtpDatePublish.Value, "yyyy-MM-dd")
            Dim remarks As String = ""



            If txtAccessionNo.Text = "" Or txtAuthor.Text = "" Or txtTitle.Text = "" Or txtDesc.Text = "" Or txtPublisher.Text = "" Then
                MsgBox("All fields are required to filled up.", MsgBoxStyle.Exclamation)
            Else
                'If rdoDonate.Checked = True Then
                remarks = "Donate"
                'ElseIf rdoPurchased.Checked = True Then
                'remarks = "Purchased"
                'End If


                sql = "SELECT * FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"
                reloadtxt(sql)

                If dt.Rows.Count > 0 Then

                    sqledit = "Update `tblbooks` Set `BookTitle`='" & txtTitle.Text &
                    "', `BookDesc`='" & txtDesc.Text & "', `Author`='" & txtAuthor.Text & "', `PublishDate`='" & datePublish &
                    "', `BookPublisher`='" & txtPublisher.Text & "', `CategoryId`='" & cboCategory.SelectedValue & "', `DeweyDecimal`='" & txtDeweyDecimal.Text &
                    "',Remark='" & remarks & "',BookType='" & cboType.Text & "'  WHERE `AccessionNo`='" & txtAccessionNo.Text & "'"


                    save_or_update(sql, sqladd, sqledit, "Books has been updated in the database.", "New books has been saved in the database.")

                    Call frmBooks_Load(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM `tblbooks` WHERE `AccessionNo` = '" & txtAccessionNo.Text & "'"

        deletes(sql)

        MsgBox("Book has been deleted!", MsgBoxStyle.Information)
        Call btnNew_Click(sender, e)
    End Sub
    Private Sub cboType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboCategory_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategory.KeyPress
        e.Handled = True
    End Sub
    Private Sub dtgList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgList.CellClick
        Try
            With dtgList

                txtAccessionNo.Text = .CurrentRow.Cells(0).Value
                txtTitle.Text = .CurrentRow.Cells(1).Value
                txtDesc.Text = .CurrentRow.Cells(2).Value
                txtAuthor.Text = .CurrentRow.Cells(3).Value
                dtpDatePublish.Value = Format(.CurrentRow.Cells(4).Value, "MM/dd/yyyy")
                txtPublisher.Text = .CurrentRow.Cells(5).Value
                cboCategory.Text = .CurrentRow.Cells(6).Value
                cboType.Text = .CurrentRow.Cells(7).Value

                txtDeweyDecimal.Text = .CurrentRow.Cells(9).Value


                btnUpdate.Enabled = True
                btnSave.Enabled = False
            End With
        Catch ex As Exception

        End Try
    End Sub
End Class