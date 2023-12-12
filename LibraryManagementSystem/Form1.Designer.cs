using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnOverdues = new System.Windows.Forms.Button();
            this.btnBorrowBooks = new System.Windows.Forms.Button();
            this.btnBorrower = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnReports);
            this.Panel1.Controls.Add(this.btnReturn);
            this.Panel1.Controls.Add(this.btnUser);
            this.Panel1.Controls.Add(this.btnCategory);
            this.Panel1.Controls.Add(this.btnOverdues);
            this.Panel1.Controls.Add(this.btnBorrowBooks);
            this.Panel1.Controls.Add(this.btnBorrower);
            this.Panel1.Controls.Add(this.btnBooks);
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(268, 857);
            this.Panel1.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(-2, 791);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(262, 60);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Visible = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(2, 418);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(262, 82);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Teal;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(2, 700);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(262, 82);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "Manage Users";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(2, 605);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(262, 82);
            this.btnCategory.TabIndex = 7;
            this.btnCategory.Text = "Manage \r\nCategories";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnOverdues
            // 
            this.btnOverdues.BackColor = System.Drawing.Color.SlateGray;
            this.btnOverdues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverdues.FlatAppearance.BorderSize = 0;
            this.btnOverdues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverdues.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverdues.ForeColor = System.Drawing.Color.White;
            this.btnOverdues.Image = ((System.Drawing.Image)(resources.GetObject("btnOverdues.Image")));
            this.btnOverdues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverdues.Location = new System.Drawing.Point(2, 509);
            this.btnOverdues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOverdues.Name = "btnOverdues";
            this.btnOverdues.Size = new System.Drawing.Size(262, 82);
            this.btnOverdues.TabIndex = 6;
            this.btnOverdues.Text = "Overdues";
            this.btnOverdues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOverdues.UseVisualStyleBackColor = false;
            this.btnOverdues.Click += new System.EventHandler(this.btnOverdues_Click);
            // 
            // btnBorrowBooks
            // 
            this.btnBorrowBooks.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBorrowBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowBooks.FlatAppearance.BorderSize = 0;
            this.btnBorrowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBooks.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBooks.Image")));
            this.btnBorrowBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBooks.Location = new System.Drawing.Point(3, 328);
            this.btnBorrowBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrowBooks.Name = "btnBorrowBooks";
            this.btnBorrowBooks.Size = new System.Drawing.Size(262, 82);
            this.btnBorrowBooks.TabIndex = 4;
            this.btnBorrowBooks.Text = "Borrow Books";
            this.btnBorrowBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowBooks.UseVisualStyleBackColor = false;
            this.btnBorrowBooks.Click += new System.EventHandler(this.btnBorrowBooks_Click);
            // 
            // btnBorrower
            // 
            this.btnBorrower.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrower.FlatAppearance.BorderSize = 0;
            this.btnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrower.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrower.ForeColor = System.Drawing.Color.White;
            this.btnBorrower.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrower.Image")));
            this.btnBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrower.Location = new System.Drawing.Point(2, 235);
            this.btnBorrower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrower.Name = "btnBorrower";
            this.btnBorrower.Size = new System.Drawing.Size(262, 82);
            this.btnBorrower.TabIndex = 3;
            this.btnBorrower.Text = "Manage \r\nBorrowers";
            this.btnBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrower.UseVisualStyleBackColor = false;
            this.btnBorrower.Click += new System.EventHandler(this.btnBorrower_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(3, 145);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(262, 82);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Manage Books";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))));
            this.Panel3.Controls.Add(this.PictureBox1);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Location = new System.Drawing.Point(-2, -2);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(274, 137);
            this.Panel3.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(130, 57);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Group 3";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.btnLogout);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(268, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1306, 94);
            this.Panel2.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(8, 14);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(657, 69);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Library Management System";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.InitialImage = null;
            this.btnLogout.Location = new System.Drawing.Point(1182, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 78);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 0;
            this.btnLogout.TabStop = false;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(290, 146);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1266, 692);
            this.pnlContainer.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(278, 100);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(66, 35);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(35, 25);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(87, 83);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1574, 857);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Panel Panel1;
        internal Panel Panel2;
        internal Panel Panel3;
        internal Label Label1;
        internal Button btnCategory;
        internal Button btnOverdues;
        internal Button btnReturn;
        internal Button btnBorrowBooks;
        internal Button btnBorrower;
        internal Button btnBooks;
        internal Panel pnlContainer;
        internal PictureBox btnImageButton3;
        internal PictureBox btnImageButton2;
        internal PictureBox btnLogout;
        internal Button btnReports;
        internal Button btnUser;
        internal Label Label2;
        internal Label lblTitle;
        internal PictureBox PictureBox1;
    }
}