using System;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmListBorrower
    {
        public frmListBorrower()
        {
            InitializeComponent();
        }
        private void frmListBorrower_Load(object sender, EventArgs e)
        {
            crud.sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` ";
            crud.reloadDtg(crud.sql, dtgList);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "SELECT BorrowerId,`Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear` as 'Course/Year' FROM `tblborrower` WHERE BorrowerId Like '%" + txtSearch.Text + "%' OR `Firstname` Like '%" + txtSearch.Text + "%'  OR  `Lastname` Like '%" + txtSearch.Text + "%' OR  BorrowerId Like '%" + txtSearch.Text + "%'";
            crud.reloadDtg(crud.sql, dtgList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                My.MyProject.Forms.frmBorrowBooks.txtBorrowerId.Text = Conversions.ToString(dtgList.CurrentRow.Cells[0].Value);
                Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}