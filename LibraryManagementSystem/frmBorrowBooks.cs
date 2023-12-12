using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmBorrowBooks
    {
        public frmBorrowBooks()
        {
            InitializeComponent();
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            crud.sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower', `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_BlistOfBooks);

            check_due.Start();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            crud.sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower', `DateBorrowed`, `Purpose`, `DueDate` " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND (BookTitle Like '%" + txt_Search.Text + "' or br.AccessionNo Like '%" + txt_Search.Text + "%' OR Concat(`Firstname`,' ', `Lastname`)  Like '%" + txt_Search.Text + "') ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_BlistOfBooks);
        }

        private void btnSearchAccesion_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.frmListBooks;
                withBlock.btnAdd.Visible = true;
                withBlock.ShowDialog();
            }
        }

        private void txtAccesionNumBorrow_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccesionNumBorrow.Text))
            {
                txtTitle.Clear();
                txtAuthor.Clear();
                txtDatePublish.Clear();
                txtpublisher.Clear();
                txtbooktype.Clear();
            }
            else
            {
                crud.sql = "Select * From tblbooks b, tblcategory c WHERE b.CategoryId=c.CategoryId AND AccessionNo='" + txtAccesionNumBorrow.Text + "'";
                crud.reloadtxt(crud.sql);
                // `AccessionNo`, `BookTitle`, `Author`, `PublishDate`, `BookPublisher`, `BookQuantity`
                if (crud.dt.Rows.Count > 0)
                {
                    {
                        var withBlock = crud.dt.Rows[0];
                        txtTitle.Text = Conversions.ToString(withBlock["BookTitle"]);
                        txtAuthor.Text = Conversions.ToString(withBlock["Author"]);
                        txtDatePublish.Text = Conversions.ToString(withBlock["PublishDate"]);
                        txtpublisher.Text = Conversions.ToString(withBlock["BookPublisher"]);
                        txtbooktype.Text = Conversions.ToString(withBlock["BookType"]);
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            funtion.cleartext(GroupBox1);
            funtion.cleartext(grp_Bgroup);
            crud.sql = " SELECT br.`AccessionNo`, `BookTitle`, `BookDesc` as 'Description',Concat(`Firstname`,' ', `Lastname`) as 'Borrower',`NoCopies`, `DateBorrowed`, `Purpose`, `DueDate` FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_BlistOfBooks);
        }

        private void btnSearchBorrower_Click(object sender, EventArgs e)
        {
            {
                var withBlock = My.MyProject.Forms.frmListBorrower;
                withBlock.btnAdd.Visible = true;
                withBlock.ShowDialog();
            }
        }

        private void txtBorrowerId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBorrowerId.Text))
            {
                txtName.Clear();
                txtCourse.Clear();
            }
            else
            {
                crud.reloadtxt("SELECT * FROM `tblborrower` WHERE `BorrowerId` = '" + txtBorrowerId.Text + "'");

                if (crud.dt.Rows.Count > 0)
                {
                    txtName.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(crud.dt.Rows[0]["Firstname"], " "), crud.dt.Rows[0]["Lastname"]));
                    txtCourse.Text = Conversions.ToString(crud.dt.Rows[0]["CourseYear"]);
                }


                else
                {
                    txtName.Clear();
                    txtCourse.Clear();
                }
            }

        }

        private void btn_Bsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccesionNumBorrow.Text) | string.IsNullOrEmpty(txtBorrowerId.Text))
                {
                    Interaction.MsgBox("All fields are required.", MsgBoxStyle.Exclamation);
                }
                else if (cboPurpose.Text == "Select")
                {
                    Interaction.MsgBox("Pls. choose your porpuse.", MsgBoxStyle.Exclamation);
                }
                else
                {


                    DateTime formatdate;
                    if (cboPurpose.Text == "Photocopy")
                    {
                        formatdate = DateAndTime.DateAdd(DateInterval.Minute, 30d, DateTime.Now);
                        txtdue.Text = Strings.Format(formatdate, "yyyy-MM-dd HH:mm:ss");
                    }

                    else if (cboPurpose.Text == "Research")
                    {

                        if (Strings.Format(DateTime.Now, "tt") == "AM")
                        {
                            txtdue.Text = Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " 11:30:00";
                        }
                        else if (Strings.Format(DateTime.Now, "tt") == "PM")
                        {
                            txtdue.Text = Strings.Format(DateTime.Now.Date, "yyyy-MM-dd") + " 17:30:00";
                        }
                    }

                    else if (cboPurpose.Text == "Overnight")
                    {
                        formatdate = DateAndTime.DateAdd(DateInterval.Hour, 24d, DateTime.Now);
                        txtdue.Text = Strings.Format(formatdate, "yyyy-MM-dd HH:mm:ss");

                        // ElseIf txtbooktype.Text.ToUpper() = "FICTION" Then

                        // formatdate = DateAdd(DateInterval.Hour, 72, Now)
                        // txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")


                        // ElseIf txtbooktype.Text.ToUpper() = "NON-FICTION" Then

                        // formatdate = DateAdd(DateInterval.Hour, 24, Now)
                        // txtdue.Text = Format(formatdate, "yyyy-MM-dd HH:mm:ss")

                    }


                    crud.sql = "INSERT INTO  `tblborrow`  " + " (`AccessionNo`, `NoCopies`, `DateBorrowed`, `Purpose`, `Status`, `DueDate`, `BorrowerId`) " + " VALUES ('" + txtAccesionNumBorrow.Text + "',1,NOW(),'" + cboPurpose.Text + "', 'Borrowed','" + txtdue.Text + "','" + txtBorrowerId.Text + "')";
                    crud.result = Conversions.ToString(crud.create(crud.sql));

                    if (Conversions.ToBoolean(crud.result) == true)
                    {
                        Interaction.MsgBox("Book has been borrowed in the library");
                        crud.updates("UPDATE tblbooks set Status = 'Not Available' Where AccessionNo='" + txtAccesionNumBorrow.Text + "'");
                    }



                    // 'updates the items copy
                    // updates("UPDATE tblbooks set BookQuantity = BookQuantity - '" _
                    // & txtNumBorCopies.Text & "' Where AccessionNo='" & txtAccesionNumBorrow.Text & "'")




                    btnNew_Click(sender, e);

                    // edit("UPDATE borrowers set statistic = statistic + 1  Where borrower_id='" _
                    // & cboBorrowerId.Text & "'")

                    // edit("UPDATE replica_items set statistic = statistic + 1  Where accessionNumber='" _
                    // & txtAccesionNumBorrow.Text & "'")

                    // 'call fisr load to refresh the record
                    // Call First_Load(sender, e)
                    // cboBorrowerId.Text = ""
                    // txtAccesionNumBorrow.Clear()
                    // check_due.Start()
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void check_due_Tick(object sender, EventArgs e)
        {

            crud.sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId FROM tblborrow Where  Status='Borrowed' AND purpose = 'Photocopy' ";
            funtion.checkOverduePurposed(crud.sql, "Photocopy");
            crud.sql = "SELECT BorrowId FROM tblborrow Where  Status='Borrowed' AND Purpose = 'Research'";
            funtion.checkOverduePurposed(crud.sql, "Research");
            crud.sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'";
            funtion.checkOverduePurposed(crud.sql, "Overnight");
            crud.sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'";
            funtion.checkOverduePurposed(crud.sql, "Borrowed for 3days");

        }
        #region numbers only
        private void txtAccesionNumBorrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtBorrowerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtNumBorCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        private void cboPurpose_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
            }
            // If txtbooktype.Text.ToUpper() = "FICTION" Then
            // cboPurpose.Text = "Borrowed for 3days"
            // cboPurpose.Enabled = False

            // ElseIf txtbooktype.Text.ToUpper() = "NON-FICTION" Then
            // cboPurpose.Text = "Overnight"
            // cboPurpose.Enabled = False
            // Else
            // cboPurpose.Enabled = True
            // cboPurpose.Text = "Select"

            // End If
            catch (Exception ex)
            {

            }
        }
    }
}