using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmOverdue : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            btnPenClose = new Button();
            btnPenClose.Click += new EventHandler(btnPenClose_Click);
            btnPenNew = new Button();
            btnPenNew.Click += new EventHandler(btnPenNew_Click);
            btnPSave = new Button();
            btnPSave.Click += new EventHandler(btnPSave_Click);
            GroupBox7 = new GroupBox();
            Label4 = new Label();
            txttothours = new TextBox();
            Label3 = new Label();
            GroupBox10 = new GroupBox();
            txtamount = new TextBox();
            txtamount.TextChanged += new EventHandler(txtamount_TextChanged);
            txtamount.KeyPress += new KeyPressEventHandler(txtamount_KeyPress);
            Label29 = new Label();
            Label2 = new Label();
            Label30 = new Label();
            txthours = new TextBox();
            txthours.TextChanged += new EventHandler(txthours_TextChanged);
            txthours.KeyPress += new KeyPressEventHandler(txtminutes_KeyPress);
            txtChange = new TextBox();
            Label33 = new Label();
            txttenderedAmount = new TextBox();
            txttenderedAmount.TextChanged += new EventHandler(txttenderedAmount_TextChanged);
            txttenderedAmount.KeyPress += new KeyPressEventHandler(txttenderedAmount_KeyPress);
            Label32 = new Label();
            txtTotPay = new TextBox();
            Label31 = new Label();
            txtOverdueTime = new TextBox();
            txtOverdueTime.TextChanged += new EventHandler(txtOverdueTime_TextChanged);
            Label28 = new Label();
            GroupBox9 = new GroupBox();
            Label34 = new Label();
            Label35 = new Label();
            Label36 = new Label();
            Label37 = new Label();
            Label38 = new Label();
            TextBox7 = new TextBox();
            Label39 = new Label();
            Label40 = new Label();
            GroupBox4 = new GroupBox();
            txtSearchPborrower = new TextBox();
            txtSearchPborrower.TextChanged += new EventHandler(txtSearchPborrower_TextChanged);
            txtSearchPborrower.KeyPress += new KeyPressEventHandler(txtSearchPborrower_KeyPress);
            dtgPenalties = new DataGridView();
            dtgPenalties.Click += new EventHandler(dtgPenalties_Click);
            Label27 = new Label();
            GroupBox7.SuspendLayout();
            GroupBox10.SuspendLayout();
            GroupBox9.SuspendLayout();
            GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPenalties).BeginInit();
            SuspendLayout();
            // 
            // btnPenClose
            // 
            btnPenClose.Anchor = AnchorStyles.Top;
            btnPenClose.Cursor = Cursors.Hand;
            btnPenClose.FlatStyle = FlatStyle.Flat;
            btnPenClose.Location = new Point(706, 367);
            btnPenClose.Name = "btnPenClose";
            btnPenClose.Size = new Size(125, 63);
            btnPenClose.TabIndex = 28;
            btnPenClose.Text = "Close";
            btnPenClose.UseVisualStyleBackColor = true;
            // 
            // btnPenNew
            // 
            btnPenNew.Anchor = AnchorStyles.Top;
            btnPenNew.Cursor = Cursors.Hand;
            btnPenNew.FlatStyle = FlatStyle.Flat;
            btnPenNew.Location = new Point(572, 367);
            btnPenNew.Name = "btnPenNew";
            btnPenNew.Size = new Size(125, 63);
            btnPenNew.TabIndex = 26;
            btnPenNew.Text = "New";
            btnPenNew.UseVisualStyleBackColor = true;
            // 
            // btnPSave
            // 
            btnPSave.Anchor = AnchorStyles.Top;
            btnPSave.Cursor = Cursors.Hand;
            btnPSave.FlatStyle = FlatStyle.Flat;
            btnPSave.Location = new Point(441, 367);
            btnPSave.Name = "btnPSave";
            btnPSave.Size = new Size(125, 63);
            btnPSave.TabIndex = 27;
            btnPSave.Text = "Save";
            btnPSave.UseVisualStyleBackColor = true;
            // 
            // GroupBox7
            // 
            GroupBox7.Anchor = AnchorStyles.Top;
            GroupBox7.Controls.Add(Label4);
            GroupBox7.Controls.Add(txttothours);
            GroupBox7.Controls.Add(Label3);
            GroupBox7.Controls.Add(GroupBox10);
            GroupBox7.Controls.Add(txtChange);
            GroupBox7.Controls.Add(Label33);
            GroupBox7.Controls.Add(txttenderedAmount);
            GroupBox7.Controls.Add(Label32);
            GroupBox7.Controls.Add(txtTotPay);
            GroupBox7.Controls.Add(Label31);
            GroupBox7.Controls.Add(txtOverdueTime);
            GroupBox7.Controls.Add(Label28);
            GroupBox7.Controls.Add(GroupBox9);
            GroupBox7.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox7.Location = new Point(424, 28);
            GroupBox7.Name = "GroupBox7";
            GroupBox7.Size = new Size(423, 326);
            GroupBox7.TabIndex = 25;
            GroupBox7.TabStop = false;
            GroupBox7.Text = "Payments";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top;
            Label4.AutoSize = true;
            Label4.Location = new Point(372, 42);
            Label4.Name = "Label4";
            Label4.Size = new Size(34, 17);
            Label4.TabIndex = 11;
            Label4.Text = "hr(s)";
            // 
            // txttothours
            // 
            txttothours.Anchor = AnchorStyles.Top;
            txttothours.Enabled = false;
            txttothours.Location = new Point(308, 39);
            txttothours.Name = "txttothours";
            txttothours.Size = new Size(64, 25);
            txttothours.TabIndex = 18;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Top;
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.Location = new Point(269, 42);
            Label3.Name = "Label3";
            Label3.Size = new Size(17, 17);
            Label3.TabIndex = 11;
            Label3.Text = "=";
            // 
            // GroupBox10
            // 
            GroupBox10.Anchor = AnchorStyles.Top;
            GroupBox10.Controls.Add(txtamount);
            GroupBox10.Controls.Add(Label29);
            GroupBox10.Controls.Add(Label2);
            GroupBox10.Controls.Add(Label30);
            GroupBox10.Controls.Add(txthours);
            GroupBox10.Location = new Point(6, 81);
            GroupBox10.Name = "GroupBox10";
            GroupBox10.Size = new Size(411, 69);
            GroupBox10.TabIndex = 17;
            GroupBox10.TabStop = false;
            GroupBox10.Text = "Payment Per Hours";
            // 
            // txtamount
            // 
            txtamount.Anchor = AnchorStyles.Top;
            txtamount.Location = new Point(89, 27);
            txtamount.Name = "txtamount";
            txtamount.RightToLeft = RightToLeft.Yes;
            txtamount.Size = new Size(106, 25);
            txtamount.TabIndex = 8;
            // 
            // Label29
            // 
            Label29.Anchor = AnchorStyles.Top;
            Label29.AutoSize = true;
            Label29.Location = new Point(23, 30);
            Label29.Name = "Label29";
            Label29.Size = new Size(60, 17);
            Label29.TabIndex = 7;
            Label29.Text = "Amount :";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.Location = new Point(341, 30);
            Label2.Name = "Label2";
            Label2.Size = new Size(35, 17);
            Label2.TabIndex = 9;
            Label2.Text = "hour";
            // 
            // Label30
            // 
            Label30.Anchor = AnchorStyles.Top;
            Label30.AutoSize = true;
            Label30.Location = new Point(201, 30);
            Label30.Name = "Label30";
            Label30.Size = new Size(28, 17);
            Label30.TabIndex = 9;
            Label30.Text = "per";
            // 
            // txthours
            // 
            txthours.Anchor = AnchorStyles.Top;
            txthours.Location = new Point(247, 27);
            txthours.Name = "txthours";
            txthours.Size = new Size(88, 25);
            txthours.TabIndex = 10;
            // 
            // txtChange
            // 
            txtChange.Anchor = AnchorStyles.Top;
            txtChange.Enabled = false;
            txtChange.Font = new Font("Segoe UI", 20.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChange.Location = new Point(152, 267);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(254, 43);
            txtChange.TabIndex = 16;
            // 
            // Label33
            // 
            Label33.Anchor = AnchorStyles.Top;
            Label33.AutoSize = true;
            Label33.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label33.Location = new Point(10, 267);
            Label33.Name = "Label33";
            Label33.Size = new Size(70, 21);
            Label33.TabIndex = 15;
            Label33.Text = "Change :";
            // 
            // txttenderedAmount
            // 
            txttenderedAmount.Anchor = AnchorStyles.Top;
            txttenderedAmount.Font = new Font("Segoe UI", 20.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttenderedAmount.Location = new Point(153, 218);
            txttenderedAmount.Name = "txttenderedAmount";
            txttenderedAmount.Size = new Size(254, 43);
            txttenderedAmount.TabIndex = 14;
            // 
            // Label32
            // 
            Label32.Anchor = AnchorStyles.Top;
            Label32.AutoSize = true;
            Label32.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label32.Location = new Point(10, 218);
            Label32.Name = "Label32";
            Label32.Size = new Size(140, 21);
            Label32.TabIndex = 13;
            Label32.Text = "Tendered Amount :";
            // 
            // txtTotPay
            // 
            txtTotPay.Anchor = AnchorStyles.Top;
            txtTotPay.Enabled = false;
            txtTotPay.Font = new Font("Segoe UI", 20.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotPay.Location = new Point(152, 169);
            txtTotPay.Name = "txtTotPay";
            txtTotPay.Size = new Size(254, 43);
            txtTotPay.TabIndex = 12;
            // 
            // Label31
            // 
            Label31.Anchor = AnchorStyles.Top;
            Label31.AutoSize = true;
            Label31.Font = new Font("Segoe UI", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label31.Location = new Point(10, 170);
            Label31.Name = "Label31";
            Label31.Size = new Size(120, 21);
            Label31.TabIndex = 11;
            Label31.Text = "Total Payments :";
            // 
            // txtOverdueTime
            // 
            txtOverdueTime.Anchor = AnchorStyles.Top;
            txtOverdueTime.Enabled = false;
            txtOverdueTime.Location = new Point(110, 39);
            txtOverdueTime.Name = "txtOverdueTime";
            txtOverdueTime.Size = new Size(142, 25);
            txtOverdueTime.TabIndex = 6;
            // 
            // Label28
            // 
            Label28.Anchor = AnchorStyles.Top;
            Label28.AutoSize = true;
            Label28.Location = new Point(11, 42);
            Label28.Name = "Label28";
            Label28.Size = new Size(93, 17);
            Label28.TabIndex = 5;
            Label28.Text = "Overdue Time:";
            // 
            // GroupBox9
            // 
            GroupBox9.Anchor = AnchorStyles.Top;
            GroupBox9.Controls.Add(Label34);
            GroupBox9.Controls.Add(Label35);
            GroupBox9.Controls.Add(Label36);
            GroupBox9.Controls.Add(Label37);
            GroupBox9.Controls.Add(Label38);
            GroupBox9.Controls.Add(TextBox7);
            GroupBox9.Controls.Add(Label39);
            GroupBox9.Controls.Add(Label40);
            GroupBox9.Location = new Point(506, 144);
            GroupBox9.Name = "GroupBox9";
            GroupBox9.Size = new Size(45, 25);
            GroupBox9.TabIndex = 4;
            GroupBox9.TabStop = false;
            GroupBox9.Text = "do not touch.Time and Days for the future used. ";
            // 
            // Label34
            // 
            Label34.Anchor = AnchorStyles.Top;
            Label34.AutoSize = true;
            Label34.Location = new Point(71, 26);
            Label34.Name = "Label34";
            Label34.Size = new Size(53, 17);
            Label34.TabIndex = 7;
            Label34.Text = "Label25";
            // 
            // Label35
            // 
            Label35.Anchor = AnchorStyles.Top;
            Label35.AutoSize = true;
            Label35.Location = new Point(71, 52);
            Label35.Name = "Label35";
            Label35.Size = new Size(53, 17);
            Label35.TabIndex = 4;
            Label35.Text = "Label25";
            // 
            // Label36
            // 
            Label36.Anchor = AnchorStyles.Top;
            Label36.AutoSize = true;
            Label36.Location = new Point(75, 122);
            Label36.Name = "Label36";
            Label36.Size = new Size(53, 17);
            Label36.TabIndex = 6;
            Label36.Text = "Label26";
            // 
            // Label37
            // 
            Label37.Anchor = AnchorStyles.Top;
            Label37.AutoSize = true;
            Label37.Location = new Point(15, 122);
            Label37.Name = "Label37";
            Label37.Size = new Size(59, 17);
            Label37.TabIndex = 5;
            Label37.Text = "Change :";
            // 
            // Label38
            // 
            Label38.Anchor = AnchorStyles.Top;
            Label38.AutoSize = true;
            Label38.Location = new Point(6, 87);
            Label38.Name = "Label38";
            Label38.Size = new Size(119, 17);
            Label38.TabIndex = 3;
            Label38.Text = "Tendered Amount :";
            // 
            // TextBox7
            // 
            TextBox7.Anchor = AnchorStyles.Top;
            TextBox7.Location = new Point(132, 84);
            TextBox7.Name = "TextBox7";
            TextBox7.Size = new Size(177, 25);
            TextBox7.TabIndex = 2;
            // 
            // Label39
            // 
            Label39.Anchor = AnchorStyles.Top;
            Label39.AutoSize = true;
            Label39.Location = new Point(6, 52);
            Label39.Name = "Label39";
            Label39.Size = new Size(70, 17);
            Label39.TabIndex = 1;
            Label39.Text = "Payments :";
            // 
            // Label40
            // 
            Label40.Anchor = AnchorStyles.Top;
            Label40.AutoSize = true;
            Label40.Location = new Point(6, 26);
            Label40.Name = "Label40";
            Label40.Size = new Size(70, 17);
            Label40.TabIndex = 0;
            Label40.Text = "Over Due :";
            // 
            // GroupBox4
            // 
            GroupBox4.Anchor = AnchorStyles.Top;
            GroupBox4.Controls.Add(txtSearchPborrower);
            GroupBox4.Controls.Add(dtgPenalties);
            GroupBox4.Controls.Add(Label27);
            GroupBox4.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox4.Location = new Point(4, 5);
            GroupBox4.Name = "GroupBox4";
            GroupBox4.Size = new Size(414, 454);
            GroupBox4.TabIndex = 24;
            GroupBox4.TabStop = false;
            GroupBox4.Text = "View Details of unreturned books with Penalties";
            // 
            // txtSearchPborrower
            // 
            txtSearchPborrower.Anchor = AnchorStyles.Top;
            txtSearchPborrower.Location = new Point(145, 23);
            txtSearchPborrower.Name = "txtSearchPborrower";
            txtSearchPborrower.Size = new Size(263, 25);
            txtSearchPborrower.TabIndex = 23;
            // 
            // dtgPenalties
            // 
            dtgPenalties.AllowUserToAddRows = false;
            dtgPenalties.AllowUserToDeleteRows = false;
            dtgPenalties.AllowUserToResizeColumns = false;
            dtgPenalties.AllowUserToResizeRows = false;
            dtgPenalties.Anchor = AnchorStyles.Top;
            dtgPenalties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPenalties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPenalties.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtgPenalties.Location = new Point(8, 54);
            dtgPenalties.MultiSelect = false;
            dtgPenalties.Name = "dtgPenalties";
            dtgPenalties.RowHeadersVisible = false;
            dtgPenalties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPenalties.Size = new Size(400, 393);
            dtgPenalties.TabIndex = 0;
            // 
            // Label27
            // 
            Label27.Anchor = AnchorStyles.Top;
            Label27.AutoSize = true;
            Label27.Location = new Point(55, 26);
            Label27.Name = "Label27";
            Label27.Size = new Size(84, 17);
            Label27.TabIndex = 22;
            Label27.Text = "Borrower Id :";
            // 
            // frmOverdue
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(btnPenClose);
            Controls.Add(btnPenNew);
            Controls.Add(btnPSave);
            Controls.Add(GroupBox7);
            Controls.Add(GroupBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOverdue";
            Text = "frmOverdue";
            GroupBox7.ResumeLayout(false);
            GroupBox7.PerformLayout();
            GroupBox10.ResumeLayout(false);
            GroupBox10.PerformLayout();
            GroupBox9.ResumeLayout(false);
            GroupBox9.PerformLayout();
            GroupBox4.ResumeLayout(false);
            GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgPenalties).EndInit();
            Load += new EventHandler(frmPayments_Load);
            ResumeLayout(false);

        }

        internal Button btnPenClose;
        internal Button btnPenNew;
        internal Button btnPSave;
        internal GroupBox GroupBox7;
        internal Label Label4;
        internal TextBox txttothours;
        internal Label Label3;
        internal GroupBox GroupBox10;
        internal TextBox txtamount;
        internal Label Label29;
        internal Label Label2;
        internal Label Label30;
        internal TextBox txthours;
        internal TextBox txtChange;
        internal Label Label33;
        internal TextBox txttenderedAmount;
        internal Label Label32;
        internal TextBox txtTotPay;
        internal Label Label31;
        internal TextBox txtOverdueTime;
        internal Label Label28;
        internal GroupBox GroupBox9;
        internal Label Label34;
        internal Label Label35;
        internal Label Label36;
        internal Label Label37;
        internal Label Label38;
        internal TextBox TextBox7;
        internal Label Label39;
        internal Label Label40;
        internal GroupBox GroupBox4;
        internal TextBox txtSearchPborrower;
        internal DataGridView dtgPenalties;
        internal Label Label27;
    }
}