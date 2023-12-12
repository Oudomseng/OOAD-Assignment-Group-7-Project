using System;

namespace LibraryManagementSystem
{
    public partial class frmLogin
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            user.login(UsernameTextBox.Text, PasswordTextBox.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}