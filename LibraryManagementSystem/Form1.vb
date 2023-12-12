Public Class Form1
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        With frmLogin
            .Show()
            .PasswordTextBox.Clear()
            .UsernameTextBox.Clear()
            .UsernameTextBox.Focus()
        End With
    End Sub
    Private Sub addForm(frm As Form)
        pnlContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = Dock.Fill
        pnlContainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(menu As String)

        Select Case menu
            Case "Books"
                btnBooks.BackColor = Color.FromArgb(0, 92, 169)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Manage Books"
                addForm(frmBooks)
            Case "Borrower"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 92, 169)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Manage Borrower"
                addForm(frmBorrower)
            Case "Borrow"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 92, 169)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Borrow Books"
                addForm(frmBorrowBooks)
            Case "Return"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 92, 169)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Return Books"
                addForm(frmReturnBooks)
            Case "Overdue"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 92, 169)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                addForm(frmOverdue)

            Case "Category"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 92, 169)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Manage Category"
                addForm(frmCategory)

            Case "User"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 92, 169)
                btnReports.BackColor = Color.FromArgb(0, 50, 95)
                lblTitle.Text = "Manage Users"
                addForm(frmUser)

            Case "Reports"
                btnBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrower.BackColor = Color.FromArgb(0, 50, 95)
                btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95)
                btnReturn.BackColor = Color.FromArgb(0, 50, 95)
                btnOverdues.BackColor = Color.FromArgb(0, 50, 95)
                btnCategory.BackColor = Color.FromArgb(0, 50, 95)
                btnUser.BackColor = Color.FromArgb(0, 50, 95)
                btnReports.BackColor = Color.FromArgb(0, 92, 169)
                lblTitle.Text = "Generates Reports"
                addForm(frmReports)
        End Select

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        change_menu("User")
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click
        change_menu("Books")
    End Sub

    Private Sub btnBorrower_Click(sender As Object, e As EventArgs) Handles btnBorrower.Click
        change_menu("Borrower")
    End Sub

    Private Sub btnBorrowBooks_Click(sender As Object, e As EventArgs) Handles btnBorrowBooks.Click
        change_menu("Borrow")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        change_menu("Return")
    End Sub

    Private Sub btnOverdues_Click(sender As Object, e As EventArgs) Handles btnOverdues.Click
        change_menu("Overdue")
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        change_menu("Category")
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        change_menu("Reports")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_menu("Books")
    End Sub




End Class
