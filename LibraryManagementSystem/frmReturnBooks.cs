using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmReturnBooks
    {
        public frmReturnBooks()
        {
            InitializeComponent();
        }
        private void frmReturn_Load(object sender, EventArgs e)
        {


            crud.sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_RlistReturn);
            dtg_RlistReturn.Columns[5].Visible = false;
            dtg_RlistReturn.Columns[6].Visible = false;


            crud.sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`, `DateReturned` " + " FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b " + " WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned' ORDER BY ReturnId Desc";
            crud.reloadDtg(crud.sql, dtgListreturned);




        }

        private void dtg_RlistReturn_Click(object sender, EventArgs e)
        {
            try
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject("SELECT *  " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND BorrowId=", dtg_RlistReturn.CurrentRow.Cells[5].Value));
                crud.reloadtxt(crud.sql);
                if (crud.dt.Rows.Count > 0)
                {
                    {
                        var withBlock = crud.dt.Rows[0];
                        txtRname.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(withBlock["Firstname"], " "), withBlock["Lastname"]));
                        txtRbookTitle.Text = Conversions.ToString(withBlock["BookTitle"]);
                        txtRdescription.Text = Conversions.ToString(withBlock["BookDesc"]);
                        txtRauthor.Text = Conversions.ToString(withBlock["Author"]);

                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtSearchPborrower_TextChanged(object sender, EventArgs e)
        {

            crud.sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" + txtSearchPborrower.Text + "%' ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_RlistReturn);
            dtg_RlistReturn.Columns[5].Visible = false;
            dtg_RlistReturn.Columns[6].Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Rsave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRname.Text))
            {
                Interaction.MsgBox("There is no borrower in the fields.", MsgBoxStyle.Exclamation);
            }
            // ElseIf Val(txtRRqty.Text) < Val(txtRCopyBorrowed.Text) Then
            // MsgBox("The return quantity is less than the number of the books that you had borrow.", MsgBoxStyle.Exclamation)
            // ElseIf Val(txtRRqty.Text) > Val(txtRCopyBorrowed.Text) Then
            // MsgBox("The return quantity is greater than the number of the books that you had borrow.", MsgBoxStyle.Exclamation)
            else
            {
                crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" + " VALUES (", dtg_RlistReturn.CurrentRow.Cells[5].Value), ",1,NOW(),'Returned')"));

                crud.result = Conversions.ToString(crud.create(crud.sql));
                if (Conversions.ToBoolean(crud.result) == true)
                {

                    crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE `tblborrow` SET  `Status` =  'Returned',`Remarks`='On Time' WHERE `BorrowId` = '", dtg_RlistReturn.CurrentRow.Cells[5].Value), "'"));
                    crud.updates(crud.sql);

                    // sql = "UPDATE  `tblbooks` SET  `BookQuantity` = `BookQuantity` + " & txtRCopyBorrowed.Text & " WHERE  `AccessionNo` = " & dtg_RlistReturn.CurrentRow.Cells(7).Value
                    // updates(sql)

                    crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '", dtg_RlistReturn.CurrentRow.Cells[6].Value), "'"));
                    crud.updates(crud.sql);


                    Interaction.MsgBox("Book has been returned in the library.");


                    frmReturn_Load(sender, e);


                    funtion.cleartext(grp_Rgroup);
                }
            }

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            crud.sql = "SELECT br.`BorrowerId`, `BookTitle`, `DateBorrowed`, `Purpose`, `DueDate`,BorrowId,br.AccessionNo " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=0 AND br.`BorrowerId` LIKE '%" + txtSearchPborrower.Text + "%' ORDER BY BorrowId Desc";
            crud.reloadDtg(crud.sql, dtg_RlistReturn);
            dtg_RlistReturn.Columns[5].Visible = false;
            dtg_RlistReturn.Columns[6].Visible = false;

            funtion.cleartext(grp_Rgroup);
        }

        private void txtrbooksSearch_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "SELECT bw.`BorrowerId`, `Firstname`, `Lastname`,DateBorrowed,b.`AccessionNo`,`BookTitle`, `BookDesc`,`DateReturned` " + " FROM `tblreturn` r, `tblborrow` br,`tblborrower` bw, `tblbooks` b " + " WHERE r.`BorrowId`=br.`BorrowId` AND br.`AccessionNo`=b.`AccessionNo` AND br.`BorrowerId`=bw.`BorrowerId` AND br.`Status` = 'Returned'" + " AND  (bw.`BorrowerId` Like '%" + txtrbooksSearch.Text + "%' OR b.`AccessionNo` Like '%" + txtrbooksSearch.Text + "%' OR  `Firstname` Like '%" + txtrbooksSearch.Text + "%' OR Lastname Like '%" + txtrbooksSearch.Text + "%' OR BookTitle Like '%" + txtrbooksSearch.Text + "%') ORDER BY ReturnId Desc";
            crud.reloadDtg(crud.sql, dtgListreturned);
        }

        private void check_due_Tick(object sender, EventArgs e)
        {

            crud.sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId FROM tblborrow Where  Status='Borrowed' AND purpose = 'Photocopy' ";
            funtion.checkOverduePurposed(crud.sql, "Photocopy");
            crud.sql = "SELECT MINUTE(TIMEDIFF(Now(),DateBorrowed)),BorrowId,DateBorrowed FROM tblborrow Where  Status='Borrowed' AND Purpose = 'Research'";
            funtion.checkOverduePurposed(crud.sql, "Research");
            crud.sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Overnight'";
            funtion.checkOverduePurposed(crud.sql, "Overnight");
            crud.sql = "SELECT HOUR( TIMEDIFF( NOW( ) ,  `DateBorrowed` ) ) AS  'time',`BorrowId` FROM   `tblborrow` Where Status='Borrowed' AND Purpose = 'Borrowed for 3days'";
            funtion.checkOverduePurposed(crud.sql, "Borrowed for 3days");
        }

        #region numbers only
        private void txtSearchPborrower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtRRqty_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}