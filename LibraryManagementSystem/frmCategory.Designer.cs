using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmCategory : Form
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
            btndelete = new Button();
            btndelete.Click += new EventHandler(btndelete_Click);
            txtSearch = new TextBox();
            txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            Label3 = new Label();
            btnnew = new Button();
            btnnew.Click += new EventHandler(btnnew_Click);
            btnsave = new Button();
            btnsave.Click += new EventHandler(btnsave_Click);
            dtglist = new DataGridView();
            dtglist.DoubleClick += new EventHandler(dtglist_DoubleClick);
            dtglist.Click += new EventHandler(dtglist_Click);
            txtDeweyDecimal = new TextBox();
            Label4 = new Label();
            txtCategory = new TextBox();
            Label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtglist).BeginInit();
            SuspendLayout();
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.Top;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(351, 72);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(64, 45);
            btndelete.TabIndex = 18;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.BackColor = Color.White;
            txtSearch.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(503, 145);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(344, 23);
            txtSearch.TabIndex = 17;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Top;
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Location = new Point(432, 148);
            Label3.Name = "Label3";
            Label3.Size = new Size(65, 17);
            Label3.TabIndex = 16;
            Label3.Text = "Search : ";
            // 
            // btnnew
            // 
            btnnew.Anchor = AnchorStyles.Top;
            btnnew.FlatStyle = FlatStyle.Flat;
            btnnew.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnew.Location = new Point(418, 72);
            btnnew.Name = "btnnew";
            btnnew.Size = new Size(64, 45);
            btnnew.TabIndex = 14;
            btnnew.Text = "New";
            btnnew.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Anchor = AnchorStyles.Top;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsave.Location = new Point(284, 72);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(64, 45);
            btnsave.TabIndex = 15;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // dtglist
            // 
            dtglist.AllowUserToAddRows = false;
            dtglist.AllowUserToDeleteRows = false;
            dtglist.AllowUserToResizeColumns = false;
            dtglist.AllowUserToResizeRows = false;
            dtglist.Anchor = AnchorStyles.Top;
            dtglist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtglist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtglist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtglist.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtglist.Location = new Point(12, 174);
            dtglist.Name = "dtglist";
            dtglist.RowHeadersVisible = false;
            dtglist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtglist.Size = new Size(835, 278);
            dtglist.TabIndex = 11;
            // 
            // txtDeweyDecimal
            // 
            txtDeweyDecimal.Anchor = AnchorStyles.Top;
            txtDeweyDecimal.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeweyDecimal.Location = new Point(280, 43);
            txtDeweyDecimal.Name = "txtDeweyDecimal";
            txtDeweyDecimal.Size = new Size(321, 23);
            txtDeweyDecimal.TabIndex = 12;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top;
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(163, 46);
            Label4.Name = "Label4";
            Label4.Size = new Size(112, 17);
            Label4.TabIndex = 8;
            Label4.Text = "Dewey Decimal :";
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top;
            txtCategory.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(280, 14);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(321, 23);
            txtCategory.TabIndex = 10;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(163, 17);
            Label2.Name = "Label2";
            Label2.Size = new Size(77, 17);
            Label2.TabIndex = 9;
            Label2.Text = "Category : ";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(btndelete);
            Controls.Add(txtSearch);
            Controls.Add(Label3);
            Controls.Add(btnnew);
            Controls.Add(btnsave);
            Controls.Add(dtglist);
            Controls.Add(txtDeweyDecimal);
            Controls.Add(Label4);
            Controls.Add(txtCategory);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategory";
            Text = "frmCategory";
            ((System.ComponentModel.ISupportInitialize)dtglist).EndInit();
            Load += new EventHandler(frmCategory_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Button btndelete;
        internal TextBox txtSearch;
        internal Label Label3;
        internal Button btnnew;
        internal Button btnsave;
        internal DataGridView dtglist;
        internal TextBox txtDeweyDecimal;
        internal Label Label4;
        internal TextBox txtCategory;
        internal Label Label2;
    }
}