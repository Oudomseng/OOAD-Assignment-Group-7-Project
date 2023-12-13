using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class frmOverdue
    {
        public frmOverdue()
        {
            InitializeComponent();
        }
        private void btnPenClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            crud.sql = "SELECT br.`BorrowerId`, `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw  " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND Due=1 ";
            crud.reloadDtg(crud.sql, dtgPenalties);
            dtgPenalties.Columns[5].Visible = false;
            dtgPenalties.Columns[6].Visible = false;

            funtion.cleartext(GroupBox7);
            funtion.cleartext(GroupBox10);
        }

        private void txtSearchPborrower_TextChanged(object sender, EventArgs e)
        {
            crud.sql = "SELECT br.`BorrowerId`, `BookTitle`,`DateBorrowed`, `Purpose`, `DueDate` , BorrowId,br.AccessionNo " + " FROM `tblborrow` br,`tblbooks` b,`tblborrower` bw " + " WHERE br.AccessionNo=b.AccessionNo AND br.`BorrowerId`=bw.`BorrowerId` AND br.Status='Borrowed' AND DueDate > '" + DateTime.Now + "' AND br.`BorrowerId` Like '%" + txtSearchPborrower.Text + "%'";
            crud.reloadDtg(crud.sql, dtgPenalties);
            dtgPenalties.Columns[5].Visible = false;
            dtgPenalties.Columns[6].Visible = false;
        }

        private void dtgPenalties_Click(object sender, EventArgs e)
        {

            try
            {
                crud.sql = "SELECT  TIMEDIFF( NOW( ) ,  `DueDate` ),`AccessionNo` " + "FROM  `tblborrow` WHERE `BorrowId` = '" + dtgPenalties.CurrentRow.Cells[5].Value.ToString() + "'";
                crud.reloadtxt(crud.sql);
                if (crud.dt.Rows.Count > 0)
                {

                    TimeSpan ts = (TimeSpan)crud.dt.Rows[0][0];
                    int tsdays;
                    int hourperday;
                    int tshours;
                    int totalhours;

                    tsdays = ts.Days;

                    hourperday = tsdays * 24;
                    tshours = ts.Hours;

                    totalhours = hourperday + tshours;



                    txtOverdueTime.Text = ts.ToString();
                    txttothours.Text = totalhours.ToString();
                    // MsgBox(dt.Rows(0).Item(0).ToString)
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtamount.Text))
                {
                    txtTotPay.Text = "";
                }
                else if (Information.IsNumeric(txtamount.Text))
                {
                    funtion.formulaofpayments();
                }
                else
                {
                    txtamount.Clear();

                }
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }

        }

        private void txthours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txthours.Text))
                {
                    txtTotPay.Text = "";
                }
                else if (Information.IsNumeric(txthours.Text))
                {
                    funtion.formulaofpayments();
                }
                else
                {
                    txthours.Clear();

                }
            }
            catch (Exception ex)
            {
                // MsgBox(ex.Message)
            }
        }

        private void txttenderedAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txttenderedAmount.Text))
                {
                    txtChange.Text = "";
                }
                else if (Information.IsNumeric(txttenderedAmount.Text))
                {
                    txtChange.Text = (Conversion.Val(txttenderedAmount.Text) - Conversion.Val(txtTotPay.Text)).ToString();
                }
                else
                {
                    txttenderedAmount.Clear();

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message + " txttenderedAmount_TextChanged");
            }
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtamount.Text) | string.IsNullOrEmpty(txthours.Text) | string.IsNullOrEmpty(txttenderedAmount.Text) | string.IsNullOrEmpty(txtOverdueTime.Text))
                {
                    Interaction.MsgBox("You must fill all the fields inorder to save.", MsgBoxStyle.Exclamation);
                }
                else if (Conversion.Val(txtChange.Text) < 0d)
                {
                    Interaction.MsgBox("The tendered amount is less than the total payments. Its not valid.", MsgBoxStyle.Exclamation);
                }
                else
                {
                    // save to penalties
                    crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO `tblpayment` (`BorrowId`, `Payment`, `Change`, `DatePayed`, `BorrowerId`, `Remarks`) " + " VALUES (", dtgPenalties.CurrentRow.Cells[6].Value), ",'"), txtTotPay.Text), "','"), txtChange.Text), "',Now(),'"), dtgPenalties.CurrentRow.Cells[0].Value), "','Settled')"));
                    crud.result = Conversions.ToString(crud.create(crud.sql));

                    if (Conversions.ToBoolean(crud.result) == true)
                    {
                        // '''''
                        // save to return
                        crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO `tblreturn` (`BorrowId`, `NoCopies`, `DateReturned`, `Remarks`)" + " VALUES (", dtgPenalties.CurrentRow.Cells[6].Value), ",1,NOW(),'Returned')"));
                        crud.create(crud.sql);

                        // for the items

                        crud.sql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE  `tblbooks` SET  `Status` =  'Available' WHERE  `AccessionNo` = '", dtgPenalties.CurrentRow.Cells[6].Value), "'"));
                        crud.updates(crud.sql);

                        // for the borrow
                        crud.sql = Conversions.ToString(Operators.ConcatenateObject("UPDATE `tblborrow` SET  `Status` =  'Returned', Due = 0 WHERE `BorrowId` = ", dtgPenalties.CurrentRow.Cells[5].Value));
                        crud.updates(crud.sql);
                        // call the first load 

                        Interaction.MsgBox("Book has been returned and settled in the library");
                        // call fisr load to refresh the record
                        frmPayments_Load(sender, e);

                    }
                }
            }


            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message + " btnPSave_Click");
            }
        }

        private void btnPenNew_Click(object sender, EventArgs e)
        {
            funtion.cleartext(GroupBox7);
            funtion.cleartext(GroupBox10);
            frmPayments_Load(sender, e);
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
        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8 && !(Conversions.ToString(e.KeyChar) == "."))
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txtminutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        private void txttenderedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8 && !(Conversions.ToString(e.KeyChar) == "."))
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        private void txtOverdueTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}