using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            {
                var withBlock = My.MyProject.Forms.frmLogin;
                withBlock.Show();
                withBlock.PasswordTextBox.Clear();
                withBlock.UsernameTextBox.Clear();
                withBlock.UsernameTextBox.Focus();
            }
        }
        private void addForm(Form frm)
        {
            pnlContainer.Controls.Clear();
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(frm);
            frm.Show();
        }

        private void change_menu(string menu)
        {

            switch (menu ?? "")
            {
                case "Books":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 92, 169);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Manage Books";
                        addForm(My.MyProject.Forms.frmBooks);
                        break;
                    }
                case "Borrower":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 92, 169);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Manage Borrower";
                        addForm(My.MyProject.Forms.frmBorrower);
                        break;
                    }
                case "Borrow":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 92, 169);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Borrow Books";
                        addForm(My.MyProject.Forms.frmBorrowBooks);
                        break;
                    }
                case "Return":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 92, 169);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Return Books";
                        addForm(My.MyProject.Forms.frmReturnBooks);
                        break;
                    }
                case "Overdue":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 92, 169);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        addForm(My.MyProject.Forms.frmOverdue);
                        break;
                    }

                case "Category":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 92, 169);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Manage Category";
                        addForm(My.MyProject.Forms.frmCategory);
                        break;
                    }

                case "User":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 92, 169);
                        btnReports.BackColor = Color.FromArgb(0, 50, 95);
                        lblTitle.Text = "Manage Users";
                        addForm(My.MyProject.Forms.frmUser);
                        break;
                    }

                case "Reports":
                    {
                        btnBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrower.BackColor = Color.FromArgb(0, 50, 95);
                        btnBorrowBooks.BackColor = Color.FromArgb(0, 50, 95);
                        btnReturn.BackColor = Color.FromArgb(0, 50, 95);
                        btnOverdues.BackColor = Color.FromArgb(0, 50, 95);
                        btnCategory.BackColor = Color.FromArgb(0, 50, 95);
                        btnUser.BackColor = Color.FromArgb(0, 50, 95);
                        btnReports.BackColor = Color.FromArgb(0, 92, 169);
                        lblTitle.Text = "Generates Reports";
                       // addForm(My.MyProject.Forms.frmReports);
                        break;
                    }
            }

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

            change_menu("User");
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            change_menu("Books");
        }

        private void btnBorrower_Click(object sender, EventArgs e)
        {
            change_menu("Borrower");
        }

        private void btnBorrowBooks_Click(object sender, EventArgs e)
        {
            change_menu("Borrow");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            change_menu("Return");
        }

        private void btnOverdues_Click(object sender, EventArgs e)
        {
            change_menu("Overdue");
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            change_menu("Category");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            change_menu("Reports");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            change_menu("Books");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}