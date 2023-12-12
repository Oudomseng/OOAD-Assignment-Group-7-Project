using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmListBooks
    {
        public frmListBooks()
        {
            InitializeComponent();
        }

        private void frmListBooks_Load(object sender, EventArgs e)
        {
            crud.sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks', `BookPrice` as 'Price', DeweyDecimal " + ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId` ";
            crud.reloadDtg(crud.sql, dtgList);
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "SELECT `AccessionNo`, `BookTitle`, `BookDesc` as 'Description', `Author`, `PublishDate`, `BookPublisher`, `Category`,BookType as 'typeOfBooks', `BookPrice` as 'Price', DeweyDecimal " + ", Status FROM `tblbooks` b, `tblcategory` c WHERE b.`CategoryId`=c.`CategoryId`  AND (`BookTitle` Like '%" + txtSearch.Text + "%' OR `Author` Like '%" + txtSearch.Text + "%' OR `AccessionNo` Like '%" + txtSearch.Text + "%')";
            crud.reloadDtg(crud.sql, dtgList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(dtgList.CurrentRow.Cells[10].Value, "Available", false)))
                {
                    My.MyProject.Forms.frmBorrowBooks.txtAccesionNumBorrow.Text = Conversions.ToString(dtgList.CurrentRow.Cells[0].Value);
                    Close();
                }
                else
                {
                    Interaction.MsgBox("The book is already borrowed.", MsgBoxStyle.Exclamation);

                }
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