using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmUser : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            dtg_listUser = new DataGridView();
            dtg_listUser.CellClick += new DataGridViewCellEventHandler(dtg_listUser_CellClick);
            dtg_listUser.Click += new EventHandler(dtg_listUser_Click);
            dtg_listUser.DoubleClick += new EventHandler(dtg_listUser_DoubleClick);
            btn_saveuser = new Button();
            btn_saveuser.Click += new EventHandler(btn_saveuser_Click);
            btn_update = new Button();
            btn_update.Click += new EventHandler(btn_update_Click);
            btn_New = new Button();
            btn_New.Click += new EventHandler(btn_close_Click);
            Label4 = new Label();
            txt_name = new TextBox();
            Label3 = new Label();
            txt_username = new TextBox();
            Label2 = new Label();
            txt_pass = new TextBox();
            Label1 = new Label();
            cbo_type = new ComboBox();
            lbl_id = new Label();
            lbl_id.TextChanged += new EventHandler(lbl_id_TextChanged);
            btn_delete = new Button();
            btn_delete.Click += new EventHandler(btn_delete_Click);
            ((System.ComponentModel.ISupportInitialize)dtg_listUser).BeginInit();
            SuspendLayout();
            // 
            // dtg_listUser
            // 
            dtg_listUser.AllowUserToAddRows = false;
            dtg_listUser.AllowUserToDeleteRows = false;
            dtg_listUser.AllowUserToResizeColumns = false;
            dtg_listUser.AllowUserToResizeRows = false;
            dtg_listUser.Anchor = AnchorStyles.Top;
            dtg_listUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_listUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_listUser.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtg_listUser.Location = new Point(12, 185);
            dtg_listUser.Name = "dtg_listUser";
            dtg_listUser.RowHeadersVisible = false;
            dtg_listUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_listUser.Size = new Size(835, 267);
            dtg_listUser.TabIndex = 58;
            // 
            // btn_saveuser
            // 
            btn_saveuser.Anchor = AnchorStyles.Top;
            btn_saveuser.BackColor = Color.Transparent;
            btn_saveuser.BackgroundImageLayout = ImageLayout.Stretch;
            btn_saveuser.Cursor = Cursors.Hand;
            btn_saveuser.FlatStyle = FlatStyle.Flat;
            btn_saveuser.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_saveuser.Location = new Point(288, 126);
            btn_saveuser.Name = "btn_saveuser";
            btn_saveuser.Size = new Size(76, 53);
            btn_saveuser.TabIndex = 50;
            btn_saveuser.Text = "Save";
            btn_saveuser.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top;
            btn_update.BackgroundImageLayout = ImageLayout.Stretch;
            btn_update.Cursor = Cursors.Hand;
            btn_update.Enabled = false;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.Location = new Point(365, 126);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(76, 53);
            btn_update.TabIndex = 52;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_New
            // 
            btn_New.Anchor = AnchorStyles.Top;
            btn_New.BackColor = Color.Transparent;
            btn_New.BackgroundImageLayout = ImageLayout.Stretch;
            btn_New.Cursor = Cursors.Hand;
            btn_New.FlatStyle = FlatStyle.Flat;
            btn_New.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_New.Location = new Point(519, 126);
            btn_New.Name = "btn_New";
            btn_New.Size = new Size(76, 53);
            btn_New.TabIndex = 55;
            btn_New.Text = "New";
            btn_New.UseVisualStyleBackColor = false;
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Top;
            Label4.AutoSize = true;
            Label4.BackColor = Color.White;
            Label4.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Image = (Image)resources.GetObject("Label4.Image");
            Label4.ImageAlign = ContentAlignment.TopCenter;
            Label4.Location = new Point(231, 93);
            Label4.Name = "Label4";
            Label4.Size = new Size(42, 17);
            Label4.TabIndex = 53;
            Label4.Text = "Type :";
            // 
            // txt_name
            // 
            txt_name.Anchor = AnchorStyles.Top;
            txt_name.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.Location = new Point(288, 12);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(322, 25);
            txt_name.TabIndex = 44;
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Top;
            Label3.AutoSize = true;
            Label3.BackColor = Color.White;
            Label3.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.Image = (Image)resources.GetObject("Label3.Image");
            Label3.ImageAlign = ContentAlignment.TopCenter;
            Label3.Location = new Point(208, 67);
            Label3.Name = "Label3";
            Label3.Size = new Size(71, 17);
            Label3.TabIndex = 51;
            Label3.Text = "Password :";
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top;
            txt_username.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(288, 39);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(322, 25);
            txt_username.TabIndex = 45;
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.BackColor = Color.White;
            Label2.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Image = (Image)resources.GetObject("Label2.Image");
            Label2.ImageAlign = ContentAlignment.TopCenter;
            Label2.Location = new Point(205, 41);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 17);
            Label2.TabIndex = 48;
            Label2.Text = "Username :";
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.Top;
            txt_pass.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pass.Location = new Point(288, 67);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(322, 25);
            txt_pass.TabIndex = 46;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.BackColor = Color.White;
            Label1.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ImageAlign = ContentAlignment.TopCenter;
            Label1.Location = new Point(231, 15);
            Label1.Name = "Label1";
            Label1.Size = new Size(50, 17);
            Label1.TabIndex = 47;
            Label1.Text = "Name :";
            // 
            // cbo_type
            // 
            cbo_type.Anchor = AnchorStyles.Top;
            cbo_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_type.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_type.FormattingEnabled = true;
            cbo_type.Items.AddRange(new object[] { "Librarian", "Assistant" });
            cbo_type.Location = new Point(288, 95);
            cbo_type.Name = "cbo_type";
            cbo_type.Size = new Size(322, 25);
            cbo_type.TabIndex = 49;
            // 
            // lbl_id
            // 
            lbl_id.Anchor = AnchorStyles.Top;
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(297, 15);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(19, 17);
            lbl_id.TabIndex = 56;
            lbl_id.Text = "id";
            lbl_id.Visible = false;
            // 
            // btn_delete
            // 
            btn_delete.Anchor = AnchorStyles.Top;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Enabled = false;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.Location = new Point(442, 126);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(76, 53);
            btn_delete.TabIndex = 57;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 464);
            Controls.Add(dtg_listUser);
            Controls.Add(btn_saveuser);
            Controls.Add(btn_update);
            Controls.Add(btn_New);
            Controls.Add(Label4);
            Controls.Add(txt_name);
            Controls.Add(Label3);
            Controls.Add(txt_username);
            Controls.Add(Label2);
            Controls.Add(txt_pass);
            Controls.Add(Label1);
            Controls.Add(cbo_type);
            Controls.Add(lbl_id);
            Controls.Add(btn_delete);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)dtg_listUser).EndInit();
            Load += new EventHandler(frm_adduser_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal DataGridView dtg_listUser;
        internal Button btn_saveuser;
        internal Button btn_update;
        internal Button btn_New;
        internal Label Label4;
        internal TextBox txt_name;
        internal Label Label3;
        internal TextBox txt_username;
        internal Label Label2;
        internal TextBox txt_pass;
        internal Label Label1;
        internal ComboBox cbo_type;
        internal Label lbl_id;
        internal Button btn_delete;
    }
}